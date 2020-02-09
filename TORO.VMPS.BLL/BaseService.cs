using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TORO.VMPS.IBLL;

namespace TORO.VMPS.BLL
{
    public abstract class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected abstract IRepository<TEntity> _reponsitory { get; }
        private readonly IMapper _mapper;
        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public virtual async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = DtoToEntity(dto);

            _reponsitory.Add(entity);

            await _unitOfWork.SaveAsync();

            return EntityToDto(entity);
        }

        public virtual async Task DeleteAsync(object id)
        {
            var entity = await _reponsitory.FindByIdAsync(id);

            if (entity == null) throw new Exception("Not found entity object with id: " + id);

            _reponsitory.Delete(entity);

            await _unitOfWork.SaveAsync();
        }

        public async Task<IQueryable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            var query = _reponsitory.Find(filter);
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return query;
        }

        public virtual async Task<TDto> FindByIdAsync(object id)
        {
            return EntityToDto(await _reponsitory.FindByIdAsync(id));
        }

        public async Task<IQueryable<TEntity>> SearchAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var query = _reponsitory.Search(predicate);
            return query;
        }

        public virtual async Task<TDto> UpdateAsync(TDto dto)
        {
            var entity = DtoToEntity(dto);

            _reponsitory.Update(entity);

            await _unitOfWork.SaveAsync();

            return EntityToDto(entity);
        }

        protected TDto EntityToDto(TEntity entity)
        {
            return _mapper.Map<TDto>(entity);
            // var config = new MapperConfiguration(cfg => cfg.CreateMap<TDto, TEntity>());
            // //var mapper = config.CreateMapper();
            // // or
            // var mapper = new Mapper(config);
            ////OrderDto dto = mapper.Map<TDto>(entity);
            // return mapper.Map<TDto>(entity);
        }

        protected TEntity DtoToEntity(TDto dto)
        {
            return _mapper.Map<TEntity>(dto);
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TDto>());
            //var mapper = new Mapper(config);
            //return mapper.Map<TEntity>(dto);
        }

        protected TEntity DtoToEntity(TDto dto, TEntity entity)
        {
            return _mapper.Map(dto, entity);
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TDto>());
            //var mapper = new Mapper(config);
            //return mapper.Map(dto, entity);
        }

        protected IEnumerable<TDto> EntityToDto(IEnumerable<TEntity> entities)
        {
            return _mapper.Map<IEnumerable<TDto>>(entities);
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<TDto, TEntity>());
            //var mapper = new Mapper(config);
            //return mapper.Map<IEnumerable<TDto>>(entities);
        }

        protected IEnumerable<TEntity> DtoToEntity(IEnumerable<TDto> dto)
        {
            return _mapper.Map<IEnumerable<TEntity>>(dto);
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<TEntity, TDto>());
            //var mapper = new Mapper(config);
            //return mapper.Map<IEnumerable<TEntity>>(dto);
        }
    }
}

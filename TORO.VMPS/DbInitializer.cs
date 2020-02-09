using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TORO.VMPS.DAL.DbContexts;

namespace TORO.VMPS
{
    public static class DbInitializer
    {
        public static void Initialize(CourseLibraryContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

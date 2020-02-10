using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TORO.VMPS.DAL.Entities;

namespace TORO.VMPS.DAL.DbContexts
{
    public class CourseLibraryContext : DbContext
    {
        public CourseLibraryContext(DbContextOptions<CourseLibraryContext> options)
           : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<TransactionsCash> TransactionCashes { get; set; }
        public DbSet<TransactionsCashDetail> TransactionCashDetails { get; set; }
        public DbSet<TransactionsPaymentOrder> TransactionsPaymentOrders { get; set; }
        public DbSet<TransactionsTopup> TransactionsTopups { get; set; }
        public DbSet<TransactionsPaymentRefund> TransactionsPaymentRefund { get; set; }
        public DbSet<TransactionsPaymentToro> TransactionsPaymentToro { get; set; }
        public DbSet<TransactionsPaymentMomo> TransactionsPaymentMomo { get; set; }
        public DbSet<TransactionsPaymentGrab> TransactionsPaymentGrab { get; set; }
        public DbSet<TransactionsPaymentZalo> TransactionsPaymentZalo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

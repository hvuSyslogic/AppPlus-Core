using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;
using System.Threading;

namespace AppPlus.Core
{
    public partial class DbContextBase : DbContext
    {
        static DbContextBase()
        {
            Database.SetInitializer<DbContextBase>(null);
        }

        public DbContextBase()
            : base("Default")
        {
        }

        public DbContextBase(string connectionString)
            : base(string.Format("Name={0}", connectionString))
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override int SaveChanges()
        {            
            //var addedEntryCollection = ChangeTracker.Entries()
            //    .Where(x => x != null)
            //    .Where(x => x.State == EntityState.Added)
            //    .Where(x => x.Entity is IAuditableEntity)
            //    ;

            //var modifiedEntryCollection = ChangeTracker.Entries()
            //    .Where(x => x != null)
            //    .Where(x => x.State == EntityState.Modified)
            //    .Where(x => x.Entity is IAuditableEntity)
            //    ;

            //string identityName = Thread.CurrentPrincipal.Identity.Name;
            //DateTime now = DateTime.UtcNow;

            //foreach (var entry in addedEntryCollection)
            //{
            //    IAuditableEntity entity = entry.Entity as IAuditableEntity;
            //    if (entity != null)
            //    {
            //        entity.CreatedBy = identityName;
            //        entity.CreatedDate = now;
            //        entity.UpdatedBy = identityName;
            //        entity.UpdatedDate = now;
            //    }
            //}

            //foreach (var entry in modifiedEntryCollection)
            //{
            //    IAuditableEntity entity = entry.Entity as IAuditableEntity;
            //    if (entity != null)
            //    {
            //        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
            //        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
            //        entity.UpdatedBy = identityName;
            //        entity.UpdatedDate = now;
            //    }
            //}

            return base.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Domain
{
    public class HisDbContext :  DbContext
    {
        static HisDbContext()
        {
            Database.SetInitializer<HisDbContext>(null);
        }

        public HisDbContext()
            : base("Default")
        {
        }

        public HisDbContext(string connectionString)
            : base(string.Format("Name={0}", connectionString))
        {
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {                      
            modelBuilder.Configurations.AddFromAssembly(typeof(BS.BsGfxe).Assembly);
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

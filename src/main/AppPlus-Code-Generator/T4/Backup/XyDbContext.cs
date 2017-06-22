namespace Xy.Pis.Domain
{


    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.24.0.0")]
    public partial class XyDbContext : System.Data.Entity.DbContext, IXyDbContext
    {
        public System.Data.Entity.DbSet<BsItem> BsItems { get; set; } // BsItem
        public System.Data.Entity.DbSet<BsLocation> BsLocations { get; set; } // BsLocation

        static XyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<XyDbContext>(null);
        }

        public XyDbContext()
            : base("Name=AppPlus.His")
        {
            InitializePartial();
        }

        public XyDbContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public XyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public XyDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public XyDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BsItemMap());
            modelBuilder.Configurations.Add(new BsLocationMap());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new BsItemMap(schema));
            modelBuilder.Configurations.Add(new BsLocationMap(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}

using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class CkMachineMap : EntityTypeConfiguration<CkMachine>
    {
        public CkMachineMap()
            : this("dbo")
        {
        }

        public CkMachineMap(string schema)
        {
            ToTable("CKMachine", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TestTypeId).HasColumnName(@"TestTypeID").IsRequired().HasColumnType("int");
            Property(x => x.TypeNum).HasColumnName(@"TypeNum").IsOptional().HasColumnType("int");
            Property(x => x.MachineNum).HasColumnName(@"MachineNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.FirstSampleNum).HasColumnName(@"FirstSampleNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.LastSampleNum).HasColumnName(@"LastSampleNum").IsOptional().HasColumnType("nvarchar").HasMaxLength(14);
            Property(x => x.SampleBeginDate).HasColumnName(@"SampleBeginDate").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsOptional().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsOptional().HasColumnType("smallint");
        }
    }
}

using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class BsFamilyMap : EntityTypeConfiguration<BsFamily>
    {
        public BsFamilyMap()
            : this("dbo")
        {
        }

        public BsFamilyMap(string schema)
        {
            ToTable("BsFamily", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"ID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Code).HasColumnName(@"Code").IsRequired().IsUnicode(false).HasColumnType("varchar").HasMaxLength(12);
            Property(x => x.CommitteeId).HasColumnName(@"CommitteeId").IsRequired().HasColumnType("int");
            Property(x => x.Name).HasColumnName(@"Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.AddressHome).HasColumnName(@"AddressHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.PhoneHome).HasColumnName(@"PhoneHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.PostCodeHome).HasColumnName(@"PostCodeHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(7);
            Property(x => x.AreaCodeHome).HasColumnName(@"AreaCodeHome").IsRequired().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.TotalPersons).HasColumnName(@"TotalPersons").IsRequired().HasColumnType("smallint");
            Property(x => x.HousePersons).HasColumnName(@"HousePersons").IsRequired().HasColumnType("smallint");
            Property(x => x.WorkingPersons).HasColumnName(@"WorkingPersons").IsRequired().HasColumnType("smallint");
            Property(x => x.LsFamilyType).HasColumnName(@"LsFamilyType").IsRequired().HasColumnType("smallint");
            Property(x => x.LsPeriod).HasColumnName(@"LsPeriod").IsRequired().HasColumnType("smallint");
            Property(x => x.LsHouseType).HasColumnName(@"LsHouseType").IsRequired().HasColumnType("smallint");
            Property(x => x.Acreage).HasColumnName(@"Acreage").IsRequired().HasColumnType("smallint");
            Property(x => x.LsFuel).HasColumnName(@"LsFuel").IsRequired().HasColumnType("smallint");
            Property(x => x.LsWarm).HasColumnName(@"LsWarm").IsRequired().HasColumnType("smallint");
            Property(x => x.LsCold).HasColumnName(@"LsCold").IsRequired().HasColumnType("smallint");
            Property(x => x.LsWater).HasColumnName(@"LsWater").IsRequired().HasColumnType("smallint");
            Property(x => x.LsSaniFamily).HasColumnName(@"LsSaniFamily").IsRequired().HasColumnType("smallint");
            Property(x => x.LsSaniPerson).HasColumnName(@"LsSaniPerson").IsRequired().HasColumnType("smallint");
            Property(x => x.LsSaniHabit).HasColumnName(@"LsSaniHabit").IsRequired().HasColumnType("smallint");
            Property(x => x.LsNeighbourhood).HasColumnName(@"LsNeighbourhood").IsRequired().HasColumnType("smallint");
            Property(x => x.LsWc).HasColumnName(@"LsWC").IsRequired().HasColumnType("smallint");
            Property(x => x.IsHealthBin).HasColumnName(@"IsHealthBin").IsRequired().HasColumnType("bit");
            Property(x => x.LsIncome).HasColumnName(@"LsIncome").IsRequired().HasColumnType("smallint");
            Property(x => x.Memo).HasColumnName(@"Memo").IsRequired().HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.PyCode).HasColumnName(@"PyCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.WbCode).HasColumnName(@"WbCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(6);
            Property(x => x.OrderBy).HasColumnName(@"OrderBy").IsRequired().HasColumnType("smallint");
            Property(x => x.OperTime).HasColumnName(@"OperTime").IsRequired().HasColumnType("smalldatetime");
            Property(x => x.OperId).HasColumnName(@"OperID").IsRequired().HasColumnType("int");
            Property(x => x.IsActive).HasColumnName(@"IsActive").IsRequired().HasColumnType("bit");
            Property(x => x.InActiveReason).HasColumnName(@"InActiveReason").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.InActiveTime).HasColumnName(@"InActiveTime").IsOptional().HasColumnType("smalldatetime");
            Property(x => x.InActiveOperId).HasColumnName(@"InActiveOperID").IsOptional().HasColumnType("int");
            Property(x => x.IconIndex).HasColumnName(@"IconIndex").IsRequired().HasColumnType("smallint");
            Property(x => x.RoadId).HasColumnName(@"RoadId").IsOptional().HasColumnType("int");
            Property(x => x.IsSign).HasColumnName(@"IsSign").IsOptional().HasColumnType("bit");
            Property(x => x.IsCareMan).HasColumnName(@"IsCareMan").IsOptional().HasColumnType("smallint");
            Property(x => x.SignDoctorId).HasColumnName(@"SignDoctorId").IsOptional().HasColumnType("int");
            Property(x => x.SignGroupId).HasColumnName(@"SignGroupId").IsOptional().HasColumnType("int");
        }
    }
}

using HisPlus.Domain;
using System.Data.Entity.ModelConfiguration;

namespace HisPlus.Domain.Mapping
{
    public class OugetreginfoMap : EntityTypeConfiguration<Ougetreginfo>
    {
        public OugetreginfoMap()
            : this("dbo")
        {
        }

        public OugetreginfoMap(string schema)
        {
            ToTable("OUGETREGINFO", schema);
            HasKey(x => new { x.Doctorid, x.Doctorname, x.Doctortitle, x.Regfee, x.Treatfee });

            Property(x => x.Doctorid).HasColumnName(@"DOCTORID").IsRequired().HasColumnType("int");
            Property(x => x.Doctorname).HasColumnName(@"DOCTORNAME").IsRequired().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Doctortitle).HasColumnName(@"DOCTORTITLE").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Timereginfolist).HasColumnName(@"TIMEREGINFOLIST").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Regdate).HasColumnName(@"REGDATE").IsOptional().HasColumnType("datetime");
            Property(x => x.Regweekday).HasColumnName(@"REGWEEKDAY").IsOptional().HasColumnType("int");
            Property(x => x.Regtotalcount).HasColumnName(@"REGTOTALCOUNT").IsOptional().HasColumnType("int");
            Property(x => x.Regleavecount).HasColumnName(@"REGLEAVECOUNT").IsOptional().HasColumnType("int");
            Property(x => x.Totalfee).HasColumnName(@"TOTALFEE").IsOptional().HasColumnType("int");
            Property(x => x.Regfee).HasColumnName(@"REGFEE").IsRequired().HasColumnType("numeric").HasPrecision(18,2);
            Property(x => x.Treatfee).HasColumnName(@"TREATFEE").IsRequired().HasColumnType("numeric").HasPrecision(18,2);
            Property(x => x.Istimereg).HasColumnName(@"ISTIMEREG").IsOptional().HasColumnType("int");
            Property(x => x.Shifttype).HasColumnName(@"SHIFTTYPE").IsOptional().HasColumnType("int");
            Property(x => x.Regstatus).HasColumnName(@"REGSTATUS").IsOptional().HasColumnType("int");
            Property(x => x.Timereginfo).HasColumnName(@"TIMEREGINFO").IsOptional().HasColumnType("nvarchar").HasMaxLength(100);
            Property(x => x.Starttime).HasColumnName(@"STARTTIME").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Timeend).HasColumnName(@"TIMEEND").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Regtotalcount1).HasColumnName(@"REGTOTALCOUNT1").IsOptional().HasColumnType("int");
            Property(x => x.Regleavecount1).HasColumnName(@"REGLEAVECOUNT1").IsOptional().HasColumnType("int");
            Property(x => x.Locationid).HasColumnName(@"LOCATIONID").IsOptional().HasColumnType("int");
            Property(x => x.Iscancel).HasColumnName(@"ISCANCEL").IsOptional().HasColumnType("smallint");
            Property(x => x.Onlyid).HasColumnName(@"ONLYID").IsOptional().HasColumnType("nvarchar").HasMaxLength(20);
            Property(x => x.Roomname).HasColumnName(@"ROOMNAME").IsOptional().HasColumnType("nvarchar").HasMaxLength(40);
        }
    }
}

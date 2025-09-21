


namespace G_4_DAL.Data.Configurations
{
   public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(d => d.Id).UseIdentityColumn(10,10);
            builder.Property(d => d.Name).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(d => d.Code).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(d => d.createOn).HasDefaultValue("GetDate()");
            builder.Property(d => d.LastModifiedBy).HasComputedColumnSql("GetDate()");
        }
    }
}

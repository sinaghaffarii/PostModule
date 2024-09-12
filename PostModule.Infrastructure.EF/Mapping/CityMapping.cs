

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.CityEntity;

namespace PostModule.Infrastructure.EF.Mapping
{
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("cities");
            builder.HasKey(b => b.id);

            builder.Property(b => b.Title).IsRequired(true).HasMaxLength(150);
            builder.HasOne(b => b.State).WithMany(s => s.Cities).HasForeignKey(c => c.StateId);
        

      
        }
    }
}

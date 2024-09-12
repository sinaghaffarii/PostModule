using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PostModule.Domain.StateEntity;


namespace PostModule.Infrastructure.EF.Mapping
{
    public class StateMapping : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("states");
            builder.HasKey(b => b.id);

            builder.Property(b => b.Title).IsRequired(true).HasMaxLength(155);
            builder.Property(b => b.CloseStates).IsRequired(false).HasMaxLength(90);
            builder.Property(b => b.CreateDate).IsRequired(true);

            builder.HasMany(b => b.Cities).WithOne(c => c.State).HasForeignKey(c => c.StateId);
        }
    }
}

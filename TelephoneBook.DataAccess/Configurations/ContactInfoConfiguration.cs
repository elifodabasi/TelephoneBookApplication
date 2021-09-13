using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TelephoneBook.Entity;

namespace TelephoneBook.DataAccess.Configurations
{
    public class ContactInfoConfiguration : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.ToTable("ContactInfos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.PhoneNumber);
            builder.Property(x => x.EmailAddress);
            builder.Property(x => x.Location);
            builder.Property(x => x.InfoContext);

        }
    }
}

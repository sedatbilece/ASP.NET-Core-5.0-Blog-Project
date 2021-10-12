using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");// table name

            builder.HasKey(u=> u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.HasIndex(u => u.Email).IsUnique();// email use one , mean dont repeat email


            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Username).HasMaxLength(20);
            builder.HasIndex(u => u.Username).IsUnique();


            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");

            builder.Property(u => u.Description).HasMaxLength(500);


            builder.Property(u => u.Name).IsRequired();
            builder.Property(u => u.Name).HasMaxLength(30);
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(30);


            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);


            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(u => u.RoleId);


            //same as all
            builder.Property(u => u.CreatedByName).IsRequired();

            builder.Property(u=> u.CreatedByName).HasMaxLength(50);

            builder.Property(u => u.ModifiedByName).IsRequired();

            builder.Property(u=> u.ModifiedByName).HasMaxLength(50);

            builder.Property(u=> u.CreatedDate).IsRequired();

            builder.Property(u=> u.ModifiedDate).IsRequired();

            builder.Property(u=> u.IsActive).IsRequired();

            builder.Property(u=> u.IsDeleted).IsRequired();

            builder.Property(u=> u.Note).HasMaxLength(500);


        }
    }
}

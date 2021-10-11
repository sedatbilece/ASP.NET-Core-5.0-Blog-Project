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
    public class ArticleMap : IEntityTypeConfiguration<Article>//this interface need for mapping
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");// table name

            builder.HasKey(a => a.Id); //id is a primary key

            builder.Property(a => a.Id).ValueGeneratedOnAdd();// id upgrading

            builder.Property(a => a.Title).HasMaxLength(100);//title length could be max 100

            builder.Property(a => a.Title).IsRequired();//title is required

            builder.Property(a => a.Content).IsRequired();

            builder.Property(a => a.Content).HasColumnType("NVARCHAR(MAX)");// for column type

            builder.Property(a => a.Date).IsRequired();

            builder.Property(a => a.SeoAuthor).IsRequired();

            builder.Property(a => a.SeoAuthor).HasMaxLength(50);

            builder.Property(a => a.SeoDescription).HasMaxLength(150);

            builder.Property(a => a.SeoDescription).IsRequired();

            builder.Property(a => a.SeoTags).HasMaxLength(150);

            builder.Property(a => a.SeoTags).IsRequired();

            builder.Property(a => a.ViewsCount).IsRequired();

            builder.Property(a => a.CommentsCount).IsRequired();

            builder.Property(a => a.Thumbnail).IsRequired();

            builder.Property(a => a.Thumbnail).HasMaxLength(250);

            builder.Property(a => a.CreatedByName).IsRequired();

            builder.Property(a => a.CreatedByName).HasMaxLength(50);

            builder.Property(a => a.ModifiedByName).IsRequired();

            builder.Property(a => a.ModifiedByName).HasMaxLength(50);

            builder.Property(a => a.CreatedDate).IsRequired();

            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.Property(a => a.IsActive).IsRequired();

            builder.Property(a => a.IsDeleted).IsRequired();

            builder.Property(a => a.Note).HasMaxLength(500);


            // relation with  the other entity

            builder.HasOne<Category>(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);
            //one article has a one category but one category has more article 


            builder.HasOne<User>(a => a.User).WithMany(u => u.Articles).HasForeignKey(a => a.UserId);

        }
    }
}

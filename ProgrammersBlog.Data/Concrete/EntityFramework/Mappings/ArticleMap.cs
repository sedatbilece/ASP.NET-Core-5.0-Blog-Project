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



            builder.HasData(
                new Article
                {
                    Id=1,
                    CategoryId=1,
                    Title="C# yenilikleri",
                    Content = "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir." +
                    " Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere" +
                    " bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler " +
                    "olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden " +
                    "elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının" +
                    " yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık " +
                    "yazılımları ile popüler olmuştur.",
                    Thumbnail="default.jpg",
                    SeoDescription="c# 9.0 yenilikler",
                    SeoTags="c#, c# 9 , inet ,.net 5",
                    SeoAuthor="Sedat Bilece",
                    Date=DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "deneme notu",
                    UserId  =1,
                    ViewsCount=100,
                    CommentsCount=1


                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    Title = "Python yenilikleri",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "c# 9.0 yenilikler",
                    SeoTags = "Python Python  , Python 3 ,Python 5",
                    SeoAuthor = "Sedat Bilece",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "deneme notu",
                    UserId = 1,
                    ViewsCount = 200,
                    CommentsCount = 1

                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Javascript yenilikleri",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "c# 9.0 yenilikler",
                    SeoTags = "Javascript Javascript  , Javascript 3 ,Javascript 5",
                    SeoAuthor = "Sedat Bilece",
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreate",
                    ModifiedDate = DateTime.Now,
                    Note = "deneme notu",
                    UserId = 1,
                    ViewsCount = 500,
                    CommentsCount = 1

                }
                );
        }
    }
}

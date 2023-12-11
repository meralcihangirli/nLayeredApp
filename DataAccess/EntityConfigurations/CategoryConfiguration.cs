using Entitites.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories").HasKey(b => b.Id);
            builder.Property(b => b.Id ).HasColumnName("CategoryId").IsRequired(); 
            builder.Property(b => b.CategoryName).HasColumnName("CategoryName").IsRequired();
            builder.HasIndex(indexExpression: b => b.CategoryName, name: "UK_Categories_Name").IsUnique();
            builder.HasMany(b => b.Products);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);//queryfilter.veri siilinmez onun yerine silinme tarihini verir.Deleteddate yoksa veriyi getirr.deleteddate null olanları getir
        }
    }
}
/*Bu C# kod parçası, bir Category sınıfının veritabanı tablosunu oluşturmak ve yapılandırmak için Entity Framework Core kullanarak yapılmış gibi görünüyor. Bu kodun Configure metodu, EntityTypeBuilder<Category> sınıfını kullanarak Category sınıfına ait veritabanı şemasının nasıl yapılandırılacağını belirtiyor.

Kodun anlamı şu şekildedir:

builder.ToTable("Categories").HasKey(b => b.Id);: Veritabanında "Categories" adında bir tablo oluşturulur ve bu tablonun anahtar alanı (Id özelliği) belirlenir.

builder.Property(b => b.Id ).HasColumnName("CategoryId").IsRequired();: Id özelliği için "CategoryId" sütun adıyla bir veritabanı sütunu oluşturulur ve bu alan zorunlu hale getirilir.

builder.Property(b => b.CategoryName).HasColumnName("CategoryName").IsRequired();: CategoryName özelliği için "CategoryName" adında bir veritabanı sütunu oluşturulur ve bu alan zorunlu hale getirilir.

builder.HasIndex(indexExpression: b => b.CategoryName, name: "UK_Categories_Name").IsUnique();: "CategoryName" alanı için "UK_Categories_Name" adında benzersiz bir index oluşturulur.

builder.HasMany(b => b.Products);: Category sınıfının birden fazla Product öğesini içerebileceğini belirtir. Bu, Category ve Product arasında bir ilişki olduğunu gösterir.

builder.HasQueryFilter(b => !b.DeletedDate.HasValue);: Bu, "DeletedDate" alanı değeri null olan (HasValue olmayan) Category kayıtlarını getirmek için bir sorgu filtresi uygular. Yani, DeletedDate değeri null olanları alır, yani silinmemiş olanları getirir.

Bu kod, Category ve Product arasında bir ilişki kurarak ve Category öğeleri için bir silme tarihi kontrolü uygulayarak veritabanı modelini yapılandırmayı amaçlar. */
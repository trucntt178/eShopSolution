using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                new CategoryTranslation()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Giày nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "giay-nu",
                    SeoDescription = "Sản phẩm giày nữ",
                    SeoTitle = "Sản phẩm giày nữ"
                },
                new CategoryTranslation()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Women's shoes",
                    LanguageId = "en-US",
                    SeoAlias = "womens-shoes",
                    SeoDescription = "The shoes products for women",
                    SeoTitle = "The shoes products for women"
                },
                new CategoryTranslation()
                {
                    Id = 3,
                    CategoryId = 2,
                    Name = "Giày nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "giay-nam",
                    SeoDescription = "Sản phẩm giày nam",
                    SeoTitle = "Sản phẩm giày nam"
                },
                new CategoryTranslation()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Men's shoes",
                    LanguageId = "en-US",
                    SeoAlias = "mens-shoes",
                    SeoDescription = "The shoes products for men",
                    SeoTitle = "The shoes products for men"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0
                }
                );

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Giày nữ Bitis",
                    LanguageId = "vi-VN",
                    SeoAlias = "giay-nu-bitis",
                    SeoDescription = "Giày nữ Bitis",
                    SeoTitle = "Giày nữ Bitis",
                    Description = "Giày nữ Bitis",
                    Details = "Giày nữ Bitis"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Bitis women's shoes",
                    LanguageId = "en-US",
                    SeoAlias = "bitis-womens-shoes",
                    SeoDescription = "Bitis women's shoes",
                    SeoTitle = "Bitis women's shoes",
                    Description = "Bitis women's shoes",
                    Details = "Bitis women's shoes"
                }
                );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { CategoryId = 1, ProductId = 1 }
                );

            // any guid
            var roleId = new Guid("D330221B-8576-46EB-A5E4-94C7AA8002E9");
            var adminId = new Guid("373198E4-A32B-40AC-8505-BF2D07E23B1B");

            modelBuilder.Entity<AppRole>().HasData(new AppRole()
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "trucntt178@gmail.com",
                NormalizedEmail = "trucntt178@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc123"),
                SecurityStamp = string.Empty,
                FirstName = "Truc",
                LastName = "Nguyen",
                Dob = new DateTime(2000, 8, 17)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
    }
}

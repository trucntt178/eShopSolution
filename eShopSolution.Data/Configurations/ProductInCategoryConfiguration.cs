﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(t => new { t.ProductId, t.CategoryId });

            builder.ToTable("ProductInCategories");

            builder.HasOne(t => t.Product).WithMany(p => p.ProductInCategories)
                .HasForeignKey(pc => pc.ProductId);
            builder.HasOne(t => t.Category).WithMany(c => c.ProductInCategories)
                .HasForeignKey(pc => pc.CategoryId);
        }
    }
}

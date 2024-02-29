using HepsiApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiApi.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new()
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                BrandId = 1,
                Discount = 10,
                Price = 1000,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Product product2 = new()
            {
                Id = 2,
                Title = "Test1",
                Description = "Tes1t",
                BrandId = 1,
                Discount = 10,
                Price = 1000,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            builder.HasData(product1,product2);
        }
    }
}

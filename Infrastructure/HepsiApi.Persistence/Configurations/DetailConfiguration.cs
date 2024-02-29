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
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Detail detail1 = new()
            {
                Id = 1,
                Title = "Ekran Panel Tipi",
                Description = "IPS",
                CategoryId = 10,
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = "Renk",
                Description = "Mika Gümüşü",
                CategoryId = 10,
                CreatedDate = DateTime.Now,
                IsDeleted = false,


            };
            Detail detail3 = new()
            {
                Id = 3,
                Title = "Ekran Kartı Bellek Tipi",
                Description = "GDDR6",
                CategoryId = 10,
                CreatedDate = DateTime.Now,
                IsDeleted = true,


            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}

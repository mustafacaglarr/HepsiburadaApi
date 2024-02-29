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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Elektronik",
                Priorty = 1,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                Priorty = 2,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category3 = new()
            {
                Id = 3,
                Name = "Ev,Yaşam,Kırtasiye,Ofis",
                Priorty = 3,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category4 = new()
            {
                Id = 4,
                Name = "Oto,Bahçe,Yapı Market",
                Priorty = 4,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category5 = new()
            {
                Id = 5,
                Name = "Anne,Bebek,Oyuncak",
                Priorty = 5,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category6 = new()
            {
                Id = 6,
                Name = "Spor,OutDoor",
                Priorty = 6,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category7 = new()
            {
                Id = 7,
                Name = "Kozmetik,Kişisel Bakım",
                Priorty = 7,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category8 = new()
            {
                Id = 8,
                Name = "Süpermarket, Pet Shop",
                Priorty = 8,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category category9 = new()
            {
                Id = 9,
                Name = "Kitap, Müziki,Film,Hobi",
                Priorty = 9,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            Category parent1 = new()
            {
                Id = 10,
                Name = "Bilgisayar",
                Priorty = 1,
                ParentId = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };
            Category parent2 = new()
            {
                Id = 11,
                Name = "Kadın",
                Priorty = 1,
                ParentId = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Now,
            };

            builder.HasData(category1, category2, category3, category4, category5, category6, category7, category8, category9, parent1, parent2);


        }
    }
}

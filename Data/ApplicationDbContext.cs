using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NotUseAuto.Models;
using Microsoft.AspNetCore.Identity;

namespace NotUseAuto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<WaitCategory> WaitCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            

            SeedUser(builder);

            SeedRole(builder);

            SeedUserRole(builder);
            
            Seed(builder);
        }



        private void Seed(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Mobile",
                    Description = "Mobile Phone"
                },
                new Category
                {
                    Id = 2,
                    Name = "Laptop",
                    Description = "Laptop"
                },
                new Category
                {
                    Id = 3,
                    Name = "Tablet",
                    Description = "Tablet"
                }
                );
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Iphone 11",
                    Price = 1000,
                    Quantity = 10,
                    Description = "Iphone 11",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "ROG",
                    Price = 2000,
                    Quantity = 20,
                    Description = "ROG STRIX",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Iphone 13",
                    Price = 3000,
                    Quantity = 30,
                    Description = "Iphone 13",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Name = "SamSungNote",
                    Price = 4000,
                    Quantity = 40,
                    Description = "SamSungNote",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 5,
                    Name = "Iphone 15",
                    Price = 5000,
                    Quantity = 50,
                    Description = "Iphone 15",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Name = "SAMSUNGTABLET",
                    Price = 6000,
                    Quantity = 60,
                    Description = "SAMSUNGTABLET",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 7,
                    Name = "Scar 17",
                    Price = 7000,
                    Quantity = 70,
                    Description = "Scar 17",
                    CategoryId = 2
                });
        }

        private void SeedUser(ModelBuilder builder)
        {
            //1. tạo tài khoản ban đầu để add vào DB
            var admin = new IdentityUser
            {
                Id = "1",
                UserName = "admin@fpt.com",
                Email = "admin@fpt.com",
                NormalizedUserName = "admin@fpt.com"
            };

            var customer = new IdentityUser
            {
                Id = "2",
                UserName = "customer@fpt.com",
                Email = "customer@fpt.com",
                NormalizedUserName = "customer@fpt.com"
            };

            //2. khai báo thư viện để mã hóa mật khẩu
            var hasher = new PasswordHasher<IdentityUser>();

            //3. thiết lập và mã hóa mật khẩu   từng tài khoản
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");

            builder.Entity<IdentityUser>().HasData(admin, customer);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                 new IdentityUserRole<string>
                 {
                     UserId = "1",
                     RoleId = "A"
                 },
                 new IdentityUserRole<string>
                 {
                     UserId = "2",
                     RoleId = "B"
                 }
              );

        }

        private void SeedRole(ModelBuilder builder)
        {
            //1. tạo các role cho hệ thống
            var admin = new IdentityRole
            {
                Id = "A",
                Name = "Administrator",
                NormalizedName = "Administrator"
            };
            var customer = new IdentityRole
            {
                Id = "B",
                Name = "Customer",
                NormalizedName = "Customer"
            };

            //2. add role vào trong DB
            builder.Entity<IdentityRole>().HasData(admin, customer);
        }
    }

}

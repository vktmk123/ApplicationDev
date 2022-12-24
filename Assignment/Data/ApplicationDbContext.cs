﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Request> Requests { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedAuthor(builder);
            SeedCategory(builder);
            SeedBook(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedUserRole(builder);

        }

        private void SeedAuthor(ModelBuilder builder)
        {
            builder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "Gosho AOYAMA",
                    Country = "Japan"
                },
                new Author
                {
                    Id = 2,
                    Name = "Fujiko F Fujio",
                    Country = "Japan"
                },
                new Author
                {
                    Id = 3,
                    Name = "Vu Trong Phung",
                    Country = "Viet Nam"
                },
                new Author
                {
                    Id = 4,
                    Name = "J. K. Rowling",
                    Country = "United States"
                }
                );
        }

       

        private void SeedUserRole(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "1",
                    RoleId = "1"
                },
                new IdentityUserRole<string>
                {
                    UserId = "2",
                    RoleId = "2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "3",
                    RoleId = "3"
                }
            );
        }

        private void SeedRole(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Admin",
                    NormalizedName = "Admin"
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Customer",
                    NormalizedName = "Customer"
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "StoreOwner",
                    NormalizedName = "StoreOwner"
                }
            );
        }

        private void SeedUser(ModelBuilder builder)
        {
            //tạo tài khoản test cho admin & customer
            var admin = new IdentityUser
            {
                Id = "1",
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com",
                NormalizedUserName = "admin@gmail.com"
            };
            var customer = new IdentityUser
            {
                Id = "2",
                Email = "customer@gmail.com",
                UserName = "customer@gmail.com",
                NormalizedUserName = "customer@gmail.com"
            };
            var storeOwner = new IdentityUser
            {
                Id = "3",
                Email = "storeowner@gmail.com",
                UserName = "storeowner@gmail.com",
                NormalizedUserName = "storeowner@gmail.com"
            };

            //khai báo thư viện để mã hóa mật khẩu cho user
            var hasher = new PasswordHasher<IdentityUser>();

            //set mật khẩu đã mã hóa cho từng user
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");
            storeOwner.PasswordHash = hasher.HashPassword(storeOwner, "123456");

            //add 2 tài khoản test vào bảng User
            builder.Entity<IdentityUser>().HasData(admin, customer, storeOwner);
        }


        private void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Conan",
                    Price = 5,
                    Image = "https://tuoitho.mobi/upload/doc-truyen/conan/anh-dai-dien.jpg",
                    Quantity = 30,
                    CategoryId = 1,
                    AuthorId = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Doremon",
                    Price = 3,
                    Image = "https://tuoitho.mobi/upload/truyen/doremon-truyen-ngan-tap-3/anh-bia.jpg",
                    Quantity = 30,
                    CategoryId = 1,
                    AuthorId = 2
                },
                new Book
                {
                    Id = 3,
                    Title = "Làm ĐĨ",
                    Price = 500,
                    Image = "https://sach86.com/wp-content/uploads/2020/10/Lam-Di.jpg",
                    Quantity = 30,
                    CategoryId = 3,
                    AuthorId = 2
                },
                new Book
                {
                    Id = 4,
                    Title = "The Hunger Games",
                    Price = 200,
                    Image = "https://cdn.vox-cdn.com/thumbor/dyjy2i3y73CS3m1uHvkgFMEJzqE=/1400x0/filters:no_upscale()/cdn.vox-cdn.com/uploads/chorus_asset/file/21960146/61JfGcL2ljL.jpg",
                    Quantity = 30,
                    CategoryId = 4,
                    AuthorId = 3

                },
                new Book
                {
                    Id = 5,
                    Title = "Harry Potter",
                    Price = 120,
                    Image = "http://prodimage.images-bn.com/pimages/9780545139700_p0_v5_s1200x630.jpg",
                    Quantity = 30,
                    CategoryId = 2,
                    AuthorId = 4
                },
                new Book
                {
                    Id = 6,
                    Title = "The Shining",
                    Price = 120,
                    Image = "http://prodimage.images-bn.com/pimages/9780345806789_p0_v2_s1200x630.jpg",
                    Quantity = 30,
                    CategoryId = 3,
                    AuthorId = 1
                },
                new Book
                {
                    Id = 7,
                    Title = "Cormoran Strike",
                    Price = 120,
                    Image = "https://salt.tikicdn.com/ts/product/17/22/0b/da2ced7d44ce084dd6b6dde1ce00b97a.jpg",
                    Quantity = 30,
                    CategoryId = 4,
                    AuthorId = 4
                }
                );
        }

        private void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Romance"
                },
                new Category
                {
                    Id = 2,
                    Name = "Comic"
                },
                new Category
                {
                    Id = 3,
                    Name = "Adventure"
                },
                new Category
                {
                    Id = 4,
                    Name = "Mystery"
                },
                new Category
                {
                    Id = 5,
                    Name = "Horror"
                },
                new Category
                {
                    Id = 6,
                    Name = "Sci-Fi"
                }
                );
        }
    }
}

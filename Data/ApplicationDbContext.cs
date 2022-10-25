using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NotUseAuto.Models;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;

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
        public DbSet<WaitCart> WaitCart { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WaitCart>().OwnsOne(x => x.CartItem);
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
                    Name = "Action",
                    Description = "Action"
                },
                new Category
                {
                    Id = 2,
                    Name = "Anime",
                    Description = "Anime"
                },
                new Category
                {
                    Id = 3,
                    Name = "Fantasy",
                    Description = "Fantasy"
                },
                new Category
                {
                    Id = 4,
                    Name = "Adventure",
                    Description = "Adventure"
                },
                new Category
                {
                    Id = 5,
                    Name = "Magic",
                    Description = "Magic"
                },
                new Category
                {
                    Id = 6,
                    Name = "Drama",
                    Description = "Drama"
                }
                );
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Black clover",
                    Price = 1000,
                    Quantity = 10,
                    Description = "The series focuses on Asta, a young orphan who is left to be raised in an orphanage alongside his fellow orphan, Yuno. While everyone is born with the ability to utilize mana in the form of magical power, Asta, with no magic however, instead focuses on physical strength.",
                    CategoryId = 1,
                    Image = "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "One Piece",
                    Price = 2000,
                    Quantity = 20,
                    Description = "One Piece is the story of Monkey D. Luffy, a young man who has a single dream: To find the legendary treasure known as the One Piece and become the King of the Pirates. Alongside a crew of trusted friends, Luffy sails the dangerous seas of the Grand Line to find Laugh Tale, the hidden island containing the One Piece.",
                    CategoryId = 2,
                    Image = "https://i.bloganchoi.com/bloganchoi.com/wp-content/uploads/2021/09/one-piece-live-action-netlfix-2-696x1044.jpg?fit=700%2C20000&quality=95&ssl=1"
                },
                new Product
                {
                    Id = 3,
                    Name = "Kimetsu No Yaiba",
                    Price = 3000,
                    Quantity = 30,
                    Description = "Demon Slayer: Kimetsu no Yaiba (鬼滅の刃, Kimetsu no Yaiba, \"Blade of Demon Destruction\") is a Japanese manga series written and illustrated by Koyoharu Gotouge. It follows teenage Tanjiro Kamado, who strives to become a demon slayer after his family was slaughtered and his younger sister, Nezuko, turned into a demon.",
                    CategoryId = 1,
                    Image = "https://cdnsg.kilala.vn/data/upload/article/5840/Kimetsu%20no%20Yaiba%20Mugen%20Ressha-hen%20(8).jpg"
                },
                new Product
                {
                    Id = 4,
                    Name = "Fairy tail",
                    Price = 4000,
                    Quantity = 40,
                    Description = "FAIRY TAIL is an anime series about a teen named Lucy (voiced by Cherami Leigh) who runs away with her new friend, Natsu (Todd Haberkorn), to join the well-known wizards guild, Fairy Tail.",
                    CategoryId = 3,
                    Image = "https://img1.ak.crunchyroll.com/i/spire2/f4ca1a545a471a9ce6e43eef8e8d72541539734102_main.jpg"
                },
                new Product
                {
                    Id = 5,
                    Name = "Onepuch man",
                    Price = 5000,
                    Quantity = 50,
                    Description = "One-Punch Man (Japanese: ワンパンマン, Hepburn: Wanpanman) is a Japanese superhero manga series created by One. It tells the story of Saitama, a superhero who, because he can defeat any opponent with a single punch, grows bored from a lack of challenge. One wrote the original webcomic manga version in early 2009.",
                    CategoryId = 1,
                    Image = "https://static.wikia.nocookie.net/onepunchman/images/2/27/Saitama.png/revision/latest?cb=20210530114318&path-prefix=vi"
                },
                new Product
                {
                    Id = 6,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 7,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 8,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 9,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 10,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 11,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 12,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 13,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 14,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 15,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 16,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 17,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 18,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 19,
                    Name = "Naruto",
                    Price = 6000,
                    Quantity = 60,
                    Description = "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.",
                    CategoryId = 3,
                    Image = "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg"
                },

                new Product
                {
                    Id = 20,
                    Name = "Hero academia",
                    Price = 7000,
                    Quantity = 70,
                    Description = "The series focuses on a middle school student Izuku Midoriya, who has no superpowers. Will he be able to become a hero and somehow to contribute to the peace and stability in the world, where the weak is the minority that needs to be defended.",
                    CategoryId = 2,
                    Image = "https://m.media-amazon.com/images/M/MV5BNzBlMDU5NzgtYTBiMC00ODYwLTg2YzItNTczYjY1OTRmNGFhXkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_.jpg"
                });
        }

        private void SeedUser(ModelBuilder builder)
        {
            //1. tạo tài khoản ban đầu để add vào DB
            var admin = new ApplicationUser
            {
                Id = "1",
                UserName = "hoanghip108@gmail.com",
                Email = "hoanghip108@gmail.com",
                NormalizedUserName = "hoanghip108@gmail.com",
                Image = "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/298710201_3244171855861409_1804411380120781534_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=174925&_nc_ohc=dFVC3HbeYfIAX-iPGLL&_nc_ht=scontent.fhan2-3.fna&oh=00_AT98b_w49sQ3jWECKsp8fsD50m1uGc981QkC8y0ES84L-g&oe=635B2C2B",
                DoB = "2000/08/10",
                Address = "Thái Nguyên",
                FullName = "Đỗ Nguyễn Huy Hoàng"
            };
            var admin2 = new ApplicationUser
            {
                Id = "2",
                UserName = "admin@fpt.com",
                Email = "admin@fpt.com",
                NormalizedUserName = "admin@fpt.com",
                Image = "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png",
                DoB = "2002/08/10",
                Address = "Hà Nội",
                FullName = "Trọng Đạt"
            };

            var customer = new ApplicationUser
            {
                Id = "3",
                UserName = "customer@fpt.com",
                Email = "customer@fpt.com",
                NormalizedUserName = "customer@fpt.com",
                Image = "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png",
                DoB = "2002/08/10",
                Address = "Phú Thọ",
                FullName = "Huy"

            };

            //2. khai báo thư viện để mã hóa mật khẩu
            var hasher = new PasswordHasher<ApplicationUser>();

            //3. thiết lập và mã hóa mật khẩu   từng tài khoản
            admin.PasswordHash = hasher.HashPassword(admin, "Hoanghandsome1");
            admin2.PasswordHash = hasher.HashPassword(admin2, "123456");
            customer.PasswordHash = hasher.HashPassword(customer, "123456");

            builder.Entity<ApplicationUser>().HasData(admin, customer, admin2);
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
                     RoleId = "A"
                 },
                 new IdentityUserRole<string>
                 {
                     UserId = "3",
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
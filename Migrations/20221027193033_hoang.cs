using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NotUseAuto.Migrations
{
    public partial class hoang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    DoB = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ProductName = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WaitCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaitCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    WaitCategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_WaitCategory_WaitCategoryId",
                        column: x => x.WaitCategoryId,
                        principalTable: "WaitCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(nullable: false),
                    WaitCart_ID = table.Column<int>(nullable: false),
                    productId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartItem_Product_productId",
                        column: x => x.productId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "A", "086a4771-540a-4e3d-9e37-e827a7728979", "Administrator", "Administrator" },
                    { "B", "7cca67a8-844b-4a1d-aa4d-3ca8542f9c17", "Customer", "Customer" },
                    { "O", "a170ce83-3630-417c-b5a5-dc8dd8321c94", "Owner", "Owner" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Address", "DoB", "FullName", "Image" },
                values: new object[,]
                {
                    { "1", 0, "9118c331-ea43-467e-9556-fcdc9db9f9e2", "ApplicationUser", "hoanghip108@gmail.com", false, false, null, null, "hoanghip108@gmail.com", "AQAAAAEAACcQAAAAEJoV0ll2vY80dM7DKd7xzt0jQFwebjUXoRqfApm00YRCnbRoMTbrDUBuRm2JvAEQ4g==", null, false, "f1a54ed3-6afa-405f-8c1f-43906ddc994c", false, "hoanghip108@gmail.com", "Thái Nguyên", "2000/08/10", "Đỗ Nguyễn Huy Hoàng", "https://scontent.fhan2-3.fna.fbcdn.net/v/t39.30808-6/298710201_3244171855861409_1804411380120781534_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=174925&_nc_ohc=dFVC3HbeYfIAX-iPGLL&_nc_ht=scontent.fhan2-3.fna&oh=00_AT98b_w49sQ3jWECKsp8fsD50m1uGc981QkC8y0ES84L-g&oe=635B2C2B" },
                    { "3", 0, "42f79553-2654-4b0f-8bc5-8ff412f4a6bd", "ApplicationUser", "customer@fpt.com", false, false, null, null, "customer@fpt.com", "AQAAAAEAACcQAAAAEJdzzx/xcj23PMNTcIZ/n3pNnJzsHS98hxkr2bODv3uZXFDGM+ToIciLmpEOTOp0FA==", null, false, "6856f684-e962-4d9f-840e-ad56c9d94330", false, "customer@fpt.com", "Phú Thọ", "2002/08/10", "Huy", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" },
                    { "2", 0, "f70b1419-8c3e-4355-b471-ae0afe5dd266", "ApplicationUser", "admin@fpt.com", false, false, null, null, "admin@fpt.com", "AQAAAAEAACcQAAAAEF68YFhwyhTLJqJaqWxgOuX0ZMw0axVCXOHFqrWhW96Je4KPqHhl02yFPDq6960gGA==", null, false, "d95de203-4ecc-41eb-91ba-81de276b9950", false, "admin@fpt.com", "Hà Nội", "2002/08/10", "Trọng Đạt", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" },
                    { "4", 0, "f7ed351e-f2a0-4893-a81b-0a574c71706a", "ApplicationUser", "quanghuy@fpt.com", false, false, null, null, "quanghuy@fpt.com", "AQAAAAEAACcQAAAAEPwNjw48jdt9D3vkpzgfVtJxB4O3aVmovSAc3rtr3m1pPtY4kiXD1z7RviCVYw94hg==", null, false, "59dabf3a-8bdc-49a2-a9b8-fa14a74c5b11", false, "quanghuy@fpt.com", "Hà Nội", "2002/02/18", "Dang Quang Huy", "https://www.alotintuc.com/wp-content/uploads/2021/07/Untitled-Capture2244-scaled-e1626766063525.jpg" },
                    { "5", 0, "fcd679e8-e517-4873-9883-0921d6f4e977", "ApplicationUser", "owner1@fpt.com", false, false, null, null, "owner1@fpt.com", "AQAAAAEAACcQAAAAEOVEiadILsSL54K0BnaoxYLMyAHMeAt8yGf9zBEVBq2kefBiENdI6exsLuioH1HnSA==", null, false, "427b53ae-a63f-4075-9cf9-0ed843061f9a", false, "owner1@fpt.com", "Phú Thọ", "2002/08/10", "Lan Phuong", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" },
                    { "6", 0, "86cd3791-9be1-41d2-acf4-904d2689b8a8", "ApplicationUser", "owner2@fpt.com", false, false, null, null, "owner2@fpt.com", "AQAAAAEAACcQAAAAEL89rFzXKopcbH7U6kvlWf3yXCqfYW6xcS5jPfJzhUgCgMJGhmB+T+Km38HJQ2jMNw==", null, false, "5a995e0d-5b5d-4e87-b497-b21a8dafbee9", false, "owner2@fpt.com", "Phú Thọ", "2002/08/10", "Truc My", "https://gamek.mediacdn.vn/133514250583805952/2020/7/11/narutossagemode-15944657133061535033027.png" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Description", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "Action", "Action", "Active" },
                    { 2, "Anime", "Anime", "Active" },
                    { 3, "Fantasy", "Fantasy", "Active" },
                    { 4, "Adventure", "Adventure", "Active" },
                    { 5, "Magic", "Magic", "Active" },
                    { 6, "Drama", "Drama", "Active" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1", "A" },
                    { "3", "B" },
                    { "2", "A" },
                    { "4", "A" },
                    { "5", "O" },
                    { "6", "O" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Quantity", "WaitCategoryId" },
                values: new object[,]
                {
                    { 17, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 16, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 15, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 14, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 13, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 12, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 11, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 10, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 9, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 6, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 7, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 18, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 4, 3, "FAIRY TAIL is an anime series about a teen named Lucy (voiced by Cherami Leigh) who runs away with her new friend, Natsu (Todd Haberkorn), to join the well-known wizards guild, Fairy Tail.", "https://img1.ak.crunchyroll.com/i/spire2/f4ca1a545a471a9ce6e43eef8e8d72541539734102_main.jpg", "Fairy tail", 4000m, 40, null },
                    { 20, 2, "The series focuses on a middle school student Izuku Midoriya, who has no superpowers. Will he be able to become a hero and somehow to contribute to the peace and stability in the world, where the weak is the minority that needs to be defended.", "https://m.media-amazon.com/images/M/MV5BNzBlMDU5NzgtYTBiMC00ODYwLTg2YzItNTczYjY1OTRmNGFhXkEyXkFqcGdeQXVyMzgxODM4NjM@._V1_.jpg", "Hero academia", 7000m, 70, null },
                    { 2, 2, "One Piece is the story of Monkey D. Luffy, a young man who has a single dream: To find the legendary treasure known as the One Piece and become the King of the Pirates. Alongside a crew of trusted friends, Luffy sails the dangerous seas of the Grand Line to find Laugh Tale, the hidden island containing the One Piece.", "https://i.bloganchoi.com/bloganchoi.com/wp-content/uploads/2021/09/one-piece-live-action-netlfix-2-696x1044.jpg?fit=700%2C20000&quality=95&ssl=1", "One Piece", 2000m, 20, null },
                    { 5, 1, "One-Punch Man (Japanese: ワンパンマン, Hepburn: Wanpanman) is a Japanese superhero manga series created by One. It tells the story of Saitama, a superhero who, because he can defeat any opponent with a single punch, grows bored from a lack of challenge. One wrote the original webcomic manga version in early 2009.", "https://static.wikia.nocookie.net/onepunchman/images/2/27/Saitama.png/revision/latest?cb=20210530114318&path-prefix=vi", "Onepuch man", 5000m, 50, null },
                    { 3, 1, "Demon Slayer: Kimetsu no Yaiba (鬼滅の刃, Kimetsu no Yaiba, \"Blade of Demon Destruction\") is a Japanese manga series written and illustrated by Koyoharu Gotouge. It follows teenage Tanjiro Kamado, who strives to become a demon slayer after his family was slaughtered and his younger sister, Nezuko, turned into a demon.", "https://cdnsg.kilala.vn/data/upload/article/5840/Kimetsu%20no%20Yaiba%20Mugen%20Ressha-hen%20(8).jpg", "Kimetsu No Yaiba", 3000m, 30, null },
                    { 1, 1, "The series focuses on Asta, a young orphan who is left to be raised in an orphanage alongside his fellow orphan, Yuno. While everyone is born with the ability to utilize mana in the form of magical power, Asta, with no magic however, instead focuses on physical strength.", "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg", "Black clover", 1000m, 10, null },
                    { 8, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null },
                    { 19, 3, "Naruto is a Japanese manga series written and illustrated by Masashi Kishimoto. It tells the story of Naruto Uzumaki, a young ninja who seeks recognition from his peers and dreams of becoming the Hokage, the leader of his village.", "https://m.media-amazon.com/images/I/81qb4I6rbsL._AC_SL1500_.jpg", "Naruto", 6000m, 60, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_OrderId",
                table: "CartItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_productId",
                table: "CartItem",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_WaitCategoryId",
                table: "Product",
                column: "WaitCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "WaitCategory");
        }
    }
}

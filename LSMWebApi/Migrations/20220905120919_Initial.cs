using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LSMWebApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bindings",
                columns: table => new
                {
                    Binding_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Binding_Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bindings", x => x.Binding_Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Shelves",
                columns: table => new
                {
                    Shelf_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shelf_Number = table.Column<int>(type: "int", nullable: false),
                    Floor_Number = table.Column<int>(type: "int", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelves", x => x.Shelf_Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Staff_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: " varchar(30)", nullable: true),
                    Last_Name = table.Column<string>(type: " varchar(30)", nullable: true),
                    Middle_Name = table.Column<string>(type: " varchar(30)", nullable: true),
                    Gender = table.Column<string>(type: " varchar(10)", nullable: true),
                    Designation = table.Column<string>(type: " varchar(30)", nullable: true),
                    Is_Admin = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: " varchar(50)", nullable: true),
                    Phone_Number = table.Column<string>(type: "varchar(15)", nullable: true),
                    Email = table.Column<string>(type: " varchar(30)", nullable: true),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Staff_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Books",
                columns: table => new
                {
                    BookISBN_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Binding_Id = table.Column<int>(type: "int", nullable: false),
                    Binding_Id1 = table.Column<int>(type: "int", nullable: true),
                    Category_Id = table.Column<int>(type: "int", nullable: false),
                    Category_Id1 = table.Column<int>(type: "int", nullable: true),
                    Shelf_Id = table.Column<int>(type: "int", nullable: false),
                    Shelf_Id1 = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "varchar(250)", nullable: true),
                    Author = table.Column<string>(type: "varchar(250)", nullable: true),
                    Edition = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "varchar(250)", nullable: true),
                    Year_Published = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Number_Actual_Copies = table.Column<int>(type: "int", nullable: false),
                    Number_Current_Copies = table.Column<int>(type: "int", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookISBN_Id);
                    table.ForeignKey(
                        name: "FK_Books_Bindings_Binding_Id1",
                        column: x => x.Binding_Id1,
                        principalTable: "Bindings",
                        principalColumn: "Binding_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Categories_Category_Id1",
                        column: x => x.Category_Id1,
                        principalTable: "Categories",
                        principalColumn: "Category_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Shelves_Shelf_Id1",
                        column: x => x.Shelf_Id1,
                        principalTable: "Shelves",
                        principalColumn: "Shelf_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id1 = table.Column<int>(type: "int", nullable: true),
                    First_Name = table.Column<string>(type: " varchar(30)", nullable: true),
                    Last_Name = table.Column<string>(type: " varchar(30)", nullable: true),
                    Middle_Name = table.Column<string>(type: " varchar(30)", nullable: true),
                    Gender = table.Column<string>(type: " varchar(10)", nullable: true),
                    Occupation = table.Column<string>(type: " varchar(30)", nullable: true),
                    Address = table.Column<string>(type: " varchar(50)", nullable: true),
                    Phone_Number = table.Column<string>(type: "varchar(15)", nullable: true),
                    Email = table.Column<string>(type: " varchar(30)", nullable: true),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK_Customers_Staffs_Staff_Id1",
                        column: x => x.Staff_Id1,
                        principalTable: "Staffs",
                        principalColumn: "Staff_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Borrowers",
                columns: table => new
                {
                    Borrower_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Id = table.Column<int>(type: "int", nullable: false),
                    Customer_Id1 = table.Column<int>(type: "int", nullable: true),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id1 = table.Column<int>(type: "int", nullable: true),
                    BookISBN_Id = table.Column<int>(type: "int", nullable: false),
                    BookISBN_Id1 = table.Column<int>(type: "int", nullable: true),
                    Is_Borrowed = table.Column<bool>(type: "bit", nullable: false),
                    Date_Borrowed = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Expected_Return = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Count_Book_Borrowed = table.Column<int>(type: "int", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Borrowers", x => x.Borrower_Id);
                    table.ForeignKey(
                        name: "FK_Borrowers_Books_BookISBN_Id1",
                        column: x => x.BookISBN_Id1,
                        principalTable: "Books",
                        principalColumn: "BookISBN_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Borrowers_Customers_Customer_Id1",
                        column: x => x.Customer_Id1,
                        principalTable: "Customers",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Borrowers_Staffs_Staff_Id1",
                        column: x => x.Staff_Id1,
                        principalTable: "Staffs",
                        principalColumn: "Staff_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Returns",
                columns: table => new
                {
                    Return_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borrower_Id = table.Column<int>(type: "int", nullable: false),
                    Borrower_Id1 = table.Column<int>(type: "int", nullable: true),
                    Staff_Id = table.Column<int>(type: "int", nullable: false),
                    Staff_Id1 = table.Column<int>(type: "int", nullable: true),
                    Date_Borrowed = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Expected_Return = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Actual_Return = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Is_Returned = table.Column<bool>(type: "bit", nullable: false),
                    Count_Book_Returned = table.Column<int>(type: "int", nullable: false),
                    Is_Defaulter = table.Column<bool>(type: "bit", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returns", x => x.Return_Id);
                    table.ForeignKey(
                        name: "FK_Returns_Borrowers_Borrower_Id1",
                        column: x => x.Borrower_Id1,
                        principalTable: "Borrowers",
                        principalColumn: "Borrower_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Returns_Staffs_Staff_Id1",
                        column: x => x.Staff_Id1,
                        principalTable: "Staffs",
                        principalColumn: "Staff_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Defaulters",
                columns: table => new
                {
                    Defaulter_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Return_Id = table.Column<int>(type: "int", nullable: false),
                    Return_Id1 = table.Column<int>(type: "int", nullable: true),
                    Days_Defaulted = table.Column<int>(type: "int", nullable: false),
                    Penalty_Cost = table.Column<int>(type: "int", nullable: false),
                    Is_Paid = table.Column<bool>(type: "bit", nullable: false),
                    Date_Paid = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Created = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Date_Edited = table.Column<DateTime>(type: "DateTime", nullable: true),
                    Date_Deleted = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defaulters", x => x.Defaulter_Id);
                    table.ForeignKey(
                        name: "FK_Defaulters_Returns_Return_Id1",
                        column: x => x.Return_Id1,
                        principalTable: "Returns",
                        principalColumn: "Return_Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Books_Binding_Id1",
                table: "Books",
                column: "Binding_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Category_Id1",
                table: "Books",
                column: "Category_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Books_Shelf_Id1",
                table: "Books",
                column: "Shelf_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_BookISBN_Id1",
                table: "Borrowers",
                column: "BookISBN_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_Customer_Id1",
                table: "Borrowers",
                column: "Customer_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowers_Staff_Id1",
                table: "Borrowers",
                column: "Staff_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Staff_Id1",
                table: "Customers",
                column: "Staff_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Defaulters_Return_Id1",
                table: "Defaulters",
                column: "Return_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_Borrower_Id1",
                table: "Returns",
                column: "Borrower_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_Returns_Staff_Id1",
                table: "Returns",
                column: "Staff_Id1");
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
                name: "Defaulters");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Returns");

            migrationBuilder.DropTable(
                name: "Borrowers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Bindings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Shelves");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_DietaryProject.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CaloryPerGram = table.Column<float>(type: "real", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Targets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Targets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategoryId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodFeatures_FoodCategories_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodFeatures_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodFeatures_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    TargetId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserDetails_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserDetails_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AppUserDetails_Targets_TargetId",
                        column: x => x.TargetId,
                        principalTable: "Targets",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaloriesTaken = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    AppUserDetailId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dishes_AppUserDetails_AppUserDetailId",
                        column: x => x.AppUserDetailId,
                        principalTable: "AppUserDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Dishes_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gramme = table.Column<float>(type: "real", nullable: false, defaultValue: 0f),
                    DishId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DishDetails_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishDetails_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Main Course" },
                    { 2, "Side Meal" },
                    { 3, "Soup" },
                    { 4, "Grain" },
                    { 5, "For Breakfast" },
                    { 6, "Snack" },
                    { 7, "Drink" },
                    { 8, "Salad" },
                    { 9, "Desert" },
                    { 10, "Fruit" },
                    { 11, "All Categories" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CaloryPerGram", "CreatedDate", "DeletedDate", "FoodName", "PhotoPath", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1.19f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7554), null, "Grilled chicken", ".\\Images\\Grilled Chicken.jpg", "0", null },
                    { 2, 2.89f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7559), null, "Steak", ".\\Images\\Steak.jpg", "0", null },
                    { 3, 2.19f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7559), null, "Salmon", ".\\Images\\Salmon.jpg", "0", null },
                    { 4, 1.29f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7560), null, "Tuna", ".\\Images\\Tuna.jpg", "0", null },
                    { 5, 0.89f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7561), null, "Cod", ".\\Images\\Cod.jpg", "0", null },
                    { 6, 1.99f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7561), null, "Shrimp", ".\\Images\\Shrimp.jpg", "0", null },
                    { 7, 1.79f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7562), null, "Beef stir-fry", ".\\Images\\Beef stir-fry.jpg", "0", null },
                    { 8, 1.39f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7563), null, "Chicken fajitas", ".\\Images\\Chicken fajitas.jpg", "0", null },
                    { 9, 2.09f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7563), null, "Meatloaf", ".\\Images\\Meatloaf.jpg", "0", null },
                    { 10, 1.59f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7564), null, "Grilled fish", ".\\Images\\Grilled fish.jpg", "0", null },
                    { 11, 2.49f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7565), null, "Pork chops", ".\\Images\\Pork chops.jpg", "0", null },
                    { 12, 2.29f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7565), null, "Chicken parmesan", ".\\Images\\Chicken parmesan.jpg", "0", null },
                    { 13, 1.89f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7566), null, "Beef stew", ".\\Images\\Beef stew.jpg", "0", null },
                    { 14, 1.69f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7569), null, "Pasta with meat sauce", ".\\Images\\Pasta with meatballs.jpg", "0", null },
                    { 15, 1.49f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7570), null, "Meatballs", ".\\Images\\Meatballs.jpg", "0", null },
                    { 16, 1.59f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7571), null, "Turkey chili", ".\\Images\\Turkey chili.jpg", "0", null },
                    { 17, 2.79f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7572), null, "Beef burgers", ".\\Images\\Beef burgers.jpg", "0", null },
                    { 18, 1.99f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7572), null, "Chicken curry", ".\\Images\\Chicken curry.jpg", "0", null },
                    { 19, 1.79f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7573), null, "Spaghetti Bolognese", ".\\Images\\Spaghetti bolognese.jpg", "0", null },
                    { 20, 2.39f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7574), null, "Roasted pork loin", ".\\Images\\Roasted pork loin.jpg", "0", null },
                    { 21, 0.25f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7575), null, "Grilled Eggplant", ".\\Images\\Grilled Eggplant.jpg", "0", null },
                    { 22, 0.39f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7575), null, "Stuffed Zucchini", ".\\Images\\Stuffed Zucchini.jpg", "0", null },
                    { 23, 0.43f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7576), null, "Roasted Brussels Sprouts", ".\\Images\\Roasted brussel sprouts.jpg", "0", null },
                    { 24, 0.4f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7577), null, "Cauliflower Fried Rice", ".\\Images\\Fried rice.jpg", "0", null },
                    { 25, 0.27f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7577), null, "Sautéed Kale", ".\\Images\\Sautéed Kale.jpg", "0", null },
                    { 26, 0.76f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7578), null, "Roasted Sweet Potatoes", ".\\Images\\Roasted sweet potatoes.jpg", "0", null },
                    { 27, 0.12f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7579), null, "Stir-Fried Bok Choy", ".\\Images\\Stir-fried bok choy.jpg", "0", null },
                    { 28, 0.2f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7579), null, "Grilled Asparagus", ".\\Images\\Grilled Asparagus.jpg", "0", null },
                    { 29, 0.41f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7580), null, "Roasted Carrots", ".\\Images\\Roasted Carrots.jpg", "0", null },
                    { 30, 0.34f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7581), null, "Mushroom Risotto", ".\\Images\\Mushroom Risotto.jpg", "0", null },
                    { 31, 0.35f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7582), null, "Steamed broccoli", ".\\Images\\Steamed broccoli.jpg", "0", null },
                    { 32, 0.27f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7582), null, "Roasted asparagus", ".\\Images\\Roasted asparagus.jpg", "0", null },
                    { 33, 0.86f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7583), null, "Mashed potatoes", ".\\Images\\Mashed potatoes.jpg", "0", null },
                    { 34, 0.33f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7585), null, "Garlic green beans", ".\\Images\\Garlic green beans.jpg", "0", null },
                    { 35, 0.17f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7586), null, "Grilled zucchini", ".\\Images\\Grilled zucchini.jpg", "0", null },
                    { 36, 0.69f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7586), null, "Creamed spinach", ".\\Images\\Creamed spinach.jpg", "0", null },
                    { 37, 1.05f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7587), null, "Fried rice", ".\\Images\\Fried rice.jpg", "0", null },
                    { 38, 1.3f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7588), null, "Sweet potato fries", ".\\Images\\Sweet potato fries.jpg", "0", null },
                    { 39, 0.86f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7588), null, "Baked beans", ".\\Images\\Bakedbeans.jpg", "0", null },
                    { 40, 0.35f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7591), null, "Tomato soup", ".\\Images\\Tomato soup.jpg", "0", null },
                    { 41, 0.25f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7591), null, "Pumpkin soup", ".\\Images\\Pumpkin soup.jpg", "0", null },
                    { 42, 0.4f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7592), null, "Mushroom soup", ".\\Images\\Mushroom soup.jpg", "0", null },
                    { 43, 0.45f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7593), null, "Chicken noodle soup", ".\\Images\\Chicken noodle soup.jpg", "0", null },
                    { 44, 0.4f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7593), null, "Beef soup", ".\\Images\\Beef soup.jpg", "0", null },
                    { 45, 0.35f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7594), null, "Corn soup", ".\\Images\\Corn soup.jpg", "0", null },
                    { 46, 0.3f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7595), null, "Minestrone soup", ".\\Images\\Minestrone soup.jpg", "0", null },
                    { 47, 0.25f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7595), null, "Vegetable soup", ".\\Images\\Vegetable soup.jpg", "0", null },
                    { 48, 0.5f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7596), null, "Clam chowder", ".\\Images\\Clam chowder.jpg", "0", null },
                    { 49, 0.3f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7597), null, "Lentil soup", ".\\Images\\Lentil soup.jpg", "0", null },
                    { 50, 3.75f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7597), null, "Rice", ".\\Images\\Rice.jpg", "0", null },
                    { 51, 2.64f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7598), null, "Bread", ".\\Images\\Bread.jpg", "0", null },
                    { 52, 3.38f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7599), null, "Pasta", ".\\Images\\Pasta.jpg", "0", null },
                    { 53, 3.68f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7614), null, "Quinoa", ".\\Images\\Quinoa.jpg", "0", null },
                    { 54, 3.33f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7615), null, "Bulgur", ".\\Images\\Bulgur.jpg", "0", null },
                    { 55, 3.81f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7616), null, "Couscous", ".\\Images\\Couscous.jpg", "0", null },
                    { 56, 3.37f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7617), null, "Oats", ".\\Images\\Oats.jpg", "0", null },
                    { 57, 3.44f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7617), null, "Barley", ".\\Images\\Barley.jpg", "0", null },
                    { 58, 3.3f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7619), null, "Wheat berries", ".\\Images\\Wheat berries.jpg", "0", null },
                    { 59, 3.72f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7620), null, "Wild rice", ".\\Images\\Wild rice.jpg", "0", null },
                    { 60, 0.68f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7621), null, "Oatmeal", ".\\Images\\Oatmeal.jpg", "0", null },
                    { 61, 1.34f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7621), null, "Scrambled Eggs", ".\\Images\\Scrambled eggs.jpg", "0", null },
                    { 62, 5.42f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7622), null, "Bacon", ".\\Images\\Bacon.jpg", "0", null },
                    { 63, 4.85f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7623), null, "Sausage", ".\\Images\\Sausage.jpg", "0", null },
                    { 64, 2.92f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7624), null, "French Toast", ".\\Images\\French toast.jpg", "0", null },
                    { 65, 2.86f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7625), null, "Waffles", ".\\Images\\Waffles.jpg", "0", null },
                    { 66, 2.52f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7625), null, "Pancakes", ".\\Images\\Pancakes.jpg", "0", null },
                    { 67, 2.71f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7626), null, "Bagel", ".\\Images\\Bagel.jpg", "0", null },
                    { 68, 3.79f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7627), null, "Cream Cheese", ".\\Images\\Cream Cheese.jpg", "0", null },
                    { 69, 0.67f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7627), null, "Fruit Salad", ".\\Images\\Bacon.jpg", "0", null },
                    { 70, 5.85f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7628), null, "Popcorn", ".\\Images\\Popcorn.jpg", "0", null },
                    { 71, 4.2f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7629), null, "Trail Mix", ".\\Images\\Tail mix.jpg", "0", null },
                    { 72, 4f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7629), null, "Energy Bars", ".\\Images\\Energy Bars.jpg", "0", null },
                    { 73, 0.73f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7630), null, "Fruit Cups", ".\\Images\\Fruit cups.jpg", "0", null },
                    { 74, 0.75f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7633), null, "Yogurt Cups", ".\\Images\\Yogurt cups.jpg", "0", null },
                    { 75, 6f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7633), null, "Nuts", ".\\Images\\Nuts.jpg", "0", null },
                    { 76, 3f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7634), null, "Cheese and Crackers", ".\\Images\\Cheese and Crackers.jpg", "0", null },
                    { 77, 3.17f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7635), null, "Pretzels", ".\\Images\\Pretzels.jpg", "0", null },
                    { 78, 1f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7636), null, "Hummus", ".\\Images\\Hummus.jpg", "0", null },
                    { 79, 5f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7636), null, "Dark Chocolate", ".\\Images\\Dark chocolate.jpg", "0", null },
                    { 80, 0f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7637), null, "Water", ".\\Images\\Water.jpg", "0", null },
                    { 81, 0.16f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7638), null, "Tea", ".\\Images\\Tea.jpg", "0", null },
                    { 82, 0.1f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7638), null, "Coffee", ".\\Images\\Coffee.jpg", "0", null },
                    { 83, 0.44f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7639), null, "Juice", ".\\Images\\Juice.jpg", "0", null },
                    { 84, 0.67f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7640), null, "Milk", ".\\Images\\Milk.jpg", "0", null },
                    { 85, 0.41f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7640), null, "Soda", ".\\Images\\Soda.jpg", "0", null },
                    { 86, 0f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7641), null, "Mineral Water", ".\\Images\\Mineral Water.jpg", "0", null },
                    { 87, 0.1f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7642), null, "Turkish Coffee", ".\\Images\\Turkish coffee.jpg", "0", null },
                    { 88, 0.4f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7642), null, "Lemonade", ".\\Images\\Lemonade.jpg", "0", null },
                    { 89, 0.56f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7644), null, "Smoothie", ".\\Images\\Smoothie.jpg", "0", null },
                    { 90, 1.13f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7645), null, "Caesar Salad", ".\\Images\\Caesar salad.jpg", "0", null },
                    { 91, 1.05f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7646), null, "Cobb Salad", ".\\Images\\Cobb salad.jpg", "0", null },
                    { 92, 0.96f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7647), null, "Greek Salad", ".\\Images\\Greek salad.jpg", "0", null },
                    { 93, 0.89f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7647), null, "Caprese Salad", ".\\Images\\Caprese salad.jpg", "0", null },
                    { 94, 0.81f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7648), null, "Spinach Salad", ".\\Images\\Spinach salad.jpg", "0", null },
                    { 95, 0.76f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7649), null, "Coleslaw", ".\\Images\\Coleslaw.jpg", "0", null },
                    { 96, 0.92f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7649), null, "Waldorf Salad", ".\\Images\\Waldorf salad.jpg", "0", null },
                    { 97, 0.78f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7650), null, "Beetroot Salad", ".\\Images\\Beetroot salad.jpg", "0", null },
                    { 98, 0.88f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7652), null, "Pasta Salad", ".\\Images\\Pasta Salad.jpg", "0", null },
                    { 99, 0.98f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7653), null, "Tuna Salad", ".\\Images\\Tuna salad.jpg", "0", null },
                    { 100, 3.87f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7653), null, "Chocolate cake", ".\\Images\\Chocolate Cake.jpg", "0", null },
                    { 101, 2.8f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7654), null, "Apple pie", ".\\Images\\Applepie.jpg", "0", null },
                    { 102, 3f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7655), null, "Pumpkin pie", ".\\Images\\Pumpkin pie.jpg", "0", null },
                    { 103, 3.2f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7655), null, "Cheesecake", ".\\Images\\Cheesecake.jpg", "0", null },
                    { 104, 2.89f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7656), null, "Strawberry shortcake", ".\\Images\\Strawberry Shortcake.jpg", "0", null },
                    { 105, 1.5f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7657), null, "Ice cream", ".\\Images\\Ice Cream.jpg", "0", null },
                    { 106, 3.6f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7657), null, "Brownie", ".\\Images\\Brownie.jpg", "0", null },
                    { 107, 1.08f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7658), null, "Fruit salad", ".\\Images\\Fruit Salad.jpg", "0", null },
                    { 108, 1.83f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7659), null, "Banana pudding", ".\\Images\\Bananapudding.jpg", "0", null },
                    { 109, 3.1f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7660), null, "Tiramisu", ".\\Images\\Tiramisu.jpg", "0", null },
                    { 110, 0.52f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7660), null, "Apple", ".\\Images\\Apple.jpg", "0", null },
                    { 111, 0.89f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7661), null, "Banana", ".\\Images\\Banana.jpg", "0", null },
                    { 112, 0.47f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7662), null, "Orange", ".\\Images\\Orange.jpg", "0", null },
                    { 113, 0.32f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7662), null, "Strawberry", ".\\Images\\Strawberry.jpg", "0", null },
                    { 114, 0.3f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7663), null, "Watermelon", ".\\Images\\Watermelon.jpg", "0", null },
                    { 115, 0.69f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7664), null, "Grape", ".\\Images\\Grape.jpg", "0", null },
                    { 116, 0.5f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7664), null, "Pineapple", ".\\Images\\Pineapple.jpg", "0", null },
                    { 117, 0.61f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7665), null, "Kiwi", ".\\Images\\Kiwi.jpg", "0", null },
                    { 118, 0.5f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7666), null, "Cherry", ".\\Images\\Cherry.jpg", "0", null },
                    { 119, 0.6f, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7666), null, "Mango", ".\\Images\\Mango.jpg", "0", null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" },
                    { 4, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "Targets",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Lose Weight" },
                    { 2, "Maintain Weight" },
                    { 3, "Gain Weight" }
                });

            migrationBuilder.InsertData(
                table: "FoodFeatures",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FoodCategoryId", "FoodId", "MealId", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7097), null, 1, 1, 2, "0", null },
                    { 2, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7131), null, 1, 1, 3, "0", null },
                    { 3, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7131), null, 1, 2, 2, "0", null },
                    { 4, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7132), null, 1, 2, 3, "0", null },
                    { 5, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7132), null, 1, 3, 2, "0", null },
                    { 6, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7134), null, 1, 3, 3, "0", null },
                    { 7, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7134), null, 1, 4, 2, "0", null },
                    { 8, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7135), null, 1, 4, 3, "0", null },
                    { 9, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7136), null, 1, 5, 2, "0", null },
                    { 10, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7137), null, 1, 5, 3, "0", null },
                    { 11, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7138), null, 1, 6, 2, "0", null },
                    { 12, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7138), null, 1, 6, 3, "0", null },
                    { 13, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7139), null, 1, 7, 2, "0", null },
                    { 14, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7140), null, 1, 7, 3, "0", null },
                    { 15, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7140), null, 1, 8, 2, "0", null },
                    { 16, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7141), null, 1, 8, 3, "0", null },
                    { 17, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7141), null, 1, 9, 2, "0", null },
                    { 18, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7143), null, 1, 9, 3, "0", null },
                    { 19, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7143), null, 1, 10, 2, "0", null },
                    { 20, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7144), null, 1, 10, 3, "0", null },
                    { 21, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7145), null, 1, 11, 2, "0", null },
                    { 22, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7145), null, 1, 11, 3, "0", null },
                    { 23, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7146), null, 1, 12, 2, "0", null },
                    { 24, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7146), null, 1, 12, 3, "0", null },
                    { 25, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7147), null, 1, 13, 2, "0", null },
                    { 26, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7148), null, 1, 13, 3, "0", null },
                    { 27, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7148), null, 1, 14, 2, "0", null },
                    { 28, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7149), null, 1, 14, 3, "0", null },
                    { 29, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7150), null, 1, 15, 2, "0", null },
                    { 30, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7150), null, 1, 15, 3, "0", null },
                    { 31, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7151), null, 2, 16, 2, "0", null },
                    { 32, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7152), null, 2, 16, 3, "0", null },
                    { 33, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7152), null, 2, 17, 2, "0", null },
                    { 34, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7154), null, 2, 18, 3, "0", null },
                    { 35, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7154), null, 2, 18, 2, "0", null },
                    { 36, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7155), null, 2, 19, 3, "0", null },
                    { 37, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7156), null, 2, 19, 2, "0", null },
                    { 38, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7156), null, 2, 20, 3, "0", null },
                    { 39, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7157), null, 2, 20, 2, "0", null },
                    { 40, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7158), null, 2, 21, 3, "0", null },
                    { 41, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7158), null, 2, 22, 2, "0", null },
                    { 42, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7159), null, 2, 23, 3, "0", null },
                    { 43, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7160), null, 2, 23, 2, "0", null },
                    { 44, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7160), null, 2, 24, 3, "0", null },
                    { 45, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7161), null, 2, 24, 2, "0", null },
                    { 46, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7162), null, 2, 25, 3, "0", null },
                    { 47, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7162), null, 2, 25, 2, "0", null },
                    { 48, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7163), null, 2, 26, 3, "0", null },
                    { 49, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7164), null, 2, 26, 2, "0", null },
                    { 50, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7164), null, 2, 27, 3, "0", null },
                    { 51, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7165), null, 2, 27, 2, "0", null },
                    { 52, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7166), null, 2, 28, 3, "0", null },
                    { 53, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7166), null, 2, 28, 2, "0", null },
                    { 54, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7167), null, 2, 29, 3, "0", null },
                    { 55, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7168), null, 2, 29, 2, "0", null },
                    { 56, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7168), null, 2, 30, 3, "0", null },
                    { 57, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7169), null, 2, 30, 2, "0", null },
                    { 58, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7170), null, 2, 31, 3, "0", null },
                    { 59, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7170), null, 2, 31, 2, "0", null },
                    { 60, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7171), null, 2, 32, 3, "0", null },
                    { 61, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7184), null, 2, 32, 2, "0", null },
                    { 62, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7184), null, 2, 33, 3, "0", null },
                    { 63, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7185), null, 2, 34, 2, "0", null },
                    { 64, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7186), null, 2, 34, 3, "0", null },
                    { 65, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7186), null, 2, 35, 2, "0", null },
                    { 66, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7187), null, 2, 35, 3, "0", null },
                    { 67, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7188), null, 2, 36, 2, "0", null },
                    { 68, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7189), null, 2, 36, 3, "0", null },
                    { 69, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7189), null, 2, 37, 2, "0", null },
                    { 70, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7190), null, 2, 37, 3, "0", null },
                    { 71, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7191), null, 2, 38, 2, "0", null },
                    { 72, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7191), null, 2, 38, 3, "0", null },
                    { 73, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7192), null, 2, 39, 2, "0", null },
                    { 74, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7193), null, 2, 39, 3, "0", null },
                    { 75, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7193), null, 3, 40, 2, "0", null },
                    { 76, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7194), null, 3, 40, 3, "0", null },
                    { 77, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7195), null, 3, 41, 2, "0", null },
                    { 78, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7195), null, 3, 41, 3, "0", null },
                    { 79, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7196), null, 3, 42, 2, "0", null },
                    { 80, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7197), null, 3, 42, 3, "0", null },
                    { 81, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7197), null, 3, 43, 2, "0", null },
                    { 82, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7198), null, 3, 43, 3, "0", null },
                    { 83, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7199), null, 3, 44, 2, "0", null },
                    { 84, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7199), null, 3, 44, 3, "0", null },
                    { 85, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7200), null, 3, 45, 2, "0", null },
                    { 86, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7201), null, 3, 45, 3, "0", null },
                    { 87, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7201), null, 3, 46, 2, "0", null },
                    { 88, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7202), null, 3, 46, 3, "0", null },
                    { 89, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7203), null, 3, 47, 2, "0", null },
                    { 90, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7203), null, 3, 47, 3, "0", null },
                    { 91, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7204), null, 3, 48, 2, "0", null },
                    { 92, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7205), null, 3, 48, 3, "0", null },
                    { 93, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7205), null, 3, 49, 2, "0", null },
                    { 94, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7206), null, 3, 49, 3, "0", null },
                    { 95, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7207), null, 4, 50, 2, "0", null },
                    { 96, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7207), null, 4, 50, 3, "0", null },
                    { 97, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7208), null, 4, 51, 2, "0", null },
                    { 98, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7208), null, 4, 51, 3, "0", null },
                    { 99, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7209), null, 4, 52, 2, "0", null },
                    { 100, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7210), null, 4, 52, 3, "0", null },
                    { 101, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7210), null, 4, 53, 2, "0", null },
                    { 102, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7211), null, 4, 53, 3, "0", null },
                    { 103, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7212), null, 4, 54, 2, "0", null },
                    { 104, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7212), null, 4, 54, 3, "0", null },
                    { 105, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7213), null, 4, 55, 2, "0", null },
                    { 106, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7214), null, 4, 55, 3, "0", null },
                    { 107, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7214), null, 4, 56, 2, "0", null },
                    { 108, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7215), null, 4, 56, 3, "0", null },
                    { 109, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7216), null, 4, 57, 2, "0", null },
                    { 110, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7216), null, 4, 57, 3, "0", null },
                    { 111, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7219), null, 4, 58, 2, "0", null },
                    { 112, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7219), null, 4, 58, 3, "0", null },
                    { 113, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7220), null, 4, 59, 2, "0", null },
                    { 114, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7220), null, 4, 59, 3, "0", null },
                    { 115, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7221), null, 5, 60, 2, "0", null },
                    { 116, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7222), null, 5, 60, 3, "0", null },
                    { 117, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7222), null, 5, 61, 2, "0", null },
                    { 118, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7223), null, 5, 61, 3, "0", null },
                    { 119, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7224), null, 5, 62, 2, "0", null },
                    { 120, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7224), null, 5, 62, 3, "0", null },
                    { 121, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7225), null, 5, 63, 2, "0", null },
                    { 122, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7226), null, 5, 63, 3, "0", null },
                    { 123, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7227), null, 5, 64, 2, "0", null },
                    { 124, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7227), null, 5, 64, 3, "0", null },
                    { 125, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7228), null, 5, 65, 2, "0", null },
                    { 126, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7229), null, 5, 65, 3, "0", null },
                    { 127, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7229), null, 5, 66, 2, "0", null },
                    { 128, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7230), null, 5, 66, 1, "0", null },
                    { 129, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7231), null, 5, 67, 2, "0", null },
                    { 130, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7245), null, 5, 67, 3, "0", null },
                    { 131, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7245), null, 5, 68, 2, "0", null },
                    { 132, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7246), null, 5, 68, 1, "0", null },
                    { 133, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7247), null, 5, 69, 2, "0", null },
                    { 134, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7247), null, 5, 69, 1, "0", null },
                    { 135, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7248), null, 6, 70, 2, "0", null },
                    { 136, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7249), null, 6, 70, 3, "0", null },
                    { 137, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7249), null, 6, 71, 2, "0", null },
                    { 138, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7250), null, 6, 71, 3, "0", null },
                    { 139, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7251), null, 6, 72, 2, "0", null },
                    { 140, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7251), null, 6, 72, 3, "0", null },
                    { 141, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7252), null, 6, 73, 4, "0", null },
                    { 142, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7253), null, 6, 73, 3, "0", null },
                    { 143, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7253), null, 6, 74, 2, "0", null },
                    { 144, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7254), null, 6, 74, 3, "0", null },
                    { 145, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7254), null, 6, 75, 2, "0", null },
                    { 146, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7255), null, 6, 75, 4, "0", null },
                    { 147, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7256), null, 6, 76, 2, "0", null },
                    { 148, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7256), null, 6, 76, 3, "0", null },
                    { 149, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7257), null, 6, 77, 2, "0", null },
                    { 150, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7258), null, 6, 77, 3, "0", null },
                    { 151, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7258), null, 6, 78, 2, "0", null },
                    { 152, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7259), null, 6, 78, 3, "0", null },
                    { 153, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7260), null, 6, 79, 2, "0", null },
                    { 154, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7260), null, 6, 79, 3, "0", null },
                    { 155, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7261), null, 7, 80, 2, "0", null },
                    { 156, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7262), null, 7, 80, 3, "0", null },
                    { 157, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7263), null, 7, 81, 2, "0", null },
                    { 158, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7264), null, 7, 81, 3, "0", null },
                    { 159, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7264), null, 7, 82, 2, "0", null },
                    { 160, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7265), null, 7, 82, 3, "0", null },
                    { 161, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7265), null, 7, 83, 2, "0", null },
                    { 162, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7266), null, 7, 83, 3, "0", null },
                    { 163, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7267), null, 7, 84, 2, "0", null },
                    { 164, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7267), null, 7, 84, 3, "0", null },
                    { 165, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7268), null, 7, 85, 2, "0", null },
                    { 166, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7269), null, 7, 85, 3, "0", null },
                    { 167, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7269), null, 7, 86, 2, "0", null },
                    { 168, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7270), null, 7, 86, 3, "0", null },
                    { 169, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7271), null, 7, 87, 2, "0", null },
                    { 170, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7271), null, 7, 87, 3, "0", null },
                    { 171, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7272), null, 7, 88, 2, "0", null },
                    { 172, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7273), null, 7, 88, 3, "0", null },
                    { 173, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7273), null, 7, 89, 2, "0", null },
                    { 174, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7274), null, 7, 89, 3, "0", null },
                    { 175, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7275), null, 8, 90, 2, "0", null },
                    { 176, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7275), null, 8, 90, 3, "0", null },
                    { 177, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7276), null, 8, 91, 4, "0", null },
                    { 178, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7277), null, 8, 91, 3, "0", null },
                    { 179, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7277), null, 8, 92, 2, "0", null },
                    { 180, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7278), null, 8, 92, 4, "0", null },
                    { 181, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7279), null, 8, 93, 2, "0", null },
                    { 182, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7279), null, 8, 93, 3, "0", null },
                    { 183, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7280), null, 8, 94, 4, "0", null },
                    { 184, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7280), null, 8, 94, 3, "0", null },
                    { 185, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7281), null, 8, 95, 2, "0", null },
                    { 186, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7282), null, 8, 95, 3, "0", null },
                    { 187, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7282), null, 8, 96, 2, "0", null },
                    { 188, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7283), null, 8, 96, 3, "0", null },
                    { 189, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7299), null, 8, 97, 4, "0", null },
                    { 190, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7300), null, 8, 97, 3, "0", null },
                    { 191, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7301), null, 8, 98, 2, "0", null },
                    { 192, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7301), null, 8, 98, 4, "0", null },
                    { 193, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7302), null, 8, 99, 2, "0", null },
                    { 194, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7303), null, 8, 99, 3, "0", null },
                    { 195, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7303), null, 9, 100, 2, "0", null },
                    { 196, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7304), null, 9, 100, 3, "0", null },
                    { 197, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7304), null, 9, 101, 2, "0", null },
                    { 198, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7305), null, 9, 101, 3, "0", null },
                    { 199, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7306), null, 9, 102, 2, "0", null },
                    { 200, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7306), null, 9, 103, 3, "0", null },
                    { 201, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7307), null, 9, 103, 2, "0", null },
                    { 202, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7308), null, 9, 104, 3, "0", null },
                    { 203, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7308), null, 9, 104, 2, "0", null },
                    { 204, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7309), null, 9, 105, 3, "0", null },
                    { 205, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7310), null, 9, 105, 2, "0", null },
                    { 206, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7310), null, 9, 106, 3, "0", null },
                    { 207, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7311), null, 9, 106, 2, "0", null },
                    { 208, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7312), null, 9, 107, 3, "0", null },
                    { 209, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7312), null, 9, 107, 2, "0", null },
                    { 210, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7313), null, 9, 108, 3, "0", null },
                    { 211, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7314), null, 9, 108, 2, "0", null },
                    { 212, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7314), null, 9, 109, 3, "0", null },
                    { 213, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7315), null, 9, 109, 2, "0", null },
                    { 214, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7316), null, 10, 110, 2, "0", null },
                    { 215, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7316), null, 10, 110, 3, "0", null },
                    { 216, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7317), null, 10, 111, 4, "0", null },
                    { 217, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7318), null, 10, 111, 3, "0", null },
                    { 218, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7318), null, 10, 112, 2, "0", null },
                    { 219, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7319), null, 10, 112, 4, "0", null },
                    { 220, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7319), null, 10, 113, 2, "0", null },
                    { 221, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7320), null, 10, 113, 3, "0", null },
                    { 222, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7321), null, 10, 114, 4, "0", null },
                    { 223, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7321), null, 10, 114, 3, "0", null },
                    { 224, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7322), null, 10, 115, 2, "0", null },
                    { 225, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7323), null, 10, 115, 3, "0", null },
                    { 226, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7323), null, 10, 116, 2, "0", null },
                    { 227, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7324), null, 10, 116, 3, "0", null },
                    { 228, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7325), null, 10, 117, 4, "0", null },
                    { 229, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7325), null, 10, 117, 3, "0", null },
                    { 230, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7326), null, 10, 118, 2, "0", null },
                    { 231, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7327), null, 10, 118, 4, "0", null },
                    { 232, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7327), null, 10, 119, 2, "0", null },
                    { 233, new DateTime(2024, 4, 20, 21, 10, 15, 847, DateTimeKind.Local).AddTicks(7328), null, 10, 119, 3, "0", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserDetails_AppUserId",
                table: "AppUserDetails",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserDetails_GenderId",
                table: "AppUserDetails",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserDetails_TargetId",
                table: "AppUserDetails",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_DishDetails_DishId",
                table: "DishDetails",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishDetails_FoodId",
                table: "DishDetails",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_AppUserDetailId",
                table: "Dishes",
                column: "AppUserDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_MealId",
                table: "Dishes",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodFeatures_FoodCategoryId",
                table: "FoodFeatures",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodFeatures_FoodId",
                table: "FoodFeatures",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodFeatures_MealId",
                table: "FoodFeatures",
                column: "MealId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishDetails");

            migrationBuilder.DropTable(
                name: "FoodFeatures");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "AppUserDetails");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Targets");
        }
    }
}

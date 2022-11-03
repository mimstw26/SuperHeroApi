using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHeroApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("1f7b928f-a887-4015-986d-554fa90bf2ab"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("544efe90-8a6b-4b87-9ee9-931c495c9a3a"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("9e4a3d86-07d2-4a9e-be5f-77c931be5c03"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("0b57f40f-bf1b-447a-bb24-54ed9aa9d628"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f7b928f-a887-4015-986d-554fa90bf2ab"), "The Dark Knight Rises" },
                    { new Guid("4395ada8-d187-4e82-8796-ab85548dbffb"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f7b928f-a887-4015-986d-554fa90bf2ab"), "The Dark Knight" },
                    { new Guid("69a0ccc3-3103-42c1-81c2-5d2c317eb80b"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("544efe90-8a6b-4b87-9ee9-931c495c9a3a"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("7966f2f5-7587-4376-acb8-b41bd11519b8"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("544efe90-8a6b-4b87-9ee9-931c495c9a3a"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("9dde9d71-70e1-4aae-88a7-320688647048"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("544efe90-8a6b-4b87-9ee9-931c495c9a3a"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("b7aa3593-b1a7-40d4-8b0a-1ee6aae74f21"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1f7b928f-a887-4015-986d-554fa90bf2ab"), "Batman Begins" },
                    { new Guid("de48362b-112f-4aca-8ef7-0a83759eb4af"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e4a3d86-07d2-4a9e-be5f-77c931be5c03"), "Black Widow" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("1e773e14-3733-4095-a832-20c5ab00da55"), "She's good at spying at people.", "Espionage", new Guid("9e4a3d86-07d2-4a9e-be5f-77c931be5c03") },
                    { new Guid("63678c86-d169-465d-9f0e-9b79ffbd3d51"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("9e4a3d86-07d2-4a9e-be5f-77c931be5c03") },
                    { new Guid("6a697568-c230-48bf-91ec-ec8165c81048"), "Sublime fighting skills.", "Fighting", new Guid("1f7b928f-a887-4015-986d-554fa90bf2ab") },
                    { new Guid("7125d291-ec94-4dd0-b2f7-26f86e92c581"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("9e4a3d86-07d2-4a9e-be5f-77c931be5c03") },
                    { new Guid("7da0f5c9-a0d1-4f7d-9b62-2f71faffed06"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("544efe90-8a6b-4b87-9ee9-931c495c9a3a") },
                    { new Guid("83334d09-1ae0-47b4-8b97-cc6f961e6ece"), "He's always a step ahead.", "Intellect.", new Guid("1f7b928f-a887-4015-986d-554fa90bf2ab") },
                    { new Guid("ec4c323c-7e3b-4eef-8338-f1f952476d2d"), "He got a lot of money", "Wealth.", new Guid("1f7b928f-a887-4015-986d-554fa90bf2ab") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheroes");
        }
    }
}

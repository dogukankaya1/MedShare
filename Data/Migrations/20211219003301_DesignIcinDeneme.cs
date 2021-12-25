using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MedShare.Data.Migrations
{
    public partial class DesignIcinDeneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Senders",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Senders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Senders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Senders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Senders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Senders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Senders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceiverId",
                table: "Medicines",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Educ = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receiver",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobId = table.Column<int>(nullable: true),
                    EducationId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receiver", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receiver_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receiver_Education_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Education",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Receiver_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Senders_CountryId",
                table: "Senders",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Senders_EducationId",
                table: "Senders",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_ReceiverId",
                table: "Medicines",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_CountryId",
                table: "Receiver",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_EducationId",
                table: "Receiver",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Receiver_JobId",
                table: "Receiver",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Receiver_ReceiverId",
                table: "Medicines",
                column: "ReceiverId",
                principalTable: "Receiver",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Senders_Country_CountryId",
                table: "Senders",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Senders_Education_EducationId",
                table: "Senders",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Receiver_ReceiverId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Senders_Country_CountryId",
                table: "Senders");

            migrationBuilder.DropForeignKey(
                name: "FK_Senders_Education_EducationId",
                table: "Senders");

            migrationBuilder.DropTable(
                name: "Receiver");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropIndex(
                name: "IX_Senders_CountryId",
                table: "Senders");

            migrationBuilder.DropIndex(
                name: "IX_Senders_EducationId",
                table: "Senders");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_ReceiverId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Senders");

            migrationBuilder.DropColumn(
                name: "ReceiverId",
                table: "Medicines");
        }
    }
}

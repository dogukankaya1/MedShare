using Microsoft.EntityFrameworkCore.Migrations;

namespace MedShare.Data.Migrations
{
    public partial class NewMedicine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AmountLeft",
                table: "Medicines",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmountReceived",
                table: "Medicines",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmountSent",
                table: "Medicines",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ReceiverMessage",
                table: "Medicines",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SenderMessage",
                table: "Medicines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AmountLeft",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "AmountReceived",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "AmountSent",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "ReceiverMessage",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "SenderMessage",
                table: "Medicines");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccsessLayer.Migrations
{
    public partial class mig_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Contacts_ContactId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ContactId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PersonId",
                table: "Contacts",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Persons_PersonId",
                table: "Contacts",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Persons_PersonId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_PersonId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ContactId",
                table: "Persons",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Contacts_ContactId",
                table: "Persons",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "ContactId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

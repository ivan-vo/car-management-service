using Microsoft.EntityFrameworkCore.Migrations;

namespace managementAPI.Migrations
{
    public partial class fixFealRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_deal_cars_car_id",
                table: "deal");

            migrationBuilder.DropForeignKey(
                name: "fk_deal_managers_manager_id",
                table: "deal");

            migrationBuilder.DropPrimaryKey(
                name: "pk_deal",
                table: "deal");

            migrationBuilder.RenameTable(
                name: "deal",
                newName: "deals");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "deals",
                newName: "date");

            migrationBuilder.RenameIndex(
                name: "ix_deal_manager_id",
                table: "deals",
                newName: "ix_deals_manager_id");

            migrationBuilder.RenameIndex(
                name: "ix_deal_car_id",
                table: "deals",
                newName: "ix_deals_car_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_deals",
                table: "deals",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_deals_cars_car_id",
                table: "deals",
                column: "car_id",
                principalTable: "cars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_deals_managers_manager_id",
                table: "deals",
                column: "manager_id",
                principalTable: "managers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_deals_cars_car_id",
                table: "deals");

            migrationBuilder.DropForeignKey(
                name: "fk_deals_managers_manager_id",
                table: "deals");

            migrationBuilder.DropPrimaryKey(
                name: "pk_deals",
                table: "deals");

            migrationBuilder.RenameTable(
                name: "deals",
                newName: "deal");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "deal",
                newName: "name");

            migrationBuilder.RenameIndex(
                name: "ix_deals_manager_id",
                table: "deal",
                newName: "ix_deal_manager_id");

            migrationBuilder.RenameIndex(
                name: "ix_deals_car_id",
                table: "deal",
                newName: "ix_deal_car_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_deal",
                table: "deal",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_deal_cars_car_id",
                table: "deal",
                column: "car_id",
                principalTable: "cars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_deal_managers_manager_id",
                table: "deal",
                column: "manager_id",
                principalTable: "managers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

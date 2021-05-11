using Microsoft.EntityFrameworkCore.Migrations;

namespace managementAPI.Migrations
{
    public partial class renemeColumnInDeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_deal_cars_car_idid",
                table: "deal");

            migrationBuilder.DropForeignKey(
                name: "fk_deal_managers_manager_idid",
                table: "deal");

            migrationBuilder.DropIndex(
                name: "ix_deal_car_idid",
                table: "deal");

            migrationBuilder.DropIndex(
                name: "ix_deal_manager_idid",
                table: "deal");

            migrationBuilder.DropColumn(
                name: "car_idid",
                table: "deal");

            migrationBuilder.DropColumn(
                name: "manager_idid",
                table: "deal");

            migrationBuilder.AddColumn<int>(
                name: "dealid",
                table: "managers",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "dealid",
                table: "cars",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_managers_dealid",
                table: "managers",
                column: "dealid");

            migrationBuilder.CreateIndex(
                name: "ix_cars_dealid",
                table: "cars",
                column: "dealid");

            migrationBuilder.AddForeignKey(
                name: "fk_cars_deal_dealid",
                table: "cars",
                column: "dealid",
                principalTable: "deal",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_managers_deal_dealid",
                table: "managers",
                column: "dealid",
                principalTable: "deal",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cars_deal_dealid",
                table: "cars");

            migrationBuilder.DropForeignKey(
                name: "fk_managers_deal_dealid",
                table: "managers");

            migrationBuilder.DropIndex(
                name: "ix_managers_dealid",
                table: "managers");

            migrationBuilder.DropIndex(
                name: "ix_cars_dealid",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "dealid",
                table: "managers");

            migrationBuilder.DropColumn(
                name: "dealid",
                table: "cars");

            migrationBuilder.AddColumn<int>(
                name: "car_idid",
                table: "deal",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "manager_idid",
                table: "deal",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_deal_car_idid",
                table: "deal",
                column: "car_idid");

            migrationBuilder.CreateIndex(
                name: "ix_deal_manager_idid",
                table: "deal",
                column: "manager_idid");

            migrationBuilder.AddForeignKey(
                name: "fk_deal_cars_car_idid",
                table: "deal",
                column: "car_idid",
                principalTable: "cars",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_deal_managers_manager_idid",
                table: "deal",
                column: "manager_idid",
                principalTable: "managers",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

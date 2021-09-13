﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Report.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ReportDemandDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ReportStatusId = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_ReportStatuses_ReportStatusId",
                        column: x => x.ReportStatusId,
                        principalTable: "ReportStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ReportStatuses",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "Hazırlanıyor" },
                    { 2, "Tamamlandı" }
                });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "Location", "PersonId", "PhoneNumber", "ReportDemandDate", "ReportStatusId" },
                values: new object[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e"), "Ankara", new Guid("e98a2570-92e7-435e-a289-e5702987fa8e"), "555", new DateTime(2021, 9, 11, 0, 29, 41, 912, DateTimeKind.Local).AddTicks(2151), 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ReportStatusId",
                table: "Reports",
                column: "ReportStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "ReportStatuses");
        }
    }
}

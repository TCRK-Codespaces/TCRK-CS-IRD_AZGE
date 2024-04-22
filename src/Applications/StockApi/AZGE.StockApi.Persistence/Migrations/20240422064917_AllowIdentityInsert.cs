﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AZGE.StockApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AllowIdentityInsert : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder
                .Sql(@"SET IDENTITY_INSERT [StockApi].[StockProduct] ON;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder
                .Sql(@"SET IDENTITY_INSERT [StockApi].[StockProduct] OFF;");
        }
    }
}

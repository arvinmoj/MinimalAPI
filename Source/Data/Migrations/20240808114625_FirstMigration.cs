using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    RateLimitWindowInMinutes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PermitLimit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    PeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                        .Annotation("SqlServer:IsTemporal", true)
                        .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                        .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                        .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                        .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TodoItems_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedOn", "Email", "Password", "PermitLimit", "RateLimitWindowInMinutes", "Salt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 11, 46, 24, 275, DateTimeKind.Utc).AddTicks(8520), "user1@example.com", "yM73XTC9Aueeab8c5Q2Q8BdpCmJXAVb5YSO1YUQce28=", 60, 5, "gDZR/l3tBjr1hMMrhS2rpQ==", "user1" },
                    { 2, new DateTime(2024, 8, 8, 11, 46, 24, 318, DateTimeKind.Utc).AddTicks(2790), "user2@example.com", "ltTO+9uq3rikCkXPjoZJXHi0ip8ImA+5OCjqQN4KZGc=", 60, 5, "RzFEpwkSnPMpprD/ldz7+w==", "user2" },
                    { 3, new DateTime(2024, 8, 8, 11, 46, 24, 360, DateTimeKind.Utc).AddTicks(1550), "user3@example.com", "DXcqW/G2JPokyCzONpupdJ3PD2xbwwsz4R5Sre1yzaU=", 60, 5, "whJhS8Hp73Qk7VMLvHd8xA==", "user3" },
                    { 4, new DateTime(2024, 8, 8, 11, 46, 24, 401, DateTimeKind.Utc).AddTicks(9990), "user4@example.com", "LbQ6b4HJWFNzjjkdJgLlxqV3sNbBQCNqiQEIu3esk4E=", 60, 5, "8diNID+TnUUhjTYLTuVaxw==", "user4" },
                    { 5, new DateTime(2024, 8, 8, 11, 46, 24, 445, DateTimeKind.Utc).AddTicks(7030), "user5@example.com", "2h02WzhAwPpQojKM/GULPkbwqDzeaALVmmWgiXX3xpo=", 60, 5, "yr2FvBWe/rwIIQZhqRS56w==", "user5" },
                    { 6, new DateTime(2024, 8, 8, 11, 46, 24, 489, DateTimeKind.Utc).AddTicks(7890), "user6@example.com", "u1Hceq5EPlczMytHjTA+mmgAdm3TeN2oOTVuStX00JA=", 60, 5, "Xj75TdHp3mv6T8pS+sBDMw==", "user6" },
                    { 7, new DateTime(2024, 8, 8, 11, 46, 24, 533, DateTimeKind.Utc).AddTicks(6030), "user7@example.com", "LK8sCbGyTleo9kOAeFfAWGNbyri0zvtmXQgiCQGwlZA=", 60, 5, "fEt6eVwGopDGBr7IBCeBAQ==", "user7" },
                    { 8, new DateTime(2024, 8, 8, 11, 46, 24, 577, DateTimeKind.Utc).AddTicks(1440), "user8@example.com", "3KqZ6IGQ3qGQA61TgCyB6OZWyXdIQcvaOM9FOiv5LNU=", 60, 5, "dwig6k7mcHuxlmc0IZ95ZA==", "user8" },
                    { 9, new DateTime(2024, 8, 8, 11, 46, 24, 620, DateTimeKind.Utc).AddTicks(7730), "user9@example.com", "XITNUs5q9AE5KuhOdxiqKTpJSJdu23+yTtypPaDa9N0=", 60, 5, "l8zKTYBF93SYlAZW/ATIQQ==", "user9" },
                    { 10, new DateTime(2024, 8, 8, 11, 46, 24, 663, DateTimeKind.Utc).AddTicks(7540), "user10@example.com", "982q+cA7b/0L0uyPFEbUvftzHrglCznxexNhjPwJkYE=", 60, 5, "mPq8qn7GE/dIO+kfJy4EkA==", "user10" },
                    { 11, new DateTime(2024, 8, 8, 11, 46, 24, 706, DateTimeKind.Utc).AddTicks(7470), "user11@example.com", "4wDBEmX+uqH24ZijkF96xUPoZugvtygegYhOnGSmw0g=", 60, 5, "/U2dpDh2HyBOUS0zZNrbHQ==", "user11" },
                    { 12, new DateTime(2024, 8, 8, 11, 46, 24, 749, DateTimeKind.Utc).AddTicks(3720), "user12@example.com", "zOu15eTQLTLpKUWbZDjRNGZ/XrzvMaBNEtutDhEJy78=", 60, 5, "R0j49bRMeE7g3X0kTi0ciQ==", "user12" },
                    { 13, new DateTime(2024, 8, 8, 11, 46, 24, 791, DateTimeKind.Utc).AddTicks(3060), "user13@example.com", "19gTrr/MUGVJhZfUe40NHn/5gbayChI304wQWLgDekI=", 60, 5, "cvKQZkCGzhFUSHZhNwCtBw==", "user13" },
                    { 14, new DateTime(2024, 8, 8, 11, 46, 24, 837, DateTimeKind.Utc).AddTicks(7470), "user14@example.com", "klGIZsLPZtYK689VTnpboniwHMZ1C7YRwSt0+DQI5/8=", 60, 5, "o4VZLxbajcBRiAi123b7HA==", "user14" },
                    { 15, new DateTime(2024, 8, 8, 11, 46, 24, 886, DateTimeKind.Utc).AddTicks(1730), "user15@example.com", "sSM+VE18GCFIQqw7RVUe4cy0c+NG94/Gi9RGLivjx+k=", 60, 5, "t2ebZanczGztO7GCdJIGng==", "user15" },
                    { 16, new DateTime(2024, 8, 8, 11, 46, 24, 931, DateTimeKind.Utc).AddTicks(9830), "user16@example.com", "CJBPyiDl6UBYXRwv0VjLFbtEeQEUdXbI/V84XGQanfU=", 60, 5, "yEni/XQR5a5/tkNh9wWyuw==", "user16" },
                    { 17, new DateTime(2024, 8, 8, 11, 46, 25, 1, DateTimeKind.Utc).AddTicks(8070), "user17@example.com", "WHy2ObSa78RCnjZ1n4lW7NjbtzLpYEuGwnk+k/x3UpY=", 60, 5, "U1KIcTg0/2gqYY/vioJd4A==", "user17" },
                    { 18, new DateTime(2024, 8, 8, 11, 46, 25, 49, DateTimeKind.Utc).AddTicks(4100), "user18@example.com", "FjhZ5tMuSgGo3P1dVlAzunyDcAZVk61VxfS485QzLfA=", 60, 5, "TVMLLQKI3uDk6Ocg5BmL2w==", "user18" },
                    { 19, new DateTime(2024, 8, 8, 11, 46, 25, 93, DateTimeKind.Utc).AddTicks(4690), "user19@example.com", "PxjXXSVum+Jc8Cm/XW7WN4pERMK3aeQ0HfseE+/sOJk=", 60, 5, "UoIrvMHdT2Bljr3fFK7Qxg==", "user19" },
                    { 20, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2180), "user20@example.com", "s5wK7ZGK8ou1fHcrxjKTxZXdnjj9j/5nMRGqq7aVHjk=", 60, 5, "8rkbxZ3SP7L70axJ/7l+2g==", "user20" }
                });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "CreatedOn", "IsCompleted", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2250), false, "Todo Item 1", 1 },
                    { 2, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2790), false, "Todo Item 2", 2 },
                    { 3, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2800), false, "Todo Item 3", 3 },
                    { 4, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2810), false, "Todo Item 4", 4 },
                    { 5, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2830), false, "Todo Item 5", 5 },
                    { 6, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2850), false, "Todo Item 6", 6 },
                    { 7, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2870), false, "Todo Item 7", 7 },
                    { 8, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2880), false, "Todo Item 8", 8 },
                    { 9, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2890), false, "Todo Item 9", 9 },
                    { 10, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2910), false, "Todo Item 10", 10 },
                    { 11, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2920), false, "Todo Item 11", 11 },
                    { 12, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2930), false, "Todo Item 12", 12 },
                    { 13, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(2940), false, "Todo Item 13", 13 },
                    { 14, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(4360), false, "Todo Item 14", 14 },
                    { 15, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(4480), false, "Todo Item 15", 15 },
                    { 16, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(4490), false, "Todo Item 16", 16 },
                    { 17, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(4510), false, "Todo Item 17", 17 },
                    { 18, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(4530), false, "Todo Item 18", 18 },
                    { 19, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(4540), false, "Todo Item 19", 19 },
                    { 20, new DateTime(2024, 8, 8, 11, 46, 25, 139, DateTimeKind.Utc).AddTicks(4560), false, "Todo Item 20", 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_UserId",
                table: "TodoItems",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TodoItems")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TodoItemsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropTable(
                name: "Users")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "UsersHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");
        }
    }
}

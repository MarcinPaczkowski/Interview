using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddCandidateVoters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasVoted",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "CastedVotes",
                table: "Candidates");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "Voters",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Voters",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Candidates",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Voters_CandidateId",
                table: "Voters",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voters_Candidates_CandidateId",
                table: "Voters",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voters_Candidates_CandidateId",
                table: "Voters");

            migrationBuilder.DropIndex(
                name: "IX_Voters_CandidateId",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Voters");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Candidates");

            migrationBuilder.AddColumn<bool>(
                name: "HasVoted",
                table: "Voters",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "CastedVotes",
                table: "Candidates",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}

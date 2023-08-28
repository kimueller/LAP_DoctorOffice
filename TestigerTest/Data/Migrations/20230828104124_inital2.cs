using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestigerTest.Data.Migrations
{
    public partial class inital2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Treatments_TreatmentID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Treatments_TreatmentID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_TreatmentID",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_TreatmentID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TreatmentID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "TreatmentID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorID",
                table: "Treatments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_DoctorID",
                table: "Treatments",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_Treatments_PatientID",
                table: "Treatments",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_AspNetUsers_DoctorID",
                table: "Treatments",
                column: "DoctorID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Treatments_People_PatientID",
                table: "Treatments",
                column: "PatientID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_AspNetUsers_DoctorID",
                table: "Treatments");

            migrationBuilder.DropForeignKey(
                name: "FK_Treatments_People_PatientID",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_DoctorID",
                table: "Treatments");

            migrationBuilder.DropIndex(
                name: "IX_Treatments_PatientID",
                table: "Treatments");

            migrationBuilder.AlterColumn<string>(
                name: "DoctorID",
                table: "Treatments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "TreatmentID",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TreatmentID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_People_TreatmentID",
                table: "People",
                column: "TreatmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_TreatmentID",
                table: "AspNetUsers",
                column: "TreatmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Treatments_TreatmentID",
                table: "AspNetUsers",
                column: "TreatmentID",
                principalTable: "Treatments",
                principalColumn: "TreatmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Treatments_TreatmentID",
                table: "People",
                column: "TreatmentID",
                principalTable: "Treatments",
                principalColumn: "TreatmentID");
        }
    }
}

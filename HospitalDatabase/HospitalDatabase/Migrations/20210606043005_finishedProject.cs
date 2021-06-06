using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalDatabase.Migrations
{
    public partial class finishedProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Patient_Model_Doctors_DoctorId",
                table: "Doctor_Patient_Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Patient_Model_Patients_PatientId",
                table: "Doctor_Patient_Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Medication_Patient_Model_Medications_MedicationId",
                table: "Medication_Patient_Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Medication_Patient_Model_Patients_PatientId",
                table: "Medication_Patient_Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medication_Patient_Model",
                table: "Medication_Patient_Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor_Patient_Model",
                table: "Doctor_Patient_Model");

            migrationBuilder.RenameTable(
                name: "Medication_Patient_Model",
                newName: "Medications_Patients");

            migrationBuilder.RenameTable(
                name: "Doctor_Patient_Model",
                newName: "Doctors_Patients");

            migrationBuilder.RenameIndex(
                name: "IX_Medication_Patient_Model_PatientId",
                table: "Medications_Patients",
                newName: "IX_Medications_Patients_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Medication_Patient_Model_MedicationId",
                table: "Medications_Patients",
                newName: "IX_Medications_Patients_MedicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_Patient_Model_PatientId",
                table: "Doctors_Patients",
                newName: "IX_Doctors_Patients_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_Patient_Model_DoctorId",
                table: "Doctors_Patients",
                newName: "IX_Doctors_Patients_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medications_Patients",
                table: "Medications_Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors_Patients",
                table: "Doctors_Patients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Patients_Doctors_DoctorId",
                table: "Doctors_Patients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Patients_Patients_PatientId",
                table: "Doctors_Patients",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Patients_Medications_MedicationId",
                table: "Medications_Patients",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Patients_Patients_PatientId",
                table: "Medications_Patients",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Patients_Doctors_DoctorId",
                table: "Doctors_Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Patients_Patients_PatientId",
                table: "Doctors_Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Patients_Medications_MedicationId",
                table: "Medications_Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Patients_Patients_PatientId",
                table: "Medications_Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medications_Patients",
                table: "Medications_Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors_Patients",
                table: "Doctors_Patients");

            migrationBuilder.RenameTable(
                name: "Medications_Patients",
                newName: "Medication_Patient_Model");

            migrationBuilder.RenameTable(
                name: "Doctors_Patients",
                newName: "Doctor_Patient_Model");

            migrationBuilder.RenameIndex(
                name: "IX_Medications_Patients_PatientId",
                table: "Medication_Patient_Model",
                newName: "IX_Medication_Patient_Model_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Medications_Patients_MedicationId",
                table: "Medication_Patient_Model",
                newName: "IX_Medication_Patient_Model_MedicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_Patients_PatientId",
                table: "Doctor_Patient_Model",
                newName: "IX_Doctor_Patient_Model_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_Patients_DoctorId",
                table: "Doctor_Patient_Model",
                newName: "IX_Doctor_Patient_Model_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medication_Patient_Model",
                table: "Medication_Patient_Model",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor_Patient_Model",
                table: "Doctor_Patient_Model",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Patient_Model_Doctors_DoctorId",
                table: "Doctor_Patient_Model",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Patient_Model_Patients_PatientId",
                table: "Doctor_Patient_Model",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medication_Patient_Model_Medications_MedicationId",
                table: "Medication_Patient_Model",
                column: "MedicationId",
                principalTable: "Medications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Medication_Patient_Model_Patients_PatientId",
                table: "Medication_Patient_Model",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

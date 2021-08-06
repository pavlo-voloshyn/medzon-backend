using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class Feedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feedbacks_Clinicas_ClinicaId",
                table: "Feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_Feedbacks_ClinicaId",
                table: "Feedbacks");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2013a22d-3de9-4bae-8f8f-aace8e2f707e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76e4b000-7d94-40ed-956e-5436fa191bef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "947d147f-d306-48f3-8bbc-3a27f0f31946");

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("0356c3c3-cc45-4142-9636-705a6a530290"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("17f1e957-824b-461c-8d48-b29183fcbc72"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("339cea7c-3036-45d8-ac9b-7bdbb1bb3fd8"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("3ddc30f5-6b6d-4260-a13e-54219f86981c"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("4eac92e0-dc12-4177-ba93-a54ddfd739a8"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("55711644-cf86-4f57-b9c2-4a7da328c9a3"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("5fc05326-ac4d-4107-bff7-97d30c2722cd"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("86a9621f-d4c6-482b-bf9a-a63dcecdf673"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("9db46b2f-9108-480f-ad05-53c172ea33fe"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("ab847722-781b-42f2-91c2-3f6486bcee8b"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("b07124ee-bfd6-4bd9-994f-3d0ee68f6bc8"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("c4780d59-69b7-48d8-b3ed-53895ff17320"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("c9a5659f-602a-4689-930b-fb2f266c9968"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("d9cfc203-b687-4fa2-ac54-c7f7fd11b8f4"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("e7b2862b-518b-49eb-9ddf-55e7e78318dc"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("1887c4e6-08cf-44dc-96a7-a13187d39fc0"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("20fd3853-3a71-4296-a739-09332575dedf"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("3607ddf2-ff0f-41e4-81e8-eb6f32da56c3"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("4dd18344-25e2-4dfa-8256-ba3d8f985643"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("4dffa158-0557-4cde-bcff-5e4354a8c3a0"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("58bcff29-cf23-4e07-88cf-c2db2f3f41f8"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("669dd4f6-fe44-49ca-91e3-2999b1279d12"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("68ebfcd2-97c0-4a7c-b571-df65073fa77d"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("7bfed1f3-c680-47c9-ae15-a5b64c8555df"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("8fa36c3f-9d8e-4adf-9c50-e78a040d2044"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("951f3081-db48-4e19-92f0-157a7218417f"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("a2e0a582-4e6f-4cb8-aef9-56a276fe0cf6"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("a6bc1c34-ab12-49fc-beb2-8dbae418798e"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("ad48e01c-3b6b-43fb-b2fe-d8346cfc29bb"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("ca7b2bda-485b-4241-b073-9814261e328c"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("e1819a1e-73d9-48c5-8a5e-1bb9aebbbeef"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("ef833957-bfa7-4383-89fc-e0fff9be66cc"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("f8945d58-001a-44e8-b541-461e0c87060a"));

            migrationBuilder.DropColumn(
                name: "ClinicaId",
                table: "Feedbacks");

            migrationBuilder.CreateTable(
                name: "ClinicaFeedback",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stars = table.Column<int>(type: "int", nullable: false),
                    ClinicaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicaFeedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicaFeedback_Clinicas_ClinicaId",
                        column: x => x.ClinicaId,
                        principalTable: "Clinicas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClinicaFeedback_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e5133648-cf01-4f16-a145-f79026597a5d", "28f0b6ef-4c62-4fb5-ac6d-30b4bd44bae9", "Doctor", "DOCTOR" },
                    { "08c0c880-4c21-4249-a724-9816a1d42f32", "1b963781-3e91-4928-ab9a-de230b8b1ae6", "User", "USER" },
                    { "7d3b3c9b-0ca4-4467-badb-9eebfce6bfe0", "b0da093e-8b18-43f8-8e33-92f888fe3540", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5cdaff3e-6d50-4477-a4a4-7a792e9ea100"), "Urolog" },
                    { new Guid("4251404c-44eb-4a09-af52-4eee3281ce71"), "Oncolog" },
                    { new Guid("afe2a6aa-d40f-4b1e-9663-67b23ca52dab"), "Surger" },
                    { new Guid("b9bf9513-8252-4309-ab01-ea7be87e0492"), "Preventive medicine" },
                    { new Guid("f013944b-a480-4ac3-8c5f-5b130e81d7f4"), "Physical medic and rehabilitolog" },
                    { new Guid("29104884-8866-4efb-818f-a6cd92dc341f"), "Pediatr" },
                    { new Guid("8f8b3d65-319f-4ea6-a1f0-257b98e62c7b"), "Immunolog" },
                    { new Guid("a15b8c9d-85ad-41cf-a2f2-13b971115a61"), "Ophthalmolog" },
                    { new Guid("561ab4f9-3d66-48e4-b9dd-5e73383e7cd4"), "Gynecolog" },
                    { new Guid("92c0bb68-8a54-40e6-b35e-8c5f4e470668"), "Neurolog" },
                    { new Guid("23f10e6d-c12e-4c7d-8395-ef8abd7e8bd0"), "Family doctor" },
                    { new Guid("0f1ee9da-867e-48aa-8c7c-92039fc03b9f"), "Diagnostic radiolog" },
                    { new Guid("ae90c5b1-d614-4318-bf68-2abdb3978ff6"), "Anesthesiolog" },
                    { new Guid("465d1bc2-0609-4278-a568-543091a63f59"), "Dermatolog" },
                    { new Guid("fd74d4af-5d5f-46e0-8e3c-d3f171ce1b0f"), "Patholog" }
                });

            migrationBuilder.InsertData(
                table: "SpecialityClinicas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2ca863d6-73a5-49cc-a798-009e0d81fc81"), "Urology" },
                    { new Guid("7ea7d269-261f-4d1b-b8fb-bfc74c96698d"), "Radiation oncology" },
                    { new Guid("02ba65cc-2d0f-4918-bca8-7f3e1862f02b"), "Surgery" },
                    { new Guid("fd558161-2057-44ae-a9f4-95b6f492bbd8"), "Preventive medicine" },
                    { new Guid("501e0817-64cd-4b67-b9aa-ee47409f468b"), "Physical medicine and rehabilitation" },
                    { new Guid("e8967044-8377-47fe-83fa-d974d63e74ae"), "Pediatrics" },
                    { new Guid("2b2040de-932a-4b04-aefb-cee669cedadd"), "Pathology" },
                    { new Guid("0aed4c2c-a376-4ea8-a4a4-234cd86ac559"), "Neurology" },
                    { new Guid("5e6e9103-a717-4d30-91dd-376cdb7bbb7f"), "Obstetrics and gynecology" },
                    { new Guid("0a810c69-cf55-4f6b-92ce-cba3d67a0636"), "Nuclear medicine" },
                    { new Guid("b0eacd27-d74a-4894-95f6-b9b586c2a7d0"), "Medical genetics" },
                    { new Guid("1628d694-f671-437e-bf34-08beb3b764c9"), "Internal medicine" },
                    { new Guid("27968e99-932c-4ca7-b702-7676a9166937"), "Family medicine" },
                    { new Guid("eba9739f-8143-438a-a99c-ffb8192cf3b4"), "Diagnostic radiology" },
                    { new Guid("321fa696-351b-433c-b7f9-8c2adb52c945"), "Anesthesiology" },
                    { new Guid("e76f8e9b-08a5-4fb4-a32a-6e4b8c26725c"), "Allergy and immunology" },
                    { new Guid("1585bdab-c1f6-4660-8df0-034210acd8cf"), "Ophthalmology" },
                    { new Guid("cc2615e7-8ff6-435f-84f4-8304f300d530"), "Dermatology" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClinicaFeedback_ClinicaId",
                table: "ClinicaFeedback",
                column: "ClinicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicaFeedback_PatientId",
                table: "ClinicaFeedback",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicaFeedback");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08c0c880-4c21-4249-a724-9816a1d42f32");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d3b3c9b-0ca4-4467-badb-9eebfce6bfe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5133648-cf01-4f16-a145-f79026597a5d");

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("0f1ee9da-867e-48aa-8c7c-92039fc03b9f"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("23f10e6d-c12e-4c7d-8395-ef8abd7e8bd0"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("29104884-8866-4efb-818f-a6cd92dc341f"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("4251404c-44eb-4a09-af52-4eee3281ce71"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("465d1bc2-0609-4278-a568-543091a63f59"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("561ab4f9-3d66-48e4-b9dd-5e73383e7cd4"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("5cdaff3e-6d50-4477-a4a4-7a792e9ea100"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("8f8b3d65-319f-4ea6-a1f0-257b98e62c7b"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("92c0bb68-8a54-40e6-b35e-8c5f4e470668"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("a15b8c9d-85ad-41cf-a2f2-13b971115a61"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("ae90c5b1-d614-4318-bf68-2abdb3978ff6"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("afe2a6aa-d40f-4b1e-9663-67b23ca52dab"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("b9bf9513-8252-4309-ab01-ea7be87e0492"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("f013944b-a480-4ac3-8c5f-5b130e81d7f4"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("fd74d4af-5d5f-46e0-8e3c-d3f171ce1b0f"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("02ba65cc-2d0f-4918-bca8-7f3e1862f02b"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("0a810c69-cf55-4f6b-92ce-cba3d67a0636"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("0aed4c2c-a376-4ea8-a4a4-234cd86ac559"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("1585bdab-c1f6-4660-8df0-034210acd8cf"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("1628d694-f671-437e-bf34-08beb3b764c9"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("27968e99-932c-4ca7-b702-7676a9166937"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("2b2040de-932a-4b04-aefb-cee669cedadd"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("2ca863d6-73a5-49cc-a798-009e0d81fc81"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("321fa696-351b-433c-b7f9-8c2adb52c945"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("501e0817-64cd-4b67-b9aa-ee47409f468b"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("5e6e9103-a717-4d30-91dd-376cdb7bbb7f"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("7ea7d269-261f-4d1b-b8fb-bfc74c96698d"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("b0eacd27-d74a-4894-95f6-b9b586c2a7d0"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("cc2615e7-8ff6-435f-84f4-8304f300d530"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("e76f8e9b-08a5-4fb4-a32a-6e4b8c26725c"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("e8967044-8377-47fe-83fa-d974d63e74ae"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("eba9739f-8143-438a-a99c-ffb8192cf3b4"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("fd558161-2057-44ae-a9f4-95b6f492bbd8"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClinicaId",
                table: "Feedbacks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "947d147f-d306-48f3-8bbc-3a27f0f31946", "507b3d1d-6165-41c3-a684-5e3a8e27f42f", "Doctor", "DOCTOR" },
                    { "2013a22d-3de9-4bae-8f8f-aace8e2f707e", "344f3c82-9b63-4f3f-b5cd-e8210c20e987", "User", "USER" },
                    { "76e4b000-7d94-40ed-956e-5436fa191bef", "3f664d86-635c-44eb-b0a7-5b8bfa749b4a", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3ddc30f5-6b6d-4260-a13e-54219f86981c"), "Urolog" },
                    { new Guid("0356c3c3-cc45-4142-9636-705a6a530290"), "Oncolog" },
                    { new Guid("ab847722-781b-42f2-91c2-3f6486bcee8b"), "Surger" },
                    { new Guid("d9cfc203-b687-4fa2-ac54-c7f7fd11b8f4"), "Preventive medicine" },
                    { new Guid("4eac92e0-dc12-4177-ba93-a54ddfd739a8"), "Physical medic and rehabilitolog" },
                    { new Guid("17f1e957-824b-461c-8d48-b29183fcbc72"), "Pediatr" },
                    { new Guid("c9a5659f-602a-4689-930b-fb2f266c9968"), "Immunolog" },
                    { new Guid("b07124ee-bfd6-4bd9-994f-3d0ee68f6bc8"), "Ophthalmolog" },
                    { new Guid("9db46b2f-9108-480f-ad05-53c172ea33fe"), "Gynecolog" },
                    { new Guid("e7b2862b-518b-49eb-9ddf-55e7e78318dc"), "Neurolog" },
                    { new Guid("339cea7c-3036-45d8-ac9b-7bdbb1bb3fd8"), "Family doctor" },
                    { new Guid("5fc05326-ac4d-4107-bff7-97d30c2722cd"), "Diagnostic radiolog" },
                    { new Guid("55711644-cf86-4f57-b9c2-4a7da328c9a3"), "Anesthesiolog" },
                    { new Guid("c4780d59-69b7-48d8-b3ed-53895ff17320"), "Dermatolog" },
                    { new Guid("86a9621f-d4c6-482b-bf9a-a63dcecdf673"), "Patholog" }
                });

            migrationBuilder.InsertData(
                table: "SpecialityClinicas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("68ebfcd2-97c0-4a7c-b571-df65073fa77d"), "Urology" },
                    { new Guid("ca7b2bda-485b-4241-b073-9814261e328c"), "Radiation oncology" },
                    { new Guid("f8945d58-001a-44e8-b541-461e0c87060a"), "Surgery" },
                    { new Guid("20fd3853-3a71-4296-a739-09332575dedf"), "Preventive medicine" },
                    { new Guid("4dd18344-25e2-4dfa-8256-ba3d8f985643"), "Physical medicine and rehabilitation" },
                    { new Guid("ad48e01c-3b6b-43fb-b2fe-d8346cfc29bb"), "Pediatrics" },
                    { new Guid("1887c4e6-08cf-44dc-96a7-a13187d39fc0"), "Pathology" },
                    { new Guid("4dffa158-0557-4cde-bcff-5e4354a8c3a0"), "Neurology" },
                    { new Guid("a6bc1c34-ab12-49fc-beb2-8dbae418798e"), "Obstetrics and gynecology" },
                    { new Guid("e1819a1e-73d9-48c5-8a5e-1bb9aebbbeef"), "Nuclear medicine" },
                    { new Guid("951f3081-db48-4e19-92f0-157a7218417f"), "Medical genetics" },
                    { new Guid("ef833957-bfa7-4383-89fc-e0fff9be66cc"), "Internal medicine" },
                    { new Guid("8fa36c3f-9d8e-4adf-9c50-e78a040d2044"), "Family medicine" },
                    { new Guid("58bcff29-cf23-4e07-88cf-c2db2f3f41f8"), "Diagnostic radiology" },
                    { new Guid("669dd4f6-fe44-49ca-91e3-2999b1279d12"), "Anesthesiology" },
                    { new Guid("7bfed1f3-c680-47c9-ae15-a5b64c8555df"), "Allergy and immunology" },
                    { new Guid("a2e0a582-4e6f-4cb8-aef9-56a276fe0cf6"), "Ophthalmology" },
                    { new Guid("3607ddf2-ff0f-41e4-81e8-eb6f32da56c3"), "Dermatology" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_ClinicaId",
                table: "Feedbacks",
                column: "ClinicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feedbacks_Clinicas_ClinicaId",
                table: "Feedbacks",
                column: "ClinicaId",
                principalTable: "Clinicas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

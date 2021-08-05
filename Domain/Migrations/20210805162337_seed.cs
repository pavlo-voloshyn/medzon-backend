using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a81a99b-d3dc-4a00-ba9e-f8cfd69441a1", "b6532cfb-6413-4f76-9ae1-02a4c8699929", "Doctor", "DOCTOR" },
                    { "840435fb-d1c7-4a9d-97ee-893d4f67be66", "b793ec04-18e1-4559-866b-05949cf637a1", "User", "USER" },
                    { "6bfac25f-ba7e-47a5-9b58-2f8c6a564f96", "4a70605d-7157-427f-a5c1-6870cec4c636", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Specialities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("392b91e7-b5c5-4e8d-921c-0389ee3f6a25"), "Urolog" },
                    { new Guid("d70809cb-2d47-4780-81e6-1110b0750654"), "Oncolog" },
                    { new Guid("2aef29c8-5e21-46f3-b9b2-4c17f438232a"), "Surger" },
                    { new Guid("8b3a7c39-a9b9-4043-a212-972d85dcece7"), "Preventive medicine" },
                    { new Guid("4f80e64c-0ddf-4c82-957e-7e1498ab6370"), "Physical medic and rehabilitolog" },
                    { new Guid("b6101e9f-95f4-4468-9a5b-7eea17cd6aba"), "Pediatr" },
                    { new Guid("d14dcea4-4180-43bc-b0a2-1c2e67adf26b"), "Immunolog" },
                    { new Guid("09dde36b-58e8-4de2-9e21-69380e6ceecb"), "Ophthalmolog" },
                    { new Guid("d293b74d-ad48-4e8b-9165-560ada51940d"), "Gynecolog" },
                    { new Guid("8c8b22bc-0555-4708-8e97-550fc33c881e"), "Neurolog" },
                    { new Guid("e9698141-5a3b-48b3-8b08-d86fc1438c4c"), "Family doctor" },
                    { new Guid("db23960f-d757-4773-a186-f70361d248fc"), "Diagnostic radiolog" },
                    { new Guid("44f3a5b6-8240-4bf9-bf24-84443ed8b5bc"), "Anesthesiolog" },
                    { new Guid("deb376b3-01b1-40e8-b4f0-841639a7a987"), "Dermatolog" },
                    { new Guid("3e89c063-07d7-4643-97b2-d34c8a86d3b6"), "Patholog" }
                });

            migrationBuilder.InsertData(
                table: "SpecialityClinicas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e847ddd-aa22-43c8-97d7-28f3aeeb1f17"), "Urology" },
                    { new Guid("d7f1c610-3bbb-49d6-b02e-d5772e01af25"), "Radiation oncology" },
                    { new Guid("5aad5f0c-f826-4e56-b0d1-e617a4880b0f"), "Surgery" },
                    { new Guid("e1d428ee-671c-4d17-8e80-19543af92b80"), "Preventive medicine" },
                    { new Guid("40dea072-0acf-44bf-b909-17bf0a743114"), "Physical medicine and rehabilitation" },
                    { new Guid("020856dc-8b5d-4427-83d2-b2337738fd32"), "Pediatrics" },
                    { new Guid("8dabd3aa-093f-49f3-8e0d-ba3d152ddea4"), "Pathology" },
                    { new Guid("5658172e-56bb-4d5c-9950-e96bb6e481f1"), "Neurology" },
                    { new Guid("528e5bab-4a09-4173-a198-d16c3a6e16c7"), "Obstetrics and gynecology" },
                    { new Guid("b1c73b93-926d-4e56-be3e-c17077557460"), "Nuclear medicine" },
                    { new Guid("6bead483-9a2b-4689-b497-0163043fcf8c"), "Medical genetics" },
                    { new Guid("49e2ed73-cccf-44b3-9307-1cda9bf3854a"), "Internal medicine" },
                    { new Guid("13bb78b3-6f2b-4d3a-8269-fa480453aee8"), "Family medicine" },
                    { new Guid("00111c74-7be8-4287-9819-66f792184c98"), "Diagnostic radiology" },
                    { new Guid("f4d07169-0211-407a-81f9-79dae790d5e9"), "Anesthesiology" },
                    { new Guid("2997c820-0758-4f58-b453-5498bfade3e8"), "Allergy and immunology" },
                    { new Guid("60f0c1f2-5f0d-46b0-9992-c855086c051c"), "Ophthalmology" },
                    { new Guid("dcad1ba7-d182-4f0b-8792-3cc8e364db89"), "Dermatology" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a81a99b-d3dc-4a00-ba9e-f8cfd69441a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bfac25f-ba7e-47a5-9b58-2f8c6a564f96");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "840435fb-d1c7-4a9d-97ee-893d4f67be66");

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("09dde36b-58e8-4de2-9e21-69380e6ceecb"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("2aef29c8-5e21-46f3-b9b2-4c17f438232a"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("392b91e7-b5c5-4e8d-921c-0389ee3f6a25"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("3e89c063-07d7-4643-97b2-d34c8a86d3b6"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("44f3a5b6-8240-4bf9-bf24-84443ed8b5bc"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("4f80e64c-0ddf-4c82-957e-7e1498ab6370"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("8b3a7c39-a9b9-4043-a212-972d85dcece7"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("8c8b22bc-0555-4708-8e97-550fc33c881e"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("b6101e9f-95f4-4468-9a5b-7eea17cd6aba"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("d14dcea4-4180-43bc-b0a2-1c2e67adf26b"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("d293b74d-ad48-4e8b-9165-560ada51940d"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("d70809cb-2d47-4780-81e6-1110b0750654"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("db23960f-d757-4773-a186-f70361d248fc"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("deb376b3-01b1-40e8-b4f0-841639a7a987"));

            migrationBuilder.DeleteData(
                table: "Specialities",
                keyColumn: "Id",
                keyValue: new Guid("e9698141-5a3b-48b3-8b08-d86fc1438c4c"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("00111c74-7be8-4287-9819-66f792184c98"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("020856dc-8b5d-4427-83d2-b2337738fd32"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("13bb78b3-6f2b-4d3a-8269-fa480453aee8"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("2997c820-0758-4f58-b453-5498bfade3e8"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("3e847ddd-aa22-43c8-97d7-28f3aeeb1f17"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("40dea072-0acf-44bf-b909-17bf0a743114"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("49e2ed73-cccf-44b3-9307-1cda9bf3854a"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("528e5bab-4a09-4173-a198-d16c3a6e16c7"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("5658172e-56bb-4d5c-9950-e96bb6e481f1"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("5aad5f0c-f826-4e56-b0d1-e617a4880b0f"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("60f0c1f2-5f0d-46b0-9992-c855086c051c"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("6bead483-9a2b-4689-b497-0163043fcf8c"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("8dabd3aa-093f-49f3-8e0d-ba3d152ddea4"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("b1c73b93-926d-4e56-be3e-c17077557460"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("d7f1c610-3bbb-49d6-b02e-d5772e01af25"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("dcad1ba7-d182-4f0b-8792-3cc8e364db89"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("e1d428ee-671c-4d17-8e80-19543af92b80"));

            migrationBuilder.DeleteData(
                table: "SpecialityClinicas",
                keyColumn: "Id",
                keyValue: new Guid("f4d07169-0211-407a-81f9-79dae790d5e9"));
        }
    }
}

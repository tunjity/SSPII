using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSP.Migrations
{
    /// <inheritdoc />
    public partial class PayeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "spike");

            migrationBuilder.CreateTable(
                name: "EmployeesMonthlyIncome",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessID = table.Column<int>(type: "int", nullable: false),
                    Basic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rent = table.Column<double>(type: "float", nullable: false),
                    Transport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LTG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Others = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total_Income = table.Column<double>(type: "float", nullable: false),
                    NHF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NHIS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesMonthlyIncome", x => x.EmployeeID);
                });


            migrationBuilder.CreateTable(
                           name: "UserManagement",
                           columns: table => new
                           {
                               CompanyID = table.Column<int>(type: "int", nullable: false)
                                   .Annotation("SqlServer:Identity", "1, 1"),
                               BusinessID = table.Column<int>(type: "int", nullable: false),
                               TaxpayerID = table.Column<int>(type: "int", nullable: false),
                               Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                           },
                           constraints: table =>
                           {
                               table.PrimaryKey("PK_UserManagement", x => x.CompanyID);
                           });





            migrationBuilder.CreateTable(
                          name: "BusinessEmployee",
                          columns: table => new
                          {
                              EmployeeID = table.Column<int>(type: "int", nullable: false)
                                  .Annotation("SqlServer:Identity", "1, 1"),
                              BusinessID = table.Column<int>(type: "int", nullable: false),
                              Empployee_Status = table.Column<bool>(type: "bit", nullable: false),
                              Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                              Start_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                          },
                          constraints: table =>
                          {
                              table.PrimaryKey("PK_BusinessEmployee", x => x.EmployeeID);
                          });

            migrationBuilder.CreateTable(
                name: "BusinessEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    BusinessId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    OtherName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EmployeeStatus = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    Designation = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    EmployerRIN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    AssetRin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmployeeRin = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Employee", x => x.Id);
                });




            migrationBuilder.CreateTable(
                           name: "EmployeesMonthlySchedule",
                           columns: table => new
                           {
                               EmployeeID = table.Column<int>(type: "int", nullable: false)
                                   .Annotation("SqlServer:Identity", "1, 1"),
                               BusinessID = table.Column<int>(type: "int", nullable: false),
                               CompanyID = table.Column<int>(type: "int", nullable: false),
                               Year = table.Column<int>(type: "int", nullable: false),
                               Month = table.Column<int>(type: "int", nullable: false),
                               StatusID = table.Column<int>(type: "int", nullable: false),
                               Basic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Rent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Transport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               LTG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Others = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Total_Income = table.Column<double>(type: "float", nullable: false),
                               NHF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               NHIS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Pension = table.Column<double>(type: "float", nullable: false),
                               Gross_Income = table.Column<double>(type: "float", nullable: false),
                               CRA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                               Tax_Free_Pay = table.Column<double>(type: "float", nullable: false),
                               Chargable_Income = table.Column<double>(type: "float", nullable: false),
                               Tax = table.Column<double>(type: "float", nullable: false)
                           },
                           constraints: table =>
                           {
                               table.PrimaryKey("PK_EmployeesMonthlySchedule", x => x.EmployeeID);
                           });


            migrationBuilder.CreateTable(
                         name: "ScheduleStatus",
                         columns: table => new
                         {
                             Id = table.Column<int>(type: "int", nullable: false)
                                 .Annotation("SqlServer:Identity", "1, 1"),
                             Forwarded_To_Head_Of_Station = table.Column<string>(type: "nvarchar(max)", nullable: false),
                             Approved = table.Column<bool>(type: "bit", nullable: false),
                             Declined = table.Column<bool>(type: "bit", nullable: false),
                             Assessed = table.Column<bool>(type: "bit", nullable: false)
                         },
                         constraints: table =>
                         {
                             table.PrimaryKey("PK_ScheduleStatus", x => x.Id);
                         });



            migrationBuilder.CreateTable(
                        name: "ScheduleComment",
                        columns: table => new
                        {
                            Id = table.Column<int>(type: "int", nullable: false)
                                .Annotation("SqlServer:Identity", "1, 1"),
                            Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                            CompanyID = table.Column<int>(type: "int", nullable: false),
                            BusinessID = table.Column<int>(type: "int", nullable: false),
                            Commenter_Type = table.Column<int>(type: "int", nullable: false),
                            Commenter_ID = table.Column<int>(type: "int", nullable: false),
                            Commenter = table.Column<int>(type: "int", nullable: false)
                        },
                        constraints: table =>
                        {
                            table.PrimaryKey("PK_ScheduleComment", x => x.Id);
                        });



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}

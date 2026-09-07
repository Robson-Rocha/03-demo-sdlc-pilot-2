using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingCatalog.Infrastructure.Migrations;

public partial class AddTrainingLessons : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<int>(
            name: "LessonCount",
            table: "Trainings",
            type: "INTEGER",
            nullable: false,
            defaultValue: 1);

        migrationBuilder.AddColumn<int>(
            name: "LessonDurationHours",
            table: "Trainings",
            type: "INTEGER",
            nullable: false,
            defaultValue: 1);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropColumn(
            name: "LessonCount",
            table: "Trainings");

        migrationBuilder.DropColumn(
            name: "LessonDurationHours",
            table: "Trainings");
    }
}

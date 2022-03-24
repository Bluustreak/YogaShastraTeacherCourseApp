using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YogaShastraTeacherCourseApp.Data.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tcourses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageHeaderUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphA1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphA2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphA3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphB1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphB2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphB3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphB4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphC1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphC2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParagraphC3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Testimonial1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Testimonial2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Testimonial3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoFloatBox1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoFloatBox2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoFloatBox3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoFloatBox4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoFloatBox5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatToLearnBoxContent10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard1ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard1Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard1Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard1Readmore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard2ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard2Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard2Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard2Readmore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard3ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard31Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard3Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard3Readmore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard4ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard4Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard4Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurTeamCard4Readmore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPGathering1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPGathering2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPGathering3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPGathering4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPNominalPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DaPDiscountedPrice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tcourses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tcourses");
        }
    }
}

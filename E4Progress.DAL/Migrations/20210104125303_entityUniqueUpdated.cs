using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E4Progress.DAL.Migrations
{
    public partial class entityUniqueUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_content_element_types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_content_element_types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_content_themes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_content_themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_models", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_difficulty_levels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_difficulty_levels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Native_Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Code = table.Column<string>(type: "varchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_office_applications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_office_applications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_formulation_types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_formulation_types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_questiontypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_questiontypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_quiz_questions",
                columns: table => new
                {
                    Quiz_Id = table.Column<int>(unicode: false, maxLength: 11, nullable: false),
                    Question_Id = table.Column<int>(unicode: false, maxLength: 11, nullable: false),
                    Sortorder = table.Column<int>(unicode: false, maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_quiz_questions", x => new { x.Quiz_Id, x.Question_Id });
                });

            migrationBuilder.CreateTable(
                name: "tbl_quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Office_Application_Id = table.Column<int>(type: "integer", nullable: false),
                    Instruction_Language_Id = table.Column<int>(type: "integer", nullable: false),
                    Userinterface_Language_Id = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "varchar(255)", nullable: false),
                    Short_Intro = table.Column<string>(type: "text", nullable: true),
                    Intro = table.Column<string>(type: "text", nullable: true),
                    Default_Time_Limit = table.Column<TimeSpan>(type: "time", nullable: false),
                    Default_Minimum_Score = table.Column<decimal>(type: "decimal(12,7)", nullable: false),
                    Identification_Code = table.Column<string>(type: "varchar(100)", nullable: false),
                    Creation_Timestamp = table.Column<DateTime>(nullable: false),
                    ReplicationKey = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_quizzes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Display_Label = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_model_levels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Didactical_ModelId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", nullable: false),
                    Sortorder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_model_levels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_levels_tbl_didactical_models_Didactical~",
                        column: x => x.Didactical_ModelId,
                        principalTable: "tbl_didactical_models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_content_element_type_translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    Content_Element_TypeId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_content_element_type_translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_content_element_type_translations_tbl_content_element_ty~",
                        column: x => x.Content_Element_TypeId,
                        principalTable: "tbl_content_element_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_content_element_type_translations_tbl_languages_Language~",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_content_theme_translations",
                columns: table => new
                {
                    Content_Theme_Id = table.Column<int>(nullable: false),
                    Language_Id = table.Column<int>(nullable: false),
                    Content_ThemeId = table.Column<int>(nullable: true),
                    LanguageId = table.Column<int>(nullable: true),
                    Translation = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_content_theme_translations", x => new { x.Content_Theme_Id, x.Language_Id });
                    table.ForeignKey(
                        name: "FK_tbl_content_theme_translations_tbl_content_themes_Content_Th~",
                        column: x => x.Content_ThemeId,
                        principalTable: "tbl_content_themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_content_theme_translations_tbl_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_model_translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Didactical_ModelId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_model_translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_translations_tbl_didactical_models_Dida~",
                        column: x => x.Didactical_ModelId,
                        principalTable: "tbl_didactical_models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_translations_tbl_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_difficulty_level_translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Difficulty_LevelId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_difficulty_level_translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_difficulty_level_translations_tbl_difficulty_levels_Diff~",
                        column: x => x.Difficulty_LevelId,
                        principalTable: "tbl_difficulty_levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_difficulty_level_translations_tbl_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_language_translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(nullable: false),
                    Translation_LanguageId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_language_translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_language_translations_tbl_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_language_translations_tbl_languages_Translation_Language~",
                        column: x => x.Translation_LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(400)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(400)", nullable: true),
                    Firstname = table.Column<string>(type: "varchar(70)", nullable: true),
                    Lastname = table.Column<string>(type: "varchar(70)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_users_tbl_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Instruction_LanguageId = table.Column<int>(nullable: false),
                    UserInterface_LanguageId = table.Column<int>(nullable: false),
                    Office_ApplicationId = table.Column<int>(nullable: false),
                    Created_By = table.Column<int>(type: "integer", nullable: false),
                    Created_On = table.Column<DateTime>(type: "date", nullable: false),
                    ReplicationKey = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_courses_tbl_languages_Instruction_LanguageId",
                        column: x => x.Instruction_LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_courses_tbl_office_applications_Office_ApplicationId",
                        column: x => x.Office_ApplicationId,
                        principalTable: "tbl_office_applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_courses_tbl_languages_UserInterface_LanguageId",
                        column: x => x.UserInterface_LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_formulation_type_translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Question_Formulation_TypeId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_formulation_type_translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_formulation_type_translations_tbl_languages_Lan~",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_formulation_type_translations_tbl_question_form~",
                        column: x => x.Question_Formulation_TypeId,
                        principalTable: "tbl_question_formulation_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Question_TypeId = table.Column<int>(type: "integer", nullable: false),
                    Is_Master_Question = table.Column<ulong>(type: "bit", nullable: false),
                    Master_QuestionId = table.Column<int>(type: "integer", nullable: true),
                    Instruction_LanguageId = table.Column<int>(type: "integer", nullable: false),
                    UserInterface_LanguageId = table.Column<int>(type: "integer", nullable: false),
                    Question_Formulation_TypeId = table.Column<int>(type: "integer", nullable: false),
                    Office_ApplicationId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", nullable: false),
                    QuestionText = table.Column<string>(type: "text", nullable: false),
                    Creation_timestamp = table.Column<DateTime>(type: "date", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Version_Number = table.Column<int>(type: "integer", nullable: false),
                    ReplicationKey = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_questions_tbl_languages_Instruction_LanguageId",
                        column: x => x.Instruction_LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_questions_tbl_questions_Master_QuestionId",
                        column: x => x.Master_QuestionId,
                        principalTable: "tbl_questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tbl_questions_tbl_office_applications_Office_ApplicationId",
                        column: x => x.Office_ApplicationId,
                        principalTable: "tbl_office_applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_questions_tbl_question_formulation_types_Question_Formul~",
                        column: x => x.Question_Formulation_TypeId,
                        principalTable: "tbl_question_formulation_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_questions_tbl_questiontypes_Question_TypeId",
                        column: x => x.Question_TypeId,
                        principalTable: "tbl_questiontypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_questions_tbl_languages_UserInterface_LanguageId",
                        column: x => x.UserInterface_LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_questiontype_translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionTypeId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_questiontype_translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_questiontype_translations_tbl_languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_questiontype_translations_tbl_questiontypes_QuestionType~",
                        column: x => x.QuestionTypeId,
                        principalTable: "tbl_questiontypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_didactical_model_level_translations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Didactical_Model_LevelId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    Translation = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_didactical_model_level_translations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_level_translations_tbl_didactical_model~",
                        column: x => x.Didactical_Model_LevelId,
                        principalTable: "tbl_didactical_model_levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_didactical_model_level_translations_tbl_languages_Langua~",
                        column: x => x.LanguageId,
                        principalTable: "tbl_languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_user_roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user_roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_user_roles_tbl_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "tbl_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_user_roles_tbl_users_UserId",
                        column: x => x.UserId,
                        principalTable: "tbl_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course_modules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "varchar(255)", nullable: false),
                    Sortorder = table.Column<int>(type: "integer", nullable: false),
                    CourseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course_modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_course_modules_tbl_courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "tbl_courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_content_themes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(nullable: false),
                    Content_ThemeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_content_themes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_content_themes_tbl_content_themes_Content_Theme~",
                        column: x => x.Content_ThemeId,
                        principalTable: "tbl_content_themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_content_themes_tbl_questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_learninggoals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    Didactical_Model_LevelId = table.Column<int>(type: "integer", nullable: false),
                    Learninggoal = table.Column<string>(type: "text", nullable: false),
                    Is_Measurable = table.Column<ulong>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Sortorder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_learninggoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_learninggoals_tbl_didactical_model_levels_Didac~",
                        column: x => x.Didactical_Model_LevelId,
                        principalTable: "tbl_didactical_model_levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_question_learninggoals_tbl_questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question_pre_knowledge_skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Skill = table.Column<string>(type: "text", nullable: false),
                    QuestionId = table.Column<int>(type: "integer", nullable: false),
                    Sortorder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question_pre_knowledge_skills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_question_pre_knowledge_skills_tbl_questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "tbl_questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course_module_topics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Course_ModuleId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "varchar(255)", nullable: false),
                    Sortorder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course_module_topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topics_tbl_course_modules_Course_ModuleId",
                        column: x => x.Course_ModuleId,
                        principalTable: "tbl_course_modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_course_module_topic_elements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Content_Element_TypeId = table.Column<int>(type: "integer", nullable: false),
                    Course_Module_TopicId = table.Column<int>(type: "integer", nullable: false),
                    Content_ElementId = table.Column<int>(type: "integer", nullable: false),
                    Difficulty_LevelId = table.Column<int>(type: "integer", nullable: false),
                    Sortorder = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_course_module_topic_elements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topic_elements_tbl_content_element_types_C~",
                        column: x => x.Content_Element_TypeId,
                        principalTable: "tbl_content_element_types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topic_elements_tbl_course_module_topics_Co~",
                        column: x => x.Course_Module_TopicId,
                        principalTable: "tbl_course_module_topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_course_module_topic_elements_tbl_difficulty_levels_Diffi~",
                        column: x => x.Difficulty_LevelId,
                        principalTable: "tbl_difficulty_levels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tbl_content_element_types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Quiz" },
                    { 2, "Test yourself" },
                    { 3, "Exam business" },
                    { 4, "Exam school" },
                    { 5, "Lesson fiche" }
                });

            migrationBuilder.InsertData(
                table: "tbl_content_themes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Medieval" },
                    { 2, "Halloween" }
                });

            migrationBuilder.InsertData(
                table: "tbl_didactical_models",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bloom" },
                    { 2, "EVA" }
                });

            migrationBuilder.InsertData(
                table: "tbl_difficulty_levels",
                columns: new[] { "Id", "Name", "Number" },
                values: new object[,]
                {
                    { 1, "Explorer", 1 },
                    { 2, "Adventurer", 2 },
                    { 3, "Expert", 3 },
                    { 4, "Master", 4 }
                });

            migrationBuilder.InsertData(
                table: "tbl_languages",
                columns: new[] { "Id", "Code", "Native_Name" },
                values: new object[,]
                {
                    { 3, "FR", "French" },
                    { 1, "EN", "English" },
                    { 2, "NL", "Dutch" }
                });

            migrationBuilder.InsertData(
                table: "tbl_office_applications",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Access" },
                    { 2, "Excel" },
                    { 3, "OneNote" },
                    { 4, "Outlook" },
                    { 5, "PowerPoint" },
                    { 6, "Word" }
                });

            migrationBuilder.InsertData(
                table: "tbl_question_formulation_types",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "Semi-open" },
                    { 3, "Closed" }
                });

            migrationBuilder.InsertData(
                table: "tbl_questiontypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "True/false question" });

            migrationBuilder.InsertData(
                table: "tbl_roles",
                columns: new[] { "Id", "Display_Label", "Name" },
                values: new object[,]
                {
                    { 1, "Admin", "Admin" },
                    { 2, "User", "User" }
                });

            migrationBuilder.InsertData(
                table: "tbl_content_element_type_translations",
                columns: new[] { "Id", "Content_Element_TypeId", "LanguageId", "Translation" },
                values: new object[,]
                {
                    { 8, 3, 2, "Examen business" },
                    { 5, 2, 2, "Toets jezelf" },
                    { 11, 4, 2, "Examen school" },
                    { 13, 5, 1, "Lesson fiche" },
                    { 10, 4, 1, "Exam school" },
                    { 7, 3, 1, "Exam business" },
                    { 4, 2, 1, "Test yourself" },
                    { 1, 1, 1, "Quiz" },
                    { 14, 5, 2, "Lesfiche" },
                    { 3, 1, 3, "Quiz" },
                    { 6, 2, 3, "Testez vous" },
                    { 9, 3, 3, "Examen d’entreprise" },
                    { 12, 4, 3, "Examen scolaire" },
                    { 15, 5, 3, "Fiche de cours" },
                    { 2, 1, 2, "Quiz" }
                });

            migrationBuilder.InsertData(
                table: "tbl_courses",
                columns: new[] { "Id", "Created_By", "Created_On", "Icon", "Instruction_LanguageId", "Name", "Office_ApplicationId", "ReplicationKey", "UserInterface_LanguageId" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2021, 1, 4, 13, 53, 3, 475, DateTimeKind.Local).AddTicks(3053), "", 1, "Yaman", 1, "EF102", 1 },
                    { 1, 1, new DateTime(2021, 1, 4, 13, 53, 3, 473, DateTimeKind.Local).AddTicks(1631), "", 1, "Algebra", 1, "EF101", 1 },
                    { 3, 1, new DateTime(2021, 1, 4, 13, 53, 3, 475, DateTimeKind.Local).AddTicks(3093), "", 1, "Arabic", 1, "EF103", 1 }
                });

            migrationBuilder.InsertData(
                table: "tbl_didactical_model_levels",
                columns: new[] { "Id", "Didactical_ModelId", "Name", "Sortorder" },
                values: new object[,]
                {
                    { 1, 1, "Remember", 1 },
                    { 8, 2, "Average", 2 },
                    { 9, 2, "High", 3 },
                    { 2, 1, "Understand", 2 },
                    { 3, 1, "Apply", 3 },
                    { 4, 1, "Analyze", 4 },
                    { 7, 2, "Low", 1 },
                    { 5, 1, "Evaluate", 5 },
                    { 6, 1, "Create", 6 }
                });

            migrationBuilder.InsertData(
                table: "tbl_didactical_model_translations",
                columns: new[] { "Id", "Didactical_ModelId", "LanguageId", "Translation" },
                values: new object[,]
                {
                    { 4, 2, 1, "EVA model" },
                    { 6, 2, 3, "Le Modèle EVA" },
                    { 1, 1, 1, "Bloom's taxonomy" },
                    { 2, 1, 2, "Taxonomie van Bloom" },
                    { 5, 2, 2, "EVA model" },
                    { 3, 1, 3, "Taxonomie de Bloom" }
                });

            migrationBuilder.InsertData(
                table: "tbl_difficulty_level_translations",
                columns: new[] { "Id", "Difficulty_LevelId", "LanguageId", "Translation" },
                values: new object[,]
                {
                    { 5, 2, 3, "Adventurer" },
                    { 3, 3, 3, "Explorer" },
                    { 10, 1, 1, "Master" },
                    { 6, 3, 3, "Aventurier" },
                    { 11, 2, 2, "Master" },
                    { 8, 2, 2, "Expert" },
                    { 2, 2, 2, "Explorer" },
                    { 12, 3, 3, "Maître" },
                    { 1, 1, 1, "Explorer" },
                    { 4, 1, 1, "Adventurer" },
                    { 7, 1, 1, "Expert" },
                    { 9, 3, 3, "Expert" }
                });

            migrationBuilder.InsertData(
                table: "tbl_language_translations",
                columns: new[] { "Id", "LanguageId", "Translation", "Translation_LanguageId" },
                values: new object[,]
                {
                    { 9, 3, "Français", 3 },
                    { 6, 3, "Frans", 2 },
                    { 5, 3, "French", 1 },
                    { 3, 2, "Dutch", 1 },
                    { 2, 1, "Anglais", 3 },
                    { 8, 2, "Nederlands", 2 },
                    { 1, 1, "Engels", 2 },
                    { 7, 1, "English", 1 },
                    { 4, 2, "Néerlandais", 3 }
                });

            migrationBuilder.InsertData(
                table: "tbl_question_formulation_type_translations",
                columns: new[] { "Id", "LanguageId", "Question_Formulation_TypeId", "Translation" },
                values: new object[,]
                {
                    { 7, 1, 3, "Closed" },
                    { 6, 3, 2, "Semi-ouverte" },
                    { 5, 2, 2, "Half-open" },
                    { 4, 1, 2, "Semi-open" },
                    { 3, 3, 1, "Ouverte" },
                    { 1, 1, 1, "Open" },
                    { 8, 2, 3, "Gesloten" },
                    { 2, 2, 1, "Open" },
                    { 9, 3, 3, "Fermée" }
                });

            migrationBuilder.InsertData(
                table: "tbl_questiontype_translations",
                columns: new[] { "Id", "LanguageId", "QuestionTypeId", "Translation" },
                values: new object[,]
                {
                    { 3, 3, 1, "Vrai/faux question" },
                    { 2, 2, 1, "Waar/onwaar vraag" },
                    { 1, 1, 1, "True/false question" }
                });

            migrationBuilder.InsertData(
                table: "tbl_course_modules",
                columns: new[] { "Id", "CourseId", "Sortorder", "Title" },
                values: new object[,]
                {
                    { 4, 2, 1, "Part Four" },
                    { 2, 1, 1, "Part Two" },
                    { 1, 1, 1, "Part One" },
                    { 3, 2, 1, "Part Three" }
                });

            migrationBuilder.InsertData(
                table: "tbl_didactical_model_level_translations",
                columns: new[] { "Id", "Didactical_Model_LevelId", "LanguageId", "Translation" },
                values: new object[,]
                {
                    { 27, 9, 3, "Haute" },
                    { 26, 9, 2, "Hoog" },
                    { 25, 9, 1, "High" },
                    { 24, 8, 3, "Moyenne" },
                    { 23, 8, 2, "Gemiddeld" },
                    { 22, 8, 1, "Average" },
                    { 21, 7, 3, "Bas" },
                    { 20, 7, 2, "Laag" },
                    { 19, 7, 1, "Low" },
                    { 18, 6, 3, "Créer" },
                    { 17, 6, 2, "Creëren" },
                    { 16, 6, 1, "Create" },
                    { 14, 5, 2, "Evalueren" },
                    { 13, 5, 1, "Evaluate" },
                    { 12, 4, 3, "Analyser" },
                    { 11, 4, 2, "Analyseren" },
                    { 10, 4, 1, "Analyze" },
                    { 9, 3, 3, "Appliquer" },
                    { 8, 3, 2, "Toepassen" },
                    { 7, 3, 1, "Apply" },
                    { 6, 2, 3, "Comprendre" },
                    { 5, 2, 2, "Begrijpen" },
                    { 4, 2, 1, "Understand" },
                    { 3, 1, 3, "Mémoriser" },
                    { 2, 1, 2, "Onthouden" },
                    { 15, 5, 3, "Evaluer" },
                    { 1, 1, 1, "Remember" }
                });

            migrationBuilder.InsertData(
                table: "tbl_course_module_topics",
                columns: new[] { "Id", "Course_ModuleId", "Sortorder", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "Multiply" },
                    { 2, 1, 2, "Divide" },
                    { 3, 1, 3, "Power" },
                    { 4, 2, 1, "jon" },
                    { 5, 2, 4, "nick " },
                    { 6, 3, 5, "brick" }
                });

            migrationBuilder.InsertData(
                table: "tbl_course_module_topic_elements",
                columns: new[] { "Id", "Content_ElementId", "Content_Element_TypeId", "Course_Module_TopicId", "Difficulty_LevelId", "Sortorder" },
                values: new object[] { 1, 1, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "tbl_course_module_topic_elements",
                columns: new[] { "Id", "Content_ElementId", "Content_Element_TypeId", "Course_Module_TopicId", "Difficulty_LevelId", "Sortorder" },
                values: new object[] { 2, 2, 1, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "tbl_course_module_topic_elements",
                columns: new[] { "Id", "Content_ElementId", "Content_Element_TypeId", "Course_Module_TopicId", "Difficulty_LevelId", "Sortorder" },
                values: new object[] { 3, 3, 1, 2, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_element_type_translations_Content_Element_TypeId",
                table: "tbl_content_element_type_translations",
                column: "Content_Element_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_element_type_translations_LanguageId",
                table: "tbl_content_element_type_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_element_types_Name",
                table: "tbl_content_element_types",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_theme_translations_Content_ThemeId",
                table: "tbl_content_theme_translations",
                column: "Content_ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_theme_translations_LanguageId",
                table: "tbl_content_theme_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_content_themes_Name",
                table: "tbl_content_themes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_elements_Course_Module_TopicId",
                table: "tbl_course_module_topic_elements",
                column: "Course_Module_TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_elements_Difficulty_LevelId",
                table: "tbl_course_module_topic_elements",
                column: "Difficulty_LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topic_elements_Content_Element_TypeId_Cour~",
                table: "tbl_course_module_topic_elements",
                columns: new[] { "Content_Element_TypeId", "Course_Module_TopicId", "Content_ElementId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_module_topics_Course_ModuleId_Title_Sortorder",
                table: "tbl_course_module_topics",
                columns: new[] { "Course_ModuleId", "Title", "Sortorder" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_course_modules_CourseId_Title_Sortorder",
                table: "tbl_course_modules",
                columns: new[] { "CourseId", "Title", "Sortorder" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_courses_Instruction_LanguageId",
                table: "tbl_courses",
                column: "Instruction_LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_courses_Office_ApplicationId",
                table: "tbl_courses",
                column: "Office_ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_courses_ReplicationKey",
                table: "tbl_courses",
                column: "ReplicationKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_courses_UserInterface_LanguageId",
                table: "tbl_courses",
                column: "UserInterface_LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_level_translations_Didactical_Model_Lev~",
                table: "tbl_didactical_model_level_translations",
                column: "Didactical_Model_LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_level_translations_LanguageId",
                table: "tbl_didactical_model_level_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_levels_Didactical_ModelId",
                table: "tbl_didactical_model_levels",
                column: "Didactical_ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_levels_Name",
                table: "tbl_didactical_model_levels",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_levels_Sortorder",
                table: "tbl_didactical_model_levels",
                column: "Sortorder");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_translations_Didactical_ModelId",
                table: "tbl_didactical_model_translations",
                column: "Didactical_ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_model_translations_LanguageId",
                table: "tbl_didactical_model_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_didactical_models_Name",
                table: "tbl_didactical_models",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_difficulty_level_translations_Difficulty_LevelId",
                table: "tbl_difficulty_level_translations",
                column: "Difficulty_LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_difficulty_level_translations_LanguageId",
                table: "tbl_difficulty_level_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_difficulty_levels_Name",
                table: "tbl_difficulty_levels",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_language_translations_LanguageId",
                table: "tbl_language_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_language_translations_Translation_LanguageId",
                table: "tbl_language_translations",
                column: "Translation_LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_languages_Code",
                table: "tbl_languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_languages_Native_Name",
                table: "tbl_languages",
                column: "Native_Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_office_applications_Name",
                table: "tbl_office_applications",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_content_themes_Content_ThemeId",
                table: "tbl_question_content_themes",
                column: "Content_ThemeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_content_themes_QuestionId",
                table: "tbl_question_content_themes",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_formulation_type_translations_LanguageId",
                table: "tbl_question_formulation_type_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_formulation_type_translations_Question_Formulat~",
                table: "tbl_question_formulation_type_translations",
                column: "Question_Formulation_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_learninggoals_Didactical_Model_LevelId",
                table: "tbl_question_learninggoals",
                column: "Didactical_Model_LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_learninggoals_QuestionId",
                table: "tbl_question_learninggoals",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_pre_knowledge_skills_QuestionId",
                table: "tbl_question_pre_knowledge_skills",
                column: "QuestionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_Instruction_LanguageId",
                table: "tbl_questions",
                column: "Instruction_LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_Master_QuestionId",
                table: "tbl_questions",
                column: "Master_QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_Office_ApplicationId",
                table: "tbl_questions",
                column: "Office_ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_Question_Formulation_TypeId",
                table: "tbl_questions",
                column: "Question_Formulation_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_Question_TypeId",
                table: "tbl_questions",
                column: "Question_TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_ReplicationKey",
                table: "tbl_questions",
                column: "ReplicationKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questions_UserInterface_LanguageId",
                table: "tbl_questions",
                column: "UserInterface_LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questiontype_translations_LanguageId",
                table: "tbl_questiontype_translations",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_questiontype_translations_QuestionTypeId",
                table: "tbl_questiontype_translations",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quiz_questions_Quiz_Id_Sortorder",
                table: "tbl_quiz_questions",
                columns: new[] { "Quiz_Id", "Sortorder" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quizzes_ReplicationKey",
                table: "tbl_quizzes",
                column: "ReplicationKey",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_quizzes_Office_Application_Id_Identification_Code",
                table: "tbl_quizzes",
                columns: new[] { "Office_Application_Id", "Identification_Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_roles_Name",
                table: "tbl_roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_user_roles_RoleId",
                table: "tbl_user_roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_user_roles_UserId",
                table: "tbl_user_roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_users_Email",
                table: "tbl_users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_users_LanguageId",
                table: "tbl_users",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_content_element_type_translations");

            migrationBuilder.DropTable(
                name: "tbl_content_theme_translations");

            migrationBuilder.DropTable(
                name: "tbl_course_module_topic_elements");

            migrationBuilder.DropTable(
                name: "tbl_didactical_model_level_translations");

            migrationBuilder.DropTable(
                name: "tbl_didactical_model_translations");

            migrationBuilder.DropTable(
                name: "tbl_difficulty_level_translations");

            migrationBuilder.DropTable(
                name: "tbl_language_translations");

            migrationBuilder.DropTable(
                name: "tbl_question_content_themes");

            migrationBuilder.DropTable(
                name: "tbl_question_formulation_type_translations");

            migrationBuilder.DropTable(
                name: "tbl_question_learninggoals");

            migrationBuilder.DropTable(
                name: "tbl_question_pre_knowledge_skills");

            migrationBuilder.DropTable(
                name: "tbl_questiontype_translations");

            migrationBuilder.DropTable(
                name: "tbl_quiz_questions");

            migrationBuilder.DropTable(
                name: "tbl_quizzes");

            migrationBuilder.DropTable(
                name: "tbl_user_roles");

            migrationBuilder.DropTable(
                name: "tbl_content_element_types");

            migrationBuilder.DropTable(
                name: "tbl_course_module_topics");

            migrationBuilder.DropTable(
                name: "tbl_difficulty_levels");

            migrationBuilder.DropTable(
                name: "tbl_content_themes");

            migrationBuilder.DropTable(
                name: "tbl_didactical_model_levels");

            migrationBuilder.DropTable(
                name: "tbl_questions");

            migrationBuilder.DropTable(
                name: "tbl_roles");

            migrationBuilder.DropTable(
                name: "tbl_users");

            migrationBuilder.DropTable(
                name: "tbl_course_modules");

            migrationBuilder.DropTable(
                name: "tbl_didactical_models");

            migrationBuilder.DropTable(
                name: "tbl_question_formulation_types");

            migrationBuilder.DropTable(
                name: "tbl_questiontypes");

            migrationBuilder.DropTable(
                name: "tbl_courses");

            migrationBuilder.DropTable(
                name: "tbl_languages");

            migrationBuilder.DropTable(
                name: "tbl_office_applications");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERP_Anass_backend.Migrations
{
    /// <inheritdoc />
    public partial class _02_08_ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                 .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Famillies",
                columns: table => new
                {
                    idFamilly = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    familyRef = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    familyName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    familyDesc = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Famillies", x => x.idFamilly);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "articles",
                columns: table => new
                {
                    idArticle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ArticleRef = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ArticleName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionArticle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FamilyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_articles", x => x.idArticle);
                    table.ForeignKey(
                        name: "FK_articles_Famillies_FamilyID",
                        column: x => x.FamilyID,
                        principalTable: "Famillies",
                        principalColumn: "idFamilly");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_articles_FamilyID",
                table: "articles",
                column: "FamilyID");

            migrationBuilder.CreateTable(
                name: "hotel_S_RoomCategorie",
                columns: table => new
                {
                    idRoomType = table.Column<int>(type: "int", nullable: false),
                    idCategorie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotel_S_RoomCategorie", x => new { x.idRoomType, x.idCategorie });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_C_RubriquesExo",
                columns: table => new
                {
                    idExo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeExo = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    libelleExo = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_C_R__3F0AA960AF69F1C7", x => x.idExo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_GroupUsers",
                columns: table => new
                {
                    idGroup = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descGroup = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_GroupU__E0CF5D24B3FE570F", x => x.idGroup);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_Menu",
                columns: table => new
                {
                    idMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeMenu = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomMenu = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    photoMenu = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dataModel = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Menu__C26AF483482986C3", x => x.idMenu);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_MenuSub",
                columns: table => new
                {
                    idSubMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomSubMenu = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codeMenu = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    namePrincipale = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_MenuSu__7821D1082CBCB38C", x => x.idSubMenu);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_salarie",
                columns: table => new
                {
                    idSalarie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomSalarie = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prenomSalarie = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    age = table.Column<int>(type: "int", nullable: true),
                    post = table.Column<string>(type: "longtext", unicode: false, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    salaire = table.Column<double>(type: "double", nullable: true),
                    DateEntree = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__t_salari__A5800341ABBD796C", x => x.idSalarie);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_Pays",
                columns: table => new
                {
                    idPays = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomPays = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Pays__BD257B67F1018B34", x => x.idPays);
                    table.ForeignKey(
                        name: "FK__b_Pays__idGroup__12FDD1B2",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_Taxe",
                columns: table => new
                {
                    idTaxe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomTaxe = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeTaxe = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cauxTaxe = table.Column<int>(type: "int", nullable: true),
                    createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Taxe__C3E11D6649505FF4", x => x.idTaxe);
                    table.ForeignKey(
                        name: "FK__b_Taxe__idGroup__19AACF41",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fish_NomScientifique",
                columns: table => new
                {
                    idNomScientifique = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomScientifique = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fish_Nom__8FBA4602A68646FB", x => x.idNomScientifique);
                    table.ForeignKey(
                        name: "FK_fish_NomScientifique_s_GroupUsers",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fish_TypeFamaille",
                columns: table => new
                {
                    idTypeFamaille = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TypeFamaille = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fish_Typ__9820EADC476505A7", x => x.idTypeFamaille);
                    table.ForeignKey(
                        name: "FK_fish_TypeFamaille_s_GroupUsers",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_Dossier",
                columns: table => new
                {
                    idDossier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nom_dossier = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Activite = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adresse = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Complement = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cp = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Region = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ville = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pays = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fix = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sitee = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tele = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cnss = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Patente = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Iff = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ice = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date_creation = table.Column<DateTime>(type: "datetime", nullable: true),
                    Entet_dossier = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pied_dossier = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Style_dossier = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Logo = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    domainName = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    wooClientKey = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    wooClientSecret = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateExeStart = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateExeEnd = table.Column<DateTime>(type: "datetime", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Objectif = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Dossie__43081945B4A81825", x => x.idDossier);
                    table.ForeignKey(
                        name: "FK__s_Dossier__idGro__689D8392",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_Roles",
                columns: table => new
                {
                    idRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nameRole = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    insertRole = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    updateRole = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    deleteRole = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    selectByUser = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    selectALL = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    selectDoc = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    imprimerRole = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    valider = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    selectArticles = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Roles__E5045C546FDECAAF", x => x.idRole);
                    table.ForeignKey(
                        name: "FK__s_Roles__idGroup__77DFC722",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_Settings",
                columns: table => new
                {
                    idSettings = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    currencyFormat = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qteFormat = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tvaCheck = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ttcCheck = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    subDepot = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Settin__C7066F18CFD5BD87", x => x.idSettings);
                    table.ForeignKey(
                        name: "FK__s_Setting__idGro__78D3EB5B",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_Users",
                columns: table => new
                {
                    idUser = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomUser = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailUser = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passwordUser = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adresseUser = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    teleUser = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    userPhoto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tokenLogin = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lastLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    outLoginDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    typeAdmin = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Users__3717C9821D916FB4", x => x.idUser);
                    table.ForeignKey(
                        name: "FK__s_Users__idGroup__7D98A078",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_Ville",
                columns: table => new
                {
                    idVille = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomVille = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idPays = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Ville__A33D0147277D3BB4", x => x.idVille);
                    table.ForeignKey(
                        name: "FK__b_Ville__idGroup__1C873BEC",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "fk_b_ville_b_pays",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "e_TypeDoc",
                columns: table => new
                {
                    codeType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDossier = table.Column<int>(type: "int", nullable: false),
                    numFacture = table.Column<int>(type: "int", nullable: true),
                    nomFacture = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valStock = table.Column<int>(type: "int", nullable: true),
                    valCmup = table.Column<int>(type: "int", nullable: true),
                    valFifo = table.Column<int>(type: "int", nullable: true),
                    valLifo = table.Column<int>(type: "int", nullable: true),
                    valCaisse = table.Column<int>(type: "int", nullable: true),
                    codeCl_FR = table.Column<int>(type: "int", nullable: true),
                    calculMarge = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e_TypeDo__DEFF6F468DB4A912", x => new { x.codeType, x.idDossier });
                    table.ForeignKey(
                        name: "FK__e_TypeDoc__idDos__36470DEF",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "a_Famille",
                columns: table => new
                {
                    idFamille = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomFamille = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    desFamille = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    photoFamille = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    wooFamille = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    parentId = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idWooCategories = table.Column<int>(type: "int", nullable: true),
                    idTypeFamaille = table.Column<long>(type: "bigint", nullable: true),
                    idNomScientifique = table.Column<long>(type: "bigint", nullable: true),
                    CDE_FAO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idPays = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__a_Famill__CC8A49782C7E39D3", x => x.idFamille);
                    table.ForeignKey(
                        name: "FK__a_Famille__idGro__05A3D694",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__a_Famille__idUse__0697FACD",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK_a_Famille_fish_TypeFamaille",
                        column: x => x.idTypeFamaille,
                        principalTable: "fish_TypeFamaille",
                        principalColumn: "idTypeFamaille");
                    table.ForeignKey(
                        name: "FK_a_Famillefish_NomScientifique",
                        column: x => x.idNomScientifique,
                        principalTable: "fish_NomScientifique",
                        principalColumn: "idNomScientifique");
                    table.ForeignKey(
                        name: "FK_a_Famillefish_b_Pays",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_ModRglm",
                columns: table => new
                {
                    idModRglm = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomModRglm = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    categModRglm = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    timbre = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_ModRgl__07F252FE436F7847", x => x.idModRglm);
                    table.ForeignKey(
                        name: "FK__b_ModRglm__idGro__11158940",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__b_ModRglm__idUse__1209AD79",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_Propriete",
                columns: table => new
                {
                    idPropriete = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomPropriete = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Propri__B315A60B58F0AEBB", x => x.idPropriete);
                    table.ForeignKey(
                        name: "FK__b_Proprie__idGro__13F1F5EB",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__b_Proprie__idUse__14E61A24",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_Service",
                columns: table => new
                {
                    idService = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomService = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descService = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Servic__0E3EA45B6E72B811", x => x.idService);
                    table.ForeignKey(
                        name: "FK__b_Service__idGro__15DA3E5D",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__b_Service__idUse__16CE6296",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_Tresorerie",
                columns: table => new
                {
                    idTreso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nameTreso = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soldAutoriseTreso = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    cherfTreso = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    defaultTreso = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    adresseTreso = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ribTreso = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Tresor__0393F6035C83AC24", x => x.idTreso);
                    table.ForeignKey(
                        name: "FK__b_Tresore__idGro__1A9EF37A",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__b_Tresore__idUse__1B9317B3",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "d_Departement",
                columns: table => new
                {
                    idDepartement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomDepartement = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descDepartement = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__d_Depart__9E93B3EBF32C9097", x => x.idDepartement);
                    table.ForeignKey(
                        name: "FK__d_Departe__idGro__1E6F845E",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__d_Departe__idUse__1F63A897",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "e_Emails",
                columns: table => new
                {
                    idEmail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    to = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    subject = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    uid = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    folder = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateEmail = table.Column<DateTime>(type: "datetime", nullable: true),
                    attachements = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    seen = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    fromName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e_Emails__DF5377108F312834", x => x.idEmail);
                    table.ForeignKey(
                        name: "FK__e_Emails__idGrou__2334397B",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__e_Emails__idUser__24285DB4",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fish_famille",
                columns: table => new
                {
                    idFamille = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CDE_FAO = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    marchandises = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idNomScientifique = table.Column<long>(type: "bigint", nullable: true),
                    idTypeFamaille = table.Column<long>(type: "bigint", nullable: true),
                    idPays = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fish_famille", x => x.idFamille);
                    table.ForeignKey(
                        name: "FK_fish_famille_b_pays",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                    table.ForeignKey(
                        name: "FK_fish_famille_fish_NomScientifique",
                        column: x => x.idNomScientifique,
                        principalTable: "fish_NomScientifique",
                        principalColumn: "idNomScientifique");
                    table.ForeignKey(
                        name: "FK_fish_famille_fish_TypeFamaille",
                        column: x => x.idTypeFamaille,
                        principalTable: "fish_TypeFamaille",
                        principalColumn: "idTypeFamaille");
                    table.ForeignKey(
                        name: "FK_fish_famille_s_GroupUsers",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK_fish_famille_s_Users",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fish_port",
                columns: table => new
                {
                    idPort = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomPort = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fish_por__BE0CD9EE2D94B3B9", x => x.idPort);
                    table.ForeignKey(
                        name: "fk_fish_port_s_GroupUsers",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "fk_fish_port_s_user",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_S_Categorie",
                columns: table => new
                {
                    idCategorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    categName = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__hotel_S___8A3D24089B0DDAC1", x => x.idCategorie);
                    table.ForeignKey(
                        name: "FK__hotel_S_C__idGro__68D28DBC",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__hotel_S_C__idUse__69C6B1F5",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_S_Extras",
                columns: table => new
                {
                    idExtras = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    extrasName = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descExtras = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prix_HT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    idTaxeExtras = table.Column<int>(type: "int", nullable: true),
                    prix_TTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    sortExtras = table.Column<int>(type: "int", nullable: true),
                    qteMax = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    photoExtras = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__hotel_S___56B7E5378449ABA0", x => x.idExtras);
                    table.ForeignKey(
                        name: "FK__hotel_S_E__idGro__6BAEFA67",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__hotel_S_E__idTax__6CA31EA0",
                        column: x => x.idTaxeExtras,
                        principalTable: "b_Taxe",
                        principalColumn: "idTaxe");
                    table.ForeignKey(
                        name: "FK__hotel_S_E__idUse__6D9742D9",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_S_RoomType",
                columns: table => new
                {
                    idRoomType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nameRoomType = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descRoomType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nbGuests = table.Column<int>(type: "int", nullable: true),
                    maxNbGuests = table.Column<int>(type: "int", nullable: true),
                    priceModel = table.Column<int>(type: "int", nullable: true),
                    prixLouer_HT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    idTaxeLouer = table.Column<int>(type: "int", nullable: true),
                    prixVente_TTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    sortOrder = table.Column<int>(type: "int", nullable: true),
                    objectType = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    photoRoomType = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__hotel_S___9D810D3FDD8616BB", x => x.idRoomType);
                    table.ForeignKey(
                        name: "FK__hotel_S_R__idGro__6E8B6712",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__hotel_S_R__idTax__6F7F8B4B",
                        column: x => x.idTaxeLouer,
                        principalTable: "b_Taxe",
                        principalColumn: "idTaxe");
                    table.ForeignKey(
                        name: "FK__hotel_S_R__idUse__7073AF84",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Maint_S_Team",
                columns: table => new
                {
                    idTeam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomTeam = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeTeam = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Maint_S___BCD885CFE1376C3C", x => x.idTeam);
                    table.ForeignKey(
                        name: "FK__Maint_S_T__idGro__7EC1CEDB",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Maint_S_T__idUse__7FB5F314",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_Caissier",
                columns: table => new
                {
                    idCaissier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nameCaissier = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passCaissier = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adminCaissier = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    avoirCheck = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    prixCheck = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    remCheck = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    fermerCheck = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    archiveChecke = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    anulatinTicket = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_Caissi__A1A63F8DB2FF02F3", x => x.idCaissier);
                    table.ForeignKey(
                        name: "FK__p_Caissie__idGro__00AA174D",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__p_Caissie__idUse__019E3B86",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_C_Rubriques",
                columns: table => new
                {
                    idRubrique = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeRubrique = table.Column<int>(type: "int", nullable: true),
                    libelleRubrique = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codeExo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    imposable = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    positive = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    valeur = table.Column<double>(type: "double", nullable: true),
                    taux = table.Column<double>(type: "double", nullable: true),
                    tauxPenalite = table.Column<double>(type: "double", nullable: true),
                    tauxMajoration1 = table.Column<double>(type: "double", nullable: true),
                    tauxMajorationAutres = table.Column<double>(type: "double", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_C_R__72CA0C17E9CC074A", x => x.idRubrique);
                    table.ForeignKey(
                        name: "FK__Paie_C_Ru__idGro__1881A0DE",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_C_Ru__idUse__1975C517",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_C_Variables",
                columns: table => new
                {
                    idVariable = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeVar = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    libelleVar = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valeurVar = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    propreSal = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_C_V__EF2620BCC122025B", x => x.idVariable);
                    table.ForeignKey(
                        name: "FK__Paie_C_Va__idGro__1A69E950",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_C_Va__idUse__1B5E0D89",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Calcul_bulletin",
                columns: table => new
                {
                    IdBulletin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numBulletin = table.Column<int>(type: "int", nullable: true),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    periodeD = table.Column<DateTime>(type: "datetime", nullable: true),
                    periodeF = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    valider = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    descPaie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cloturer = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    mois = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Cal__66989D1EC8F3C161", x => x.IdBulletin);
                    table.ForeignKey(
                        name: "fk_Paie_Calcul_bulletin_dossier",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "fk_Paie_Calcul_bulletin_groupUser",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "fk_Paie_Calcul_bulletin_user",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Calcul_GrpEntete",
                columns: table => new
                {
                    idGrpEnt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numPaie = table.Column<int>(type: "int", nullable: true),
                    datePaie = table.Column<DateTime>(type: "datetime", nullable: true),
                    valider = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    cloturer = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    mois = table.Column<int>(type: "int", nullable: true),
                    periodeD = table.Column<DateTime>(type: "datetime", nullable: true),
                    periodeF = table.Column<DateTime>(type: "datetime", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    descPaie = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Cal__576CEFB610A65BCB", x => x.idGrpEnt);
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idDos__29AC2CE0",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idGro__2AA05119",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idUse__2B947552",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paie_I_Categorie",
                columns: table => new
                {
                    idCategorie = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomCategorie = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__paie_I_C__8A3D2408E6D8ED01", x => x.idCategorie);
                    table.ForeignKey(
                        name: "FK__paie_I_Ca__idGro__436BFEE3",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__paie_I_Ca__idUse__4460231C",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paie_I_Departement",
                columns: table => new
                {
                    idDepartement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomDepartement = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__paie_I_D__9E93B3EBC1C59A28", x => x.idDepartement);
                    table.ForeignKey(
                        name: "FK__paie_I_De__idGro__45544755",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__paie_I_De__idUse__46486B8E",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paie_I_Fonction",
                columns: table => new
                {
                    idFonction = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomFonction = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__paie_I_F__14817A4816B153EE", x => x.idFonction);
                    table.ForeignKey(
                        name: "FK__paie_I_Fo__idGro__473C8FC7",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__paie_I_Fo__idUse__4830B400",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paie_I_Niveau",
                columns: table => new
                {
                    idNiveau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomNiveau = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__paie_I_N__8D81C23E32EBD846", x => x.idNiveau);
                    table.ForeignKey(
                        name: "FK__paie_I_Ni__idGro__4924D839",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__paie_I_Ni__idUse__4A18FC72",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paie_I_ProfilContrat",
                columns: table => new
                {
                    idProfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomProfil = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    partSalariel = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    allFamiliel = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    formationProf = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    cotisationPatr = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    iR = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    plafondIR = table.Column<double>(type: "double", nullable: true),
                    typeProfil = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__paie_I_P__2389837BE75EC0D2", x => x.idProfil);
                    table.ForeignKey(
                        name: "FK__paie_I_Pr__idGro__4B0D20AB",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__paie_I_Pr__idUse__4C0144E4",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paie_I_TauxFraisProf",
                columns: table => new
                {
                    idTaux = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeTaux = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    libelleTaux = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    taux = table.Column<double>(type: "double", nullable: true),
                    plafond = table.Column<double>(type: "double", nullable: true),
                    refTaux = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__paie_I_T__C3E0C46D489FAE11", x => x.idTaux);
                    table.ForeignKey(
                        name: "FK__paie_I_Ta__idGro__4CF5691D",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__paie_I_Ta__idUse__4DE98D56",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_P_POINTAGE",
                columns: table => new
                {
                    idPointage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    mois = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descrPointage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numPointage = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_P_P__3875EEE7C9C81FCF", x => x.idPointage);
                    table.ForeignKey(
                        name: "fk_Paie_P_POINTAGE_idGroup",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "fk_Paie_P_POINTAGE_idUser",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "fk_pointage_dossier",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Z_Planning",
                columns: table => new
                {
                    idPlanning = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomPlanning = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    heureDepartDe = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    heureDepartA = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    heurePauseDe = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    heurePauseA = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    heureSortie = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    checkPause = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Z_P__B185E000B4197857", x => x.idPlanning);
                    table.ForeignKey(
                        name: "FK__Paie_Z_Pl__idGro__5772F790",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_Z_Pl__idUse__58671BC9",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Z_ZKTDevices",
                columns: table => new
                {
                    idDevice = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nameDevice = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ipDevice = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    portDevice = table.Column<int>(type: "int", nullable: true),
                    machingNumber = table.Column<int>(type: "int", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Z_Z__FB43DB0429D0A54F", x => x.idDevice);
                    table.ForeignKey(
                        name: "FK__Paie_Z_ZK__idGro__5C37ACAD",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_Z_ZK__idUse__5D2BD0E6",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_EmailsSettings",
                columns: table => new
                {
                    idESettings = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    urlServer = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    urlAttach = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hostSm = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usernameSm = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passwordSm = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    portSm = table.Column<int>(type: "int", nullable: true),
                    fromNameSm = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checkSMTP = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    hostIm = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    usernameIm = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passwordIm = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    portIm = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Emails__3CB665854665DFA7", x => x.idESettings);
                    table.ForeignKey(
                        name: "FK__s_EmailsS__idGro__6991A7CB",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__s_EmailsS__idUse__6A85CC04",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_Fille",
                columns: table => new
                {
                    idFille = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nameFile = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pathFile = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeFile = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sizeFile = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_Fille__9670A138AD82BE04", x => x.idFille);
                    table.ForeignKey(
                        name: "FK__s_Fille__idGroup__6B79F03D",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__s_Fille__idUser__6C6E1476",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_MenuInstall",
                columns: table => new
                {
                    idMenu = table.Column<int>(type: "int", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__s_MenuIns__idGro__7226EDCC",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__s_MenuIns__idMen__731B1205",
                        column: x => x.idMenu,
                        principalTable: "s_Menu",
                        principalColumn: "idMenu");
                    table.ForeignKey(
                        name: "FK__s_MenuIns__idUse__740F363E",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_MenuSubInstall",
                columns: table => new
                {
                    idSubMenu = table.Column<int>(type: "int", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__s_MenuSub__idGro__75035A77",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__s_MenuSub__idSub__75F77EB0",
                        column: x => x.idSubMenu,
                        principalTable: "s_MenuSub",
                        principalColumn: "idSubMenu");
                    table.ForeignKey(
                        name: "FK__s_MenuSub__idUse__76EBA2E9",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_UserDossier",
                columns: table => new
                {
                    idUser = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDossier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_UserDo__732748166511DB00", x => new { x.idUser, x.idDossier });
                    table.ForeignKey(
                        name: "FK__s_UserDos__idDos__79C80F94",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__s_UserDos__idUse__7ABC33CD",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_UserRoles",
                columns: table => new
                {
                    idRole = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_UserRo__D67520CC0F857492", x => new { x.idRole, x.idUser });
                    table.ForeignKey(
                        name: "FK__s_UserRol__idRol__7BB05806",
                        column: x => x.idRole,
                        principalTable: "s_Roles",
                        principalColumn: "idRole");
                    table.ForeignKey(
                        name: "FK__s_UserRol__idUse__7CA47C3F",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sb_CreationBarCode",
                columns: table => new
                {
                    idCreation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    dimensionW = table.Column<double>(type: "double", nullable: true),
                    dimensionH = table.Column<double>(type: "double", nullable: true),
                    vBarWidth = table.Column<double>(type: "double", nullable: true),
                    vBarHeight = table.Column<double>(type: "double", nullable: true),
                    meta = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codeType = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sb_Creat__FA6C5830232E1A42", x => x.idCreation);
                    table.ForeignKey(
                        name: "FK__sb_Creati__idDos__7E8CC4B1",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__sb_Creati__idGro__7F80E8EA",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__sb_Creati__idUse__00750D23",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sc_calendar",
                columns: table => new
                {
                    idCalendar = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    @checked = table.Column<bool>(name: "checked", type: "tinyint(1)", nullable: true),
                    color = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bgColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    borderColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dragBgColor = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sc_calen__B35CADE53E6CEB56", x => x.idCalendar);
                    table.ForeignKey(
                        name: "FK__sc_calend__idGro__0169315C",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__sc_calend__idUse__025D5595",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "u_UniteMesure",
                columns: table => new
                {
                    idUnite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descUnite = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    prcpUnite = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__u_UniteM__91C8610CE18BAC6D", x => x.idUnite);
                    table.ForeignKey(
                        name: "FK__u_UniteMe__idGro__1C1D2798",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__u_UniteMe__idUse__1D114BD1",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_Depot",
                columns: table => new
                {
                    idDepot = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomDepot = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adressDepot = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prcpDepot = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idVille = table.Column<int>(type: "int", nullable: true),
                    idPays = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_Depot__F1B853A3BEB7A511", x => x.idDepot);
                    table.ForeignKey(
                        name: "FK__b_Depot__idGroup__0A688BB1",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__b_Depot__idPays__0B5CAFEA",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                    table.ForeignKey(
                        name: "FK__b_Depot__idUser__0C50D423",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK__b_Depot__idVille__0D44F85C",
                        column: x => x.idVille,
                        principalTable: "b_Ville",
                        principalColumn: "idVille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_Client",
                columns: table => new
                {
                    idClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomClient = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adresseClient = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postalClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iceClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnssClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nifClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    patenteClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    siegeClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    banqueClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ribClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soldAutoriseClient = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    frmJuridiqueClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailClient = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    teleClient = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fixClient = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeClient = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contratClient = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    vendeurClient = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    distributeur = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idVille = table.Column<int>(type: "int", nullable: true),
                    idPays = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    cinClient = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    potentielClt = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    categorieClt = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    origineContact = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    siteweb = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    propriete = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    incoterms = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    autorizacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__t_Client__A6A610D4B1A3F292", x => x.idClient);
                    table.ForeignKey(
                        name: "FK__t_Client__idGrou__062DE679",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__t_Client__idPays__08162EEB",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                    table.ForeignKey(
                        name: "FK__t_Client__idUser__09FE775D",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK__t_Client__idVill__0BE6BFCF",
                        column: x => x.idVille,
                        principalTable: "b_Ville",
                        principalColumn: "idVille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_Fournisseur",
                columns: table => new
                {
                    idFournisseur = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomFournisseur = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adresseFournisseur = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postalFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    iceFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cnssFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nifFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    patenteFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    siegeFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    banqueFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ribFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    soldAutoriseFournisseur = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    frmJuridiqueFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    emailFournisseur = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    teleFournisseur = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fixFournisseur = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeFournisseur = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contratFournisseur = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    fournisseur = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    sous_traitance = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    createdate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idVille = table.Column<int>(type: "int", nullable: true),
                    idPays = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    cinFournisseur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    potentielFR = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    categorieFR = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    origineContactFR = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sitewebFr = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__t_Fourni__9850876A0EADB6B4", x => x.idFournisseur);
                    table.ForeignKey(
                        name: "FK__t_Fournis__idGro__0FB750B3",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__t_Fournis__idPay__10AB74EC",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                    table.ForeignKey(
                        name: "FK__t_Fournis__idUse__119F9925",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK__t_Fournis__idVil__1293BD5E",
                        column: x => x.idVille,
                        principalTable: "b_Ville",
                        principalColumn: "idVille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fish_charge",
                columns: table => new
                {
                    idCharge = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEntet = table.Column<int>(type: "int", nullable: true),
                    idService = table.Column<int>(type: "int", nullable: true),
                    cout = table.Column<double>(type: "double", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fish_cha__5B96E1AC749E3A9D", x => x.idCharge);
                    table.ForeignKey(
                        name: "FK_fish_charge_b_Service",
                        column: x => x.idService,
                        principalTable: "b_Service",
                        principalColumn: "idService");
                    table.ForeignKey(
                        name: "FK_fish_charge_s_GroupUsers",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_SoldTresorerie",
                columns: table => new
                {
                    idTreso = table.Column<int>(type: "int", nullable: false),
                    idDossier = table.Column<int>(type: "int", nullable: false),
                    soldTresorerie = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_SoldTr__47A377971E1310B8", x => new { x.idTreso, x.idDossier });
                    table.ForeignKey(
                        name: "FK__b_SoldTre__idDos__17C286CF",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__b_SoldTre__idTre__18B6AB08",
                        column: x => x.idTreso,
                        principalTable: "b_Tresorerie",
                        principalColumn: "idTreso");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tr_TresorerieEntet",
                columns: table => new
                {
                    idTresoEntet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numTresoEntet = table.Column<int>(type: "int", nullable: true),
                    dateTresoEntet = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateEcheanche = table.Column<DateTime>(type: "datetime", nullable: true),
                    banque = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numCheque = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    etatDoc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    montant = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    descTresoEntet = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codeType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idModRglm = table.Column<int>(type: "int", nullable: true),
                    idTreso = table.Column<int>(type: "int", nullable: true),
                    idTreso_2 = table.Column<int>(type: "int", nullable: true),
                    idService = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tr_Treso__FEA43A3ACFADC22A", x => x.idTresoEntet);
                    table.ForeignKey(
                        name: "FK__tr_Tresor__idDos__15702A09",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__tr_Tresor__idGro__16644E42",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__tr_Tresor__idMod__1758727B",
                        column: x => x.idModRglm,
                        principalTable: "b_ModRglm",
                        principalColumn: "idModRglm");
                    table.ForeignKey(
                        name: "FK__tr_Tresor__idSer__184C96B4",
                        column: x => x.idService,
                        principalTable: "b_Service",
                        principalColumn: "idService");
                    table.ForeignKey(
                        name: "FK__tr_Tresor__idTre__1940BAED",
                        column: x => x.idTreso,
                        principalTable: "b_Tresorerie",
                        principalColumn: "idTreso");
                    table.ForeignKey(
                        name: "FK__tr_Tresor__idTre__1A34DF26",
                        column: x => x.idTreso_2,
                        principalTable: "b_Tresorerie",
                        principalColumn: "idTreso");
                    table.ForeignKey(
                        name: "FK__tr_Tresor__idUse__1B29035F",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_S_Equipements",
                columns: table => new
                {
                    idRoomType = table.Column<int>(type: "int", nullable: true),
                    valeurEquip = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    textEquip = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__hotel_S_E__idRoo__6ABAD62E",
                        column: x => x.idRoomType,
                        principalTable: "hotel_S_RoomType",
                        principalColumn: "idRoomType");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_S_Units",
                columns: table => new
                {
                    idUnit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    unitName = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idRoomType = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__hotel_S___34420721A31B2E3B", x => x.idUnit);
                    table.ForeignKey(
                        name: "FK__hotel_S_U__idRoo__7167D3BD",
                        column: x => x.idRoomType,
                        principalTable: "hotel_S_RoomType",
                        principalColumn: "idRoomType");
                    table.ForeignKey(
                        name: "FK__hotel_S_U__idUse__725BF7F6",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Z_UserDevice",
                columns: table => new
                {
                    idUserDevice = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    enrolNumber = table.Column<int>(type: "int", nullable: true),
                    name = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    passwordU = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDevice = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Z_U__65DA88BCEC24D13B", x => x.idUserDevice);
                    table.ForeignKey(
                        name: "FK__Paie_Z_Us__idDev__595B4002",
                        column: x => x.idDevice,
                        principalTable: "Paie_Z_ZKTDevices",
                        principalColumn: "idDevice");
                    table.ForeignKey(
                        name: "FK__Paie_Z_Us__idGro__5A4F643B",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_Z_Us__idUse__5B438874",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "e_FilleInEmails",
                columns: table => new
                {
                    idEmail = table.Column<int>(type: "int", nullable: false),
                    idFille = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e_FilleI__46347D03E0F491FE", x => new { x.idEmail, x.idFille });
                    table.ForeignKey(
                        name: "FK__e_FilleIn__idEma__32767D0B",
                        column: x => x.idEmail,
                        principalTable: "e_Emails",
                        principalColumn: "idEmail");
                    table.ForeignKey(
                        name: "FK__e_FilleIn__idFil__336AA144",
                        column: x => x.idFille,
                        principalTable: "s_Fille",
                        principalColumn: "idFille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "sc_schedule",
                columns: table => new
                {
                    idSchedule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    body = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    isAllday = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    start = table.Column<DateTime>(type: "datetime", nullable: true),
                    endd = table.Column<DateTime>(type: "datetime", nullable: true),
                    isPrivate = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    nomTier = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idCalendar = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    heureStart = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    heureEndd = table.Column<TimeOnly>(type: "time(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__sc_sched__5717CA9456DDDB20", x => x.idSchedule);
                    table.ForeignKey(
                        name: "FK__sc_schedu__idCal__035179CE",
                        column: x => x.idCalendar,
                        principalTable: "sc_calendar",
                        principalColumn: "idCalendar");
                    table.ForeignKey(
                        name: "FK__sc_schedu__idGro__04459E07",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__sc_schedu__idUse__0539C240",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "a_Article",
                columns: table => new
                {
                    idArticle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    refArticle = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codeBareArticle = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nomArticle = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descArticle = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    favorisArticle = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    photoArticle = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    achatArticle = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    venteArticle = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    locationArticle = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    typeArticle = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prixAchat_HT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixAchat_HT_1 = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixAchat_TTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixAchat_TTC_1 = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixVente_HT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixVente_HT_1 = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixVente_TTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixVente_TTC_1 = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixlocation_HT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixlocation_TTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    classmentArticle = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stkMinArticle = table.Column<double>(type: "double", nullable: true),
                    wooArticle = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idWooProducts = table.Column<int>(type: "int", nullable: true),
                    metaWooArticle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    metaArticle = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    pourCentArticle = table.Column<double>(type: "double", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idFamille = table.Column<int>(type: "int", nullable: true),
                    idTaxeAchat = table.Column<int>(type: "int", nullable: true),
                    idTaxeVente = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    qteBox = table.Column<double>(type: "double", nullable: true),
                    checkDureDevie = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    stateDureDevie = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dureDevie = table.Column<int>(type: "int", nullable: true),
                    prixVente_HT_2 = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixVente_TTC_2 = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    checkBateau = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    mesureArticle = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUnite = table.Column<int>(type: "int", nullable: true),
                    checkMaintenance = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    codePdFini = table.Column<int>(type: "int", nullable: true),
                    PdFini = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__a_Articl__6719B9B36422FA22", x => x.idArticle);
                    table.ForeignKey(
                        name: "FK__a_Article__idFam__7C1A6C5A",
                        column: x => x.idFamille,
                        principalTable: "a_Famille",
                        principalColumn: "idFamille");
                    table.ForeignKey(
                        name: "FK__a_Article__idGro__7D0E9093",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__a_Article__idTax__7E02B4CC",
                        column: x => x.idTaxeAchat,
                        principalTable: "b_Taxe",
                        principalColumn: "idTaxe");
                    table.ForeignKey(
                        name: "FK__a_Article__idTax__7EF6D905",
                        column: x => x.idTaxeVente,
                        principalTable: "b_Taxe",
                        principalColumn: "idTaxe");
                    table.ForeignKey(
                        name: "FK__a_Article__idUni__7FEAFD3E",
                        column: x => x.idUnite,
                        principalTable: "u_UniteMesure",
                        principalColumn: "idUnite");
                    table.ForeignKey(
                        name: "FK__a_Article__idUse__00DF2177",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "b_DepotSup",
                columns: table => new
                {
                    idSupDepot = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomSupDepot = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prcpSupDepot = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    infoSupDepot = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDepot = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    typeSupDepot = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    couloirX = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rayonY = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hauteur = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    codeBare = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__b_DepotS__411440C9D14DCF4D", x => x.idSupDepot);
                    table.ForeignKey(
                        name: "FK__b_DepotSu__idDep__0E391C95",
                        column: x => x.idDepot,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__b_DepotSu__idGro__0F2D40CE",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__b_DepotSu__idUse__10216507",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "s_LiaisonUsers",
                columns: table => new
                {
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDepot = table.Column<int>(type: "int", nullable: true),
                    idTreso = table.Column<int>(type: "int", nullable: true),
                    idVille = table.Column<int>(type: "int", nullable: true),
                    idPays = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__s_Liaison__idDep__6D6238AF",
                        column: x => x.idDepot,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__s_Liaison__idPay__6E565CE8",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                    table.ForeignKey(
                        name: "FK__s_Liaison__idTre__6F4A8121",
                        column: x => x.idTreso,
                        principalTable: "b_Tresorerie",
                        principalColumn: "idTreso");
                    table.ForeignKey(
                        name: "FK__s_Liaison__idUse__703EA55A",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK__s_Liaison__idVil__7132C993",
                        column: x => x.idVille,
                        principalTable: "b_Ville",
                        principalColumn: "idVille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fish_entet",
                columns: table => new
                {
                    idEntet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numFactur = table.Column<int>(type: "int", nullable: true),
                    refFacture = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idFournisseur = table.Column<int>(type: "int", nullable: true),
                    dateEntet = table.Column<DateOnly>(type: "date", nullable: true),
                    idPays = table.Column<int>(type: "int", nullable: true),
                    ETAT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idFamille = table.Column<int>(type: "int", nullable: true),
                    stockEntree = table.Column<double>(type: "double", nullable: true),
                    stockTaxable = table.Column<double>(type: "double", nullable: true),
                    totalAchat = table.Column<double>(type: "double", nullable: true),
                    PM = table.Column<double>(type: "double", nullable: true),
                    totalCharges = table.Column<double>(type: "double", nullable: true),
                    comission = table.Column<double>(type: "double", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idClient = table.Column<int>(type: "int", nullable: true),
                    codeType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idPort = table.Column<int>(type: "int", nullable: true),
                    kgRec = table.Column<double>(type: "double", nullable: true),
                    valider = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    etatDoc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    clotur = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    barco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TotalCais = table.Column<double>(type: "double", nullable: true),
                    TotalPN = table.Column<double>(type: "double", nullable: true),
                    Lote = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DUA = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateCongele = table.Column<DateOnly>(type: "date", nullable: true),
                    idEntetS = table.Column<int>(type: "int", nullable: true),
                    numBon_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantite_plt = table.Column<double>(type: "double", nullable: true),
                    facturNum_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dua_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_plt = table.Column<DateOnly>(type: "date", nullable: true),
                    numBonL_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantiteL_plt = table.Column<double>(type: "double", nullable: true),
                    dateL_plt = table.Column<DateOnly>(type: "date", nullable: true),
                    facturNumL_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duaL_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoteL_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fish_ent__53DEA1113C7FFD0D", x => x.idEntet);
                    table.ForeignKey(
                        name: "FK_fish_entet_a_Famille",
                        column: x => x.idFamille,
                        principalTable: "a_Famille",
                        principalColumn: "idFamille");
                    table.ForeignKey(
                        name: "FK_fish_entet_s_GroupUsers",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK_fish_entet_s_User",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK_fish_entet_t_Client",
                        column: x => x.idClient,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                    table.ForeignKey(
                        name: "fk_fish_entet_b_Pays",
                        column: x => x.idPays,
                        principalTable: "b_Pays",
                        principalColumn: "idPays");
                    table.ForeignKey(
                        name: "fk_fish_entet_fish_port",
                        column: x => x.idPort,
                        principalTable: "fish_port",
                        principalColumn: "idPort");
                    table.ForeignKey(
                        name: "fk_fish_entet_s_dossier",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_B_BookingEntete",
                columns: table => new
                {
                    idBookingEntete = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    bookingInDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    bookingOutDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    tt_NbGuest = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idClient = table.Column<int>(type: "int", nullable: true),
                    checkIn = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    checkInDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    checkOut = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    checkOutDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    message = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    comment = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cancel = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    cancelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    numBooking = table.Column<int>(type: "int", nullable: true),
                    nbNights = table.Column<int>(type: "int", nullable: true),
                    infoClients = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    totalEnteteHT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    totalEnteteTTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    totalEnteteUnPaye = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__hotel_B___EF8BA5E9340E3854", x => x.idBookingEntete);
                    table.ForeignKey(
                        name: "FK__hotel_B_B__idCli__5A846E65",
                        column: x => x.idClient,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                    table.ForeignKey(
                        name: "FK__hotel_B_B__idDos__5B78929E",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__hotel_B_B__idGro__5C6CB6D7",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__hotel_B_B__idUse__5D60DB10",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_Pos",
                columns: table => new
                {
                    idPos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tokenPos = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    namePos = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titrePos = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    souTitrePos = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    msgPos = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checkEmail = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    emailSend = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checkOpenSession = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idTreso = table.Column<int>(type: "int", nullable: true),
                    idDepot = table.Column<int>(type: "int", nullable: true),
                    clientDivers = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_Pos__3D78A0B7B32D34E0", x => x.idPos);
                    table.ForeignKey(
                        name: "FK__p_Pos__clientDiv__0662F0A3",
                        column: x => x.clientDivers,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                    table.ForeignKey(
                        name: "FK__p_Pos__idDepot__075714DC",
                        column: x => x.idDepot,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__p_Pos__idDossier__084B3915",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__p_Pos__idGroup__093F5D4E",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__p_Pos__idTreso__0A338187",
                        column: x => x.idTreso,
                        principalTable: "b_Tresorerie",
                        principalColumn: "idTreso");
                    table.ForeignKey(
                        name: "FK__p_Pos__idUser__0B27A5C0",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_ClientCredit",
                columns: table => new
                {
                    idClient = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    credit = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__t_ClientC__idCli__0DCF0841",
                        column: x => x.idClient,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                    table.ForeignKey(
                        name: "FK__t_ClientC__idDos__0EC32C7A",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "e_Entet",
                columns: table => new
                {
                    idEntet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numFactur = table.Column<int>(type: "int", nullable: true),
                    refFactur = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateEntet = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateEcheanche = table.Column<DateTime>(type: "datetime", nullable: true),
                    nom = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    info = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valider = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    clotur = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TT_ttc = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TT_ht = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TT_tva = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TT_remis = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TT_MargeCmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TT_MargePxAcha = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TT_TauxMargeCmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TT_TauxMargePxAcha = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    timbre = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TT_net = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    avance = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    etatDoc = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numCheq = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    remiseGlobal = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    teypGlobal = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    tva = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    ttc = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    obs = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checkExpiration = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    meta = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idModRglm = table.Column<int>(type: "int", nullable: true),
                    idDepot = table.Column<int>(type: "int", nullable: true),
                    idDepot_2 = table.Column<int>(type: "int", nullable: true),
                    idClient = table.Column<int>(type: "int", nullable: true),
                    idFournisseur = table.Column<int>(type: "int", nullable: true),
                    codeType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idVendeur = table.Column<int>(type: "int", nullable: true),
                    terms = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    metaImpression = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    proprieteClient = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeLigne = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateValidation = table.Column<DateTime>(type: "datetime", nullable: true),
                    checkCopierVers = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idFamille = table.Column<int>(type: "int", nullable: true),
                    idDestinataire = table.Column<int>(type: "int", nullable: true),
                    nomDestinataire = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    truck = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tauxPlastique = table.Column<double>(type: "double", nullable: true),
                    SumNetWeight = table.Column<double>(type: "double", nullable: true),
                    SumUnitePrice = table.Column<double>(type: "double", nullable: true),
                    changeDH = table.Column<double>(type: "double", nullable: true),
                    certificatEuro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LotePF = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MtPremier = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroTaux = table.Column<int>(type: "int", nullable: true),
                    lote = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TauxGalce = table.Column<double>(type: "double", nullable: true),
                    InternationalCheck = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    PesoBruto = table.Column<double>(type: "double", nullable: true),
                    MateriaPrima = table.Column<double>(type: "double", nullable: true),
                    PesoNetoEscurido = table.Column<double>(type: "double", nullable: true),
                    PesoNeto = table.Column<double>(type: "double", nullable: true),
                    idEntetS = table.Column<int>(type: "int", nullable: true),
                    expeditoP_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaP_plt = table.Column<DateOnly>(type: "date", nullable: true),
                    factureP_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantiteP_plt = table.Column<double>(type: "double", nullable: true),
                    expeditoLP_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fechaLP_plt = table.Column<DateOnly>(type: "date", nullable: true),
                    factureLP_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantiteLP_plt = table.Column<double>(type: "double", nullable: true),
                    DETLP_plt = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e_Entet__53DEA1117F1E3259", x => x.idEntet);
                    table.ForeignKey(
                        name: "FK__e_Entet__idClien__251C81ED",
                        column: x => x.idClient,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                    table.ForeignKey(
                        name: "FK__e_Entet__idDepot__2610A626",
                        column: x => x.idDepot,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__e_Entet__idDepot__2704CA5F",
                        column: x => x.idDepot_2,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__e_Entet__idDossi__27F8EE98",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__e_Entet__idFourn__28ED12D1",
                        column: x => x.idFournisseur,
                        principalTable: "t_Fournisseur",
                        principalColumn: "idFournisseur");
                    table.ForeignKey(
                        name: "FK__e_Entet__idGroup__29E1370A",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__e_Entet__idModRg__2AD55B43",
                        column: x => x.idModRglm,
                        principalTable: "b_ModRglm",
                        principalColumn: "idModRglm");
                    table.ForeignKey(
                        name: "FK__e_Entet__idUser__2BC97F7C",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK_e_entet_a_famille",
                        column: x => x.idFamille,
                        principalTable: "a_Famille",
                        principalColumn: "idFamille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "t_FournisseurCredit",
                columns: table => new
                {
                    idFournisseur = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    credit = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__t_Fournis__idDos__1387E197",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__t_Fournis__idFou__147C05D0",
                        column: x => x.idFournisseur,
                        principalTable: "t_Fournisseur",
                        principalColumn: "idFournisseur");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_E_Employe",
                columns: table => new
                {
                    idEmploye = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomEmployee = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prenomEmployee = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    matricule = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    titre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cinEmployee = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nationalite = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateNaissance = table.Column<DateTime>(type: "datetime", nullable: true),
                    sitFamiliale = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nbEnfants = table.Column<int>(type: "int", nullable: true),
                    lieuNaissance = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    abattement = table.Column<int>(type: "int", nullable: true),
                    email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    adresse = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    observation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: false),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idNiveau = table.Column<int>(type: "int", nullable: true),
                    idCategorie = table.Column<int>(type: "int", nullable: true),
                    idDepartement = table.Column<int>(type: "int", nullable: true),
                    idFonction = table.Column<int>(type: "int", nullable: true),
                    dateEntree = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateSortie = table.Column<DateTime>(type: "datetime", nullable: true),
                    checkSortie = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    typePaie = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeSalarie = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    salaireBase = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    numCarte = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    checkPointage = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    salaireFix = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    banque = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numCompte = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    recharge = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    traiteAssurVie = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateAssurVie = table.Column<DateTime>(type: "datetime", nullable: true),
                    plafondAssurVie = table.Column<double>(type: "double", nullable: true),
                    traiteAssurRetraite = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateAssurRetraite = table.Column<DateTime>(type: "datetime", nullable: true),
                    plafondAssurRetraite = table.Column<double>(type: "double", nullable: true),
                    photo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idVille = table.Column<int>(type: "int", nullable: true),
                    idModRglm = table.Column<int>(type: "int", nullable: true),
                    genre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    empCadre = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUserDevice = table.Column<int>(type: "int", nullable: true),
                    idPlanning = table.Column<int>(type: "int", nullable: true),
                    telephone = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    busStation = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numDeclareEmp = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PrixKgs = table.Column<double>(type: "double", nullable: true),
                    PrixHeurSup = table.Column<double>(type: "double", nullable: true),
                    PrixParHeur = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_E_E__97B32F2A937E683A", x => x.idEmploye);
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idCat__351DDF8C",
                        column: x => x.idCategorie,
                        principalTable: "paie_I_Categorie",
                        principalColumn: "idCategorie");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idDep__361203C5",
                        column: x => x.idDepartement,
                        principalTable: "paie_I_Departement",
                        principalColumn: "idDepartement");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idFon__370627FE",
                        column: x => x.idFonction,
                        principalTable: "paie_I_Fonction",
                        principalColumn: "idFonction");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idGro__37FA4C37",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idMod__38EE7070",
                        column: x => x.idModRglm,
                        principalTable: "b_ModRglm",
                        principalColumn: "idModRglm");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idNiv__39E294A9",
                        column: x => x.idNiveau,
                        principalTable: "paie_I_Niveau",
                        principalColumn: "idNiveau");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idPla__3AD6B8E2",
                        column: x => x.idPlanning,
                        principalTable: "Paie_Z_Planning",
                        principalColumn: "idPlanning");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idUse__3BCADD1B",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idUse__3CBF0154",
                        column: x => x.idUserDevice,
                        principalTable: "Paie_Z_UserDevice",
                        principalColumn: "idUserDevice");
                    table.ForeignKey(
                        name: "FK__Paie_E_Em__idVil__3DB3258D",
                        column: x => x.idVille,
                        principalTable: "b_Ville",
                        principalColumn: "idVille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "a_ArticleInFille",
                columns: table => new
                {
                    idFille = table.Column<int>(type: "int", nullable: true),
                    idArticle = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__a_Article__idArt__01D345B0",
                        column: x => x.idArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                    table.ForeignKey(
                        name: "FK__a_Article__idFil__02C769E9",
                        column: x => x.idFille,
                        principalTable: "s_Fille",
                        principalColumn: "idFille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "a_Bateau",
                columns: table => new
                {
                    idBateau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    idClient = table.Column<int>(type: "int", nullable: true),
                    dimensionX = table.Column<double>(type: "double", nullable: true),
                    dimensionY = table.Column<double>(type: "double", nullable: true),
                    prixM = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    checkCollaboration = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    dateDebut = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateFin = table.Column<DateTime>(type: "datetime", nullable: true),
                    valider = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    clotur = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__a_Bateau__8303C1652CEDC140", x => x.idBateau);
                    table.ForeignKey(
                        name: "FK__a_Bateau__idArti__03BB8E22",
                        column: x => x.idArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                    table.ForeignKey(
                        name: "FK__a_Bateau__idClie__04AFB25B",
                        column: x => x.idClient,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "f_Fabrication",
                columns: table => new
                {
                    idFabrication = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    reference = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    info = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__f_Fabric__C10A431E8106A8EB", x => x.idFabrication);
                    table.ForeignKey(
                        name: "FK__f_Fabrica__idArt__373B3228",
                        column: x => x.idArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                    table.ForeignKey(
                        name: "FK__f_Fabrica__idGro__382F5661",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__f_Fabrica__idUse__39237A9A",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "e_Art_Depot",
                columns: table => new
                {
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    idDepot = table.Column<int>(type: "int", nullable: true),
                    idSupDepot = table.Column<int>(type: "int", nullable: true),
                    qteDepot = table.Column<double>(type: "double", nullable: true),
                    cmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lastPrix = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    firstPrix = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__e_Art_Dep__idDep__2057CCD0",
                        column: x => x.idDepot,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__e_Art_Dep__idDos__214BF109",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__e_Art_Dep__idSup__22401542",
                        column: x => x.idSupDepot,
                        principalTable: "b_DepotSup",
                        principalColumn: "idSupDepot");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "fish_entetLign",
                columns: table => new
                {
                    idLign = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEntet = table.Column<int>(type: "int", nullable: true),
                    idFamille = table.Column<int>(type: "int", nullable: true),
                    descLign = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    calibre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantite = table.Column<double>(type: "double", nullable: true),
                    prix = table.Column<double>(type: "double", nullable: true),
                    prixTotal = table.Column<double>(type: "double", nullable: true),
                    CodePLT = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PN = table.Column<double>(type: "double", nullable: true),
                    cais = table.Column<double>(type: "double", nullable: true),
                    caisINVT = table.Column<double>(type: "double", nullable: true),
                    PNINVT = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__fish_ent__143910CC6021B68B", x => x.idLign);
                    table.ForeignKey(
                        name: "FK_fish_entetLign_a_famille",
                        column: x => x.idFamille,
                        principalTable: "a_Famille",
                        principalColumn: "idFamille");
                    table.ForeignKey(
                        name: "FK_fish_entetLign_fish_entet",
                        column: x => x.idEntet,
                        principalTable: "fish_entet",
                        principalColumn: "idEntet");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotel_B_BookingExtras",
                columns: table => new
                {
                    idBookingExtra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idBookingEntete = table.Column<int>(type: "int", nullable: true),
                    idExtras = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qte = table.Column<int>(type: "int", nullable: true),
                    prixExtra = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    totalExtras = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hotel_B___C131B493378C5998", x => x.idBookingExtra);
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idBoo__5E54FF49",
                        column: x => x.idBookingEntete,
                        principalTable: "hotel_B_BookingEntete",
                        principalColumn: "idBookingEntete");
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idExt__5F492382",
                        column: x => x.idExtras,
                        principalTable: "hotel_S_Extras",
                        principalColumn: "idExtras");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotel_B_BookingInvites",
                columns: table => new
                {
                    idBookingInvite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nomInvite = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    prenomInvite = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cinInvite = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ageInvite = table.Column<int>(type: "int", nullable: true),
                    sexeInvite = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nationalite = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idBookingEntete = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hotel_B___8A4162E267075D60", x => x.idBookingInvite);
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idBoo__603D47BB",
                        column: x => x.idBookingEntete,
                        principalTable: "hotel_B_BookingEntete",
                        principalColumn: "idBookingEntete");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotel_B_BookingLigne",
                columns: table => new
                {
                    idBookingLigne = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idBookingEntete = table.Column<int>(type: "int", nullable: true),
                    idRoomType = table.Column<int>(type: "int", nullable: true),
                    idUnit = table.Column<int>(type: "int", nullable: true),
                    guests = table.Column<int>(type: "int", nullable: true),
                    prixTTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixHT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    priceModel = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TTPrix_TTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    TTPrix_HT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnTVA = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hotel_B___D0F4C35EB8625D64", x => x.idBookingLigne);
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idBoo__61316BF4",
                        column: x => x.idBookingEntete,
                        principalTable: "hotel_B_BookingEntete",
                        principalColumn: "idBookingEntete");
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idRoo__6225902D",
                        column: x => x.idRoomType,
                        principalTable: "hotel_S_RoomType",
                        principalColumn: "idRoomType");
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idUni__6319B466",
                        column: x => x.idUnit,
                        principalTable: "hotel_S_Units",
                        principalColumn: "idUnit");
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idUse__640DD89F",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Hotel_B_BookingPayment",
                columns: table => new
                {
                    idBookingPayment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idBookingEntete = table.Column<int>(type: "int", nullable: true),
                    comment = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idModRglm = table.Column<int>(type: "int", nullable: true),
                    montant = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    datePayment = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Hotel_B___0E4EF227B98C8182", x => x.idBookingPayment);
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idBoo__6501FCD8",
                        column: x => x.idBookingEntete,
                        principalTable: "hotel_B_BookingEntete",
                        principalColumn: "idBookingEntete");
                    table.ForeignKey(
                        name: "FK__Hotel_B_B__idMod__65F62111",
                        column: x => x.idModRglm,
                        principalTable: "b_ModRglm",
                        principalColumn: "idModRglm");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "hotel_B_FilleInBookingEntete",
                columns: table => new
                {
                    idFille = table.Column<int>(type: "int", nullable: true),
                    idBookingEntete = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__hotel_B_F__idBoo__66EA454A",
                        column: x => x.idBookingEntete,
                        principalTable: "hotel_B_BookingEntete",
                        principalColumn: "idBookingEntete");
                    table.ForeignKey(
                        name: "FK__hotel_B_F__idFil__67DE6983",
                        column: x => x.idFille,
                        principalTable: "s_Fille",
                        principalColumn: "idFille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_Famille",
                columns: table => new
                {
                    idPos = table.Column<int>(type: "int", nullable: true),
                    idFamille = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__p_Famille__idFam__02925FBF",
                        column: x => x.idFamille,
                        principalTable: "a_Famille",
                        principalColumn: "idFamille");
                    table.ForeignKey(
                        name: "FK__p_Famille__idPos__038683F8",
                        column: x => x.idPos,
                        principalTable: "p_Pos",
                        principalColumn: "idPos");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_ModRglm",
                columns: table => new
                {
                    idModRglm = table.Column<int>(type: "int", nullable: true),
                    idPos = table.Column<int>(type: "int", nullable: true),
                    defaults = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__p_ModRglm__idMod__047AA831",
                        column: x => x.idModRglm,
                        principalTable: "b_ModRglm",
                        principalColumn: "idModRglm");
                    table.ForeignKey(
                        name: "FK__p_ModRglm__idPos__056ECC6A",
                        column: x => x.idPos,
                        principalTable: "p_Pos",
                        principalColumn: "idPos");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_Session",
                columns: table => new
                {
                    idSession = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idPos = table.Column<int>(type: "int", nullable: true),
                    dateOpen = table.Column<DateTime>(type: "datetime", nullable: true),
                    caissierOpen = table.Column<int>(type: "int", nullable: true),
                    soldeOpen = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    dateClose = table.Column<DateTime>(type: "datetime", nullable: true),
                    caissierClose = table.Column<int>(type: "int", nullable: true),
                    soldeClose = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    closed = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    totalCaissier = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_Sessio__ADE2668F5D786F8C", x => x.idSession);
                    table.ForeignKey(
                        name: "FK__p_Session__caiss__0C1BC9F9",
                        column: x => x.caissierOpen,
                        principalTable: "p_Caissier",
                        principalColumn: "idCaissier");
                    table.ForeignKey(
                        name: "FK__p_Session__caiss__0D0FEE32",
                        column: x => x.caissierClose,
                        principalTable: "p_Caissier",
                        principalColumn: "idCaissier");
                    table.ForeignKey(
                        name: "FK__p_Session__idPos__0E04126B",
                        column: x => x.idPos,
                        principalTable: "p_Pos",
                        principalColumn: "idPos");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "e_EntetLign",
                columns: table => new
                {
                    idLign = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEntet = table.Column<int>(type: "int", nullable: true),
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    refArticle = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descLign = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qteLign = table.Column<double>(type: "double", nullable: true),
                    prixTTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    prixHT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnTTC = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnHT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnRemise = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnTVA = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnCmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnMargeCmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnMargePxAcha = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnTauxMargeCmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnTauxMargePxAcha = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    valStock = table.Column<int>(type: "int", nullable: true),
                    valCmup = table.Column<int>(type: "int", nullable: true),
                    dateExpiration = table.Column<DateTime>(type: "datetime", nullable: true),
                    meta = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lgnUnite = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lgnUrgence = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idSupDepot = table.Column<int>(type: "int", nullable: true),
                    idSupDepot_2 = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    lgnValeurCmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnValeurPxAcha = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lgnPxAcha = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    lastQte = table.Column<double>(type: "double", nullable: true),
                    dateLigne = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    sortOrder = table.Column<int>(type: "int", nullable: true),
                    PackageEmvase = table.Column<double>(type: "double", nullable: true),
                    GrossWeight = table.Column<double>(type: "double", nullable: true),
                    drainedNetWeight = table.Column<double>(type: "double", nullable: true),
                    NetWeight = table.Column<double>(type: "double", nullable: true),
                    frozenDate = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lote = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DuaLigne = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LotePfLigne = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PesoNetoLigne = table.Column<double>(type: "double", nullable: true),
                    DateCongelationLigne = table.Column<DateOnly>(type: "date", nullable: true),
                    codePdFini = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qtebyDua = table.Column<double>(type: "double", nullable: true),
                    SinAgua = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__e_EntetL__143910CCFFFD03D9", x => x.idLign);
                    table.ForeignKey(
                        name: "FK__e_EntetLi__idArt__2DB1C7EE",
                        column: x => x.idArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                    table.ForeignKey(
                        name: "FK__e_EntetLi__idEnt__2EA5EC27",
                        column: x => x.idEntet,
                        principalTable: "e_Entet",
                        principalColumn: "idEntet");
                    table.ForeignKey(
                        name: "FK__e_EntetLi__idSup__2F9A1060",
                        column: x => x.idSupDepot_2,
                        principalTable: "b_DepotSup",
                        principalColumn: "idSupDepot");
                    table.ForeignKey(
                        name: "FK__e_EntetLi__idSup__308E3499",
                        column: x => x.idSupDepot,
                        principalTable: "b_DepotSup",
                        principalColumn: "idSupDepot");
                    table.ForeignKey(
                        name: "FK__e_EntetLi__idUse__318258D2",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "e_FilleInEntet",
                columns: table => new
                {
                    idFille = table.Column<int>(type: "int", nullable: true),
                    idEntet = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__e_FilleIn__idEnt__345EC57D",
                        column: x => x.idEntet,
                        principalTable: "e_Entet",
                        principalColumn: "idEntet");
                    table.ForeignKey(
                        name: "FK__e_FilleIn__idFil__3552E9B6",
                        column: x => x.idFille,
                        principalTable: "s_Fille",
                        principalColumn: "idFille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "r_Reglement",
                columns: table => new
                {
                    idReglement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numReglement = table.Column<int>(type: "int", nullable: true),
                    dateReglement = table.Column<DateTime>(type: "datetime", nullable: true),
                    banque = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numCheque = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateEcheanche = table.Column<DateTime>(type: "datetime", nullable: true),
                    nom = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    info = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    etatReg = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idModRglm = table.Column<int>(type: "int", nullable: true),
                    idTreso = table.Column<int>(type: "int", nullable: true),
                    idClient = table.Column<int>(type: "int", nullable: true),
                    idFournisseur = table.Column<int>(type: "int", nullable: true),
                    codeType = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idEntet = table.Column<int>(type: "int", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    montant = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idEntetFish = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__r_Reglem__DB4C7B8E33384D86", x => x.idReglement);
                    table.ForeignKey(
                        name: "FK__r_Regleme__idCli__5E1FF51F",
                        column: x => x.idClient,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idDos__5F141958",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idEnt__60083D91",
                        column: x => x.idEntet,
                        principalTable: "e_Entet",
                        principalColumn: "idEntet");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idFou__60FC61CA",
                        column: x => x.idFournisseur,
                        principalTable: "t_Fournisseur",
                        principalColumn: "idFournisseur");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idGro__61F08603",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idMod__62E4AA3C",
                        column: x => x.idModRglm,
                        principalTable: "b_ModRglm",
                        principalColumn: "idModRglm");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idTre__63D8CE75",
                        column: x => x.idTreso,
                        principalTable: "b_Tresorerie",
                        principalColumn: "idTreso");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idUse__64CCF2AE",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                    table.ForeignKey(
                        name: "fk_reglement_fish_entet",
                        column: x => x.idEntetFish,
                        principalTable: "fish_entet",
                        principalColumn: "idEntet");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
     name: "Maint_S_Member",
     columns: table => new
     {
         idMember = table.Column<int>(type: "int", nullable: false)
             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
         idEmploye = table.Column<int>(type: "int", nullable: true),
         idFournisseur = table.Column<int>(type: "int", nullable: true),
         idTeam = table.Column<int>(type: "int", nullable: true)
     },
     constraints: table =>
     {
         table.PrimaryKey("PK_Maint_S_Member", x => x.idMember);
         table.ForeignKey(
             name: "FK_Maint_S_Member_idEmploye_Paie_E_Employe_idEmploye",
             column: x => x.idEmploye,
             principalTable: "Paie_E_Employe",
             principalColumn: "idEmploye");
         table.ForeignKey(
             name: "FK_Maint_S_Member_idFournisseur_t_Fournisseur_idFournisseur",
             column: x => x.idFournisseur,
             principalTable: "t_Fournisseur",
             principalColumn: "idFournisseur");
         table.ForeignKey(
             name: "FK_Maint_S_Member_idTeam_Maint_S_Team_idTeam",
             column: x => x.idTeam,
             principalTable: "Maint_S_Team",
             principalColumn: "idTeam");
     })
     .Annotation("MySql:CharSet", "utf8mb4");


            migrationBuilder.CreateTable(
                name: "Paie_C_Cotisations",
                columns: table => new
                {
                    idCotisation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    codeCotis = table.Column<int>(type: "int", nullable: true),
                    libelleCotis = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    partSalariel = table.Column<double>(type: "double", nullable: true),
                    prestationSoc = table.Column<double>(type: "double", nullable: true),
                    allFamilial = table.Column<double>(type: "double", nullable: true),
                    formationProf = table.Column<double>(type: "double", nullable: true),
                    plafond = table.Column<double>(type: "double", nullable: true),
                    cotisationPatr = table.Column<double>(type: "double", nullable: true),
                    tauxPenalite = table.Column<double>(type: "double", nullable: true),
                    tauxMajoration1 = table.Column<double>(type: "double", nullable: true),
                    tauxMajorationAutres = table.Column<double>(type: "double", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    typeCoti = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_C_C__6159288BFAC35F45", x => x.idCotisation);
                    table.ForeignKey(
                        name: "FK__Paie_C_Co__idEmp__15A53433",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_C_Co__idGro__1699586C",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_C_Co__idUse__178D7CA5",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Calcul_Avance",
                columns: table => new
                {
                    idAvance = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    dateAvance = table.Column<DateTime>(type: "datetime", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    montant = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    cloturer = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Cal__B1657DC64C0008D9", x => x.idAvance);
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idEmp__1C5231C2",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idGro__1D4655FB",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idUse__1E3A7A34",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Calcul_bulletin_ligne",
                columns: table => new
                {
                    IdBulletinLigne = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdBulletin = table.Column<int>(type: "int", nullable: true),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    SalaireBase = table.Column<double>(type: "double", nullable: true),
                    totalPrixSupp = table.Column<double>(type: "double", nullable: true),
                    nbHeurSup = table.Column<int>(type: "int", nullable: true),
                    totalKgs = table.Column<double>(type: "double", nullable: true),
                    totalPrixKgs = table.Column<double>(type: "double", nullable: true),
                    salaireTotal = table.Column<double>(type: "double", nullable: true),
                    nbJours = table.Column<int>(type: "int", nullable: true),
                    nbconge = table.Column<int>(type: "int", nullable: true),
                    nombreHeurs = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Cal__13B8C3BB214F0CFF", x => x.IdBulletinLigne);
                    table.ForeignKey(
                        name: "fk_Paie_Calcul_bulletin_ligne_Employee",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "fk_Paie_Calcul_bulletin_ligne_bulletin",
                        column: x => x.IdBulletin,
                        principalTable: "Paie_Calcul_bulletin",
                        principalColumn: "IdBulletin");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Calcul_Conges",
                columns: table => new
                {
                    idCng = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    periodeDebut = table.Column<DateTime>(type: "datetime", nullable: true),
                    periodeFin = table.Column<DateTime>(type: "datetime", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    nbJours = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Cal__398F16C83A17AFA3", x => x.idCng);
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idDos__23F3538A",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idEmp__24E777C3",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idGro__25DB9BFC",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idUse__26CFC035",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Calcul_Entete",
                columns: table => new
                {
                    idEntete = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    idGrpEnt = table.Column<int>(type: "int", nullable: true),
                    salaireBase = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    totalBrut = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    joursTravail = table.Column<double>(type: "double", nullable: true),
                    hS0 = table.Column<double>(type: "double", nullable: true),
                    hS25 = table.Column<double>(type: "double", nullable: true),
                    hS50 = table.Column<double>(type: "double", nullable: true),
                    hS100 = table.Column<double>(type: "double", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Cal__D60AEBB80E676EE7", x => x.idEntete);
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idEmp__27C3E46E",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idGrp__28B808A7",
                        column: x => x.idGrpEnt,
                        principalTable: "Paie_Calcul_GrpEntete",
                        principalColumn: "idGrpEnt");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_E_Conges",
                columns: table => new
                {
                    idConge = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    annee = table.Column<int>(type: "int", nullable: true),
                    numberMonths = table.Column<int>(type: "int", nullable: true),
                    jConsommes = table.Column<double>(type: "double", nullable: true),
                    jCongeN_1 = table.Column<double>(type: "double", nullable: true),
                    jCongeN = table.Column<double>(type: "double", nullable: true),
                    jRestes = table.Column<double>(type: "double", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_E_C__51C97AAB85C611E9", x => x.idConge);
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idDos__2D7CBDC4",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idEmp__2E70E1FD",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idGro__2F650636",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idUse__30592A6F",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_E_Contrat",
                columns: table => new
                {
                    idContrat = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numContrat = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dateContrat = table.Column<DateTime>(type: "datetime", nullable: true),
                    idProfil = table.Column<int>(type: "int", nullable: true),
                    periodeD = table.Column<DateTime>(type: "datetime", nullable: true),
                    periodeF = table.Column<DateTime>(type: "datetime", nullable: true),
                    observationC = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_E_C__2A0DE1E8B3429FB7", x => x.idContrat);
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idEmp__314D4EA8",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idGro__324172E1",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idPro__3335971A",
                        column: x => x.idProfil,
                        principalTable: "paie_I_ProfilContrat",
                        principalColumn: "idProfil");
                    table.ForeignKey(
                        name: "FK__Paie_E_Co__idUse__3429BB53",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_E_Prets",
                columns: table => new
                {
                    idPret = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    reliquant = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    montantTotal = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    nbEcheance = table.Column<int>(type: "int", nullable: true),
                    montantEcheance = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    montantDernierEcheance = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    dateEcheanceD = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateEcheanceF = table.Column<DateTime>(type: "datetime", nullable: true),
                    codeRubrique = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    observation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_E_P__B41BA71774103744", x => x.idPret);
                    table.ForeignKey(
                        name: "FK__Paie_E_Pr__idEmp__408F9238",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_E_Pr__idGro__4183B671",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_E_Pr__idUse__4277DAAA",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_P_POINTAGE_LIGNE",
                columns: table => new
                {
                    idPointageLigne = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEmploye = table.Column<int>(type: "int", nullable: true),
                    HeureEntree = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    HeureSortire = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    kgs = table.Column<double>(type: "double", nullable: true),
                    idPointage = table.Column<int>(type: "int", nullable: true),
                    heureSupp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_P_P__4F9C0CAD1A5A5B15", x => x.idPointageLigne);
                    table.ForeignKey(
                        name: "fk_Paie_P_POINTAGE_LIGNE_idEmploye",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "fk_Paie_P_POINTAGE_LIGNE_idPointage",
                        column: x => x.idPointage,
                        principalTable: "Paie_P_POINTAGE",
                        principalColumn: "idPointage");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Z_LogData",
                columns: table => new
                {
                    idLogData = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idUserDevice = table.Column<int>(type: "int", nullable: true),
                    dateTimeRecord = table.Column<DateTime>(type: "datetime", nullable: true),
                    uniqueId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    timeRecord = table.Column<TimeOnly>(type: "time(6)", nullable: true),
                    idEmploye = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Z_L__A49937F43BE3FFFF", x => x.idLogData);
                    table.ForeignKey(
                        name: "FK__Paie_Z_Lo__idEmp__53A266AC",
                        column: x => x.idEmploye,
                        principalTable: "Paie_E_Employe",
                        principalColumn: "idEmploye");
                    table.ForeignKey(
                        name: "FK__Paie_Z_Lo__idGro__54968AE5",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Paie_Z_Lo__idUse__558AAF1E",
                        column: x => x.idUserDevice,
                        principalTable: "Paie_Z_UserDevice",
                        principalColumn: "idUserDevice");
                    table.ForeignKey(
                        name: "FK__Paie_Z_Lo__idUse__567ED357",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "f_FabricationLign",
                columns: table => new
                {
                    idLignFab = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idFabrication = table.Column<int>(type: "int", nullable: true),
                    idLignArticle = table.Column<int>(type: "int", nullable: true),
                    qteFabrication = table.Column<double>(type: "double", nullable: true),
                    qteLignFabrication = table.Column<double>(type: "double", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__f_Fabric__F8C72471FCD7CE4D", x => x.idLignFab);
                    table.ForeignKey(
                        name: "FK__f_Fabrica__idFab__3A179ED3",
                        column: x => x.idFabrication,
                        principalTable: "f_Fabrication",
                        principalColumn: "idFabrication");
                    table.ForeignKey(
                        name: "FK__f_Fabrica__idLig__3B0BC30C",
                        column: x => x.idLignArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "f_Ordre",
                columns: table => new
                {
                    idOrdre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numOrdre = table.Column<int>(type: "int", nullable: true),
                    qteOrdre = table.Column<double>(type: "double", nullable: true),
                    ttHT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    datePlanification = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateEndPlanification = table.Column<DateTime>(type: "datetime", nullable: true),
                    positionOrdre = table.Column<int>(type: "int", nullable: true),
                    progressType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idDepot = table.Column<int>(type: "int", nullable: true),
                    idSupDepot = table.Column<int>(type: "int", nullable: true),
                    idFabrication = table.Column<int>(type: "int", nullable: true),
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    valider = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    numberPerson = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__f_Ordre__C8AD1C42449B5826", x => x.idOrdre);
                    table.ForeignKey(
                        name: "FK__f_Ordre__idArtic__3BFFE745",
                        column: x => x.idArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                    table.ForeignKey(
                        name: "FK__f_Ordre__idDepot__3CF40B7E",
                        column: x => x.idDepot,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__f_Ordre__idDossi__3DE82FB7",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__f_Ordre__idFabri__3EDC53F0",
                        column: x => x.idFabrication,
                        principalTable: "f_Fabrication",
                        principalColumn: "idFabrication");
                    table.ForeignKey(
                        name: "FK__f_Ordre__idGroup__3FD07829",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__f_Ordre__idSupDe__40C49C62",
                        column: x => x.idSupDepot,
                        principalTable: "b_DepotSup",
                        principalColumn: "idSupDepot");
                    table.ForeignKey(
                        name: "FK__f_Ordre__idUser__41B8C09B",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_Ticket",
                columns: table => new
                {
                    idTicket = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numTicket = table.Column<int>(type: "int", nullable: true),
                    total = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    dateCreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    idCaissier = table.Column<int>(type: "int", nullable: true),
                    isCancel = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    dateCancel = table.Column<DateTime>(type: "datetime", nullable: true),
                    isClosed = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    idSession = table.Column<int>(type: "int", nullable: true),
                    idClient = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_Ticket__22B1456F3065CB00", x => x.idTicket);
                    table.ForeignKey(
                        name: "FK__p_Ticket__idCais__0EF836A4",
                        column: x => x.idCaissier,
                        principalTable: "p_Caissier",
                        principalColumn: "idCaissier");
                    table.ForeignKey(
                        name: "FK__p_Ticket__idClie__0FEC5ADD",
                        column: x => x.idClient,
                        principalTable: "t_Client",
                        principalColumn: "idClient");
                    table.ForeignKey(
                        name: "FK__p_Ticket__idSess__10E07F16",
                        column: x => x.idSession,
                        principalTable: "p_Session",
                        principalColumn: "idSession");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Maint_A_Equipements",
                columns: table => new
                {
                    idEquipement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    modeleEquipement = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numeroSerie = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    coutEquipement = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    dateGarantie = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateEffet = table.Column<DateTime>(type: "datetime", nullable: true),
                    idLign = table.Column<int>(type: "int", nullable: true),
                    idArticle = table.Column<int>(type: "int", nullable: true),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Maint_A___87E05D1F9B0D1F8B", x => x.idEquipement);
                    table.ForeignKey(
                        name: "FK__Maint_A_E__idArt__73501C2F",
                        column: x => x.idArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                    table.ForeignKey(
                        name: "FK__Maint_A_E__idGro__74444068",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Maint_A_E__idLig__753864A1",
                        column: x => x.idLign,
                        principalTable: "e_EntetLign",
                        principalColumn: "idLign");
                    table.ForeignKey(
                        name: "FK__Maint_A_E__idUse__762C88DA",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "r_ReglementInFille",
                columns: table => new
                {
                    idFille = table.Column<int>(type: "int", nullable: true),
                    idReglement = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK__r_Regleme__idFil__66B53B20",
                        column: x => x.idFille,
                        principalTable: "s_Fille",
                        principalColumn: "idFille");
                    table.ForeignKey(
                        name: "FK__r_Regleme__idReg__67A95F59",
                        column: x => x.idReglement,
                        principalTable: "r_Reglement",
                        principalColumn: "idReglement");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_Calcul_LigneRubrique",
                columns: table => new
                {
                    idLigne = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idEntete = table.Column<int>(type: "int", nullable: true),
                    idRubrique = table.Column<int>(type: "int", nullable: true),
                    idCotisation = table.Column<int>(type: "int", nullable: true),
                    idPret = table.Column<int>(type: "int", nullable: true),
                    codeRubrique = table.Column<int>(type: "int", nullable: true),
                    libelleRubrique = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    @base = table.Column<decimal>(name: "base", type: "DECIMAL(19,4)", nullable: true),
                    taux = table.Column<double>(type: "double", nullable: true),
                    gains = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    retenues = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    createDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    position = table.Column<int>(type: "int", nullable: true),
                    valeur = table.Column<int>(type: "int", nullable: true),
                    typeRubrique = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_Cal__408FD6F4B693FF52", x => x.idLigne);
                    table.ForeignKey(
                        name: "FK__Paie_Calc__idEnt__2C88998B",
                        column: x => x.idEntete,
                        principalTable: "Paie_Calcul_Entete",
                        principalColumn: "idEntete");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paie_E_FilleInContrat",
                columns: table => new
                {
                    idContrat = table.Column<int>(type: "int", nullable: false),
                    idFille = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Paie_E_F__B36AEBFBC72E890A", x => new { x.idContrat, x.idFille });
                    table.ForeignKey(
                        name: "FK__Paie_E_Fi__idCon__3EA749C6",
                        column: x => x.idContrat,
                        principalTable: "Paie_E_Contrat",
                        principalColumn: "idContrat");
                    table.ForeignKey(
                        name: "FK__Paie_E_Fi__idFil__3F9B6DFF",
                        column: x => x.idFille,
                        principalTable: "s_Fille",
                        principalColumn: "idFille");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "f_OrdreLine",
                columns: table => new
                {
                    idOrdreLine = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    qteOrdreLine = table.Column<double>(type: "double", nullable: true),
                    cmup = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    ttHT = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    typeOrdre = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    valStock = table.Column<int>(type: "int", nullable: true),
                    idLignArticle = table.Column<int>(type: "int", nullable: true),
                    idOrdre = table.Column<int>(type: "int", nullable: true),
                    idDepot = table.Column<int>(type: "int", nullable: true),
                    idSupDepot = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__f_OrdreL__A8F09F55E111731B", x => x.idOrdreLine);
                    table.ForeignKey(
                        name: "FK__f_OrdreLi__idDep__42ACE4D4",
                        column: x => x.idDepot,
                        principalTable: "b_Depot",
                        principalColumn: "idDepot");
                    table.ForeignKey(
                        name: "FK__f_OrdreLi__idDos__43A1090D",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__f_OrdreLi__idLig__44952D46",
                        column: x => x.idLignArticle,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                    table.ForeignKey(
                        name: "FK__f_OrdreLi__idOrd__4589517F",
                        column: x => x.idOrdre,
                        principalTable: "f_Ordre",
                        principalColumn: "idOrdre");
                    table.ForeignKey(
                        name: "FK__f_OrdreLi__idSup__467D75B8",
                        column: x => x.idSupDepot,
                        principalTable: "b_DepotSup",
                        principalColumn: "idSupDepot");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_Ticket_ligne",
                columns: table => new
                {
                    idLigne = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idTicket = table.Column<int>(type: "int", nullable: true),
                    dateCreation = table.Column<DateTime>(type: "datetime", nullable: true),
                    idproduct = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    umvente = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    qte = table.Column<int>(type: "int", nullable: true),
                    rem = table.Column<double>(type: "double", nullable: true),
                    total = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true),
                    checkVenduGrand = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_Ticket__408FD6F4123DC466", x => x.idLigne);
                    table.ForeignKey(
                        name: "FK__p_Ticket___idTic__12C8C788",
                        column: x => x.idTicket,
                        principalTable: "p_Ticket",
                        principalColumn: "idTicket");
                    table.ForeignKey(
                        name: "FK__p_Ticket___idpro__11D4A34F",
                        column: x => x.idproduct,
                        principalTable: "a_Article",
                        principalColumn: "idArticle");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "p_Ticket_Reg",
                columns: table => new
                {
                    idPaiment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idTicket = table.Column<int>(type: "int", nullable: true),
                    idModRglm = table.Column<int>(type: "int", nullable: true),
                    mantant = table.Column<decimal>(type: "DECIMAL(19,4)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_Ticket__430DC81233861774", x => x.idPaiment);
                    table.ForeignKey(
                        name: "FK__p_Ticket___idMod__13BCEBC1",
                        column: x => x.idModRglm,
                        principalTable: "b_ModRglm",
                        principalColumn: "idModRglm");
                    table.ForeignKey(
                        name: "FK__p_Ticket___idTic__14B10FFA",
                        column: x => x.idTicket,
                        principalTable: "p_Ticket",
                        principalColumn: "idTicket");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Maint_R_Request",
                columns: table => new
                {
                    idRequest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    numRequest = table.Column<int>(type: "int", nullable: true),
                    nomRequest = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    etatRequest = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    typeMaint = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    descMaint = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    lieuMaint = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idUser = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    idGroup = table.Column<int>(type: "int", nullable: true),
                    idDossier = table.Column<int>(type: "int", nullable: true),
                    idTeam = table.Column<int>(type: "int", nullable: true),
                    idEquipement = table.Column<int>(type: "int", nullable: true),
                    progressType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    positionOrdre = table.Column<int>(type: "int", nullable: true),
                    dateRequest = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Maint_R___F4A4109EE2C16E2E", x => x.idRequest);
                    table.ForeignKey(
                        name: "FK__Maint_R_R__idDos__7720AD13",
                        column: x => x.idDossier,
                        principalTable: "s_Dossier",
                        principalColumn: "idDossier");
                    table.ForeignKey(
                        name: "FK__Maint_R_R__idEqu__7814D14C",
                        column: x => x.idEquipement,
                        principalTable: "Maint_A_Equipements",
                        principalColumn: "idEquipement");
                    table.ForeignKey(
                        name: "FK__Maint_R_R__idGro__7908F585",
                        column: x => x.idGroup,
                        principalTable: "s_GroupUsers",
                        principalColumn: "idGroup");
                    table.ForeignKey(
                        name: "FK__Maint_R_R__idTea__79FD19BE",
                        column: x => x.idTeam,
                        principalTable: "Maint_S_Team",
                        principalColumn: "idTeam");
                    table.ForeignKey(
                        name: "FK__Maint_R_R__idUse__7AF13DF7",
                        column: x => x.idUser,
                        principalTable: "s_Users",
                        principalColumn: "idUser");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_a_Article_idFamille",
                table: "a_Article",
                column: "idFamille");

            migrationBuilder.CreateIndex(
                name: "IX_a_Article_idGroup",
                table: "a_Article",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_a_Article_idTaxeAchat",
                table: "a_Article",
                column: "idTaxeAchat");

            migrationBuilder.CreateIndex(
                name: "IX_a_Article_idTaxeVente",
                table: "a_Article",
                column: "idTaxeVente");

            migrationBuilder.CreateIndex(
                name: "IX_a_Article_idUnite",
                table: "a_Article",
                column: "idUnite");

            migrationBuilder.CreateIndex(
                name: "IX_a_Article_idUser",
                table: "a_Article",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_a_ArticleInFille_idArticle",
                table: "a_ArticleInFille",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_a_ArticleInFille_idFille",
                table: "a_ArticleInFille",
                column: "idFille");

            migrationBuilder.CreateIndex(
                name: "IX_a_Bateau_idArticle",
                table: "a_Bateau",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_a_Bateau_idClient",
                table: "a_Bateau",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_a_Famille_idGroup",
                table: "a_Famille",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_a_Famille_idNomScientifique",
                table: "a_Famille",
                column: "idNomScientifique");

            migrationBuilder.CreateIndex(
                name: "IX_a_Famille_idPays",
                table: "a_Famille",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_a_Famille_idTypeFamaille",
                table: "a_Famille",
                column: "idTypeFamaille");

            migrationBuilder.CreateIndex(
                name: "IX_a_Famille_idUser",
                table: "a_Famille",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_b_Depot_idGroup",
                table: "b_Depot",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_Depot_idPays",
                table: "b_Depot",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_b_Depot_idUser",
                table: "b_Depot",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_b_Depot_idVille",
                table: "b_Depot",
                column: "idVille");

            migrationBuilder.CreateIndex(
                name: "IX_b_DepotSup_idDepot",
                table: "b_DepotSup",
                column: "idDepot");

            migrationBuilder.CreateIndex(
                name: "IX_b_DepotSup_idGroup",
                table: "b_DepotSup",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_DepotSup_idUser",
                table: "b_DepotSup",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_b_ModRglm_idGroup",
                table: "b_ModRglm",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_ModRglm_idUser",
                table: "b_ModRglm",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_b_Pays_idGroup",
                table: "b_Pays",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_Propriete_idGroup",
                table: "b_Propriete",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_Propriete_idUser",
                table: "b_Propriete",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_b_Service_idGroup",
                table: "b_Service",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_Service_idUser",
                table: "b_Service",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_b_SoldTresorerie_idDossier",
                table: "b_SoldTresorerie",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_b_Taxe_idGroup",
                table: "b_Taxe",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_Tresorerie_idGroup",
                table: "b_Tresorerie",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_Tresorerie_idUser",
                table: "b_Tresorerie",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_b_Ville_idGroup",
                table: "b_Ville",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_b_Ville_idPays",
                table: "b_Ville",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_d_Departement_idGroup",
                table: "d_Departement",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_d_Departement_idUser",
                table: "d_Departement",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_e_Art_Depot_idDepot",
                table: "e_Art_Depot",
                column: "idDepot");

            migrationBuilder.CreateIndex(
                name: "IX_e_Art_Depot_idDossier",
                table: "e_Art_Depot",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_e_Art_Depot_idSupDepot",
                table: "e_Art_Depot",
                column: "idSupDepot");

            migrationBuilder.CreateIndex(
                name: "IX_e_Emails_idGroup",
                table: "e_Emails",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_e_Emails_idUser",
                table: "e_Emails",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idClient",
                table: "e_Entet",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idDepot",
                table: "e_Entet",
                column: "idDepot");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idDepot_2",
                table: "e_Entet",
                column: "idDepot_2");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idDossier",
                table: "e_Entet",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idFamille",
                table: "e_Entet",
                column: "idFamille");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idFournisseur",
                table: "e_Entet",
                column: "idFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idGroup",
                table: "e_Entet",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idModRglm",
                table: "e_Entet",
                column: "idModRglm");

            migrationBuilder.CreateIndex(
                name: "IX_e_Entet_idUser",
                table: "e_Entet",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_e_EntetLign_idArticle",
                table: "e_EntetLign",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_e_EntetLign_idEntet",
                table: "e_EntetLign",
                column: "idEntet");

            migrationBuilder.CreateIndex(
                name: "IX_e_EntetLign_idSupDepot",
                table: "e_EntetLign",
                column: "idSupDepot");

            migrationBuilder.CreateIndex(
                name: "IX_e_EntetLign_idSupDepot_2",
                table: "e_EntetLign",
                column: "idSupDepot_2");

            migrationBuilder.CreateIndex(
                name: "IX_e_EntetLign_idUser",
                table: "e_EntetLign",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_e_FilleInEmails_idFille",
                table: "e_FilleInEmails",
                column: "idFille");

            migrationBuilder.CreateIndex(
                name: "IX_e_FilleInEntet_idEntet",
                table: "e_FilleInEntet",
                column: "idEntet");

            migrationBuilder.CreateIndex(
                name: "IX_e_FilleInEntet_idFille",
                table: "e_FilleInEntet",
                column: "idFille");

            migrationBuilder.CreateIndex(
                name: "IX_e_TypeDoc_idDossier",
                table: "e_TypeDoc",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_f_Fabrication_idArticle",
                table: "f_Fabrication",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_f_Fabrication_idGroup",
                table: "f_Fabrication",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_f_Fabrication_idUser",
                table: "f_Fabrication",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_f_FabricationLign_idFabrication",
                table: "f_FabricationLign",
                column: "idFabrication");

            migrationBuilder.CreateIndex(
                name: "IX_f_FabricationLign_idLignArticle",
                table: "f_FabricationLign",
                column: "idLignArticle");

            migrationBuilder.CreateIndex(
                name: "IX_f_Ordre_idArticle",
                table: "f_Ordre",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_f_Ordre_idDepot",
                table: "f_Ordre",
                column: "idDepot");

            migrationBuilder.CreateIndex(
                name: "IX_f_Ordre_idDossier",
                table: "f_Ordre",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_f_Ordre_idFabrication",
                table: "f_Ordre",
                column: "idFabrication");

            migrationBuilder.CreateIndex(
                name: "IX_f_Ordre_idGroup",
                table: "f_Ordre",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_f_Ordre_idSupDepot",
                table: "f_Ordre",
                column: "idSupDepot");

            migrationBuilder.CreateIndex(
                name: "IX_f_Ordre_idUser",
                table: "f_Ordre",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_f_OrdreLine_idDepot",
                table: "f_OrdreLine",
                column: "idDepot");

            migrationBuilder.CreateIndex(
                name: "IX_f_OrdreLine_idDossier",
                table: "f_OrdreLine",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_f_OrdreLine_idLignArticle",
                table: "f_OrdreLine",
                column: "idLignArticle");

            migrationBuilder.CreateIndex(
                name: "IX_f_OrdreLine_idOrdre",
                table: "f_OrdreLine",
                column: "idOrdre");

            migrationBuilder.CreateIndex(
                name: "IX_f_OrdreLine_idSupDepot",
                table: "f_OrdreLine",
                column: "idSupDepot");

            migrationBuilder.CreateIndex(
                name: "IX_fish_charge_idGroup",
                table: "fish_charge",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_fish_charge_idService",
                table: "fish_charge",
                column: "idService");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entet_idClient",
                table: "fish_entet",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entet_idDossier",
                table: "fish_entet",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entet_idFamille",
                table: "fish_entet",
                column: "idFamille");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entet_idGroup",
                table: "fish_entet",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entet_idPays",
                table: "fish_entet",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entet_idPort",
                table: "fish_entet",
                column: "idPort");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entet_idUser",
                table: "fish_entet",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entetLign_idEntet",
                table: "fish_entetLign",
                column: "idEntet");

            migrationBuilder.CreateIndex(
                name: "IX_fish_entetLign_idFamille",
                table: "fish_entetLign",
                column: "idFamille");

            migrationBuilder.CreateIndex(
                name: "IX_fish_famille_idGroup",
                table: "fish_famille",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_fish_famille_idNomScientifique",
                table: "fish_famille",
                column: "idNomScientifique");

            migrationBuilder.CreateIndex(
                name: "IX_fish_famille_idPays",
                table: "fish_famille",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_fish_famille_idTypeFamaille",
                table: "fish_famille",
                column: "idTypeFamaille");

            migrationBuilder.CreateIndex(
                name: "IX_fish_famille_idUser",
                table: "fish_famille",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_fish_NomScientifique_idGroup",
                table: "fish_NomScientifique",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_fish_port_idGroup",
                table: "fish_port",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_fish_port_idUser",
                table: "fish_port",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_fish_TypeFamaille_idGroup",
                table: "fish_TypeFamaille",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_B_BookingEntete_idClient",
                table: "hotel_B_BookingEntete",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_B_BookingEntete_idDossier",
                table: "hotel_B_BookingEntete",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_B_BookingEntete_idGroup",
                table: "hotel_B_BookingEntete",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_B_BookingEntete_idUser",
                table: "hotel_B_BookingEntete",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingExtras_idBookingEntete",
                table: "Hotel_B_BookingExtras",
                column: "idBookingEntete");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingExtras_idExtras",
                table: "Hotel_B_BookingExtras",
                column: "idExtras");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingInvites_idBookingEntete",
                table: "Hotel_B_BookingInvites",
                column: "idBookingEntete");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingLigne_idBookingEntete",
                table: "Hotel_B_BookingLigne",
                column: "idBookingEntete");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingLigne_idRoomType",
                table: "Hotel_B_BookingLigne",
                column: "idRoomType");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingLigne_idUnit",
                table: "Hotel_B_BookingLigne",
                column: "idUnit");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingLigne_idUser",
                table: "Hotel_B_BookingLigne",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingPayment_idBookingEntete",
                table: "Hotel_B_BookingPayment",
                column: "idBookingEntete");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_B_BookingPayment_idModRglm",
                table: "Hotel_B_BookingPayment",
                column: "idModRglm");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_B_FilleInBookingEntete_idBookingEntete",
                table: "hotel_B_FilleInBookingEntete",
                column: "idBookingEntete");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_B_FilleInBookingEntete_idFille",
                table: "hotel_B_FilleInBookingEntete",
                column: "idFille");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Categorie_idGroup",
                table: "hotel_S_Categorie",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Categorie_idUser",
                table: "hotel_S_Categorie",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Equipements_idRoomType",
                table: "hotel_S_Equipements",
                column: "idRoomType");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Extras_idGroup",
                table: "hotel_S_Extras",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Extras_idTaxeExtras",
                table: "hotel_S_Extras",
                column: "idTaxeExtras");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Extras_idUser",
                table: "hotel_S_Extras",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_RoomType_idGroup",
                table: "hotel_S_RoomType",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_RoomType_idTaxeLouer",
                table: "hotel_S_RoomType",
                column: "idTaxeLouer");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_RoomType_idUser",
                table: "hotel_S_RoomType",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Units_idRoomType",
                table: "hotel_S_Units",
                column: "idRoomType");

            migrationBuilder.CreateIndex(
                name: "IX_hotel_S_Units_idUser",
                table: "hotel_S_Units",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_A_Equipements_idArticle",
                table: "Maint_A_Equipements",
                column: "idArticle");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_A_Equipements_idGroup",
                table: "Maint_A_Equipements",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_A_Equipements_idLign",
                table: "Maint_A_Equipements",
                column: "idLign");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_A_Equipements_idUser",
                table: "Maint_A_Equipements",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_R_Request_idDossier",
                table: "Maint_R_Request",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_R_Request_idEquipement",
                table: "Maint_R_Request",
                column: "idEquipement");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_R_Request_idGroup",
                table: "Maint_R_Request",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_R_Request_idTeam",
                table: "Maint_R_Request",
                column: "idTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_R_Request_idUser",
                table: "Maint_R_Request",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_S_Member_idEmploye",
                table: "Maint_S_Member",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_S_Member_idFournisseur",
                table: "Maint_S_Member",
                column: "idFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_S_Member_idTeam",
                table: "Maint_S_Member",
                column: "idTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_S_Team_idGroup",
                table: "Maint_S_Team",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Maint_S_Team_idUser",
                table: "Maint_S_Team",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_p_Caissier_idGroup",
                table: "p_Caissier",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_p_Caissier_idUser",
                table: "p_Caissier",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_p_Famille_idFamille",
                table: "p_Famille",
                column: "idFamille");

            migrationBuilder.CreateIndex(
                name: "IX_p_Famille_idPos",
                table: "p_Famille",
                column: "idPos");

            migrationBuilder.CreateIndex(
                name: "IX_p_ModRglm_idModRglm",
                table: "p_ModRglm",
                column: "idModRglm");

            migrationBuilder.CreateIndex(
                name: "IX_p_ModRglm_idPos",
                table: "p_ModRglm",
                column: "idPos");

            migrationBuilder.CreateIndex(
                name: "IX_p_Pos_clientDivers",
                table: "p_Pos",
                column: "clientDivers");

            migrationBuilder.CreateIndex(
                name: "IX_p_Pos_idDepot",
                table: "p_Pos",
                column: "idDepot");

            migrationBuilder.CreateIndex(
                name: "IX_p_Pos_idDossier",
                table: "p_Pos",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_p_Pos_idGroup",
                table: "p_Pos",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_p_Pos_idTreso",
                table: "p_Pos",
                column: "idTreso");

            migrationBuilder.CreateIndex(
                name: "IX_p_Pos_idUser",
                table: "p_Pos",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_p_Session_caissierClose",
                table: "p_Session",
                column: "caissierClose");

            migrationBuilder.CreateIndex(
                name: "IX_p_Session_caissierOpen",
                table: "p_Session",
                column: "caissierOpen");

            migrationBuilder.CreateIndex(
                name: "IX_p_Session_idPos",
                table: "p_Session",
                column: "idPos");

            migrationBuilder.CreateIndex(
                name: "IX_p_Ticket_idCaissier",
                table: "p_Ticket",
                column: "idCaissier");

            migrationBuilder.CreateIndex(
                name: "IX_p_Ticket_idClient",
                table: "p_Ticket",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_p_Ticket_idSession",
                table: "p_Ticket",
                column: "idSession");

            migrationBuilder.CreateIndex(
                name: "IX_p_Ticket_ligne_idproduct",
                table: "p_Ticket_ligne",
                column: "idproduct");

            migrationBuilder.CreateIndex(
                name: "IX_p_Ticket_ligne_idTicket",
                table: "p_Ticket_ligne",
                column: "idTicket");

            migrationBuilder.CreateIndex(
                name: "IX_p_Ticket_Reg_idModRglm",
                table: "p_Ticket_Reg",
                column: "idModRglm");

            migrationBuilder.CreateIndex(
                name: "IX_p_Ticket_Reg_idTicket",
                table: "p_Ticket_Reg",
                column: "idTicket");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_C_Cotisations_idEmploye",
                table: "Paie_C_Cotisations",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_C_Cotisations_idGroup",
                table: "Paie_C_Cotisations",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_C_Cotisations_idUser",
                table: "Paie_C_Cotisations",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_C_Rubriques_idGroup",
                table: "Paie_C_Rubriques",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_C_Rubriques_idUser",
                table: "Paie_C_Rubriques",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_C_Variables_idGroup",
                table: "Paie_C_Variables",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_C_Variables_idUser",
                table: "Paie_C_Variables",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Avance_idEmploye",
                table: "Paie_Calcul_Avance",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Avance_idGroup",
                table: "Paie_Calcul_Avance",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Avance_idUser",
                table: "Paie_Calcul_Avance",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_bulletin_idDossier",
                table: "Paie_Calcul_bulletin",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_bulletin_idGroup",
                table: "Paie_Calcul_bulletin",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_bulletin_idUser",
                table: "Paie_Calcul_bulletin",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_bulletin_ligne_IdBulletin",
                table: "Paie_Calcul_bulletin_ligne",
                column: "IdBulletin");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_bulletin_ligne_idEmploye",
                table: "Paie_Calcul_bulletin_ligne",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Conges_idDossier",
                table: "Paie_Calcul_Conges",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Conges_idEmploye",
                table: "Paie_Calcul_Conges",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Conges_idGroup",
                table: "Paie_Calcul_Conges",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Conges_idUser",
                table: "Paie_Calcul_Conges",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Entete_idEmploye",
                table: "Paie_Calcul_Entete",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_Entete_idGrpEnt",
                table: "Paie_Calcul_Entete",
                column: "idGrpEnt");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_GrpEntete_idDossier",
                table: "Paie_Calcul_GrpEntete",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_GrpEntete_idGroup",
                table: "Paie_Calcul_GrpEntete",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_GrpEntete_idUser",
                table: "Paie_Calcul_GrpEntete",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Calcul_LigneRubrique_idEntete",
                table: "Paie_Calcul_LigneRubrique",
                column: "idEntete");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Conges_idDossier",
                table: "Paie_E_Conges",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Conges_idEmploye",
                table: "Paie_E_Conges",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Conges_idGroup",
                table: "Paie_E_Conges",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Conges_idUser",
                table: "Paie_E_Conges",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Contrat_idEmploye",
                table: "Paie_E_Contrat",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Contrat_idGroup",
                table: "Paie_E_Contrat",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Contrat_idProfil",
                table: "Paie_E_Contrat",
                column: "idProfil");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Contrat_idUser",
                table: "Paie_E_Contrat",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idCategorie",
                table: "Paie_E_Employe",
                column: "idCategorie");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idDepartement",
                table: "Paie_E_Employe",
                column: "idDepartement");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idFonction",
                table: "Paie_E_Employe",
                column: "idFonction");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idGroup",
                table: "Paie_E_Employe",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idModRglm",
                table: "Paie_E_Employe",
                column: "idModRglm");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idNiveau",
                table: "Paie_E_Employe",
                column: "idNiveau");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idPlanning",
                table: "Paie_E_Employe",
                column: "idPlanning");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idUser",
                table: "Paie_E_Employe",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idUserDevice",
                table: "Paie_E_Employe",
                column: "idUserDevice");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Employe_idVille",
                table: "Paie_E_Employe",
                column: "idVille");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_FilleInContrat_idFille",
                table: "Paie_E_FilleInContrat",
                column: "idFille");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Prets_idEmploye",
                table: "Paie_E_Prets",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Prets_idGroup",
                table: "Paie_E_Prets",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_E_Prets_idUser",
                table: "Paie_E_Prets",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Categorie_idGroup",
                table: "paie_I_Categorie",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Categorie_idUser",
                table: "paie_I_Categorie",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Departement_idGroup",
                table: "paie_I_Departement",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Departement_idUser",
                table: "paie_I_Departement",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Fonction_idGroup",
                table: "paie_I_Fonction",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Fonction_idUser",
                table: "paie_I_Fonction",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Niveau_idGroup",
                table: "paie_I_Niveau",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_Niveau_idUser",
                table: "paie_I_Niveau",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_ProfilContrat_idGroup",
                table: "paie_I_ProfilContrat",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_ProfilContrat_idUser",
                table: "paie_I_ProfilContrat",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_TauxFraisProf_idGroup",
                table: "paie_I_TauxFraisProf",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_paie_I_TauxFraisProf_idUser",
                table: "paie_I_TauxFraisProf",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_P_POINTAGE_idDossier",
                table: "Paie_P_POINTAGE",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_P_POINTAGE_idGroup",
                table: "Paie_P_POINTAGE",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_P_POINTAGE_idUser",
                table: "Paie_P_POINTAGE",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_P_POINTAGE_LIGNE_idEmploye",
                table: "Paie_P_POINTAGE_LIGNE",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_P_POINTAGE_LIGNE_idPointage",
                table: "Paie_P_POINTAGE_LIGNE",
                column: "idPointage");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_LogData_idEmploye",
                table: "Paie_Z_LogData",
                column: "idEmploye");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_LogData_idGroup",
                table: "Paie_Z_LogData",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_LogData_idUser",
                table: "Paie_Z_LogData",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_LogData_idUserDevice",
                table: "Paie_Z_LogData",
                column: "idUserDevice");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_Planning_idGroup",
                table: "Paie_Z_Planning",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_Planning_idUser",
                table: "Paie_Z_Planning",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_UserDevice_idDevice",
                table: "Paie_Z_UserDevice",
                column: "idDevice");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_UserDevice_idGroup",
                table: "Paie_Z_UserDevice",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_UserDevice_idUser",
                table: "Paie_Z_UserDevice",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_ZKTDevices_idGroup",
                table: "Paie_Z_ZKTDevices",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_Paie_Z_ZKTDevices_idUser",
                table: "Paie_Z_ZKTDevices",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idClient",
                table: "r_Reglement",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idDossier",
                table: "r_Reglement",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idEntet",
                table: "r_Reglement",
                column: "idEntet");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idEntetFish",
                table: "r_Reglement",
                column: "idEntetFish");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idFournisseur",
                table: "r_Reglement",
                column: "idFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idGroup",
                table: "r_Reglement",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idModRglm",
                table: "r_Reglement",
                column: "idModRglm");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idTreso",
                table: "r_Reglement",
                column: "idTreso");

            migrationBuilder.CreateIndex(
                name: "IX_r_Reglement_idUser",
                table: "r_Reglement",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_r_ReglementInFille_idFille",
                table: "r_ReglementInFille",
                column: "idFille");

            migrationBuilder.CreateIndex(
                name: "IX_r_ReglementInFille_idReglement",
                table: "r_ReglementInFille",
                column: "idReglement");

            migrationBuilder.CreateIndex(
                name: "IX_s_Dossier_idGroup",
                table: "s_Dossier",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_s_EmailsSettings_idGroup",
                table: "s_EmailsSettings",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_s_EmailsSettings_idUser",
                table: "s_EmailsSettings",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_s_Fille_idGroup",
                table: "s_Fille",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_s_Fille_idUser",
                table: "s_Fille",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_s_LiaisonUsers_idDepot",
                table: "s_LiaisonUsers",
                column: "idDepot");

            migrationBuilder.CreateIndex(
                name: "IX_s_LiaisonUsers_idPays",
                table: "s_LiaisonUsers",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_s_LiaisonUsers_idTreso",
                table: "s_LiaisonUsers",
                column: "idTreso");

            migrationBuilder.CreateIndex(
                name: "IX_s_LiaisonUsers_idUser",
                table: "s_LiaisonUsers",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_s_LiaisonUsers_idVille",
                table: "s_LiaisonUsers",
                column: "idVille");

            migrationBuilder.CreateIndex(
                name: "IX_s_MenuInstall_idGroup",
                table: "s_MenuInstall",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_s_MenuInstall_idMenu",
                table: "s_MenuInstall",
                column: "idMenu");

            migrationBuilder.CreateIndex(
                name: "IX_s_MenuInstall_idUser",
                table: "s_MenuInstall",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_s_MenuSubInstall_idGroup",
                table: "s_MenuSubInstall",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_s_MenuSubInstall_idSubMenu",
                table: "s_MenuSubInstall",
                column: "idSubMenu");

            migrationBuilder.CreateIndex(
                name: "IX_s_MenuSubInstall_idUser",
                table: "s_MenuSubInstall",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_s_Roles_idGroup",
                table: "s_Roles",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_s_Settings_idGroup",
                table: "s_Settings",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_s_UserDossier_idDossier",
                table: "s_UserDossier",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_s_UserRoles_idUser",
                table: "s_UserRoles",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_s_Users_idGroup",
                table: "s_Users",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_sb_CreationBarCode_idDossier",
                table: "sb_CreationBarCode",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_sb_CreationBarCode_idGroup",
                table: "sb_CreationBarCode",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_sb_CreationBarCode_idUser",
                table: "sb_CreationBarCode",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_sc_calendar_idGroup",
                table: "sc_calendar",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_sc_calendar_idUser",
                table: "sc_calendar",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_sc_schedule_idCalendar",
                table: "sc_schedule",
                column: "idCalendar");

            migrationBuilder.CreateIndex(
                name: "IX_sc_schedule_idGroup",
                table: "sc_schedule",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_sc_schedule_idUser",
                table: "sc_schedule",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_t_Client_idGroup",
                table: "t_Client",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_t_Client_idPays",
                table: "t_Client",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_t_Client_idUser",
                table: "t_Client",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_t_Client_idVille",
                table: "t_Client",
                column: "idVille");

            migrationBuilder.CreateIndex(
                name: "IX_t_ClientCredit_idClient",
                table: "t_ClientCredit",
                column: "idClient");

            migrationBuilder.CreateIndex(
                name: "IX_t_ClientCredit_idDossier",
                table: "t_ClientCredit",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_t_Fournisseur_idGroup",
                table: "t_Fournisseur",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_t_Fournisseur_idPays",
                table: "t_Fournisseur",
                column: "idPays");

            migrationBuilder.CreateIndex(
                name: "IX_t_Fournisseur_idUser",
                table: "t_Fournisseur",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_t_Fournisseur_idVille",
                table: "t_Fournisseur",
                column: "idVille");

            migrationBuilder.CreateIndex(
                name: "IX_t_FournisseurCredit_idDossier",
                table: "t_FournisseurCredit",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_t_FournisseurCredit_idFournisseur",
                table: "t_FournisseurCredit",
                column: "idFournisseur");

            migrationBuilder.CreateIndex(
                name: "IX_tr_TresorerieEntet_idDossier",
                table: "tr_TresorerieEntet",
                column: "idDossier");

            migrationBuilder.CreateIndex(
                name: "IX_tr_TresorerieEntet_idGroup",
                table: "tr_TresorerieEntet",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_tr_TresorerieEntet_idModRglm",
                table: "tr_TresorerieEntet",
                column: "idModRglm");

            migrationBuilder.CreateIndex(
                name: "IX_tr_TresorerieEntet_idService",
                table: "tr_TresorerieEntet",
                column: "idService");

            migrationBuilder.CreateIndex(
                name: "IX_tr_TresorerieEntet_idTreso",
                table: "tr_TresorerieEntet",
                column: "idTreso");

            migrationBuilder.CreateIndex(
                name: "IX_tr_TresorerieEntet_idTreso_2",
                table: "tr_TresorerieEntet",
                column: "idTreso_2");

            migrationBuilder.CreateIndex(
                name: "IX_tr_TresorerieEntet_idUser",
                table: "tr_TresorerieEntet",
                column: "idUser");

            migrationBuilder.CreateIndex(
                name: "IX_u_UniteMesure_idGroup",
                table: "u_UniteMesure",
                column: "idGroup");

            migrationBuilder.CreateIndex(
                name: "IX_u_UniteMesure_idUser",
                table: "u_UniteMesure",
                column: "idUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
    name: "articles");

            migrationBuilder.DropTable(
                name: "Famillies");
            migrationBuilder.DropTable(
                name: "a_ArticleInFille");

            migrationBuilder.DropTable(
                name: "a_Bateau");

            migrationBuilder.DropTable(
                name: "b_Propriete");

            migrationBuilder.DropTable(
                name: "b_SoldTresorerie");

            migrationBuilder.DropTable(
                name: "d_Departement");

            migrationBuilder.DropTable(
                name: "e_Art_Depot");

            migrationBuilder.DropTable(
                name: "e_FilleInEmails");

            migrationBuilder.DropTable(
                name: "e_FilleInEntet");

            migrationBuilder.DropTable(
                name: "e_TypeDoc");

            migrationBuilder.DropTable(
                name: "f_FabricationLign");

            migrationBuilder.DropTable(
                name: "f_OrdreLine");

            migrationBuilder.DropTable(
                name: "fish_charge");

            migrationBuilder.DropTable(
                name: "fish_entetLign");

            migrationBuilder.DropTable(
                name: "fish_famille");

            migrationBuilder.DropTable(
                name: "Hotel_B_BookingExtras");

            migrationBuilder.DropTable(
                name: "Hotel_B_BookingInvites");

            migrationBuilder.DropTable(
                name: "Hotel_B_BookingLigne");

            migrationBuilder.DropTable(
                name: "Hotel_B_BookingPayment");

            migrationBuilder.DropTable(
                name: "hotel_B_FilleInBookingEntete");

            migrationBuilder.DropTable(
                name: "hotel_S_Categorie");

            migrationBuilder.DropTable(
                name: "hotel_S_Equipements");

            migrationBuilder.DropTable(
                name: "hotel_S_RoomCategorie");

            migrationBuilder.DropTable(
                name: "Maint_R_Request");

            migrationBuilder.DropTable(
                name: "Maint_S_Member");

            migrationBuilder.DropTable(
                name: "p_Famille");

            migrationBuilder.DropTable(
                name: "p_ModRglm");

            migrationBuilder.DropTable(
                name: "p_Ticket_ligne");

            migrationBuilder.DropTable(
                name: "p_Ticket_Reg");

            migrationBuilder.DropTable(
                name: "Paie_C_Cotisations");

            migrationBuilder.DropTable(
                name: "Paie_C_Rubriques");

            migrationBuilder.DropTable(
                name: "Paie_C_RubriquesExo");

            migrationBuilder.DropTable(
                name: "Paie_C_Variables");

            migrationBuilder.DropTable(
                name: "Paie_Calcul_Avance");

            migrationBuilder.DropTable(
                name: "Paie_Calcul_bulletin_ligne");

            migrationBuilder.DropTable(
                name: "Paie_Calcul_Conges");

            migrationBuilder.DropTable(
                name: "Paie_Calcul_LigneRubrique");

            migrationBuilder.DropTable(
                name: "Paie_E_Conges");

            migrationBuilder.DropTable(
                name: "Paie_E_FilleInContrat");

            migrationBuilder.DropTable(
                name: "Paie_E_Prets");

            migrationBuilder.DropTable(
                name: "paie_I_TauxFraisProf");

            migrationBuilder.DropTable(
                name: "Paie_P_POINTAGE_LIGNE");

            migrationBuilder.DropTable(
                name: "Paie_Z_LogData");

            migrationBuilder.DropTable(
                name: "r_ReglementInFille");

            migrationBuilder.DropTable(
                name: "s_EmailsSettings");

            migrationBuilder.DropTable(
                name: "s_LiaisonUsers");

            migrationBuilder.DropTable(
                name: "s_MenuInstall");

            migrationBuilder.DropTable(
                name: "s_MenuSubInstall");

            migrationBuilder.DropTable(
                name: "s_Settings");

            migrationBuilder.DropTable(
                name: "s_UserDossier");

            migrationBuilder.DropTable(
                name: "s_UserRoles");

            migrationBuilder.DropTable(
                name: "sb_CreationBarCode");

            migrationBuilder.DropTable(
                name: "sc_schedule");

            migrationBuilder.DropTable(
                name: "t_ClientCredit");

            migrationBuilder.DropTable(
                name: "t_FournisseurCredit");

            migrationBuilder.DropTable(
                name: "t_salarie");

            migrationBuilder.DropTable(
                name: "tr_TresorerieEntet");

            migrationBuilder.DropTable(
                name: "e_Emails");

            migrationBuilder.DropTable(
                name: "f_Ordre");

            migrationBuilder.DropTable(
                name: "hotel_S_Extras");

            migrationBuilder.DropTable(
                name: "hotel_S_Units");

            migrationBuilder.DropTable(
                name: "hotel_B_BookingEntete");

            migrationBuilder.DropTable(
                name: "Maint_A_Equipements");

            migrationBuilder.DropTable(
                name: "Maint_S_Team");

            migrationBuilder.DropTable(
                name: "p_Ticket");

            migrationBuilder.DropTable(
                name: "Paie_Calcul_bulletin");

            migrationBuilder.DropTable(
                name: "Paie_Calcul_Entete");

            migrationBuilder.DropTable(
                name: "Paie_E_Contrat");

            migrationBuilder.DropTable(
                name: "Paie_P_POINTAGE");

            migrationBuilder.DropTable(
                name: "s_Fille");

            migrationBuilder.DropTable(
                name: "r_Reglement");

            migrationBuilder.DropTable(
                name: "s_Menu");

            migrationBuilder.DropTable(
                name: "s_MenuSub");

            migrationBuilder.DropTable(
                name: "s_Roles");

            migrationBuilder.DropTable(
                name: "sc_calendar");

            migrationBuilder.DropTable(
                name: "b_Service");

            migrationBuilder.DropTable(
                name: "f_Fabrication");

            migrationBuilder.DropTable(
                name: "hotel_S_RoomType");

            migrationBuilder.DropTable(
                name: "e_EntetLign");

            migrationBuilder.DropTable(
                name: "p_Session");

            migrationBuilder.DropTable(
                name: "Paie_Calcul_GrpEntete");

            migrationBuilder.DropTable(
                name: "Paie_E_Employe");

            migrationBuilder.DropTable(
                name: "paie_I_ProfilContrat");

            migrationBuilder.DropTable(
                name: "fish_entet");

            migrationBuilder.DropTable(
                name: "a_Article");

            migrationBuilder.DropTable(
                name: "e_Entet");

            migrationBuilder.DropTable(
                name: "b_DepotSup");

            migrationBuilder.DropTable(
                name: "p_Caissier");

            migrationBuilder.DropTable(
                name: "p_Pos");

            migrationBuilder.DropTable(
                name: "paie_I_Categorie");

            migrationBuilder.DropTable(
                name: "paie_I_Departement");

            migrationBuilder.DropTable(
                name: "paie_I_Fonction");

            migrationBuilder.DropTable(
                name: "paie_I_Niveau");

            migrationBuilder.DropTable(
                name: "Paie_Z_Planning");

            migrationBuilder.DropTable(
                name: "Paie_Z_UserDevice");

            migrationBuilder.DropTable(
                name: "fish_port");

            migrationBuilder.DropTable(
                name: "b_Taxe");

            migrationBuilder.DropTable(
                name: "u_UniteMesure");

            migrationBuilder.DropTable(
                name: "t_Fournisseur");

            migrationBuilder.DropTable(
                name: "b_ModRglm");

            migrationBuilder.DropTable(
                name: "a_Famille");

            migrationBuilder.DropTable(
                name: "t_Client");

            migrationBuilder.DropTable(
                name: "b_Depot");

            migrationBuilder.DropTable(
                name: "s_Dossier");

            migrationBuilder.DropTable(
                name: "b_Tresorerie");

            migrationBuilder.DropTable(
                name: "Paie_Z_ZKTDevices");

            migrationBuilder.DropTable(
                name: "fish_TypeFamaille");

            migrationBuilder.DropTable(
                name: "fish_NomScientifique");

            migrationBuilder.DropTable(
                name: "b_Ville");

            migrationBuilder.DropTable(
                name: "s_Users");

            migrationBuilder.DropTable(
                name: "b_Pays");

            migrationBuilder.DropTable(
                name: "s_GroupUsers");

            migrationBuilder.UpdateData(
                table: "Familly",
                keyColumn: "familyRef",
                keyValue: null,
                column: "familyRef",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "familyRef",
                table: "Familly",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Familly",
                keyColumn: "familyName",
                keyValue: null,
                column: "familyName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "familyName",
                table: "Familly",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Familly",
                keyColumn: "familyDesc",
                keyValue: null,
                column: "familyDesc",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "familyDesc",
                table: "Familly",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "DescriptionArticle",
                keyValue: null,
                column: "DescriptionArticle",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionArticle",
                table: "Article",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ArticleRef",
                keyValue: null,
                column: "ArticleRef",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ArticleRef",
                table: "Article",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "ArticleName",
                keyValue: null,
                column: "ArticleName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ArticleName",
                table: "Article",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vista.Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Direccion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LugarNacimiento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Documento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GrupoSanguineo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Observaciones = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Profesion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NivelEstudios = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroIoma = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPersona = table.Column<int>(type: "int", nullable: false),
                    NumeroLegajo = table.Column<int>(type: "int", nullable: true),
                    Estado = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaAceptacion = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Grado = table.Column<int>(type: "int", nullable: true),
                    Dotacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brigada = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion1 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion2 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion3 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion4 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion5 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Resolucion6 = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Chofer = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    VencimientoRegistro = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contactos",
                columns: table => new
                {
                    ContactoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TelefonoCel = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoLaboral = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoFijo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactos", x => x.ContactoId);
                    table.ForeignKey(
                        name: "FK_Contactos_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Salidas",
                columns: table => new
                {
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    KmSalida = table.Column<int>(type: "int", nullable: false),
                    KmLlegada = table.Column<int>(type: "int", nullable: false),
                    NumeroParte = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CalleORuta = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroOKilometro = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EntreCalles = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PisoNumero = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Depto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoZona = table.Column<int>(type: "int", nullable: false),
                    NombreSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApellidoSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DniSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TelefonoSolicitante = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Receptor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ReceptorId = table.Column<int>(type: "int", nullable: true),
                    EncargadoId = table.Column<int>(type: "int", nullable: false),
                    QuienLlenoId = table.Column<int>(type: "int", nullable: false),
                    TipoSalida = table.Column<int>(type: "int", nullable: false),
                    Accidente_Tipo = table.Column<int>(type: "int", nullable: true),
                    CantidadVehiculos = table.Column<int>(type: "int", nullable: true),
                    CondicionesClimaticas = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FactorClimatico_Tipo = table.Column<int>(type: "int", nullable: true),
                    FactorClimatico_Evacuacion = table.Column<int>(type: "int", nullable: true),
                    Superficie = table.Column<int>(type: "int", nullable: true),
                    DetalleSuperficieDañada = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeteccionAutomaticaId = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Extintor = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Hidrante = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    TipoLugarSiniestroEmbarcacion = table.Column<int>(type: "int", nullable: true),
                    OtroLugarDeSiniestroEmbarcacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoEvacuacion = table.Column<int>(type: "int", nullable: true),
                    TipoSuperficieAfectada = table.Column<int>(type: "int", nullable: true),
                    DetalleSuperficieAfectadaIncendio = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SuperficieAfectadaCausa = table.Column<int>(type: "int", nullable: true),
                    Incendio_Tipo = table.Column<int>(type: "int", nullable: true),
                    TipoAbertura = table.Column<int>(type: "int", nullable: true),
                    OtraAbertura = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoTecho = table.Column<int>(type: "int", nullable: true),
                    OtroTecho = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OtroLugar = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEstablecimiento = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CantidadPisos = table.Column<int>(type: "int", nullable: true),
                    PisoAfectado = table.Column<int>(type: "int", nullable: true),
                    CantidadAmbientes = table.Column<int>(type: "int", nullable: true),
                    TipoLugar = table.Column<int>(type: "int", nullable: true),
                    IncendioEstablecimientoEducativo_TipoLugar = table.Column<int>(type: "int", nullable: true),
                    IncendioEstablecimientoPublico_TipoLugar = table.Column<int>(type: "int", nullable: true),
                    IncendioForestal_TipoLugar = table.Column<int>(type: "int", nullable: true),
                    IncendioHospitalesYClinicas_TipoLugar = table.Column<int>(type: "int", nullable: true),
                    IncendioIndustria_TipoLugar = table.Column<int>(type: "int", nullable: true),
                    IncendioVivienda_TipoLugar = table.Column<int>(type: "int", nullable: true),
                    Sustancias = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Controlada = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Venteo = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DilucionDeVapores = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Neutralizacion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Trasvase = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    OtraAccionesMateriales = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DetallesAccionesMateriales = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Evacuacion = table.Column<int>(type: "int", nullable: true),
                    Descontaminacion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Confinamiento = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SinAccion = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    OtraAccionesPersonas = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DetallesAccionesPersonas = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoSuperficie = table.Column<int>(type: "int", nullable: true),
                    DetalleSuperficieAfectada = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoSituacion = table.Column<int>(type: "int", nullable: true),
                    Tipo = table.Column<int>(type: "int", nullable: true),
                    TipoRescateAnimal = table.Column<int>(type: "int", nullable: true),
                    Otro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoRescatePersona = table.Column<int>(type: "int", nullable: true),
                    ServicioEspecial_Tipo = table.Column<int>(type: "int", nullable: true),
                    TipoOrganizacion = table.Column<int>(type: "int", nullable: true),
                    OtroRepresentacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPrevencion = table.Column<int>(type: "int", nullable: true),
                    TipoRepresentacion = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salidas", x => x.SalidaId);
                    table.ForeignKey(
                        name: "FK_Salidas_Personas_EncargadoId",
                        column: x => x.EncargadoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Personas_QuienLlenoId",
                        column: x => x.QuienLlenoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Salidas_Personas_ReceptorId",
                        column: x => x.ReceptorId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "BomberoSalida",
                columns: table => new
                {
                    BomberoSalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Salio = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Grado = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    BomberoPersonaId = table.Column<int>(type: "int", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BomberoSalida", x => x.BomberoSalidaId);
                    table.ForeignKey(
                        name: "FK_BomberoSalida_Personas_BomberoPersonaId",
                        column: x => x.BomberoPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BomberoSalida_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Damnificados",
                columns: table => new
                {
                    DamnificadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dni = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    LugarDeNacimiento = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Damnificados", x => x.DamnificadoId);
                    table.ForeignKey(
                        name: "FK_Damnificados_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DatosCapacitaciones",
                columns: table => new
                {
                    DatosCapacitacionId = table.Column<int>(type: "int", nullable: false),
                    NivelCapacitacion = table.Column<int>(type: "int", nullable: true),
                    NivelCapacitacionOtro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoCapacitacion = table.Column<int>(type: "int", nullable: true),
                    CapacitacionOtra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DiasCapacitacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorariosCapacitacion = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosCapacitaciones", x => x.DatosCapacitacionId);
                    table.ForeignKey(
                        name: "FK_DatosCapacitaciones_Salidas_DatosCapacitacionId",
                        column: x => x.DatosCapacitacionId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmbarcacionesAfectadas",
                columns: table => new
                {
                    EmbarcacionAfectadaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Intervinientes = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CantidadBarcos = table.Column<int>(type: "int", nullable: false),
                    CantidadBotes = table.Column<int>(type: "int", nullable: false),
                    CantidadFragatas = table.Column<int>(type: "int", nullable: false),
                    CantidadLanchas = table.Column<int>(type: "int", nullable: false),
                    Otro = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalidaId = table.Column<int>(type: "int", nullable: false),
                    IncendioSalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmbarcacionesAfectadas", x => x.EmbarcacionAfectadaId);
                    table.ForeignKey(
                        name: "FK_EmbarcacionesAfectadas_Salidas_IncendioSalidaId",
                        column: x => x.IncendioSalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Vehiculo",
                columns: table => new
                {
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Patente = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BomberoPersonaId = table.Column<int>(type: "int", nullable: true),
                    TipoVehiculo = table.Column<int>(type: "int", nullable: false),
                    NumeroMovil = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroMotor = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroChasis = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<int>(type: "int", nullable: true),
                    BomberoId = table.Column<int>(type: "int", nullable: true),
                    Airbag = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    SalidaId = table.Column<int>(type: "int", nullable: true),
                    AccidenteSalidaId = table.Column<int>(type: "int", nullable: true),
                    IncendioSalidaId = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VehiculoDamnificado_Airbag = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    DamnificadoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo", x => x.VehiculoId);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Damnificados_DamnificadoId",
                        column: x => x.DamnificadoId,
                        principalTable: "Damnificados",
                        principalColumn: "DamnificadoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Personas_BomberoId",
                        column: x => x.BomberoId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Personas_BomberoPersonaId",
                        column: x => x.BomberoPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Salidas_AccidenteSalidaId",
                        column: x => x.AccidenteSalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Salidas_IncendioSalidaId",
                        column: x => x.IncendioSalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovilBombero",
                columns: table => new
                {
                    MovilBomberoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    MovilId = table.Column<int>(type: "int", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovilBombero", x => x.MovilBomberoId);
                    table.ForeignKey(
                        name: "FK_MovilBombero_Personas_PersonaId",
                        column: x => x.PersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovilBombero_Vehiculo_MovilId",
                        column: x => x.MovilId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovilSalida",
                columns: table => new
                {
                    MovilSalidaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CargoCombustible = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PersonaId = table.Column<int>(type: "int", nullable: false),
                    ChoferPersonaId = table.Column<int>(type: "int", nullable: false),
                    MovilId = table.Column<int>(type: "int", nullable: false),
                    SalidaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovilSalida", x => x.MovilSalidaId);
                    table.ForeignKey(
                        name: "FK_MovilSalida_Personas_ChoferPersonaId",
                        column: x => x.ChoferPersonaId,
                        principalTable: "Personas",
                        principalColumn: "PersonaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovilSalida_Salidas_SalidaId",
                        column: x => x.SalidaId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovilSalida_Vehiculo_MovilId",
                        column: x => x.MovilId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seguros",
                columns: table => new
                {
                    SeguroId = table.Column<int>(type: "int", nullable: false),
                    CompañiaAseguradora = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NumeroDePoliza = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaDeVencimineto = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: true),
                    SalidaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguros", x => x.SeguroId);
                    table.ForeignKey(
                        name: "FK_Seguros_Salidas_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Salidas",
                        principalColumn: "SalidaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguros_Vehiculo_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculo",
                        principalColumn: "VehiculoId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BomberoSalida_BomberoPersonaId",
                table: "BomberoSalida",
                column: "BomberoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_BomberoSalida_SalidaId",
                table: "BomberoSalida",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contactos_PersonaId",
                table: "Contactos",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Damnificados_SalidaId",
                table: "Damnificados",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmbarcacionesAfectadas_IncendioSalidaId",
                table: "EmbarcacionesAfectadas",
                column: "IncendioSalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovilBombero_MovilId_PersonaId",
                table: "MovilBombero",
                columns: new[] { "MovilId", "PersonaId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovilBombero_PersonaId",
                table: "MovilBombero",
                column: "PersonaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovilSalida_ChoferPersonaId",
                table: "MovilSalida",
                column: "ChoferPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_MovilSalida_MovilId",
                table: "MovilSalida",
                column: "MovilId");

            migrationBuilder.CreateIndex(
                name: "IX_MovilSalida_SalidaId",
                table: "MovilSalida",
                column: "SalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NumeroLegajo",
                table: "Personas",
                column: "NumeroLegajo");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_EncargadoId",
                table: "Salidas",
                column: "EncargadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_QuienLlenoId",
                table: "Salidas",
                column: "QuienLlenoId");

            migrationBuilder.CreateIndex(
                name: "IX_Salidas_ReceptorId",
                table: "Salidas",
                column: "ReceptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguros_VehiculoId",
                table: "Seguros",
                column: "VehiculoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_AccidenteSalidaId",
                table: "Vehiculo",
                column: "AccidenteSalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_BomberoId",
                table: "Vehiculo",
                column: "BomberoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_BomberoPersonaId",
                table: "Vehiculo",
                column: "BomberoPersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_DamnificadoId",
                table: "Vehiculo",
                column: "DamnificadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_IncendioSalidaId",
                table: "Vehiculo",
                column: "IncendioSalidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_SalidaId",
                table: "Vehiculo",
                column: "SalidaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BomberoSalida");

            migrationBuilder.DropTable(
                name: "Contactos");

            migrationBuilder.DropTable(
                name: "DatosCapacitaciones");

            migrationBuilder.DropTable(
                name: "EmbarcacionesAfectadas");

            migrationBuilder.DropTable(
                name: "MovilBombero");

            migrationBuilder.DropTable(
                name: "MovilSalida");

            migrationBuilder.DropTable(
                name: "Seguros");

            migrationBuilder.DropTable(
                name: "Vehiculo");

            migrationBuilder.DropTable(
                name: "Damnificados");

            migrationBuilder.DropTable(
                name: "Salidas");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}

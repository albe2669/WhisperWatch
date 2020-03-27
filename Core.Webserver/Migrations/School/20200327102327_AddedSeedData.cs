using Microsoft.EntityFrameworkCore.Migrations;

namespace Core.Webserver.Migrations.School
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "Name", "Secret" },
                values: new object[] { 1L, "Stæhr Johansens Vej 7. 2000 Frederiksberg", "SJV 7", null });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Description", "Level", "Name", "Secret" },
                values: new object[,]
                {
                    { 1L, 1L, "", 0L, "0 STUE", null },
                    { 2L, 1L, "", 1L, "1 SAL", null },
                    { 3L, 1L, "", 2L, "2 SAL", null },
                    { 4L, 1L, "", 3L, "3 SAL", null },
                    { 5L, 1L, "", 4L, "4 SAL", null },
                    { 6L, 1L, "", 5L, "5 SAL", null },
                    { 7L, 1L, "", 6L, "6 SAL", null },
                    { 8L, 1L, "", 7L, "7 SAL", null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Area", "FloorId", "Name", "Number", "Secret" },
                values: new object[,]
                {
                    { 1L, 41L, 1L, "DEPOT", "7.000", null },
                    { 295L, 13L, 6L, "DAME TOILET", "7.522", null },
                    { 294L, 2L, 6L, "TOILET", "7.521", null },
                    { 293L, 98L, 6L, "TEORI/ØVELSER", "7.520", null },
                    { 292L, 2L, 6L, "TEKNIK", "7.519", null },
                    { 291L, 96L, 6L, "TEORI/ØVELSER", "7.518", null },
                    { 290L, 46L, 6L, "TEORI", "7.517", null },
                    { 289L, 70L, 6L, "TEORI", "7.516", null },
                    { 288L, 87L, 6L, "TEORI/ØVELSER", "7.515", null },
                    { 287L, 69L, 6L, "TEORI", "7.514", null },
                    { 286L, 70L, 6L, "TEAMBASE", "7.513", null },
                    { 285L, 8L, 6L, "MØDE", "7.512.C", null },
                    { 284L, 9L, 6L, "KOPIRUM", "7.512.B", null },
                    { 283L, 17L, 6L, "MØDE", "7.512.A", null },
                    { 282L, 17L, 6L, "MØDE", "7.512", null },
                    { 281L, 6L, 6L, "DEPOT", "7.511.A", null },
                    { 280L, 105L, 6L, "TEAMBASE", "7.511", null },
                    { 279L, 2L, 6L, "TEKNIK", "7.509", null },
                    { 278L, 9L, 6L, "-", "7.506.A", null },
                    { 277L, 66L, 6L, "LÆRER ARBEJDSRUM", "7.506", null },
                    { 276L, 83L, 6L, "LÆRER ARBEJDSRUM", "7.505", null },
                    { 275L, 1L, 6L, "TOILET", "7.504.D", null },
                    { 274L, 1L, 6L, "TOILET", "7.504.C", null },
                    { 273L, 1L, 6L, "TOILET", "7.504.B", null },
                    { 296L, 1L, 6L, "TOILET", "7.522.A", null },
                    { 272L, 3L, 6L, "TOILET", "7.504.A", null },
                    { 297L, 1L, 6L, "TOILET", "7.522.B", null },
                    { 299L, 16L, 6L, "HERRE TOILET", "7.523", null },
                    { 322L, 1L, 7L, "TOILET", "7.604.B", null },
                    { 321L, 2L, 7L, "TOILET", "7.604.A", null },
                    { 320L, 14L, 7L, "DAME TOILET", "7.604", null },
                    { 319L, 1L, 7L, "TOILET", "7.603.B", null },
                    { 318L, 1L, 7L, "TOILET", "7.603.A", null },
                    { 317L, 16L, 7L, "HERRE TOILET", "7.603", null },
                    { 316L, 66L, 7L, "TEORI", "7.602", null },
                    { 315L, 48L, 7L, "ELEVOPHOLD", "7.601", null },
                    { 314L, 33L, 7L, "GANG", "7.600.A", null },
                    { 313L, 186L, 7L, "GANG", "7.600", null },
                    { 312L, 14L, 6L, "GANG", "7.5XX", null },
                    { 311L, 14L, 6L, "GANG", "7.5XX", null },
                    { 310L, 71L, 6L, "ELEVOPHOLD", "7.5XX", null },
                    { 309L, 19L, 6L, "TRAPPE", "7.5T2", null },
                    { 308L, 19L, 6L, "TRAPPE", "7.5T1", null },
                    { 307L, 34L, 6L, "ELEVRÅD", "7.527", null },
                    { 306L, 11L, 6L, "MASKINE", "7.526.B", null },
                    { 305L, 13L, 6L, "DEPOT", "7.526.A", null },
                    { 304L, 6L, 6L, "GANG", "7.526", null },
                    { 303L, 31L, 6L, "VÆRKSTED", "7.525", null },
                    { 302L, 77L, 6L, "TEORI", "7.524", null },
                    { 301L, 1L, 6L, "TOILET", "7.523.B", null },
                    { 300L, 1L, 6L, "TOILET", "7.523.A", null },
                    { 298L, 1L, 6L, "TOILET", "7.522.C", null },
                    { 323L, 1L, 7L, "TOILET", "7.604.C", null },
                    { 271L, 13L, 6L, "DAME TOILET", "7.504", null },
                    { 269L, 1L, 6L, "TOILET", "7.503.A", null },
                    { 241L, 25L, 5L, "KONTOR", "7.416", null },
                    { 240L, 1L, 5L, "TOILET", "7.415.B", null },
                    { 239L, 1L, 5L, "TOILET", "7.415.A", null },
                    { 238L, 17L, 5L, "DEPOT/KOPI", "7.415", null },
                    { 237L, 70L, 5L, "TEAMBASE", "7.414", null },
                    { 236L, 86L, 5L, "TEORI", "7.413", null },
                    { 235L, 70L, 5L, "TEORI", "7.412", null },
                    { 234L, 11L, 5L, "KONTOR", "7.411.A", null },
                    { 233L, 5L, 5L, "PRINT", "7.411", null },
                    { 232L, 35L, 5L, "LÆRERVÆRELSE", "7.410", null },
                    { 231L, 87L, 5L, "TEORI", "7.409", null },
                    { 230L, 6L, 5L, "DEPOT", "7.408.A", null },
                    { 229L, 87L, 5L, "TEORI", "7.408", null },
                    { 228L, 2L, 5L, "TEKNIK", "7.407", null },
                    { 227L, 75L, 5L, "TEORI", "7.406", null },
                    { 226L, 1L, 5L, "TOILET", "7.405.D", null },
                    { 225L, 1L, 5L, "TOILET", "7.405.C", null },
                    { 224L, 1L, 5L, "TOILET", "7.405.B", null },
                    { 223L, 2L, 5L, "TOILET", "7.405.A", null },
                    { 222L, 14L, 5L, "DAME TOILET", "7.405", null },
                    { 221L, 1L, 5L, "TOILET", "7.404.B", null },
                    { 220L, 1L, 5L, "TOILET", "7.404.A", null },
                    { 219L, 16L, 5L, "HERRE TOILET", "7.404", null },
                    { 242L, 96L, 5L, "GF1", "7.417", null },
                    { 270L, 1L, 6L, "TOILET", "7.503.B", null },
                    { 243L, 2L, 5L, "TEKNIK", "7.418", null },
                    { 245L, 13L, 5L, "DAME TOILET", "7.421", null },
                    { 268L, 16L, 6L, "HERRE TOILET", "7.503", null },
                    { 267L, 7L, 6L, "MØDE", "7.502", null },
                    { 266L, 75L, 6L, "SKY 4", "7.501.D", null },
                    { 265L, 86L, 6L, "SKY 3", "7.501.C", null },
                    { 264L, 7L, 6L, "MØDE", "7.501.A", null },
                    { 263L, 32L, 6L, "KONTOR", "7.501", null },
                    { 262L, 206L, 6L, "GANG", "7.500", null },
                    { 261L, 14L, 5L, "GANG", "7.4XX", null },
                    { 260L, 14L, 5L, "GANG", "7.4XX", null },
                    { 259L, 71L, 5L, "ELEVOPHOLD", "7.4XX", null },
                    { 258L, 19L, 5L, "TRAPPE", "7.4T2", null },
                    { 257L, 19L, 5L, "TRAPPE", "7.4T1", null },
                    { 256L, 11L, 5L, "TEKNIK", "7.426", null },
                    { 255L, 16L, 5L, "DEPOT", "7.425.A", null },
                    { 254L, 71L, 5L, "GF1", "7.425", null },
                    { 253L, 63L, 5L, "TEORI", "7.424", null },
                    { 252L, 73L, 5L, "GF1", "7.423", null },
                    { 251L, 1L, 5L, "TOILET", "7.422.B", null },
                    { 250L, 1L, 5L, "TOILET", "7.422.A", null },
                    { 249L, 15L, 5L, "HERRE TOILET", "7.422", null },
                    { 248L, 1L, 5L, "TOILET", "7.421.C", null },
                    { 247L, 1L, 5L, "TOILET", "7.421.B", null },
                    { 246L, 1L, 5L, "TOILET", "7.421.A", null },
                    { 244L, 48L, 5L, "TEAMBASE", "7.419", null },
                    { 218L, 83L, 5L, "TEORI", "7.403", null },
                    { 324L, 1L, 7L, "TOILET", "7.604.D", null },
                    { 326L, 75L, 7L, "TEORI", "7.606", null },
                    { 403L, 55L, 8L, "DEPOT - SKP MALER", "7.K29", null },
                    { 402L, 124L, 8L, "DEPOT", "7.K28", null },
                    { 401L, 9L, 8L, "GANG", "7.K00.D", null },
                    { 400L, 26L, 8L, "GANG", "7.K00.C", null },
                    { 399L, 9L, 8L, "GANG", "7.K00.B", null },
                    { 398L, 27L, 8L, "GANG", "7.K00.A", null },
                    { 397L, 6L, 8L, "-", "7.K.", null },
                    { 396L, 52L, 8L, "GANG", "7.7XX", null },
                    { 395L, 27L, 8L, "GANG", "7.7XX", null },
                    { 394L, 14L, 8L, "GANG", "7.7X2", null },
                    { 393L, 14L, 8L, "GANG", "7.7X1", null },
                    { 392L, 19L, 8L, "TRAPPE", "7.7T2", null },
                    { 391L, 19L, 8L, "TRAPPE", "7.7T1", null },
                    { 390L, 26L, 8L, "GANG", "7.730", null },
                    { 389L, 37L, 8L, "DEPOT", "7.719", null },
                    { 388L, 11L, 8L, "DEPOT", "7.718.B", null },
                    { 387L, 13L, 8L, "VÆRKSTED", "7.718.A", null },
                    { 386L, 6L, 8L, "GANG", "7.718", null },
                    { 385L, 52L, 8L, "TEORI", "7.717", null },
                    { 384L, 16L, 8L, "DEPOT", "7.716.A", null },
                    { 383L, 114L, 8L, "TEORI-IT", "7.716", null },
                    { 382L, 9L, 8L, "HERRE TOILET", "7.715", null },
                    { 381L, 2L, 8L, "TOILET", "7.714.C", null },
                    { 404L, 54L, 8L, "DEPOT", "7.K30", null },
                    { 380L, 2L, 8L, "TOILET", "7.714.B", null },
                    { 405L, 32L, 8L, "DEPOT", "7.K32", null },
                    { 407L, 8L, 8L, "EL", "7.K34", null },
                    { 430L, 25L, 8L, "TRAPPE", "7.KT2", null },
                    { 429L, 20L, 8L, "TRAPPE", "7.KT1", null },
                    { 428L, 36L, 8L, "TEKNIK", "7.K62", null },
                    { 427L, 26L, 8L, "VENTILATION", "7.K61", null },
                    { 426L, 59L, 8L, "TEKNIK", "7.K60", null },
                    { 425L, 28L, 8L, "TEKNIK", "7.K59", null },
                    { 424L, 39L, 8L, "TRANSFORMATOR ØRSTED", "7.K58", null },
                    { 423L, 27L, 8L, "DEPOT", "7.K57", null },
                    { 422L, 34L, 8L, "DEPOT", "7.K56", null },
                    { 421L, 32L, 8L, "DEPOT", "7.K55", null },
                    { 420L, 122L, 8L, "DEPOT", "7.K54", null },
                    { 419L, 8L, 8L, "TEKNIK", "7.K49", null },
                    { 418L, 21L, 8L, "VENTILATION", "7.K48.A", null },
                    { 417L, 1L, 8L, "GANG", "7.K48", null },
                    { 416L, 136L, 8L, "DEPOT", "7.K47", null },
                    { 415L, 74L, 8L, "DEPOT", "7.K46", null },
                    { 414L, 137L, 8L, "IT LAGER", "7.K45", null },
                    { 413L, 32L, 8L, "BAD/OMKLÆDNING", "7.K44", null },
                    { 412L, 33L, 8L, "BAD/OMKLÆDNING", "7.K43", null },
                    { 411L, 11L, 8L, "VENTILATION", "7.K37.A", null },
                    { 410L, 2L, 8L, "TEKNIK", "7.K37", null },
                    { 409L, 1L, 8L, "TEKNIK", "7.K36", null },
                    { 408L, 8L, 8L, "TEKNIK", "7.K35", null },
                    { 406L, 18L, 8L, "DEPOT", "7.K33", null },
                    { 325L, 16L, 7L, "STILLERUM", "7.605", null },
                    { 379L, 2L, 8L, "TOILET", "7.714.A", null },
                    { 377L, 1L, 8L, "TEKNIK", "7.713", null },
                    { 349L, 34L, 7L, "KEMIKALIEDEPOT", "7.623", null },
                    { 348L, 19L, 7L, "DEPOT", "7.622", null },
                    { 347L, 1L, 7L, "TOILET", "7.621.B", null },
                    { 346L, 1L, 7L, "TOILET", "7.621.A", null },
                    { 345L, 8L, 7L, "HERRE TOILET", "7.621", null },
                    { 344L, 1L, 7L, "TOILET", "7.620.C", null },
                    { 343L, 1L, 7L, "TOILET", "7.620.B", null },
                    { 342L, 1L, 7L, "TOILET", "7.620.A", null },
                    { 341L, 3L, 7L, "DAME TOILET", "7.620", null },
                    { 340L, 96L, 7L, "KEMI", "7.619", null },
                    { 339L, 1L, 7L, "TEKNIK", "7.618", null },
                    { 338L, 121L, 7L, "PROCES LAB", "7.617", null },
                    { 337L, 25L, 7L, "APPARATRUM", "7.616", null },
                    { 336L, 17L, 7L, "VÆRKSTEDSASSISTENT", "7.615", null },
                    { 335L, 17L, 7L, "DEPOT", "7.614", null },
                    { 334L, 70L, 7L, "TEORI", "7.613", null },
                    { 333L, 69L, 7L, "TEORI", "7.612", null },
                    { 332L, 106L, 7L, "KEMI", "7.611", null },
                    { 331L, 17L, 7L, "STILLERUM", "7.610", null },
                    { 330L, 70L, 7L, "TEORI", "7.609", null },
                    { 329L, 87L, 7L, "BIOLOGI", "7.608", null },
                    { 328L, 2L, 7L, "TEKNIK", "7.607", null },
                    { 327L, 6L, 7L, "DEPOT", "7.606.A", null },
                    { 350L, 11L, 7L, "GIFTDEPOT", "7.624", null },
                    { 378L, 3L, 8L, "DAME TOILET", "7.714", null },
                    { 351L, 37L, 7L, "MØDELOKALE", "7.625", null },
                    { 353L, 19L, 7L, "TRAPPE", "7.6T1", null },
                    { 376L, 126L, 8L, "TEORI-IT", "7.712", null },
                    { 375L, 92L, 8L, "SZY 2", "7.711.B", null },
                    { 374L, 78L, 8L, "SZY 1", "7.711.A", null },
                    { 373L, 67L, 8L, "TEORI", "7.710", null },
                    { 372L, 72L, 8L, "TEORI", "7.709", null },
                    { 371L, 70L, 8L, "TEORI", "7.708", null },
                    { 370L, 2L, 8L, "TEKNIK", "7.707", null },
                    { 369L, 76L, 8L, "TEORI-IT", "7.706", null },
                    { 368L, 1L, 8L, "TOILET", "7.705.B", null },
                    { 367L, 1L, 8L, "TOILET", "7.705.A", null },
                    { 366L, 9L, 8L, "HERRE TOILET", "7.705", null },
                    { 365L, 2L, 8L, "TOILET", "7.704.C", null },
                    { 364L, 1L, 8L, "TOILET", "7.704.B", null },
                    { 363L, 1L, 8L, "TOILET", "7.704.A", null },
                    { 362L, 5L, 8L, "DAME TOILET", "7.704", null },
                    { 361L, 16L, 8L, "STILLERUM", "7.703", null },
                    { 360L, 83L, 8L, "TEORI", "7.702", null },
                    { 359L, 67L, 8L, "TEORI", "7.701", null },
                    { 358L, 111L, 8L, "GANG", "7.700", null },
                    { 357L, 90L, 7L, "ELEVOPHOLD", "7.6X3", null },
                    { 356L, 14L, 7L, "GANG", "7.6X2", null },
                    { 355L, 14L, 7L, "GANG", "7.6X1", null },
                    { 354L, 19L, 7L, "TRAPPE", "7.6T2", null },
                    { 352L, 60L, 7L, "PROCESKØKKEN", "7.626", null },
                    { 217L, 47L, 5L, "TEAMBASE", "7.402", null },
                    { 216L, 5L, 5L, "DEPOT", "7.401", null },
                    { 215L, 202L, 5L, "GANG", "7.400", null },
                    { 78L, 514L, 2L, "ELEVKANTINE", "7.108", null },
                    { 77L, 12L, 2L, "VENTILATION", "7.107.E", null },
                    { 76L, 15L, 2L, "VENTILATION", "7.107.D", null },
                    { 75L, 4L, 2L, "VENTILATION", "7.107.C", null },
                    { 74L, 2L, 2L, "GANG", "7.107.B", null },
                    { 73L, 5L, 2L, "EL", "7.107.A", null },
                    { 72L, 6L, 2L, "GANG", "7.107", null },
                    { 71L, 3L, 2L, "TEKNIK", "7.106", null },
                    { 70L, 3L, 2L, "KONTOR", "7.105.C", null },
                    { 69L, 13L, 2L, "KØLERUM", "7.105.B", null },
                    { 68L, 107L, 2L, "KANTINE UDSALG", "7.105.A", null },
                    { 67L, 10L, 2L, "DEPOT", "7.105.A", null },
                    { 66L, 124L, 2L, "KØKKEN", "7.105", null },
                    { 65L, 1L, 2L, "TOILET", "7.104.B", null },
                    { 64L, 1L, 2L, "TOILET", "7.104.A", null },
                    { 63L, 6L, 2L, "HERRE TOILET", "7.104", null },
                    { 62L, 1L, 2L, "TOILET", "7.103.C", null },
                    { 61L, 2L, 2L, "TOILET", "7.103.B", null },
                    { 60L, 1L, 2L, "TOILET", "7.103.A", null },
                    { 59L, 3L, 2L, "DAME TOILET", "7.103", null },
                    { 58L, 14L, 2L, "DEPOT", "7.102.A", null },
                    { 57L, 21L, 2L, "DEPOT", "7.102", null },
                    { 56L, 144L, 2L, "PERSONALE KANTINE", "7.101", null },
                    { 79L, 78L, 2L, "VEJLEDNING", "7.109", null },
                    { 55L, 10L, 2L, "TRAPPE", "7.100", null },
                    { 80L, 8L, 2L, "MØDE", "7.109.A", null },
                    { 82L, 2L, 2L, "TEKNIK", "7.110", null },
                    { 105L, 28L, 2L, "GANG", "7.1XX", null },
                    { 104L, 17L, 2L, "GANG", "7.1XX", null },
                    { 103L, 16L, 2L, "GANG", "7.1XX", null },
                    { 102L, 21L, 2L, "TRAPPE", "7.1T2", null },
                    { 101L, 20L, 2L, "TRAPPE", "7.1T2", null },
                    { 100L, 19L, 2L, "TRAPPE", "7.1T1", null },
                    { 99L, 22L, 2L, "GANG", "7.1T1", null },
                    { 98L, 5L, 2L, "DEPOT", "7.115.A", null },
                    { 97L, 60L, 2L, "BALKON - MØDELOKALE", "7.115", null },
                    { 96L, 2L, 2L, "TOILET", "7.114.C", null },
                    { 95L, 2L, 2L, "TOILET", "7.114.B", null },
                    { 94L, 2L, 2L, "TOILET", "7.114.A", null },
                    { 93L, 6L, 2L, "HERRE TOILET", "7.114", null },
                    { 92L, 1L, 2L, "TOILET", "7.113.C", null },
                    { 91L, 2L, 2L, "TOILET", "7.113.B", null },
                    { 90L, 1L, 2L, "TOILET", "7.113.A", null },
                    { 89L, 4L, 2L, "DAME TOILET", "7.113", null },
                    { 88L, 25L, 2L, "KONTOR & MØDE", "7.112.D", null },
                    { 87L, 21L, 2L, "MØDELOKALE", "7.112.C", null },
                    { 86L, 18L, 2L, "MØDELOKALE & TEEKØKKEN", "7.112.B", null },
                    { 85L, 14L, 2L, "DEPOT", "7.112.A", null },
                    { 84L, 134L, 2L, "BYGNINGSAFD.", "7.112", null },
                    { 83L, 100L, 2L, "EUX", "7.111", null },
                    { 81L, 7L, 2L, "MØDE", "7.109.B", null },
                    { 106L, 31L, 2L, "GANG", "7.1XX", null },
                    { 54L, 16L, 1L, "VINDFANG", "7.0XX", null },
                    { 52L, 12L, 1L, "GANG", "7.0XX", null },
                    { 24L, 15L, 1L, "RENGØRING", "7.011", null },
                    { 23L, 33L, 1L, "SCENE", "7.010", null },
                    { 22L, 21L, 1L, "MASSAGE", "7.009", null },
                    { 21L, 19L, 1L, "DEPOT", "7.008", null },
                    { 20L, 13L, 1L, "TEKNIK", "7.007", null },
                    { 19L, 6L, 1L, "HC TOILET", "7.006", null },
                    { 18L, 2L, 1L, "TOILET", "7.005.D", null },
                    { 17L, 2L, 1L, "DAME TOILET", "7.005.C", null },
                    { 16L, 2L, 1L, "TOILET", "7.005.B", null },
                    { 15L, 2L, 1L, "DAME TOILET", "7.005.A", null },
                    { 14L, 8L, 1L, "DAME TOILET", "7.005", null },
                    { 13L, 2L, 1L, "HERRE TOILET", "7.004.C", null },
                    { 12L, 2L, 1L, "HERRE TOILET", "7.004.B", null },
                    { 11L, 2L, 1L, "HERRE TOILET", "7.004.A", null },
                    { 10L, 12L, 1L, "HERRE TOILET", "7.004", null },
                    { 9L, 43L, 1L, "GANG", "7.003.C", null },
                    { 8L, 93L, 1L, "TEORI", "7.003.A", null },
                    { 7L, 28L, 1L, "DEPOT", "7.003.8", null },
                    { 6L, 410L, 1L, "GANG", "7.003", null },
                    { 5L, 42L, 1L, "RECEPTION", "7.002.A", null },
                    { 4L, 43L, 1L, "RECEPTION", "7.002", null },
                    { 3L, 41L, 1L, "MØDELOKALE", "7.001", null },
                    { 2L, 337L, 1L, "GANG", "7.000", null },
                    { 25L, 14L, 1L, "HTX-DEPOT", "7.012", null },
                    { 53L, 12L, 1L, "GANG", "7.0XX", null },
                    { 26L, 551L, 1L, "AULA", "7.013", null },
                    { 28L, 5L, 1L, "GANG", "7.013.B", null },
                    { 51L, 20L, 1L, "TRAPPE", "7.0T2", null },
                    { 50L, 20L, 1L, "TRAPPE", "7.0T1", null },
                    { 49L, 251L, 1L, "UNDERVISNINGSGRUNDFORLØB 2", "7.023", null },
                    { 48L, 192L, 1L, "UNDERVISNINGSGRUNDFORLØB 1", "7.022", null },
                    { 47L, 30L, 1L, "HTX-SLIBERUM", "7.021.D", null },
                    { 46L, 56L, 1L, "HTX-VÆRKSTED", "7.021.C", null },
                    { 45L, 11L, 1L, "KONTOR", "7.021.B", null },
                    { 44L, 42L, 1L, "IT/TEORI", "7.021.A", null },
                    { 43L, 343L, 1L, "HTX-VÆRKSTED", "7.021", null },
                    { 42L, 55L, 1L, "DEPOT", "7.020", null },
                    { 41L, 49L, 1L, "STOLE DEPOT", "7.019", null },
                    { 40L, 43L, 1L, "VÆRKSTED - Way2Go", "7.018", null },
                    { 39L, 13L, 1L, "TEKNIK", "7.017", null },
                    { 38L, 60L, 1L, "VÆRKSTED - Way2Go", "7.016", null },
                    { 37L, 2L, 1L, "DAME TOILET", "7.015.C", null },
                    { 36L, 2L, 1L, "DAME TOILET", "7.015.B", null },
                    { 35L, 3L, 1L, "DAME TOILET", "7.015.A", null },
                    { 34L, 9L, 1L, "DAME TOILET", "7.015", null },
                    { 33L, 2L, 1L, "HERRE TOILET", "7.014.B", null },
                    { 32L, 2L, 1L, "HERRE TOILET", "7.014.A", null },
                    { 31L, 9L, 1L, "HERRE TOILET", "7.014", null },
                    { 30L, 38L, 1L, "GANG", "7.013.D", null },
                    { 29L, 5L, 1L, "GANG", "7.013.C", null },
                    { 27L, 7L, 1L, "GANG", "7.013.A", null },
                    { 107L, 4L, 2L, "GANG", "7.1XX", null },
                    { 108L, 26L, 3L, "GANG", "7.200.A", null },
                    { 109L, 32L, 3L, "ANKOMST/GANG", "7.200.B", null },
                    { 187L, 70L, 4L, "E-ZONE", "7.313", null },
                    { 186L, 35L, 4L, "PITSTOP", "7.312", null },
                    { 185L, 11L, 4L, "KØKKEN", "7.311.A", null },
                    { 184L, 5L, 4L, "GANG", "7.311", null },
                    { 183L, 35L, 4L, "PITSTOP", "7.310", null },
                    { 182L, 6L, 4L, "DEPOT", "7.309.A", null },
                    { 181L, 51L, 4L, "PITSTOP", "7.309", null },
                    { 180L, 2L, 4L, "TEKNIK", "7.308", null },
                    { 179L, 75L, 4L, "TEAMBASE", "7.307", null },
                    { 178L, 16L, 4L, "KONTOR", "7.306", null },
                    { 177L, 1L, 4L, "TOILET", "7.305.D", null },
                    { 176L, 1L, 4L, "TOILET", "7.305.C", null },
                    { 175L, 1L, 4L, "TOILET", "7.305.B", null },
                    { 174L, 3L, 4L, "TOILET", "7.305.A", null },
                    { 173L, 13L, 4L, "DAME TOILET", "7.305", null },
                    { 172L, 1L, 4L, "TOILET", "7.304.B", null },
                    { 171L, 1L, 4L, "TOILET", "7.304.A", null },
                    { 170L, 16L, 4L, "HERRE TOILET", "7.304", null },
                    { 169L, 16L, 4L, "KONTOR", "7.303", null },
                    { 168L, 11L, 4L, "SAMTALERUM", "7.302.C", null },
                    { 167L, 13L, 4L, "SAMTALERUM", "7.302.B", null },
                    { 166L, 11L, 4L, "SAMTALERUM", "7.302.A", null },
                    { 165L, 10L, 4L, "GANG", "7.302", null },
                    { 188L, 17L, 4L, "MØDE", "7.313.A", null }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Area", "FloorId", "Name", "Number", "Secret" },
                values: new object[,]
                {
                    { 164L, 17L, 4L, "KONTOR", "7.301", null },
                    { 189L, 69L, 4L, "Way2Go", "7.314", null },
                    { 191L, 8L, 4L, "PRINT", "7.315.A", null },
                    { 214L, 2L, 5L, "TOILET", "7.4.20", null },
                    { 213L, 14L, 4L, "GANG", "7.3XX", null },
                    { 212L, 14L, 4L, "GANG", "7.3XX", null },
                    { 211L, 19L, 4L, "TRAPPE", "7.3T2", null },
                    { 210L, 19L, 4L, "TRAPPE", "7.3T1", null },
                    { 209L, 210L, 4L, "GANG", "7.350", null },
                    { 208L, 30L, 4L, "KONTOR", "7.327", null },
                    { 207L, 33L, 4L, "MØDE", "7.326", null },
                    { 206L, 15L, 4L, "FLEX", "7.325.A", null },
                    { 205L, 96L, 4L, "EUX", "7.325", null },
                    { 204L, 1L, 4L, "TOILET", "7.324.B", null },
                    { 203L, 1L, 4L, "TOILET", "7.324.A", null },
                    { 202L, 16L, 4L, "HERRE TOILET", "7.324", null },
                    { 201L, 1L, 4L, "TOILET", "7.323.C", null },
                    { 200L, 1L, 4L, "TOILET", "7.323.B", null },
                    { 199L, 1L, 4L, "TOILET", "7.323.A", null },
                    { 198L, 13L, 4L, "DAME TOILET", "7.323", null },
                    { 197L, 98L, 4L, "EUX", "7.321", null },
                    { 196L, 2L, 4L, "TEKNIK", "7.320", null },
                    { 195L, 96L, 4L, "EUX", "7.319", null },
                    { 194L, 79L, 4L, "Way2Go", "7.318", null },
                    { 193L, 87L, 4L, "Way2Go", "7.317", null },
                    { 192L, 87L, 4L, "TEAMBASE", "7.316", null },
                    { 190L, 8L, 4L, "PRINT", "7.315", null },
                    { 163L, 32L, 4L, "KONTOR", "7.300", null },
                    { 162L, 2L, 4L, "PERSONALTOILET", "7.3.22", null },
                    { 161L, 14L, 3L, "GANG", "7.2XX", null },
                    { 132L, 86L, 3L, "ELEV/STUDIEADMIN._GF1+GF2 12p", "7.214", null },
                    { 131L, 8L, 3L, "SUPPORTRUM", "7.213", null },
                    { 130L, 82L, 3L, "UDVIKLING 7p", "7.212", null },
                    { 129L, 11L, 3L, "SUPPORTRUM", "7.211", null },
                    { 128L, 46L, 3L, "DIREKTION 3P", "7.210", null },
                    { 127L, 36L, 3L, "MØDE", "7.209", null },
                    { 126L, 33L, 3L, "VEU 3p", "7.208", null },
                    { 125L, 6L, 3L, "SUPPORTRUM", "7.207", null },
                    { 124L, 28L, 3L, "-", "7.207", null },
                    { 123L, 88L, 3L, "CONTROLLER 10p", "7.206", null },
                    { 122L, 18L, 3L, "SUPPORTRUM", "7.205", null },
                    { 121L, 1L, 3L, "TOILET", "7.204.D", null },
                    { 120L, 1L, 3L, "TOILET", "7.204.C", null },
                    { 119L, 1L, 3L, "TOILET", "7.204.B", null },
                    { 118L, 2L, 3L, "TOILET", "7.204.A", null },
                    { 117L, 47L, 3L, "HR", "7.204", null },
                    { 116L, 13L, 3L, "DAME TOILET", "7.204", null },
                    { 115L, 1L, 3L, "TOILET", "7.203.B", null },
                    { 114L, 1L, 3L, "TOILET", "7.203.A", null },
                    { 113L, 47L, 3L, "TEKØKKEN", "7.203", null },
                    { 112L, 16L, 3L, "HERRE TOILET", "7.203", null },
                    { 111L, 48L, 3L, "GANG", "7.200.D", null },
                    { 110L, 134L, 3L, "GANG", "7.200.C", null },
                    { 133L, 13L, 3L, "SUPPORTRUM", "7.215", null },
                    { 134L, 8L, 3L, "SUPPORTRUM", "7.216", null },
                    { 135L, 140L, 3L, "ELEV/STUDIEADMIN._HF+SKP 14p", "7.217", null },
                    { 136L, 51L, 3L, "FLEKS MØDELOKALE", "7.218.A", null },
                    { 160L, 14L, 3L, "GANG", "7.2XX", null },
                    { 159L, 19L, 3L, "TRAPPE", "7.2T2", null },
                    { 158L, 19L, 3L, "TRAPPE", "7.2T1", null },
                    { 157L, 2L, 3L, "TEKNIK", "7.233", null },
                    { 156L, 8L, 3L, "PRINT/KOPI", "7.232", null },
                    { 155L, 9L, 3L, "SUPPORTRUM", "7.231", null },
                    { 154L, 66L, 3L, "MARCOM 6p", "7.230", null },
                    { 153L, 31L, 3L, "PROJEKT OMRÅD", "7.229", null },
                    { 152L, 71L, 3L, "ELEV/STUDIEADMIN._AMV+GTX 10p", "7.228", null },
                    { 151L, 9L, 3L, "SUPPORTRUM", "7.227", null },
                    { 150L, 9L, 3L, "PRINT/KOPI", "7.226", null },
                    { 431L, 17L, 8L, "GANG", "7.KX1", null },
                    { 149L, 2L, 3L, "TEKNIK", "7.225", null },
                    { 147L, 2L, 3L, "RENGØRING", "7.222.D", null },
                    { 146L, 2L, 3L, "TOILET", "7.222.C", null },
                    { 145L, 2L, 3L, "TOILET", "7.222.B", null },
                    { 144L, 2L, 3L, "TOILET", "7.222.A", null },
                    { 143L, 11L, 3L, "TOILET", "7.222", null },
                    { 142L, 19L, 3L, "GARDEROBE", "7.221.A", null },
                    { 141L, 31L, 3L, "TEKØKKEN", "7.221", null },
                    { 140L, 31L, 3L, "KONTOR", "7.220", null },
                    { 139L, 6L, 3L, "IT SUPPORT", "7.219.A", null },
                    { 138L, 56L, 3L, "IT SUPPORT - ENIGA", "7.219", null },
                    { 137L, 49L, 3L, "FLEKS MØDELOKALE", "7.218.B", null },
                    { 148L, 1L, 3L, "GANG", "7.222.E", null },
                    { 432L, 11L, 8L, "GANG", "7.KX2", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}

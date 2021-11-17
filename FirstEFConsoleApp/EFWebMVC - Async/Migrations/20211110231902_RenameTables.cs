using Microsoft.EntityFrameworkCore.Migrations;

namespace EFWebMVC.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_auditEntities_Country_CountryId",
                table: "auditEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_bookFiles_BookFormat_BookFormatId",
                table: "bookFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_bookFiles_Books_BookId",
                table: "bookFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookFiles",
                table: "bookFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_auditEntities",
                table: "auditEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhsicalLibrary",
                table: "PhsicalLibrary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookFormat",
                table: "BookFormat");

            migrationBuilder.RenameTable(
                name: "bookFiles",
                newName: "BookFiles");

            migrationBuilder.RenameTable(
                name: "auditEntities",
                newName: "AuditEntities");

            migrationBuilder.RenameTable(
                name: "Publisher",
                newName: "Publishers");

            migrationBuilder.RenameTable(
                name: "PhsicalLibrary",
                newName: "PhisicalLibraries");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "BookFormat",
                newName: "BooksFormats");

            migrationBuilder.RenameIndex(
                name: "IX_bookFiles_BookId",
                table: "BookFiles",
                newName: "IX_BookFiles_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_bookFiles_BookFormatId",
                table: "BookFiles",
                newName: "IX_BookFiles_BookFormatId");

            migrationBuilder.RenameIndex(
                name: "IX_auditEntities_CountryId",
                table: "AuditEntities",
                newName: "IX_AuditEntities_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookFiles",
                table: "BookFiles",
                column: "BookFileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditEntities",
                table: "AuditEntities",
                column: "AuditEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhisicalLibraries",
                table: "PhisicalLibraries",
                column: "PhsicalLibraryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BooksFormats",
                table: "BooksFormats",
                column: "BookFormatId");

            migrationBuilder.CreateTable(
                name: "PhisicalBooks",
                columns: table => new
                {
                    PhsicalBookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhisicalBooks", x => x.PhsicalBookId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEntities_Countries_CountryId",
                table: "AuditEntities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookFiles_Books_BookId",
                table: "BookFiles",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookFiles_BooksFormats_BookFormatId",
                table: "BookFiles",
                column: "BookFormatId",
                principalTable: "BooksFormats",
                principalColumn: "BookFormatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditEntities_Countries_CountryId",
                table: "AuditEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_BookFiles_Books_BookId",
                table: "BookFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_BookFiles_BooksFormats_BookFormatId",
                table: "BookFiles");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "PhisicalBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookFiles",
                table: "BookFiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditEntities",
                table: "AuditEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhisicalLibraries",
                table: "PhisicalLibraries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BooksFormats",
                table: "BooksFormats");

            migrationBuilder.RenameTable(
                name: "BookFiles",
                newName: "bookFiles");

            migrationBuilder.RenameTable(
                name: "AuditEntities",
                newName: "auditEntities");

            migrationBuilder.RenameTable(
                name: "Publishers",
                newName: "Publisher");

            migrationBuilder.RenameTable(
                name: "PhisicalLibraries",
                newName: "PhsicalLibrary");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "BooksFormats",
                newName: "BookFormat");

            migrationBuilder.RenameIndex(
                name: "IX_BookFiles_BookId",
                table: "bookFiles",
                newName: "IX_bookFiles_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookFiles_BookFormatId",
                table: "bookFiles",
                newName: "IX_bookFiles_BookFormatId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditEntities_CountryId",
                table: "auditEntities",
                newName: "IX_auditEntities_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookFiles",
                table: "bookFiles",
                column: "BookFileId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_auditEntities",
                table: "auditEntities",
                column: "AuditEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publisher",
                table: "Publisher",
                column: "PublisherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhsicalLibrary",
                table: "PhsicalLibrary",
                column: "PhsicalLibraryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookFormat",
                table: "BookFormat",
                column: "BookFormatId");

            migrationBuilder.AddForeignKey(
                name: "FK_auditEntities_Country_CountryId",
                table: "auditEntities",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_bookFiles_BookFormat_BookFormatId",
                table: "bookFiles",
                column: "BookFormatId",
                principalTable: "BookFormat",
                principalColumn: "BookFormatId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_bookFiles_Books_BookId",
                table: "bookFiles",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publisher_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

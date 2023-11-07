using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using System.Text.Json;
using Web.Controllers.Base;
using Infrastructure.Data.Postgres.EntityFramework;

namespace Web.Controllers
{
    public class BooksController : BaseCrudController<Books, int, CreateBookDto, UpdateBookDto, BookInfoDto>
    {
    private PostgresContext _context;
    public BooksController(IBooksService service, PostgresContext context) : base(service)
    {
      _context = context;
    }
    [HttpGet]
    public IActionResult GetAllBooks()
    {
      // Comment verilerini yükleyin
      var book = _context.Books
            .Include(b => b.User)
            .Include(b => b.Comment)
                    .Select(book => new
                    {
                       userId= book.UserId,
                       commentText=book.Comment,

                    })
        .ToList();

      var options = new JsonSerializerOptions
      {
        ReferenceHandler = ReferenceHandler.Preserve,
        MaxDepth = 500 // Derinlik sınırını artırın
      };
      var json = JsonSerializer.Serialize(book, options);

      // JSON formatında yanıt döndürmek için bir IActionResult oluşturun
      IActionResult response = new ContentResult
      {

        Content = json,  // Verileri JSON formatına dönüştürün
        ContentType = "application/json", // İçerik türünü JSON olarak belirtin
        StatusCode = 200 // HTTP 200 (Başarılı) durum kodunu ayarlayın
      };

      return response;


    }
  }
}

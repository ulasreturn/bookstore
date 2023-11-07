using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
  public class BookInfoDto
  {
    public int Id { get; set; }
    public string CoverPhoto { get; set; } = default!;
    public string BookName { get; set; } = default!;
    public int Price { get; set; }
    public int Piece { get; set; }
    public string BookStatus { get; set; } = default!;
    public int SaleId { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }

        public BookInfoDto Books { get; set; }

        

        /*public Basket Basket { get; set; }
        public User User { get; set; }
        public Sale Sale { get; set; }*/
    }
}

using BookRazor.Interface;
using BookRazor.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookRazor.Respository
{
	public class BookRespository : IRepository
	{
		public HashSet<Book> Books { get; set; } = new HashSet<Book> { 
					new Book {Id = 1, Title = "ASP.NET Core for dummy", Publisher = "Apress", Year = 2023, Authors = "Donal Trump"},
					new Book {Id = 2, Title = "Professional ASP.NET Core ", Publisher = "Manning", Year = 2022, Authors = "Bill Clinton"},
					new Book {Id = 3, Title = "ASP.NET Core Self learning", Publisher = "Wiley", Year = 2023, Authors = "Donal Trump"},
					new Book {Id = 4, Title = "ASP.NET Core quick course", Publisher = "Linda", Authors = "Donal Trump"},
					new Book {Id = 5, Title = "ASP.NET Core video Course", Publisher = "Linda", Authors = "Donal Trump"},

		};

        public Book Get(int id) => Books.SingleOrDefault(b => b.Id == id);
        public bool Delete(int id)
        {
			var book = Get(id);
			return book != null ? Books.Remove(book) : false;
        }


    }
}

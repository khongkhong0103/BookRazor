using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRazor.Pages
{
using BookRazor.Interface;
using BookRazor.Models;
public class IndexModel : PageModel
	{
	private readonly IRepository _repository;
	public HashSet<Book> Books => _repository.Books;
	public int Count => _repository.Books.Count;
	public IndexModel(IRepository repository) => _repository = repository;
	
	}
}

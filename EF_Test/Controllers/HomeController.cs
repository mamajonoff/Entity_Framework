using EF_Test.Data;
using EF_Test.Models;
using EF_Test.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EF_Test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public HomeController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var listOfBooks = _dbContext.Books.ToList();
            return View(listOfBooks);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddBookViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                Book book = new()
                {
                    Name = viewModel.Name,
                    Author = viewModel.Author,
                    Price = viewModel.Price,
                    Date = DateTime.Now
                };

                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        public IActionResult Delete(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(b => b.Id == id);
            EditBookViewModel editBook = new()
            {
                Id = book.Id,
                Name = book.Name,
                Author = book.Author,
                Price= book.Price
            };
            return View(editBook);
        }
        [HttpPost]
        public IActionResult Edit(EditBookViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                Book book = new()
                {
                    Id = viewModel.Id,
                    Name = viewModel.Name,
                    Author = viewModel.Author,
                    Price = viewModel.Price,
                    Date = DateTime.Now
                };

                _dbContext.Update(book);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
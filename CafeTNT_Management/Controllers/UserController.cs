using AutoMapper;
using CafeTNT_Management.Models;
using CafeTNT_Management.Repository.DTO;
using CafeTNT_Management.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CafeTNT_Management.Controllers
{
    public class UserController : Controller
    {
        readonly IUserMasterRepository userRepository;
        public UserController(IUserMasterRepository repository)
        {
            this.userRepository = repository;
        }
        // GET: User  
        
        public ActionResult Index()
        {
            return View();
        }
        
        public JsonResult GetAllBooks()
        {
            List<UserMaster> master = new List<UserMaster>();
            List<UserMasterDTO> data = userRepository.GetAll().ToList();
            master = Mapper.Map<List<UserMaster>>(data);

            return Json(master, JsonRequestBehavior.AllowGet);
        }
        //GET: Book by Id
        public JsonResult GetBookById(int id)
        {
            List<UserMaster> master = new List<UserMaster>();
            List<UserMasterDTO> data = userRepository.GetAll().Where(x => x.ID == id).ToList();
            master = Mapper.Map<List<UserMaster>>(data);

            return Json(master, JsonRequestBehavior.AllowGet);
        }

        ////GET: Book by Id
        //public JsonResult GetBookById(string id)
        //{
        //    using (BookDBContext contextObj = new BookDBContext())
        //    {
        //        var bookId = Convert.ToInt32(id);
        //        var getBookById = contextObj.book.Find(bookId);
        //        return Json(getBookById, JsonRequestBehavior.AllowGet);
        //    }
        //}
        ////Update Book
        //public string UpdateBook(Book book)
        //{
        //    if (book != null)
        //    {
        //        using (BookDBContext contextObj = new BookDBContext())
        //        {
        //            int bookId = Convert.ToInt32(book.Id);
        //            Book _book = contextObj.book.Where(b => b.Id == bookId).FirstOrDefault();
        //            _book.Title = book.Title;
        //            _book.Author = book.Author;
        //            _book.Publisher = book.Publisher;
        //            _book.Isbn = book.Isbn;
        //            contextObj.SaveChanges();
        //            return "Book record updated successfully";
        //        }
        //    }
        //    else
        //    {
        //        return "Invalid book record";
        //    }
        //}
        //// Add book
        //public string AddBook(Book book)
        //{
        //    if (book != null)
        //    {
        //        using (BookDBContext contextObj = new BookDBContext())
        //        {
        //            contextObj.book.Add(book);
        //            contextObj.SaveChanges();
        //            return "Book record added successfully";
        //        }
        //    }
        //    else
        //    {
        //        return "Invalid book record";
        //    }
        //}
        //// Delete book
        //public string DeleteBook(string bookId)
        //{

        //    if (!String.IsNullOrEmpty(bookId))
        //    {
        //        try
        //        {
        //            int _bookId = Int32.Parse(bookId);
        //            using (BookDBContext contextObj = new BookDBContext())
        //            {
        //                var _book = contextObj.book.Find(_bookId);
        //                contextObj.book.Remove(_book);
        //                contextObj.SaveChanges();
        //                return "Selected book record deleted sucessfully";
        //            }
        //        }
        //        catch (Exception)
        //        {
        //            return "Book details not found";
        //        }
        //    }
        //    else
        //    {
        //        return "Invalid operation";
        //    }
        //}
    }
}
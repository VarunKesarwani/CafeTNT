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
    }
}
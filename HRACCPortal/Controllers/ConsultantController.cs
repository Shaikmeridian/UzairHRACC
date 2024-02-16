using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRACCPortal.Edmx;
using HRACCPortal.Models;

namespace HRACCPortal.Controllers
{
    [Authorize]
    public class ConsultantController : Controller
    {
         
        public HRACCDBEntities entities;
        clsCrud cls;
        public ConsultantController()
        {
            entities = new HRACCDBEntities();
            cls = new clsCrud();
        }
        // GET: Consultant
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AddConsultant()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddConsultant(ConsultantModel consultant)
        {
            string message = "";
            try
            {
                message = cls.AddConsultant(consultant);
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            
             
            return Json(new { message = message, JsonRequestBehavior.AllowGet });
        }
         
        public ActionResult ViewConsultants()
        {
            cls.GetConsultants();
            return View(cls);
        }
        
        public ActionResult EditConsultant(int id)
        {
            ConsultantModel cl = cls.GetConsultantById(id);
            return Json(new { cl= cl,  JsonRequestBehavior.AllowGet });
        }
        public ActionResult ConsultantPositionDetails()
        {
            cls.GetconsultantPositionDetails();
            return View(cls);
        }
        public ActionResult EditConsultantPositionDetails(int id)
        {
            ConsultantPositionDetailsModel cl = cls.GetConsultantPositionDetailsById(id);
            return Json(new { cl = cl, JsonRequestBehavior.AllowGet });
        }
        [HttpPost]
        public ActionResult AddConsultantPositionDetails(ConsultantPositionDetailsModel consultantPositionDetail)
        {
            string message = "";
            try
            {
                message = cls.AddConsultantPositionDetails(consultantPositionDetail);
            }
            catch (Exception e)
            {
                message = e.Message;
            }


            return Json(new { message = message, JsonRequestBehavior.AllowGet });
        }
    }
}
using QuizWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuizWebApplication.Controllers
{
    public class HomeController : Controller
    {
        QuizAppEntities db= new QuizAppEntities();
        [HttpGet]
        public ActionResult tlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult tlogin(tbl_admin ad)
        {
            tbl_admin a=db.tbl_admin.Where(x => x.ad_name == ad.ad_name && x.ad_pass == ad.ad_pass).SingleOrDefault();
            if (a != null)
            {
                Session["ad_id"] = a.ad_id;
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.msg = "Invalid Username or Password!";
            }
            return View();
        }
        public ActionResult slogin()
        {
            return View();
        }
        
        public ActionResult Dashboard()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Add_Category()
        {
            //Session["ad_id"] = 2; //we will remove it soon// Assuming admin ID is set to 1 for demonstration purposes
            int ad_id = Convert.ToInt32(Session["ad_id"]);
            List<tbl_category> catLi=db.tbl_category.Where(x => x.cat_fk_ad_id == ad_id).OrderByDescending(x=>x.car_id).ToList();

            ViewData["list"] = catLi;
            return View();
        }
        [HttpPost]
        public ActionResult Add_Category(tbl_category cat)
        {

             List<tbl_category> catLi = db.tbl_category.OrderByDescending(x => x.car_id).ToList();
            ViewData["list"] = catLi;
            
            tbl_category c= new tbl_category();
            c.cat_name = cat.cat_name;
            c.cat_fk_ad_id = Convert.ToInt32(Session["ad_id"]);

            db.tbl_category.Add(c);
            db.SaveChanges();
            return RedirectToAction("Add_Category");
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddQuestions()
        {
            int sid = Convert.ToInt32(Session["ad_id"]);
            List<tbl_category> li = db.tbl_category.Where(x => x.cat_fk_ad_id == sid).ToList();
            ViewBag.list = new SelectList(li, "car_id", "cat_name");
            return View();
        }
        [HttpPost]
        public ActionResult AddQuestions(tbl_questions q)
        {
            int sid = Convert.ToInt32(Session["ad_id"]);
            List<tbl_category> li = db.tbl_category.Where(x => x.cat_fk_ad_id == sid).ToList();
            ViewBag.list = new SelectList(li, "car_id", "cat_name");
            
            tbl_questions qa = new tbl_questions();
            qa.q_text = q.q_text;
            qa.QA = q.QA;
            qa.QB = q.QB;
            qa.QC = q.QC;
            qa.QD = q.QD;
            qa.QCorrectAns = q.QCorrectAns;
            qa.q_fk_catid = q.q_fk_catid; // Assuming this is the foreign key to the category
            db.tbl_questions.Add(qa);
            db.SaveChanges();
            ViewBag.ms="Question Added Successfully";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
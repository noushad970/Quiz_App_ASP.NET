using QuizWebApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
        
        [HttpGet]
        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("Index");
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
        [HttpPost]
        public ActionResult slogin( student s)
        {
            student sv= db.students.Where(x => x.std_name == s.std_name && x.std_password == s.std_password).SingleOrDefault();
            if (sv == null)
            {
                ViewBag.msg = "Invalid Username or Password!";
            }
            else
            {
                return RedirectToAction("ExamDashboard");
            }
            return View();
        }



        [HttpGet]
        public ActionResult sregister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult sregister(student smv,HttpPostedFileBase imgfile)
        {
            student s= new student();
            try
            {
                s.std_name = smv.std_name;
                s.std_password = smv.std_password;
                s.std_image = uploadImage(imgfile); // Assuming you handle image upload separately
                db.students.Add(s);
                db.SaveChanges();
                return RedirectToAction("slogin");
            }
            catch (Exception )
            {

                ViewBag.msg = "Data Could Not Found";
            }
            return View();
        }
        public string uploadImage(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();

            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals("jpg") || extension.ToLower().Equals("jpeg") || extension.ToLower().Equals("png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("/Content/images/"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);
                        path = "~/Content/upload/" + random + Path.GetFileName(file.FileName);


                    }
                    catch (Exception e)
                    {
                        path = "-1";
                    }
                }
            }
            
            
            return path; // Return null if no file was uploaded
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult ExamDashboard()
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
            if (Session["ad_id"] != null)
            {
                return RedirectToAction("Dashboard");
            }
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
            TempData["ms"]="Question Added Successfully";
            TempData.Keep();
            return RedirectToAction("AddQuestions");
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
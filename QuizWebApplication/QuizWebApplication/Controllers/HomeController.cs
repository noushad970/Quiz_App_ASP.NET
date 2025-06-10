﻿using QuizWebApplication.Models;
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
        public ActionResult tlogin()
        {
            return View();
        }
        public ActionResult slogin()
        {
            return View();
        }
        public ActionResult alogin()
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
            Session["ad_id"] = 1; //we will remove it soon// Assuming admin ID is set to 1 for demonstration purposes
            int ad_id = Convert.ToInt32(Session["ad_id"].ToString());
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
            c.cat_fk_ad_id = Convert.ToInt32(Session["ad_id"].ToString());

            db.tbl_category.Add(c);
            db.SaveChanges();
            return RedirectToAction("Add_Category");
        }

        public ActionResult Index()
        {
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
using ASP_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ASP_Intro.Controllers
{
    public class ExamController:Controller
    { private List<Exam> _exams;
        DateTime time1 = new DateTime(2022, 6, 6);
        DateTime time2 = new DateTime(2022, 6, 17);
        DateTime time3 = new DateTime(2022, 6, 22);
        DateTime time4 = new DateTime(2022, 6, 14);
        DateTime time5 = new DateTime(2022, 6, 5);
        DateTime time6 = new DateTime(2022, 6, 1);
        DateTime time7 = new DateTime(2022, 6, 30);
        DateTime time8 = new DateTime(2022, 6, 26);
        public ExamController()
        {
            _exams = new List<Exam>
            {
              
                new Exam(1,"Riyaziyyat", time1),
                new Exam(2,"Azerbaycan dili",time2),
                new Exam(3,"Tarix",time3),
                new Exam(4,"Kimya",time4),
                new Exam(5,"Ingilis dili",time5),
                new Exam(6,"Cografiya",time6),
                new Exam(7,"Bialogiya",time7),
                new Exam(8,"Informatika",time8),
            };
        }
        public ActionResult Index()
        {

            ViewBag.Exam = _exams;

            return View();
        }
        public ActionResult Detail(int id)
        {
            Exam exm = _exams.Find(x => x.Id == id);
            ViewBag.Exam = exm;

            return View();
        }
    }
}

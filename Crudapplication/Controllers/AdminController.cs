using Crudapplication.Data;
using Crudapplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace Crudapplication.Controllers
{
    public class AdminController : Controller
    {
        private readonly MyDbContext conn;
        public AdminController()
        {
            conn = new MyDbContext();
        }
        public IActionResult Index()
        {
            var data = conn.Students.ToList();
                return View(data);
            
         
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Admin ad)
        {
            var data = conn.Admins.Where(u => u.AdminEmail == ad.AdminEmail && u.AdminPassword == ad.AdminPassword).FirstOrDefault();

            if (data == null)
            {
                return Unauthorized("Enter Correct Admin Id");
            }
            else
            {
                return RedirectToAction("Index", "Admin");
            }
        }
        public IActionResult HandleForm(Student ad,string action,int studentId)
        {
            if(action == "insert")
            {
                conn.Students.Add(ad);
                conn.SaveChanges();
                return RedirectToAction("Index", "Admin");
            }
else if(action == "update")
            {
                var sid = conn.Students.Find(studentId);
                if (sid != null)
                {
                    sid.studentname = ad.studentname;
                    sid.studentemail = ad.studentemail;
                    sid.studentpassword = ad.studentpassword;
                    conn.Students.Update(sid);
                    conn.SaveChanges();
                    return RedirectToAction("Index", "Admin");
                }
              
            }

else if(action == "delete")
            {
                var dlt = conn.Students.Find(studentId);
                if (dlt != null)
                {
                    conn.Students.Remove(dlt);
                    conn.SaveChanges();
                    return RedirectToAction("Index", "Admin");
                }
            }
            return RedirectToAction("Index","Admin");
        }

        public IActionResult Teacher()
        {
            var card = conn.Teachers.ToList();
            return View(card);
        }
        [HttpPost]
        public IActionResult Formclass(Teacher td,string taction,int tid)
        {
            if(taction == "tInsert")
            {
                conn.Teachers.Add(td);
                conn.SaveChanges();
                return RedirectToAction("Teacher", "Admin");
            }
            else if(taction == "update")
            {
                var upd = conn.Teachers.Find(tid);
                if(upd != null)
                {
                    upd.Teachername = td.Teachername;
                    upd.Teacheremail = td.Teacheremail;
                    upd.Teacherpassword = td.Teacherpassword;
                    upd.Teachersubject = td.Teachersubject;
                    conn.Teachers.Update(upd);
                    conn.SaveChanges();
                    return RedirectToAction("Teacher", "Admin");
                }
            }
            else if(taction == "delete")
            {
                var dlt = conn.Teachers.Find(tid);
                if(dlt != null)
                {
                    conn.Teachers.Remove(dlt);
                    conn.SaveChanges();
                    return RedirectToAction("Teacher", "Admin");
                }
            }

            return RedirectToAction("Teacher", "Admin");
        }

        
    }
}

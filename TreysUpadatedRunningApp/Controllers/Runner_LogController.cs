using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using TreysUpadatedRunningApp.Models;

namespace TreysUpadatedRunningApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class Runner_LogController : Controller
    {
        private RunnerDataContext db = new RunnerDataContext();

        // GET: Runner_Log
        public ActionResult Index()
        {
            var allRunners = db.Runner_Log.ToList();
            return View(allRunners);
        }

        // GET: Runner_Log/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Runner_Log runner_Log = db.Runner_Log.Find(id);
            if (runner_Log == null)
            {
                return HttpNotFound();
            }
            return View(runner_Log);
        }

        // GET: Runner_Log/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: Runner_Log/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Runner_LogId,Runner_Name,Run_Description,Miles_Ran,Total_Distance,Pushup_Count,Start_Date,Total_Time,Pullup_Count,Total_Count")] Runner_Log runner_Log)
        {
            if (ModelState.IsValid)
            {
                db.Runner_Log.Add(runner_Log);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(runner_Log);
        }

        // GET: Runner_Log/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Runner_Log runner_Log = db.Runner_Log.Find(id);
            if (runner_Log == null)
            {
                return HttpNotFound();
            }
            return View(runner_Log);
        }

        // POST: Runner_Log/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Runner_LogId,Runner_Name,Run_Description,Miles_Ran,Total_Distance,Pushup_Count,Start_Date,Total_Time,Pullup_Count,Total_Count")] Runner_Log runner_Log)
        {
            if (ModelState.IsValid)
            {
                db.Entry(runner_Log).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(runner_Log);
        }

        // GET: Runner_Log/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Runner_Log runner_Log = db.Runner_Log.Find(id);
            if (runner_Log == null)
            {
                return HttpNotFound();
            }
            return View(runner_Log);
        }

        // POST: Runner_Log/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Runner_Log runner_Log = db.Runner_Log.Find(id);
            db.Runner_Log.Remove(runner_Log);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

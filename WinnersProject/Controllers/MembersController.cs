using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WinnersProject.Models;

namespace WinnersProject.Controllers
{
    [Authorize]
    public class MembersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Members
        public async Task<ActionResult> Index()
        {
            return View(await db.Members.ToListAsync());
        }

        // GET: Members/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = await db.Members.Include(x=>x.Branch).FirstOrDefaultAsync(x=>x.Id ==id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // GET: Members/Create
        public ActionResult Create(string message)
        {
            if(message!=null)
            {
                ViewBag.Message = message;
            }
            ViewBag.Districts = db.Districts.ToList();
            return View(new Member());
        }

        [HttpGet]
        public ActionResult GetBranchList(int id)
        {
         //   db.Configuration.ProxyCreationEnabled = false;
            var branches = db.Branches.Where(x => x.DistrictId == id).Select(y=>new { y.Id,y.branchName}).ToList();
            return Json(branches, JsonRequestBehavior.AllowGet);
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Member member)
        {

            member.asBornAgain = convertCheckBox(member.asBornAgain);
            member.asBothFirstBornAgain = convertCheckBox(member.asBothFirstBornAgain);
            member.asFirstTimer = convertCheckBox(member.asFirstTimer);


            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                await db.SaveChangesAsync();
                return RedirectToAction("Create", "Members",new { message = "Member Added Successfully" });
            }
            ViewBag.Districts = db.Districts.ToList();
            return View(member);
        }

        // GET: Members/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = await db.Members.FindAsync(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,name,bustop,email,phoneNo,sex,occupation,servicePreference,wasInvited,cameOnYourOwn,whoInvitedYou,phoneNoOfInvitee,newMemberStaus,prayerRequest,officialName,signatureDate,districtName,dateRegistered")] Member member)
        {
            if (ModelState.IsValid)
            {
                db.Entry(member).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Member member = await db.Members.FindAsync(id);
            if (member == null)
            {
                return HttpNotFound();
            }
            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Member member = await db.Members.FindAsync(id);
            db.Members.Remove(member);
            await db.SaveChangesAsync();
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

        public string convertCheckBox(string status)
        {
            if (status == null)
            {
                return "No";
            }
            else
            {
                return "Yes";
            }
        }
    }
}

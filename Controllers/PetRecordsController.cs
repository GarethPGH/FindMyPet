using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FindMyPet.Models;

namespace FindMyPetv2.Controllers
{
    public class PetRecordsController : Controller
    {
        private FindMyPetContext db = new FindMyPetContext();

        // GET: PetRecords
        public async Task<ActionResult> Index()
        {
            var pets = db.Pets.Include(p => p.Owner);
            return View(await pets.ToListAsync());
        }

        // GET: PetRecords/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetRecord petRecord = await db.Pets.FindAsync(id);
            if (petRecord == null)
            {
                return HttpNotFound();
            }
            return View(petRecord);
        }

        // GET: PetRecords/Create
        public ActionResult Create()
        {
            ViewBag.OwnerID = new SelectList(db.Profiles, "OwnerID", "UserName");
            return View();
        }

        // POST: PetRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "PetID,PetName,Species,Breed,Description,ImageURL,SpecialNeeds,LocationLost,OwnerID")] PetRecord petRecord)
        {
            if (ModelState.IsValid)
            {
                db.Pets.Add(petRecord);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.OwnerID = new SelectList(db.Profiles, "OwnerID", "UserName", petRecord.OwnerID);
            return View(petRecord);
        }

        // GET: PetRecords/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetRecord petRecord = await db.Pets.FindAsync(id);
            if (petRecord == null)
            {
                return HttpNotFound();
            }
            ViewBag.OwnerID = new SelectList(db.Profiles, "OwnerID", "UserName", petRecord.OwnerID);
            return View(petRecord);
        }

        // POST: PetRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "PetID,PetName,Species,Breed,Description,ImageURL,SpecialNeeds,LocationLost,OwnerID")] PetRecord petRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(petRecord).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.OwnerID = new SelectList(db.Profiles, "OwnerID", "UserName", petRecord.OwnerID);
            return View(petRecord);
        }

        // GET: PetRecords/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PetRecord petRecord = await db.Pets.FindAsync(id);
            if (petRecord == null)
            {
                return HttpNotFound();
            }
            return View(petRecord);
        }

        // POST: PetRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PetRecord petRecord = await db.Pets.FindAsync(id);
            db.Pets.Remove(petRecord);
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
    }
}

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



namespace FindMyPet.Controllers
{
    public class OwnerProfileController : Controller
    {
        private FindMyPetContext db = new FindMyPetContext();

        // GET: api/OwnerProfile
        public async Task<ActionResult> MyPetProfile()
        {
            
                return View(db.Profiles.ToList());
                // return View(await db.Pets.ToList());
            
        }
        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerProfile Profile = await db.Profiles.FindAsync(id);
            if (Profile == null)
            {
                return HttpNotFound();
            }
            return View(Profile);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "OwnerID,UserName,Pets")] OwnerProfile Profile)
        {
            if (ModelState.IsValid)
            {
                db.Profiles.Add(Profile);
                await db.SaveChangesAsync();
                return RedirectToAction("MyPetProfile");
            }

            return View(Profile);
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerProfile Profile = await db.Profiles.FindAsync(id);
            if (Profile == null)
            {
                return HttpNotFound();
            }
            return View(Profile);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "OwnerID,UserName,Pets")] OwnerProfile Profile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Profile).State = System.Data.Entity.EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("MyPetProfile");
            }
            return View(Profile);
        }

        // GET: Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnerProfile Profile = await db.Profiles.FindAsync(id);
            if (Profile == null)
            {
                return HttpNotFound();
            }
            return View(Profile);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            OwnerProfile Profile = await db.Profiles.FindAsync(id);
            db.Profiles.Remove(Profile);
            await db.SaveChangesAsync();
            return RedirectToAction("MyPetProfile");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesApp.WebClient.Models;
using NotesApp.WebClient.Services;

namespace NotesApp.WebClient.Controllers
{
    public class NotesController : Controller
    {
        // GET: NotesController
        public async Task<ActionResult> Index()
        {
            var notes = await BackendService.Instance.Get<List<NoteViewModel>>("api/notes");
            return View(notes);
        }

        // GET: NotesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NotesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(NoteCreateModel model)
        {
            var note = new Note
            {
                Title = model.Title,
                Description = model.Description,
                Content = model.Content,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow,
                UserId = new Guid("5ca7bee5-c362-4138-28e0-08d868cc3b04")
            };

            var response = await BackendService.Instance.PostHttpResponse(note,"api/notes");
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        // GET: NotesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NotesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NotesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NotesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

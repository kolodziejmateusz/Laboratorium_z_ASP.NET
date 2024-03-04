﻿using Laboratorium_8.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_8.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public IActionResult Index()
        {
            var albums = _albumService.FindAll();
            return View(albums);
        }

        private void InitializeRecordLabels(Album model)
        {
            model.RecordLabels = _albumService
                .FindAllOrganizations()
                .Select(o => new SelectListItem { Value = o.Id.ToString(), Text = o.Name })
                .ToList();
        }


        [HttpGet]
        public IActionResult Create()
        {
            Album model = new Album();
            InitializeRecordLabels(model);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumService.Add(album);
                return RedirectToAction("Index");
            }
            else
            {
                InitializeRecordLabels(album);
                return View(album);
            }
        }

        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            _albumService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateApi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateApi(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumService.Add(album);
                return RedirectToAction(nameof(Index));
            }
            return View(album);
        }
       
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var album = _albumService.FindById(id);
            if (album == null)
            {
                return NotFound();
            }
            InitializeRecordLabels(album);
            return View(album);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumService.Edit(album);
                return RedirectToAction("Index");
            }
            InitializeRecordLabels(album);
            return View(album);
        }
        [HttpGet]
        public IActionResult EditApi(int id)
        {
            var album = _albumService.FindById(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditApi(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumService.Edit(album);
                return RedirectToAction("Index");
            }
            return View(album);
        }

        public IActionResult Details(int id)
        {
            var album = _albumService.FindById(id);
            if (album == null)
            {
                return NotFound();
            }
            return View(album);
        }
    }
}

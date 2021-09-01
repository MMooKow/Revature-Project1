﻿using DL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly IReviewRepo _reviewrepo;

        public ReviewsController(IReviewRepo reviewRepo)
        {
            _reviewrepo = reviewRepo;
        }
        // GET: ReviewsController
        public ActionResult Index()
        {
            var viewModel = _reviewrepo.GetAllReviews().Select(r => new Reviews
            {
                Rating = r.Rating,
                Content = r.Content,
                RestaurantId = r.RestaurantId
            }) ;

            return View(viewModel);
        }

        // GET: ReviewsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReviewsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReviewsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ReviewsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReviewsController/Edit/5
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

        // GET: ReviewsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReviewsController/Delete/5
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

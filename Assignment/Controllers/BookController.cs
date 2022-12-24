﻿using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class BookController : Controller
    {
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        [Authorize(Roles = "StoreOwner")]
        public IActionResult Index()
        {
            return View(context.Books.ToList());
        }


        [Authorize(Roles = "StoreOwner")]
        public IActionResult Delete(int id)
        {
            var book = context.Books.Find(id);
            context.Books.Remove(book);
            context.SaveChanges();
            TempData["Message"] = "Delete book successfully !";
            return RedirectToAction("Index");
        }

        //xem thông tin theo id
        
        public IActionResult Detail(int id)
        {
            var book = context.Books
                .Include(c => c.Author)
                .Include(c => c.Category)
                .FirstOrDefault(c => c.Id == id);
            return View(book);
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Authors = context.Authors.ToList();
            ViewBag.Categories = context.Categories.ToList();

            return View();
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                TempData["Message"] = "Add new book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Authors = context.Authors.ToList();
            ViewBag.Categories = context.Categories.ToList();
            var book = context.Books.Find(id);
            return View(book);
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Update(book);
                context.SaveChanges();
                TempData["Message"] = "Edit book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        public IActionResult Store()
        {
            return View(context.Books.ToList());
        }

       
    }
}

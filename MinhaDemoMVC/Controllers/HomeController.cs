﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;

namespace MinhaDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        //[Route("")]
        //[Route("pagina-inicial")]
        //[Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(/*int id, Guid categoria*/)
        {
            
            var filme = new Filme
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };

            return RedirectToAction("Privacy", filme);
            
            //return View();
        }

        //[Route("privacidade")]
        //[Route("politica-de-privacidade")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy(Filme filme)
        {
            //return Json("{'nome:'thiago}");

            //var fileBytes = System.IO.File.ReadAllBytes(@"D:\arquivo.txt");
            //var fileName = "novo_arquivo.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            //return Content("Qualquer coisa");

            
            if (ModelState.IsValid)
            {

            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //[Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

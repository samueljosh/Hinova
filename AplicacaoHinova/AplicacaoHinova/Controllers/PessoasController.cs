using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using AplicacaoHinova.Models;

namespace AplicacaoHinova.Controllers
{
    public class PessoasController : Controller
    {
        private AplicacaoHinovaContext db = new AplicacaoHinovaContext();



        // GET: Pessoas/Create
        public ActionResult Indicar()
        {
            return View();
        }


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "CodigoAssociacao,DataCriacao,CpfAssociado,EmailAssociado,NomeAssociado,TelefoneAssociado,PlacaVeiculoAssociado,NomeAmigo,TelefoneAmigo,EmailAmigo,Observacao")] Pessoa pessoa)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://localhost:64189/api/student");

        //        HTTP POST
        //        var postTask = client.PostAsJsonAsync<Pessoa>("Pessoa", pessoa);
        //        postTask.Wait();

        //        var result = postTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            return RedirectToAction("Create");
        //        }
        //    }

        //    ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

        //    return View(pessoa);
        //}


    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AplicacaoHinova.Models;
using Newtonsoft.Json;
namespace AplicacaoHinova.Controllers
{
    public class OficinasController : Controller
    {
        private AplicacaoHinovaContext db = new AplicacaoHinovaContext();

        // GET: Oficinas

        public async Task<ActionResult> Index()
        {
            string urlConexao = "http://app.hinovamobile.com.br/ProvaConhecimentoWebApi";


            using (var requisicaoWebservice = new HttpClient())
            {
                requisicaoWebservice.BaseAddress = new Uri(urlConexao);
                requisicaoWebservice.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await requisicaoWebservice.GetAsync("ProvaConhecimentoWebApi/Api/Oficina?codigoAssociacao=601");
                if (Res.IsSuccessStatusCode)
                {
                    var requisicaoWebserviceResultado = Res.Content.ReadAsStringAsync().Result;

                    var oficinaInformacoes = JsonConvert.DeserializeObject<RootObject>(requisicaoWebserviceResultado);

                    return View(oficinaInformacoes.ListaOficinas.ToList());
                }

                return View("Não fui possivel conectar com o WebService");

            }

        }

        public async Task<ActionResult> Detalhes(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {


                string urlConexao = "http://app.hinovamobile.com.br/ProvaConhecimentoWebApi";
                using (var requisicaoWebservice = new HttpClient())
                {
                    requisicaoWebservice.BaseAddress = new Uri(urlConexao);
                    requisicaoWebservice.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res = await requisicaoWebservice.GetAsync("ProvaConhecimentoWebApi/Api/Oficina?codigoAssociacao=601");
                    if (Res.IsSuccessStatusCode)
                    {
                        var requisicaoWebserviceResultado = Res.Content.ReadAsStringAsync().Result;

                        var oficinaInformacoes = JsonConvert.DeserializeObject<RootObject>(requisicaoWebserviceResultado);

                        return View(oficinaInformacoes.ListaOficinas.Find(x => x.Id == id));
                    }

                    return View();

                }
            }
        }
    }
}
     
    


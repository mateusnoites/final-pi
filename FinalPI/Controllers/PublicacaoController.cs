using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalPI.Context;
using FinalPI.Models;
using System.IO;
using System.Text;
using System.Data.Entity;

namespace FinalPI.Controllers
{
    public class PublicacaoController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Publicacao
        public ActionResult Index()
        {
            return View(context.Publicacoes.OrderBy(c => c.Id));
        }

        // GET: Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Publicacao publicacao, HttpPostedFileBase arquivo = null)
        {
            try
            {
                if (ModelState.IsValid && (publicacao.Conteudo != null || arquivo != null ))
                {
                    if (arquivo != null)
                    {
                        byte[] bytesDaImagem = new byte[arquivo.ContentLength];
                        arquivo.InputStream.Read(bytesDaImagem, 0, arquivo.ContentLength);
                        publicacao.TipoArquivo = arquivo.ContentType;
                        publicacao.Imagem = Convert.ToBase64String(bytesDaImagem);
                    }
                    context.Publicacoes.Add(publicacao);
                    context.SaveChanges();
                    return RedirectToAction("../Publicacao/Index");
                }
                else
                {
                    return View(publicacao);
                }
            }
            catch
            {

                return View(publicacao);
            }
        }

        public FileContentResult GetImagem(long id)
        {
            Publicacao publicacao = context.Publicacoes.Where(p => p.Id == id).First();
            if (publicacao != null)
            {
                if (!string.IsNullOrEmpty(publicacao.Imagem))
                {
                    byte[] bytesDaImagem = Convert.FromBase64String(publicacao.Imagem);
                    return File(bytesDaImagem, publicacao.TipoArquivo);
                }
                else return null;
            }
            return null;
        }
    }
}
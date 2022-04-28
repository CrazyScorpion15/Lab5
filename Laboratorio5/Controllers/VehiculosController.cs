using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio5.Helpers;
using Laboratorio5.Models;
using Laboratorio5.Arbol2_3;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace Laboratorio5.Controllers
{
    public class VehiculosController : Controller
    {
        // GET: VehiculosController
        public ActionResult Index(BTree<VehiculosModel> lista)
        {
            return View(Data.Instance.Arbol);
        }


        [HttpGet]
        public IActionResult Index(List<VehiculosModel> Lista = null)
        {
            Lista = Lista == null ? new List<VehiculosModel>() : Lista;
            return View(Lista);
        }

        [HttpPost]
        public IActionResult Index(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }

            var Lista = this.GetList(file.FileName);

            return Index(Lista);
        }

        private List<VehiculosModel> GetList(string fileName)
        {
            List<VehiculosModel> Lista = new List<VehiculosModel>();
            #region Read CSV
            var path = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\files"}" + "\\" + fileName;
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    var lista = csv.GetRecord<VehiculosModel>();
                    Data.Instance.ListaVehi.Add(lista);
                    Data.Instance.Arbol.Agregar(lista, lista.Comparer);
                }
            }
            #endregion
            return Lista;
        }

        // GET: VehiculosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VehiculosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VehiculosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var Informacion = VehiculosModel.Save(new VehiculosModel
                {
                    Placas = Convert.ToInt32(collection["Placas"]),
                    Color = collection["Color"],
                    Propietario = collection["Propietario"],
                    Longitud = Convert.ToDouble(collection["Longitud"]),
                    Latitud = Convert.ToDouble(collection["Latitud"])
                });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VehiculosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VehiculosController/Edit/5
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

        // GET: VehiculosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VehiculosController/Delete/5
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

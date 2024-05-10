using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSPostgresEC2.Models;
using MvcCoreAWSPostgresEC2.Repositories;

namespace MvcCoreAWSPostgresEC2.Controllers
{
    public class DepartamentosController : Controller
    {
        private DepartamentosRepository repo;
        public DepartamentosController(DepartamentosRepository repo)
        {
            this.repo = repo;
        }
        public async Task<ActionResult> Index()
        {
            List<Departamento> deps = await this.repo.GetDepartamentosAsync();
            return View(deps);
        }

        public async Task<ActionResult> Details(int id)
        {
            Departamento dep = await this.repo.FindDepartamentoAsync(id);
            return View(dep);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Departamento dep)
        {
            await this.repo
                .InsertDepartamentoAsync(dep.IdDepartamento,dep.Nombre,dep.Localidad);
            return RedirectToAction("Index");
        }
    }
}

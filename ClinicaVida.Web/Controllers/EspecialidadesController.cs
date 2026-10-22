using ClinicaVida.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicaVida.Web.Controllers;

public class EspecialidadesController : Controller
{
    public IActionResult Index()
    {
        var contagem = new Dictionary<int, int>();

        foreach (var e in ClinicaEmMemoria.Especialidades)
        {
            contagem[e.Id] = ClinicaEmMemoria.Medicos.Count(m => m.EspecialidadeId == e.Id);
        }

        ViewBag.MedicosPorEspecialidade = contagem;
        return View(ClinicaEmMemoria.Especialidades);   // @model IEnumerable<Especialidade>
    }

    public IActionResult Details(int id)
    {
        var especialidade = ClinicaEmMemoria.Especialidades.FirstOrDefault(e => e.Id == id);
        if (especialidade is null) return NotFound();

        return View(especialidade);                     // @model Especialidade
    }
}

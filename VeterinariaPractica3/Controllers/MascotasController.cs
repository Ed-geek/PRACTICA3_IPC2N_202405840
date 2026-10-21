using Microsoft.AspNetCore.Mvc;
using VeterinariaPractica3.Models;
using VeterinariaPractica3.Models.ViewModels;
using VeterinariaPractica3.Services;
using VeterinariaPractica3.Utils;

namespace VeterinariaPractica3.Controllers;

public class MascotasController : Controller
{
    private readonly MascotaService _service;

    // Inyección de dependencias
    public MascotasController(MascotaService service) => _service = service;

    public IActionResult Index() => View(_service.ObtenerTodas());

    [HttpGet]
    public IActionResult Create() => View(new MascotaFormViewModel());

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(MascotaFormViewModel vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var mascota = ConstruirMascota(vm);
        _service.Agregar(mascota);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Details(int id)
    {
        var m = _service.ObtenerPorId(id);
        if (m == null) return NotFound();
        return View(m);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var m = _service.ObtenerPorId(id);
        if (m == null) return NotFound();

        return View(new MascotaFormViewModel
        {
            Id = m.Id,
            Tipo = m.Tipo,
            Nombre = m.Nombre,
            Raza = m.Raza,
            Edad = m.Edad,
            Peso = m.Peso
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(MascotaFormViewModel vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var original = _service.ObtenerPorId(vm.Id);
        if (original == null) return NotFound();

        original.Nombre = vm.Nombre;
        original.Raza = vm.Raza;
        original.Edad = vm.Edad;
        original.Peso = vm.Peso;

        _service.Actualizar(original);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var m = _service.ObtenerPorId(id);
        if (m == null) return NotFound();
        return View(m);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        _service.Eliminar(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CambiarEstado(int id)
    {
        _service.CambiarEstado(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CalcularDosis(int id, double dosisPorKilogramo)
    {
        var m = _service.ObtenerPorId(id);
        if (m == null) return NotFound();

        // 👇 Convertimos a string para que TempData no falle
        TempData["DosisCalculada"] = m.CalcularDosis(dosisPorKilogramo).ToString("0.00");
        TempData["DosisPorKg"] = dosisPorKilogramo.ToString("0.00");
        
        return RedirectToAction(nameof(Details), new { id });
    }

    private static Mascota ConstruirMascota(MascotaFormViewModel vm)
    {
        if (!TipoMascota.EsValido(vm.Tipo))
            throw new ArgumentException($"Tipo de mascota inválido: {vm.Tipo}");

        return vm.Tipo switch
        {
            TipoMascota.Perro   => new Perro(vm.Nombre, vm.Raza, vm.Edad, vm.Peso),
            TipoMascota.Gato    => new Gato(vm.Nombre, vm.Raza, vm.Edad, vm.Peso),
            TipoMascota.Ave     => new Ave(vm.Nombre, vm.Raza, vm.Edad, vm.Peso),
            TipoMascota.Tortuga => new Tortuga(vm.Nombre, vm.Raza, vm.Edad, vm.Peso),
            _ => throw new ArgumentException("Tipo inválido")
        };
    }
}
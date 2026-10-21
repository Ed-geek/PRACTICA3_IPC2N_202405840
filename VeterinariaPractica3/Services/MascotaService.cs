using VeterinariaPractica3.Models;

namespace VeterinariaPractica3.Services;

public class MascotaService
{
    
    private readonly List<Mascota> _lista = new();
    private int _siguienteId = 1;

    public List<Mascota> ObtenerTodas() => _lista;

    public Mascota? ObtenerPorId(int id) => _lista.FirstOrDefault(m => m.Id == id);

    public void Agregar(Mascota mascota)
    {
        mascota.Id = _siguienteId++;
        _lista.Add(mascota);
    }

    public bool Actualizar(Mascota mascota)
    {
        var index = _lista.FindIndex(m => m.Id == mascota.Id);
        if (index == -1) return false;
        
        _lista[index] = mascota;
        return true;
    }

    public bool Eliminar(int id)
    {
        var mascota = ObtenerPorId(id);
        if (mascota == null) return false;
        
        _lista.Remove(mascota);
        return true;
    }

    public bool CambiarEstado(int id)
    {
        var mascota = ObtenerPorId(id);
        if (mascota == null) return false;
        
        mascota.CambiarEstado();
        return true;
    }
}
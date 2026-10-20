namespace VeterinariaPractica3.Models.ViewModels;

public class MascotaFormViewModel
{
    public int Id { get; set; }
    public string Tipo { get; set; } = "Perro";
    public string Nombre { get; set; } = string.Empty;
    public string Raza { get; set; } = string.Empty;
    public int Edad { get; set; }
    public double Peso { get; set; }
}
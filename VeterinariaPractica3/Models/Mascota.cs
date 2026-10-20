namespace VeterinariaPractica3.Models;

public abstract class Mascota
{
    // atributos privados
    private int _id;
    private string _nombre = string.Empty;
    private string _raza = string.Empty;
    private int _edad;
    private double _peso;
    private bool _enferma;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Nombre
    {
        get => _nombre;
        set => _nombre = string.IsNullOrWhiteSpace(value) ? "Sin nombre" : value.Trim();
    }

    public string Raza
    {
        get => _raza;
        set => _raza = string.IsNullOrWhiteSpace(value) ? "Mestizo" : value.Trim();
    }

    public int Edad
    {
        get => _edad;
        set => _edad = value < 0 ? 0 : value;
    }

    public double Peso
    {
        get => _peso;
        set => _peso = value < 0 ? 0 : value;
    }

    public bool Enferma
    {
        get => _enferma;
        private set => _enferma = value;
    }

    protected Mascota(string nombre, string raza, int edad, double peso)
    {
        Nombre = nombre;
        Raza = raza;
        Edad = edad;
        Peso = peso;
        _enferma = false; // Por defecto sanas
    }

    // Abstracción y Polimorfismo
    public abstract string Tipo { get; }
    public abstract double CalcularDosis(double dosisPorKilogramo);

    public void CambiarEstado() => _enferma = !_enferma;
}
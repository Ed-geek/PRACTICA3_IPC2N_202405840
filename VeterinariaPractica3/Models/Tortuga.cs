namespace VeterinariaPractica3.Models;

public class Tortuga : Mascota
{
    public Tortuga(string nombre, string raza, int edad, double peso)
        : base(nombre, raza, edad, peso) { }

    public override string Tipo => "Tortuga";

    // Factor: 80 %
    public override double CalcularDosis(double dosisPorKilogramo)
        => Peso * dosisPorKilogramo * 0.80;
}
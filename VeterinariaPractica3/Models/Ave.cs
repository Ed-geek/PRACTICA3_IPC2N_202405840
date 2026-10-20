namespace VeterinariaPractica3.Models;

public class Ave : Mascota
{
    public Ave(string nombre, string raza, int edad, double peso)
        : base(nombre, raza, edad, peso) { }

    public override string Tipo => "Ave";

    // Factor: 50 %
    public override double CalcularDosis(double dosisPorKilogramo)
        => Peso * dosisPorKilogramo * 0.50;
}
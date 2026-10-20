namespace VeterinariaPractica3.Models;

public class Perro : Mascota
{
    public Perro(string nombre, string raza, int edad, double peso)
        : base(nombre, raza, edad, peso) { }

    public override string Tipo => "Perro";

    // Factor: 100 %
    public override double CalcularDosis(double dosisPorKilogramo)
        => Peso * dosisPorKilogramo * 1.00;
}
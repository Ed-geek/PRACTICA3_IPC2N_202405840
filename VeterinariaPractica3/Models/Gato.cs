namespace VeterinariaPractica3.Models;

public class Gato : Mascota
{
    public Gato(string nombre, string raza, int edad, double peso)
        : base(nombre, raza, edad, peso) { }

    public override string Tipo => "Gato";

    // Factor: 90 %
    public override double CalcularDosis(double dosisPorKilogramo)
        => Peso * dosisPorKilogramo * 0.90;
}
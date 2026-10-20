namespace VeterinariaPractica3.Utils;

public static class TipoMascota
{
    public const string Perro   = "Perro";
    public const string Gato    = "Gato";
    public const string Ave     = "Ave";
    public const string Tortuga = "Tortuga";

    public static bool EsValido(string tipo)
        => tipo is Perro or Gato or Ave or Tortuga;
}
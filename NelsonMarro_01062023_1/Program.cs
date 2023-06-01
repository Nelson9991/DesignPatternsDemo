var nelson = new Persona("Nelson Marro", 24, "Cubana", "1757078579", "10004", "Quito - Ave 6 de diciembre");

Console.WriteLine(nelson);
Console.WriteLine("Datos de ciudadania");
Console.WriteLine(nelson.ObtenerDatosCiudadano());

if (nelson.VarificarMayoriaEdad())
{
  Console.WriteLine($"{nelson.Nombre} es mayor de Edad");
}
else
{
  Console.WriteLine($"{nelson.Nombre} es menor de Edad");
}

public class Persona : ICiudadano
{
  public string Nombre;
  public int Edad;
  public string Nacionalidad;

  public Persona(string nombre, int edad, string nacionalidad, string cedula,
    string numSeguroSocial, string direccion)
  {
    Nombre = nombre;
    Edad = edad;
    Nacionalidad = nacionalidad;
    Cedula = cedula;
    NumSeguroSocial = numSeguroSocial;
    Direccion = direccion;
  }

  public string Cedula { get; set; }
  public string NumSeguroSocial { get; set; }
  public string Direccion { get; set; }

  public string ObtenerDatosCiudadano()
  {
    return $"Cedula: {Cedula} \nSeguro Social: {NumSeguroSocial} \nDireccion: {Direccion} \n";
  }

  public override string ToString()
  {
    return $"Nombre: {Nombre} \nEdad: {Edad} \nNacionalidad: {Nacionalidad} \n";
  }

  public bool VarificarMayoriaEdad()
  {
    return Edad >= 18;
  }
}

public interface ICiudadano
{
  public string Cedula { get; set; }
  public string NumSeguroSocial { get; set; }
  public string Direccion { get; set; }

  public string ObtenerDatosCiudadano();
  public bool VarificarMayoriaEdad();
}
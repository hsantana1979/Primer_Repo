

Console.WriteLine("Digite su Nombre");
string nombreUsuario = Console.ReadLine();

Console.WriteLine("Digite su Edad");
string edadUsuario = Console.ReadLine();

int edad = int.Parse(edadUsuario);

Saludar(nombreUsuario);

if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}

static void Saludar(string nombre)
{
    Console.WriteLine("Hola "+ nombre);
}
// See https://aka.ms/new-console-template for more information
Console.Clear();
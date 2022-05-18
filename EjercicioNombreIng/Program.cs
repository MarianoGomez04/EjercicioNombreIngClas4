Console.Clear();

// Pedir nombre//
Console.WriteLine("Hola! Ingresa un nombre por favor:");
//Variables//
var NombreIngresado = Console.ReadLine();

//Saludar//
Console.WriteLine($"Hola {NombreIngresado}!");

//Preguntar si quiere continuar//
Console.WriteLine("Quiere continuar? S/N");
//variable opcion//
var opcion = Console.ReadLine();


while (opcion.ToUpper() == "S")
{
    //Borrar lineas//
    Console.Clear();

    //Pedir nombre//
    Console.Write("Hola! Ingresa un nombre por favor:");
    NombreIngresado = Console.ReadLine();

    //Saludar//
    Console.WriteLine($"Hola {NombreIngresado}!");

    Console.WriteLine("Quiere continuar? S/N");

    opcion = Console.ReadLine();
}

if (opcion.ToUpper() == "N")
{
    Console.WriteLine("El programa ha finalizado.");

}
else
{
    Console.WriteLine("Opcion ingresada no valida. El programa ha finalizado.");
}

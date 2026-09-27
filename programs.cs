string nombre;
string apellido;
int edad;
double estatura;

Console.WriteLine("Ingrese su nombre: ");
nombre = Console.ReadLine() ?? "";
Console.WriteLine("Ingrese su apellido: ");
apellido = Console.ReadLine() ?? "";
Console.WriteLine("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ingrese su estatura: ");
estatura = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Su nombre es: " + nombre);
Console.WriteLine("Su apellido es: " + apellido);  
Console.WriteLine("Su edad es: " + edad);
Console.WriteLine("Su estatura es: " + estatura);

Console.WriteLine("Hola, mi nombre es: " + nombre    + " " + apellido + " y tengo " + edad + " años y mido " + estatura + " metros.");
Console.ReadKey();

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int cedula = 0;
string nombre = "";
int tipoempleado = 0;
int cantidadhoras = 0;
int preciohora = 0;


do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Bienvendido al programa de aumentos salariales de Tienda la Baratica SA");
    Console.WriteLine("Digite su numero de cedula (sin guiones ni espacios): ");
    cedula = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite su nombre completo: ");
    nombre = Console.ReadLine();
    Console.WriteLine("Digite su tipo de empleado: (1-Operario 2-Tecnico 3-Profesional)");
    if (tipoempleado == 1)
	{

    }
    else if (tipoempleado == 2)
    {

    }
    else if (tipoempleado == 3)
    {

    }
} while (tipoempleado <1 || tipoempleado > 3);
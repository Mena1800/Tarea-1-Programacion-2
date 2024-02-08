// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Collections;
using System.Runtime.Intrinsics.Arm;

string cedula = "";
string nombre = "";
int tipoempleado = 0;
double cantidadhoras = 0;
double preciohora = 0;
double salarioordi = 0;
double aumento = 0;
double salariobruto = 0;
double salarioneto = 0;
double deducciones = 0;
int cantoper = 0;
int canttec = 0;
int cantprof = 0;
double totalacuop = 0;
double totalacutec = 0;
double totalacuprof = 0;
double promsalnetope = 0;
double promsalnettec = 0;
double promsalnetprof = 0;
int respuesta = 0;
//int 
ArrayList names = new ArrayList();
ArrayList id = new ArrayList();
ArrayList type = new ArrayList();

do
{

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("Bienvendido al programa de aumentos salariales de Tienda la Baratica SA");
    Console.WriteLine("Digite su numero de cedula (sin guiones ni espacios): ");
    cedula = Console.ReadLine();
    id.Add(cedula);
    Console.WriteLine("Digite su nombre completo: ");
    nombre = Console.ReadLine();
    names.Add(nombre);
    Console.WriteLine("Digite su tipo de empleado: (1-Operario 2-Tecnico 3-Profesional)");
    tipoempleado = int.Parse(Console.ReadLine());
    type.Add(tipoempleado);
    if (tipoempleado == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Digite la cantidad de horas laboradas: ");
        cantidadhoras = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el precio de la hora laborada: ");
        preciohora = int.Parse(Console.ReadLine());
        salarioordi = cantidadhoras * preciohora;
        aumento = salarioordi * 0.15;
        salariobruto = salarioordi + aumento;
        deducciones = salariobruto * 0.0917;
        salarioneto = salariobruto - deducciones;
        Console.WriteLine("Su numero de cedula es {0}, su nombre es {1}, su tipo de empleado es {2}, su salario por hora es {3}, la cantidad de horas laboradas son de {4}, su salario ordinario es de {5}, el aumento fue de {6}, el salario bruto es de {7}, la deducion de la caja fue de {8} y el salario neto fue de {9}", cedula, nombre, tipoempleado, preciohora, cantidadhoras, salarioordi, aumento, salariobruto, deducciones, salarioneto);
        cantoper = cantoper + 1;
        totalacuop = totalacuop + salarioneto;
        Console.WriteLine("Desea agregar otro user? 1:Si / 2: No");
        respuesta = int.Parse(Console.ReadLine());


    }
    else if (tipoempleado == 2)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Digite la cantidad de horas laboradas: ");
        cantidadhoras = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el precio de la hora laborada: ");
        preciohora = int.Parse(Console.ReadLine());
        salarioordi = cantidadhoras * preciohora;
        aumento = salarioordi * 0.10;
        salariobruto = salarioordi + aumento;
        deducciones = salariobruto * 0.0917;
        salarioneto = salariobruto - deducciones;
        Console.WriteLine("Su numero de cedula es {0}, su nombre es {1}, su tipo de empleado es {2}, su salario por hora es {3}, la cantidad de horas laboradas son de {4}, su salario ordinario es de {5}, el aumento fue de {6}, el salario bruto es de {7}, la deducion de la caja fue de {8} y el salario neto fue de {9}", cedula, nombre, tipoempleado, preciohora, cantidadhoras, salarioordi, aumento, salariobruto, deducciones, salarioneto);
        canttec = canttec + 1;
        Console.WriteLine("Desea agregar otro user? 1:Si / 2: No");
        respuesta = int.Parse(Console.ReadLine());


    }
    else if (tipoempleado == 3)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Digite la cantidad de horas laboradas: ");
        cantidadhoras = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite el precio de la hora laborada: ");
        preciohora = int.Parse(Console.ReadLine());
        salarioordi = cantidadhoras * preciohora;
        aumento = salarioordi * 0.05;
        salariobruto = salarioordi + aumento;
        deducciones = salariobruto * 0.0917;
        salarioneto = salariobruto - deducciones;
        Console.WriteLine("Su numero de cedula es {0}, su nombre es {1}, su tipo de empleado es {2}, su salario por hora es {3}, la cantidad de horas laboradas son de {4}, su salario ordinario es de {5}, el aumento fue de {6}, el salario bruto es de {7}, la deducion de la caja fue de {8} y el salario neto fue de {9}", cedula, nombre, tipoempleado, preciohora, cantidadhoras, salarioordi, aumento, salariobruto, deducciones, salarioneto);
        cantprof = cantprof + 1;
        Console.WriteLine("Desea agregar otro user? 1:Si / 2: No");
        respuesta = int.Parse(Console.ReadLine());

    }
} while (tipoempleado < 1 || tipoempleado > 3 || respuesta == 1);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("La cantidad de empleados de tipo operarios fue de {0}", cantoper);
Console.WriteLine("El acumulado del salario neto de los operarios consultados es de {0}", totalacuop);
Console.WriteLine("El promedio del salario neto de los operarios es de {0}", promsalnetope = totalacuop/cantoper);
Console.WriteLine("-------------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("La cantidad de empleados de tipo tecnicos fue de {0}", canttec);
Console.WriteLine("El acumulado del salario neto de los tecnicos consultados es de {0}", totalacutec);
Console.WriteLine("El promedio del salario neto de los Tecnicos es de {0}", promsalnettec = totalacutec / canttec);
Console.WriteLine("-------------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("La cantidad de empleados de tipo profesionales fue de {0}", cantprof);
Console.WriteLine("El acumulado del salario neto de los profesionales consultados es de {0}", totalacuprof);
Console.WriteLine("El promedio del salario neto de los profesionales es de {0}", promsalnetprof = totalacuprof / cantprof);
Console.WriteLine("-------------------------------------------------------------------------------------------------");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Estos fueron los nombres de los usuarios consultados junto con su cedula y tipo de empleado: ");
Console.WriteLine("");
Console.WriteLine("");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"Nombre: {names[i]}, numero de cedula: {id[i]}, tipo de empleado: {type[i]}");
    Console.WriteLine("");
}

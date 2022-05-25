// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("CALCULADORA VERSION 1");
short start = 0;
do
{
    
    Console.WriteLine("Seleccione la operación que desea realizar: ");
    Console.WriteLine("1.Suma");
    Console.WriteLine("2.Resta");
    Console.WriteLine("3.Multiplicacion");
    Console.WriteLine("4.Division");
    int operador;
    operador = Int32.Parse(Console.ReadLine());
    int a,b;
    Console.WriteLine("Ingrese el operando a: ");
    a = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el operando b: ");
    b = Int32.Parse(Console.ReadLine());

    int resultado;
    switch (operador)
    {
        case 1:
            resultado = Suma(a,b);
            Console.WriteLine("El resultado de a+b es " + resultado);
            break;
        case 2:
            resultado = Resta(a,b);
            Console.WriteLine("El resultado de a-b es " + resultado);
            break;
        case 3:
            resultado = Multiplicacion(a,b);
            Console.WriteLine("El resultado de a*b es " + resultado);
            break;
        case 4:
            resultado = Division(a,b);
            Console.WriteLine("El resultado de a/b es " + resultado);
            break;
    }
    Console.WriteLine("Desea realizar otra operacion? Seleccione 0.");
    start = short.Parse(Console.ReadLine());
} while (start==0);


int Suma(int a, int b) {
    return a+b;
}
int Resta(int a, int b) {
    return a-b;
}
int Multiplicacion(int a, int b) {
    return a*b;
}
int Division(int a, int b) {
    while (b == 0)
    {
        Console.WriteLine("Ingrese el operando b distinto de cero: ");
        b = Int32.Parse(Console.ReadLine());
    }
    return a/b;
}


Console.WriteLine("CALCULADORA VERSION 2");
Console.WriteLine("Ingrese un numero: ");
double num;
num = double.Parse(Console.ReadLine());
Console.WriteLine("Valor absoluto: " + Math.Abs(num));
Console.WriteLine("El cuadrado: " + Math.Pow(num,2));
Console.WriteLine("La raiz cuadrada: " + Math.Sqrt(num));
Console.WriteLine("El seno: " + Math.Sin(num));
Console.WriteLine("El coseno: " + Math.Cos(num));
Console.WriteLine("La parte entera: " + Convert.ToInt32(num));

double x,y;
Console.WriteLine("***Conozcamos el maximo y minimo entre dos numeros***");
Console.WriteLine("Ingrese el primer numero: ");
x = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
y = double.Parse(Console.ReadLine());
Console.WriteLine("El máximo es " + Math.Max(x,y));
Console.WriteLine("El minimo es " + Math.Min(x,y));


Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese una cadena: ");
string cadena = Console.ReadLine();

Console.WriteLine("La cadena ingresada fue: " + cadena);

Console.WriteLine("Ingrese la cantidad de caracteres a imprimir: ");
int caracteres = Int32.Parse(Console.ReadLine());
Console.WriteLine("La subcadena es: " + cadena.Substring(caracteres));
Console.WriteLine("La cadena contiene " + cadena.Length + " caracteres");

string segCadena;
do
{
    Console.WriteLine("Ingrese una cadena distinta a concatenar: ");
    segCadena = Console.ReadLine();
} while (cadena.CompareTo(segCadena) == 0);


Console.WriteLine("Cadena final: " + String.Concat(cadena, segCadena));

Console.WriteLine("Ingrese la cantidad de caracteres de la subcadena: ");
int caracteres = Int32.Parse(Console.ReadLine());
Console.WriteLine("La subcadena es: " + cadena.Substring(caracteres));

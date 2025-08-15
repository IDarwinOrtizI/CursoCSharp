// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string miCadena = "Hola, esto es una cadena";
Console.WriteLine(miCadena);

miCadena = string.Empty;
Console.WriteLine(miCadena);

/*
Console.WriteLine("Digite su nombre por consola.. ");
string tuNombre = Console.ReadLine()!;

Console.WriteLine("Digite su edad: ");
string entradaEdad = Console.ReadLine()!;
int edad = Convert.ToInt32(entradaEdad);
Console.WriteLine("Tu edad es: " + edad);

Console.WriteLine("Tu nombre es: " + tuNombre + " y tu edad es: " + edad);
*/

string nombre = "Sebastian";
string apellido = "Ortiz";
Console.WriteLine("Tu nombre es: " + nombre + " " + apellido);
Console.WriteLine($"Tu nombre es: {nombre} {apellido}");

Console.WriteLine("Nombre {0}, apellido {1}", nombre, apellido);

Console.WriteLine("*********Numeros*********");

int numero = 10;
int numero2 = 20;

int resultado = numero + numero2;

Console.WriteLine(resultado);

// si no hay una cadena "" se suma normal: osea 30 si hay una cadena "" se concatena
// osea "1020"
Console.WriteLine("resultado: " + numero + numero2);
// si se quiere sumar y no concatenar, se debe convertir a int
// osea Convert.toInt32(numero + numero2)
Console.WriteLine("resultado: " + Convert.ToInt32(numero + numero2));

Console.WriteLine(numero - numero2);
Console.WriteLine(numero / numero2);
Console.WriteLine(numero * numero2);


String num1 = "10";
String num2 = "20";
Console.WriteLine(num1 + num2);

float f = 1f / 3f;  // 0.3333333 (Aproximadamente)
double d = 1.0 / 3.0; // 0.3333333333333333 (más preciso que float)
decimal m = 1.0m / 3.0m; // 0.3333333333333333333333333333 (mas preciso que double)

Console.WriteLine("float: " + f);
Console.WriteLine("double: " + d);
Console.WriteLine("decimal: " + m);

decimal salario = 1205.25M; // M al final indica que es un decimal
decimal aumento = 10.10M;

Console.WriteLine("Aumento (mal hecho): " + salario + aumento);

float resultadoFinal = (float)(salario + aumento);
Console.WriteLine("Aumento (bien hecho): " + resultadoFinal);

Console.WriteLine("**********Booleanos y var*********");

bool esMayorDeEdad = false;
Console.WriteLine("Es mayor de edad: " + esMayorDeEdad);
esMayorDeEdad = true;
Console.WriteLine("Es mayor de edad: " + esMayorDeEdad);

var variableDinamica = "Una cadena de texto";
// variableDinamica = 123;  // Esto no es posible porque 'var' infiere el tipo 
// en la primera asignación


var edad = 23;

var esHombre = true;

// Ejercicio 
Console.WriteLine("Digite el primer numero: ");
String entrada1 = Console.ReadLine()!;
Console.WriteLine("Digite el segundo numero: ");
String entrada2 = Console.ReadLine()!;
Console.WriteLine("Digite el tercer numero: ");
String entrada3 = Console.ReadLine()!;
int suma = Convert.ToInt32(entrada1) + Convert.ToInt32(entrada2) + Convert.ToInt32(entrada3);
Console.WriteLine("La Suma de los dos numeros es: " + suma);
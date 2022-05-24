// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Escribe un programa que:

1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Recuerden que no nos deben adjuntar archivos comprimidos ni imagenes.
Pueden adjuntarnos el archivo .cs, o el codigo como texto.*/

//1)Pida 10 numeros al usuario
int[] numeros = new int[10];


for (int i = 0; i < numeros.Length; i++)

{

    Console.WriteLine($"Por favor ingrese el numero: { i + 1}");

    numeros[i] = int.Parse(Console.ReadLine());

}


//2) Obtener la suma de todos los numeros

int suma = 0;
for (int i = 0; i < numeros.Length; i++)
{
    suma = suma + numeros[i];
}

//3)Obtener el mayor de todos los numeros


numeros.Max();



//4)Obtener el menor de todos los numeros

numeros.Min();



//5) Obtener el promedio de todos los números.

numeros.Average();


//6) Mostrar todos los números ingresados por pantalla.

Console.WriteLine("Los valores son:");

for (int i = 0; i < numeros.Length; i++)

{
    Console.WriteLine(numeros[i]);

}

//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.

Console.WriteLine($"La suma de los numeros ingresados es = {suma}");

Console.WriteLine($"El mayor de todos los numeros es ={numeros.Max()}");

Console.WriteLine($"El menor de todos los numeros es ={numeros.Min()}");

Console.WriteLine($"El promedio de todos los numeros es ={numeros.Average()}");



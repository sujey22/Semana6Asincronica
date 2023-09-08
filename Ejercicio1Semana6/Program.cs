
//Ejercicio 1
//La operación completa incluye crear un origen de datos, definir la expresión de
//consulta y ejecutar la consulta en una instrucción foreach.

int[] Score = { 97, 92, 81, 60 };

var Query = (from x in Score where x > 80 select x);

Console.WriteLine(string.Join(", ", Query));

Console.WriteLine("Hecho por Merlin Sujey Duarte");
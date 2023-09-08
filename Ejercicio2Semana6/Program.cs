//Ejercicio 2
//La operación completa incluye crear un origen de datos, definir la expresión de
//consulta y ejecutar la consulta en una instrucción foreach.

int[] Score = { 90, 71, 82, 93, 75, 82 };

var Query = (from x in Score where x > 80 select x);

var descend = Query.OrderByDescending(x => x.ToString());

Console.WriteLine(string.Join(", ", descend));

Console.WriteLine("Hecho por Merlin Sujey Duarte");
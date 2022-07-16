//Problema 2.2:
//Silo.El dueño de un campo almacena sus cosechas de granos en silos
//cilíndricos. Le pide que desarrolle un programa que le permita conocer el volumen
//máximo de un silo.


using Ejercicio2._2;

Silo oSilo = new Silo();


Console.WriteLine("Ingresa el valor del radio: ");

oSilo.Radio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura:");

oSilo.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("El volumen del silo sera: " + oSilo.CalcularVolumen());

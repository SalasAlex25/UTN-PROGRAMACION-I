//Problema 2.4:
//Persona.Se nos pide modelar una clase Persona con las siguientes
//condiciones:
// Sus atributos son: nombre, edad, sexo(H hombre, M mujer), peso y altura.
// Los métodos que se implementarán son:
//o calcularIMC(): calculará si la persona está en su peso ideal (peso en
//kg/(altura^2 en m)), si esta fórmula devuelve un valor menor que 20, la
//función devuelve un -1, si devuelve un número entre 20 y 25 (incluidos),
//significa que está por debajo de su peso ideal la función devuelve un 0


//y si devuelve un valor mayor que 25 significa que tiene sobrepeso, la
//función devuelve un 1. Se recomienda usar constantes para devolver
//estos valores.
//o esMayorDeEdad(): indica si es mayor de edad(21 años), devuelve un
//booleano.

using Problema2._4;

Persona oPersona = new Persona("Alex",21,"M",79,1.60);
Console.WriteLine(oPersona.CalcularIMC());
Console.WriteLine(oPersona.EsMayorDeEdad());


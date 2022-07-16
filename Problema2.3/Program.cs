//Problema 2.3:
//Punto.nos han solicitado desarrollar una clase que permita modelar un punto
//en el plano. Cada punto se representa mediante un par ordenado de coordenadas
//cartesianas y es posible conocer:
// cuál es su distancia al eje de coordenadas
// Adicionalmente se necesita mostrar un punto como una cadena con formato
//“(x; y)”.

using Problema2._3;

Punto oPunto = new Punto();


Console.WriteLine("LA DISTANCIA ENTRE AMBOS PUNTOS ES: " + oPunto.CalcularDistancia());

Console.WriteLine("LA COORDENADA ES: " + oPunto.CoordenadaX + ";" + oPunto.CoordenadaY);
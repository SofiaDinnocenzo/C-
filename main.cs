using System;

class MainClass {
  public static void Main (string[] args) {
  int numero, auxiliar, decena, unidad;
  Console.WriteLine ("Ingrese número de dos cifras:");
  numero=Convert.ToInt32 (Console.ReadLine());
  decena=numero/10;
  unidad=numero % 10;
  auxiliar=(unidad*10) + decena;
  Console.WriteLine();
  Console.WriteLine("El número invertido es:" + auxiliar);




  }
}
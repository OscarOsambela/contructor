using System;

class MainClass {
  public static void Main (string[] args) {
    Coche obj = new Coche();//instanciando tanto la clase como el contructor
    Console.WriteLine(obj.getInfoCoche());

    Coche obj2 = new Coche(3.80, 1.76, "negro");
    Console.WriteLine(obj2.getInfoCoche());

    Coche obj3 = new Coche(4, 3.85, 1.62, "azúl");
    Console.WriteLine(obj3.getInfoCoche());
  }
}

//clase
class Coche{
  //contructor
  public Coche(){
    ruedas = 4;
    largo = 3.20;
    ancho = 2.8;
    color = "rojo";
  }
  //constructor 2
  public Coche(double largoCoche2, double anchoCoche2, string colorCoche2){
    ruedas = 4;
    largo = largoCoche2;
    ancho = anchoCoche2;
    color = colorCoche2;
  }
  //contructor 3
  public Coche(int ruedasCoche3, double largoCoche3, double anchoCoche3, string colorCoche3){
    ruedas = ruedasCoche3;
    largo = largoCoche3;
    ancho = anchoCoche3;
    color = colorCoche3;
  }

  //método get()
  public string getInfoCoche(){
    return "Información del coche: \n" +
           "Ruedas: " + ruedas + ",\n" +
           "Largo: " + largo + ",\n" +
           "Ancho: " + ancho + ",\n" +
           "Color: " + color + "\n"; 
  }

  private int ruedas;
  private double largo;
  private double ancho;
  private string color;
}
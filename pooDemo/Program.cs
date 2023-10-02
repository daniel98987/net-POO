// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Apuntador apuntadorPlatz = new Apuntador();
Apuntador apuntadorPlatz2 = new Apuntador();

apuntadorPlatz.Color = "Negro";
apuntadorPlatz2.Color = "Blanco";

class Apuntador {

    public string Color ;
    public double Largo;
    public short NumeroDeBotones;
    public bool TieneStickers;

}
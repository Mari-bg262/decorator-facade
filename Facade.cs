using System;

class Proyector
{
    public void Encender() => Console.WriteLine("Proyector encendido");
    public void Apagar() => Console.WriteLine("Proyector apagado");
}

class Sonido
{
    public void Encender() => Console.WriteLine("Sonido encendido");
    public void Apagar() => Console.WriteLine("Sonido apagado");
}

class Luces
{
    public void Atenuar() => Console.WriteLine("Luces atenuadas");
    public void Encender() => Console.WriteLine("Luces encendidas");
}

// Fachada
class HomeTheaterFacade
{
    Proyector proyector = new Proyector();
    Sonido sonido = new Sonido();
    Luces luces = new Luces();

    public void VerPelicula()
    {
        Console.WriteLine("--- Iniciando película ---");
        luces.Atenuar();
        proyector.Encender();
        sonido.Encender();
    }

    public void FinPelicula()
    {
        Console.WriteLine("--- Apagando todo ---");
        proyector.Apagar();
        sonido.Apagar();
        luces.Encender();
    }
}

class Program
{
    static void Main()
    {
        var cine = new HomeTheaterFacade();
        cine.VerPelicula();

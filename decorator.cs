using System;

interface IBebida
{
    string Descripcion();
    double Costo();
}

class Cafe : IBebida
{
    public string Descripcion() => "Café";
    public double Costo() => 2.0;
}

class ConLeche : IBebida
{
    IBebida bebida;
    public ConLeche(IBebida b) { bebida = b; }
    public string Descripcion() => bebida.Descripcion() + " + Leche";
    public double Costo() => bebida.Costo() + 0.5;
}

class ConChocolate : IBebida
{
    IBebida bebida;
    public ConChocolate(IBebida b) { bebida = b; }
    public string Descripcion() => bebida.Descripcion() + " + Chocolate";
    public double Costo() => bebida.Costo() + ;
}

class Program
{
    static void Main()
    {
        IBebida pedido = new ConChocolate(new ConLeche(new Cafe()));
        Console.WriteLine($"{pedido.Descripcion()} = {pedido.Costo()}");
    }
}

using System;

namespace PAUL_Lilian_TP6_ST2TRD
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new PizzaDelaMama.Director();
            var builder = new PizzaDelaMama.ConcreteBuilder();
            director.Builder = builder;
            
            Console.WriteLine("Standard basic product:");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());
            Console.WriteLine("");
            Console.WriteLine("Custom product:");
            builder.PePene();
            builder.Chorizo();
            Console.Write(builder.GetProduct().ListParts());
            
            Client client = new Client();

            var comp = new ConcreteComponent();
            Console.WriteLine("Composant");
            client.ClientCode(comp);
            Console.WriteLine();
            Merguez merguez = new Merguez(comp);
            Console.WriteLine("Création de la merguez");
            Console.WriteLine(merguez.Operation());
            Couscous couscous = new Couscous(merguez);
            client.ClientCode(couscous);
            
            
        }
    }
}
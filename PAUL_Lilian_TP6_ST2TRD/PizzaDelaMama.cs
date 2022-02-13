using System.Collections.Generic;

namespace PAUL_Lilian_TP6_ST2TRD
{
    public class PizzaDelaMama
    {
        // The Builder interface specifies methods for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void Tomato();
        
        void Cheese();
        
        void PePene();

        void Pineapple();
        void Chorizo();
    }
    
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new Product();
        }
        
        // All production steps work with the same product instance.
        public void Tomato()
        {
            this._product.Add("Tomato");
        }
        
        public void Cheese()
        {
            this._product.Add("Cheese");
        }
        
        public void PePene()
        {
            this._product.Add("PePene");
        }
        public void Pineapple()
        {
            this._product.Add("Pineapple");
        }
        public void Chorizo()
        {
            this._product.Add("Chorizo");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
    public class Product
    {
        private List<object> _parts = new List<object>();
        
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }
    }
    
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set => _builder = value;
        }
        
        public void BuildMinimalViableProduct()
        {
            this._builder.Cheese();
        }
        
        public void BuildFullFeaturedProduct()
        {
            this._builder.Pineapple();
            this._builder.Chorizo();
            this._builder.PePene();
            this._builder.Cheese();
            this._builder.Tomato();
        }
    }
    
        
    }
}
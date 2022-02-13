using System;

namespace PAUL_Lilian_TP6_ST2TRD
{
    public abstract class Component
    {
        public abstract string Operation();
    }
    
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "Composant de base";
        }
    }
    abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
    class Merguez : Decorator
    {
        public Merguez(Component comp) : base(comp)
        {
        }
        public override string Operation()
        {
            return "Merguez()";
        }
    }
    class Couscous : Decorator
    {
        public Couscous(Component comp) : base(comp)
        {
        }

        public override string Operation()
        {
             
            return $"Couscous({base.Operation()})";
        }
    }
    
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("Plat décoré : " + component.Operation());
        }
    }
}
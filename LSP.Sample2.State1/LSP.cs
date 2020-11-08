using System;
using System.Collections.Generic;

namespace LSP.Sample2.State1
{
    public abstract class CoffeeMaker
    {
        public abstract void DoCoffee();
        public abstract void DoEspresso();
        public abstract void DoCapucino();
    }

    public class DeLonghi : CoffeeMaker
    {
        public override void DoCoffee()
        {
            Console.WriteLine("Ready!");
        }

        public override void DoEspresso()
        {
            Console.WriteLine("Ready!");
        }

        public override void DoCapucino()
        {
            Console.WriteLine("Ready!");
        }
    }

    public class Phillips : CoffeeMaker
    {
        public override void DoCoffee()
        {
            Console.WriteLine("Ready!");
        }

        public override void DoEspresso()
        {
            throw new NotImplementedException();
        }

        public override void DoCapucino()
        {
            throw new NotImplementedException();
        }
    }

    public class CoffeeShop
    {
        private readonly List<CoffeeMaker> _coffeeMakers;

        public CoffeeShop(List<CoffeeMaker> coffeeMakers)
        {
            _coffeeMakers = coffeeMakers;
        }
        public void DoQuickCoffee()
        {
            foreach (var coffeeMaker in _coffeeMakers)
            {
                coffeeMaker.DoCoffee();
            }
        }

        public void DoQuickEspresso()
        {
            foreach (var coffeeMaker in _coffeeMakers)
            {
                coffeeMaker.DoEspresso(); //throws exception;
            }
        }

        public void DoQuickCapucino()
        {
            foreach (var coffeeMaker in _coffeeMakers)
            {
                coffeeMaker.DoCapucino();//throws exception;
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace LSP.Sample2.Final
{
    public abstract class CoffeeMaker
    {
        public abstract void DoCoffee();
    }

    public interface ICanMakeEspresso
    {
        void DoEspresso();
    }

    public interface ICanMakeCapucino
    {
        void DoCapucino();
    }

    public class Phillips : CoffeeMaker
    {
        public override void DoCoffee()
        {
            Console.WriteLine("Ready!");
        }

    }

    public class DeLonghi : CoffeeMaker, ICanMakeEspresso, ICanMakeCapucino
    {
        public override void DoCoffee()
        {
            Console.WriteLine("Ready!");
        }

        public void DoEspresso()
        {
            Console.WriteLine("Ready!");
        }

        public void DoCapucino()
        {
            Console.WriteLine("Ready!");
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
                if (coffeeMaker is ICanMakeEspresso espressoMaker) //Hata vermez :)
                {
                    espressoMaker.DoEspresso();
                }
                
            }
        }

        public void DoQuickCapucino()
        {
            foreach (var coffeeMaker in _coffeeMakers)
            {
                if (coffeeMaker is ICanMakeCapucino capucinoMaker) //Hata vermez :)
                {
                    capucinoMaker.DoCapucino();
                }
            }
        }
    }
}

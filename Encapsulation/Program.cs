using Console = System.Console;

Console.WriteLine("Encapsulation Örneği");

var medical = new Medical();

Console.WriteLine("Animal");
Console.WriteLine("-------------");

var animal = new Animal();
animal.Breath();
animal.SetName("Karabaş");
animal.SetAge(5);
medical.Describe(animal);
medical.Surger(animal);

Console.WriteLine("");


Console.WriteLine("Human");
Console.WriteLine("-------------");

var human = new Human();
human.Breath();
human.SetName("Samet");
human.SetAge(33);
human.Think();
medical.Describe(human);
medical.Surger(human);

public abstract class Creature
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public void Breath()
    {
        Console.WriteLine("Nefes.");
    }
    public virtual void SetAge(int age)
    {
        if (age < 0)
        {
            Age = 0;
        }
        else
        {
            Age = age;
        }
        
    }
    public virtual void SetName(string name)
    {
        Name = name;
    }

    public abstract void Describe();
    public abstract void Die();
}
public class Animal : Creature
{
    public override void Die()
    {
        Console.WriteLine("Ölüm.");
    }

    public override void Describe()
    {
        Console.WriteLine($"Hrrrrr, hav hav, miyav miyav");
    }
}

public class Human : Creature
{

    public override void Die()
    {
        Console.WriteLine("Ölüm.");
        Console.WriteLine("Şehadet getirdi.");
    }

    public void Think()
    {
        Console.WriteLine("Düşünüyorum, o halde varım.");
    }

    public override void Describe()
    {
        Console.WriteLine($"Merhaba, Benim adım {Name}, Benim yaşım {Age}.");
    }
}

public class Medical
{
    public void Describe(Creature creature)
    {
        Console.WriteLine("Medikal tanım yapılıyor...");
        creature.Describe();
    }

    public void Surger(Creature creature)
    {
        Console.WriteLine("Ameliyat ediliyor...");
        creature.Die();
    }

    // other medical methods.. 
}
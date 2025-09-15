using Console = System.Console;

Console.WriteLine("Inheritence Örneği");

var medical = new Medical();

Console.WriteLine("Animal");
Console.WriteLine("-------------");

var animal = new Animal();
animal.Breath();
animal.Name = "Karabaş";
animal.Age = 5;

medical.DescribeAnimal(animal);
medical.SurgerAnimal(animal);

Console.WriteLine("");


Console.WriteLine("Human");
Console.WriteLine("-------------");

var human = new Human();
human.Breath();
human.Name = "Samet";
human.Age = 33;
human.Think();
medical.DescribeHuman(human);
medical.SurgerHuman(human);

public class Creature
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Breath()
    {
        Console.WriteLine("Nefes.");
    }
}
public class Animal : Creature
{
    public void Die()
    {
        Console.WriteLine("Ölüm.");
    }

    public void Describe()
    {
        Console.WriteLine($"Hrrrrr, hav hav, miyav miyav");
    }
}

public class Human : Creature
{

    public void Die()
    {
        Console.WriteLine("Ölüm.");
        Console.WriteLine("Şehadet getirdi.");
    }

    public void Think()
    {
        Console.WriteLine("Düşünüyorum, o halde varım.");
    }

    public void Describe()
    {
        Console.WriteLine($"Merhaba, Benim adım {Name}, Benim yaşım {Age}.");
    }
}

public class Medical
{
    public void DescribeAnimal(Animal animal)
    {
        Console.WriteLine("Medikal tanım yapılıyor...");
        animal.Describe();
    }

    public void DescribeHuman(Human human)
    {
        Console.WriteLine("Medikal tanım yapılıyor...");
        human.Describe();
    }

    public void SurgerHuman(Human human)
    {
        Console.WriteLine("Ameliyat ediliyor...");
        human.Die();
    }

    public void SurgerAnimal(Animal animal)
    {
        Console.WriteLine("Ameliyat ediliyor...");
        animal.Die();
    }

    // other medical methods.. 
}
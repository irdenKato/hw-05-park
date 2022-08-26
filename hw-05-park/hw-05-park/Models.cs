
class Animals               //добавляем public чтобы можно было использовать инфу вне класса
{
    public string name;
    public int age;
    public double size;

    public void GetGrow()
    {
        Console.ReadLine(age);

        if (age == 0)
        { Console.WriteLine(size); }
        else if (age <= 70)
        {
            int k = (int)age;
            float s = (float)size;
            double x = s * (1 + 0.1*k);
            Console.WriteLine("Размер в возрасте {age} = {x}");
        }
        else
        { Console.WriteLine("Проверьте введенный возраст"); }
    }

    public void Eat()
    {
        Console.WriteLine($"{elephant.name} может съесть {chamomile.name}");
    }
}

sealed class elephant : Animals     //sealed запрещает наследование от этих классов
{
    name = "Www";
}

sealed class octopus : Animals
{

}

class Plant
{
    public string name2;
    public int age2;
    public float size2;
}

sealed class kalanchoe : Plant
{

}

sealed class chamomile : Plant
{

}
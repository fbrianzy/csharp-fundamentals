using System;

class Animal { public virtual string Speak() => "..."; }
class Dog : Animal { public override string Speak() => "Woof"; }
class Cat : Animal { public override string Speak() => "Meow"; }

class Program
{
    static void Talk(Animal a) => Console.WriteLine(a.Speak());
    static void Main()
    {
        Talk(new Dog());
        Talk(new Cat());
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        
        IComponent<string> component = new ConcreteComponent();

       
        var plaindecorator = new Plaindecorator(component);
        var upperCaseDecorator = new UpperCaseDecorator(component);
        var colorDecorator = new ColorDecorator(component);

        Console.WriteLine("Text from ConcreteComponent: " + component.GetText());
        Console.WriteLine("Text from PlainDecorator: " + plaindecorator.GetText());
        Console.WriteLine("Text from UpperCaseDecorator: " + upperCaseDecorator.GetText());
        Console.WriteLine("Text from ColorDecorator: " + colorDecorator.GetText());
    }
}


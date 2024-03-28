public class Plaindecorator : Decorator<string>
{
    public Plaindecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
        
        string baseText = base.GetText();
        return "Hi I am Parneet " + baseText;
    }
}


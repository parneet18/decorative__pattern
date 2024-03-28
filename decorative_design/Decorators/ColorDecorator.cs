public class ColorDecorator : Decorator<string>
{
    public ColorDecorator(IComponent<string> component) : base(component)
    {
    }

    public override string GetText()
    {
       
        string baseText = base.GetText();
        return $"\u001b[31m{baseText}\u001b[0m"; 
    }
}

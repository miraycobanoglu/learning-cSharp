namespace polymorphsim{

public class hayvan
{
    public string isim { get; set; }
    
    public virtual void konus()
    {
        Console.WriteLine(isim + "konuşuyor");
    }
}
}
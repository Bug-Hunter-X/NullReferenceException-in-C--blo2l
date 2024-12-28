public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a null reference
        Console.WriteLine(MyProperty.ToString());
    }
}
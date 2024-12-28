public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty

    public void MyMethod()
    {
        // Accessing a member after initialization
        Console.WriteLine(MyProperty.ToString());
    }
}
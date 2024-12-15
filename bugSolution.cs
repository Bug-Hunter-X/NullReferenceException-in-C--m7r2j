public class MyClass
{
    public int? MyProperty { get; set; } // Nullable int

    public void MyMethod()
    {
        // Check for null before accessing the property
        int value = MyProperty.HasValue ? MyProperty.Value.ToString().Length : 0; 
    }
}
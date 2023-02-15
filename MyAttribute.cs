namespace Attributes;

[System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class MyAttribute : System.Attribute
{
    readonly string positionalString;

    // This is a positional argument
    public MyAttribute(string positionalString)
    {
        this.positionalString = positionalString;

        // TODO: Implement code here
        throw new System.NotImplementedException();
    }

    public string PositionalString
    {
        get { return positionalString; }
    }

    public int test()
    {
        return 0;
    }

    // This is a named argument
    public int NamedInt { get; set; }
}
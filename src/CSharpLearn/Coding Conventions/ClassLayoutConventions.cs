namespace CSharpLearn.CodingConventions;

/// <summary>
/// A class showing an example 
/// </summary>
internal class ClassLayoutConventions
{
    // Public Variables
    // Variables are grouped together and sorted by prority. This is not something I focus on; and do just what feels good.
    public int CardName;
    public int CardDescription;
    public int CardHealth;
    public int NameOfPlayer;

    // Internal Variables
    internal int AVeryImportantNumber;

    // Protected Variables
    protected int _turnNumber;

    // Private Variables
    private int _effectStackCount;

    // Constructor
    public ClassLayoutConventions() { }

    // Public Methods
    public void PublicMethod() { }

    // Internal Methods
    internal void InternalMethod() { }

    // Protected Methods
    protected void ProtectedMethod() { }

    // Private Methods
    private void PrivateMethod() { }
}

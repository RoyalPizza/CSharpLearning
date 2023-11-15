namespace CSharpLearn.CodingConventions;

/// <summary>
/// 
/// </summary>
internal class ClassLayoutConventions
{
    // Public
    // Variables are grouped together and sorted by prority. This is not something I focus on; just what feels good.
    public int CardName;
    public int CardDescription;
    public int CardHealth;
    public int NameOfPlayer;

    // Internal
    internal int AVeryImportantNumber;

    // Protected
    protected int TurnNumber;

    // Private
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

// I prefer doing namespaces like this to avoid unused indentation.
// I never add more than one namespace per file. Usually its one class per file too.
namespace CSharpLearn.CodingConventions;

/// <summary>
/// A class showing my preferred naming and style conventions
/// </summary>
/// <remarks>
/// Most of these conventions are the MSFT naming conventions.
/// </remarks>
internal class NamingConventions
{
    /// <summary>
    /// 
    /// </summary>
    public int SomePublicInt;

    /// <summary>
    /// use all caps and snake case for constants.
    /// </summary>
    /// <remarks>
    /// This is not part of MSFT convention. Just a preference.
    /// </remarks>
    private const int SOME_CONST_INT = 50;

    /// <summary>
    /// Use an underscore camel case for private readonly variables
    /// </summary>
    private readonly int _somePrivateReadonlyInt;

    /// <summary>
    /// Use an underscore camel case for private variables
    /// </summary>
    private int _somePrivateInt;

    /// <summary>
    /// Constructor
    /// </summary>
    public NamingConventions()
    {
        // I have become a fan of setting values in the constructor instead of next to the variable.
        SomePublicInt = 10;
        _somePrivateReadonlyInt = 10;
        _somePrivateInt = 10;
    }

    // Pascal case for methods
    private void PrivateMethod() { }
    public void PublicMethod() { }
    protected void ProtectedMethod() { }
    internal void InternalMethod() { }

    // Event Methods should have a tense. I do not do the "OnAction" naming style with events.
    private void ButtonClicked() { }
    private void ThingHappening() { }
    private void ThingHappened() { }

    // Camel case for parms for methods
    private void MethodWithParams(int someParam) { }
}

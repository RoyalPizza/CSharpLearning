// I prefer doing namespaces like this to avoid unused indentation.
// I never add more than one namespace per file. Usually its one class per file too.
namespace CSharpLearn.CodingConventions;

/// <summary>
/// A class showing my preferred naming and style conventions
/// </summary>
/// <remarks>
/// Most of these conventions are the MSFT naming conventions. 
/// <see href=https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names">LINK</see>
/// </remarks>
internal class NamingConventions
{
    /// <summary>
    /// 
    /// </summary>
    public int SomePublicInt;

    /// <summary>
    /// Use pascal case for internal.
    /// </summary>
    /// <remarks>
    /// This differs from MSFT a bit. They say to treat it like a private; but
    /// just because it is isolated to this DLL; does not mean it wont be accesesd 
    /// by other objects in the DLL. This is more simlar to a public than a private imo.
    /// </remarks>
    internal int SomeInternalInt;

    /// <summary>
    /// use _ and camel case for protected.
    /// </summary>
    /// <remarks>
    /// This differs from the MSFT conventions. They recommend treating it like a public.
    /// But because only child classes can access it, it feels closer to private than internal does.
    /// </remarks>
    protected int _someProtectedInt;

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
    public void PublicMethod() { }
    internal void InternalMethod() { }
    protected void ProtectedMethod() { }
    private void PrivateMethod() { }

    // Event Methods should have a tense. I do not do the "OnAction" naming style with events.
    private void ButtonClicked() { }
    private void ThingHappening() { }
    private void ThingHappened() { }

    // Camel case for parms for methods
    private void MethodWithParams(int someParam) { }
}

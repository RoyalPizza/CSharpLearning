namespace CSharpLearn.CodingConventions;

/// <summary>
/// A class detailing thoughts on expression bodied members
/// </summary>
/// <remarks>
/// Long story short. Old way is my preferred way. I only use this operator with switch case.
/// </remarks>
internal class ExpressionBodiedMembers
{
    /*
     * Variable examples
     * Old way is better in my opinion. Usually with properties I do solution #2.
    */
    private int _myMagicNumber;
    public int MyMagicNumberOldWay1 { get { return _myMagicNumber; } }
    public int MyMagicNumberOldWay2 { get; private set; }
    public int MyMagicNumberNewWay => _myMagicNumber; // Need to research to see if this is treated as a get only property, or something else.

    /* 
     * Constructor Examples
     * The first constructor is the normal way. The second one is the new way.
     * The first one is more identifiable and readable; so I only do the old way.
    */
    public ExpressionBodiedMembers()
    {
        _myMagicNumber = 10;
    }
    public ExpressionBodiedMembers(int value) => _myMagicNumber = value;


    /* 
     * Method examples
     * The old way is better to me. Purely for asthetic reasons, but normally a method return is 
     * not always this simple. Sometimes it is; but for constancy I feel it is better to do it the same 
     * everywhere. Not just because a methods return value is simple enough to do it.
    */
    public string GetNameNewWay() => "Royal Freaking Pizza";
    public string GetNameOldWay()
    {
        return "Royal Freaking Pizza";
    }

    // Note: See an example where I do like this operator for switch statements in the swith case example.
}

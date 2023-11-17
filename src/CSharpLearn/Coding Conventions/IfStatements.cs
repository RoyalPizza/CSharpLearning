namespace CSharpLearn.Coding_Conventions;

/// <summary>
/// Discusses my opinion on if statements
/// </summary>
internal class IfStatements
{
    private void MultiLineIfs()
    {
        bool someBool = true;
        bool someOtherBool = true;
        bool someOtherOtherBool = false;
        bool someOtherOtherOtherBool = true;
        bool someOtherOtherOtherOtherBool = true;
        bool someOtherOtherOtherOtherOtherBool = true;

        // Single line
        if (someBool == true && someOtherBool == true && someOtherOtherBool == false && someOtherOtherOtherBool == true && someOtherOtherOtherOtherBool == true && someOtherOtherOtherOtherOtherBool == true)
        {
            // Eh. Who cares. Do what you want.
        }

        // Multi line
        if (someBool == true
            && someOtherBool == true
            && someOtherOtherBool == false
            && someOtherOtherOtherBool == true
            && someOtherOtherOtherOtherBool == true
            && someOtherOtherOtherOtherOtherBool == true)
        {
            // Eh. Who cares. Do what you want.
        }
    }

    /// <summary>
    /// Talks about short hand vs long hand boolean expressions
    /// </summary>
    private void ShortHandVsLongHand()
    {
        /*
         * For most of my career, I have used the shorthand to evaluate
         * boolean IF conditions. However, in recent years I have found myself preferring 
         * typing out == true or == false, even though its extra to type.
         * 
         * The reason for this is simple. Personal Preference.
         * The shorthand is definitley the more popular way. However, I like consistency and all other
         * value types require typing out the value you are comparing against on the right. So why should bools be any different.
        */

        bool someBool = true;
        bool someOtherBool = true;
        bool someOtherOtherBool = false;

        // Shorthand
        if (someBool && someOtherBool && !someOtherBool && SomeMethodThatReturnsBool() && !SomeOtherMethodThatReturnsBool())
        {
            // I used this most my life
        }

        // Long Way
        if (someBool == true && someOtherBool == true && someOtherOtherBool == false && SomeMethodThatReturnsBool() == true && SomeOtherMethodThatReturnsBool() == false)
        {
            // I am now doing this.
        }

        // Ternarys count too!!!
        int someMagicNumber = (someBool == true) ? 1 : 2;
    }

    private bool SomeMethodThatReturnsBool()
    {
        return true;
    }

    private bool SomeOtherMethodThatReturnsBool()
    {
        return false;
    }
}

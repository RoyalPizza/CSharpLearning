namespace CSharpLearn.CodingConventions;

/// <summary>
/// Details out my preferred way to handle switch cases
/// </summary>
internal class SwitchCase
{
    private void SwitchCaseExample()
    {
        int someValue = 10;

        // old way
        string? message1;
        switch (someValue)
        {
            case 1:
                message1 = "You gots 1 dollaz";
                break;
            case 2:
                message1 = "You gots 2 dollaz";
                break;
            default:
                message1 = "You gots NULL dollaz";
                break;
        }

        // new way
        string message2 = someValue switch
        {
            1 => "You gotz 1 dollaz",
            2 => "You gotz 2 dollaz",
            _ => "You gots NULL dollaz"
        };

        /*
         * The new way is shorter and easier to read.
         * Its not good if you are performing actions in the swith case.
         * Calling multiple methods (for example) is not good in the new way.
         * But I typallly only use switch case to perform a single action; not multiple. 
         * And that action is typically assining a value;
         * 
         * If I am doing more than just assinging a value; then I would use the old way.
        */
    }
}

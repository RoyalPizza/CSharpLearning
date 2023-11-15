namespace CSharpLearn.CodingConventions;

/// <summary>
/// 
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
        }

        // new way
        string message2 = someValue switch
        {
            1 => "You gotz 1 dollaz",
            2 => "You gotz 2 dollaz",
            _ => "You gots NULL dollaz"
        };
    }
}

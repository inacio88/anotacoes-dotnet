namespace simplifyCSharp;

public class ImportantLogic
{
    public (string firstname, string lastname) SplitName(string fullName)
    {
        string[] names = fullName.Split(' ');

        return (names[0], names[1]);
    }
}

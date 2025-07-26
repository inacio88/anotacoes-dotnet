using Microsoft.Data.SqlClient;
using simplifyCSharp;
using static System.Console;

WriteLine("Hello, World!");


List<string> names = ["loui", "clark"];
string[] namesArr = ["loui", "clark"];


List<int> numbers = new();

var parameters = new { FirstName = "Carlo", LastName = "Alberto" };



object emp = new EmployeeRecord(1, "Carlos");

if (emp is not null)
{
    WriteLine("não é nulo");
}

if (emp is EmployeeRecord e && e.Id == 1)
{
    WriteLine($"the employee id of 1 is {e.Name}");
}

WriteLine($"there was an error with the {nameof(emp)} variable");


ImportantLogic importantLogic = new();

var results = importantLogic.SplitName("Carlos Alberto");

WriteLine(results.firstname);

(string, string) results2 = importantLogic.SplitName("Carlos Alberto");

WriteLine(results2.Item1);


(string n1, string n2) results3 = importantLogic.SplitName("Carlos Alberto");

WriteLine(results3.n1);

(string n1, string n2) = importantLogic.SplitName("Carlos Alberto");

WriteLine(n1);

var (q1,  _) = importantLogic.SplitName("Carlos Alberto");

WriteLine(q1);


//dispose
using var conn = new SqlConnection("");


using (var conn2 = new SqlConnection(""))
{

}



string numberText = "43";

int.TryParse(numberText, out int numberValue);

WriteLine($"the number is {numberValue}");
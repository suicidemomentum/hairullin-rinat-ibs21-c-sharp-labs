using LocalClasses;
using Exceptions;

try
{
    User usr = new User("Testing", "Jim", "Jommia-S", "test@mail.ru", LocalFuncs.StringToDate("15-11-2000"));
    Console.WriteLine(usr.ToString());
    string str = "Testing, Jim, Jommia-S, , 11-11-2000";
    usr.FillFromString(str);
    Console.WriteLine(usr.ToString());
}
catch (UserException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("Unknown error - " + e.Message);
}
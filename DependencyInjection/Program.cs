// See https://aka.ms/new-console-template for more information

//injector
BusinessLogicService obj = new BusinessLogicService(new StudentService());

obj.Sample();
Console.WriteLine(obj.sssss(1));
/*
Client = depends on the service class
Service = serves the operation for the client class
Injector = injects service class into client class
 */



//Client Class
class BusinessLogicService
{
    private IService _iService;

    public BusinessLogicService(IService service)
    {
        this._iService = service;
    }

    public void Sample()
    {
        string something;

        something = _iService.GetFirstName();
        Console.WriteLine(something);
    }

    public int sssss(int first)
    {
        return 1 + first;
    }

}

interface IService
{
    string GetFirstName();
    string GetLastName();
}

//Service Class
public class StudentService : IService
{
    public string GetFirstName()
    {
        return "Student First Name";
    }

    public string GetLastName()
    {
        return "Student Last Name";
    }
}

//Service Class
public class TeacherService : IService
{
    public string GetFirstName()
    {
        return "Teacher Last Name";
    }

    public string GetLastName()
    {
        return "Teacher Last Name";
    }
}
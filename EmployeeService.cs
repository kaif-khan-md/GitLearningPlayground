public class EmployeeService
{
    public void CreateEmployee(string name)
{
    if(string.IsNullOrWhiteSpace(name))
        return;

    Console.WriteLine(name);
}
}
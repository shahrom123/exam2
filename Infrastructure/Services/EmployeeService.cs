

using System.Data;

public class EmployeeService
{
    private List<Employee> Employees;

    public EmployeeService()
    {
        Employees = new List<Employee>();
    }
    public List<Employee> GetEmployee()
    {
        return Employees;
    }
    public void Add(Employee Employee)
    {
        Employees.Add(Employee);
    }
    public void Update(Department department, int id)
    {
        var find = Employees.Find(x => x.Id == department.Id);
        find.BirthDate = 
        find.FirstName =
        
    }
    public Employee GetEmployeetById(int id)
    {
        var findId = Employees.Find(x => x.Id == id);
        return ;

    }
    public  void Delete(int id)
    {
        var findId = Employees.Find(x => x.Id == id);
        if (findId == null) return;
        Employees.Remove(findId);
    }
    public int Count()
    {
        return Employees.Count();
    }
}
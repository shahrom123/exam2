
public class DepartmentService
{
    private List<Department> departments;

    public DepartmentService()
   {
        departments = new List<Department>();
    }
    public List<Department> GetDepartments()
    {
        return departments;
    }
    public void Add(Department department)
    {
        departments.Add(department);
    }
   public void Update(Department department, int id)
    {
        var find = departments.Find(x => x.Id == department.Id);
    }
    public void Delete(int id)
    {
        var findId = departments.Find(x => x.Id == id);
        if (findId == null) return;
        departments.Remove(findId);
    }
    public int Count()
    {
        return departments.Count();
    }
}
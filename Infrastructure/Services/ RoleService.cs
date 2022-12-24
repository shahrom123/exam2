
public class RoleService
{
    private List<Role> Roles;

    public RoleService()
    {
        Roles = new List<Role>();
    }
    public List<Role> GetRoles()
    {
        return Roles;
    }
    public void Add(Role role)
    {
        Roles.Add(role);
    }
    public void Update(Role Role, int id)
    {
        var find = Roles.Find(x => x.Id ==id);
        if (find != null)
        {

        }
    }
     public Role GetRoleById(int id)
    {
        var findId = Roles.Find(x => x.Id == id);
        
    }

    public void Delete(int id)
    {
        var findId = Roles.Find(x => x.Id == id);

        if (findId != null)
        {
            Roles.Remove(findId);
        }
    }
     public int Count()
    { 
        if(Roles == null) return 0;
        return Roles.Count();
    }
}
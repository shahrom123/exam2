
public class ExperienceService
{
    private List<Experience> Experiences;

    public ExperienceService()
    {
        Experiences = new List<Experience>();
    }
    public List<Experience> GetExperience()
    {
        return Experiences;
    }
    public void Add(Experience experience)
    {
        Experiences.Add(experience);
    }
    public void Update(Experience Experience, int id)
    {
        var find = Experiences.Find(x => x.Id == Experience.Id);
        if (find != null)
        {
           
        }
    }
     public Experience GetExperienceById(int id)
    {
        var findId = Experiences.Find(x => x.Id == id);

        return Employees;
        
    }

    public void Delete(int id)
    {
        var findId = Experiences.Find(x => x.Id == id);
        if (findId == null) return;
        Experiences.Remove(findId);

    }
    public int Count()
    {
        return Experiences.Count();
    }
}
namespace CraftmanshipBlog.Models;

public class ExperienceItem
{
    public string Enterprise { get; set; }
    public string Date { get; set; }
    public string Poste { get; set; }
    public IDictionary<string, List<string>> Items { get; set; }
}
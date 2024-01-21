namespace CraftmanshipBlog.Models;

public class ExperienceItem
{
    public ExperienceItem()
    {
    }

    public ExperienceItem(string date, string enterprise, string poste, IDictionary<string, List<string>> items)
    {
        Date = date;
        Enterprise = enterprise;
        Poste = poste;
        Items = items;
    }

    public string Enterprise { get; set; }
    public string Date { get; set; }
    public string Poste { get; set; }
    public IDictionary<string, List<string>> Items { get; set; }
}
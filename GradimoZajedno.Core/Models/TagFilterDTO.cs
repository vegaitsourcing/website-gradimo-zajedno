using GradimoZajedno.Common.Extensions;

public class TagFilterDTO {
    public string Id {get;set;}

    public string Name {get;set;}

    public bool Checked {get;set;}

    public TagFilterDTO()
    {

    }

    public TagFilterDTO(string name, string slug, bool isChecked = false)
    {
        this.Name = name;
        this.Id = slug;
        this.Checked = isChecked;
    }
}
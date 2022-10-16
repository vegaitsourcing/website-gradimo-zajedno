
public class BuildingDTO {
    public BuildingDTO () {
        Tag = new List<BuildingTagDTO>();
        FilterTags = new List<string>();
    }

    public List<BuildingTagDTO> Tag {get;set;}

    public List<string> FilterTags {get;set;}

    public string Img {get;set;}
    public string Object {get;set;}

    public string Location {get; set;}

    public string Text {get;set;}

    public string NameLabel {get;set;}

    public string NameSurname {get;set;}

    public string PriceTag {get;set;}

    public string Price {get;set;}

    public string Btn {get;set;}

    public string Url {get;set;}
}
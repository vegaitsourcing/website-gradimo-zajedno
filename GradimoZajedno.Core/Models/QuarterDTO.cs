
using GradimoZajedno.Common.Extensions;

public class QuarterDTO {
    public QuarterDTO() {

    }

    public QuarterDTO(string name) {
        this.Name = name;
        this.Id = name.GenerateSlug();
    }

    public string Id {get;set;}

    public string Name {get;set;}

}
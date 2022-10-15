
public class SettlementDTO {
    
    public string FiltersBtn {get;set;}

    public string CloseBtn {get;set;}

    public List<QuarterDTO> FilterTop {get;set;}

    public List<TagFilterDTO> FilterBottom {get;set;}

    public List<BuildingDTO> Item {get;set;}

    public SettlementDTO()
    {
        FilterTop = new List<QuarterDTO>();
        FilterBottom = new List<TagFilterDTO>();
        Item = new List<BuildingDTO>();
    }
}

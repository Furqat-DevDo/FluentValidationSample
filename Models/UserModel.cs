namespace FluentValidationExample.Models;

public class UserModel
{
    public int  Id { get; set; }
    public string Eamil { get; set; }
    public required string Name { get; set; }
    public List<AdrressModel> Adrresses { get; set; }
}
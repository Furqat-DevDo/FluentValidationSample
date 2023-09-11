namespace FluentValidationExample.Entities;

public class User
{
    public int  Id { get; set; }
    public string Eamil { get; set; }
    public required string Name { get; set; }
    public List<Adrress> Adrresses { get; set; }
}
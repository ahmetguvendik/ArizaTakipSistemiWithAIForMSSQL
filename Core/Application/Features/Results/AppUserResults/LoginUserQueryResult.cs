namespace Application.Features.Results.AppUserResults;

public class LoginUserQueryResult
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Role { get; set; }
    public int? DepartmanId { get; set; }
}
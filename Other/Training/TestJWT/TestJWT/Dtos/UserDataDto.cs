namespace TestJWT.Dtos;

public class UserDataDto
{
    public string Email { get; set; }
    public string Role { get; set; }
    public Dictionary<string,bool> Permissions { get; set; }
}

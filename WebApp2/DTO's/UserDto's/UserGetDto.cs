namespace WebApp2.DTO_s.UserDto_s;

public class UserGetDto
{
    public string Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public List<UserGetDto> Friends { get; set; }
}

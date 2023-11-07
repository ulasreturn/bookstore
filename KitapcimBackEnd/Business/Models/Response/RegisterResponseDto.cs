
namespace Business.Models.Response;

public class RegisterResponseDto
{
    public int UserId { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string UserSurname { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public string Telephone { get; set; } = default!;
    public string Country { get; set; } = default!;
    public string City { get; set; } = default!;
    public int PostalCode { get; set; } = default!;
    public string AddressText { get; set; } = default!;
    public string AddressTitle { get; set; } = default!;
    public string UserPhoto { get; set; } = default!;
    public RegisterResponseDto User { get; set; }

}

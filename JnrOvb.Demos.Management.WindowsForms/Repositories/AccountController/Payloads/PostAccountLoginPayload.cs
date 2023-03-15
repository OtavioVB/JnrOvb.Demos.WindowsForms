namespace JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Payloads;

public sealed class PostAccountLoginPayload
{
    public PostAccountLoginPayload(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public string Username { get; set; }
    public string Password { get; set; }
}

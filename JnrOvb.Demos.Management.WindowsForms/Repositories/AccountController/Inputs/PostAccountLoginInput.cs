namespace JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Inputs;

public sealed class PostAccountLoginInput
{
    public PostAccountLoginInput(string jwtToken, string name, string lastName, string createdOn, List<string> notifications)
    {
        JwtToken = jwtToken;
        Name = name;
        LastName = lastName;
        CreatedOn = createdOn;
        Notifications = notifications;
    }

    public string JwtToken { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string CreatedOn { get; set; }
    public List<string> Notifications { get; set; }
}

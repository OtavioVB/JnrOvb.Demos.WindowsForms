using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Inputs;

namespace JnrOvb.Demos.Management.WindowsForms.Views.Navigation;

public partial class FormNavigation : Form
{
    public PostAccountLoginInput AccountLoginContent { get; set; }

    public FormNavigation(PostAccountLoginInput accountLoginContent)
    {
        AccountLoginContent = accountLoginContent;
        InitializeComponent();
    }
}

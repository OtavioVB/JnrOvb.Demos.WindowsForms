using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController;
using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Payloads;
using JnrOvb.Demos.Management.WindowsForms.Views.Navigation;

namespace JnrOvb.Demos.Management.WindowsForms.Views;

public partial class FormInitial : Form
{
    public FormInitial()
    {
        InitializeComponent();
    }

    private async void EnterInSystemLoginAccount(object sender, EventArgs e)
    {
        var response = 
            await new PostAccountLogin().LoginAccountAsync(new PostAccountLoginPayload(textBoxUsername.Text, textBoxPassword.Text));

        if (response.HasDone == false)
        {
            MessageBox.Show("As credenciais inseridas são inválidas!");
        }
        else
        {
            if (response.Input is null)
                throw new Exception("Input has returned null.");

            var formNavigation = new FormNavigation(response.Input);
            MessageBox.Show("Login realizado com sucesso!");
            this.Hide();
            this.Controls.Clear();
            formNavigation.Show();
        }
    }
}

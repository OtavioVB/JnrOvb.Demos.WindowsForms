using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Inputs;
using JnrOvb.Demos.Management.WindowsForms.Views.FormOfPaymentContext;
using JnrOvb.Demos.Management.WindowsForms.Views.ProductContext;
using JnrOvb.Demos.Management.WindowsForms.Views.StorageChangesContext;

namespace JnrOvb.Demos.Management.WindowsForms.Views.Navigation;

public partial class FormNavigation : Form
{
    private Form? ActivatedForm { get; set; }

    public PostAccountLoginInput AccountLoginContent { get; set; }

    public FormNavigation(PostAccountLoginInput accountLoginContent)
    {

        AccountLoginContent = accountLoginContent;
        InitializeComponent();
    }

    private void ButtonRedirectToProductManagement(object sender, EventArgs e)
    {
        OpenChildForm(new FormProductMain(AccountLoginContent));
    }

    private void OpenChildForm(Form childForm)
    {
        if (ActivatedForm is not null)
            ActivatedForm.Dispose();

        ActivatedForm = childForm;
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        this.panelContent.Controls.Add(childForm);
        this.panelContent.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
    }

    private void FormNavigation_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void RedirectFormStorageChange(object sender, EventArgs e)
    {
        OpenChildForm(new FormStorageChangeMain());
    }

    private void RedirectFormFormOfPayment(object sender, EventArgs e)
    {
        OpenChildForm(new FormFormOfPaymentMain());
    }
}

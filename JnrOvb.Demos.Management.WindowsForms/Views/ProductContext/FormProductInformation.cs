using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController;
using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Inputs;

namespace JnrOvb.Demos.Management.WindowsForms.Views.ProductContext;

public partial class FormProductInformation : Form
{
    public GetProductGetProductsByPaginationInput ProductInformation { get; set; }

    public FormProductInformation(GetProductGetProductsByPaginationInput productInformation)
    {
        ProductInformation = productInformation;
        InitializeComponent();
        labelProductIdentifier.Text = productInformation.Identifier.ToString().ToUpper();
    }
}

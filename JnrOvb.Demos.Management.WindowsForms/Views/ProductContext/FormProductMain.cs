using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Inputs;
using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController;
using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Inputs;
using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Payloads;

namespace JnrOvb.Demos.Management.WindowsForms.Views.ProductContext;

public partial class FormProductMain : Form
{
    public PostAccountLoginInput AccountLoginContent { get; set; }
    public int ActualPage { get; set; } = 1;

    public FormProductMain(PostAccountLoginInput accountLoginContent)
    {
        AccountLoginContent = accountLoginContent;
        InitializeComponent();
        SynchronizeTableToApi();
    }

    public async void SynchronizeTableToApi()
    {
        var response = await new GetProductGetProductsByPagination().GetProductsByPaginationAsync(ActualPage, AccountLoginContent.JwtToken);

        if (response.HasDone == false)
        {
            MessageBox.Show("Não foi possível encontrar produtos no banco de dados.");
            return;
        }

        if (response.HasDone == true && response.Products is null)
            throw new Exception("Products is null is not expected. Contact support.");

        listViewProducts.Items.Clear();
        foreach (var product in response.Products!)
        {
            var productInformation = new string[]
            {
                product.Code,
                product.Name,
                product.Description,
                product.InventoryQuantity.ToString(),
                product.CreatedOn,
                product.LastModifiedOn,
                product.Identifier.ToString(),
                product.IdentifierAccountCreatedBy.ToString(),
                product.IdentifierAccountLastModifiedBy.ToString()
            };

            var item = new ListViewItem(productInformation);
            listViewProducts.Items.Add(item);
        }
    }

    private void NextTable(object sender, MouseEventArgs e)
    {
        if (listViewProducts.Items.Count < 25)
        {
            MessageBox.Show("Não há mais produtos a serem buscados.");
            return;
        }

        ActualPage++;
        SynchronizeTableToApi();
    }

    private void BackTable(object sender, EventArgs e)
    {
        if (ActualPage <= 1)
        {
            MessageBox.Show("Não é possível voltar mais na paginação");
            return;
        }

        ActualPage--;
        SynchronizeTableToApi();
    }

    private void InitialTable(object sender, EventArgs e)
    {
        if (ActualPage > 1)
        {
            ActualPage = 1;
            SynchronizeTableToApi();
        }
    }

    private async void PostCreateProductAsync(object sender, EventArgs e)
    {
        var response = 
            await new PostProductCreate().CreateProductPostAsync(
                new PostProductCreatePayload(textBoxProductName.Text, textBoxProductDescription.Text), AccountLoginContent.JwtToken);

        if (response == false)
            MessageBox.Show("Não foi possível criar o produto, verifique se o texto inserido é válido.");

        if (response == true)
        {
            textBoxProductName.Text = string.Empty;
            textBoxProductDescription.Text = string.Empty;
            MessageBox.Show("Produto cadastrado com sucesso!");
        }
    }

    private void DoubleClickToViewInformationAboutProduct(object sender, EventArgs e)
    {
        if (listViewProducts.SelectedItems.Count == 1)
        {
            var form = new FormProductInformation(new GetProductGetProductsByPaginationInput(
                identifier: new Guid(listViewProducts.SelectedItems[0].SubItems[6].Text),
                code: listViewProducts.SelectedItems[0].SubItems[0].Text,
                name: listViewProducts.SelectedItems[0].SubItems[1].Text,
                description: listViewProducts.SelectedItems[0].SubItems[2].Text,
                inventoryQuantity: Convert.ToInt32(listViewProducts.SelectedItems[0].SubItems[3].Text),
                createdOn: listViewProducts.SelectedItems[0].SubItems[4].Text,
                identifierAccountCreatedBy: new Guid(listViewProducts.SelectedItems[0].SubItems[7].Text),
                lastModifiedOn: listViewProducts.SelectedItems[0].SubItems[5].Text,
                identifierAccountLastModifiedBy: new Guid(listViewProducts.SelectedItems[0].SubItems[8].Text)));
            form.ShowDialog();
        }
    }
}

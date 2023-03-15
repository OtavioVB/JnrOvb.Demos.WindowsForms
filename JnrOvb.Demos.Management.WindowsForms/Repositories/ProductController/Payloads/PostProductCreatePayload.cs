namespace JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Payloads;

public sealed class PostProductCreatePayload
{
    public PostProductCreatePayload(string productName, string productDescription)
    {
        ProductName = productName;
        ProductDescription = productDescription;
    }

    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
}

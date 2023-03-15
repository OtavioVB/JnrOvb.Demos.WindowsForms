namespace JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Inputs;

public sealed class GetProductGetProductsByPaginationInput
{
    public GetProductGetProductsByPaginationInput(Guid identifier, string code, string name, 
        string description, int inventoryQuantity, string createdOn, Guid identifierAccountCreatedBy, 
        string lastModifiedOn, Guid identifierAccountLastModifiedBy)
    {
        Identifier = identifier;
        Code = code;
        Name = name;
        Description = description;
        InventoryQuantity = inventoryQuantity;
        CreatedOn = createdOn;
        IdentifierAccountCreatedBy = identifierAccountCreatedBy;
        LastModifiedOn = lastModifiedOn;
        IdentifierAccountLastModifiedBy = identifierAccountLastModifiedBy;
    }

    public Guid Identifier { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int InventoryQuantity { get; set; }
    public string CreatedOn { get; set; }
    public Guid IdentifierAccountCreatedBy { get; set; }
    public string LastModifiedOn { get; set; }
    public Guid IdentifierAccountLastModifiedBy { get; set; }
}

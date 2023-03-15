using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Payloads;
using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Payloads;
using JnrOvb.Demos.Management.WindowsForms.Settings;
using System.Net;

namespace JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController;

public sealed class PostProductCreate
{
    public string Url = ApiSettings.UrlBase + "api/v1/product/create";

    public async Task<bool> CreateProductPostAsync(PostProductCreatePayload payload, string jwt)
    {
        using var httpClient = HttpClientFactory.Create();
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", $"{jwt}");
        var httpClientResponse = await httpClient.PostAsJsonAsync(Url, payload);

        if (httpClientResponse.StatusCode == HttpStatusCode.InternalServerError)
            throw new Exception($"{Url} Internal Server Error. Contate o suporte.");

        if (httpClientResponse.StatusCode == HttpStatusCode.Forbidden)
            throw new Exception($"{Url} Model State Invalid.");

        if (httpClientResponse.StatusCode == HttpStatusCode.Unauthorized)
            throw new Exception("Feche o aplicativo e abre novamente! Token expirado.");

        if (httpClientResponse.StatusCode == HttpStatusCode.Created)
            return true;

        return false;
    }
}

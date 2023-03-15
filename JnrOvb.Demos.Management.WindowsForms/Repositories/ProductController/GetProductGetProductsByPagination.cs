using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Inputs;
using JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController.Payloads;
using JnrOvb.Demos.Management.WindowsForms.Settings;
using System.Net;

namespace JnrOvb.Demos.Management.WindowsForms.Repositories.ProductController;

public sealed class GetProductGetProductsByPagination
{
    public string Url = ApiSettings.UrlBase + "api/v1/product/getproductsbypagination?page=";

    public async Task<(bool HasDone, List<GetProductGetProductsByPaginationInput>? Products)> GetProductsByPaginationAsync(int page, string jwt)
    {
        using var httpClient = HttpClientFactory.Create();
        httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", $"{jwt}");
        var httpClientResponse = await httpClient.GetAsync(Url + page);

        if (httpClientResponse.StatusCode == HttpStatusCode.InternalServerError)
            throw new Exception($"{Url} Internal Server Error. Contate o suporte.");

        if (httpClientResponse.StatusCode == HttpStatusCode.Forbidden)
            throw new Exception($"{Url} Model State Invalid.");

        if (httpClientResponse.StatusCode == HttpStatusCode.OK)
            return (true, await httpClientResponse.Content.ReadAsAsync<List<GetProductGetProductsByPaginationInput>>());

        return (false, null);
    }
}

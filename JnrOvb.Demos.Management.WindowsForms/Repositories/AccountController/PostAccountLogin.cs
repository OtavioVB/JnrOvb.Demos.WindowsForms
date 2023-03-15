using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Inputs;
using JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController.Payloads;
using JnrOvb.Demos.Management.WindowsForms.Settings;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;

namespace JnrOvb.Demos.Management.WindowsForms.Repositories.AccountController;

public class PostAccountLogin
{
    public string Url = ApiSettings.UrlBase + "api/v1/account/login";

    public async Task<(bool HasDone, PostAccountLoginInput? Input)> LoginAccountAsync(PostAccountLoginPayload payload)
    {
        using var httpClient = HttpClientFactory.Create();
        var httpClientResponse = await httpClient.PostAsJsonAsync<PostAccountLoginPayload>(Url, payload);

        if (httpClientResponse.StatusCode == HttpStatusCode.Forbidden)
            throw new Exception($"{Url} Post Account Login Model State Invalid.");

        if (httpClientResponse.StatusCode == HttpStatusCode.NotFound)
            return (false, null);

        var response = await httpClientResponse.Content.ReadAsAsync<PostAccountLoginInput>();

        if (response is null)
            throw new Exception($"{Url} Post Account Login response is null.");

        return (true, response);
    }
}

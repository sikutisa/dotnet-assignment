namespace frontend.Clients;

public interface IApiAppClient
{
    Task<string> SummariseAsync(string youtubeLink, string videoLanguageCode, string summaryLanguageCode);
}

public class ApiAppClient : IApiAppClient
{
    public async Task<string> SummariseAsync(string youTubeLinkUrl, string videoLanguageCode, string summaryLanguageCode)
    {
        throw new NotImplementedException();
    }
}
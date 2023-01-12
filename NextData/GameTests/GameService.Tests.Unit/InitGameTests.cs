using System.Net;
using FluentAssertions;
using System.Net.Http.Headers;
using Newtonsoft.Json;
namespace GameService.Tests.Unit;

public class InitGameTests
{
    private readonly HttpClient _client;
    private HttpContent _body;

    public InitGameTests()
    {
        InitGameReq initGame = new InitGameReq()
        {
            IdPlayer = 3,
            Token = "#ND_TEST_TOKEN_012568",
            IdGame = 3
        };
        _body = new StringContent(JsonConvert.SerializeObject(initGame));
        
        _client = new HttpClient();
        
        _body.Headers.ContentType = new MediaTypeHeaderValue("application/json"); 
    }

    [Fact]
    public async Task InitFirstGame()
    {
        string idGame = "003";
        string envUrl = "dev.next-data.cz:8";
        string url = $"https://{envUrl}{idGame}/Game{idGame}Service.svc/InitGame";
        var response = await _client.PostAsync(url,_body);
        var responseBody = await response.Content.ReadAsStringAsync();
        //var result = JsonConvert.DeserializeObject<CurrencyDetails>(responseBody);
        
        
        response.StatusCode.Should().Be(HttpStatusCode.OK);
        
    }
    
    
}
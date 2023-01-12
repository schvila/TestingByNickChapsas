using System.Net;
using FluentAssertions;
using System.Net.Http.Headers;

namespace GameService.Tests.Unit;


public class CheckServicePostTests
{
    private readonly HttpClient _client;
    private HttpContent _body;
    private static int _delay = 1000;

    public CheckServicePostTests()
    {
        
        _body = new StringContent("");
        
        _client = new HttpClient();
        
        _body.Headers.ContentType = new MediaTypeHeaderValue("application/json"); 
    }

    [Theory]
    [MemberData(nameof(AllGames))]
    public async Task NextDataDev(string idGame)
    {
        await Task.Delay(_delay);
        string envUrl = "dev.next-data.cz:8";
        string url = $"https://{envUrl}{idGame}/Game{idGame}Service.svc/CheckService";
        var response = await _client.PostAsync(url,_body);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }
    [Theory]
    [MemberData(nameof(SazkaGames))]
    //[InlineData("050")]
    public async Task SazkaStage(string idGame)
    {
        string envUrl = "stagesazka.adell-trading.cz/G";
        string url = $"https://{envUrl}{idGame}/Game{idGame}Service.svc/CheckService";
        var response = await _client.PostAsync(url,_body);
        response.StatusCode.Should().Be(HttpStatusCode.OK);
    }

    public static IEnumerable<object[]> AllGames =>
        new List<object[]>
        {
            new object[] { "003" },
            new object[] { "008" },
            new object[] { "009" },
            new object[] { "010" },
            new object[] { "012" },
            new object[] { "016" },
            new object[] { "017" },
            new object[] { "018" },
            new object[] { "019" },
            new object[] { "029" },
            new object[] { "030" },
            new object[] { "031" },
            new object[] { "032" },
            new object[] { "033" },
            new object[] { "034" },
            new object[] { "035" },
            new object[] { "036" },
            new object[] { "037" },
            new object[] { "038" },
            new object[] { "039" },
            new object[] { "040" },
            new object[] { "041" },
            new object[] { "042" },
            new object[] { "043" },
            new object[] { "044" },
            new object[] { "045" },
            new object[] { "047" },
            new object[] { "048" },
            new object[] { "049" },
            new object[] { "050" },
            new object[] { "051" },
            new object[] { "052" },
            new object[] { "053" },
            new object[] { "054" },
            new object[] { "055" },
            new object[] { "056" },
            new object[] { "057" },
            new object[] { "058" },
            new object[] { "101" },
            new object[] { "102" },
            new object[] { "105" },
            new object[] { "106" },
        };
    public static IEnumerable<object[]> SazkaGames =>
        new List<object[]>
        {
            new object[] { "003" },
            new object[] { "008" },
            new object[] { "009" },
            new object[] { "010" },
            new object[] { "012" },
            new object[] { "016" },
            new object[] { "017" },
            new object[] { "018" },
            new object[] { "019" },
            //new object[] { "029" },
            new object[] { "030" },
            new object[] { "031" },
            new object[] { "032" },
            new object[] { "033" },
            new object[] { "034" },
            new object[] { "035" },
            // new object[] { "036" },
            // new object[] { "037" },
            // new object[] { "038" },
            new object[] { "039" },
            // new object[] { "040" },
            // new object[] { "041" },
            // new object[] { "042" },
            // new object[] { "043" },
            // new object[] { "044" },
            // new object[] { "045" },
            // new object[] { "047" },
            // new object[] { "048" },
            // new object[] { "049" },
            // new object[] { "050" },
            // new object[] { "051" },
            // new object[] { "052" },
            // new object[] { "053" },
            // new object[] { "054" },
            // new object[] { "055" },
            // new object[] { "056" },
            // new object[] { "057" },
            // new object[] { "058" },
            new object[] { "101" },
            new object[] { "102" },
            new object[] { "105" },
            new object[] { "106" },
        };
}
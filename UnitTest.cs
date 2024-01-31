using NUnit.Framework;

namespace FirstDrone;

public class UnitTest
{
    private HttpClient _httpClient;

    [SetUp]
    public void Setup()
    {
        _httpClient = new HttpClient();
    }
    
    [Test]
    public async Task Test1()
    {
        var expected = "Hello World";
        
        HttpResponseMessage response = await _httpClient.GetAsync("http://localhost:5000/Hello");
        
        var content = await response.Content.ReadAsStringAsync();
        
        Assert.That(content,Is.EqualTo(expected));
    }
}
namespace HTTP;
class Program
{
    static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();

        using (HttpResponseMessage resp = await client.GetAsync("https://rickandmortyapi.com/"))
        {
            string responseBody = await resp.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
        }
        }
        
}


/*
{"id":733,"name":"Kathy Ireland","status":"Alive","species":"Human","type":"","gender":"Female","origin":
{"name":"Earth (Replacement Dimension)","url":"https://rickandmortyapi.com/api/location/20"},"location":
{"name":"Earth (Replacement Dimension)","url":"https://rickandmortyapi.com/api/location/20"},
"image":"https://rickandmortyapi.com/api/character/avatar/733.jpeg","episode":["https://rickandmortyapi.com/api/episode/45"],
"url":"https://rickandmortyapi.com/api/character/733","created":"2021-10-17T12:00:07.076Z"}
*/
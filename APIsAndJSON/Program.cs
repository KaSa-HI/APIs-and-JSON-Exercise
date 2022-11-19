using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();

            string kanyeURL = string.Empty;
            string kanyeResponse = string.Empty;
            string kanyeQuote = string.Empty;

            string ronURL = string.Empty;
            string ronResponse = string.Empty; ;
            string ronQuote = string.Empty;

            for (int i = 0; i < 5; i++)
            {
                 kanyeURL = "https://api.kanye.rest";
                 kanyeResponse = client.GetStringAsync(kanyeURL).Result;

                 kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
                //Console.WriteLine(kanyeResponse);
                //Console.WriteLine(kanyeQuote);
                Console.WriteLine($"Kanye says: \"{kanyeQuote}\"");



                 ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
                 ronResponse = client.GetStringAsync(ronURL).Result;

                 ronQuote = JArray.Parse(ronResponse).ToString().Replace("[", "").Replace("]", "").Trim();
                //Console.WriteLine(ronResponse);
                //Console.WriteLine(ronQuote);
                Console.WriteLine($"Ron Swanson says: {ronQuote}");
                Console.WriteLine();


            }
        }
    }
}

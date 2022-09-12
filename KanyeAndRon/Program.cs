using Newtonsoft.Json.Linq;

namespace KanyeAndRon
{
        class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine(kanyeQuote);

            var ronSwansonURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronSwansonResponse = client.GetStringAsync(ronSwansonURL).Result;
            var ronSwansonQuote = JArray.Parse(ronSwansonResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine(ronSwansonQuote);




        }
    }
}
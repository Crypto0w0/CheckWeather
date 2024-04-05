using System.Net;
using System.Net.Sockets;
using System.Text;

class CheckWeather
{
    static async Task Main()
    {
        try
        {
            Console.WriteLine("Enter the city: ");
            string city = Console.ReadLine();

            using (HttpClient client = new HttpClient())
            {
                string url = $"https://weather.com/weather/tenday/l/{city}";

                HttpResponseMessage res = await client.GetAsync(url);
                string rbody = await res.Content.ReadAsStringAsync();
                Console.WriteLine("The weather: " + rbody);
            }
        }
        catch (WebException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

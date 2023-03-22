using BAJK.EAutoSerwis.solution.xLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;
using System.Text.Json;
using System.Xml.Linq;
using System.Runtime.ConstrainedExecution;


namespace BAJK.EAutoSerwis.REST.RESTApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task task = CallWebService();

            task.Wait();

            Console.ReadLine();
        }
        public static async Task CallWebService()
        {
            HttpClient httpClient = new HttpClient();

            string requestUri = String.Format("http://{0}:{1}/Car/GetSameBrands?name={2}", "localhost", 5000, "Opel");

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);

            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            httpClient.Dispose();

            httpResponseMessage.EnsureSuccessStatusCode();

            string httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync();

            CarDto[] carsData = JsonSerializer.Deserialize<CarDto[]>(httpResponseContent);
            Car[] cars = carsData.Select(carDto => new Car(carDto.year, carDto.model, carDto.lastCheckUp)).ToArray();

            Console.WriteLine("Found {0} cars", "Opel");
            foreach (Car car in cars)
                Console.WriteLine("Model: {0} Year: {1}, LastCheckUp: {2}", car.Model, car.Year, car.LastCheckUp);
        }

        public static void Main_(string[] args)
        {
            Console.WriteLine("Starting ...");

            Debug.Assert(condition: args.Length >= 2);

            try
            {
                string webServiceHost = args[0];
                ushort webServicePort = ushort.Parse(args[1]);

                Task<Car[]> getCarsTask = GetCars(webServiceHost, webServicePort, "VW");
                getCarsTask.Wait();
                Car[] cars = getCarsTask.Result;

                foreach (Car car in cars)
                    Console.WriteLine(car.Model);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Finished.");
            }
        }

        private static async Task<Car[]> GetCars(string webServiceHost, ushort webServicePort, string searchText)
        {
            string webServiceUri = String.Format("https://{0}:{1}/Car/GetSameBrands?name={2}", webServiceHost, webServicePort, searchText);

            string jsonResponseContent = await CallWebService(webServiceUri);

            Car[] cars = ConvertJson(jsonResponseContent);

            return cars;
        }

        public static async Task<string> CallWebService(string webServiceUri)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, webServiceUri);

            httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

            httpClient.Dispose();

            httpResponseMessage.EnsureSuccessStatusCode();

            string httpResponseContent = await httpResponseMessage.Content.ReadAsStringAsync();
            return httpResponseContent;
        }

        public static Car[] ConvertJson(string json)
        {
            CarDto[] carsData = JsonSerializer.Deserialize<CarDto[]>(json);
            Car[] cars = carsData.Select(carDto => new Car(carDto.year, carDto.model, carDto.lastCheckUp)).ToArray();

            return cars;
        }
    }
}

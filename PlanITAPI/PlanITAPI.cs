using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace PlanITAPIAssessment
{
    class PlanITAPI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write($"Pets count is : { GetPetCount()}");

        }

        public static int GetPetCount()
        {
            try
            {
                string url = $"https://petstore.swagger.io/v2/pet/findByStatus?status=available";

                var request = WebRequest.Create(url);

                request.Method = "GET";
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            string data = reader.ReadToEnd();
                            var pets = JsonConvert.DeserializeObject<Pet[]>(data);
                            return pets.Length;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public class Pet
        {
            public string name { get; set; }
        }


    }








}

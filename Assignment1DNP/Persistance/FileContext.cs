using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Assignment1DNP.Data;
using Models;

namespace Assignment1DNP.Persistance
{
    public class FileContext : IAdultData
        
    {
        private readonly string adultsFile = "adults.json";
        private readonly string familiesFile = "families.json";
        public IList<Adult> Adults { get; private set; }
        public IList<Family> Families { get; private set; }

        public FileContext()
        {

            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
            Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
        }



        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(s))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {

            var jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (var outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
            
        }

        public IList<Adult> getAdults()
        {
            IList<Adult> tmp = new List<Adult>(Adults);
            return tmp;
        }

        public void AddAdult(Adult adult)
        {
           
            int max = Adults.Max(adult => adult.Id);
            adult.Id = (++max);
            Adults.Add(adult);
            SaveChanges();
        }

        public void RemoveAdult(int adultId)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Adult Get(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}

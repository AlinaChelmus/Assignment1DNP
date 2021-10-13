using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace Assignment1DNP.Data
{
    public class AdultJsonData: IAdultData
    {
        private string adultFile = "adults.json";
        
        private IList<Adult> adults;
        
        private IList<User> users { get;  }

        public AdultJsonData()
        {
            if (!File.Exists(adultFile))
            {
                //Seed();
                WriteAdultsToFile();
            }
            else
            {
                string content = File.ReadAllText(adultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }
        
       /* private void Seed()
        {
            Adult[] ad =
            {
                new Adult
                {
                    Id = 1,
                    FirstName = "Alina",
                    LastName = "chelmus",
                    HairColor = "Black",
                    EyeColor = "Brown",
                    Age = 34,
                    Weight = 70,
                    Height = 155,
                    Sex = "F",

                },

                new Adult
                {
                    Id = 2,
                    FirstName = "Teo",
                    LastName = "Catana",
                    HairColor = "Blonde",
                    EyeColor = "Blue",
                    Age = 25,
                    Weight = 72,
                    Height = 178,
                    Sex = "M",
                    JobTitle = null,
                    
                },
            };
            adults = ad.ToList();
        }*/
        public IList<Adult> getAdults()
        {
            List<Adult> tmp = new List<Adult>(adults);
            return tmp;
        }

        public void AddAdult(Adult adult)
        {
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            WriteAdultsToFile();
        }

        public void RemoveAdult(int adultId)
        {
            Adult toRemove = adults.First(t => t.Id == adultId);
            adults.Remove(toRemove);
            WriteAdultsToFile();
        }

        private void WriteAdultsToFile()
        {
            string adultAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile,adultAsJson);
        }

        public void Update(Adult adult)
        {
            Adult toUpdate = adults.First(t => t.Id == adult.Id);
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.Sex = adult.Sex;
            toUpdate.JobTitle = adult.JobTitle;
            
            WriteAdultsToFile();
        }

        public Adult Get(int id)
        {
            return adults.FirstOrDefault(t => t.Id == id);
        }
    
    }
}
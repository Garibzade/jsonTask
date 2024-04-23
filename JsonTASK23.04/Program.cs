using Newtonsoft.Json;
using System.Xml.Linq;
namespace JsonTASK23._04
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Add("Garib");
            //    Add("ali");
            //    Add("emil");
            //    Add("samir");
            Add("sahin");

            //Delete("Garib");
            //Console.WriteLine(Searc("ali"));
           
            
        }
        public static List<string> Deserialize(string path)
        {
            string result;


            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }
            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
        public static void Serialize<T>(string path, T obj)
        {
            string result = JsonConvert.SerializeObject(obj);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(result);
            }
        }
        public static void Add(string name)
        {
            string path = @"C:\Users\Qarib\Desktop\c#\JsonTASK23.04\Files\json1.json";
            List<string> names = Deserialize(path);
            names.Add(name);

            Serialize<List<string>>(path, names);

        }
        public static void Delete(string name)
        {
            string path = @"C:\Users\Qarib\Desktop\c#\JsonTASK23.04\Files\json1.json";
            List<string> names = Deserialize(path);
            if (names.Contains(name)) 
            {
                names.Remove(name);

                Console.WriteLine($"{ name}-bu isdifadeci silindi");
            }
            else { Console.WriteLine("bele isdirakci tapilmadi"); }

            Serialize<List<string>>(path, names);

        }
        public static bool Searc(string name)
        {
            string path = @"C:\Users\Qarib\Desktop\c#\JsonTASK23.04\Files\json1.json";
            List<string> names = Deserialize(path);
            int count = 0;
           if (names.Contains(name)) { Console.WriteLine($"{count++}- sayi qeder adam var"); return true;  }
           else { return false; }
          Serialize<List<string>>(path, names);


        }


    }
}
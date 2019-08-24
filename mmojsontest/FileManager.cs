using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace mmojsontest
{
    class FileManager
    {
        public static string[] LoadFile(string Path)
        {
            if (File.Exists(Path))
            {
                return File.ReadAllLines(Path);
            }
            throw new FileNotFoundException();
        }

        public static Player LoadPlayer(int SaveNo)
        {
            string Path = Environment.CurrentDirectory + "/SaveData/Data" + SaveNo + ".json";
            if (File.Exists(Path))
            {
                string Json = string.Join("\n", LoadFile(Path));
                return JsonConvert.DeserializeObject<Player>(Json);
            }
            throw new FileNotFoundException();
        }
    }
}

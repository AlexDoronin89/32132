using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tariff.model.Tools
{
    class Loader
    {
        public List<Tariff> LoadTariffs()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileInfo fileInf = new FileInfo("tariffs.itp");
            if (fileInf.Exists)
            {
                using (FileStream stream = new FileStream("tariffs.itp", FileMode.Open))
                    return (List<Tariff>)formatter.Deserialize(stream);
            }
            else
            {
                return new List<Tariff>();
            }
        }
    }
}

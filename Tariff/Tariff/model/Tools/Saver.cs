using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Tariff.model.Tools
{
    class Saver
    {
        public void Save(TariffData data)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream("tariffs.itp", FileMode.OpenOrCreate))
                formatter.Serialize(stream, data.GetTariffs());
        }
    }
}

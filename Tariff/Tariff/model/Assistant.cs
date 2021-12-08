using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tariff.model
{
    class Assistant
    {
        public TariffData TariffData { get; private set; }

        public Assistant(TariffData tariffData)
        {
            TariffData = tariffData;
        }

        public void ChooseRightTariff(int messages, int gygabytes, int minutes)
        {
            IReadOnlyList<IReadOnlyTariff> tariffs = TariffData.GetTariffs();

            foreach (var item in tariffs)
            {
                if (true)
                {

                }
            }
        }
    }
}

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

        public event Action<IReadOnlyList<IReadOnlyTariff>> ChoseRightTariff;

        public Assistant(TariffData tariffData)
        {
            TariffData = tariffData;
        }

        public List<IReadOnlyTariff> ChooseRightTariff(int gygabytes, int minutes, int messages)
        {
            IReadOnlyList<IReadOnlyTariff> tariffs = TariffData.GetTariffs();
            List<IReadOnlyTariff> filtredTariffs = new List<IReadOnlyTariff>();
            foreach (var item in tariffs)
            {
                if ((gygabytes < item.Gygabytes && gygabytes == item.Gygabytes || gygabytes > item.Gygabytes ) &&
                    (minutes < item.Minutes && minutes == item.Minutes || minutes > item.Minutes) &&
                    (messages < item.Messages && messages == item.Messages || messages > item.Messages))
                {
                    filtredTariffs.Add(item);
                }
                else if ((gygabytes > item.Gygabytes && gygabytes == item.Gygabytes || gygabytes < item.Gygabytes) &&
                    (minutes > item.Minutes && minutes == item.Minutes || minutes < item.Minutes) &&
                    (messages > item.Messages && messages == item.Messages || messages < item.Messages))
                {
                    filtredTariffs.Add(item);
                }
            }
            ChoseRightTariff?.Invoke(filtredTariffs);
            return filtredTariffs;
        }
    }
}

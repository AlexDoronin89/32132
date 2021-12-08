using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Tariff.model.Tools;

namespace Tariff.model
{
    [Serializable]
    class TariffData
    {
        private List<Tariff> _tariffs;

        public event Action UpdatedTariff;
        public event Action RemovedTariff;
        public event Action AddedTariff;
        public event Action<string, string> GettingAccess;

        public TariffData()
        {
            Loader loader = new Loader();

            _tariffs = loader.LoadTariffs();
        }

        public void Save()
        {
            Saver saver = new Saver();
            saver.Save(this);
        }

        public void AddTariff(int gygabytes, int minutes, int messages, int price, string name)
        {
            _tariffs.Add(new Tariff(name, minutes, gygabytes, messages, price));
            AddedTariff?.Invoke();
        }

        public void RemoveTariff(int id)
        {
            foreach (var item in _tariffs)
            {
                if (id == item.Id)
                {
                    _tariffs.Remove(item);
                    RemovedTariff?.Invoke();
                    return;
                }
            }
        }

        public void UpdateTariff(int ID, int price, string name, int gygabytes, int messages, int minutes)
        {
            int index = FindTariffById(ID);

            if (index != -1)
            {
                _tariffs[index].Update(price, minutes, gygabytes, messages, name);
                UpdatedTariff?.Invoke();
            }
        }

        public void AccessAdminData(string login, string password)
        {
            StreamReader streamReaderPassword = new StreamReader("Password.txt");
            StreamReader streamReaderLogin = new StreamReader("Login.txt");
            if (streamReaderPassword.ReadLine() == password && streamReaderLogin.ReadLine() == login)
            {
                GettingAccess?.Invoke(login, password);
            }
        }

        public int FindTariffById(int id)
        {
            return _tariffs.IndexOf(_tariffs.First(_tariffs => _tariffs.Id == id));
        }

        public IReadOnlyList<IReadOnlyTariff> GetTariffs() => _tariffs;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tariff.model;

namespace Tariff
{
    public partial class FormTariffAssistant : Form
    {
        public event Func<IReadOnlyList<IReadOnlyTariff>> GettingAllTariffs;

        public event Action Saving;

        public FormTariffAssistant()
        {
            InitializeComponent();
        }

        private void FormTariffAssistant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Saving?.Invoke();
        }

        public void RefreshListBox()
        {
            listBoxTariffs.DataSource = null;
            listBoxTariffs.DataSource = GettingAllTariffs?.Invoke();
            listBoxTariffs.SelectedIndex = -1;
        }

        private void listBoxTariffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTariffs.SelectedIndex != -1)
            {
                if (listBoxTariffs.SelectedItem is Tariff tariff)
                {
                    RefreshTextboxData(tariff);
                }
            }
        }

        private void RefreshTextboxData(IReadOnlyTariff Tariff)
        {
            textBoxGygabytes.Text = Tariff.Gygabytes.ToString();
            textBoxMinutes.Text = Tariff.Minutes.ToString();
            textBoxMessages.Text = Tariff.Messages.ToString();
            textBoxPrice.Text = Tariff.Price.ToString();
        }
    }
}

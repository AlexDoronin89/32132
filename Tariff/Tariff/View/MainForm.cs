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
        public event Action Saving;

        public event Action<int,int,int> ChoosingRightTariff;

        public FormTariffAssistant()
        {
            InitializeComponent();
        }

        private void FormTariffAssistant_FormClosing(object sender, FormClosingEventArgs e)
        {
            Saving?.Invoke();
        }

        public void RefreshListBox(IReadOnlyList<IReadOnlyTariff> tariffs)
        {
            listBoxTariffs.DataSource = null;
            listBoxTariffs.DataSource = tariffs;
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

        private void FormTariffAssistant_Load(object sender, EventArgs e)
        {

        }

        private void trackBarGygabytes_Scroll(object sender, EventArgs e)
        {
            labelGygaValue.Text = trackBarGygabytes.Value.ToString();
        }

        private void trackBarMinutes_Scroll(object sender, EventArgs e)
        {
            labelMinValue.Text = trackBarMinutes.Value.ToString();
        }

        private void trackBarMessages_Scroll(object sender, EventArgs e)
        {
            labelSMSValue.Text = trackBarMessages.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChoosingRightTariff?.Invoke(trackBarGygabytes.Value,trackBarMinutes.Value,trackBarMessages.Value);
        }
    }
}

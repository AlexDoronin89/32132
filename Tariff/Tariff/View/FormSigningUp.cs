using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tariff.View
{
    public partial class FormSigningUp : Form
    {
        public event Action OpeningMainForm;
        public event Action<string, string> CheckingInputData;
        public FormSigningUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            OpeningMainForm?.Invoke();
        }

        private void buttonAdminSignUp_Click(object sender, EventArgs e)
        {
            CheckingInputData?.Invoke(textBoxLogin.Text, textBoxPassword.Text);
        }

        private void FormSigningUp_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

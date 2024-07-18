using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kendiuygform2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ad:" + textBoxad.Text + " " + "Soyad: " + textBoxsoyad.Text + " " + "T.C." + maskedTextBoxtc.Text + " " + "yaş:" + textBoxyaş.Text + " " +
                "Doğum Tarihi:" + dateTimePicker1.Text + " " + " Anne adı:" + textBoxanaadı.Text + " " + " Baba adı:" + textBoxbabaadı.Text + " " +
                " Öğrenim:" + comboBox1.Text + " " + " Öğrenim gördüğü kurum adı:" + textBoxkurumadı.Text + " " + " Tel no:" + maskedTextBoxtelno.Text);

        }
    }
}

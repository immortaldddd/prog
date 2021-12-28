using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfITServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTYsl_Click(object sender, EventArgs e)
        {
            Yslyga form = new Yslyga();
            form.ShowDialog();
        }

        private void BTSotr_Click(object sender, EventArgs e)
        {
            Sotr form = new Sotr();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zakaz form = new Zakaz();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prifITServisDataSet.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.prifITServisDataSet.Zakaz);


        }

        private void BTIzmen_Click(object sender, EventArgs e)
        {
            IzmenZakaz form = new IzmenZakaz();
            form.ShowDialog();
        }

        private void BRDelet_Click(object sender, EventArgs e)
        {
            ZakazDelete form = new ZakazDelete();
            form.ShowDialog();
        }
    }
}

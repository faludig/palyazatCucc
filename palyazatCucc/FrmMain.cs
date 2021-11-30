using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palyazatCucc
{
    //start: 16:55pm
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            ConnectionString = @"data source=(localdb)\MSSQLLocalDB;initial catalog=palyazatok;"; //csak mert kéri a feladat :D
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshDgvAllapot();
        }

        private void BtnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUj_Click(object sender, EventArgs e)
        {
            new FrmUjPalyazat().ShowDialog();
            RefreshDgvAllapot();
        }

        private void RefreshDgvAllapot()
        {
            try
            {
                using (var ctxPalyazatok = new PalyazatokEntities()) DgvAllapot.DataSource = ctxPalyazatok.palyazatokAllapota.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adatbázis kapcsolati hiba:\n" + ex.Message);
            }
        }
    }
}

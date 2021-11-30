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
    public partial class FrmUjPalyazat : Form
    {
        public FrmUjPalyazat()
        {
            InitializeComponent();

            try
            {
                using (var ctxPalyazatok = new PalyazatokEntities()) tbID.Text = (ctxPalyazatok.palyazat.Max(x => x.id) + 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Adatbázis kapcsolati hiba:\n" + ex.Message);
            }
        }

        private void btnUjPalyazat_Click(object sender, EventArgs e)
        {
            int aCatHuf;
            int cCatHuf;

            try
            {
                if (!int.TryParse(tbAKategoria.Text, out aCatHuf)) throw new Exception("Az \"A\" értékkeret nem szám.");
                else if (aCatHuf < 0) throw new Exception("Az \"A\" értékkeret negatív.");
                else if (!int.TryParse(tbCKategoria.Text, out cCatHuf)) throw new Exception("Az \"C\" értékkeret nem szám.");
                else if (cCatHuf < 0) throw new Exception("Az \"C\" értékkeret negatív.");

                try
                {
                    using (var ctxPalyazatok = new PalyazatokEntities())
                    {
                        ctxPalyazatok.palyazat.Add(new palyazat()
                        {
                            id = Convert.ToInt32(tbID.Text),
                            tervezetA = aCatHuf,
                            tervezetC = cCatHuf

                        });

                        ctxPalyazatok.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Adatbázis kapcsolati hiba\n" + ex.Message);
                }
                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

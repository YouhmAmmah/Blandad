using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blandadededdedd
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnKör_Click(object sender, EventArgs e)
        {
            {
                  try
                {
                    // grabs tal
                    int tal = int.Parse(tbxTalA.Text);
                    int talB = int.Parse(tbxTalB.Text);

                    // divide
                    int hel = tal / talB;

                    // modulus
                    int delA = tal % talB;

                    // Convert double negative to positive
                    if (tal < 0 && talB < 0)
                        hel = (tal * -1) / (talB * -1);
                    if (tal < 0 && talB < 0)
                        delA = (tal * -1) % (talB * -1);
                    if (tal < 0 && talB < 0)
                        talB = talB * -1;
                        //         if (talB < 0 && tal >= 0)
                        //            talB = talB * -1;
                        //         if (talB < 0 && tal >= 0)
                        //           tal = tal * -1;

                        // print andswer
                        lblSvar.Text = "                         " + hel.ToString() + " " + delA + "/" + talB;


                    // if 0 correct label
                    if (delA == 0)
                        lblSvar.Text = "                         " + hel.ToString();
                    if (hel == 0)
                        lblSvar.Text = "                         " + delA + "/" + talB;
                    if (talB < 0 && tal >= 0)
                       lblSvar.Text = "                         " + hel.ToString() + " " + (delA * -1) + "/" + (talB * -1);
                    if (talB < 0 && tal >= 0 && hel == 0)
                        lblSvar.Text = "                         " + " " + (delA * -1) + "/" + (talB * -1);

                }
                   catch
                {
                    MessageBox.Show("Kalkylatorn vet inte vad de ska göra");
                }
            }
        }
    }
}

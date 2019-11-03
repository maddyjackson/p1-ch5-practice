using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceCalculator
{
    public partial class FormDC : Form
    {
        public FormDC()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {


            int mph;
            int hours;
            
        
            
            {
                if (int.TryParse(txtboxmph.Text, out mph))
                    if (int.TryParse(txtboxhours.Text, out hours))

                        for (int c = 1; c <= hours; c++)

                            resultlistbox.Items.Add("After hour " + hours + " the distance is " + (c * mph));
                {
                    {
                   

                    }
                    
                }
                
            }
        }

        private void resultlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtboxmph_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtboxhours_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH3C_Q8E6EZ
{
    public partial class UserControl3 : UserControl
    {
        Models.se_petsContext context = new Models.se_petsContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSpecies();
        }

        private void ListSpecies()
        {
            var selectedSpecies = (Models.Species)listBox1.SelectedItem;
            var species = from x in context.Species
                          where x.SpeciesSk = selectedSpecies.SpeciesFk
                          select x;
            listBox1.DataSource = species.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

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
    public partial class UserControl2 : UserControl
    {
        Models.se_petsContext context = new Models.se_petsContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        private void FilterSpecies()
        {
            var species = from x in context.Species
                          where x.Name.Contains(textBox1.Text)
                          select x;
            listBox1.DataSource = species.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterSpecies();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            FilteredSpecies();
        }

        private void FilteredSpecies()
        {
            var selectedSpecies = (Models.Animal)listBox1.SelectedItem;
            var filtered = from x in context.Animals
                           where x.SpeciesFk == selectedSpecies.SpeciesFk
                           select new
                           {
                               Name = x.Name,
                               BirthYear = x.BirthYear
                           };
            //DetailedFiltered.DataSource= filtered.ToList();
            //dataGridView1.DataSource = DetailedFiltered;
        }
        public class DetailedFiltered
        {
            public string Name { get; set; }
            public int BirthYear { get; set; }
        }
    }
}

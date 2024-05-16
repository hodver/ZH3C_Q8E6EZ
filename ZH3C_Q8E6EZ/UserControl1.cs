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
    public partial class UserControl1 : UserControl
    {
        Models.se_petsContext context = new Models.se_petsContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            FilterProcedure();
        }

        private void FilterProcedure()
        {
            var selectedProcedure = (Models.ProcedureDone)listBox1.SelectedItem;
            var proc = from x in context.ProcedureDones
                       where x.ProcedureDoneSk = x.selectedProcedure.ProcedureDoneFk
                       select new
                       {
                           PetName = x.AnimalFkNavigation.Name,
                           ProcedureName = x.ProcedureFkNavigation.Name,
                           ProcedureDate = x.TreatmentFkNavigation.Date
                       };
            //DetailedProcedure.DataSource = proc.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterProcedure();
        }

        public class DetailedProcedure
        {
            public string PetName { get; set; } 
            public string ProcedureName { get; set;}
            public int ProcedureDate { get; set;}
        }
    }
}

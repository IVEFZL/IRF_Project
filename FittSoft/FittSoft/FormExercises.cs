using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FittSoft
{
    public partial class FormExercises : Form
    {
        DWEntities context = new DWEntities();
        public FormExercises()
        {
            InitializeComponent();
            RefreshExercises();
        }

        private void RefreshExercises()
        {
            context.D_GYAKORLAT.Load();
            d_GYAKORLATBindingSource.DataSource = context.D_GYAKORLAT.Local;

            listBox_exercises.DisplayMember = "MEGNEVEZES";
            listBox_exercises.ValueMember = "GYAKORLAT_SK";
            listBox_exercises.DataSource = d_GYAKORLATBindingSource;

            RefreshDetails();
            
        }

        private void RefreshDetails()
        {
            int selectedSK = (int)listBox_exercises.SelectedValue;
            var selectedExercise = (from x in context.D_GYAKORLAT
                                    where x.GYAKORLAT_SK == selectedSK
                                    select x).First();

            string name = selectedExercise.MEGNEVEZES;
            // enumration category
            string desc = selectedExercise.LEIRAS;

            textBox_name.Text = name;
            textBox_desc.Text = desc;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var selectedExerciseIndex = listBox_exercises.SelectedIndex;
            

            
            //d_GYAKORLATBindingSource.RemoveAt(selectedExerciseIndex);
           // d_GYAKORLATBindingSource.
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void listBox_exercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDetails();
        }
    }
}

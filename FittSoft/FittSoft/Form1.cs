using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FittSoft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_to_FormWorkoutSession_Click(object sender, EventArgs e)
        {
            FormWorkoutSession form = new FormWorkoutSession();
            form.ShowDialog();
        }

        private void btn_to_FormMeasures_Click(object sender, EventArgs e)
        {
            FormMeasures form = new FormMeasures();
            form.ShowDialog();
        }

        private void btn_to_FormDoneWorkouts_Click(object sender, EventArgs e)
        {
            FormDoneWorkouts form = new FormDoneWorkouts();
            form.ShowDialog();
        }

        private void btn_to_FormExercises_Click(object sender, EventArgs e)
        {
            FormExercises form = new FormExercises();
            form.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FittSoft
{
    public partial class UserControlPreWorkout : UserControl
    {
        DWEntities context = new DWEntities();
        List<WorkoutPlanItem> workoutPlanList = new List<WorkoutPlanItem>();
        bool isValidItem = false;

        public UserControlPreWorkout()
        {
            InitializeComponent();
            dgw_workoutPlan.DataSource = workoutPlanList;

            var exercises = (from x in context.D_GYAKORLAT
                             select x).ToList();
            comboBox_name.DisplayMember = "MEGNEVEZES";
            comboBox_name.ValueMember = "GYAKORLAT_SK";
            comboBox_name.DataSource = exercises;
        }

        public bool CheckDecimal(String dec)
        {
            // Parse ellenőrzés
            decimal value;
            if (Decimal.TryParse(dec, out value)) return true;
            else return false;
        }

        public bool checkInt(String inte)
        {
            // Parse ellenőrzés
            int value;
            if (int.TryParse(inte, out value)) return true;
            else return false;
        }

        private bool validateReps(string reps)
        {
            return checkInt(reps);
        }

        private bool validateDuration(string dur)
        {
            return CheckDecimal(dur);
        }

        private bool validateWeight(string weight)
        {
            return CheckDecimal(weight);
        }



        private void btn_addToPlan_Click(object sender, EventArgs e)
        {
            // Gyakorlat létrehozása, datagridview-ba töltése
            WorkoutPlanItem ujItem = new WorkoutPlanItem();
            ujItem.Megnevezés = comboBox_name.Text;

            int reps = 0;
            decimal duration = 0;
            decimal weight = 0;

            int.TryParse(textBox_reps.Text, out reps);
            decimal.TryParse(textBox_duration.Text, out duration);
            decimal.TryParse(textBox_weight.Text, out weight);

            ujItem.Ismétlés = reps;
            ujItem.Időtartam = duration;
            ujItem.Súly = weight;

            var curEx = (from x in context.D_GYAKORLAT
                            where x.MEGNEVEZES == ujItem.Megnevezés
                            select x).First();

            string desc = curEx.LEIRAS;
            ujItem.Leírás = desc;

            workoutPlanList.Add(ujItem);
            dgw_workoutPlan.DataSource = new List<WorkoutPlanItem>();
            dgw_workoutPlan.DataSource = workoutPlanList;
            dgw_workoutPlan.Refresh();

            // Textboxok ürítése
            textBox_duration.Text = "";
            textBox_reps.Text = "";
            textBox_weight.Text = "";
        }
    }
}

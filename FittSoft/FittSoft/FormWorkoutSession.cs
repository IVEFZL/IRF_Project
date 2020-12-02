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
    public partial class FormWorkoutSession : Form
    {
        UserControlPreWorkout ucPreWorkout;
        UserControlExercise ucExercise;
        List<WorkoutPlanItem> currentPlanList;
        DWEntities context = new DWEntities();
        bool isCompleted = false;
        int curExNumber = 0;
        WorkoutSession currentSession;

        public FormWorkoutSession()
        {
            InitializeComponent();
            // Edzés tervezési nézet megjelenítése
            ucPreWorkout = new UserControlPreWorkout();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(ucPreWorkout);
            btn_delete.Visible = false;
            btn_save.Visible = false;
            btn_next.Visible = false;

        }

        private void btn_startWorkout_Click(object sender, EventArgs e)
        {
            // Új edzés session létrehozása
            currentSession = new WorkoutSession();
            currentSession.startTime = DateTime.Now;
            currentPlanList = new List<WorkoutPlanItem>();

            // Edzéstervben lévő gyakorlatok listába töltése
            foreach (DataGridViewRow curRow in ucPreWorkout.dgw_workoutPlan.Rows)
            {
                WorkoutPlanItem curItem = new WorkoutPlanItem();
                curItem.Megnevezés = curRow.Cells[0].Value.ToString();
                curItem.Ismétlés = int.Parse(curRow.Cells[1].Value.ToString());
                curItem.Időtartam = decimal.Parse(curRow.Cells[2].Value.ToString());
                curItem.Súly = decimal.Parse(curRow.Cells[3].Value.ToString());
                curItem.Leírás = curRow.Cells[4].Value.ToString();

                currentPlanList.Add(curItem);
            }

            // Pre Workout nézet elrejtése, új nézet megjelenítése
            ucExercise = new UserControlExercise();
            panel_main.Controls.Clear();
            panel_main.Controls.Add(ucExercise);
            btn_next.Visible = true;
            btn_startWorkout.Visible = false;

            // Első gyakorlat betöltése
            TryNextExercise();
        }

        private void TryNextExercise()
        {
            // Ellenőrzés, nehogy tovább menjünk mint ahány gyakorlatunk van
            if (curExNumber >= currentPlanList.Count) isCompleted = true;

            if(!isCompleted)
            {
                string name = currentPlanList[curExNumber].Megnevezés;
                string desc = currentPlanList[curExNumber].Leírás;
                int reps = currentPlanList[curExNumber].Ismétlés;
                decimal duration = currentPlanList[curExNumber].Időtartam;
                decimal weight = currentPlanList[curExNumber].Súly;

                RefreshExercisePanel(name, desc, reps, duration, weight);
                curExNumber++;
            }
            else
            {
                // Ha végeztünk az edzéssel
                string name = "KÉSZ";
                string desc = "KÉSZ";
                int reps = 0;
                decimal duration = 0;
                decimal weight = 0;

                RefreshExercisePanel(name, desc, reps, duration, weight);

                btn_save.Visible = true;
                btn_delete.Visible = true;
                btn_next.Visible = false;

                currentSession.endTime = DateTime.Now;
                currentSession.duration = Decimal.Parse((currentSession.endTime - currentSession.startTime).TotalMinutes.ToString());
            }
        }

        private void RefreshExercisePanel(string name, string desc, int reps, decimal duration, decimal weight)
        {
            // Aktuális gyakorlat adatainak megjelenítése
            ucExercise.label_var_exerciseName.Text = name;
            ucExercise.label_var_desc.Text = desc;
            ucExercise.label_var_reps.Text = reps.ToString();
            ucExercise.label_var_duration.Text = duration.ToString();
            ucExercise.label_var_weight.Text = weight.ToString();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            TryNextExercise();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Mentés az adatbázisba
            context.F_EDZES.Load();
            context.F_EDZES_GYAKORLAT.Load();
            fEDZESBindingSource.DataSource = context.F_EDZES.Local;
            fEDZES_GYAKORLATBindingSource.DataSource = context.F_EDZES_GYAKORLAT.Local;

            // Edzés hozzáadása
            F_EDZES newWorkout = new F_EDZES();
            newWorkout.KEZD_IDOPONT = currentSession.startTime;
            newWorkout.BEF_IDOPONT = currentSession.endTime;
            newWorkout.IDOTARTAM = currentSession.duration;

            fEDZESBindingSource.Add(newWorkout);
            context.SaveChanges();

            // Gyakorlatok hozzáadása a létrehozott edzéshez
            var prevAddedWorkout = (from x in context.F_EDZES
                               where x.KEZD_IDOPONT == newWorkout.KEZD_IDOPONT
                               select x).First();
            int prevAddedSK = prevAddedWorkout.EDZES_SK;
            
            foreach (WorkoutPlanItem curItem in currentPlanList)
            {
                var curEx = (from x in context.D_GYAKORLAT
                             where x.MEGNEVEZES == curItem.Megnevezés
                             select x).First();
                int exerciseSK = curEx.GYAKORLAT_SK;

                F_EDZES_GYAKORLAT newExercise = new F_EDZES_GYAKORLAT();
                newExercise.EDZES_ID = prevAddedSK;
                newExercise.GYAKORLAT_ID = exerciseSK;
                newExercise.ISMETLES = curItem.Ismétlés;
                newExercise.IDOTARTAM = curItem.Időtartam;
                newExercise.SULY = curItem.Súly;

                fEDZES_GYAKORLATBindingSource.Add(newExercise);
                context.SaveChanges();

                this.Close();
            }
                               
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Form bezárása mentés nélkül
            this.Close();
        }
    }
}
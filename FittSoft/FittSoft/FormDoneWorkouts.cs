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
    public partial class FormDoneWorkouts : Form
    {
        DWEntities context = new DWEntities();

        public FormDoneWorkouts()
        {
            InitializeComponent();
            RefreshDates();
        }

        private void RefreshDates()
        {
            var dates = (from x in context.F_EDZES
                        select x).ToList();
            listBox_dates.DisplayMember = "KEZD_IDOPONT";
            listBox_dates.DataSource = dates;
        }

        private void RefreshDetails()
        {
            var beginDate = ((F_EDZES)listBox_dates.SelectedItem).KEZD_IDOPONT;
            
            var selectedWorkout = (from x in context.F_EDZES
                                  where x.KEZD_IDOPONT == beginDate
                                  select x).First();

            String duration = selectedWorkout.IDOTARTAM.ToString();
            String start = selectedWorkout.KEZD_IDOPONT.ToString();
            String end = selectedWorkout.BEF_IDOPONT.ToString();

            label_var_duration.Text = duration;
            label_var_start.Text = start;
            label_var_end.Text = end;

            var exercises = from x in context.F_EDZES
                            join y in context.F_EDZES_GYAKORLAT on x.EDZES_SK equals y.EDZES_ID
                            join z in context.D_GYAKORLAT on y.GYAKORLAT_ID equals z.GYAKORLAT_SK
                            where x.KEZD_IDOPONT == beginDate
                            select new
                            {
                                Gyakorlat = z.MEGNEVEZES,
                                Ismétlés = y.ISMETLES,
                                Időtartam = y.IDOTARTAM,
                                Súly = y.SULY
                            };
            dgw_exercises.DataSource = exercises.ToList();
        }

        private void listBox_dates_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDetails();
        }
    }
}

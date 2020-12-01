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
    public partial class FormMeasures : Form
    {
        DWEntities context = new DWEntities();

        public FormMeasures()
        {
            InitializeComponent();
            refreshMeasures();
        }

        private void refreshMeasures()
        {
            var measures = from x in context.F_MERES
                           select new
                           {
                               Dátum = x.DATUM,
                               Tömeg = x.TOMEG,
                               Testzsír = x.TESTZSIR
                           };

            dgw_Measures.DataSource = measures.ToList();
        }

        private void btn_toFormNewMeasure_Click(object sender, EventArgs e)
        {
            FormNewMeasure form = new FormNewMeasure();
            form.ShowDialog();
        }
    }
}

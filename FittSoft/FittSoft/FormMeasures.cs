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
            context.F_MERES.Load();
            fMERESBindingSource.DataSource = context.F_MERES.Local;
        }

        private void btn_toFormNewMeasure_Click(object sender, EventArgs e)
        {
            FormNewMeasure form = new FormNewMeasure();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Új rekord létrehozása
                F_MERES ujmeres = new F_MERES();

                // Adatok feltöltése
                ujmeres.DATUM = DateTime.Parse(form.textBox_date.Text);
                ujmeres.TOMEG = decimal.Parse(form.textBox_weight.Text);
                if (!String.IsNullOrEmpty(form.textBox_bodyfat.Text)) { ujmeres.TESTZSIR = decimal.Parse(form.textBox_bodyfat.Text); }
                
                

                // Rekord hozzáadása az adatforráshoz
                fMERESBindingSource.Add(ujmeres);
                context.SaveChanges();
            }
        }
    }
}

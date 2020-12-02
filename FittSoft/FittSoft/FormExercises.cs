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
        enum categories
        {
            Erőnlét = 1,
            Kardió = 2
        }

        public FormExercises()
        {
            InitializeComponent();
            RefreshExercises();
            RefreshDetails();
        }

        private void listBox_exercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDetails();
        }

        private void RefreshExercises()
        {
            
            // Null-al tesszük egyenlővé, hogy kényszerítsük a frissítést
            context.D_GYAKORLAT.Load();
            d_GYAKORLATBindingSource.DataSource = null;
            d_GYAKORLATBindingSource.DataSource = context.D_GYAKORLAT.Local;
            
            // Listbox tulajdonságok beállítása
            listBox_exercises.DisplayMember = "MEGNEVEZES";
            listBox_exercises.ValueMember = "GYAKORLAT_SK";
            listBox_exercises.DataSource = d_GYAKORLATBindingSource;

            // Combobox adatforrás beállítása
            comboBox_category.DataSource = Enum.GetValues(typeof(categories));
        }

        private void RefreshDetails()
        {
                // Szükséges SK tárolása
                int selectedSK = ((int)listBox_exercises.SelectedValue);

                // Aktuális rekord lekérdezése táblából
                var selectedExercise = (from x in context.D_GYAKORLAT
                                        where x.GYAKORLAT_SK == selectedSK
                                        select x).First();

                string name = selectedExercise.MEGNEVEZES;
                int category = selectedExercise.KATEGORIA_ID;
                string desc = selectedExercise.LEIRAS;

                // Textboxok és combobox frissítése
                if (category == 1) comboBox_category.SelectedItem = categories.Erőnlét;
                else comboBox_category.SelectedItem = categories.Kardió;

                textBox_name.Text = name;
                textBox_desc.Text = desc;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Aktuális, kiválasztott rekord tulajdonságainak frissítése
            ((D_GYAKORLAT)listBox_exercises.SelectedItem).MEGNEVEZES = textBox_name.Text;
            ((D_GYAKORLAT)listBox_exercises.SelectedItem).LEIRAS = textBox_desc.Text;
            if (comboBox_category.SelectedItem.ToString() == "Erőnlét") ((D_GYAKORLAT)listBox_exercises.SelectedItem).KATEGORIA_ID = 1;
            else ((D_GYAKORLAT)listBox_exercises.SelectedItem).KATEGORIA_ID = 2;

            // Adatbázisba mentés
            context.SaveChanges();

            // BindingSource újrakötése a listboxhoz
            listBox_exercises.DataSource = new List<D_GYAKORLAT>();
            listBox_exercises.DataSource = d_GYAKORLATBindingSource;
        }

        private void btn_addNewExercise_Click(object sender, EventArgs e)
        {
            // Új rekord létrehozása
            D_GYAKORLAT ujgyakorlat = new D_GYAKORLAT();
            ujgyakorlat.MEGNEVEZES = "Új gyakorlat";
            ujgyakorlat.LEIRAS = "";
            ujgyakorlat.KATEGORIA_ID = 1;

            // Listához adás, adatbázisba mentés
            d_GYAKORLATBindingSource.Add(ujgyakorlat);
            context.SaveChanges();
        }
    }
}

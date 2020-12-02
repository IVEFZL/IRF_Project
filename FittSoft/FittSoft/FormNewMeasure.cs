using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FittSoft
{
    public partial class FormNewMeasure : Form
    {

        public FormNewMeasure()
        {
            InitializeComponent();
        }

        private void ValidateOkButton()
        {
            // Csak akkor kattintható az OK gomb, ha minden megfelelően ki lett töltve
            if (ValidateDate(textBox_date.Text) &&
               ValidateWeight(textBox_weight.Text) &&
               ValidateBodyfat(textBox_bodyfat.Text)) btn_ok.Enabled = true;
            else btn_ok.Enabled = false;
        }

        public bool CheckDate(String date)
        {
            // Parse ellenőrzés
            try
            {
                DateTime dt = DateTime.Parse(date);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool CheckDecimal(String dec)
        {
            // Parse ellenőrzés
            decimal value;
            if (Decimal.TryParse(dec, out value)) return true;
            else return false;
        }

        public bool ValidateDate(string date)
        {
            return CheckDate(date);
        }

        public bool ValidateWeight(string dec)
        {
            return CheckDecimal(dec);
        }

        public bool ValidateBodyfat(string bodyfat)
        {

            //Testzsír százalék szám legyen, és 100-nál kisebb, vagy üres
            bool isDecimal = false;
            bool lessThan100 = false;
            bool isEmpty = String.IsNullOrEmpty(bodyfat);


            if (CheckDecimal(bodyfat))
            {
                isDecimal = true;
                if(Decimal.Parse(bodyfat) < 100)
                {
                    lessThan100 = true;
                }
            }

            if ((isDecimal && lessThan100) || isEmpty) return true;
            else return false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ValidateOkButton();
        }
    }
}

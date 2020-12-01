namespace FittSoft
{
    partial class FormNewMeasure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_date = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_bodyfat = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_bodyfat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(220, 63);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(41, 13);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "Dátum:";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Location = new System.Drawing.Point(220, 101);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(43, 13);
            this.label_weight.TabIndex = 1;
            this.label_weight.Text = "Tömeg:";
            // 
            // label_bodyfat
            // 
            this.label_bodyfat.AutoSize = true;
            this.label_bodyfat.Location = new System.Drawing.Point(209, 141);
            this.label_bodyfat.Name = "label_bodyfat";
            this.label_bodyfat.Size = new System.Drawing.Size(92, 13);
            this.label_bodyfat.TabIndex = 2;
            this.label_bodyfat.Text = "Testzsír százalék:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(259, 282);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(453, 282);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Mégse";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(336, 56);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(100, 20);
            this.textBox_date.TabIndex = 5;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(336, 94);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_weight.TabIndex = 6;
            // 
            // textBox_bodyfat
            // 
            this.textBox_bodyfat.Location = new System.Drawing.Point(336, 134);
            this.textBox_bodyfat.Name = "textBox_bodyfat";
            this.textBox_bodyfat.Size = new System.Drawing.Size(100, 20);
            this.textBox_bodyfat.TabIndex = 7;
            // 
            // FormNewMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_bodyfat);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label_bodyfat);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.label_date);
            this.Name = "FormNewMeasure";
            this.Text = "FormNewMeasure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.Label label_bodyfat;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_bodyfat;
    }
}
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
            this.label_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(159, 54);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(56, 18);
            this.label_date.TabIndex = 0;
            this.label_date.Text = "Dátum:";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_weight.ForeColor = System.Drawing.Color.White;
            this.label_weight.Location = new System.Drawing.Point(159, 94);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(59, 18);
            this.label_weight.TabIndex = 1;
            this.label_weight.Text = "Tömeg:";
            // 
            // label_bodyfat
            // 
            this.label_bodyfat.AutoSize = true;
            this.label_bodyfat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_bodyfat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_bodyfat.ForeColor = System.Drawing.Color.White;
            this.label_bodyfat.Location = new System.Drawing.Point(159, 134);
            this.label_bodyfat.Name = "label_bodyfat";
            this.label_bodyfat.Size = new System.Drawing.Size(128, 18);
            this.label_bodyfat.TabIndex = 2;
            this.label_bodyfat.Text = "Testzsír százalék:";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_ok.Enabled = false;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(84, 221);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(150, 50);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(357, 221);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(150, 50);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Mégse";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(324, 55);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(100, 20);
            this.textBox_date.TabIndex = 5;
            this.textBox_date.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(324, 95);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_weight.TabIndex = 6;
            this.textBox_weight.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_bodyfat
            // 
            this.textBox_bodyfat.Location = new System.Drawing.Point(324, 135);
            this.textBox_bodyfat.Name = "textBox_bodyfat";
            this.textBox_bodyfat.Size = new System.Drawing.Size(100, 20);
            this.textBox_bodyfat.TabIndex = 7;
            this.textBox_bodyfat.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // FormNewMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(552, 311);
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
        public System.Windows.Forms.TextBox textBox_date;
        public System.Windows.Forms.TextBox textBox_weight;
        public System.Windows.Forms.TextBox textBox_bodyfat;
    }
}
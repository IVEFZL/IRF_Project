namespace FittSoft
{
    partial class UserControlPreWorkout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgw_workoutPlan = new System.Windows.Forms.DataGridView();
            this.label_addNew = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_reps = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.btn_addToPlan = new System.Windows.Forms.Button();
            this.textBox_reps = new System.Windows.Forms.TextBox();
            this.textBox_duration = new System.Windows.Forms.TextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.comboBox_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_workoutPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_workoutPlan
            // 
            this.dgw_workoutPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_workoutPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_workoutPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgw_workoutPlan.Enabled = false;
            this.dgw_workoutPlan.Location = new System.Drawing.Point(0, 0);
            this.dgw_workoutPlan.Name = "dgw_workoutPlan";
            this.dgw_workoutPlan.Size = new System.Drawing.Size(555, 184);
            this.dgw_workoutPlan.TabIndex = 0;
            // 
            // label_addNew
            // 
            this.label_addNew.AutoSize = true;
            this.label_addNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_addNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_addNew.ForeColor = System.Drawing.Color.White;
            this.label_addNew.Location = new System.Drawing.Point(125, 200);
            this.label_addNew.Name = "label_addNew";
            this.label_addNew.Size = new System.Drawing.Size(256, 20);
            this.label_addNew.TabIndex = 1;
            this.label_addNew.Text = "Új gyakorlat hozzáadása a tervhez:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(84, 245);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(92, 17);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "Megnevezés:";
            // 
            // label_reps
            // 
            this.label_reps.AutoSize = true;
            this.label_reps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_reps.ForeColor = System.Drawing.Color.White;
            this.label_reps.Location = new System.Drawing.Point(84, 271);
            this.label_reps.Name = "label_reps";
            this.label_reps.Size = new System.Drawing.Size(96, 17);
            this.label_reps.TabIndex = 3;
            this.label_reps.Text = "Ismétlésszám:";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_duration.ForeColor = System.Drawing.Color.White;
            this.label_duration.Location = new System.Drawing.Point(84, 300);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(113, 17);
            this.label_duration.TabIndex = 4;
            this.label_duration.Text = "Időtartam (perc):";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_weight.ForeColor = System.Drawing.Color.White;
            this.label_weight.Location = new System.Drawing.Point(84, 326);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(39, 17);
            this.label_weight.TabIndex = 5;
            this.label_weight.Text = "Súly:";
            // 
            // btn_addToPlan
            // 
            this.btn_addToPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_addToPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_addToPlan.ForeColor = System.Drawing.Color.White;
            this.btn_addToPlan.Location = new System.Drawing.Point(379, 261);
            this.btn_addToPlan.Name = "btn_addToPlan";
            this.btn_addToPlan.Size = new System.Drawing.Size(123, 56);
            this.btn_addToPlan.TabIndex = 6;
            this.btn_addToPlan.Text = "Hozzáadás";
            this.btn_addToPlan.UseVisualStyleBackColor = false;
            this.btn_addToPlan.Click += new System.EventHandler(this.btn_addToPlan_Click);
            // 
            // textBox_reps
            // 
            this.textBox_reps.Location = new System.Drawing.Point(215, 269);
            this.textBox_reps.Name = "textBox_reps";
            this.textBox_reps.Size = new System.Drawing.Size(100, 20);
            this.textBox_reps.TabIndex = 8;
            // 
            // textBox_duration
            // 
            this.textBox_duration.Location = new System.Drawing.Point(215, 297);
            this.textBox_duration.Name = "textBox_duration";
            this.textBox_duration.Size = new System.Drawing.Size(100, 20);
            this.textBox_duration.TabIndex = 9;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(215, 323);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_weight.TabIndex = 10;
            // 
            // comboBox_name
            // 
            this.comboBox_name.FormattingEnabled = true;
            this.comboBox_name.Location = new System.Drawing.Point(215, 237);
            this.comboBox_name.Name = "comboBox_name";
            this.comboBox_name.Size = new System.Drawing.Size(100, 21);
            this.comboBox_name.TabIndex = 11;
            // 
            // UserControlPreWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.comboBox_name);
            this.Controls.Add(this.textBox_weight);
            this.Controls.Add(this.textBox_duration);
            this.Controls.Add(this.textBox_reps);
            this.Controls.Add(this.btn_addToPlan);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label_reps);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_addNew);
            this.Controls.Add(this.dgw_workoutPlan);
            this.Name = "UserControlPreWorkout";
            this.Size = new System.Drawing.Size(555, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_workoutPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_addNew;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_reps;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.Label label_weight;
        public System.Windows.Forms.DataGridView dgw_workoutPlan;
        public System.Windows.Forms.Button btn_addToPlan;
        public System.Windows.Forms.TextBox textBox_reps;
        public System.Windows.Forms.TextBox textBox_duration;
        public System.Windows.Forms.TextBox textBox_weight;
        public System.Windows.Forms.ComboBox comboBox_name;
    }
}

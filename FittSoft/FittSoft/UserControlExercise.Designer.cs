namespace FittSoft
{
    partial class UserControlExercise
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
            this.label_var_exerciseName = new System.Windows.Forms.Label();
            this.label_var_reps = new System.Windows.Forms.Label();
            this.label_var_desc = new System.Windows.Forms.Label();
            this.label_var_duration = new System.Windows.Forms.Label();
            this.label_var_weight = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_reps = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_var_exerciseName
            // 
            this.label_var_exerciseName.AutoSize = true;
            this.label_var_exerciseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_exerciseName.Location = new System.Drawing.Point(143, 14);
            this.label_var_exerciseName.Name = "label_var_exerciseName";
            this.label_var_exerciseName.Size = new System.Drawing.Size(104, 17);
            this.label_var_exerciseName.TabIndex = 1;
            this.label_var_exerciseName.Text = "Gyakorlat neve";
            // 
            // label_var_reps
            // 
            this.label_var_reps.AutoSize = true;
            this.label_var_reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_reps.Location = new System.Drawing.Point(143, 40);
            this.label_var_reps.Name = "label_var_reps";
            this.label_var_reps.Size = new System.Drawing.Size(59, 17);
            this.label_var_reps.TabIndex = 2;
            this.label_var_reps.Text = "Ismétlés";
            // 
            // label_var_desc
            // 
            this.label_var_desc.AutoSize = true;
            this.label_var_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_desc.Location = new System.Drawing.Point(143, 113);
            this.label_var_desc.Name = "label_var_desc";
            this.label_var_desc.Size = new System.Drawing.Size(47, 17);
            this.label_var_desc.TabIndex = 3;
            this.label_var_desc.Text = "Leírás";
            // 
            // label_var_duration
            // 
            this.label_var_duration.AutoSize = true;
            this.label_var_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_duration.Location = new System.Drawing.Point(143, 68);
            this.label_var_duration.Name = "label_var_duration";
            this.label_var_duration.Size = new System.Drawing.Size(67, 17);
            this.label_var_duration.TabIndex = 4;
            this.label_var_duration.Text = "Időtartam";
            // 
            // label_var_weight
            // 
            this.label_var_weight.AutoSize = true;
            this.label_var_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_weight.Location = new System.Drawing.Point(143, 91);
            this.label_var_weight.Name = "label_var_weight";
            this.label_var_weight.Size = new System.Drawing.Size(35, 17);
            this.label_var_weight.TabIndex = 5;
            this.label_var_weight.Text = "Súly";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(11, 14);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(108, 17);
            this.label_name.TabIndex = 6;
            this.label_name.Text = "Gyakorlat neve:";
            // 
            // label_reps
            // 
            this.label_reps.AutoSize = true;
            this.label_reps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_reps.Location = new System.Drawing.Point(11, 40);
            this.label_reps.Name = "label_reps";
            this.label_reps.Size = new System.Drawing.Size(93, 17);
            this.label_reps.TabIndex = 7;
            this.label_reps.Text = "Ismétlés (db):";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_duration.Location = new System.Drawing.Point(11, 68);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(113, 17);
            this.label_duration.TabIndex = 8;
            this.label_duration.Text = "Időtartam (perc):";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_weight.Location = new System.Drawing.Point(11, 91);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(68, 17);
            this.label_weight.TabIndex = 9;
            this.label_weight.Text = "Súly (kg):";
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc.Location = new System.Drawing.Point(11, 113);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(51, 17);
            this.label_desc.TabIndex = 10;
            this.label_desc.Text = "Leírás:";
            // 
            // UserControlExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label_reps);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_var_weight);
            this.Controls.Add(this.label_var_duration);
            this.Controls.Add(this.label_var_desc);
            this.Controls.Add(this.label_var_reps);
            this.Controls.Add(this.label_var_exerciseName);
            this.Name = "UserControlExercise";
            this.Size = new System.Drawing.Size(291, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label_var_exerciseName;
        public System.Windows.Forms.Label label_var_reps;
        public System.Windows.Forms.Label label_var_desc;
        public System.Windows.Forms.Label label_var_duration;
        public System.Windows.Forms.Label label_var_weight;
        public System.Windows.Forms.Label label_name;
        public System.Windows.Forms.Label label_reps;
        public System.Windows.Forms.Label label_duration;
        public System.Windows.Forms.Label label_weight;
        public System.Windows.Forms.Label label_desc;
    }
}

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
            this.label_totalDuration = new System.Windows.Forms.Label();
            this.label_var_exerciseName = new System.Windows.Forms.Label();
            this.label_var_reps = new System.Windows.Forms.Label();
            this.label_var_desc = new System.Windows.Forms.Label();
            this.label_var_duration = new System.Windows.Forms.Label();
            this.label_var_weight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_totalDuration
            // 
            this.label_totalDuration.AutoSize = true;
            this.label_totalDuration.Location = new System.Drawing.Point(36, 24);
            this.label_totalDuration.Name = "label_totalDuration";
            this.label_totalDuration.Size = new System.Drawing.Size(52, 13);
            this.label_totalDuration.TabIndex = 0;
            this.label_totalDuration.Text = "Teljes idő";
            // 
            // label_var_exerciseName
            // 
            this.label_var_exerciseName.AutoSize = true;
            this.label_var_exerciseName.Location = new System.Drawing.Point(340, 24);
            this.label_var_exerciseName.Name = "label_var_exerciseName";
            this.label_var_exerciseName.Size = new System.Drawing.Size(79, 13);
            this.label_var_exerciseName.TabIndex = 1;
            this.label_var_exerciseName.Text = "Gyakorlat neve";
            // 
            // label_var_reps
            // 
            this.label_var_reps.AutoSize = true;
            this.label_var_reps.Location = new System.Drawing.Point(340, 46);
            this.label_var_reps.Name = "label_var_reps";
            this.label_var_reps.Size = new System.Drawing.Size(45, 13);
            this.label_var_reps.TabIndex = 2;
            this.label_var_reps.Text = "Ismétlés";
            // 
            // label_var_desc
            // 
            this.label_var_desc.AutoSize = true;
            this.label_var_desc.Location = new System.Drawing.Point(340, 90);
            this.label_var_desc.Name = "label_var_desc";
            this.label_var_desc.Size = new System.Drawing.Size(37, 13);
            this.label_var_desc.TabIndex = 3;
            this.label_var_desc.Text = "Leírás";
            // 
            // label_var_duration
            // 
            this.label_var_duration.AutoSize = true;
            this.label_var_duration.Location = new System.Drawing.Point(340, 59);
            this.label_var_duration.Name = "label_var_duration";
            this.label_var_duration.Size = new System.Drawing.Size(51, 13);
            this.label_var_duration.TabIndex = 4;
            this.label_var_duration.Text = "Időtartam";
            // 
            // label_var_weight
            // 
            this.label_var_weight.AutoSize = true;
            this.label_var_weight.Location = new System.Drawing.Point(340, 77);
            this.label_var_weight.Name = "label_var_weight";
            this.label_var_weight.Size = new System.Drawing.Size(27, 13);
            this.label_var_weight.TabIndex = 5;
            this.label_var_weight.Text = "Súly";
            // 
            // UserControlExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_var_weight);
            this.Controls.Add(this.label_var_duration);
            this.Controls.Add(this.label_var_desc);
            this.Controls.Add(this.label_var_reps);
            this.Controls.Add(this.label_var_exerciseName);
            this.Controls.Add(this.label_totalDuration);
            this.Name = "UserControlExercise";
            this.Size = new System.Drawing.Size(771, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_totalDuration;
        public System.Windows.Forms.Label label_var_exerciseName;
        public System.Windows.Forms.Label label_var_reps;
        public System.Windows.Forms.Label label_var_desc;
        public System.Windows.Forms.Label label_var_duration;
        public System.Windows.Forms.Label label_var_weight;
    }
}

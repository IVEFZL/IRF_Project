namespace FittSoft
{
    partial class FormDoneWorkouts
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
            this.listBox_dates = new System.Windows.Forms.ListBox();
            this.label_start = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.label_var_start = new System.Windows.Forms.Label();
            this.label_var_end = new System.Windows.Forms.Label();
            this.label_var_duration = new System.Windows.Forms.Label();
            this.dgw_exercises = new System.Windows.Forms.DataGridView();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_exercises)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_dates
            // 
            this.listBox_dates.FormattingEnabled = true;
            this.listBox_dates.Location = new System.Drawing.Point(38, 40);
            this.listBox_dates.Name = "listBox_dates";
            this.listBox_dates.Size = new System.Drawing.Size(197, 381);
            this.listBox_dates.TabIndex = 0;
            this.listBox_dates.SelectedIndexChanged += new System.EventHandler(this.listBox_dates_SelectedIndexChanged);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Location = new System.Drawing.Point(467, 17);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(45, 13);
            this.label_start.TabIndex = 1;
            this.label_start.Text = "Kezdés:";
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(467, 53);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(56, 13);
            this.label_end.TabIndex = 2;
            this.label_end.Text = "Befejezés:";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.Location = new System.Drawing.Point(467, 95);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(84, 13);
            this.label_duration.TabIndex = 3;
            this.label_duration.Text = "Időtartam (perc):";
            // 
            // label_var_start
            // 
            this.label_var_start.AutoSize = true;
            this.label_var_start.Location = new System.Drawing.Point(557, 17);
            this.label_var_start.Name = "label_var_start";
            this.label_var_start.Size = new System.Drawing.Size(35, 13);
            this.label_var_start.TabIndex = 4;
            this.label_var_start.Text = "label4";
            // 
            // label_var_end
            // 
            this.label_var_end.AutoSize = true;
            this.label_var_end.Location = new System.Drawing.Point(557, 53);
            this.label_var_end.Name = "label_var_end";
            this.label_var_end.Size = new System.Drawing.Size(35, 13);
            this.label_var_end.TabIndex = 5;
            this.label_var_end.Text = "label5";
            // 
            // label_var_duration
            // 
            this.label_var_duration.AutoSize = true;
            this.label_var_duration.Location = new System.Drawing.Point(557, 95);
            this.label_var_duration.Name = "label_var_duration";
            this.label_var_duration.Size = new System.Drawing.Size(35, 13);
            this.label_var_duration.TabIndex = 6;
            this.label_var_duration.Text = "label6";
            // 
            // dgw_exercises
            // 
            this.dgw_exercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_exercises.Location = new System.Drawing.Point(299, 122);
            this.dgw_exercises.Name = "dgw_exercises";
            this.dgw_exercises.Size = new System.Drawing.Size(470, 258);
            this.dgw_exercises.TabIndex = 7;
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(502, 398);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 8;
            this.btn_export.Text = "Exportálás";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // FormDoneWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.dgw_exercises);
            this.Controls.Add(this.label_var_duration);
            this.Controls.Add(this.label_var_end);
            this.Controls.Add(this.label_var_start);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.listBox_dates);
            this.Name = "FormDoneWorkouts";
            this.Text = "FormDoneWorkouts";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_exercises)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_dates;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.Label label_var_start;
        private System.Windows.Forms.Label label_var_end;
        private System.Windows.Forms.Label label_var_duration;
        private System.Windows.Forms.DataGridView dgw_exercises;
        private System.Windows.Forms.Button btn_export;
    }
}
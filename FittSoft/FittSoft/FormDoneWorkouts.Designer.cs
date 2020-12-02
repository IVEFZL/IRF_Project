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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.listBox_dates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_dates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.listBox_dates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_dates.ForeColor = System.Drawing.Color.White;
            this.listBox_dates.FormattingEnabled = true;
            this.listBox_dates.ItemHeight = 16;
            this.listBox_dates.Location = new System.Drawing.Point(38, 40);
            this.listBox_dates.Name = "listBox_dates";
            this.listBox_dates.Size = new System.Drawing.Size(197, 372);
            this.listBox_dates.TabIndex = 0;
            this.listBox_dates.SelectedIndexChanged += new System.EventHandler(this.listBox_dates_SelectedIndexChanged);
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_start.ForeColor = System.Drawing.Color.White;
            this.label_start.Location = new System.Drawing.Point(296, 17);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(59, 17);
            this.label_start.TabIndex = 1;
            this.label_start.Text = "Kezdés:";
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_end.ForeColor = System.Drawing.Color.White;
            this.label_end.Location = new System.Drawing.Point(296, 53);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(74, 17);
            this.label_end.TabIndex = 2;
            this.label_end.Text = "Befejezés:";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_duration.ForeColor = System.Drawing.Color.White;
            this.label_duration.Location = new System.Drawing.Point(296, 95);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(113, 17);
            this.label_duration.TabIndex = 3;
            this.label_duration.Text = "Időtartam (perc):";
            // 
            // label_var_start
            // 
            this.label_var_start.AutoSize = true;
            this.label_var_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_var_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_start.ForeColor = System.Drawing.Color.White;
            this.label_var_start.Location = new System.Drawing.Point(557, 17);
            this.label_var_start.Name = "label_var_start";
            this.label_var_start.Size = new System.Drawing.Size(46, 17);
            this.label_var_start.TabIndex = 4;
            this.label_var_start.Text = "label4";
            // 
            // label_var_end
            // 
            this.label_var_end.AutoSize = true;
            this.label_var_end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_var_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_end.ForeColor = System.Drawing.Color.White;
            this.label_var_end.Location = new System.Drawing.Point(557, 53);
            this.label_var_end.Name = "label_var_end";
            this.label_var_end.Size = new System.Drawing.Size(46, 17);
            this.label_var_end.TabIndex = 5;
            this.label_var_end.Text = "label5";
            // 
            // label_var_duration
            // 
            this.label_var_duration.AutoSize = true;
            this.label_var_duration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_var_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_var_duration.ForeColor = System.Drawing.Color.White;
            this.label_var_duration.Location = new System.Drawing.Point(557, 95);
            this.label_var_duration.Name = "label_var_duration";
            this.label_var_duration.Size = new System.Drawing.Size(46, 17);
            this.label_var_duration.TabIndex = 6;
            this.label_var_duration.Text = "label6";
            // 
            // dgw_exercises
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgw_exercises.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgw_exercises.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_exercises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_exercises.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_exercises.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgw_exercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_exercises.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgw_exercises.Location = new System.Drawing.Point(299, 122);
            this.dgw_exercises.Name = "dgw_exercises";
            this.dgw_exercises.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_exercises.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgw_exercises.Size = new System.Drawing.Size(470, 258);
            this.dgw_exercises.TabIndex = 7;
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_export.FlatAppearance.BorderSize = 0;
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_export.ForeColor = System.Drawing.Color.White;
            this.btn_export.Location = new System.Drawing.Point(502, 398);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(150, 30);
            this.btn_export.TabIndex = 8;
            this.btn_export.Text = "Exportálás";
            this.btn_export.UseVisualStyleBackColor = false;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // FormDoneWorkouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
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
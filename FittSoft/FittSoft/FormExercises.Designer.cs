namespace FittSoft
{
    partial class FormExercises
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
            this.components = new System.ComponentModel.Container();
            this.listBox_exercises = new System.Windows.Forms.ListBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.label_desc = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_addNewExercise = new System.Windows.Forms.Button();
            this.d_GYAKORLATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.d_GYAKORLATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_exercises
            // 
            this.listBox_exercises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.listBox_exercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_exercises.ForeColor = System.Drawing.Color.White;
            this.listBox_exercises.FormattingEnabled = true;
            this.listBox_exercises.ItemHeight = 16;
            this.listBox_exercises.Location = new System.Drawing.Point(42, 47);
            this.listBox_exercises.Name = "listBox_exercises";
            this.listBox_exercises.Size = new System.Drawing.Size(259, 308);
            this.listBox_exercises.TabIndex = 0;
            this.listBox_exercises.SelectedIndexChanged += new System.EventHandler(this.listBox_exercises_SelectedIndexChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(409, 47);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(92, 17);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Megnevezés:";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_category.ForeColor = System.Drawing.Color.White;
            this.label_category.Location = new System.Drawing.Point(409, 97);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(73, 17);
            this.label_category.TabIndex = 2;
            this.label_category.Text = "Kategória:";
            // 
            // label_desc
            // 
            this.label_desc.AutoSize = true;
            this.label_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.label_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc.ForeColor = System.Drawing.Color.White;
            this.label_desc.Location = new System.Drawing.Point(409, 147);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(51, 17);
            this.label_desc.TabIndex = 3;
            this.label_desc.Text = "Leírás:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(512, 44);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(223, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(512, 147);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(223, 20);
            this.textBox_desc.TabIndex = 5;
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(512, 97);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(121, 21);
            this.comboBox_category.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(537, 304);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(143, 59);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Mentés";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_addNewExercise
            // 
            this.btn_addNewExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_addNewExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_addNewExercise.ForeColor = System.Drawing.Color.White;
            this.btn_addNewExercise.Location = new System.Drawing.Point(42, 390);
            this.btn_addNewExercise.Name = "btn_addNewExercise";
            this.btn_addNewExercise.Size = new System.Drawing.Size(259, 50);
            this.btn_addNewExercise.TabIndex = 8;
            this.btn_addNewExercise.Text = "Új gyakorlat hozzáadása";
            this.btn_addNewExercise.UseVisualStyleBackColor = false;
            this.btn_addNewExercise.Click += new System.EventHandler(this.btn_addNewExercise_Click);
            // 
            // d_GYAKORLATBindingSource
            // 
            this.d_GYAKORLATBindingSource.DataSource = typeof(FittSoft.D_GYAKORLAT);
            // 
            // FormExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addNewExercise);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.listBox_exercises);
            this.Name = "FormExercises";
            this.Text = "FormExercises";
            ((System.ComponentModel.ISupportInitialize)(this.d_GYAKORLATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource d_GYAKORLATBindingSource;
        private System.Windows.Forms.ListBox listBox_exercises;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Label label_desc;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addNewExercise;
    }
}
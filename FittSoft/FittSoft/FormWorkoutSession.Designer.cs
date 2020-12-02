namespace FittSoft
{
    partial class FormWorkoutSession
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
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_startWorkout = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.fEDZESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fEDZES_GYAKORLATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fEDZESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEDZES_GYAKORLATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.AutoSize = true;
            this.panel_main.Location = new System.Drawing.Point(53, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(739, 390);
            this.panel_main.TabIndex = 0;
            // 
            // btn_startWorkout
            // 
            this.btn_startWorkout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_startWorkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_startWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_startWorkout.ForeColor = System.Drawing.Color.White;
            this.btn_startWorkout.Location = new System.Drawing.Point(196, 429);
            this.btn_startWorkout.Name = "btn_startWorkout";
            this.btn_startWorkout.Size = new System.Drawing.Size(150, 50);
            this.btn_startWorkout.TabIndex = 1;
            this.btn_startWorkout.Text = "Edzés indítása";
            this.btn_startWorkout.UseVisualStyleBackColor = false;
            this.btn_startWorkout.Click += new System.EventHandler(this.btn_startWorkout_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(429, 429);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(150, 50);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Következő";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(196, 492);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(150, 50);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Edzés mentése";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(429, 492);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 50);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Edzés törlése";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // fEDZESBindingSource
            // 
            this.fEDZESBindingSource.DataSource = typeof(FittSoft.F_EDZES);
            // 
            // fEDZES_GYAKORLATBindingSource
            // 
            this.fEDZES_GYAKORLATBindingSource.DataSource = typeof(FittSoft.F_EDZES_GYAKORLAT);
            // 
            // FormWorkoutSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(843, 554);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_startWorkout);
            this.Controls.Add(this.panel_main);
            this.Name = "FormWorkoutSession";
            this.Text = "FormWorkoutSession";
            ((System.ComponentModel.ISupportInitialize)(this.fEDZESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fEDZES_GYAKORLATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_startWorkout;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.BindingSource fEDZESBindingSource;
        private System.Windows.Forms.BindingSource fEDZES_GYAKORLATBindingSource;
    }
}
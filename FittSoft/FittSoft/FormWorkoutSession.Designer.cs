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
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.Location = new System.Drawing.Point(53, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(739, 390);
            this.panel_main.TabIndex = 0;
            // 
            // btn_startWorkout
            // 
            this.btn_startWorkout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_startWorkout.Location = new System.Drawing.Point(155, 415);
            this.btn_startWorkout.Name = "btn_startWorkout";
            this.btn_startWorkout.Size = new System.Drawing.Size(198, 23);
            this.btn_startWorkout.TabIndex = 1;
            this.btn_startWorkout.Text = "Edzés indítása";
            this.btn_startWorkout.UseVisualStyleBackColor = true;
            this.btn_startWorkout.Click += new System.EventHandler(this.btn_startWorkout_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_next.Location = new System.Drawing.Point(504, 415);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(171, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Következő";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_save.Location = new System.Drawing.Point(196, 453);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(198, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Edzés mentése";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_delete.Location = new System.Drawing.Point(429, 453);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(198, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Edzés törlése";
            this.btn_delete.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(843, 503);
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
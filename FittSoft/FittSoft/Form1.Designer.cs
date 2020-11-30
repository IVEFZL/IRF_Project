namespace FittSoft
{
    partial class Form1
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
            this.btn_to_FormWorkoutSession = new System.Windows.Forms.Button();
            this.btn_to_FormMeasures = new System.Windows.Forms.Button();
            this.btn_to_FormDoneWorkouts = new System.Windows.Forms.Button();
            this.btn_to_FormExercises = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_to_FormWorkoutSession
            // 
            this.btn_to_FormWorkoutSession.Location = new System.Drawing.Point(182, 112);
            this.btn_to_FormWorkoutSession.Name = "btn_to_FormWorkoutSession";
            this.btn_to_FormWorkoutSession.Size = new System.Drawing.Size(137, 23);
            this.btn_to_FormWorkoutSession.TabIndex = 0;
            this.btn_to_FormWorkoutSession.Text = "Edzés elkezdése";
            this.btn_to_FormWorkoutSession.UseVisualStyleBackColor = true;
            this.btn_to_FormWorkoutSession.Click += new System.EventHandler(this.btn_to_FormWorkoutSession_Click);
            // 
            // btn_to_FormMeasures
            // 
            this.btn_to_FormMeasures.Location = new System.Drawing.Point(434, 112);
            this.btn_to_FormMeasures.Name = "btn_to_FormMeasures";
            this.btn_to_FormMeasures.Size = new System.Drawing.Size(145, 23);
            this.btn_to_FormMeasures.TabIndex = 1;
            this.btn_to_FormMeasures.Text = "Test mérések";
            this.btn_to_FormMeasures.UseVisualStyleBackColor = true;
            this.btn_to_FormMeasures.Click += new System.EventHandler(this.btn_to_FormMeasures_Click);
            // 
            // btn_to_FormDoneWorkouts
            // 
            this.btn_to_FormDoneWorkouts.Location = new System.Drawing.Point(182, 218);
            this.btn_to_FormDoneWorkouts.Name = "btn_to_FormDoneWorkouts";
            this.btn_to_FormDoneWorkouts.Size = new System.Drawing.Size(125, 47);
            this.btn_to_FormDoneWorkouts.TabIndex = 2;
            this.btn_to_FormDoneWorkouts.Text = "Korábbi edzések megtekintése";
            this.btn_to_FormDoneWorkouts.UseVisualStyleBackColor = true;
            this.btn_to_FormDoneWorkouts.Click += new System.EventHandler(this.btn_to_FormDoneWorkouts_Click);
            // 
            // btn_to_FormExercises
            // 
            this.btn_to_FormExercises.Location = new System.Drawing.Point(434, 230);
            this.btn_to_FormExercises.Name = "btn_to_FormExercises";
            this.btn_to_FormExercises.Size = new System.Drawing.Size(145, 23);
            this.btn_to_FormExercises.TabIndex = 3;
            this.btn_to_FormExercises.Text = "Gyakorlatok szerkesztése";
            this.btn_to_FormExercises.UseVisualStyleBackColor = true;
            this.btn_to_FormExercises.Click += new System.EventHandler(this.btn_to_FormExercises_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_to_FormExercises);
            this.Controls.Add(this.btn_to_FormDoneWorkouts);
            this.Controls.Add(this.btn_to_FormMeasures);
            this.Controls.Add(this.btn_to_FormWorkoutSession);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_to_FormWorkoutSession;
        private System.Windows.Forms.Button btn_to_FormMeasures;
        private System.Windows.Forms.Button btn_to_FormDoneWorkouts;
        private System.Windows.Forms.Button btn_to_FormExercises;
    }
}


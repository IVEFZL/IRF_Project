namespace FittSoft
{
    partial class FormMeasures
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
            this.dgw_Measures = new System.Windows.Forms.DataGridView();
            this.btn_toFormNewMeasure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Measures)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Measures
            // 
            this.dgw_Measures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Measures.Location = new System.Drawing.Point(83, 45);
            this.dgw_Measures.Name = "dgw_Measures";
            this.dgw_Measures.Size = new System.Drawing.Size(647, 305);
            this.dgw_Measures.TabIndex = 0;
            // 
            // btn_toFormNewMeasure
            // 
            this.btn_toFormNewMeasure.Location = new System.Drawing.Point(318, 394);
            this.btn_toFormNewMeasure.Name = "btn_toFormNewMeasure";
            this.btn_toFormNewMeasure.Size = new System.Drawing.Size(180, 23);
            this.btn_toFormNewMeasure.TabIndex = 1;
            this.btn_toFormNewMeasure.Text = "Új mérés felvétele";
            this.btn_toFormNewMeasure.UseVisualStyleBackColor = true;
            this.btn_toFormNewMeasure.Click += new System.EventHandler(this.btn_toFormNewMeasure_Click);
            // 
            // FormMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_toFormNewMeasure);
            this.Controls.Add(this.dgw_Measures);
            this.Name = "FormMeasures";
            this.Text = "FormMeasures";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Measures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Measures;
        private System.Windows.Forms.Button btn_toFormNewMeasure;
    }
}
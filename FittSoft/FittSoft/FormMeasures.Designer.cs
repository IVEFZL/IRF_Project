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
            this.components = new System.ComponentModel.Container();
            this.dgw_Measures = new System.Windows.Forms.DataGridView();
            this.btn_toFormNewMeasure = new System.Windows.Forms.Button();
            this.fMERESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mERESSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOMEGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTZSIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Measures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMERESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Measures
            // 
            this.dgw_Measures.AutoGenerateColumns = false;
            this.dgw_Measures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Measures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mERESSKDataGridViewTextBoxColumn,
            this.tOMEGDataGridViewTextBoxColumn,
            this.tESTZSIRDataGridViewTextBoxColumn,
            this.dATUMDataGridViewTextBoxColumn});
            this.dgw_Measures.DataSource = this.fMERESBindingSource;
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
            // fMERESBindingSource
            // 
            this.fMERESBindingSource.DataSource = typeof(FittSoft.F_MERES);
            // 
            // mERESSKDataGridViewTextBoxColumn
            // 
            this.mERESSKDataGridViewTextBoxColumn.DataPropertyName = "MERES_SK";
            this.mERESSKDataGridViewTextBoxColumn.HeaderText = "MERES_SK";
            this.mERESSKDataGridViewTextBoxColumn.Name = "mERESSKDataGridViewTextBoxColumn";
            // 
            // tOMEGDataGridViewTextBoxColumn
            // 
            this.tOMEGDataGridViewTextBoxColumn.DataPropertyName = "TOMEG";
            this.tOMEGDataGridViewTextBoxColumn.HeaderText = "TOMEG";
            this.tOMEGDataGridViewTextBoxColumn.Name = "tOMEGDataGridViewTextBoxColumn";
            // 
            // tESTZSIRDataGridViewTextBoxColumn
            // 
            this.tESTZSIRDataGridViewTextBoxColumn.DataPropertyName = "TESTZSIR";
            this.tESTZSIRDataGridViewTextBoxColumn.HeaderText = "TESTZSIR";
            this.tESTZSIRDataGridViewTextBoxColumn.Name = "tESTZSIRDataGridViewTextBoxColumn";
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
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
            ((System.ComponentModel.ISupportInitialize)(this.fMERESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Measures;
        private System.Windows.Forms.Button btn_toFormNewMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn mERESSKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOMEGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTZSIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fMERESBindingSource;
    }
}
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgw_Measures = new System.Windows.Forms.DataGridView();
            this.btn_toFormNewMeasure = new System.Windows.Forms.Button();
            this.fMERESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOMEGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tESTZSIRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mERESSKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Measures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMERESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Measures
            // 
            this.dgw_Measures.AllowUserToAddRows = false;
            this.dgw_Measures.AllowUserToDeleteRows = false;
            this.dgw_Measures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Measures.AutoGenerateColumns = false;
            this.dgw_Measures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_Measures.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.dgw_Measures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Measures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dATUMDataGridViewTextBoxColumn,
            this.tOMEGDataGridViewTextBoxColumn,
            this.tESTZSIRDataGridViewTextBoxColumn,
            this.mERESSKDataGridViewTextBoxColumn});
            this.dgw_Measures.DataSource = this.fMERESBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_Measures.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_Measures.Location = new System.Drawing.Point(83, 45);
            this.dgw_Measures.Name = "dgw_Measures";
            this.dgw_Measures.ReadOnly = true;
            this.dgw_Measures.Size = new System.Drawing.Size(647, 305);
            this.dgw_Measures.TabIndex = 0;
            // 
            // btn_toFormNewMeasure
            // 
            this.btn_toFormNewMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_toFormNewMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(26)))));
            this.btn_toFormNewMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_toFormNewMeasure.ForeColor = System.Drawing.Color.White;
            this.btn_toFormNewMeasure.Location = new System.Drawing.Point(271, 387);
            this.btn_toFormNewMeasure.Name = "btn_toFormNewMeasure";
            this.btn_toFormNewMeasure.Size = new System.Drawing.Size(279, 51);
            this.btn_toFormNewMeasure.TabIndex = 1;
            this.btn_toFormNewMeasure.Text = "Új mérés felvétele";
            this.btn_toFormNewMeasure.UseVisualStyleBackColor = false;
            this.btn_toFormNewMeasure.Click += new System.EventHandler(this.btn_toFormNewMeasure_Click);
            // 
            // fMERESBindingSource
            // 
            this.fMERESBindingSource.DataSource = typeof(FittSoft.F_MERES);
            // 
            // dATUMDataGridViewTextBoxColumn
            // 
            this.dATUMDataGridViewTextBoxColumn.DataPropertyName = "DATUM";
            this.dATUMDataGridViewTextBoxColumn.HeaderText = "Dátum";
            this.dATUMDataGridViewTextBoxColumn.Name = "dATUMDataGridViewTextBoxColumn";
            this.dATUMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOMEGDataGridViewTextBoxColumn
            // 
            this.tOMEGDataGridViewTextBoxColumn.DataPropertyName = "TOMEG";
            this.tOMEGDataGridViewTextBoxColumn.HeaderText = "Tömeg";
            this.tOMEGDataGridViewTextBoxColumn.Name = "tOMEGDataGridViewTextBoxColumn";
            this.tOMEGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tESTZSIRDataGridViewTextBoxColumn
            // 
            this.tESTZSIRDataGridViewTextBoxColumn.DataPropertyName = "TESTZSIR";
            this.tESTZSIRDataGridViewTextBoxColumn.HeaderText = "Testzsír(%)";
            this.tESTZSIRDataGridViewTextBoxColumn.Name = "tESTZSIRDataGridViewTextBoxColumn";
            this.tESTZSIRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mERESSKDataGridViewTextBoxColumn
            // 
            this.mERESSKDataGridViewTextBoxColumn.DataPropertyName = "MERES_SK";
            this.mERESSKDataGridViewTextBoxColumn.HeaderText = "MERES_SK";
            this.mERESSKDataGridViewTextBoxColumn.Name = "mERESSKDataGridViewTextBoxColumn";
            this.mERESSKDataGridViewTextBoxColumn.ReadOnly = true;
            this.mERESSKDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormMeasures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
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
        private System.Windows.Forms.BindingSource fMERESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOMEGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tESTZSIRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mERESSKDataGridViewTextBoxColumn;
    }
}
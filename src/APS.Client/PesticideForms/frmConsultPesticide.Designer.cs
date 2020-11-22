
namespace APS.Client.PesticideForms
{
    partial class frmConsultPesticide
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbToxicity = new System.Windows.Forms.ComboBox();
            this.cmbIsLegal = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPesticides = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesticides)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(198, 333);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbToxicity
            // 
            this.cmbToxicity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToxicity.Enabled = false;
            this.cmbToxicity.FormattingEnabled = true;
            this.cmbToxicity.Location = new System.Drawing.Point(152, 283);
            this.cmbToxicity.Name = "cmbToxicity";
            this.cmbToxicity.Size = new System.Drawing.Size(121, 23);
            this.cmbToxicity.TabIndex = 12;
            // 
            // cmbIsLegal
            // 
            this.cmbIsLegal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsLegal.Enabled = false;
            this.cmbIsLegal.FormattingEnabled = true;
            this.cmbIsLegal.Location = new System.Drawing.Point(14, 283);
            this.cmbIsLegal.Name = "cmbIsLegal";
            this.cmbIsLegal.Size = new System.Drawing.Size(121, 23);
            this.cmbIsLegal.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(14, 221);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 23);
            this.txtName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nível de toxidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Produto Legal?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do pesticida";
            // 
            // dgvPesticides
            // 
            this.dgvPesticides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesticides.Location = new System.Drawing.Point(14, 31);
            this.dgvPesticides.MultiSelect = false;
            this.dgvPesticides.Name = "dgvPesticides";
            this.dgvPesticides.ReadOnly = true;
            this.dgvPesticides.RowTemplate.Height = 25;
            this.dgvPesticides.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesticides.Size = new System.Drawing.Size(258, 150);
            this.dgvPesticides.TabIndex = 14;
            this.dgvPesticides.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesticides_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pesticidas";
            // 
            // frmConsultPesticide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 371);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPesticides);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbToxicity);
            this.Controls.Add(this.cmbIsLegal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultPesticide";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar pesticidas";
            this.Load += new System.EventHandler(this.frmConsultPesticide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesticides)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbToxicity;
        private System.Windows.Forms.ComboBox cmbIsLegal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPesticides;
        private System.Windows.Forms.Label label4;
    }
}

namespace APS.Client.PesticideForms
{
    partial class frmRegisterPesticide
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbIsLegal = new System.Windows.Forms.ComboBox();
            this.cmbToxicity = new System.Windows.Forms.ComboBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do pesticida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto Legal?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nível de toxidade";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 23);
            this.txtName.TabIndex = 3;
            // 
            // cmbIsLegal
            // 
            this.cmbIsLegal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIsLegal.FormattingEnabled = true;
            this.cmbIsLegal.Location = new System.Drawing.Point(13, 100);
            this.cmbIsLegal.Name = "cmbIsLegal";
            this.cmbIsLegal.Size = new System.Drawing.Size(121, 23);
            this.cmbIsLegal.TabIndex = 4;
            // 
            // cmbToxicity
            // 
            this.cmbToxicity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbToxicity.FormattingEnabled = true;
            this.cmbToxicity.Location = new System.Drawing.Point(151, 100);
            this.cmbToxicity.Name = "cmbToxicity";
            this.cmbToxicity.Size = new System.Drawing.Size(121, 23);
            this.cmbToxicity.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(200, 145);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmRegisterPesticide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 180);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbToxicity);
            this.Controls.Add(this.cmbIsLegal);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRegisterPesticide";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pesticida";
            this.Load += new System.EventHandler(this.frmRegisterPesticide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbIsLegal;
        private System.Windows.Forms.ComboBox cmbToxicity;
        private System.Windows.Forms.Button btnRegister;
    }
}
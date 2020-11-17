
namespace APS.ClientTest
{
    partial class frmMenu
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
            this.btnRegisterProperty = new System.Windows.Forms.Button();
            this.btnRegisterTicket = new System.Windows.Forms.Button();
            this.btnRegisterPesticide = new System.Windows.Forms.Button();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnConsultUser = new System.Windows.Forms.Button();
            this.btnConsultPesticide = new System.Windows.Forms.Button();
            this.btnConsultTicket = new System.Windows.Forms.Button();
            this.btnConsultProperty = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterProperty
            // 
            this.btnRegisterProperty.Location = new System.Drawing.Point(12, 12);
            this.btnRegisterProperty.Name = "btnRegisterProperty";
            this.btnRegisterProperty.Size = new System.Drawing.Size(89, 45);
            this.btnRegisterProperty.TabIndex = 2;
            this.btnRegisterProperty.Text = "Cadastrar Propriedade";
            this.btnRegisterProperty.UseVisualStyleBackColor = true;
            // 
            // btnRegisterTicket
            // 
            this.btnRegisterTicket.Location = new System.Drawing.Point(12, 63);
            this.btnRegisterTicket.Name = "btnRegisterTicket";
            this.btnRegisterTicket.Size = new System.Drawing.Size(89, 45);
            this.btnRegisterTicket.TabIndex = 3;
            this.btnRegisterTicket.Text = "Cadastrar Ticket";
            this.btnRegisterTicket.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPesticide
            // 
            this.btnRegisterPesticide.Location = new System.Drawing.Point(12, 114);
            this.btnRegisterPesticide.Name = "btnRegisterPesticide";
            this.btnRegisterPesticide.Size = new System.Drawing.Size(89, 45);
            this.btnRegisterPesticide.TabIndex = 4;
            this.btnRegisterPesticide.Text = "Cadastrar Pesticida";
            this.btnRegisterPesticide.UseVisualStyleBackColor = true;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(12, 165);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(89, 45);
            this.btnRegisterUser.TabIndex = 5;
            this.btnRegisterUser.Text = "Cadastrar Usuário";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // btnConsultUser
            // 
            this.btnConsultUser.Location = new System.Drawing.Point(12, 369);
            this.btnConsultUser.Name = "btnConsultUser";
            this.btnConsultUser.Size = new System.Drawing.Size(89, 45);
            this.btnConsultUser.TabIndex = 9;
            this.btnConsultUser.Text = "Consultar Usuário";
            this.btnConsultUser.UseVisualStyleBackColor = true;
            // 
            // btnConsultPesticide
            // 
            this.btnConsultPesticide.Location = new System.Drawing.Point(12, 318);
            this.btnConsultPesticide.Name = "btnConsultPesticide";
            this.btnConsultPesticide.Size = new System.Drawing.Size(89, 45);
            this.btnConsultPesticide.TabIndex = 8;
            this.btnConsultPesticide.Text = "Consultar Pesticida";
            this.btnConsultPesticide.UseVisualStyleBackColor = true;
            // 
            // btnConsultTicket
            // 
            this.btnConsultTicket.Location = new System.Drawing.Point(12, 267);
            this.btnConsultTicket.Name = "btnConsultTicket";
            this.btnConsultTicket.Size = new System.Drawing.Size(89, 45);
            this.btnConsultTicket.TabIndex = 7;
            this.btnConsultTicket.Text = "Consultar Ticket";
            this.btnConsultTicket.UseVisualStyleBackColor = true;
            // 
            // btnConsultProperty
            // 
            this.btnConsultProperty.Location = new System.Drawing.Point(12, 216);
            this.btnConsultProperty.Name = "btnConsultProperty";
            this.btnConsultProperty.Size = new System.Drawing.Size(89, 45);
            this.btnConsultProperty.TabIndex = 6;
            this.btnConsultProperty.Text = "Consultar Propriedade";
            this.btnConsultProperty.UseVisualStyleBackColor = true;
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(12, 420);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(89, 45);
            this.btnLogoff.TabIndex = 10;
            this.btnLogoff.Text = "Sair";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnConsultUser);
            this.Controls.Add(this.btnConsultPesticide);
            this.Controls.Add(this.btnConsultTicket);
            this.Controls.Add(this.btnConsultProperty);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.btnRegisterPesticide);
            this.Controls.Add(this.btnRegisterTicket);
            this.Controls.Add(this.btnRegisterProperty);
            this.IsMdiContainer = true;
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterProperty;
        private System.Windows.Forms.Button btnRegisterTicket;
        private System.Windows.Forms.Button btnRegisterPesticide;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnConsultUser;
        private System.Windows.Forms.Button btnConsultPesticide;
        private System.Windows.Forms.Button btnConsultTicket;
        private System.Windows.Forms.Button btnConsultProperty;
        private System.Windows.Forms.Button btnLogoff;
    }
}
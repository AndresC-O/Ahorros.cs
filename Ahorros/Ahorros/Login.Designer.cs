namespace Ahorros
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnCentral = new System.Windows.Forms.Panel();
            this.chBVerPass = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnInferior = new System.Windows.Forms.Panel();
            this.lklNuevoRegistro = new System.Windows.Forms.LinkLabel();
            this.pnCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnCentral
            // 
            this.pnCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.pnCentral.Controls.Add(this.chBVerPass);
            this.pnCentral.Controls.Add(this.panel2);
            this.pnCentral.Controls.Add(this.txtDUI);
            this.pnCentral.Controls.Add(this.panel1);
            this.pnCentral.Controls.Add(this.btnEntrar);
            this.pnCentral.Controls.Add(this.txtPassword);
            this.pnCentral.Controls.Add(this.ptbLogo);
            this.pnCentral.Controls.Add(this.btnCerrar);
            this.pnCentral.Controls.Add(this.pnInferior);
            this.pnCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCentral.Location = new System.Drawing.Point(0, 0);
            this.pnCentral.Name = "pnCentral";
            this.pnCentral.Size = new System.Drawing.Size(290, 405);
            this.pnCentral.TabIndex = 0;
            // 
            // chBVerPass
            // 
            this.chBVerPass.AutoSize = true;
            this.chBVerPass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBVerPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chBVerPass.Location = new System.Drawing.Point(13, 251);
            this.chBVerPass.Name = "chBVerPass";
            this.chBVerPass.Size = new System.Drawing.Size(127, 20);
            this.chBVerPass.TabIndex = 5;
            this.chBVerPass.Text = "Visualizar Caracteres";
            this.chBVerPass.UseVisualStyleBackColor = true;
            this.chBVerPass.CheckedChanged += new System.EventHandler(this.chBVerPass_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(13, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 2);
            this.panel2.TabIndex = 2;
            // 
            // txtDUI
            // 
            this.txtDUI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.txtDUI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDUI.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUI.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDUI.Location = new System.Drawing.Point(12, 179);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(266, 24);
            this.txtDUI.TabIndex = 1;
            this.txtDUI.Text = "00000000-0";
            this.txtDUI.Enter += new System.EventHandler(this.txtDUI_Enter);
            this.txtDUI.Leave += new System.EventHandler(this.txtDUI_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 2);
            this.panel1.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrar.Location = new System.Drawing.Point(69, 300);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(156, 42);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Iniciar Sesión";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPassword.Location = new System.Drawing.Point(11, 221);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(266, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Contraseña";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // ptbLogo
            // 
            this.ptbLogo.Image = global::Ahorros.Properties.Resources.money__1_;
            this.ptbLogo.Location = new System.Drawing.Point(80, 12);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(126, 131);
            this.ptbLogo.TabIndex = 2;
            this.ptbLogo.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Ahorros.Properties.Resources.close;
            this.btnCerrar.Location = new System.Drawing.Point(244, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 41);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnInferior
            // 
            this.pnInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.pnInferior.Controls.Add(this.lklNuevoRegistro);
            this.pnInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnInferior.Location = new System.Drawing.Point(0, 359);
            this.pnInferior.Name = "pnInferior";
            this.pnInferior.Size = new System.Drawing.Size(290, 46);
            this.pnInferior.TabIndex = 7;
            // 
            // lklNuevoRegistro
            // 
            this.lklNuevoRegistro.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(116)))), ((int)(((byte)(155)))));
            this.lklNuevoRegistro.AutoSize = true;
            this.lklNuevoRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklNuevoRegistro.LinkColor = System.Drawing.Color.White;
            this.lklNuevoRegistro.Location = new System.Drawing.Point(8, 15);
            this.lklNuevoRegistro.Name = "lklNuevoRegistro";
            this.lklNuevoRegistro.Size = new System.Drawing.Size(273, 18);
            this.lklNuevoRegistro.TabIndex = 0;
            this.lklNuevoRegistro.TabStop = true;
            this.lklNuevoRegistro.Text = "Aún no soy un Usuario - ¡Regístrame!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 405);
            this.Controls.Add(this.pnCentral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnCentral.ResumeLayout(false);
            this.pnCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnInferior.ResumeLayout(false);
            this.pnInferior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCentral;
        private System.Windows.Forms.Panel pnInferior;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.LinkLabel lklNuevoRegistro;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.CheckBox chBVerPass;
    }
}


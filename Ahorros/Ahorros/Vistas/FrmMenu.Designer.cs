namespace Ahorros.Vistas
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.flpPanelPrincipal = new System.Windows.Forms.FlowLayoutPanel();
            this.pnIzquierdo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnumDUI = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnAbonos = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pnSuperior.SuspendLayout();
            this.pnIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(37)))), ((int)(((byte)(73)))));
            this.pnSuperior.Controls.Add(this.btnCerrar);
            this.pnSuperior.Controls.Add(this.btnMinimizar);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(814, 40);
            this.pnSuperior.TabIndex = 0;
            // 
            // flpPanelPrincipal
            // 
            this.flpPanelPrincipal.AutoScroll = true;
            this.flpPanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.flpPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPanelPrincipal.Location = new System.Drawing.Point(200, 40);
            this.flpPanelPrincipal.Name = "flpPanelPrincipal";
            this.flpPanelPrincipal.Size = new System.Drawing.Size(614, 512);
            this.flpPanelPrincipal.TabIndex = 1;
            // 
            // pnIzquierdo
            // 
            this.pnIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(20)))), ((int)(((byte)(46)))));
            this.pnIzquierdo.Controls.Add(this.lblnumDUI);
            this.pnIzquierdo.Controls.Add(this.label1);
            this.pnIzquierdo.Controls.Add(this.pictureBox1);
            this.pnIzquierdo.Controls.Add(this.btnMas);
            this.pnIzquierdo.Controls.Add(this.btnAbonos);
            this.pnIzquierdo.Controls.Add(this.btnCuentas);
            this.pnIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnIzquierdo.Location = new System.Drawing.Point(0, 40);
            this.pnIzquierdo.Name = "pnIzquierdo";
            this.pnIzquierdo.Size = new System.Drawing.Size(200, 512);
            this.pnIzquierdo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.label1.Location = new System.Drawing.Point(3, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUI:";
            // 
            // lblnumDUI
            // 
            this.lblnumDUI.AutoSize = true;
            this.lblnumDUI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumDUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.lblnumDUI.Location = new System.Drawing.Point(75, 137);
            this.lblnumDUI.Name = "lblnumDUI";
            this.lblnumDUI.Size = new System.Drawing.Size(119, 25);
            this.lblnumDUI.TabIndex = 3;
            this.lblnumDUI.Text = "00000000-0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ahorros.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(33, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMas
            // 
            this.btnMas.FlatAppearance.BorderSize = 0;
            this.btnMas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(98)))), ((int)(((byte)(85)))));
            this.btnMas.Image = global::Ahorros.Properties.Resources.exit__1_;
            this.btnMas.Location = new System.Drawing.Point(0, 459);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(200, 41);
            this.btnMas.TabIndex = 2;
            this.btnMas.Text = "  Cerrar Sesión";
            this.btnMas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnAbonos
            // 
            this.btnAbonos.FlatAppearance.BorderSize = 0;
            this.btnAbonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.btnAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAbonos.Image = global::Ahorros.Properties.Resources.salary;
            this.btnAbonos.Location = new System.Drawing.Point(0, 222);
            this.btnAbonos.Name = "btnAbonos";
            this.btnAbonos.Size = new System.Drawing.Size(200, 41);
            this.btnAbonos.TabIndex = 1;
            this.btnAbonos.Text = "       Abonos";
            this.btnAbonos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbonos.UseVisualStyleBackColor = true;
            // 
            // btnCuentas
            // 
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(64)))), ((int)(((byte)(89)))));
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCuentas.Image = global::Ahorros.Properties.Resources.saving_money;
            this.btnCuentas.Location = new System.Drawing.Point(0, 175);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(200, 41);
            this.btnCuentas.TabIndex = 0;
            this.btnCuentas.Text = "       Cuentas";
            this.btnCuentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCuentas.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = global::Ahorros.Properties.Resources.close__1_;
            this.btnCerrar.Location = new System.Drawing.Point(775, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 34);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = global::Ahorros.Properties.Resources.minimize__1_;
            this.btnMinimizar.Location = new System.Drawing.Point(737, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 34);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 552);
            this.Controls.Add(this.flpPanelPrincipal);
            this.Controls.Add(this.pnIzquierdo);
            this.Controls.Add(this.pnSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.pnSuperior.ResumeLayout(false);
            this.pnIzquierdo.ResumeLayout(false);
            this.pnIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.FlowLayoutPanel flpPanelPrincipal;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Panel pnIzquierdo;
        private System.Windows.Forms.Button btnAbonos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblnumDUI;
        private System.Windows.Forms.Label label1;
    }
}
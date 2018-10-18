namespace Departamentos_AW
{
    partial class Actualizar
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblNombreAct = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblConf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(35, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(294, 87);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(228, 20);
            this.txtGrupo.TabIndex = 1;
            // 
            // lblNombreAct
            // 
            this.lblNombreAct.AutoSize = true;
            this.lblNombreAct.Location = new System.Drawing.Point(35, 51);
            this.lblNombreAct.Name = "lblNombreAct";
            this.lblNombreAct.Size = new System.Drawing.Size(102, 13);
            this.lblNombreAct.TabIndex = 2;
            this.lblNombreAct.Text = "Nombre a Actualizar";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(328, 51);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 3;
            this.lblGrupo.Text = "Grupo";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(200, 160);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(142, 41);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Location = new System.Drawing.Point(380, 187);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(35, 13);
            this.lblConf.TabIndex = 5;
            this.lblConf.Text = "label1";
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 339);
            this.Controls.Add(this.lblConf);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lblNombreAct);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.txtNombre);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblNombreAct;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblConf;
    }
}
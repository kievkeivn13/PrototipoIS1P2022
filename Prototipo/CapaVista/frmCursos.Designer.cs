
namespace CapaVista
{
    partial class frmCursos
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
            this.navegador1 = new DLL.nav.navegador();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.labelFraccionamiento = new System.Windows.Forms.Label();
            this.dtgFraccionamiento = new System.Windows.Forms.DataGridView();
            this.labelestadofraccionamiento = new System.Windows.Forms.Label();
            this.labelnombrefraccionamiento = new System.Windows.Forms.Label();
            this.labelidfraccionamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(267, 312);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(41, 26);
            this.txtEstatus.TabIndex = 69;
            this.txtEstatus.Tag = "estatus_curso";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(111, 187);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 26);
            this.txtNombre.TabIndex = 61;
            this.txtNombre.Tag = "nombre_curso";
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(112, 148);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(216, 26);
            this.txtPkid.TabIndex = 60;
            this.txtPkid.Tag = "codigo_curso";
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(50, 316);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 62;
            this.rbnHabilitado.TabStop = true;
            this.rbnHabilitado.Text = "Habilitado";
            this.rbnHabilitado.UseVisualStyleBackColor = false;
            this.rbnHabilitado.CheckedChanged += new System.EventHandler(this.rbnActivo_CheckedChanged);
            // 
            // rbnInhabilitado
            // 
            this.rbnInhabilitado.AutoSize = true;
            this.rbnInhabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnInhabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnInhabilitado.Location = new System.Drawing.Point(154, 316);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 63;
            this.rbnInhabilitado.TabStop = true;
            this.rbnInhabilitado.Text = "Inhabilitado";
            this.rbnInhabilitado.UseVisualStyleBackColor = false;
            this.rbnInhabilitado.CheckedChanged += new System.EventHandler(this.rbnInactivo_CheckedChanged);
            // 
            // labelFraccionamiento
            // 
            this.labelFraccionamiento.AutoSize = true;
            this.labelFraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelFraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFraccionamiento.Location = new System.Drawing.Point(363, 104);
            this.labelFraccionamiento.Name = "labelFraccionamiento";
            this.labelFraccionamiento.Size = new System.Drawing.Size(59, 20);
            this.labelFraccionamiento.TabIndex = 68;
            this.labelFraccionamiento.Text = "Cursos";
            // 
            // dtgFraccionamiento
            // 
            this.dtgFraccionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFraccionamiento.Location = new System.Drawing.Point(367, 127);
            this.dtgFraccionamiento.Name = "dtgFraccionamiento";
            this.dtgFraccionamiento.Size = new System.Drawing.Size(799, 245);
            this.dtgFraccionamiento.TabIndex = 67;
            // 
            // labelestadofraccionamiento
            // 
            this.labelestadofraccionamiento.AutoSize = true;
            this.labelestadofraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelestadofraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadofraccionamiento.Location = new System.Drawing.Point(37, 286);
            this.labelestadofraccionamiento.Name = "labelestadofraccionamiento";
            this.labelestadofraccionamiento.Size = new System.Drawing.Size(64, 20);
            this.labelestadofraccionamiento.TabIndex = 66;
            this.labelestadofraccionamiento.Text = "Estado:";
            // 
            // labelnombrefraccionamiento
            // 
            this.labelnombrefraccionamiento.AutoSize = true;
            this.labelnombrefraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelnombrefraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrefraccionamiento.Location = new System.Drawing.Point(36, 193);
            this.labelnombrefraccionamiento.Name = "labelnombrefraccionamiento";
            this.labelnombrefraccionamiento.Size = new System.Drawing.Size(69, 20);
            this.labelnombrefraccionamiento.TabIndex = 65;
            this.labelnombrefraccionamiento.Text = "Nombre:";
            // 
            // labelidfraccionamiento
            // 
            this.labelidfraccionamiento.AutoSize = true;
            this.labelidfraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelidfraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidfraccionamiento.Location = new System.Drawing.Point(36, 154);
            this.labelidfraccionamiento.Name = "labelidfraccionamiento";
            this.labelidfraccionamiento.Size = new System.Drawing.Size(30, 20);
            this.labelidfraccionamiento.TabIndex = 64;
            this.labelidfraccionamiento.Text = "ID:";
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 414);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.labelFraccionamiento);
            this.Controls.Add(this.dtgFraccionamiento);
            this.Controls.Add(this.labelestadofraccionamiento);
            this.Controls.Add(this.labelnombrefraccionamiento);
            this.Controls.Add(this.labelidfraccionamiento);
            this.Controls.Add(this.navegador1);
            this.Name = "frmCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.Label labelFraccionamiento;
        private System.Windows.Forms.DataGridView dtgFraccionamiento;
        private System.Windows.Forms.Label labelestadofraccionamiento;
        private System.Windows.Forms.Label labelnombrefraccionamiento;
        private System.Windows.Forms.Label labelidfraccionamiento;
    }
}
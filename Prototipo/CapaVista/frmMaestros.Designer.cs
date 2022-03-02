
namespace CapaVista
{
    partial class frmMaestros
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPkid = new System.Windows.Forms.TextBox();
            this.rbnHabilitado = new System.Windows.Forms.RadioButton();
            this.rbnInhabilitado = new System.Windows.Forms.RadioButton();
            this.labelFraccionamiento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgFraccionamiento = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelestadofraccionamiento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelnombrefraccionamiento = new System.Windows.Forms.Label();
            this.labelidfraccionamiento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(-1, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(263, 415);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(41, 26);
            this.txtEstatus.TabIndex = 85;
            this.txtEstatus.Tag = "estatus_maestro";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(108, 316);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 26);
            this.txtEmail.TabIndex = 72;
            this.txtEmail.Tag = "email_maestro";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(107, 266);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(217, 26);
            this.txtTelefono.TabIndex = 73;
            this.txtTelefono.Tag = "telefono_maestro";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(108, 227);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(216, 26);
            this.txtDireccion.TabIndex = 70;
            this.txtDireccion.Tag = "direccion_maestro";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(107, 178);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 26);
            this.txtNombre.TabIndex = 74;
            this.txtNombre.Tag = "nombre_maestro";
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(108, 139);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(216, 26);
            this.txtPkid.TabIndex = 71;
            this.txtPkid.Tag = "codigo_maestro";
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(46, 419);
            this.rbnHabilitado.Name = "rbnHabilitado";
            this.rbnHabilitado.Size = new System.Drawing.Size(98, 24);
            this.rbnHabilitado.TabIndex = 75;
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
            this.rbnInhabilitado.Location = new System.Drawing.Point(150, 419);
            this.rbnInhabilitado.Name = "rbnInhabilitado";
            this.rbnInhabilitado.Size = new System.Drawing.Size(109, 24);
            this.rbnInhabilitado.TabIndex = 76;
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
            this.labelFraccionamiento.Location = new System.Drawing.Point(359, 95);
            this.labelFraccionamiento.Name = "labelFraccionamiento";
            this.labelFraccionamiento.Size = new System.Drawing.Size(75, 20);
            this.labelFraccionamiento.TabIndex = 84;
            this.labelFraccionamiento.Text = "Maestros";
            this.labelFraccionamiento.Click += new System.EventHandler(this.labelFraccionamiento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Email:";
            // 
            // dtgFraccionamiento
            // 
            this.dtgFraccionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFraccionamiento.Location = new System.Drawing.Point(363, 118);
            this.dtgFraccionamiento.Name = "dtgFraccionamiento";
            this.dtgFraccionamiento.Size = new System.Drawing.Size(799, 340);
            this.dtgFraccionamiento.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Telefono:";
            // 
            // labelestadofraccionamiento
            // 
            this.labelestadofraccionamiento.AutoSize = true;
            this.labelestadofraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelestadofraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadofraccionamiento.Location = new System.Drawing.Point(33, 389);
            this.labelestadofraccionamiento.Name = "labelestadofraccionamiento";
            this.labelestadofraccionamiento.Size = new System.Drawing.Size(64, 20);
            this.labelestadofraccionamiento.TabIndex = 82;
            this.labelestadofraccionamiento.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Dirección:";
            // 
            // labelnombrefraccionamiento
            // 
            this.labelnombrefraccionamiento.AutoSize = true;
            this.labelnombrefraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelnombrefraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnombrefraccionamiento.Location = new System.Drawing.Point(32, 184);
            this.labelnombrefraccionamiento.Name = "labelnombrefraccionamiento";
            this.labelnombrefraccionamiento.Size = new System.Drawing.Size(69, 20);
            this.labelnombrefraccionamiento.TabIndex = 81;
            this.labelnombrefraccionamiento.Text = "Nombre:";
            // 
            // labelidfraccionamiento
            // 
            this.labelidfraccionamiento.AutoSize = true;
            this.labelidfraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelidfraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidfraccionamiento.Location = new System.Drawing.Point(32, 145);
            this.labelidfraccionamiento.Name = "labelidfraccionamiento";
            this.labelidfraccionamiento.Size = new System.Drawing.Size(30, 20);
            this.labelidfraccionamiento.TabIndex = 78;
            this.labelidfraccionamiento.Text = "ID:";
            // 
            // frmMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 487);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPkid);
            this.Controls.Add(this.rbnHabilitado);
            this.Controls.Add(this.rbnInhabilitado);
            this.Controls.Add(this.labelFraccionamiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgFraccionamiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelestadofraccionamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelnombrefraccionamiento);
            this.Controls.Add(this.labelidfraccionamiento);
            this.Controls.Add(this.navegador1);
            this.Name = "frmMaestros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaestros";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPkid;
        private System.Windows.Forms.RadioButton rbnHabilitado;
        private System.Windows.Forms.RadioButton rbnInhabilitado;
        private System.Windows.Forms.Label labelFraccionamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgFraccionamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelestadofraccionamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelnombrefraccionamiento;
        private System.Windows.Forms.Label labelidfraccionamiento;
    }
}
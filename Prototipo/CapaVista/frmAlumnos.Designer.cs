
namespace CapaVista
{
    partial class frmAlumnos
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
            this.navegador1 = new DLL.nav.navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEstatus
            // 
            this.txtEstatus.Enabled = false;
            this.txtEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(262, 456);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(41, 26);
            this.txtEstatus.TabIndex = 69;
            this.txtEstatus.Tag = "estatus_alumno";
            this.txtEstatus.Visible = false;
            this.txtEstatus.TextChanged += new System.EventHandler(this.txtEstatus_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(102, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 26);
            this.txtNombre.TabIndex = 61;
            this.txtNombre.Tag = "nombre_almno";
            // 
            // txtPkid
            // 
            this.txtPkid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPkid.Location = new System.Drawing.Point(103, 163);
            this.txtPkid.Name = "txtPkid";
            this.txtPkid.Size = new System.Drawing.Size(216, 26);
            this.txtPkid.TabIndex = 60;
            this.txtPkid.Tag = "carnet_alumno";
            // 
            // rbnHabilitado
            // 
            this.rbnHabilitado.AutoSize = true;
            this.rbnHabilitado.BackColor = System.Drawing.Color.Transparent;
            this.rbnHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnHabilitado.Location = new System.Drawing.Point(45, 460);
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
            this.rbnInhabilitado.Location = new System.Drawing.Point(149, 460);
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
            this.labelFraccionamiento.Location = new System.Drawing.Point(354, 119);
            this.labelFraccionamiento.Name = "labelFraccionamiento";
            this.labelFraccionamiento.Size = new System.Drawing.Size(71, 20);
            this.labelFraccionamiento.TabIndex = 68;
            this.labelFraccionamiento.Text = "Alumnos";
            // 
            // dtgFraccionamiento
            // 
            this.dtgFraccionamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFraccionamiento.Location = new System.Drawing.Point(358, 142);
            this.dtgFraccionamiento.Name = "dtgFraccionamiento";
            this.dtgFraccionamiento.Size = new System.Drawing.Size(799, 340);
            this.dtgFraccionamiento.TabIndex = 67;
            // 
            // labelestadofraccionamiento
            // 
            this.labelestadofraccionamiento.AutoSize = true;
            this.labelestadofraccionamiento.BackColor = System.Drawing.Color.Transparent;
            this.labelestadofraccionamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelestadofraccionamiento.Location = new System.Drawing.Point(32, 430);
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
            this.labelnombrefraccionamiento.Location = new System.Drawing.Point(27, 208);
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
            this.labelidfraccionamiento.Location = new System.Drawing.Point(27, 169);
            this.labelidfraccionamiento.Name = "labelidfraccionamiento";
            this.labelidfraccionamiento.Size = new System.Drawing.Size(30, 20);
            this.labelidfraccionamiento.TabIndex = 64;
            this.labelidfraccionamiento.Text = "ID:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(3, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(103, 251);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(216, 26);
            this.txtDireccion.TabIndex = 60;
            this.txtDireccion.Tag = "direccion_alumno";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(102, 290);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(217, 26);
            this.txtTelefono.TabIndex = 61;
            this.txtTelefono.Tag = "telefono_almno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(103, 340);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 26);
            this.txtEmail.TabIndex = 61;
            this.txtEmail.Tag = "email_alumno";
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 529);
            this.Controls.Add(this.navegador1);
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
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgFraccionamiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
    }
}
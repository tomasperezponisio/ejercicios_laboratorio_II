namespace Aplicacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.grbDetallesDelUsuario = new System.Windows.Forms.GroupBox();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.radGeneroNoBinario = new System.Windows.Forms.RadioButton();
            this.radGeneroF = new System.Windows.Forms.RadioButton();
            this.radGeneroM = new System.Windows.Forms.RadioButton();
            this.grbCursos = new System.Windows.Forms.GroupBox();
            this.chkCursosJavascript = new System.Windows.Forms.CheckBox();
            this.chkCursosCplusplus = new System.Windows.Forms.CheckBox();
            this.chkCursosCsharp = new System.Windows.Forms.CheckBox();
            this.libPais = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grbDetallesDelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            this.grbGenero.SuspendLayout();
            this.grbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 56);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 89);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(33, 15);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(12, 150);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "País";
            // 
            // grbDetallesDelUsuario
            // 
            this.grbDetallesDelUsuario.Controls.Add(this.numEdad);
            this.grbDetallesDelUsuario.Controls.Add(this.txtDireccion);
            this.grbDetallesDelUsuario.Controls.Add(this.txtNombre);
            this.grbDetallesDelUsuario.Controls.Add(this.lblNombre);
            this.grbDetallesDelUsuario.Controls.Add(this.lblDireccion);
            this.grbDetallesDelUsuario.Controls.Add(this.lblEdad);
            this.grbDetallesDelUsuario.Location = new System.Drawing.Point(12, 12);
            this.grbDetallesDelUsuario.Name = "grbDetallesDelUsuario";
            this.grbDetallesDelUsuario.Size = new System.Drawing.Size(321, 123);
            this.grbDetallesDelUsuario.TabIndex = 7;
            this.grbDetallesDelUsuario.TabStop = false;
            this.grbDetallesDelUsuario.Text = "Detalles del usuario";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(73, 85);
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(120, 23);
            this.numEdad.TabIndex = 11;
            this.numEdad.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(73, 52);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(242, 23);
            this.txtDireccion.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.radGeneroNoBinario);
            this.grbGenero.Controls.Add(this.radGeneroF);
            this.grbGenero.Controls.Add(this.radGeneroM);
            this.grbGenero.Location = new System.Drawing.Point(362, 12);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(159, 104);
            this.grbGenero.TabIndex = 8;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Género";
            // 
            // radGeneroNoBinario
            // 
            this.radGeneroNoBinario.AutoSize = true;
            this.radGeneroNoBinario.Location = new System.Drawing.Point(30, 65);
            this.radGeneroNoBinario.Name = "radGeneroNoBinario";
            this.radGeneroNoBinario.Size = new System.Drawing.Size(81, 19);
            this.radGeneroNoBinario.TabIndex = 8;
            this.radGeneroNoBinario.Text = "No Binario";
            this.radGeneroNoBinario.UseVisualStyleBackColor = true;
            // 
            // radGeneroF
            // 
            this.radGeneroF.AutoSize = true;
            this.radGeneroF.Location = new System.Drawing.Point(30, 43);
            this.radGeneroF.Name = "radGeneroF";
            this.radGeneroF.Size = new System.Drawing.Size(78, 19);
            this.radGeneroF.TabIndex = 7;
            this.radGeneroF.Text = "Femenino";
            this.radGeneroF.UseVisualStyleBackColor = true;
            // 
            // radGeneroM
            // 
            this.radGeneroM.AutoSize = true;
            this.radGeneroM.Checked = true;
            this.radGeneroM.Location = new System.Drawing.Point(30, 21);
            this.radGeneroM.Name = "radGeneroM";
            this.radGeneroM.Size = new System.Drawing.Size(80, 19);
            this.radGeneroM.TabIndex = 6;
            this.radGeneroM.TabStop = true;
            this.radGeneroM.Text = "Masculino";
            this.radGeneroM.UseVisualStyleBackColor = true;
            // 
            // grbCursos
            // 
            this.grbCursos.Controls.Add(this.chkCursosJavascript);
            this.grbCursos.Controls.Add(this.chkCursosCplusplus);
            this.grbCursos.Controls.Add(this.chkCursosCsharp);
            this.grbCursos.Location = new System.Drawing.Point(362, 122);
            this.grbCursos.Name = "grbCursos";
            this.grbCursos.Size = new System.Drawing.Size(159, 111);
            this.grbCursos.TabIndex = 9;
            this.grbCursos.TabStop = false;
            this.grbCursos.Text = "Cursos";
            // 
            // chkCursosJavascript
            // 
            this.chkCursosJavascript.AutoSize = true;
            this.chkCursosJavascript.Location = new System.Drawing.Point(28, 83);
            this.chkCursosJavascript.Name = "chkCursosJavascript";
            this.chkCursosJavascript.Size = new System.Drawing.Size(77, 19);
            this.chkCursosJavascript.TabIndex = 8;
            this.chkCursosJavascript.Text = "Javascript";
            this.chkCursosJavascript.UseVisualStyleBackColor = true;
            // 
            // chkCursosCplusplus
            // 
            this.chkCursosCplusplus.AutoSize = true;
            this.chkCursosCplusplus.Location = new System.Drawing.Point(28, 56);
            this.chkCursosCplusplus.Name = "chkCursosCplusplus";
            this.chkCursosCplusplus.Size = new System.Drawing.Size(50, 19);
            this.chkCursosCplusplus.TabIndex = 7;
            this.chkCursosCplusplus.Text = "C++";
            this.chkCursosCplusplus.UseVisualStyleBackColor = true;
            // 
            // chkCursosCsharp
            // 
            this.chkCursosCsharp.AutoSize = true;
            this.chkCursosCsharp.Location = new System.Drawing.Point(28, 29);
            this.chkCursosCsharp.Name = "chkCursosCsharp";
            this.chkCursosCsharp.Size = new System.Drawing.Size(41, 19);
            this.chkCursosCsharp.TabIndex = 6;
            this.chkCursosCsharp.Text = "C#";
            this.chkCursosCsharp.UseVisualStyleBackColor = true;
            // 
            // libPais
            // 
            this.libPais.FormattingEnabled = true;
            this.libPais.ItemHeight = 15;
            this.libPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.libPais.Location = new System.Drawing.Point(12, 179);
            this.libPais.Name = "libPais";
            this.libPais.Size = new System.Drawing.Size(321, 94);
            this.libPais.TabIndex = 10;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(362, 246);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(159, 27);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 298);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.libPais);
            this.Controls.Add(this.grbCursos);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.grbDetallesDelUsuario);
            this.Controls.Add(this.grbGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.grbDetallesDelUsuario.ResumeLayout(false);
            this.grbDetallesDelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbCursos.ResumeLayout(false);
            this.grbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.GroupBox grbDetallesDelUsuario;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.GroupBox grbCursos;
        private System.Windows.Forms.ListBox libPais;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton radGeneroNoBinario;
        private System.Windows.Forms.RadioButton radGeneroF;
        private System.Windows.Forms.RadioButton radGeneroM;
        private System.Windows.Forms.CheckBox chkCursosJavascript;
        private System.Windows.Forms.CheckBox chkCursosCplusplus;
        private System.Windows.Forms.CheckBox chkCursosCsharp;
        private System.Windows.Forms.Button btnIngresar;
    }
}

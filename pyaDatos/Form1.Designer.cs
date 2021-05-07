
namespace pyaDatos
{
    partial class Form1
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
            this.btnSemestre = new System.Windows.Forms.Button();
            this.btnEspecialidad = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.lvCaracteristicas = new System.Windows.Forms.ListView();
            this.N = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lSemestre = new System.Windows.Forms.Label();
            this.lEspecialidad = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lMatricula = new System.Windows.Forms.Label();
            this.txtApePa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApeMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPracticas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbResidencias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCertificaciones = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbToefl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPorEsp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.porSS = new System.Windows.Forms.Button();
            this.btnPP = new System.Windows.Forms.Button();
            this.btnPR = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSemestre
            // 
            this.btnSemestre.Location = new System.Drawing.Point(331, 331);
            this.btnSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.btnSemestre.Name = "btnSemestre";
            this.btnSemestre.Size = new System.Drawing.Size(76, 67);
            this.btnSemestre.TabIndex = 45;
            this.btnSemestre.Text = "Buscar por Semestre";
            this.btnSemestre.UseVisualStyleBackColor = true;
            this.btnSemestre.Click += new System.EventHandler(this.btnSemestre_Click);
            // 
            // btnEspecialidad
            // 
            this.btnEspecialidad.Location = new System.Drawing.Point(251, 331);
            this.btnEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnEspecialidad.Name = "btnEspecialidad";
            this.btnEspecialidad.Size = new System.Drawing.Size(76, 67);
            this.btnEspecialidad.TabIndex = 44;
            this.btnEspecialidad.Text = "Buscar por especialidad";
            this.btnEspecialidad.UseVisualStyleBackColor = true;
            this.btnEspecialidad.Click += new System.EventHandler(this.btnEspecialidad_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(11, 331);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(76, 67);
            this.btnLeer.TabIndex = 43;
            this.btnLeer.Text = "Leer Archivo";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(171, 331);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 67);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(91, 331);
            this.btnEscribir.Margin = new System.Windows.Forms.Padding(2);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(76, 67);
            this.btnEscribir.TabIndex = 40;
            this.btnEscribir.Text = "Escribir Archivo";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // lvCaracteristicas
            // 
            this.lvCaracteristicas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.N,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvCaracteristicas.HideSelection = false;
            this.lvCaracteristicas.Location = new System.Drawing.Point(331, 69);
            this.lvCaracteristicas.Margin = new System.Windows.Forms.Padding(2);
            this.lvCaracteristicas.Name = "lvCaracteristicas";
            this.lvCaracteristicas.Size = new System.Drawing.Size(672, 202);
            this.lvCaracteristicas.TabIndex = 39;
            this.lvCaracteristicas.UseCompatibleStateImageBehavior = false;
            this.lvCaracteristicas.View = System.Windows.Forms.View.Details;
            // 
            // N
            // 
            this.N.Text = "N";
            this.N.Width = 46;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Matricula";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido Paterno";
            this.columnHeader3.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Apellido Materno";
            this.columnHeader4.Width = 128;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nombre";
            this.columnHeader5.Width = 76;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Especialidad";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Semestre";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Servicio Social";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prácticas Profesionales";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Residencias Profesionales";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Certificaciones";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "TOEFL";
            // 
            // cbSemestre
            // 
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbSemestre.Location = new System.Drawing.Point(118, 142);
            this.cbSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(194, 21);
            this.cbSemestre.TabIndex = 38;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Items.AddRange(new object[] {
            "Informática",
            "Electrónica",
            "Mecánica",
            "Industrial",
            "Gestión Empresarial",
            "Energías Renovables"});
            this.cbEspecialidad.Location = new System.Drawing.Point(118, 117);
            this.cbEspecialidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(194, 21);
            this.cbEspecialidad.TabIndex = 37;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 93);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 36;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(118, 21);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(194, 20);
            this.txtMatricula.TabIndex = 35;
            // 
            // lSemestre
            // 
            this.lSemestre.AutoSize = true;
            this.lSemestre.Location = new System.Drawing.Point(37, 145);
            this.lSemestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSemestre.Name = "lSemestre";
            this.lSemestre.Size = new System.Drawing.Size(51, 13);
            this.lSemestre.TabIndex = 34;
            this.lSemestre.Text = "Semestre";
            // 
            // lEspecialidad
            // 
            this.lEspecialidad.AutoSize = true;
            this.lEspecialidad.Location = new System.Drawing.Point(35, 119);
            this.lEspecialidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lEspecialidad.Name = "lEspecialidad";
            this.lEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lEspecialidad.TabIndex = 33;
            this.lEspecialidad.Text = "Especialidad";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(43, 96);
            this.lNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(44, 13);
            this.lNombre.TabIndex = 32;
            this.lNombre.Text = "Nombre";
            // 
            // lMatricula
            // 
            this.lMatricula.AutoSize = true;
            this.lMatricula.Location = new System.Drawing.Point(37, 23);
            this.lMatricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lMatricula.Name = "lMatricula";
            this.lMatricula.Size = new System.Drawing.Size(50, 13);
            this.lMatricula.TabIndex = 31;
            this.lMatricula.Text = "Matricula";
            // 
            // txtApePa
            // 
            this.txtApePa.Location = new System.Drawing.Point(118, 45);
            this.txtApePa.Margin = new System.Windows.Forms.Padding(2);
            this.txtApePa.Name = "txtApePa";
            this.txtApePa.Size = new System.Drawing.Size(194, 20);
            this.txtApePa.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Apellido Paterno";
            // 
            // txtApeMa
            // 
            this.txtApeMa.Location = new System.Drawing.Point(118, 69);
            this.txtApeMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtApeMa.Name = "txtApeMa";
            this.txtApeMa.Size = new System.Drawing.Size(194, 20);
            this.txtApeMa.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Apellido Materno";
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbServicio.Location = new System.Drawing.Point(118, 167);
            this.cbServicio.Margin = new System.Windows.Forms.Padding(2);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(194, 21);
            this.cbServicio.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Servicio Social";
            // 
            // cbPracticas
            // 
            this.cbPracticas.FormattingEnabled = true;
            this.cbPracticas.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbPracticas.Location = new System.Drawing.Point(118, 205);
            this.cbPracticas.Margin = new System.Windows.Forms.Padding(2);
            this.cbPracticas.Name = "cbPracticas";
            this.cbPracticas.Size = new System.Drawing.Size(194, 21);
            this.cbPracticas.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 200);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 26);
            this.label4.TabIndex = 52;
            this.label4.Text = "Prácticas \r\nProfesionales";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbResidencias
            // 
            this.cbResidencias.FormattingEnabled = true;
            this.cbResidencias.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbResidencias.Location = new System.Drawing.Point(118, 237);
            this.cbResidencias.Margin = new System.Windows.Forms.Padding(2);
            this.cbResidencias.Name = "cbResidencias";
            this.cbResidencias.Size = new System.Drawing.Size(194, 21);
            this.cbResidencias.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "Residencias \r\nProfesionales";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCertificaciones
            // 
            this.cbCertificaciones.FormattingEnabled = true;
            this.cbCertificaciones.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbCertificaciones.Location = new System.Drawing.Point(118, 262);
            this.cbCertificaciones.Margin = new System.Windows.Forms.Padding(2);
            this.cbCertificaciones.Name = "cbCertificaciones";
            this.cbCertificaciones.Size = new System.Drawing.Size(194, 21);
            this.cbCertificaciones.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 270);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Certificaciones";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbToefl
            // 
            this.cbToefl.FormattingEnabled = true;
            this.cbToefl.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cbToefl.Location = new System.Drawing.Point(118, 291);
            this.cbToefl.Margin = new System.Windows.Forms.Padding(2);
            this.cbToefl.Name = "cbToefl";
            this.cbToefl.Size = new System.Drawing.Size(194, 21);
            this.cbToefl.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "TOEFL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPorEsp
            // 
            this.btnPorEsp.Location = new System.Drawing.Point(411, 331);
            this.btnPorEsp.Margin = new System.Windows.Forms.Padding(2);
            this.btnPorEsp.Name = "btnPorEsp";
            this.btnPorEsp.Size = new System.Drawing.Size(76, 67);
            this.btnPorEsp.TabIndex = 60;
            this.btnPorEsp.Text = "Porcentaje por especialidad";
            this.btnPorEsp.UseVisualStyleBackColor = true;
            this.btnPorEsp.Click += new System.EventHandler(this.btnPorEsp_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(491, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 67);
            this.button1.TabIndex = 61;
            this.button1.Text = "Porcentaje por semestre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // porSS
            // 
            this.porSS.Location = new System.Drawing.Point(571, 331);
            this.porSS.Margin = new System.Windows.Forms.Padding(2);
            this.porSS.Name = "porSS";
            this.porSS.Size = new System.Drawing.Size(76, 67);
            this.porSS.TabIndex = 62;
            this.porSS.Text = "Porcentaje por servicio social";
            this.porSS.UseVisualStyleBackColor = true;
            this.porSS.Click += new System.EventHandler(this.porSS_Click);
            // 
            // btnPP
            // 
            this.btnPP.Location = new System.Drawing.Point(651, 331);
            this.btnPP.Margin = new System.Windows.Forms.Padding(2);
            this.btnPP.Name = "btnPP";
            this.btnPP.Size = new System.Drawing.Size(85, 67);
            this.btnPP.TabIndex = 63;
            this.btnPP.Text = "Porcentaje por prácticas profesionales";
            this.btnPP.UseVisualStyleBackColor = true;
            this.btnPP.Click += new System.EventHandler(this.btnPP_Click);
            // 
            // btnPR
            // 
            this.btnPR.Location = new System.Drawing.Point(740, 331);
            this.btnPR.Margin = new System.Windows.Forms.Padding(2);
            this.btnPR.Name = "btnPR";
            this.btnPR.Size = new System.Drawing.Size(85, 67);
            this.btnPR.TabIndex = 64;
            this.btnPR.Text = "Porcentaje por prácticas residenciales";
            this.btnPR.UseVisualStyleBackColor = true;
            this.btnPR.Click += new System.EventHandler(this.btnPR_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(829, 331);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(85, 67);
            this.btnC.TabIndex = 65;
            this.btnC.Text = "Porcentaje por certificaciones";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(918, 331);
            this.btnT.Margin = new System.Windows.Forms.Padding(2);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(85, 67);
            this.btnT.TabIndex = 66;
            this.btnT.Text = "Porcentaje por TOEFL";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 449);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnPR);
            this.Controls.Add(this.btnPP);
            this.Controls.Add(this.porSS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPorEsp);
            this.Controls.Add(this.cbToefl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbCertificaciones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbResidencias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPracticas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApeMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApePa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSemestre);
            this.Controls.Add(this.btnEspecialidad);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.lvCaracteristicas);
            this.Controls.Add(this.cbSemestre);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lSemestre);
            this.Controls.Add(this.lEspecialidad);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lMatricula);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSemestre;
        private System.Windows.Forms.Button btnEspecialidad;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.ListView lvCaracteristicas;
        private System.Windows.Forms.ColumnHeader N;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lSemestre;
        private System.Windows.Forms.Label lEspecialidad;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lMatricula;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.TextBox txtApePa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApeMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPracticas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbResidencias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCertificaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbToefl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPorEsp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button porSS;
        private System.Windows.Forms.Button btnPP;
        private System.Windows.Forms.Button btnPR;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnT;
    }
}


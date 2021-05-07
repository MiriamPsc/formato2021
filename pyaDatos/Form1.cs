using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel;


namespace pyaDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        xls.Application a = new xls.Application();
        int i = 7;
        Especialidad esp = new Especialidad();
        Semestre sem = new Semestre();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            lvCaracteristicas.Items.Clear();
            int x = 6;
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string num = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string matricula = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string paterno = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string materno = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                string especialidad = a.ActiveWorkbook.ActiveSheet.Cells(x, 6).Value.ToString();
                string semestre = a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value.ToString();
                string servicio = a.ActiveWorkbook.ActiveSheet.Cells(x, 8).Value.ToString();
                string practicas = a.ActiveWorkbook.ActiveSheet.Cells(x, 9).Value.ToString();
                string residencias = a.ActiveWorkbook.ActiveSheet.Cells(x, 10).Value.ToString();
                string certificaciones = a.ActiveWorkbook.ActiveSheet.Cells(x, 11).Value.ToString();
                string toefl = a.ActiveWorkbook.ActiveSheet.Cells(x, 12).Value.ToString();
                ListViewItem lista = new ListViewItem(num);
                lista.SubItems.Add(matricula);
                lista.SubItems.Add(paterno);
                lista.SubItems.Add(materno);
                lista.SubItems.Add(nombre);
                lista.SubItems.Add(especialidad);
                lista.SubItems.Add(semestre);
                lista.SubItems.Add(servicio);
                lista.SubItems.Add(practicas);
                lista.SubItems.Add(residencias);
                lista.SubItems.Add(certificaciones);
                lista.SubItems.Add(toefl);
                lvCaracteristicas.Items.Add(lista);
                x++;
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string paterno = txtApePa.Text;
            string materno = txtApeMa.Text;
            string nombre = txtNombre.Text;
            string especialidad = cbEspecialidad.Text;
            string semestre = cbSemestre.Text;
            string servicio = cbServicio.Text;
            string practicas = cbPracticas.Text;
            string residencias = cbResidencias.Text;
            string certificaciones = cbCertificaciones.Text;
            string toefl = cbToefl.Text;

            a.ActiveWorkbook.Worksheets[1].Cells(i, 1).Value = i - 5;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 2).Value = matricula;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 3).Value = paterno;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 4).Value = materno;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 5).Value = nombre;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 6).Value = especialidad;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 7).Value = semestre;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 8).Value = servicio;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 9).Value = practicas;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 10).Value = residencias;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 11).Value = certificaciones;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 12).Value = toefl;
            i++;
            a.ActiveWorkbook.Save();
            MessageBox.Show("Se agregaron los datos al excel", "Lestura y Escritura", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            a.Workbooks.Open(Application.StartupPath + @"\formatooo.xlsx");
            while (a.ActiveWorkbook.ActiveSheet.Cells(i, 1).Value != null)
            {
                i++;
            }
            i--;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvCaracteristicas.Items.Clear();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            esp.Show();
        }

        private void btnSemestre_Click(object sender, EventArgs e)
        {
            sem.Show();
        }

        private void btnPorEsp_Click(object sender, EventArgs e)
        {
            int x = 6;
            int y = 6;
            int inf = 0;
            int mec = 0;
            int gest = 0;
            int ele = 0;
            int ind = 0;
            int reno = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 6).Value != null)
            {
                string i = a.ActiveWorkbook.ActiveSheet.Cells(x, 6).Value.ToString();

                switch (i)
                {
                    case "Informática":
                        inf++;
                        break;
                    case "Mecánica":
                        mec++;
                        break;
                    case "Gestión Empresarial":
                        gest++;
                        break;
                    case "Electrónica":
                        ele++;
                        break;
                    case "Industrial":
                        ind++;
                        break;
                    case "Energías Renovables":
                        reno++;
                        break;
                }
                x++;
            }

            decimal tInf = (inf * 100) / total;
            decimal tMec = (mec * 100) / total;
            decimal tGest = (gest * 100) / total;
            decimal tEle = (ele * 100) / total;
            decimal tInd = (ind * 100) / total;
            decimal tReno = (reno * 100) / total;

            MessageBox.Show("Porcentaje por especialidad: " +
                "Informática: " + tInf + "%   " +
                "Mecánica: " + tMec + "%   " +
                "Gestión Empresarial: " + tGest + "%   " +
                "Electrónica: " + tEle + "%   " +
              "Industial: " + tInd + "%   " +
              "Energías Renovables: " + tReno + "%   ");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            a.ActiveWorkbook.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 6;
            int y = 6;
            int primero = 0;
            int segundo = 0;
            int tercero = 0;
            int cuarto = 0;
            int quinto = 0;
            int sexto = 0;
            int sept = 0;
            int octavo = 0;
            int noveno = 0;
            int decimo = 0;
            int onceavo = 0;
            int doceavo = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value != null)
            {
                string s = a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value.ToString();

                switch (s)
                {
                    case "1":
                        primero++;
                        break;
                    case "2":
                        segundo++;
                        break;
                    case "3":
                        tercero++;
                        break;
                    case "4":
                        cuarto++;
                        break;
                    case "5":
                        quinto++;
                        break;
                    case "6":
                        sexto++;
                        break;
                    case "7":
                        sept++;
                        break;
                    case "8":
                        octavo++;
                        break;
                    case "9":
                        noveno++;
                        break;
                    case "10":
                        decimo++;
                        break;
                    case "11":
                        onceavo++;
                        break;
                    case "12":
                        doceavo++;
                        break;
                }
                x++;
            }
            decimal t1 = (primero * 100) / total;
            decimal t2 = (segundo * 100) / total;
            decimal t3 = (tercero * 100) / total;
            decimal t4 = (cuarto * 100) / total;
            decimal t5 = (quinto * 100) / total;
            decimal t6 = (sexto * 100) / total;
            decimal t7 = (sept * 100) / total;
            decimal t8 = (octavo * 100) / total;
            decimal t9 = (noveno * 100) / total;
            decimal t10 = (decimo * 100) / total;
            decimal t11 = (onceavo * 100) / total;
            decimal t12 = (doceavo * 100) / total;

            MessageBox.Show("Porcentaje por semestre: " +
              "Primero: " + t1 + "%   " +
              "Segundo: " + t2 + "%   " +
              "Tercero: " + t3 + "%   " +
              "Cuarto: " + t4 + "%   " +
              "Quinto: " + t5 + "%   " +
              "Sexto: " + t6 + "%   " +
              "Séptimo: " + t7 + "%   " +
              "Octavo: " + t8 + "%   " +
              "Noveno:" + t9 + "%   " +
              "Décimo:" + t10 + "%   " +
              "Onceavo:" + t11 + "%   ");
        }

        private void porSS_Click(object sender, EventArgs e)
        {
            int x = 6;
            int y = 6;
            int yes = 0;
            int no = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 8).Value != null)
            {
                string ss = a.ActiveWorkbook.ActiveSheet.Cells(x, 8).Value.ToString();

                switch (ss)
                {
                    case "Sí":
                        yes++;
                        break;
                    case "No":
                        no++;
                        break;
                }
                x++;
            }
            decimal tSi = (yes * 100) / total;
            decimal tNo = (no * 100) / total;

            MessageBox.Show("Porcentaje por servicio social: " +
              "Sí: " + tSi + "%   " +
              "No:" + tNo + "%   ");
        }

        private void btnPP_Click(object sender, EventArgs e)
        {
            int x = 6;
            int y = 6;
            int yes = 0;
            int no = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 9).Value != null)
            {
                string ss = a.ActiveWorkbook.ActiveSheet.Cells(x, 9).Value.ToString();

                switch (ss)
                {
                    case "Sí":
                        yes++;
                        break;
                    case "No":
                        no++;
                        break;
                }
                x++;
            }
            decimal tSi = (yes * 100) / total;
            decimal tNo = (no * 100) / total;

            MessageBox.Show("Porcentaje por prácticas profesionales: " +
              "Sí: " + tSi + "%   " +
              "No:" + tNo + "%   ");
        }

        private void btnPR_Click(object sender, EventArgs e)
        {
            int x = 6;
            int y = 6;
            int yes = 0;
            int no = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 10).Value != null)
            {
                string ss = a.ActiveWorkbook.ActiveSheet.Cells(x, 10).Value.ToString();

                switch (ss)
                {
                    case "Sí":
                        yes++;
                        break;
                    case "No":
                        no++;
                        break;
                }
                x++;
            }
            decimal tSi = (yes * 100) / total;
            decimal tNo = (no * 100) / total;

            MessageBox.Show("Porcentaje por prácticas residenciales: " +
              "Sí: " + tSi + "%   " +
              "No:" + tNo + "%   ");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            int x = 6;
            int y = 6;
            int yes = 0;
            int no = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 11).Value != null)
            {
                string ss = a.ActiveWorkbook.ActiveSheet.Cells(x, 11).Value.ToString();

                switch (ss)
                {
                    case "Sí":
                        yes++;
                        break;
                    case "No":
                        no++;
                        break;
                }
                x++;
            }
            decimal tSi = (yes * 100) / total;
            decimal tNo = (no * 100) / total;

            MessageBox.Show("Porcentaje por certificaciones: " +
              "Sí: " + tSi + "%   " +
              "No:" + tNo + "%   ");
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            int x = 6;
            int y = 6;
            int yes = 0;
            int no = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 12).Value != null)
            {
                string ss = a.ActiveWorkbook.ActiveSheet.Cells(x, 12).Value.ToString();

                switch (ss)
                {
                    case "Sí":
                        yes++;
                        break;
                    case "No":
                        no++;
                        break;
                }
                x++;
            }
            decimal tSi = (yes * 100) / total;
            decimal tNo = (no * 100) / total;

            MessageBox.Show("Porcentaje por TOEFL: " +
              "Sí: " + tSi + "%   " +
              "No:" + tNo + "%   ");
        }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;
 namespace IDE
{
    public partial class Form1 : Form
    {
        private String nombre_Archivo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.editor.Language = FastColoredTextBoxNS.Language.CSharp;
            this.nombre_Archivo = "nuevo";
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {
           
        }

        private void OpenDialog()
        {
            //crea un nuevo archivo
            OpenFileDialog arch = new OpenFileDialog();
            arch.Filter = "Text File|*.txt|Any File|*";

            if (arch.ShowDialog() == DialogResult.OK)
            {
                //abre el archivo
                StreamReader sr = new StreamReader(arch.FileName);
                editor.Text = sr.ReadToEnd();

                sr.Close();
                this.Text = arch.FileName;
                this.nombre_Archivo = arch.FileName;
            }
        }

        private void SaveDialog()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text File|*.txt|Any File|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sr = new StreamWriter(sf.FileName);
                sr.Write(this.editor.Text);
                this.nombre_Archivo = sf.FileName;
                sr.Close();
            }
        }


        private void abirirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.nombre_Archivo == "nuevo")
            {
                SaveDialog();
            }
            else
            {
                try
                {
                    //guardamos el archivo
                    StreamWriter sw = new StreamWriter(this.nombre_Archivo);
                    sw.Write(this.editor.Text);
                    sw.Close();
                }
                catch
                {
                    OpenDialog();
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editor.Text = "";
            this.nombre_Archivo = "nuevo";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void group_error_Enter(object sender, EventArgs e)
        {

        }

        private void faseLexico_Click(object sender, EventArgs e)
        {
            this.fases.Text = "";
            if(this.nombre_Archivo == "nuevo")
            {
                SaveDialog();
            }
            else
            {
                try
                {
                    //guardamos el archivo
                    StreamWriter sw = new StreamWriter(this.nombre_Archivo);
                    sw.Write(this.editor.Text);
                    sw.Close();
                }
                catch
                {
                    OpenDialog();
                }
            }
            //Creamos un espacio de ejecución para capturar el resultado del comando
            Runspace espacioEjecucion = RunspaceFactory.CreateRunspace();
            //Lo iniciamos
            espacioEjecucion.Open();
            //Creamos el objeto PowerShell
            PowerShell objPowerShell = PowerShell.Create();
            //Al objeto PowerShell le asignamos el espacio de ejecución
            objPowerShell.Runspace = espacioEjecucion;
            //Agregamos el comando PowerShell a ejecutar
            objPowerShell.AddScript(@".\ejecutable " + this.nombre_Archivo);
            //Ejecutamos el comando PowerShell y guardamos su resultado
            System.Collections.ObjectModel.Collection<PSObject> resultadoEjecucion = objPowerShell.Invoke();
            //Cerramos el espacio de ejecución
            espacioEjecucion.Close();
            //Recorremos cada línea del resultado para mostrarla por consola
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject lineaResultado in resultadoEjecucion)
            {
                this.fases.Text += lineaResultado.ToString() + "\r\n";
            }
      
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fases.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fases.Paste();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fases.Copy();
        }
    }
}
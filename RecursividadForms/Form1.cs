using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursividadForms
{
    public partial class Form1 : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        public Form1()
        {
            InitializeComponent();
            folderBrowserDialog = new FolderBrowserDialog();
        }

        private void btnSeleccionarUSB_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string usbPath = folderBrowserDialog.SelectedPath;
                textBoxRutaUSB.Text = usbPath;

                listBoxContenido.Items.Clear();
                ListarCarpetasYArchivos(usbPath);
            }

            void ListarCarpetasYArchivos(string path, string indent = "")
            {
                try
                {
                    string[] carpetas = Directory.GetDirectories(path);
                    foreach (string carpeta in carpetas)
                    {
                        listBoxContenido.Items.Add($"{indent}Carpeta: {Path.GetFileName(carpeta)}");
                        ListarCarpetasYArchivos(carpeta, indent + "  ");
                    }

                    string[] archivos = Directory.GetFiles(path);
                    foreach (string archivo in archivos)
                    {
                        listBoxContenido.Items.Add($"{indent}Archivo: {Path.GetFileName(archivo)}");
                    }
                }
                catch (Exception ex)
                {
                    listBoxContenido.Items.Add($"{indent}Error: {ex.Message}");
                }
            }
        }
    }
}

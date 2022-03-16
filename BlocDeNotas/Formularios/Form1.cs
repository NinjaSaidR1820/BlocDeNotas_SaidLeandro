#region Usos
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using AppCore.Procesos;
#endregion

namespace BlocDeNotas
{
    public partial class NoteBook : Form
    {
        #region Variable Global
        List<string> listaNotas = new List<string>();
        string rutapath = string.Empty;
        BlockNotas texto;
        #endregion

        #region Inicializar componente NoteBook
        public NoteBook(BlockDeNotas texto)
        {
            InitializeComponent();
            this.texto = Texto;
        }
        #endregion

        #region Botones Editar
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Copy();
        }
        private void pasteçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Paste();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.SelectAll();
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Clear();
        }
        #endregion

        #region Botones de Archivo
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbInformation.Clear();
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            AbrirArchivo();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }
        #endregion

        #region Metodo
        public void AbrirArchivo()
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "All Filter (*.txt) | *.txt";

            if(open.ShowDialog() == DialogResult.OK)
            {
                rtbInformation.Text = File.ReadAllText(open.FileName); 
            }
        }

        public void GuardarComo()
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Archivos de Texto (*.txt) | *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                rtbInformation.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public void Guardar()
        {
            SaveFileDialog saveas = new SaveFileDialog();
            StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);

            saveas.Filter = "Archivos de Texto (*.txt) | *.txt ";
            saveas.CheckFileExists = true;
            saveas.Title = "Guardar Como";
            saveas.ShowDialog(this);

            try
            {
                streamWriter = File.AppendText(saveas.Filter);
                streamWriter.Write(rtbInformation.Text);
                streamWriter.Flush();
            }
            catch
            {
            }
        }

        public void Salir()
        {
            DialogResult result = MessageBox.Show("Esta seguro de querer salir?", "Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Extras
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region Botones Del Arbol
        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvArbol.Nodes.Clear();
            openFileDialog1.Title = "Abrir carpeta... ";

            string text = string.Empty;

            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutapath = Path.GetDirectoryName(openFileDialog1.FileName);
                LoadFolder(TvArbol.Nodes, new DirectoryInfo(Path.GetDirectoryName(openFileDialog1.FileName)));
            }
        }

        private void agregarElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvArbol.SelectedNode.Nodes.Add(TxtNombre.Text);
            TxtNombre.Text = " ";
        }
        private void eliminarElementoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TvArbol.Nodes.Remove(TvArbol.SelectedNode);
        }
        #endregion

        #region 

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Guardar archivo como... ";

            string text = string.Empty;

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                {
                    MessageBox.Show(rtbInformation.Text);
                    string txt = saveFileDialog1.FileName;
                    texto.Add(rtbInformation.Text, txt);
                }
                else
                {
                    MessageBox.Show(rtbInformation.Text);
                    string txt = saveFileDialog1.FileName;
                    texto.Add(rtbInformation.Text, txt);
                }
            }
            rtbInformation.Text = string.Empty;
        }
        private void TvArbol_DoubleClick(object sender, EventArgs e)
        {
            rtbInformation.Text = string.Empty;
            string textos = string.Empty;

            textos = rutapath + "\\" + TvArbol.SelectedNode.Text;

            rtbInformation.Text = texto.Read((textos));
        }
        private void NoteBook_Load(object sender, EventArgs e)
        {
            TvArbol.Nodes.Clear();
        }


        #endregion

        
        private void LoadFolder(TreeNodeCollection nodes, DirectoryInfo folder)
        {
            var newNode = nodes.Add(folder.Name);
            foreach (var childFolder in folder.EnumerateDirectories())
            {
                LoadFolder(newNode.Nodes, childFolder);
            }
            foreach (FileInfo file in folder.EnumerateFiles())
            {
                newNode.Nodes.Add(file.Name);
            }
        }

        private void treevwFiles_DoubleClick(object sender, EventArgs e)
        {
            rtbInformation.Text = string.Empty;
            string textos = string.Empty;

            textos = rutapath + "\\" + TvArbol.SelectedNode.Text;

            rtbInformation.Text = texto.Read((textos));
        }

        private void guardarTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Guardar archivo como... ";

            string text = string.Empty;

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = false;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(saveFileDialog1.FileName))
                {
                    MessageBox.Show(rtbInformation.Text);
                    string txt = saveFileDialog1.FileName;
                    texto.Add(rtbInformation.Text, txt);
                }
                else
                {
                    MessageBox.Show(rtbInformation.Text);
                    string txt = saveFileDialog1.FileName;
                    texto.Add(rtbInformation.Text, txt);
                }
            }
            rtbInformation.Text = string.Empty;
        }
    }
}
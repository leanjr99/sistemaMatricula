using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploCurso
{
    public partial class cadastroForm : Form
    {
        public cadastroForm()
        {
            InitializeComponent();
        }
        string periodo;
       
        private void confirmarButton_Click(object sender, EventArgs e)
        {
            string nome = NomeTextBox.Text;
            DateTime dataMatricula = dataDeMatriculaDateTimePicker.Value;
            string cidade = cidadeComboBox.Text;
            bool periodoManha = periodoManhaRadioButton.Checked;
            bool periodoTarde = periodoTardeRadioButton.Checked;
            bool periodoNoite = periodoNoiteRadioButton.Checked;
            
            try
            {
                int ano = int.Parse(anoTextBox.Text);
                if (periodoManha == true)
                {
                    periodo = "Manhã";
                }
                else if (periodoTarde == true)
                {
                    periodo = "Tarde";
                }
                else
                {
                    periodo = "Noite";
                }
                MessageBox.Show("Nome: " + nome + " Data: de matrícula: " + dataMatricula + " Cidade: " + cidade
                    + " Periodo: " + periodo + " Ano:" + ano
                    );
            }
            catch (Exception)
            {
                MessageBox.Show("Ano incorreto");
            }


            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NomeTextBox.Text = "";
            cidadeComboBox.Text = "";
            periodoManhaRadioButton.Checked = false;
            periodoTardeRadioButton.Checked = false;
            periodoNoiteRadioButton.Checked = false;
            anoTextBox.Text = "";
            dataDeMatriculaDateTimePicker.Value = DateTime.Today;
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de ajuda em desenvolvimento");
        }

        private void cadastroForm_Load(object sender, EventArgs e)
        {

        }
    }
}

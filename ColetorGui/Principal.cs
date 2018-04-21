using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColetorGui
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            alunoTableAdapter.Fill(escolaDataSet.Aluno);
            classeTableAdapter.Fill(escolaDataSet.Classe);
            responsavelTableAdapter.Fill(escolaDataSet.Responsavel);
            //chamadaTableAdapter.Fill(escolaDataSet.Chamada);
        }

        private void lblData_Paint(object sender, PaintEventArgs e)
        {
            lblData.Text = DateTime.Today.ToShortDateString();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarChamada();
        }

        private void SalvarChamada()
        {
            bsChamada.EndEdit();
            chamadaTableAdapter.Adapter.Update(escolaDataSet.Chamada);
        }

        private void dgClasses_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                int classe = (int)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value;
                chamadaPorClasseTableAdapter.FillByClasse(escolaDataSet.Chamada, classe, DateTime.Today);
            }
            catch (Exception ex)
            {
                toolStripStatusLabelPadrao.Text = ex.Message;
            }
            
        }

        private void dgChamadaClasse_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            /*
            DateTime data = (DateTime)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value;
            int alunoId = (int)(sender as DataGridView).Rows[e.RowIndex].Cells[1].Value;
            bool presente = (bool)(sender as DataGridView).Rows[e.RowIndex].Cells[3].Value;
            int classe = (int)(sender as DataGridView).Rows[e.RowIndex].Cells[6].Value;

            chamadaTableAdapter.UpdateQuery(presente, data, alunoId);
            chamadaPorClasseTableAdapter.FillByClasse(escolaDataSet.Chamada, classe, DateTime.Today);
            */
            SalvarChamada();
        }
    }
}

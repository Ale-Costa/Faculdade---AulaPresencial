using Controllers;
using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsView
{
    public partial class frmExcluirAluno : Form
    {
        public frmExcluirAluno()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int matricula = int.Parse(txtMatriculaAluno.Text);

            AlunosController alunosController = new AlunosController();
            alunosController.Excluir(matricula);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtMatriculaAluno.Text = string.Empty;
        }
    }
}

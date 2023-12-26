using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace Jogo_da_Forca
{
    public partial class FrmInicio : Form
    {

        Thread Jogar;
        

        public FrmInicio()
        {
            InitializeComponent();
        }
        #region Jogar
        private void BtnJogar_Click(object sender, EventArgs e)
        {
             this.Close();
            Jogar = new Thread(NovoForm);
            Jogar.SetApartmentState(ApartmentState.MTA);
            Jogar.Start();
        }
        private void NovoForm()
        {
            Application.Run(new FrmJogar());
        }
        #endregion
        #region Fechar
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o jogo?", "Fechando", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        #region Como Jogar
        private void BtnInstrucoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Você terá 5 chances para acertar a palavra.\n\n" +
                "- Você ganha quando descobrir a palavra escondida.\n\n" +
                "- Uma dica será dada a cada palavra nova.\n\n" +
                "- Escolha letras para tentar adivinhar a palavra.\n\n" +
                "- Cada traço representa uma letra da palavra.", "Como Jogar", MessageBoxButtons.OK);           
        }
        #endregion        
        #region Botão sobre
        private void btnautoria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Luís Eduardo   RA: 166625\n\n Marcos Gabriel   RA: 170810\n\n Uriel Andrade   RA: 170295", "Autoria", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
        #endregion




    }
}

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
    public partial class FrmJogar : Form
    {

        #region Variaveis Globais
        Thread Inicio;
        string letra;
        int img, Acertos = 0, Erros = 0;
        string[] Geo = new string[15];
        string[] Port = new string[15];
        string[] Hist = new string[15];
        string[] Cien = new string[15];
        string[] DicaGeo = new string[15];
        string[] DicaPort = new string[15];
        string[] DicaHist = new string[15];
        string[] DicaCien = new string[15];
        string Palavrasglobal ,PalavraPort, PalavraHist, PalavraGeo, PalavraCien;
        string Dicas;
        int Score = 0;
        int materia;
        #endregion

        public FrmJogar()
        {
            InitializeComponent();
        }

        #region Palavras Geografia
        void PalavrasGeo()
        {
            Geo[0] = "PLANALTO"; DicaGeo[0] = "Terreno com elevações";
            Geo[1] = "TROPICAL"; DicaGeo[1] = "O Brasil é um país de clima...";
            Geo[2] = "TERRESTRE"; DicaGeo[2] = "O carro é um meio de transporte...";
            Geo[3] = "SALVADOR"; DicaGeo[3] = "Qual a capital da Bahia?";
            Geo[4] = "TERRENO"; DicaGeo[4] = "Qual nome se da a área da sua casa?";
            Geo[5] = "AMAZONAS"; DicaGeo[5] = "Qual o Estado do Brasil que tem muitas florestas?";
            Geo[6] = "NORDESTE"; DicaGeo[6] = "Em qual região que o Estado da Bahia fica?";
            Geo[7] = "ENSOLARADO"; DicaGeo[7] = "Um dia de sol é um dia...";
            Geo[8] = "MONTANHA"; DicaGeo[8] = "Grande monte de terra";
            Geo[9] = "CAATINGA"; DicaGeo[9] = "Local com cheiro desagradável";
            Geo[10] = "AVENIDAS"; DicaGeo[10] = "Qual o nome das maiores ruas de uma cidade?";
            Geo[11] = "BRASILEIRO"; DicaGeo[11] = "Quem nasceu no Brasil é...";
            Geo[12] = "AGRICULTURA"; DicaGeo[12] = "Como se chama o cultivo das plantas?";
            Geo[13] = "CONTINENTES"; DicaGeo[13] = "A Terra possue 6 no total";
            Geo[14] = "PRIMAVERA"; DicaGeo[14] = "Estação do ano";
        }
        #endregion
        #region Palavras Portugues
        void PalavrasPort()
        {
            Port[0] = "ADJETIVO"; DicaPort[0] = "O que da qualidade a um substativo?";
            Port[1] = "PRONOMES"; DicaPort[1] = "O que pode substituir um Substantivo?";
            Port[2] = "PARADOXO"; DicaPort[2] = "Contradição";
            Port[3] = "AUMENTATIVO"; DicaPort[3] = "Aumentar o sentido de uma palavra";
            Port[4] = "DIMINUTIVO"; DicaPort[4] = "Diminuir o sentido de uma palavra";
            Port[5] = "SUBSTANTIVO"; DicaPort[5] = "Classe que define nomes";
            Port[6] = "LITERATURA"; DicaPort[6] = "Matéria relacionada aos livros";
            Port[7] = "ABSTRATO"; DicaPort[7] = "Algo que não é real";
            Port[8] = "TRSNSITIVO"; DicaPort[8] = "Verbo que precisa de complemento";
            Port[9] = "COMPLEXO"; DicaPort[9] = "Algo difícil de entender";
            Port[10] = "ALFABETO"; DicaPort[10] = "Ordem das letras";
            Port[11] = "ESCREVER"; DicaPort[11] = "Ato de escrita";
            Port[12] = "CONSOANTES"; DicaPort[12] = "Vogais e...";
            Port[13] = "POLISSILABA"; DicaPort[13] = "Qual o nome de uma palavra com 4 silabas?";
            Port[14] = "TRITONGO"; DicaPort[14] = "Junção de 3 consoantes";
        }
        #endregion
        #region Palavras História
        void PalavrasHist()
        {
            Hist[0] = "ESFINGES"; DicaHist[0] = "Qual é a estrutura feita pelos Egípcios que se assemelha a um ser humano?";
            Hist[1] = "ESCULTURAS"; DicaHist[1] = "Arte que representa ou ilustra imagens";
            Hist[2] = "CARAVELAS"; DicaHist[2] = "Navios utilizados pelos Portugueses";
            Hist[3] = "INTERNACIONAL"; DicaHist[3] = "Relaçoes entre países";
            Hist[4] = "INGLATERRA"; DicaHist[4] = "País ao qual o Brasil tinha uma dívida";
            Hist[5] = "GUERRILHAS"; DicaHist[5] = "Derivado de guerras";
            Hist[6] = "VIKINGS"; DicaHist[6] = "Povo bárbaro";
            Hist[7] = "SAQUEADORES"; DicaHist[7] = "Apelido dos piratas";
            Hist[8] = "ALEXANDRE"; DicaHist[8] = "Grande Imperador Macedônico";
            Hist[9] = "MONARQUIA"; DicaHist[9] = "Governo feito por um rei";
            Hist[10] = "AFRODITE"; DicaHist[10] = "Deusa Grega conhecida por sua beleza";
            Hist[11] = "POSEIDON"; DicaHist[11] = "Imperador dos Mares na cultura Grega";
            Hist[12] = "MEDIEVAL"; DicaHist[12] = "Época das cavalarias";
            Hist[13] = "CAVALEIRO"; DicaHist[13] = "Homem nobre";
            Hist[14] = "PRINCESA"; DicaHist[14] = "Filha do rei";

        }
        #endregion
        #region Palavras Ciências
        void PalavrasCien()
        {
            Cien[0] = "CACHORRO"; DicaCien[0] = "Qual o melhor amigo do homem?";
            Cien[1] = "VITAMINAS"; DicaCien[1] = "Substâncias que ajudam na saúde do corpo?";
            Cien[2] = "DECOMPOSITORES"; DicaCien[2] = "Responsáveis pela decomposição";
            Cien[3] = "DIGESTIVO"; DicaCien[3] = "Sitema responsável por processar o alimento";
            Cien[4] = "ELEFANTE"; DicaCien[4] = "Espécies de lagartos extinta";
            Cien[5] = "GRAVIDADE"; DicaCien[5] = "Força da Terra";
            Cien[6] = "SEMENTES"; DicaCien[6] = "Grãos que possuem fruto";
            Cien[7] = "SENTIDOS"; DicaCien[7] = "Os humanos possuem 5";
            Cien[8] = "METAMORFOSE"; DicaCien[8] = "Transformação das borboletas";
            Cien[9] = "GOLFINHO"; DicaCien[9] = "Mamífero que possue dois cérebros";
            Cien[10] = "BORBOLETA"; DicaCien[10] = "Inseto voador";
            Cien[11] = "INDICADOR"; DicaCien[11] = "Qual dedo você aponta?";
            Cien[12] = "ESTRELAS"; DicaCien[12] = "Iluminam o céu";
            Cien[13] = "ESQUELETO"; DicaCien[13] = "Formação de ossos do seu corpo";
            Cien[14] = "DINOSSAURO"; DicaCien[14] = "Animal pré-historico";
        }
        #endregion

        #region Void Novo Jogo
        void NovoJogo()
        {

            btnQ.Enabled = true; btnQ.ForeColor = Color.Black;
            btnW.Enabled = true; btnW.ForeColor = Color.Black;
            btnE.Enabled = true; btnE.ForeColor = Color.Black;
            btnR.Enabled = true; btnR.ForeColor = Color.Black;
            btnT.Enabled = true; btnT.ForeColor = Color.Black;
            btnY.Enabled = true; btnY.ForeColor = Color.Black;
            btnU.Enabled = true; btnU.ForeColor = Color.Black;
            btnI.Enabled = true; btnI.ForeColor = Color.Black;
            btnO.Enabled = true; btnO.ForeColor = Color.Black;
            btnP.Enabled = true; btnP.ForeColor = Color.Black;
            btnA.Enabled = true; btnA.ForeColor = Color.Black;
            btnS.Enabled = true; btnS.ForeColor = Color.Black;
            btnD.Enabled = true; btnD.ForeColor = Color.Black;
            btnF.Enabled = true; btnF.ForeColor = Color.Black;
            btnG.Enabled = true; btnG.ForeColor = Color.Black;
            btnH.Enabled = true; btnH.ForeColor = Color.Black;
            btnJ.Enabled = true; btnJ.ForeColor = Color.Black;
            btnK.Enabled = true; btnK.ForeColor = Color.Black;
            btnL.Enabled = true; btnL.ForeColor = Color.Black;
            btnÇ.Enabled = true; btnÇ.ForeColor = Color.Black;
            btnZ.Enabled = true; btnZ.ForeColor = Color.Black;
            btnX.Enabled = true; btnX.ForeColor = Color.Black;
            btnC.Enabled = true; btnC.ForeColor = Color.Black;
            btnV.Enabled = true; btnV.ForeColor = Color.Black;
            btnB.Enabled = true; btnB.ForeColor = Color.Black;
            btnN.Enabled = true; btnN.ForeColor = Color.Black;
            btnM.Enabled = true; btnM.ForeColor = Color.Black;

            btnQ.Visible = false;
            btnW.Visible = false;
            btnE.Visible = false;
            btnR.Visible = false;
            btnT.Visible = false;
            btnY.Visible = false;
            btnU.Visible = false;
            btnI.Visible = false;
            btnO.Visible = false;
            btnP.Visible = false;
            btnA.Visible = false;
            btnS.Visible = false;
            btnD.Visible = false;
            btnF.Visible = false;
            btnG.Visible = false;
            btnH.Visible = false;
            btnJ.Visible = false;
            btnK.Visible = false;
            btnL.Visible = false;
            btnÇ.Visible = false;
            btnZ.Visible = false;
            btnX.Visible = false;
            btnC.Visible = false;
            btnV.Visible = false;
            btnB.Visible = false;
            btnN.Visible = false;
            btnM.Visible = false;

            btngeografia.Visible = true;
            btnportugues.Visible = true;
            btnciencias.Visible = true;
            btnhistoria.Visible = true;

            lblpalavra.Visible = false;
            btnnovojogo.Visible = false;
            pbxforca.Visible = false;
            BtnVoltar.Visible = true;
            btnvoltartema.Visible = false;
            btntema.Visible = true;
            lbldica.Visible = false;
            lbldica.Text = "";
       

            Acertos = 0; img = 1;
            Erros = 0;
            pbxforca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\forca1.png");
            Palavrasglobal = null;

            
        }
        #endregion
        #region Void Muda Botão
        void MudaBotão()
        {
            btnQ.Visible = true;
            btnW.Visible = true;
            btnE.Visible = true;
            btnR.Visible = true;
            btnT.Visible = true;
            btnY.Visible = true;
            btnU.Visible = true;
            btnI.Visible = true;
            btnO.Visible = true;
            btnP.Visible = true;
            btnA.Visible = true;
            btnS.Visible = true;
            btnD.Visible = true;
            btnF.Visible = true;
            btnG.Visible = true;
            btnH.Visible = true;
            btnJ.Visible = true;
            btnK.Visible = true;
            btnL.Visible = true;
            btnÇ.Visible = true;
            btnZ.Visible = true;
            btnX.Visible = true;
            btnC.Visible = true;
            btnV.Visible = true;
            btnB.Visible = true;
            btnN.Visible = true;
            btnM.Visible = true;

            btngeografia.Visible = false;
            btnportugues.Visible = false;
            btnciencias.Visible = false;
            btnhistoria.Visible = false;

            pbxforca.Visible = true;
            btnnovojogo.Visible = true;
            lblpalavra.Visible = true;
            btntema.Visible = false;
            BtnVoltar.Visible = false;
            btnvoltartema.Visible = true;
            
          
            lbldica.Visible = true;
            img = 1;
            pbxforca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\forca1.png");

        }
        #endregion
        #region Void Verifica Letras
        void Letras()
        {          

            switch (materia)
            {
                case 1:
                    Palavrasglobal = PalavraPort;
                    break;
                case 2:
                    Palavrasglobal = PalavraHist;
                    break;
                case 3:
                    Palavrasglobal = PalavraGeo;
                    break;
                case 4:
                    Palavrasglobal = PalavraCien;
                    break;
            }

            bool Acerto = false;
            for (int i = 0; i < Palavrasglobal.Length; i++)
            {
                string LetraDaPalavra = Palavrasglobal.Substring(i, 1);

                if (LetraDaPalavra == letra)
                {
                    lblpalavra.Text = lblpalavra.Text.Remove(i * 2, 1).Insert(i * 2, LetraDaPalavra);
                    Acerto = true;
                    Acertos++;
                    Score += 10;
                    lblScore.Text = Convert.ToString(Score);
                    
                    
                }
            }

                if (!Acerto)
                {
                    Erros++;
                    img = img % 6 + 1;
                    pbxforca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\forca" + Convert.ToString(img) + ".png");                   
                  
                }

                if (Erros > 5)
                {
                    MessageBox.Show("Nunca desista! Mais sorte na próxima vez.");
                    NovoJogo();

                }
                else if (Acertos >= Palavrasglobal.Length)
                {
                    MessageBox.Show("Parabéns, hoje é seu dia!");
                    NovoJogo();
                }
            }
       
        #endregion

        #region Voltar
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio = new Thread(NovoForm);
            Inicio.SetApartmentState(ApartmentState.MTA);
            Inicio.Start();
        }
        private void NovoForm()
        {
            Application.Run(new FrmInicio());
        }
        #endregion      

        #region Botões Letras
        private void btnQ_Click_1(object sender, EventArgs e)
        {
            letra = "Q";
            btnQ.Enabled = false;
            btnQ.ForeColor = Color.Red;
            Letras();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            letra = "W";
            btnW.Enabled = false;
            btnW.ForeColor = Color.Red;
            Letras();
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            letra = "E";
            btnE.Enabled = false;
            btnE.ForeColor = Color.Red;
            Letras();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            letra = "R";
            btnR.Enabled = false;
            btnR.ForeColor = Color.Red;
            Letras();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            letra = "T";
            btnT.Enabled = false;
            btnT.ForeColor = Color.Red;
            Letras();
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            letra = "Y";
            btnY.Enabled = false;
            btnY.ForeColor = Color.Red;
            Letras();
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            letra = "U";
            btnU.Enabled = false;
            btnU.ForeColor = Color.Red;
            Letras();

        }

        private void btnI_Click(object sender, EventArgs e)
        {
            letra = "I";
            btnI.Enabled = false;
            btnI.ForeColor = Color.Red;
            Letras();
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            letra = "O";
            btnO.Enabled = false;
            btnO.ForeColor = Color.Red;
            Letras();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            letra = "P";
            btnP.Enabled = false;
            btnP.ForeColor = Color.Red;
            Letras();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            letra = "A";
            btnA.Enabled = false;
            btnA.ForeColor = Color.Red;
            Letras();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            letra = "S";
            btnS.Enabled = false;
            btnS.ForeColor = Color.Red;
            Letras();
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            letra = "D";
            btnD.Enabled = false;
            btnD.ForeColor = Color.Red;
            Letras();
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            letra = "F";
            btnF.Enabled = false;
            btnF.ForeColor = Color.Red;
            Letras();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            letra = "G";
            btnG.Enabled = false;
            btnG.ForeColor = Color.Red;
            Letras();

        }

        private void btnH_Click(object sender, EventArgs e)
        {
            letra = "H";
            btnH.Enabled = false;
            btnH.ForeColor = Color.Red;
            Letras();
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            letra = "J";
            btnJ.Enabled = false;
            btnJ.ForeColor = Color.Red;
            Letras();
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            letra = "K";
            btnK.Enabled = false;
            btnK.ForeColor = Color.Red;
            Letras();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            letra = "L";
            btnL.Enabled = false;
            btnL.ForeColor = Color.Red;
            Letras();
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            letra = "Ç";
            btnÇ.Enabled = false;
            btnÇ.ForeColor = Color.Red;
            Letras();

        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            letra = "Z";
            btnZ.Enabled = false;
            btnZ.ForeColor = Color.Red;
            Letras();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            letra = "X";
            btnX.Enabled = false;
            btnX.ForeColor = Color.Red;
            Letras();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            letra = "C";
            btnC.Enabled = false;
            btnC.ForeColor = Color.Red;
            Letras();
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            letra = "V";
            btnV.Enabled = false;
            btnV.ForeColor = Color.Red;
            Letras();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            letra = "B";
            btnB.Enabled = false;
            btnB.ForeColor = Color.Red;
            btnB.ForeColor = Color.Red;
            Letras();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            letra = "N";
            btnN.Enabled = false;
            btnN.ForeColor = Color.Red;
            btnN.ForeColor = Color.Red;
            Letras();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            letra = "M";
            btnM.Enabled = false;
            btnM.ForeColor = Color.Red;
            Letras();

        }
        #endregion
        #region Botão Novo Jogo
        private void btnnovojogo_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }
        #endregion
        #region Botão Voltar
        private void BtnVoltar1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio = new Thread(NovoForm);
            Inicio.SetApartmentState(ApartmentState.MTA);
            Inicio.Start();
        }
        #endregion

        #region Botão Português
        private void btnportugues_Click(object sender, EventArgs e)
        {
            lblScore.Visible = true;
            lblScore.Text = "0";
            lblScoreMSG.Visible = true;
            PalavrasPort();

            materia = 1;

            Random MudarNum = new Random();
            int num = MudarNum.Next(0, 14);

            PalavraPort = Port[num];
            Dicas = DicaPort[num];
            lbldica.Text = Dicas;
            lblpalavra.Text = "";      

            for (int i = 0; i < PalavraPort.Length; i++)
            {
                lblpalavra.Text += "_ ";
            }

            MudaBotão();

        }
        #endregion
        #region Botão Historia
        private void btnhistoria_Click(object sender, EventArgs e)
        {
            lblScore.Visible = true;
            lblScore.Text = "0";
            lblScoreMSG.Visible = true;
            PalavrasHist();

            materia = 2;

            Random MudarNum = new Random();
            int num = MudarNum.Next(0, 14);

            PalavraHist = Hist[num];
            Dicas = DicaHist[num];
            lbldica.Text = Dicas;
            lblpalavra.Text = "";

        

            for (int i = 0; i < PalavraHist.Length; i++)
            {
                lblpalavra.Text += "_ ";
            }

            MudaBotão();

        }
        #endregion
        #region Botão Geografia
        private void btngeografia_Click(object sender, EventArgs e)
        {
            lblScore.Visible = true;
            lblScore.Text = "0";
            lblScoreMSG.Visible = true;
            PalavrasGeo();

            materia = 3;

            Random MudarNum = new Random();
            int num = MudarNum.Next(0, 14);

            PalavraGeo = Geo[num];
            Dicas = DicaGeo[num];
            lbldica.Text = Dicas;
            lblpalavra.Text = "";

            for (int i = 0; i < PalavraGeo.Length; i++)
            {
                lblpalavra.Text += "_ ";
            }

            MudaBotão();

        }
        #endregion
        #region Botão Ciências
        private void btnciencias_Click(object sender, EventArgs e)
        {
            lblScore.Visible = true;
            lblScore.Text = "0";
            lblScoreMSG.Visible = true;
            PalavrasCien();

            materia = 4;

            Random MudarNum = new Random();
            int num = MudarNum.Next(0, 14);


            PalavraCien = Cien[num];
            Dicas = DicaCien[num];
            lbldica.Text = Dicas;
            lblpalavra.Text = "";
            
            for (int i = 0; i < PalavraCien.Length; i++)
            {
                lblpalavra.Text += "_ ";
            }

            MudaBotão();

        }
        #endregion

        #region Botão Tema
        private void btntema_Click(object sender, EventArgs e)
        {
            btnQ.Visible = false;
            btnW.Visible = false;
            btnE.Visible = false;
            btnR.Visible = false;
            btnT.Visible = false;
            btnY.Visible = false;
            btnU.Visible = false;
            btnI.Visible = false;
            btnO.Visible = false;
            btnP.Visible = false;
            btnA.Visible = false;
            btnS.Visible = false;
            btnD.Visible = false;
            btnF.Visible = false;
            btnG.Visible = false;
            btnH.Visible = false;
            btnJ.Visible = false;
            btnK.Visible = false;
            btnL.Visible = false;
            btnÇ.Visible = false;
            btnZ.Visible = false;
            btnX.Visible = false;
            btnC.Visible = false;
            btnV.Visible = false;
            btnB.Visible = false;
            btnN.Visible = false;
            btnM.Visible = false;

            btngeografia.Visible = false;
            btnportugues.Visible = false;
            btnciencias.Visible = false;
            btnhistoria.Visible = false;

            lblpalavra.Visible = false;
            btnnovojogo.Visible = false;
            pbxforca.Visible = false;

            btnbarbie.Visible = true;
            btncarros.Visible = true;
            btnmaxsteel.Visible = true;
            btnpolly.Visible = true;
            btnluccasneto.Visible = true;

            BtnVoltar.Visible = false;
            btntema.Visible = false;
            btnvoltartema.Visible = true;
            lbldica.Visible = false;
            lbldica.Text = "";

        }
        #endregion
        #region Temas
        private void btnbarbie_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\barbie.jpg");
        }

        private void btncarros_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\carros.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\bobesponja.png");
        }

        private void btnpolly_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\pollypocket.jpg");
        }
        private void btnluccasneto_Click(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\luccasneto.jpg");
        }

        #endregion
        #region Botão Voltar Tema
        private void btnvoltartema_Click(object sender, EventArgs e)
        {
            btnQ.Visible = false;
            btnW.Visible = false;
            btnE.Visible = false;
            btnR.Visible = false;
            btnT.Visible = false;
            btnY.Visible = false;
            btnU.Visible = false;
            btnI.Visible = false;
            btnO.Visible = false;
            btnP.Visible = false;
            btnA.Visible = false;
            btnS.Visible = false;
            btnD.Visible = false;
            btnF.Visible = false;
            btnG.Visible = false;
            btnH.Visible = false;
            btnJ.Visible = false;
            btnK.Visible = false;
            btnL.Visible = false;
            btnÇ.Visible = false;
            btnZ.Visible = false;
            btnX.Visible = false;
            btnC.Visible = false;
            btnV.Visible = false;
            btnB.Visible = false;
            btnN.Visible = false;
            btnM.Visible = false;

            btngeografia.Visible = true;
            btnportugues.Visible = true;
            btnciencias.Visible = true;
            btnhistoria.Visible = true;

            lblpalavra.Visible = false;
            btnnovojogo.Visible = false;
            pbxforca.Visible = false;

            btnbarbie.Visible = false;
            btncarros.Visible = false;
            btnmaxsteel.Visible = false;
            btnpolly.Visible = false;
            btnluccasneto.Visible = false;

            btnvoltartema.Visible = false;
            btntema.Visible = true;

            BtnVoltar.Visible = true;
           
            lbldica.Visible = false;
            lbldica.Text = "";
            NovoJogo();
        }
        #endregion
        #region Botão fechar
        private void FrmJogar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Fechar jogo?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }

    }

using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;

namespace LerArquivoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextReader reader = new XmlTextReader(txtCaminhoXML.Text);
            ArrayList elementos = new ArrayList();

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                elementos.Add(reader.Value);
                            }
                        }
                        break;
                    case XmlNodeType.Text:
                        elementos.Add(reader.Value);
                        break;
                }
            }
            foreach (var num in elementos)
            {
                lstXML.Items.Add(num);
            }
        }

        private void btnLerTag_Click(object sender, EventArgs e)
        {
            //Cria uma instância de um documento XML
            XmlDocument oXML = new XmlDocument();

            //Define o caminho do arquivo XML
            string ArquivoXML = txtCaminhoXML.Text;
            //Carrega o arquivo XML
            oXML.Load(ArquivoXML);

            //Le o filho de um no pai especifico
            string nomeAluno = oXML.SelectSingleNode("Alunos").ChildNodes[0].InnerText;
            string idadeAluno = oXML.SelectSingleNode("Alunos").ChildNodes[1].InnerText;
            string emailAluno = oXML.SelectSingleNode("Alunos").ChildNodes[2].InnerText;

            //Exibe dados do aluno
            lstXML.Items.Add(nomeAluno);
            lstXML.Items.Add(idadeAluno);
            lstXML.Items.Add(emailAluno);

            //Endereco do aluno
            for (int i = 0; i < 4; i++)
            {
                lstXML.Items.Add(oXML.SelectSingleNode("Alunos").ChildNodes[3].ChildNodes[i].InnerText);
            }
        }
    }
}

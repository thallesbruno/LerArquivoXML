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
                
            }
        }
    }
}

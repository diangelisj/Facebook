using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Facebook
{
    public partial class Facebook : Form
    {
        public Facebook()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("email").SetAttribute("value", "email");
            webBrowser1.Document.GetElementById("pass").SetAttribute("value", "senha");
            //https://www.facebook.com/?ref=logo   // link que será clicado após o login

            
           

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Document != null)
            {
                HtmlElementCollection elems = webBrowser1.Document.GetElementsByTagName("Button");
                foreach (HtmlElement elem in elems)
                {
                    String nameStr = elem.GetAttribute("name");
                    if (nameStr != null && nameStr.Length != 0)
                    {
                        String contentStr = elem.GetAttribute("content");
                        MessageBox.Show("Document: " + webBrowser1.Url.ToString() + "\nDescription: " + contentStr);
                    }
                }
            }
        }

    }
}

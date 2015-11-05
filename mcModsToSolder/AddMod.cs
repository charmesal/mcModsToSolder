using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace mcModsToSolder
{
    public partial class AddMod : Form
    {
        public AddMod()
        {
            InitializeComponent();
            //this.Location = new Point(10000, 10000);
            this.Location = new Point(100, 100);
            this.Visible = false;
            webBrowser1.Navigate("http://solder.chaoticscience.org/login");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MessageBox.Show("hello");
            if (webBrowser1.Url.ToString().EndsWith("login"))
            {
                foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("input"))
                {
                    if (he.Name == "email")
                    {
                        he.SetAttribute("value", "kevindullens3@hotmail.com");
                    }
                    else if (he.Name == "password")
                    {
                        he.SetAttribute("value", "#include");
                    }
                }

                foreach (HtmlElement form in webBrowser1.Document.Forms)
                    form.InvokeMember("submit");
            }

            else if (webBrowser1.Url.ToString().EndsWith("dashboard"))
            {
                webBrowser1.Navigate("http://solder.chaoticscience.org/mod/create");
            }
            else if (webBrowser1.Url.ToString().EndsWith("mod/create"))
            {
                if (webBrowser1.Document.Body.InnerHtml.Contains("The slug you entered is already taken"))
                {
                    // Slug bestaat al!
                    return;
                }

                // Mod Name
                webBrowser1.Document.GetElementById("pretty_name").SetAttribute("value", "kevin1");

                // Mod Slug
                webBrowser1.Document.GetElementById("name").SetAttribute("value", "kevin1");

                // Author
                webBrowser1.Document.GetElementById("author").SetAttribute("value", "kevin1");

                // Description
                webBrowser1.Document.GetElementById("description").SetAttribute("value", "kevin1");

                // Mod website
                webBrowser1.Document.GetElementById("link").SetAttribute("value", "kevin1");

                // Author Donations
                webBrowser1.Document.GetElementById("donatelink").SetAttribute("value", "kevin1");

                foreach (HtmlElement form in webBrowser1.Document.Forms)
                    form.InvokeMember("submit");
            }
            else if (webBrowser1.Url.ToString().Contains("mod/view"))
            {
                // do stuff
            }
        }
    }
}

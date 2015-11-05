using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mcModsToSolder
{
    public partial class Form1 : Form
    {
        string selectedFolder;
        public Form1()
        {
            selectedFolder = "";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine;
                string parentKeyLocation = @"SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl";
                string keyName = "FEATURE_BROWSER_EMULATION";
                RegistryKey subkey = key.CreateSubKey(parentKeyLocation);
                subkey = subkey.CreateSubKey(keyName);
                subkey.SetValue(Process.GetCurrentProcess().ProcessName + ".exe", 11001);
            }
            catch (Exception)
            {
                this.Location = new Point(10000, 10000);
                MessageBox.Show("Please start the application as admin");
                Application.Exit();
            }
            webBrowser1.Navigate("http://solder.chaoticscience.org/login");
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            AddMod addMod = new AddMod();
            if (addMod.ShowDialog() == DialogResult.OK)
            {

            }
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
        private void btnChooseInitialFolder_Click(object sender, EventArgs e)
        {
            string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            FolderBrowserDialog choosefolder = new FolderBrowserDialog();
            choosefolder.SelectedPath = startupFolder;
            DialogResult result = choosefolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedFolder = choosefolder.SelectedPath;
                SetModsFromFolderInList(selectedFolder);
            }
        }

        public void SetModsFromFolderInList(string selectedFolder)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(selectedFolder);
            FileInfo[] files = directoryInfo.GetFiles();
            lbFoudMods.Items.Clear();
            foreach (FileInfo file in files)
            {
                lbFoudMods.Items.Add(file.Name);
            }
        }


    }
}

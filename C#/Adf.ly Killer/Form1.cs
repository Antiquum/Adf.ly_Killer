// Adf.ly Killer 0.5
// (C) Doddy Hackman 2016
// Credits : Thanks to fudmario

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;
using System.IO;

namespace Adf.ly_Killer
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string base64_encode(string texto)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(texto));
        }

        public string base64_decode(string texto)
        {
            return System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(texto));
        }

        private Boolean check_link(string link)
        {
            Match regex = Regex.Match(link, "adf.ly", RegexOptions.IgnoreCase);
            if (regex.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string adfly_decode(string link_to_decode)
        {
            string link_decoded = "";
            DH_Tools tools = new DH_Tools();
            string code = tools.toma(link_to_decode);
            Match regex = Regex.Match(code, "var ysmm = '(.*?)';", RegexOptions.IgnoreCase);
            if (regex.Success)
            {
                string link = regex.Groups[1].Value;
                string left = "";
                string right = "";
                for (int i = 0; i < link.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        left = left + Convert.ToString(link[i]);
                    }
                    else
                    {
                        right = Convert.ToString(link[i]) + right;
                    }
                }
                string link_encoded = base64_decode(left + right);
                string link_ready = link_encoded.Substring(2);
                link_decoded = link_ready;

            }
            if (link_decoded == "")
            {
                link_decoded = "???";
            }
            return link_decoded;
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            if (txtEnterLink.Text != "")
            {
                if (check_link(txtEnterLink.Text))
                {
                    status.Text = "[+] Decoding ...";
                    this.Refresh();
                    string result = adfly_decode(txtEnterLink.Text);
                    if (result != "???")
                    {
                        txtResult.Text = result;
                        status.Text = "[+] Link Decoded";
                        this.Refresh();
                    }
                    else
                    {
                        txtResult.Text = "Not Found";
                        status.Text = "[-] Not Found";
                        this.Refresh();
                    }
                }
                else
                {
                    status.Text = "[-] Link Invalid";
                    this.Refresh();
                }
            }
            else
            {
                status.Text = "[-] Enter Link to decode";
                this.Refresh();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(txtResult.Text);
                status.Text = "[+] Link copied to clipboard";
                this.Refresh();
            }
            catch
            {
                //
            }
        }

        private void miAddLink_Click(object sender, EventArgs e)
        {
            string link = Interaction.InputBox("Enter Link : ", "Adf.ly Killer 0.5", "");
            if (link != "")
            {
                if (check_link(link))
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = link;
                    item.SubItems.Add("...");
                    lvLinks.Items.Add(item);
                    status.Text = "[+] Link Added";
                    this.Refresh();
                }
                else
                {
                    status.Text = "[-] Link Invalid";
                    this.Refresh();
                }
            }
            else
            {
                status.Text = "[-] Enter Link";
                this.Refresh();
            }
        }

        private void miAddWordlist_Click(object sender, EventArgs e)
        {
            odOpenFile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath); ;
            DialogResult resultado = odOpenFile.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string filename = odOpenFile.FileName;
                int counter = 0;
                if (File.Exists(filename))
                {
                    var lines = File.ReadAllLines(filename);
                    foreach (var line in lines)
                    {
                        if (check_link(line))
                        {
                            ListViewItem item = new ListViewItem();
                            item.Text = line;
                            item.SubItems.Add("...");
                            lvLinks.Items.Add(item);
                            counter = counter + 1;
                        }
                    }
                    if (counter > 0)
                    {
                        status.Text = "[+] Links Added : " + counter.ToString();
                        this.Refresh();
                    }
                    else
                    {
                        status.Text = "[-] Links not found";
                        this.Refresh();
                    }
                }
                else
                {
                    status.Text = "[-] Enter Valid Filename";
                    this.Refresh();
                }
            }
        }

        private void miClearList_Click(object sender, EventArgs e)
        {
            lvLinks.Items.Clear();
        }

        private void miKill_Click(object sender, EventArgs e)
        {
            if (lvLinks.Items.Count > 0)
            {
                for (int i = 0; i < lvLinks.Items.Count; i++)
                {
                    ListViewItem item = lvLinks.Items[i];
                    string link_to_decode = item.Text;
                    status.Text = "[+] Checking : " + link_to_decode + " ...";
                    this.Refresh();
                    string result = adfly_decode(link_to_decode);
                    if (result != "???")
                    {
                        lvLinks.Items[i].SubItems[1].Text = result;
                        status.Text = "[+] " + link_to_decode+" : "+result;
                        this.Refresh();
                    }
                    else
                    {
                        lvLinks.Items[i].SubItems[1].Text = "Not Found";
                        status.Text = "[-] " + link_to_decode + " : " + "Not Found";
                        this.Refresh();
                    }
                }
                status.Text = "[+] Finished";
                this.Refresh();
            }
            else
            {
                status.Text = "[-] Links not found";
                this.Refresh();
            }
        }

        private void miCopy_Click(object sender, EventArgs e)
        {

            if (lvLinks.SelectedIndices.Count > 0 && lvLinks.SelectedIndices[0] != -1)
            {
                string link = lvLinks.SelectedItems[0].SubItems[1].Text;
                if (link != "..." || link!="Not Found")
                {
                    try
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(link);
                        status.Text = "[+] Link copied to clipboard";
                        this.Refresh();
                    }
                    catch
                    {
                        //
                    }
                }
            }
        }

    }
}

// The End ?
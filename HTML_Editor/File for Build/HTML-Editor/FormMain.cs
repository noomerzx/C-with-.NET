﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTML_Editor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            webPage.DocumentText = tbxEditor.Text;
        }

        private void cmbExampleCode_TextChanged(object sender, EventArgs e)
        {
            if(cmbExampleCode.Text=="Example-Button_Alert")
            {
                tbxEditor.Text = "<html>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<body>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<button type=\"button\" onclick=\"alert('Good Morning Teacher')\">Click Me for Alert</button>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</body>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</html>";
            }
            else if(cmbExampleCode.Text=="Example-Text_and_Table")
            {
                tbxEditor.Text = "<html>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<body>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<font size=\"5\" color=\"black\">Example TEXT Header</font>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<br>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<font face=\"Tahoma\" color=\"blue\">Example TEXT Header-II";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<br>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<font size=\"2\" color=\"green\">Example TEXT Heade-III</font>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<br>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<table border=\"2\">";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<tr>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<th><font size=\"3\" color=\"red\">HeadTable-I</th>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<th><font size=\"3\" color=\"red\">HeadTable-I</th>"; ;
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</tr>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<tr>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<td>row-I,Cell-I</td>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<td>row-I,Cell-II</td>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</tr>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<tr>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<td>row-II,Cell-I</td>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<td>row-II,Cell-II</td>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</tr>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</body>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</html>";
            }
            else if (cmbExampleCode.Text == "Example-Css_BackgroundColor")
            {
                tbxEditor.Text = "<html>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<head>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<style type=\"text/css\">";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "body{ background-color:black; }";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += ".bgred{ background-color:red; }";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += ".bgblue{ background-color:blue; }";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += ".bggreen{ background-color:green; }";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += ".bgyellow{ background-color:yellow; }";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += ".bgwhite{ background-color:white; }";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</style>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</head>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<body>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<div class=\"bgred\" height=\"200\">TEXT IN RED-BG</div>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<div class=\"bgblue\" height=\"200\">TEXT IN BLUE-BG</div>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<div class=\"bggreen\" height=\"200\">TEXT IN GREEN-BG</div>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<div class=\"bgyellow\" height=\"200\">TEXT IN YELLOW-BG</div>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "<div class=\"bgwhite\" height=\"200\">TEXT IN WHITE-BG</div>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</body>";
                tbxEditor.Text += "\r\n";
                tbxEditor.Text += "</html>";
            }
            else
            { 
                tbxEditor.Text="Type Some HTML Code Here";
            }

        }

        private void tbxEditor_Click(object sender, EventArgs e)
        {
            tbxEditor.Text = "";
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ims
{
    internal class Main
    {
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static string s = File.ReadAllText(path+"\\connect");
        public static SqlConnection con = new SqlConnection(s);

        public static void showWindow(Form openWin, Form hideWin, Form? MDIWin) 
        {
            hideWin.Close();

            // Set parrent Window
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void showWindow(Form openWin, Form MDIWin)
        {
            // Set parrent Window
            openWin.MdiParent = MDIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }

        public static void disable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = string.Empty;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                    dtp.Value = DateTime.Now;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)c;
                    nud.Enabled = false;
                    nud.Value = 0;
                }
            }
        }

        public static void disable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = false;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)c;
                    nud.Enabled = false;
                }
            }
        }

        public static void enable_reset(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = string.Empty;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                    cb.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                    rb.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                    cb.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                    dtp.Value = DateTime.Now;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)c;
                    nud.Enabled = true;
                    nud.Value = 0;
                }
            }
        }

        public static void enable(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox cb = (ComboBox)c;
                    cb.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton rb = (RadioButton)c;
                    rb.Enabled = true;
                }
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    cb.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)c;
                    dtp.Enabled = true;
                }
                if (c is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)c;
                    nud.Enabled = true;
                }
            }
        }

        public static DialogResult ShowMSG(string msg, string heading, string type)
        {
            if (type == "Success")
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Auto_Definition
{
    public partial class Form1 : Form
    {
        private delegate void SetListBoxDelegate(string[] value);

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        //initialize matching process terminator
        private bool EndMatching = false;

        //initialize library
        private static Library mainLib = new Library();

        private void Form1_Load(object sender, EventArgs e)
        {
            LibraryUtility.Load(mainLib);
            if (mainLib == null)
            {
                LibraryUtility.DeleteLibrary();
                this.Close();
            }
        }

        #region theme

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //open list
            if (openListDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            listEnglish.Items.Clear(); listChinese.Items.Clear();

            string[] a;
            a = System.IO.File.ReadAllLines(openListDialog.FileName);

            foreach (string i in a)
            {
                if (i.Length != 0)//exclude empty lines
                {
                    listEnglish.Items.Add(i.Trim());
                    listChinese.Items.Add("");//initialize eng list
                }
            }

            listItemNavigator.Maximum = listEnglish.Items.Count;
        }

        private Point FrmBeforeLoc = new Point(0, 0);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left & e.Clicks == 1)
            {
                FrmBeforeLoc = e.Location;
                this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            this.MouseMove -= new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Left += e.Location.X - FrmBeforeLoc.X; //处理横坐标
            this.Top += e.Location.Y - FrmBeforeLoc.Y; //处理纵坐标
        }

        #endregion theme

        private void btnClose_Click(object sender, EventArgs e)
        {
            //mainLibManager.Sort();

            LibraryUtility.Save(mainLib, LibraryUtility.LibraryPath());

            if (bgW.IsBusy != true)
                this.Close();
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (!bgW.IsBusy)
            {
                matchingProgPanel.Visible = true;
                waitTimer.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveOptionPanel.Visible)
                saveOptionPanel.Visible = false;
            else
                saveOptionPanel.Visible = true; r1_EC.Checked = false; r2_C.Checked = false;
        }

        private void r1_EC_CheckedChanged(object sender, EventArgs e)
        {
            if (r1_EC.Checked)
            {
                if (saveListDialog.ShowDialog() != DialogResult.OK)
                    return;

                System.IO.StreamWriter sw = System.IO.File.CreateText(saveListDialog.FileName);
                for (int i = 1; i <= listChinese.Items.Count; i++)
                    sw.WriteLine(listEnglish.Items[i - 1].ToString().PadRight(20) + " || " + listChinese.Items[i - 1]);
                sw.Close();
            }
            saveOptionPanel.Visible = false;
        }

        private void r2_C_CheckedChanged(object sender, EventArgs e)
        {
            if (r2_C.Checked)
            {
                if (saveListDialog.ShowDialog() != DialogResult.OK)
                    return;
                
                System.IO.StreamWriter sw = System.IO.File.CreateText(saveListDialog.FileName);
                for (int i = 1; i <= listChinese.Items.Count; i++)
                    sw.WriteLine(listChinese.Items[i - 1]);

                sw.Close();
            }
            saveOptionPanel.Visible = false;
        }

        private void bgW_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < listEnglish.Items.Count; i++)
            {
                if (this.EndMatching == true)
                {
                    EndMatching = false; break;
                }

                matchingProgLabel.Text = "     Matching... " + (i + 1) + "/" + listEnglish.Items.Count;//refrequencysh status
                if (listEnglish.Items[i].ToString().Length == 0)//exclude empty lines
                    listChinese.Items[i] = "!ERROR Occurred";
                else
                    listChinese.Items[i] = GetDef(listEnglish.Items[i].ToString(), i);
            }
        }

        private string GetDef(string eng, int IndexInListBox)
        {
            string chn;
            chn = FetchEngine.GetDefinition(eng, mainLib);

            if (!chn.StartsWith("!") || chn.StartsWith("!N"))
                mainLib.Add(new Entry(chn, eng));//Library will intelligently add the entry

            return chn;
        }

        private void waitTimer_Tick(object sender, EventArgs e)
        {
            bgW.RunWorkerAsync();
            waitTimer.Enabled = false;
        }

        private void bgW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            matchingProgPanel.Visible = false;
        }

        private void btnWipeCache_Click(object sender, EventArgs e)
        {
            mainLib.Wipe();//wipe library
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            listEnglish.SelectedIndex = listChinese.SelectedIndex = (int)listItemNavigator.Value - 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.EndMatching = true;
        }
    }
}
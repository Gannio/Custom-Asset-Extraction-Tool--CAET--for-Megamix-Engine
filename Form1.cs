using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Collection Asset Extraction Tool (CAET) by Gannio. Copyright 2019.
//You may fork/expand on this, as long as you follow guidelines listed on the GitHub page.
namespace CAET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string pathInput = "";
        string pathOutput = "";
        string username = "";
        private void textBoxProjectPath_TextChanged(object sender, EventArgs e)
        {
            pathInput = textBoxProjectPath.Text;
        }

        private void buttonProjectPath_Click(object sender, EventArgs e)
        {
            openFileDialogProjectPath.ShowDialog();
        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            saveFileDialogOutput.ShowDialog();
        }



        void DirSearch(string sDir, string OGDir) //Derived and slightly modified from here: https://support.microsoft.com/en-us/help/303974/how-to-recursively-search-directories-by-using-visual-c
        {
            try
            {
                //string[] coll = Directory.GetDirectories(sDir);
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        string smallName = f.Replace(d + "\\", "");
                        string[] prefixes = {"lvl","rm","obj","sfx","spr","msk","bg","tst", "scr", "mus"};
                        for (int i = 0; i < prefixes.Length; i++)
                        {

                            if (smallName.Substring(0, prefixes[i].Length) == prefixes[i])
                            {
                                //MessageBox.Show(smallName.Substring(0, prefixes[i].Length));
                                if (smallName.Substring(prefixes[i].Length, username.Length) == username)
                                {
                                    //MessageBox.Show(f);
                                    string truncatedDirectory = f.Replace(OGDir, "").Replace(smallName,"");
                                    //MessageBox.Show(truncatedDirectory);
                                    string combine = pathOutput + "\\" + truncatedDirectory;
                                    if (!Directory.Exists(combine))
                                    {
                                        Directory.CreateDirectory(combine);

                                        //MessageBox.Show(pathOutput + "\\" + truncatedDirectory);
                                    }
                                    File.Copy(f, combine + smallName);
                                    //MessageBox.Show(smallName.Substring(i, username.Length));
                                }
                                i = 9001;
                            }
                        }
                        //MessageBox.Show(smallName);//lstFilesFound.Items.Add(f);
                        //MessageBox.Show(d);
                    }
                    DirSearch(d, OGDir);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private void saveFileDialogOutput_FileOk(object sender, CancelEventArgs e)
        {
            //C:\My Stuff\MAGMML3\Custom Asset Extractor\Sample Project\MegamixEngine-1.0.3.1m3 Submission Copy\MegamixEngine-1.0.3.1m3\MegamixEngine.project.gmx
//            saveFileDialogOutput.FileName.Replace(saveFileDialogOutput.CheckFileExists
            pathInput = textBoxProjectPath.Text;//openFileDialogProjectPath.FileName;
            pathOutput = saveFileDialogOutput.FileName;
            string outDirCheck = "";
            for (int i = pathOutput.Length - 1; i > 0; i--)
            { 
                if (pathOutput[i] == '\\')
                {
                    outDirCheck = pathOutput.Remove(i + 1);
                    //MessageBox.Show(pathOutput + i.ToString());
                    i = -10;

                }
            
            }
            MessageBox.Show(pathInput);
            if (Directory.Exists(pathInput))
            {
                if (Directory.Exists(outDirCheck))
                {
                    DirSearch(pathInput, pathInput);
                }
                else
                {
                    MessageBox.Show("WHY DID YOU BORK MY PROGRAM SDOIFEOBOSJERGBORWESGNBORSJBGBONP:IRNJBOB", "Nicaragua");//Shouldn't happen under normal circumstances.
                }

            }
            else
            {
                MessageBox.Show("The project path specified does not exist. This shouldn't happen if you just use the Browse option.", "ZOINKS, Scoob!");
            }
        }

        private void openFileDialogProjectPath_FileOk(object sender, CancelEventArgs e)
        {
           // string splitName = 

            openFileDialogProjectPath.FileName = openFileDialogProjectPath.FileName.Replace(openFileDialogProjectPath.SafeFileName, "");
            textBoxProjectPath.Text = openFileDialogProjectPath.FileName;
           
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
        }


    }
}

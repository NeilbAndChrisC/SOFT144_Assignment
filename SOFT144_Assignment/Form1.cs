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

/**********************************/
/* Neil Bennett and Chris Carter */ 
/*           Feb 2015           */
/*******************************/

namespace SOFT144_Assignment
{
    public partial class Form1 : Form
    {
       
        private string fileName;
        private string currentDirectoryName;
        public Form1()
         
   
        {
            InitializeComponent();
        }
       
        //code below is to open the open dialog box
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string onlyFileName;
            string directoryName;
            string driveLetter;

            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {

                currentDirectoryName = openFileDialog.InitialDirectory;

                fileName = openFileDialog.FileName;

                onlyFileName = openFileDialog.SafeFileName;

                directoryName = Path.GetDirectoryName(fileName);

                driveLetter = directoryName.Split(Path.VolumeSeparatorChar)[0];

                LoadFile();

            } // end if

        }// end open tool strip menu
       
        private void LoadFile()
        {
            string[] wordArray;
            string lineFromFile;
            StreamReader reader;

            fileContentsTextBox.Clear();

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        lineFromFile = reader.ReadLine();

                        fileContentsTextBox.AppendText(lineFromFile);
                        wordArray = lineFromFile.Split(',');
                        string moduleTitle = wordArray[0];
                        ModuleTitlelistView1.Items.Add(new ListViewItem(moduleTitle));

                            //if txt box is empty then fill it
                           //with txt from the array
                            if (titleTexBox.Text == string.Empty)
                            {
                                string title = wordArray[1];
                                titleTexBox.Text = title;
                            }//end if

                            //if txt box is empty then fill it
                            //with txt from the array
                            if (StageTextBox.Text == string.Empty)
                            {
                                string stage = wordArray[2];
                                StageTextBox.Text = stage;
                            }//end if

                        //if txt box is empty then fill it
                        //with txt from the array
                            if (InClassTextBox.Text == string.Empty)
                            {
                                string ClassText = wordArray[11];
                                InClassTextBox.Text = ClassText;
                            }//end if
                    }
                }
            }
               //if the file is not their
                //then tell user
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("File not found ");
            }

            }//end load file
       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                SaveFile();
            } //end if    
        }//end save tool strip

        private void SaveFile()
        {
            string textToSave;

            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    textToSave = fileContentsTextBox.Text;

                    writer.WriteLine(textToSave);
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Error writing to file", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}
        //code for save as below
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = currentDirectoryName;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;

                SaveFile();
            }


        }

        //code below hides the 'blinking curser' in contents
        //needs more work!!!!!!!!!!
        private void fileContentsTextBox_TextChanged(object sender, EventArgs e)
        {
            ActiveControl = null;
        }//end file contents text box

        //edit button code below
        private void editButton_Click(object sender, EventArgs e)
        {

        }//end edit button

       //ignore code below
        private void titleTexBox_TextChanged(object sender, EventArgs e)
        {
             
         //ignore  
        }//end 

        //add file code below
        private void AddModuleButton_Click(object sender, EventArgs e)
        {
            //clear all text from text boxes
            fileContentsTextBox.Clear();
            StageTextBox.Clear();
            titleTexBox.Clear();
            ModuleTitlelistView1.Clear();
            InClassTextBox.Clear();

            //need to show the two text box at the top of the form
            if (fileContentsTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter text!");
            }
          

        }//end add module button

        //delete module
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //give the user an option of not deleting
            string MessageBoxContent = "Do you really want to delete the file!";
            //title on the message box
            string MessageBoxTitle = "WARNING";
           

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {//start if
                File.Exists(fileName);
                {
                    try
                    {//start try

                        File.Delete(fileName);// need a try and catch here incase a user has no file selected
                        //clear all text from text boxes
                        fileContentsTextBox.Clear();
                        StageTextBox.Clear();
                        titleTexBox.Clear();
                        ModuleTitlelistView1.Clear();
                        InClassTextBox.Clear();
                    }//end try
                    catch (Exception ex)
                    {//start catch
                        MessageBox.Show("No File");
                    }//end catch

              
                }
            }//end if
            //if NO then close message box
            else if (dialogResult == DialogResult.No)
            {
                //close message box and do nothing
            }

            
        }//end deletButton

    }
}

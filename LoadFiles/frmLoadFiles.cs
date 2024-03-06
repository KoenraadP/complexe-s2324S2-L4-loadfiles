using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadFiles
{
    public partial class frmLoadFiles : Form
    {
        public frmLoadFiles()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = ofd.FileName;
            string fileContent = File.ReadAllText(filePath);
            FileData fileData = new FileData(filePath, fileContent);
            lbxFiles.Items.Add(fileData);
        }

        private void lbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFiles.SelectedIndex != -1)
            {
                FileData selectedFile = (FileData)lbxFiles.SelectedItem;
                txtContent.Text = selectedFile.FileContent;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lbxFiles.SelectedIndex != -1)
            {
                string selectedFileName = lbxFiles.SelectedItem.ToString();
                FileData selectedFile = (FileData)lbxFiles.SelectedItem;

                // Update the content of the selected file
                selectedFile.FileContent = txtContent.Text;

                try
                {
                    // Save the changes back to the file
                    File.WriteAllText(selectedFile.FullPath, selectedFile.FileContent);
                    MessageBox.Show("Changes saved successfully!");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error saving changes: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No file selected to save changes.");
            }
        }
    }
}

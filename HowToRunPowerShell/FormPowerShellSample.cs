using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace HowToRunPowerShell
{
    public partial class FormPowerShellSample : Form
    {
        // Represents the kind of drag drop formats we want to receive
        private const string dragDropFormat = "FileDrop";

        public FormPowerShellSample()
        {
            InitializeComponent();
        }

        private void buttonRunScript_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutput.Clear();
                textBoxOutput.Text = this.RunScript(textBoxScript.Text);
            }
            catch (Exception error)
            {
                textBoxOutput.Text += String.Format("\r\nError in script : {0}\r\n", error.Message);
            }
        }

        /// <summary>
        /// Runs the given powershell script and returns the script output.
        /// </summary>
        /// <param name="scriptText">the powershell script text to run</param>
        /// <returns>output of the script</returns>
        private string RunScript(string scriptText)
        {
            // create Powershell runspace
            Runspace runspace = RunspaceFactory.CreateRunspace();

            // open it
            runspace.Open();

            // create a pipeline and feed it the script text
            Pipeline pipeline = runspace.CreatePipeline();
            pipeline.Commands.AddScript(scriptText);

            // add an extra command to transform the script output objects into nicely formatted strings
            // remove this line to get the actual objects that the script returns. For example, the script
            // "Get-Process" returns a collection of System.Diagnostics.Process instances.
            pipeline.Commands.Add("Out-String");

            // execute the script
            Collection<PSObject> results = pipeline.Invoke();

            // close the runspace
            runspace.Close();

            // convert the script result into a single string
            StringBuilder stringBuilder = new StringBuilder();
            foreach (PSObject obj in results)
            {
                stringBuilder.AppendLine(obj.ToString());
            }

            return stringBuilder.ToString();
        }

        #region Drag-drop handling events
        private void FormPowerShellSample_DragDrop(object sender, DragEventArgs e)
        {
            // is it the correct type of data?
            if (e.Data.GetDataPresent(dragDropFormat))
            {
                // dragging files onto the window yields an array of pathnames
                string[] files = (string[])e.Data.GetData(dragDropFormat);

                if (files.Length > 0)
                {
                    // just read the first file
                    using (StreamReader sr = new StreamReader(files[0]))
                    {
                        // and plunk the contents in the textbox
                        textBoxScript.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void FormPowerShellSample_DragEnter(object sender, DragEventArgs e)
        {
            // only accept the dropped data if it has the correct format
            e.Effect = e.Data.GetDataPresent(dragDropFormat) ? DragDropEffects.Link : DragDropEffects.None;
        }
        #endregion

        private void textBoxScript_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBrowseProject_Click(object sender, EventArgs e)
        {
            DialogResult button1_Click = folderBrowserDialogProject.ShowDialog();
            if (button1_Click == DialogResult.OK)
            {
                textBoxProjectDir.Text = folderBrowserDialogProject.SelectedPath;
                textBoxScript.Text = "";
            }
        }

        private void FormPowerShellSample_Load(object sender, EventArgs e)
        {
            this.dataGridViewArtisan.Rows.Insert(0, "php artisan list", "", "Add");
        }

        private void dataGridViewArtisan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                textBoxScript.Text = "";
                textBoxScript.Text += "cd " + textBoxProjectDir.Text;
                textBoxScript.Text += "\r\n";
                textBoxScript.Text += dataGridViewArtisan.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
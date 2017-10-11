namespace HowToRunPowerShell
{
    partial class FormPowerShellSample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewArtisan = new System.Windows.Forms.DataGridView();
            this.buttonBrowseProject = new System.Windows.Forms.Button();
            this.textBoxProjectDir = new System.Windows.Forms.TextBox();
            this.textBoxScript = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRunScript = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogProject = new System.Windows.Forms.FolderBrowserDialog();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtisan)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(634, 511);
            this.splitContainer1.SplitterDistance = 289;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewArtisan);
            this.groupBox1.Controls.Add(this.buttonBrowseProject);
            this.groupBox1.Controls.Add(this.textBoxProjectDir);
            this.groupBox1.Controls.Add(this.textBoxScript);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(634, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // dataGridViewArtisan
            // 
            this.dataGridViewArtisan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArtisan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtisan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDesc,
            this.colAction});
            this.dataGridViewArtisan.Location = new System.Drawing.Point(8, 47);
            this.dataGridViewArtisan.Name = "dataGridViewArtisan";
            this.dataGridViewArtisan.Size = new System.Drawing.Size(618, 123);
            this.dataGridViewArtisan.TabIndex = 5;
            this.dataGridViewArtisan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtisan_CellContentClick);
            // 
            // buttonBrowseProject
            // 
            this.buttonBrowseProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseProject.Location = new System.Drawing.Point(531, 12);
            this.buttonBrowseProject.Name = "buttonBrowseProject";
            this.buttonBrowseProject.Size = new System.Drawing.Size(95, 29);
            this.buttonBrowseProject.TabIndex = 4;
            this.buttonBrowseProject.Text = "&Browse Project";
            this.buttonBrowseProject.UseVisualStyleBackColor = true;
            this.buttonBrowseProject.Click += new System.EventHandler(this.buttonBrowseProject_Click);
            // 
            // textBoxProjectDir
            // 
            this.textBoxProjectDir.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxProjectDir.Location = new System.Drawing.Point(8, 21);
            this.textBoxProjectDir.Name = "textBoxProjectDir";
            this.textBoxProjectDir.Size = new System.Drawing.Size(517, 20);
            this.textBoxProjectDir.TabIndex = 3;
            this.textBoxProjectDir.Text = "D:/MEGAsync/ProjectPHP/laravel/laravel55";
            // 
            // textBoxScript
            // 
            this.textBoxScript.Location = new System.Drawing.Point(8, 176);
            this.textBoxScript.MaxLength = 0;
            this.textBoxScript.Multiline = true;
            this.textBoxScript.Name = "textBoxScript";
            this.textBoxScript.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxScript.Size = new System.Drawing.Size(618, 62);
            this.textBoxScript.TabIndex = 0;
            this.textBoxScript.WordWrap = false;
            this.textBoxScript.TextChanged += new System.EventHandler(this.textBoxScript_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRunScript);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 37);
            this.panel1.TabIndex = 2;
            // 
            // buttonRunScript
            // 
            this.buttonRunScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunScript.Location = new System.Drawing.Point(523, 0);
            this.buttonRunScript.Name = "buttonRunScript";
            this.buttonRunScript.Size = new System.Drawing.Size(95, 30);
            this.buttonRunScript.TabIndex = 1;
            this.buttonRunScript.Text = "&Run Script";
            this.buttonRunScript.UseVisualStyleBackColor = true;
            this.buttonRunScript.Click += new System.EventHandler(this.buttonRunScript_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxOutput);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(634, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxOutput.Location = new System.Drawing.Point(8, 21);
            this.textBoxOutput.MaxLength = 0;
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(618, 189);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.WordWrap = false;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            this.colDesc.ReadOnly = true;
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            // 
            // FormPowerShellSample
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormPowerShellSample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laravel Artisan";
            this.Load += new System.EventHandler(this.FormPowerShellSample_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormPowerShellSample_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormPowerShellSample_DragEnter);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtisan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxScript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRunScript;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxProjectDir;
        private System.Windows.Forms.Button buttonBrowseProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogProject;
        private System.Windows.Forms.DataGridView dataGridViewArtisan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
    }
}


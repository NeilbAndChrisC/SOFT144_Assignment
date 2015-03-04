namespace SOFT144_Assignment
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileContentsTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.editButton = new System.Windows.Forms.Button();
            this.titleTexBox = new System.Windows.Forms.TextBox();
            this.ModuleTitlelistView1 = new System.Windows.Forms.ListView();
            this.StageTextBox = new System.Windows.Forms.TextBox();
            this.DeletButton = new System.Windows.Forms.Button();
            this.AddModuleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InClassTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.moduleDetailsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.saveAsToolStripMenuItem.Text = "&Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // moduleDetailsToolStripMenuItem
            // 
            this.moduleDetailsToolStripMenuItem.Name = "moduleDetailsToolStripMenuItem";
            this.moduleDetailsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.moduleDetailsToolStripMenuItem.Text = "Module Details";
            // 
            // fileContentsTextBox
            // 
            this.fileContentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileContentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileContentsTextBox.Location = new System.Drawing.Point(360, 330);
            this.fileContentsTextBox.Multiline = true;
            this.fileContentsTextBox.Name = "fileContentsTextBox";
            this.fileContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileContentsTextBox.Size = new System.Drawing.Size(414, 116);
            this.fileContentsTextBox.TabIndex = 1;
            this.fileContentsTextBox.TextChanged += new System.EventHandler(this.fileContentsTextBox_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Text Files (.txt) | *.txt";
            this.openFileDialog.InitialDirectory = "\"C:\\Users\\chriscarter\\Documents\\";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files (.txt) |*.txt| All Files|*.*";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(97, 380);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(121, 30);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "EDIT MODULE";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // titleTexBox
            // 
            this.titleTexBox.BackColor = System.Drawing.SystemColors.Control;
            this.titleTexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTexBox.Location = new System.Drawing.Point(100, 63);
            this.titleTexBox.Multiline = true;
            this.titleTexBox.Name = "titleTexBox";
            this.titleTexBox.Size = new System.Drawing.Size(533, 29);
            this.titleTexBox.TabIndex = 5;
            this.titleTexBox.TextChanged += new System.EventHandler(this.titleTexBox_TextChanged);
            // 
            // ModuleTitlelistView1
            // 
            this.ModuleTitlelistView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModuleTitlelistView1.LabelWrap = false;
            this.ModuleTitlelistView1.Location = new System.Drawing.Point(97, 152);
            this.ModuleTitlelistView1.Name = "ModuleTitlelistView1";
            this.ModuleTitlelistView1.Size = new System.Drawing.Size(121, 177);
            this.ModuleTitlelistView1.TabIndex = 6;
            this.ModuleTitlelistView1.UseCompatibleStateImageBehavior = false;
            // 
            // StageTextBox
            // 
            this.StageTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.StageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StageTextBox.Location = new System.Drawing.Point(658, 63);
            this.StageTextBox.Multiline = true;
            this.StageTextBox.Name = "StageTextBox";
            this.StageTextBox.Size = new System.Drawing.Size(100, 29);
            this.StageTextBox.TabIndex = 7;
            // 
            // DeletButton
            // 
            this.DeletButton.Location = new System.Drawing.Point(97, 344);
            this.DeletButton.Name = "DeletButton";
            this.DeletButton.Size = new System.Drawing.Size(121, 30);
            this.DeletButton.TabIndex = 8;
            this.DeletButton.Text = "DELETE MODULE";
            this.DeletButton.UseVisualStyleBackColor = true;
            this.DeletButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddModuleButton
            // 
            this.AddModuleButton.Location = new System.Drawing.Point(97, 416);
            this.AddModuleButton.Name = "AddModuleButton";
            this.AddModuleButton.Size = new System.Drawing.Size(121, 30);
            this.AddModuleButton.TabIndex = 9;
            this.AddModuleButton.Text = "ADD MODULE";
            this.AddModuleButton.UseVisualStyleBackColor = true;
            this.AddModuleButton.Click += new System.EventHandler(this.AddModuleButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "MODULE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "IN CLASS TEST";
            // 
            // InClassTextBox
            // 
            this.InClassTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.InClassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InClassTextBox.Location = new System.Drawing.Point(233, 152);
            this.InClassTextBox.Multiline = true;
            this.InClassTextBox.Name = "InClassTextBox";
            this.InClassTextBox.Size = new System.Drawing.Size(121, 177);
            this.InClassTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 595);
            this.Controls.Add(this.InClassTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddModuleButton);
            this.Controls.Add(this.DeletButton);
            this.Controls.Add(this.StageTextBox);
            this.Controls.Add(this.ModuleTitlelistView1);
            this.Controls.Add(this.titleTexBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.fileContentsTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stage Management App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.TextBox fileContentsTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem moduleDetailsToolStripMenuItem;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox titleTexBox;
        private System.Windows.Forms.ListView ModuleTitlelistView1;
        private System.Windows.Forms.TextBox StageTextBox;
        private System.Windows.Forms.Button DeletButton;
        private System.Windows.Forms.Button AddModuleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InClassTextBox;
    }
}


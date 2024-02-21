namespace WindowsClipSolver
{
    partial class Clipper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clipper));
            takeScreenShot = new Button();
            mainText = new RichTextBox();
            saveButton = new Button();
            copyButton = new Button();
            clearButton = new Button();
            openFolder = new Button();
            imageBox = new PictureBox();
            menuTab = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
            menuTab.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // takeScreenShot
            // 
            resources.ApplyResources(takeScreenShot, "takeScreenShot");
            takeScreenShot.BackColor = SystemColors.ControlLight;
            takeScreenShot.Name = "takeScreenShot";
            takeScreenShot.UseVisualStyleBackColor = false;
            takeScreenShot.Click += Capture;
            takeScreenShot.MouseHover += takeScreenShot_MouseHover;
            // 
            // mainText
            // 
            mainText.BackColor = SystemColors.ControlLight;
            mainText.BorderStyle = BorderStyle.None;
            resources.ApplyResources(mainText, "mainText");
            mainText.ForeColor = SystemColors.WindowText;
            mainText.Name = "mainText";
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ControlLight;
            resources.ApplyResources(saveButton, "saveButton");
            saveButton.Name = "saveButton";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            saveButton.MouseHover += saveButton_MouseHover;
            // 
            // copyButton
            // 
            copyButton.BackColor = SystemColors.ControlLight;
            resources.ApplyResources(copyButton, "copyButton");
            copyButton.Name = "copyButton";
            copyButton.UseVisualStyleBackColor = false;
            copyButton.Click += copyButton_Click;
            copyButton.MouseHover += copyButton_MouseHover;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.ControlLight;
            clearButton.Image = Properties.Resources.open;
            resources.ApplyResources(clearButton, "clearButton");
            clearButton.Name = "clearButton";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            clearButton.MouseHover += clearButton_MouseHover;
            // 
            // openFolder
            // 
            openFolder.BackColor = SystemColors.ControlLight;
            resources.ApplyResources(openFolder, "openFolder");
            openFolder.Name = "openFolder";
            openFolder.UseVisualStyleBackColor = false;
            openFolder.Click += openFolder_Click;
            openFolder.MouseHover += openFolder_MouseHover;
            // 
            // imageBox
            // 
            imageBox.BackColor = SystemColors.ControlLight;
            resources.ApplyResources(imageBox, "imageBox");
            imageBox.Name = "imageBox";
            imageBox.TabStop = false;
            // 
            // menuTab
            // 
            menuTab.Controls.Add(tabPage1);
            menuTab.Controls.Add(tabPage2);
            resources.ApplyResources(menuTab, "menuTab");
            menuTab.Multiline = true;
            menuTab.Name = "menuTab";
            menuTab.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(imageBox);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(mainText);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(clearButton, 7, 0);
            tableLayoutPanel1.Controls.Add(copyButton, 6, 0);
            tableLayoutPanel1.Controls.Add(saveButton, 5, 0);
            tableLayoutPanel1.Controls.Add(takeScreenShot, 0, 0);
            tableLayoutPanel1.Controls.Add(openFolder, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // Clipper
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuTab);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Clipper";
            Opacity = 0.98D;
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            menuTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button takeScreenShot;
        private RichTextBox mainText;
        private Button openFolder;
        private PictureBox imageBox;
        private Button clearButton;
        private Button saveButton;
        private Button copyButton;
        private TabControl menuTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}

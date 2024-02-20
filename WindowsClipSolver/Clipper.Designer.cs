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
            buttonGroup = new GroupBox();
            saveButton = new Button();
            copyButton = new Button();
            clearButton = new Button();
            openFolder = new Button();
            imageBox = new PictureBox();
            buttonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBox).BeginInit();
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
            resources.ApplyResources(mainText, "mainText");
            mainText.BackColor = SystemColors.ControlLight;
            mainText.BorderStyle = BorderStyle.None;
            mainText.Name = "mainText";
            // 
            // buttonGroup
            // 
            buttonGroup.BackColor = SystemColors.Control;
            buttonGroup.Controls.Add(saveButton);
            buttonGroup.Controls.Add(copyButton);
            buttonGroup.Controls.Add(clearButton);
            buttonGroup.Controls.Add(openFolder);
            buttonGroup.Controls.Add(takeScreenShot);
            resources.ApplyResources(buttonGroup, "buttonGroup");
            buttonGroup.Name = "buttonGroup";
            buttonGroup.TabStop = false;
            buttonGroup.DpiChangedAfterParent += buttonGroup_DpiChangedAfterParent;
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
            // Clipper
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageBox);
            Controls.Add(buttonGroup);
            Controls.Add(mainText);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Clipper";
            buttonGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button takeScreenShot;
        private RichTextBox mainText;
        private GroupBox buttonGroup;
        private Button openFolder;
        private PictureBox imageBox;
        private Button clearButton;
        private Button saveButton;
        private Button copyButton;
    }
}

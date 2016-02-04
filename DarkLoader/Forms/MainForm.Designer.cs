namespace DarkLoader
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DevTools = new System.Windows.Forms.GroupBox();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.LaunchGeme = new System.Windows.Forms.Button();
            this.btnPatchEditor = new System.Windows.Forms.Button();
            this.LaunchPad = new System.Windows.Forms.GroupBox();
            this.GameName = new System.Windows.Forms.TextBox();
            this.LaunchArgumentsForm = new System.Windows.Forms.TextBox();
            this.DevTools.SuspendLayout();
            this.LaunchPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // DevTools
            // 
            this.DevTools.Controls.Add(this.SaveSettings);
            this.DevTools.Controls.Add(this.LaunchGeme);
            this.DevTools.Controls.Add(this.btnPatchEditor);
            this.DevTools.Location = new System.Drawing.Point(111, 12);
            this.DevTools.Name = "DevTools";
            this.DevTools.Size = new System.Drawing.Size(495, 57);
            this.DevTools.TabIndex = 14;
            this.DevTools.TabStop = false;
            this.DevTools.Text = "Developer Tools";
            // 
            // SaveSettings
            // 
            this.SaveSettings.Location = new System.Drawing.Point(330, 22);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(156, 23);
            this.SaveSettings.TabIndex = 2;
            this.SaveSettings.Text = "Save Settings";
            this.SaveSettings.UseVisualStyleBackColor = true;
            this.SaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // LaunchGeme
            // 
            this.LaunchGeme.Location = new System.Drawing.Point(169, 22);
            this.LaunchGeme.Name = "LaunchGeme";
            this.LaunchGeme.Size = new System.Drawing.Size(156, 23);
            this.LaunchGeme.TabIndex = 1;
            this.LaunchGeme.Text = "Launch Game";
            this.LaunchGeme.UseVisualStyleBackColor = true;
            this.LaunchGeme.Click += new System.EventHandler(this.LaunchGeme_click);
            // 
            // btnPatchEditor
            // 
            this.btnPatchEditor.Location = new System.Drawing.Point(9, 22);
            this.btnPatchEditor.Name = "btnPatchEditor";
            this.btnPatchEditor.Size = new System.Drawing.Size(156, 23);
            this.btnPatchEditor.TabIndex = 0;
            this.btnPatchEditor.Text = "Patch Editor";
            this.btnPatchEditor.UseVisualStyleBackColor = true;
            this.btnPatchEditor.Click += new System.EventHandler(this.btnPatchEditor_click);
            // 
            // LaunchPad
            // 
            this.LaunchPad.Controls.Add(this.GameName);
            this.LaunchPad.Controls.Add(this.LaunchArgumentsForm);
            this.LaunchPad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LaunchPad.Location = new System.Drawing.Point(12, 75);
            this.LaunchPad.Name = "LaunchPad";
            this.LaunchPad.Size = new System.Drawing.Size(688, 57);
            this.LaunchPad.TabIndex = 16;
            this.LaunchPad.TabStop = false;
            this.LaunchPad.Text = "Launch Args";
            // 
            // GameName
            // 
            this.GameName.Location = new System.Drawing.Point(10, 20);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(329, 21);
            this.GameName.TabIndex = 17;
            this.GameName.TextChanged += new System.EventHandler(this.GameName_TextChanged);
            // 
            // LaunchArgumentsForm
            // 
            this.LaunchArgumentsForm.Location = new System.Drawing.Point(353, 20);
            this.LaunchArgumentsForm.Name = "LaunchArgumentsForm";
            this.LaunchArgumentsForm.Size = new System.Drawing.Size(329, 21);
            this.LaunchArgumentsForm.TabIndex = 16;
            this.LaunchArgumentsForm.TextChanged += new System.EventHandler(this.LaunchArgumentsForm_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 150);
            this.Controls.Add(this.LaunchPad);
            this.Controls.Add(this.DevTools);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "RogueLoader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DevTools.ResumeLayout(false);
            this.LaunchPad.ResumeLayout(false);
            this.LaunchPad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox DevTools;
        private System.Windows.Forms.Button btnPatchEditor;
        private System.Windows.Forms.GroupBox LaunchPad;
        private System.Windows.Forms.TextBox LaunchArgumentsForm;
        private System.Windows.Forms.Button LaunchGeme;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.Button SaveSettings;
    }
}


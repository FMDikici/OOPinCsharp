
namespace Chess
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClassic = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPuzzle = new System.Windows.Forms.Panel();
            this.timerExit = new System.Windows.Forms.Timer(this.components);
            this.panelSettings = new System.Windows.Forms.Panel();
            this.btnSettingsBack = new System.Windows.Forms.Button();
            this.checkBoxHelper = new System.Windows.Forms.CheckBox();
            this.panelMenu.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chess";
            // 
            // btnClassic
            // 
            this.btnClassic.Location = new System.Drawing.Point(107, 164);
            this.btnClassic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClassic.Name = "btnClassic";
            this.btnClassic.Size = new System.Drawing.Size(200, 86);
            this.btnClassic.TabIndex = 1;
            this.btnClassic.Text = "Classic";
            this.btnClassic.UseVisualStyleBackColor = true;
            this.btnClassic.Click += new System.EventHandler(this.btnClassic_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnClassic);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Location = new System.Drawing.Point(280, 21);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(397, 545);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // panelPuzzle
            // 
            this.panelPuzzle.Location = new System.Drawing.Point(12, 57);
            this.panelPuzzle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPuzzle.Name = "panelPuzzle";
            this.panelPuzzle.Size = new System.Drawing.Size(928, 454);
            this.panelPuzzle.TabIndex = 5;
            this.panelPuzzle.Visible = false;
            this.panelPuzzle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPuzzle_Paint);
            // 
            // timerExit
            // 
            this.timerExit.Interval = 5000;
            this.timerExit.Tick += new System.EventHandler(this.timerExit_Tick);
            // 
            // panelSettings
            // 
            this.panelSettings.Controls.Add(this.btnSettingsBack);
            this.panelSettings.Controls.Add(this.checkBoxHelper);
            this.panelSettings.Location = new System.Drawing.Point(16, 39);
            this.panelSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(928, 454);
            this.panelSettings.TabIndex = 2;
            this.panelSettings.Visible = false;
            // 
            // btnSettingsBack
            // 
            this.btnSettingsBack.Location = new System.Drawing.Point(41, 37);
            this.btnSettingsBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettingsBack.Name = "btnSettingsBack";
            this.btnSettingsBack.Size = new System.Drawing.Size(93, 49);
            this.btnSettingsBack.TabIndex = 1;
            this.btnSettingsBack.Text = "Back";
            this.btnSettingsBack.UseVisualStyleBackColor = true;
            this.btnSettingsBack.Click += new System.EventHandler(this.btnSettingsBack_Click);
            // 
            // checkBoxHelper
            // 
            this.checkBoxHelper.AutoSize = true;
            this.checkBoxHelper.Checked = true;
            this.checkBoxHelper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHelper.Location = new System.Drawing.Point(144, 119);
            this.checkBoxHelper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHelper.Name = "checkBoxHelper";
            this.checkBoxHelper.Size = new System.Drawing.Size(162, 20);
            this.checkBoxHelper.TabIndex = 0;
            this.checkBoxHelper.Text = "Show Possible Moves";
            this.checkBoxHelper.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(992, 580);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelPuzzle);
            this.Controls.Add(this.panelSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnSettingsBack;

        private System.Windows.Forms.Panel panelPuzzle;

        private System.Windows.Forms.Panel panelMenu;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClassic;
        private System.Windows.Forms.Timer timerExit;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.CheckBox checkBoxHelper;
    }
}


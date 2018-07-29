namespace AudioSessionVolumeManagerCS
{
    partial class AudioSessionVolumeManagerCS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioSessionVolumeManagerCS));
            this.MasterMuteButton = new System.Windows.Forms.Button();
            this.MasterVolumeSlider = new System.Windows.Forms.TrackBar();
            this.Session1Selector = new System.Windows.Forms.ComboBox();
            this.Session1Volume = new System.Windows.Forms.TrackBar();
            this.Session2Volume = new System.Windows.Forms.TrackBar();
            this.Session2Selector = new System.Windows.Forms.ComboBox();
            this.Session3Volume = new System.Windows.Forms.TrackBar();
            this.Session3Selector = new System.Windows.Forms.ComboBox();
            this.Session4Volume = new System.Windows.Forms.TrackBar();
            this.Session4Selector = new System.Windows.Forms.ComboBox();
            this.ComSelector = new System.Windows.Forms.ComboBox();
            this.ComSelectText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MasterVolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session1Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session2Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session3Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session4Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterMuteButton
            // 
            this.MasterMuteButton.Location = new System.Drawing.Point(10, 34);
            this.MasterMuteButton.Name = "MasterMuteButton";
            this.MasterMuteButton.Size = new System.Drawing.Size(121, 23);
            this.MasterMuteButton.TabIndex = 0;
            this.MasterMuteButton.Text = "Master";
            this.MasterMuteButton.UseVisualStyleBackColor = true;
            this.MasterMuteButton.Click += new System.EventHandler(this.MasterMuteButton_Click);
            // 
            // MasterVolumeSlider
            // 
            this.MasterVolumeSlider.Location = new System.Drawing.Point(48, 63);
            this.MasterVolumeSlider.Maximum = 1000;
            this.MasterVolumeSlider.Name = "MasterVolumeSlider";
            this.MasterVolumeSlider.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.MasterVolumeSlider.Size = new System.Drawing.Size(45, 367);
            this.MasterVolumeSlider.TabIndex = 1;
            this.MasterVolumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MasterVolumeSlider.Scroll += new System.EventHandler(this.MasterVolumeSlider_Scroll);
            // 
            // Session1Selector
            // 
            this.Session1Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Session1Selector.FormattingEnabled = true;
            this.Session1Selector.Location = new System.Drawing.Point(136, 34);
            this.Session1Selector.Name = "Session1Selector";
            this.Session1Selector.Size = new System.Drawing.Size(121, 21);
            this.Session1Selector.TabIndex = 2;
            this.Session1Selector.SelectedIndexChanged += new System.EventHandler(this.Session1Selector_SelectedIndexChanged);
            // 
            // Session1Volume
            // 
            this.Session1Volume.Location = new System.Drawing.Point(174, 61);
            this.Session1Volume.Maximum = 1000;
            this.Session1Volume.Name = "Session1Volume";
            this.Session1Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Session1Volume.Size = new System.Drawing.Size(45, 367);
            this.Session1Volume.TabIndex = 3;
            this.Session1Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Session1Volume.Scroll += new System.EventHandler(this.Session1Volume_Scroll);
            // 
            // Session2Volume
            // 
            this.Session2Volume.Location = new System.Drawing.Point(300, 61);
            this.Session2Volume.Maximum = 1000;
            this.Session2Volume.Name = "Session2Volume";
            this.Session2Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Session2Volume.Size = new System.Drawing.Size(45, 367);
            this.Session2Volume.TabIndex = 5;
            this.Session2Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Session2Volume.Scroll += new System.EventHandler(this.Session2Volume_Scroll);
            // 
            // Session2Selector
            // 
            this.Session2Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Session2Selector.FormattingEnabled = true;
            this.Session2Selector.Location = new System.Drawing.Point(262, 34);
            this.Session2Selector.Name = "Session2Selector";
            this.Session2Selector.Size = new System.Drawing.Size(121, 21);
            this.Session2Selector.TabIndex = 4;
            this.Session2Selector.SelectedIndexChanged += new System.EventHandler(this.Session2Selector_SelectedIndexChanged);
            // 
            // Session3Volume
            // 
            this.Session3Volume.Location = new System.Drawing.Point(425, 61);
            this.Session3Volume.Maximum = 1000;
            this.Session3Volume.Name = "Session3Volume";
            this.Session3Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Session3Volume.Size = new System.Drawing.Size(45, 367);
            this.Session3Volume.TabIndex = 7;
            this.Session3Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Session3Volume.Scroll += new System.EventHandler(this.Session3Volume_Scroll);
            // 
            // Session3Selector
            // 
            this.Session3Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Session3Selector.FormattingEnabled = true;
            this.Session3Selector.Location = new System.Drawing.Point(387, 34);
            this.Session3Selector.Name = "Session3Selector";
            this.Session3Selector.Size = new System.Drawing.Size(121, 21);
            this.Session3Selector.TabIndex = 6;
            this.Session3Selector.SelectedIndexChanged += new System.EventHandler(this.Session3Selector_SelectedIndexChanged);
            // 
            // Session4Volume
            // 
            this.Session4Volume.Location = new System.Drawing.Point(552, 61);
            this.Session4Volume.Maximum = 1000;
            this.Session4Volume.Name = "Session4Volume";
            this.Session4Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Session4Volume.Size = new System.Drawing.Size(45, 367);
            this.Session4Volume.TabIndex = 9;
            this.Session4Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Session4Volume.Scroll += new System.EventHandler(this.Session4Volume_Scroll);
            // 
            // Session4Selector
            // 
            this.Session4Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Session4Selector.FormattingEnabled = true;
            this.Session4Selector.Location = new System.Drawing.Point(514, 34);
            this.Session4Selector.Name = "Session4Selector";
            this.Session4Selector.Size = new System.Drawing.Size(121, 21);
            this.Session4Selector.TabIndex = 8;
            this.Session4Selector.SelectedIndexChanged += new System.EventHandler(this.Session4Selector_SelectedIndexChanged);
            // 
            // ComSelector
            // 
            this.ComSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSelector.FormattingEnabled = true;
            this.ComSelector.Location = new System.Drawing.Point(70, 7);
            this.ComSelector.Name = "ComSelector";
            this.ComSelector.Size = new System.Drawing.Size(121, 21);
            this.ComSelector.TabIndex = 11;
            this.ComSelector.SelectedIndexChanged += new System.EventHandler(this.ComSelector_SelectedIndexChanged);
            // 
            // ComSelectText
            // 
            this.ComSelectText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ComSelectText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComSelectText.Location = new System.Drawing.Point(11, 10);
            this.ComSelectText.Name = "ComSelectText";
            this.ComSelectText.Size = new System.Drawing.Size(118, 13);
            this.ComSelectText.TabIndex = 12;
            this.ComSelectText.Tag = "";
            this.ComSelectText.Text = "Com Port:";
            // 
            // AudioSessionVolumeManagerCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.ComSelector);
            this.Controls.Add(this.ComSelectText);
            this.Controls.Add(this.Session4Volume);
            this.Controls.Add(this.Session4Selector);
            this.Controls.Add(this.Session3Volume);
            this.Controls.Add(this.Session3Selector);
            this.Controls.Add(this.Session2Volume);
            this.Controls.Add(this.Session2Selector);
            this.Controls.Add(this.Session1Volume);
            this.Controls.Add(this.Session1Selector);
            this.Controls.Add(this.MasterVolumeSlider);
            this.Controls.Add(this.MasterMuteButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AudioSessionVolumeManagerCS";
            this.Text = "AudioSessionVolumeManagerCS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AudioSessionVolumeManagerCS_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MasterVolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session1Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session2Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session3Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Session4Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MasterMuteButton;
        private System.Windows.Forms.TrackBar MasterVolumeSlider;
        private System.Windows.Forms.ComboBox Session1Selector;
        private System.Windows.Forms.TrackBar Session1Volume;
        private System.Windows.Forms.TrackBar Session2Volume;
        private System.Windows.Forms.ComboBox Session2Selector;
        private System.Windows.Forms.TrackBar Session3Volume;
        private System.Windows.Forms.ComboBox Session3Selector;
        private System.Windows.Forms.TrackBar Session4Volume;
        private System.Windows.Forms.ComboBox Session4Selector;
        private System.Windows.Forms.ComboBox ComSelector;
        private System.Windows.Forms.TextBox ComSelectText;
    }
}


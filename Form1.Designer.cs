namespace IpSwitcher
{
    partial class IpSwitcherForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.switchIpButton = new System.Windows.Forms.Button();
            this.currentIpLabel = new System.Windows.Forms.Label();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.mainButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // switchIpButton
            // 
            this.switchIpButton.Location = new System.Drawing.Point(150, 150);
            this.switchIpButton.Name = "switchIpButton";
            this.switchIpButton.Size = new System.Drawing.Size(100, 50);
            this.switchIpButton.TabIndex = 0;
            this.switchIpButton.Text = "Switch IP";
            this.switchIpButton.UseVisualStyleBackColor = true;
            this.switchIpButton.Click += new System.EventHandler(this.switchIpButton_Click);
            // 
            // currentIpLabel
            // 
            this.currentIpLabel.AutoSize = true;
            this.currentIpLabel.Location = new System.Drawing.Point(150, 100);
            this.currentIpLabel.Name = "currentIpLabel";
            this.currentIpLabel.Size = new System.Drawing.Size(64, 13);
            this.currentIpLabel.TabIndex = 1;
            this.currentIpLabel.Text = "Current IP: -";
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sidebarPanel.Controls.Add(this.mainButton);
            this.sidebarPanel.Controls.Add(this.settingsButton);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(100, 450);
            this.sidebarPanel.TabIndex = 2;
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(12, 20);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(80, 40);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Main";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Location = new System.Drawing.Point(12, 70);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(80, 40);
            this.settingsButton.TabIndex = 1;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.webBrowser);
            this.mainPanel.Controls.Add(this.currentIpLabel);
            this.mainPanel.Controls.Add(this.switchIpButton);
            this.mainPanel.Location = new System.Drawing.Point(100, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(700, 450);
            this.mainPanel.TabIndex = 3;
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.label1);
            this.settingsPanel.Controls.Add(this.textBox1);
            this.settingsPanel.Controls.Add(this.label2);
            this.settingsPanel.Controls.Add(this.textBox2);
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Location = new System.Drawing.Point(100, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(700, 450);
            this.settingsPanel.TabIndex = 4;
            this.settingsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Setting 1:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Setting 2:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save Settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(150, 50);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(450, 300);
            this.webBrowser.TabIndex = 2;
            // 
            // IpSwitcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Name = "IpSwitcherForm";
            this.Text = "IP Switcher";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button switchIpButton;
        private System.Windows.Forms.Label currentIpLabel;
        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

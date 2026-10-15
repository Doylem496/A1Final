namespace A1Final
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
            ChatLog = new Label();
            msgBox = new TextBox();
            sendMsgButton = new Button();
            Game = new ListBox();
            msgBoxLabel = new Label();
            menuStrip1 = new MenuStrip();
            networkToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            systemToolStripMenuItem = new ToolStripMenuItem();
            connectToolStripMenuItem = new ToolStripMenuItem();
            disconnectToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ChatLog
            // 
            ChatLog.AutoSize = true;
            ChatLog.Font = new Font("Liberation Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChatLog.Location = new Point(12, 492);
            ChatLog.Name = "ChatLog";
            ChatLog.Size = new Size(107, 25);
            ChatLog.TabIndex = 1;
            ChatLog.Text = "Chat Log";
            ChatLog.Click += label1_Click;
            // 
            // msgBox
            // 
            msgBox.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            msgBox.Location = new Point(12, 446);
            msgBox.Margin = new Padding(3, 4, 3, 4);
            msgBox.Name = "msgBox";
            msgBox.Size = new Size(803, 34);
            msgBox.TabIndex = 2;
            // 
            // sendMsgButton
            // 
            sendMsgButton.Font = new Font("Liberation Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sendMsgButton.Location = new Point(837, 441);
            sendMsgButton.Margin = new Padding(3, 4, 3, 4);
            sendMsgButton.Name = "sendMsgButton";
            sendMsgButton.Size = new Size(113, 48);
            sendMsgButton.TabIndex = 3;
            sendMsgButton.Text = "Send ";
            sendMsgButton.UseVisualStyleBackColor = true;
            sendMsgButton.Click += sendMsgButton_Click;
            // 
            // Game
            // 
            Game.BackColor = SystemColors.InfoText;
            Game.Font = new Font("Microsoft Sans Serif", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Game.ForeColor = SystemColors.Menu;
            Game.FormattingEnabled = true;
            Game.Location = new Point(9, 54);
            Game.Margin = new Padding(3, 4, 3, 4);
            Game.Name = "Game";
            Game.Size = new Size(954, 328);
            Game.TabIndex = 4;
            Game.SelectedIndexChanged += Game_SelectedIndexChanged;
            // 
            // msgBoxLabel
            // 
            msgBoxLabel.AutoSize = true;
            msgBoxLabel.Font = new Font("Liberation Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msgBoxLabel.Location = new Point(7, 400);
            msgBoxLabel.Name = "msgBoxLabel";
            msgBoxLabel.Size = new Size(222, 25);
            msgBoxLabel.TabIndex = 5;
            msgBoxLabel.Text = "Type messages below";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { networkToolStripMenuItem, systemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // networkToolStripMenuItem
            // 
            networkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            networkToolStripMenuItem.Size = new Size(62, 24);
            networkToolStripMenuItem.Text = "Game";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // systemToolStripMenuItem
            // 
            systemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { connectToolStripMenuItem, disconnectToolStripMenuItem });
            systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            systemToolStripMenuItem.Size = new Size(79, 24);
            systemToolStripMenuItem.Text = "Network";
            systemToolStripMenuItem.Click += systemToolStripMenuItem_Click;
            // 
            // connectToolStripMenuItem
            // 
            connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            connectToolStripMenuItem.Size = new Size(165, 26);
            connectToolStripMenuItem.Text = "Connect";
            connectToolStripMenuItem.Click += connectToolStripMenuItem_Click;
            // 
            // disconnectToolStripMenuItem
            // 
            disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            disconnectToolStripMenuItem.Size = new Size(165, 26);
            disconnectToolStripMenuItem.Text = "Disconnect";
            disconnectToolStripMenuItem.Click += disconnectToolStripMenuItem_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.Location = new Point(12, 528);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(979, 304);
            listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 841);
            Controls.Add(listBox1);
            Controls.Add(msgBoxLabel);
            Controls.Add(Game);
            Controls.Add(sendMsgButton);
            Controls.Add(msgBox);
            Controls.Add(ChatLog);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ChatLog;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Button sendMsgButton;
        private System.Windows.Forms.ListBox Game;
        private System.Windows.Forms.Label msgBoxLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private ListBox listBox1;
    }
}


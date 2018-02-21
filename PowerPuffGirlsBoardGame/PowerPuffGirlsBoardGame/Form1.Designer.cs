namespace PowerPuffGirlsBoardGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bubblesResultBox = new System.Windows.Forms.Label();
            this.blossomResultBox = new System.Windows.Forms.Label();
            this.buttercupResultBox = new System.Windows.Forms.Label();
            this.bubblesLostFightButton = new System.Windows.Forms.Button();
            this.blossomLostFightButton = new System.Windows.Forms.Button();
            this.buttercupLostFightButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.bubblesDicePoolDisplay = new System.Windows.Forms.Label();
            this.blossomDicePoolDisplay = new System.Windows.Forms.Label();
            this.buttercupDicePoolDisplay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playLongVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bubblesResultBox
            // 
            this.bubblesResultBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.bubblesResultBox.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubblesResultBox.Location = new System.Drawing.Point(110, 800);
            this.bubblesResultBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bubblesResultBox.Name = "bubblesResultBox";
            this.bubblesResultBox.Size = new System.Drawing.Size(160, 148);
            this.bubblesResultBox.TabIndex = 0;
            this.bubblesResultBox.Text = " 0";
            this.bubblesResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bubblesResultBox.Visible = false;
            // 
            // blossomResultBox
            // 
            this.blossomResultBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.blossomResultBox.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blossomResultBox.Location = new System.Drawing.Point(494, 800);
            this.blossomResultBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blossomResultBox.Name = "blossomResultBox";
            this.blossomResultBox.Size = new System.Drawing.Size(160, 148);
            this.blossomResultBox.TabIndex = 1;
            this.blossomResultBox.Text = "0";
            this.blossomResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blossomResultBox.Visible = false;
            // 
            // buttercupResultBox
            // 
            this.buttercupResultBox.BackColor = System.Drawing.Color.LightGreen;
            this.buttercupResultBox.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttercupResultBox.Location = new System.Drawing.Point(827, 800);
            this.buttercupResultBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttercupResultBox.Name = "buttercupResultBox";
            this.buttercupResultBox.Size = new System.Drawing.Size(160, 148);
            this.buttercupResultBox.TabIndex = 2;
            this.buttercupResultBox.Text = "0";
            this.buttercupResultBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttercupResultBox.Visible = false;
            // 
            // bubblesLostFightButton
            // 
            this.bubblesLostFightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubblesLostFightButton.Location = new System.Drawing.Point(87, 952);
            this.bubblesLostFightButton.Margin = new System.Windows.Forms.Padding(4);
            this.bubblesLostFightButton.Name = "bubblesLostFightButton";
            this.bubblesLostFightButton.Size = new System.Drawing.Size(217, 50);
            this.bubblesLostFightButton.TabIndex = 5;
            this.bubblesLostFightButton.Text = "Lost Fight";
            this.bubblesLostFightButton.UseVisualStyleBackColor = true;
            this.bubblesLostFightButton.Visible = false;
            // 
            // blossomLostFightButton
            // 
            this.blossomLostFightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blossomLostFightButton.Location = new System.Drawing.Point(461, 952);
            this.blossomLostFightButton.Margin = new System.Windows.Forms.Padding(4);
            this.blossomLostFightButton.Name = "blossomLostFightButton";
            this.blossomLostFightButton.Size = new System.Drawing.Size(217, 50);
            this.blossomLostFightButton.TabIndex = 6;
            this.blossomLostFightButton.Text = "Lost Fight";
            this.blossomLostFightButton.UseVisualStyleBackColor = true;
            this.blossomLostFightButton.Visible = false;
            // 
            // buttercupLostFightButton
            // 
            this.buttercupLostFightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttercupLostFightButton.Location = new System.Drawing.Point(795, 952);
            this.buttercupLostFightButton.Margin = new System.Windows.Forms.Padding(4);
            this.buttercupLostFightButton.Name = "buttercupLostFightButton";
            this.buttercupLostFightButton.Size = new System.Drawing.Size(217, 50);
            this.buttercupLostFightButton.TabIndex = 7;
            this.buttercupLostFightButton.Text = "Lost Fight";
            this.buttercupLostFightButton.UseVisualStyleBackColor = true;
            this.buttercupLostFightButton.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(148)))));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logo.Image = global::PowerPuffGirlsBoardGame.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(314, 32);
            this.logo.Margin = new System.Windows.Forms.Padding(4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(499, 182);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 9;
            this.logo.TabStop = false;
            // 
            // bubblesDicePoolDisplay
            // 
            this.bubblesDicePoolDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(148)))));
            this.bubblesDicePoolDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubblesDicePoolDisplay.Location = new System.Drawing.Point(87, 761);
            this.bubblesDicePoolDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bubblesDicePoolDisplay.Name = "bubblesDicePoolDisplay";
            this.bubblesDicePoolDisplay.Size = new System.Drawing.Size(217, 39);
            this.bubblesDicePoolDisplay.TabIndex = 10;
            this.bubblesDicePoolDisplay.Text = "122344";
            this.bubblesDicePoolDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blossomDicePoolDisplay
            // 
            this.blossomDicePoolDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(148)))));
            this.blossomDicePoolDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blossomDicePoolDisplay.Location = new System.Drawing.Point(461, 761);
            this.blossomDicePoolDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blossomDicePoolDisplay.Name = "blossomDicePoolDisplay";
            this.blossomDicePoolDisplay.Size = new System.Drawing.Size(217, 39);
            this.blossomDicePoolDisplay.TabIndex = 11;
            this.blossomDicePoolDisplay.Text = "122344";
            this.blossomDicePoolDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttercupDicePoolDisplay
            // 
            this.buttercupDicePoolDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(148)))));
            this.buttercupDicePoolDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttercupDicePoolDisplay.Location = new System.Drawing.Point(795, 761);
            this.buttercupDicePoolDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buttercupDicePoolDisplay.Name = "buttercupDicePoolDisplay";
            this.buttercupDicePoolDisplay.Size = new System.Drawing.Size(217, 39);
            this.buttercupDicePoolDisplay.TabIndex = 12;
            this.buttercupDicePoolDisplay.Text = "122344";
            this.buttercupDicePoolDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.musicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resetGameToolStripMenuItem
            // 
            this.resetGameToolStripMenuItem.Name = "resetGameToolStripMenuItem";
            this.resetGameToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.resetGameToolStripMenuItem.Text = "Reset Game";
            this.resetGameToolStripMenuItem.Click += new System.EventHandler(this.resetGameToolStripMenuItem_Click);
            // 
            // musicToolStripMenuItem
            // 
            this.musicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playMusicToolStripMenuItem,
            this.playLongVersionToolStripMenuItem,
            this.stopMusicToolStripMenuItem,
            this.loopToolStripMenuItem});
            this.musicToolStripMenuItem.Name = "musicToolStripMenuItem";
            this.musicToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.musicToolStripMenuItem.Text = "Music";
            // 
            // playMusicToolStripMenuItem
            // 
            this.playMusicToolStripMenuItem.Name = "playMusicToolStripMenuItem";
            this.playMusicToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.playMusicToolStripMenuItem.Text = "Play Theme Song - Short";
            this.playMusicToolStripMenuItem.Click += new System.EventHandler(this.playMusicToolStripMenuItem_Click);
            // 
            // stopMusicToolStripMenuItem
            // 
            this.stopMusicToolStripMenuItem.Name = "stopMusicToolStripMenuItem";
            this.stopMusicToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.stopMusicToolStripMenuItem.Text = "Stop Music";
            this.stopMusicToolStripMenuItem.Click += new System.EventHandler(this.stopMusicToolStripMenuItem_Click);
            // 
            // playLongVersionToolStripMenuItem
            // 
            this.playLongVersionToolStripMenuItem.Name = "playLongVersionToolStripMenuItem";
            this.playLongVersionToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.playLongVersionToolStripMenuItem.Text = "Play Theme Song - Long";
            this.playLongVersionToolStripMenuItem.Click += new System.EventHandler(this.playLongVersionToolStripMenuItem_Click);
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.loopToolStripMenuItem.Text = "Loop";
            this.loopToolStripMenuItem.Click += new System.EventHandler(this.loopToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(148)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1117, 1015);
            this.Controls.Add(this.buttercupDicePoolDisplay);
            this.Controls.Add(this.blossomDicePoolDisplay);
            this.Controls.Add(this.bubblesDicePoolDisplay);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.buttercupLostFightButton);
            this.Controls.Add(this.blossomLostFightButton);
            this.Controls.Add(this.bubblesLostFightButton);
            this.Controls.Add(this.buttercupResultBox);
            this.Controls.Add(this.blossomResultBox);
            this.Controls.Add(this.bubblesResultBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Power Puff Girls!";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bubblesResultBox;
        private System.Windows.Forms.Label blossomResultBox;
        private System.Windows.Forms.Label buttercupResultBox;
        private System.Windows.Forms.Button bubblesLostFightButton;
        private System.Windows.Forms.Button blossomLostFightButton;
        private System.Windows.Forms.Button buttercupLostFightButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label bubblesDicePoolDisplay;
        private System.Windows.Forms.Label blossomDicePoolDisplay;
        private System.Windows.Forms.Label buttercupDicePoolDisplay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playLongVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}


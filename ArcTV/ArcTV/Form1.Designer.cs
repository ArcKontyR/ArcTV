namespace ArcTV
{
    partial class TV
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblExit = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lblPrevious = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.tbChannelSelect = new System.Windows.Forms.TextBox();
            this.pbSwitch = new System.Windows.Forms.PictureBox();
            this.pbTV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Location = new System.Drawing.Point(333, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(22, 22);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblChannel
            // 
            this.lblChannel.BackColor = System.Drawing.Color.Transparent;
            this.lblChannel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChannel.ForeColor = System.Drawing.Color.Black;
            this.lblChannel.Location = new System.Drawing.Point(60, 158);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(247, 48);
            this.lblChannel.TabIndex = 3;
            this.lblChannel.Text = "label1";
            this.lblChannel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrevious
            // 
            this.lblPrevious.AutoSize = true;
            this.lblPrevious.BackColor = System.Drawing.Color.Black;
            this.lblPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrevious.Location = new System.Drawing.Point(121, 307);
            this.lblPrevious.Name = "lblPrevious";
            this.lblPrevious.Size = new System.Drawing.Size(22, 22);
            this.lblPrevious.TabIndex = 4;
            this.lblPrevious.Text = "<";
            this.lblPrevious.Click += new System.EventHandler(this.lblPrevious_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.Black;
            this.lblNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNext.Location = new System.Drawing.Point(225, 307);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(22, 22);
            this.lblNext.TabIndex = 5;
            this.lblNext.Text = ">";
            this.lblNext.Click += new System.EventHandler(this.lblNext_Click);
            // 
            // tbChannelSelect
            // 
            this.tbChannelSelect.BackColor = System.Drawing.Color.Black;
            this.tbChannelSelect.Enabled = false;
            this.tbChannelSelect.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.tbChannelSelect.ForeColor = System.Drawing.Color.White;
            this.tbChannelSelect.Location = new System.Drawing.Point(149, 304);
            this.tbChannelSelect.MaxLength = 4;
            this.tbChannelSelect.Name = "tbChannelSelect";
            this.tbChannelSelect.Size = new System.Drawing.Size(70, 30);
            this.tbChannelSelect.TabIndex = 6;
            this.tbChannelSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbChannelSelect.TextChanged += new System.EventHandler(this.tbChannelSelect_TextChanged);
            this.tbChannelSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChannelSelect_KeyPress);
            // 
            // pbSwitch
            // 
            this.pbSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSwitch.Image = global::ArcTV.Properties.Resources.off;
            this.pbSwitch.Location = new System.Drawing.Point(33, 304);
            this.pbSwitch.Name = "pbSwitch";
            this.pbSwitch.Size = new System.Drawing.Size(23, 23);
            this.pbSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSwitch.TabIndex = 2;
            this.pbSwitch.TabStop = false;
            this.pbSwitch.Click += new System.EventHandler(this.pbSwitch_Click);
            // 
            // pbTV
            // 
            this.pbTV.Image = global::ArcTV.Properties.Resources.TVOff;
            this.pbTV.Location = new System.Drawing.Point(12, 34);
            this.pbTV.Name = "pbTV";
            this.pbTV.Size = new System.Drawing.Size(343, 311);
            this.pbTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTV.TabIndex = 1;
            this.pbTV.TabStop = false;
            // 
            // TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(367, 357);
            this.ControlBox = false;
            this.Controls.Add(this.tbChannelSelect);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblPrevious);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.pbSwitch);
            this.Controls.Add(this.pbTV);
            this.Controls.Add(this.lblExit);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pbTV;
        private System.Windows.Forms.PictureBox pbSwitch;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Label lblPrevious;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.TextBox tbChannelSelect;
    }
}


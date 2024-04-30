namespace ChatServer
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxRecievedMessages = new System.Windows.Forms.TextBox();
            this.textBoxSentMessages = new System.Windows.Forms.TextBox();
            this.buttonSendMessages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(563, 42);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 41);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxRecievedMessages
            // 
            this.textBoxRecievedMessages.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecievedMessages.Location = new System.Drawing.Point(23, 35);
            this.textBoxRecievedMessages.Multiline = true;
            this.textBoxRecievedMessages.Name = "textBoxRecievedMessages";
            this.textBoxRecievedMessages.Size = new System.Drawing.Size(518, 169);
            this.textBoxRecievedMessages.TabIndex = 1;
            // 
            // textBoxSentMessages
            // 
            this.textBoxSentMessages.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentMessages.Location = new System.Drawing.Point(23, 222);
            this.textBoxSentMessages.Multiline = true;
            this.textBoxSentMessages.Name = "textBoxSentMessages";
            this.textBoxSentMessages.Size = new System.Drawing.Size(518, 169);
            this.textBoxSentMessages.TabIndex = 2;
            // 
            // buttonSendMessages
            // 
            this.buttonSendMessages.Location = new System.Drawing.Point(573, 239);
            this.buttonSendMessages.Name = "buttonSendMessages";
            this.buttonSendMessages.Size = new System.Drawing.Size(104, 41);
            this.buttonSendMessages.TabIndex = 3;
            this.buttonSendMessages.Text = "Send";
            this.buttonSendMessages.UseVisualStyleBackColor = true;
            this.buttonSendMessages.Click += new System.EventHandler(this.buttonSendMessages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSendMessages);
            this.Controls.Add(this.textBoxSentMessages);
            this.Controls.Add(this.textBoxRecievedMessages);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxRecievedMessages;
        private System.Windows.Forms.TextBox textBoxSentMessages;
        private System.Windows.Forms.Button buttonSendMessages;
    }
}


namespace ChatClient
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonSendMessages = new System.Windows.Forms.Button();
            this.textBoxSentMessages = new System.Windows.Forms.TextBox();
            this.textBoxRecievedMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(598, 59);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(103, 36);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonSendMessages
            // 
            this.buttonSendMessages.Location = new System.Drawing.Point(597, 244);
            this.buttonSendMessages.Name = "buttonSendMessages";
            this.buttonSendMessages.Size = new System.Drawing.Size(104, 41);
            this.buttonSendMessages.TabIndex = 6;
            this.buttonSendMessages.Text = "Send";
            this.buttonSendMessages.UseVisualStyleBackColor = true;
            this.buttonSendMessages.Click += new System.EventHandler(this.buttonSendMessages_Click);
            // 
            // textBoxSentMessages
            // 
            this.textBoxSentMessages.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSentMessages.Location = new System.Drawing.Point(47, 227);
            this.textBoxSentMessages.Multiline = true;
            this.textBoxSentMessages.Name = "textBoxSentMessages";
            this.textBoxSentMessages.Size = new System.Drawing.Size(518, 169);
            this.textBoxSentMessages.TabIndex = 5;
            // 
            // textBoxRecievedMessages
            // 
            this.textBoxRecievedMessages.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecievedMessages.Location = new System.Drawing.Point(47, 40);
            this.textBoxRecievedMessages.Multiline = true;
            this.textBoxRecievedMessages.Name = "textBoxRecievedMessages";
            this.textBoxRecievedMessages.Size = new System.Drawing.Size(518, 169);
            this.textBoxRecievedMessages.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSendMessages);
            this.Controls.Add(this.textBoxSentMessages);
            this.Controls.Add(this.textBoxRecievedMessages);
            this.Controls.Add(this.buttonConnect);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonSendMessages;
        private System.Windows.Forms.TextBox textBoxSentMessages;
        private System.Windows.Forms.TextBox textBoxRecievedMessages;
    }
}


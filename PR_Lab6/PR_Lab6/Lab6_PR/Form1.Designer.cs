namespace Lab6_PR
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
               this.panel1 = new System.Windows.Forms.Panel();
               this.buttonSClient = new System.Windows.Forms.Button();
               this.buttonConnectClient = new System.Windows.Forms.Button();
               this.textBoxClient = new System.Windows.Forms.TextBox();
               this.labelConnectedTo_Client = new System.Windows.Forms.Label();
               this.panel2 = new System.Windows.Forms.Panel();
               this.buttonSendServer = new System.Windows.Forms.Button();
               this.buttonListen = new System.Windows.Forms.Button();
               this.textBoxServer = new System.Windows.Forms.TextBox();
               this.labelConnectedTo_Server = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.labelConversation = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.panel1.SuspendLayout();
               this.panel2.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel1
               // 
               this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel1.Controls.Add(this.buttonSClient);
               this.panel1.Controls.Add(this.buttonConnectClient);
               this.panel1.Controls.Add(this.textBoxClient);
               this.panel1.Controls.Add(this.labelConnectedTo_Client);
               this.panel1.Location = new System.Drawing.Point(12, 36);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(270, 312);
               this.panel1.TabIndex = 0;
               // 
               // buttonSClient
               // 
               this.buttonSClient.Location = new System.Drawing.Point(198, 261);
               this.buttonSClient.Name = "buttonSClient";
               this.buttonSClient.Size = new System.Drawing.Size(67, 33);
               this.buttonSClient.TabIndex = 4;
               this.buttonSClient.Text = "Send";
               this.buttonSClient.UseVisualStyleBackColor = true;
               // 
               // buttonConnectClient
               // 
               this.buttonConnectClient.Location = new System.Drawing.Point(3, 46);
               this.buttonConnectClient.Name = "buttonConnectClient";
               this.buttonConnectClient.Size = new System.Drawing.Size(262, 33);
               this.buttonConnectClient.TabIndex = 3;
               this.buttonConnectClient.Text = "Connect";
               this.buttonConnectClient.UseVisualStyleBackColor = true;
               // 
               // textBoxClient
               // 
               this.textBoxClient.Location = new System.Drawing.Point(6, 85);
               this.textBoxClient.Multiline = true;
               this.textBoxClient.Name = "textBoxClient";
               this.textBoxClient.Size = new System.Drawing.Size(186, 209);
               this.textBoxClient.TabIndex = 3;
               // 
               // labelConnectedTo_Client
               // 
               this.labelConnectedTo_Client.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.labelConnectedTo_Client.Location = new System.Drawing.Point(3, 11);
               this.labelConnectedTo_Client.Name = "labelConnectedTo_Client";
               this.labelConnectedTo_Client.Size = new System.Drawing.Size(262, 23);
               this.labelConnectedTo_Client.TabIndex = 0;
               this.labelConnectedTo_Client.Text = "Connected To :";
               this.labelConnectedTo_Client.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // panel2
               // 
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel2.Controls.Add(this.buttonSendServer);
               this.panel2.Controls.Add(this.buttonListen);
               this.panel2.Controls.Add(this.textBoxServer);
               this.panel2.Controls.Add(this.labelConnectedTo_Server);
               this.panel2.Location = new System.Drawing.Point(672, 36);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(273, 312);
               this.panel2.TabIndex = 1;
               // 
               // buttonSendServer
               // 
               this.buttonSendServer.Location = new System.Drawing.Point(195, 261);
               this.buttonSendServer.Name = "buttonSendServer";
               this.buttonSendServer.Size = new System.Drawing.Size(73, 33);
               this.buttonSendServer.TabIndex = 7;
               this.buttonSendServer.Text = "Send";
               this.buttonSendServer.UseVisualStyleBackColor = true;
               // 
               // buttonListen
               // 
               this.buttonListen.Location = new System.Drawing.Point(3, 46);
               this.buttonListen.Name = "buttonListen";
               this.buttonListen.Size = new System.Drawing.Size(265, 33);
               this.buttonListen.TabIndex = 2;
               this.buttonListen.Text = "Listen";
               this.buttonListen.UseVisualStyleBackColor = true;
               // 
               // textBoxServer
               // 
               this.textBoxServer.Location = new System.Drawing.Point(3, 85);
               this.textBoxServer.Multiline = true;
               this.textBoxServer.Name = "textBoxServer";
               this.textBoxServer.Size = new System.Drawing.Size(186, 209);
               this.textBoxServer.TabIndex = 6;
               // 
               // labelConnectedTo_Server
               // 
               this.labelConnectedTo_Server.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.labelConnectedTo_Server.Location = new System.Drawing.Point(3, 11);
               this.labelConnectedTo_Server.Name = "labelConnectedTo_Server";
               this.labelConnectedTo_Server.Size = new System.Drawing.Size(265, 23);
               this.labelConnectedTo_Server.TabIndex = 0;
               this.labelConnectedTo_Server.Text = "Connected To :";
               this.labelConnectedTo_Server.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // label2
               // 
               this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(12, 9);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(270, 23);
               this.label2.TabIndex = 1;
               this.label2.Text = "Client";
               this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // label3
               // 
               this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(672, 9);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(273, 23);
               this.label3.TabIndex = 2;
               this.label3.Text = "Server";
               this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // labelConversation
               // 
               this.labelConversation.BackColor = System.Drawing.Color.Gainsboro;
               this.labelConversation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.labelConversation.Location = new System.Drawing.Point(288, 36);
               this.labelConversation.Name = "labelConversation";
               this.labelConversation.Size = new System.Drawing.Size(378, 315);
               this.labelConversation.TabIndex = 1;
               // 
               // label6
               // 
               this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.label6.Location = new System.Drawing.Point(288, 9);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(378, 23);
               this.label6.TabIndex = 2;
               this.label6.Text = "Conversation";
               this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.label6.Click += new System.EventHandler(this.label6_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(957, 360);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.labelConversation);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label labelConnectedTo_Client;
        public System.Windows.Forms.Button buttonSClient;
        public System.Windows.Forms.Button buttonConnectClient;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button buttonSendServer;
        public System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.TextBox textBoxServer;
        public System.Windows.Forms.Label labelConnectedTo_Server;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label labelConversation;
        private System.Windows.Forms.Label label6;
    }
}


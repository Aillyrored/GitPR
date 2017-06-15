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
               this.panel2 = new System.Windows.Forms.Panel();
               this.buttonSendServer = new System.Windows.Forms.Button();
               this.textBoxServer = new System.Windows.Forms.TextBox();
               this.labelConversation = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.panel2.SuspendLayout();
               this.SuspendLayout();
               // 
               // panel2
               // 
               this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.panel2.Controls.Add(this.buttonSendServer);
               this.panel2.Controls.Add(this.textBoxServer);
               this.panel2.Location = new System.Drawing.Point(12, 439);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(549, 57);
               this.panel2.TabIndex = 1;
               // 
               // buttonSendServer
               // 
               this.buttonSendServer.Location = new System.Drawing.Point(471, 19);
               this.buttonSendServer.Name = "buttonSendServer";
               this.buttonSendServer.Size = new System.Drawing.Size(73, 33);
               this.buttonSendServer.TabIndex = 7;
               this.buttonSendServer.Text = "Send";
               this.buttonSendServer.UseVisualStyleBackColor = true;
               // 
               // textBoxServer
               // 
               this.textBoxServer.Location = new System.Drawing.Point(3, 3);
               this.textBoxServer.Multiline = true;
               this.textBoxServer.Name = "textBoxServer";
               this.textBoxServer.Size = new System.Drawing.Size(462, 49);
               this.textBoxServer.TabIndex = 6;
               // 
               // labelConversation
               // 
               this.labelConversation.BackColor = System.Drawing.Color.Honeydew;
               this.labelConversation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.labelConversation.Location = new System.Drawing.Point(12, 32);
               this.labelConversation.Name = "labelConversation";
               this.labelConversation.Size = new System.Drawing.Size(549, 381);
               this.labelConversation.TabIndex = 1;
               // 
               // label6
               // 
               this.label6.Location = new System.Drawing.Point(13, 9);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(549, 23);
               this.label6.TabIndex = 2;
               this.label6.Text = "Client";
               this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.label6.Click += new System.EventHandler(this.label6_Click);
               // 
               // label1
               // 
               this.label1.Location = new System.Drawing.Point(13, 413);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(549, 23);
               this.label1.TabIndex = 3;
               this.label1.Text = "Server";
               this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(573, 508);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.panel2);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.labelConversation);
               this.Name = "Form1";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button buttonSendServer;
        public  System.Windows.Forms.TextBox textBoxServer;
        public System.Windows.Forms.Label labelConversation;
        private System.Windows.Forms.Label label6;
          private System.Windows.Forms.Label label1;
     }
}


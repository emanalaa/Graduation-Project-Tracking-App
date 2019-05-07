namespace Graduation_Tracking_Project.Supervisor_Mentor_Home
{
    partial class Email_Students
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sender_txtbox = new System.Windows.Forms.TextBox();
            this.reciever_cmbobox = new System.Windows.Forms.ComboBox();
            this.message_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // sender_txtbox
            // 
            this.sender_txtbox.Location = new System.Drawing.Point(78, 35);
            this.sender_txtbox.Name = "sender_txtbox";
            this.sender_txtbox.ReadOnly = true;
            this.sender_txtbox.Size = new System.Drawing.Size(312, 22);
            this.sender_txtbox.TabIndex = 2;
            // 
            // reciever_cmbobox
            // 
            this.reciever_cmbobox.FormattingEnabled = true;
            this.reciever_cmbobox.Location = new System.Drawing.Point(78, 66);
            this.reciever_cmbobox.Name = "reciever_cmbobox";
            this.reciever_cmbobox.Size = new System.Drawing.Size(312, 24);
            this.reciever_cmbobox.TabIndex = 3;
            // 
            // message_txtbox
            // 
            this.message_txtbox.Location = new System.Drawing.Point(26, 164);
            this.message_txtbox.Multiline = true;
            this.message_txtbox.Name = "message_txtbox";
            this.message_txtbox.Size = new System.Drawing.Size(727, 257);
            this.message_txtbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Message";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Email_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message_txtbox);
            this.Controls.Add(this.reciever_cmbobox);
            this.Controls.Add(this.sender_txtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Email_Students";
            this.Text = "Email_Students";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sender_txtbox;
        private System.Windows.Forms.ComboBox reciever_cmbobox;
        private System.Windows.Forms.TextBox message_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}
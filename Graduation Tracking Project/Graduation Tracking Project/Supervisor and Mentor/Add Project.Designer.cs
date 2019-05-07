namespace Graduation_Tracking_Project.Supervisor_and_Mentor
{
    partial class Add_Project
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
            this.end_date_txtbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.st_date_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.desc_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // end_date_txtbox
            // 
            this.end_date_txtbox.Location = new System.Drawing.Point(157, 292);
            this.end_date_txtbox.Name = "end_date_txtbox";
            this.end_date_txtbox.Size = new System.Drawing.Size(235, 22);
            this.end_date_txtbox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "End Date";
            // 
            // st_date_txtbox
            // 
            this.st_date_txtbox.Location = new System.Drawing.Point(157, 231);
            this.st_date_txtbox.Name = "st_date_txtbox";
            this.st_date_txtbox.Size = new System.Drawing.Size(235, 22);
            this.st_date_txtbox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Start Date";
            // 
            // desc_txtbox
            // 
            this.desc_txtbox.Location = new System.Drawing.Point(157, 121);
            this.desc_txtbox.Multiline = true;
            this.desc_txtbox.Name = "desc_txtbox";
            this.desc_txtbox.Size = new System.Drawing.Size(235, 87);
            this.desc_txtbox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(157, 76);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(235, 22);
            this.name_txtbox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Project Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 48);
            this.button1.TabIndex = 19;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end_date_txtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.st_date_txtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc_txtbox);
            this.Controls.Add(this.label2);
            this.Name = "Add_Project";
            this.Text = "Add_Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox end_date_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox st_date_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desc_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
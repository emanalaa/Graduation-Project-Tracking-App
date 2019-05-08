namespace Graduation_Tracking_Project.Supervisor_Mentor_Home
{
    partial class Post_Office_Hours
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(283, 160);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 57);
            this.textBox1.TabIndex = 0;
            // 
            // update_button
            // 
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(175, 289);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(157, 41);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Recent Office Hours";
            // 
            // Post_Office_Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.textBox1);
            this.Name = "Post_Office_Hours";
            this.Text = "Post_Office_Hours";
            this.Load += new System.EventHandler(this.Post_Office_Hours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label1;
    }
}
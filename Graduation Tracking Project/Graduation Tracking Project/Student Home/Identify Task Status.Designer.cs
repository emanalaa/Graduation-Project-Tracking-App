namespace Graduation_Tracking_Project
{
    partial class Identify_Task_Status
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
            this.textBox_projectid = new System.Windows.Forms.TextBox();
            this.textBox_taskid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_projectid
            // 
            this.textBox_projectid.Location = new System.Drawing.Point(281, 64);
            this.textBox_projectid.Multiline = true;
            this.textBox_projectid.Name = "textBox_projectid";
            this.textBox_projectid.Size = new System.Drawing.Size(186, 57);
            this.textBox_projectid.TabIndex = 2;
            this.textBox_projectid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_taskid
            // 
            this.textBox_taskid.Location = new System.Drawing.Point(281, 179);
            this.textBox_taskid.Multiline = true;
            this.textBox_taskid.Name = "textBox_taskid";
            this.textBox_taskid.Size = new System.Drawing.Size(186, 57);
            this.textBox_taskid.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project ID";
            // 
            // update_button
            // 
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(177, 363);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(157, 41);
            this.update_button.TabIndex = 7;
            this.update_button.Text = "SET STATUS";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(281, 275);
            this.textBox_status.Multiline = true;
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.Size = new System.Drawing.Size(186, 57);
            this.textBox_status.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Task Status";
            // 
            // Identify_Task_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 440);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_status);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_taskid);
            this.Controls.Add(this.textBox_projectid);
            this.Name = "Identify_Task_Status";
            this.Text = "Identify_Task_Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_projectid;
        private System.Windows.Forms.TextBox textBox_taskid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.Label label3;
    }
}
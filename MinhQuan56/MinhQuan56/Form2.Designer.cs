
namespace MinhQuan56
{
    partial class Form2
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
            this.btMQ_56 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMQ_56
            // 
            this.btMQ_56.Location = new System.Drawing.Point(333, 202);
            this.btMQ_56.Name = "btMQ_56";
            this.btMQ_56.Size = new System.Drawing.Size(124, 45);
            this.btMQ_56.TabIndex = 2;
            this.btMQ_56.Text = "Open";
            this.btMQ_56.UseVisualStyleBackColor = true;
            this.btMQ_56.Click += new System.EventHandler(this.btMQ_56_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMQ_56);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btMQ_56;
    }
}
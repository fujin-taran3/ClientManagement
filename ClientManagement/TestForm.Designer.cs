
namespace ClientManagement
{
    partial class TestForm
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
            this.testStartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testStartButton
            // 
            this.testStartButton.Location = new System.Drawing.Point(305, 246);
            this.testStartButton.Name = "testStartButton";
            this.testStartButton.Size = new System.Drawing.Size(183, 55);
            this.testStartButton.TabIndex = 0;
            this.testStartButton.Text = "testStart";
            this.testStartButton.UseVisualStyleBackColor = true;
            this.testStartButton.Click += new System.EventHandler(this.TestStart_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testStartButton);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testStartButton;
    }
}

namespace ClientManagement
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelControl = new System.Windows.Forms.Panel();
            this.LavelLoginName = new System.Windows.Forms.Label();
            this.ButtonBackControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PanelControl
            // 
            this.PanelControl.AutoScroll = true;
            this.PanelControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelControl.Location = new System.Drawing.Point(0, 46);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.Size = new System.Drawing.Size(1098, 791);
            this.PanelControl.TabIndex = 0;
            // 
            // LavelLoginName
            // 
            this.LavelLoginName.AutoSize = true;
            this.LavelLoginName.Location = new System.Drawing.Point(878, 16);
            this.LavelLoginName.Name = "LavelLoginName";
            this.LavelLoginName.Size = new System.Drawing.Size(0, 24);
            this.LavelLoginName.TabIndex = 2;
            // 
            // ButtonBackControl
            // 
            this.ButtonBackControl.Location = new System.Drawing.Point(12, 0);
            this.ButtonBackControl.Name = "ButtonBackControl";
            this.ButtonBackControl.Size = new System.Drawing.Size(99, 40);
            this.ButtonBackControl.TabIndex = 3;
            this.ButtonBackControl.Text = "戻る";
            this.ButtonBackControl.UseVisualStyleBackColor = true;
            this.ButtonBackControl.Click += new System.EventHandler(this.ButtonBackControlClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1091, 823);
            this.Controls.Add(this.ButtonBackControl);
            this.Controls.Add(this.LavelLoginName);
            this.Controls.Add(this.PanelControl);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "ClientManagement";
            this.Resize += new System.EventHandler(this.FormResizeEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelControl;
        private System.Windows.Forms.Label LavelLoginName;
        private System.Windows.Forms.Button ButtonBackControl;
    }
}


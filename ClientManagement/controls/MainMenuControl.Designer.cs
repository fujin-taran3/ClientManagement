﻿
namespace ClientManagement.controls
{
    partial class MainMenuControl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelMainMenuTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelMainMenuTitle
            // 
            this.LabelMainMenuTitle.AutoSize = true;
            this.LabelMainMenuTitle.Font = new System.Drawing.Font("MS UI Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LabelMainMenuTitle.Location = new System.Drawing.Point(319, 0);
            this.LabelMainMenuTitle.Name = "LabelMainMenuTitle";
            this.LabelMainMenuTitle.Size = new System.Drawing.Size(293, 53);
            this.LabelMainMenuTitle.TabIndex = 0;
            this.LabelMainMenuTitle.Text = "メインメニュー";
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelMainMenuTitle);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMainMenuTitle;
    }
}
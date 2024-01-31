
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
            this.ButtonClient = new System.Windows.Forms.Button();
            this.ButtonWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonClient
            // 
            this.ButtonClient.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonClient.Location = new System.Drawing.Point(95, 183);
            this.ButtonClient.Name = "ButtonClient";
            this.ButtonClient.Size = new System.Drawing.Size(270, 322);
            this.ButtonClient.TabIndex = 0;
            this.ButtonClient.Text = "顧客管理";
            this.ButtonClient.UseVisualStyleBackColor = true;
            this.ButtonClient.Click += new System.EventHandler(this.ButtonClientClick);
            // 
            // ButtonWorker
            // 
            this.ButtonWorker.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonWorker.Location = new System.Drawing.Point(631, 183);
            this.ButtonWorker.Name = "ButtonWorker";
            this.ButtonWorker.Size = new System.Drawing.Size(270, 322);
            this.ButtonWorker.TabIndex = 1;
            this.ButtonWorker.Text = "従業員管理";
            this.ButtonWorker.UseVisualStyleBackColor = true;
            this.ButtonWorker.Click += new System.EventHandler(this.ButtonWorkerClick);
            // 
            // MainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonWorker);
            this.Controls.Add(this.ButtonClient);
            this.Name = "MainMenuControl";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonClient;
        private System.Windows.Forms.Button ButtonWorker;
    }
}


namespace ClientManagement.controls
{
    partial class ClientLogControl
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
            this.ButtonMaxPage = new System.Windows.Forms.Button();
            this.ButtonMinPage = new System.Windows.Forms.Button();
            this.LabelFindCount = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonMaxPage
            // 
            this.ButtonMaxPage.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMaxPage.Location = new System.Drawing.Point(153, 117);
            this.ButtonMaxPage.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonMaxPage.Name = "ButtonMaxPage";
            this.ButtonMaxPage.Size = new System.Drawing.Size(62, 40);
            this.ButtonMaxPage.TabIndex = 22;
            this.ButtonMaxPage.Text = "7";
            this.ButtonMaxPage.UseVisualStyleBackColor = true;
            this.ButtonMaxPage.Click += new System.EventHandler(this.ButtonMaxPage_Click);
            // 
            // ButtonMinPage
            // 
            this.ButtonMinPage.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMinPage.Location = new System.Drawing.Point(78, 117);
            this.ButtonMinPage.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonMinPage.Name = "ButtonMinPage";
            this.ButtonMinPage.Size = new System.Drawing.Size(65, 40);
            this.ButtonMinPage.TabIndex = 21;
            this.ButtonMinPage.Text = "1";
            this.ButtonMinPage.UseVisualStyleBackColor = true;
            this.ButtonMinPage.UseWaitCursor = true;
            this.ButtonMinPage.Click += new System.EventHandler(this.ButtonMinPage_Click);
            // 
            // LabelFindCount
            // 
            this.LabelFindCount.AutoSize = true;
            this.LabelFindCount.Location = new System.Drawing.Point(681, 131);
            this.LabelFindCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFindCount.Name = "LabelFindCount";
            this.LabelFindCount.Size = new System.Drawing.Size(196, 24);
            this.LabelFindCount.TabIndex = 20;
            this.LabelFindCount.Text = "1件中1件目を表示";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonBack.Location = new System.Drawing.Point(19, 116);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(5, 5, 13, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(41, 40);
            this.ButtonBack.TabIndex = 19;
            this.ButtonBack.Text = "<";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonNext.Location = new System.Drawing.Point(228, 115);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(13, 5, 5, 5);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(41, 40);
            this.ButtonNext.TabIndex = 18;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(0, 166);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1087, 634);
            this.DataGridView.TabIndex = 17;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(685, 42);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(169, 53);
            this.ButtonUpdate.TabIndex = 23;
            this.ButtonUpdate.Text = "更新";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ClientLogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonMaxPage);
            this.Controls.Add(this.ButtonMinPage);
            this.Controls.Add(this.LabelFindCount);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.DataGridView);
            this.Name = "ClientLogControl";
            this.Size = new System.Drawing.Size(1092, 805);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonMaxPage;
        private System.Windows.Forms.Button ButtonMinPage;
        private System.Windows.Forms.Label LabelFindCount;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ButtonUpdate;
    }
}

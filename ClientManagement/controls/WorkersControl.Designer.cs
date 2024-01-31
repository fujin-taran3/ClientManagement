
namespace ClientManagement.controls
{
    partial class WorkersControl
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
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonMaxPage = new System.Windows.Forms.Button();
            this.ButtonMinPage = new System.Windows.Forms.Button();
            this.LabelFindCount = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSearch.BackgroundImage = global::ClientManagement.Properties.Resources.bug_gokiburi;
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.Location = new System.Drawing.Point(50, 34);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(62, 58);
            this.ButtonSearch.TabIndex = 28;
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonMaxPage
            // 
            this.ButtonMaxPage.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMaxPage.Location = new System.Drawing.Point(153, 117);
            this.ButtonMaxPage.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonMaxPage.Name = "ButtonMaxPage";
            this.ButtonMaxPage.Size = new System.Drawing.Size(62, 40);
            this.ButtonMaxPage.TabIndex = 27;
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
            this.ButtonMinPage.TabIndex = 26;
            this.ButtonMinPage.Text = "1";
            this.ButtonMinPage.UseVisualStyleBackColor = true;
            this.ButtonMinPage.UseWaitCursor = true;
            this.ButtonMinPage.Click += new System.EventHandler(this.ButtonMinPage_Click);
            // 
            // LabelFindCount
            // 
            this.LabelFindCount.AutoSize = true;
            this.LabelFindCount.Location = new System.Drawing.Point(753, 137);
            this.LabelFindCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFindCount.Name = "LabelFindCount";
            this.LabelFindCount.Size = new System.Drawing.Size(196, 24);
            this.LabelFindCount.TabIndex = 25;
            this.LabelFindCount.Text = "1件中1件目を表示";
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonBack.Location = new System.Drawing.Point(19, 116);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(5, 5, 13, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(41, 40);
            this.ButtonBack.TabIndex = 24;
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
            this.ButtonNext.TabIndex = 23;
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
            this.DataGridView.Size = new System.Drawing.Size(1108, 634);
            this.DataGridView.TabIndex = 19;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(120, 48);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(454, 31);
            this.TextBoxSearch.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "検索";
            // 
            // WorkersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonMaxPage);
            this.Controls.Add(this.ButtonMinPage);
            this.Controls.Add(this.LabelFindCount);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.TextBoxSearch);
            this.Name = "WorkersControl";
            this.Size = new System.Drawing.Size(1113, 805);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonMaxPage;
        private System.Windows.Forms.Button ButtonMinPage;
        private System.Windows.Forms.Label LabelFindCount;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}

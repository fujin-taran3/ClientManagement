
namespace ClientManagement
{
    partial class ClientsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ButtonLog = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelFindCount = new System.Windows.Forms.Label();
            this.ButtonMinPage = new System.Windows.Forms.Button();
            this.ButtonMaxPage = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(120, 24);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(454, 31);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.ButtonLog});
            this.DataGridView.Location = new System.Drawing.Point(0, 142);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(1108, 634);
            this.DataGridView.TabIndex = 3;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ButtonLogClick);
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CheckBox.HeaderText = "選択";
            this.CheckBox.MinimumWidth = 6;
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 64;
            // 
            // ButtonLog
            // 
            this.ButtonLog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ButtonLog.DefaultCellStyle = dataGridViewCellStyle1;
            this.ButtonLog.HeaderText = "購入ログ";
            this.ButtonLog.MinimumWidth = 10;
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Text = "移動";
            this.ButtonLog.UseColumnTextForButtonValue = true;
            this.ButtonLog.Width = 99;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(598, 24);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(122, 37);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "登録";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(730, 24);
            this.ButtonChange.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(122, 37);
            this.ButtonChange.TabIndex = 5;
            this.ButtonChange.Text = "変更";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChangeClick);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(862, 24);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(122, 37);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "削除";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonNext.Location = new System.Drawing.Point(228, 91);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(13, 5, 5, 5);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(41, 40);
            this.ButtonNext.TabIndex = 7;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonBack.Location = new System.Drawing.Point(19, 92);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(5, 5, 13, 5);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(41, 40);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "<";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // LabelFindCount
            // 
            this.LabelFindCount.AutoSize = true;
            this.LabelFindCount.Location = new System.Drawing.Point(753, 113);
            this.LabelFindCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelFindCount.Name = "LabelFindCount";
            this.LabelFindCount.Size = new System.Drawing.Size(196, 24);
            this.LabelFindCount.TabIndex = 9;
            this.LabelFindCount.Text = "1件中1件目を表示";
            // 
            // ButtonMinPage
            // 
            this.ButtonMinPage.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMinPage.Location = new System.Drawing.Point(78, 93);
            this.ButtonMinPage.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonMinPage.Name = "ButtonMinPage";
            this.ButtonMinPage.Size = new System.Drawing.Size(65, 40);
            this.ButtonMinPage.TabIndex = 10;
            this.ButtonMinPage.Text = "1";
            this.ButtonMinPage.UseVisualStyleBackColor = true;
            this.ButtonMinPage.UseWaitCursor = true;
            this.ButtonMinPage.Click += new System.EventHandler(this.ButtonMinPageClick);
            // 
            // ButtonMaxPage
            // 
            this.ButtonMaxPage.Font = new System.Drawing.Font("MS UI Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMaxPage.Location = new System.Drawing.Point(153, 93);
            this.ButtonMaxPage.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonMaxPage.Name = "ButtonMaxPage";
            this.ButtonMaxPage.Size = new System.Drawing.Size(62, 40);
            this.ButtonMaxPage.TabIndex = 16;
            this.ButtonMaxPage.Text = "7";
            this.ButtonMaxPage.UseVisualStyleBackColor = true;
            this.ButtonMaxPage.Click += new System.EventHandler(this.ButtonMaxPageClick);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSearch.BackgroundImage = global::ClientManagement.Properties.Resources.bug_gokiburi;
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSearch.Location = new System.Drawing.Point(50, 10);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(62, 58);
            this.ButtonSearch.TabIndex = 17;
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "検索";
            // 
            // ClientsControl
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
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.TextBoxSearch);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(1113, 781);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelFindCount;
        private System.Windows.Forms.Button ButtonMinPage;
        private System.Windows.Forms.Button ButtonMaxPage;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewButtonColumn ButtonLog;
        private System.Windows.Forms.Label label1;
    }
}

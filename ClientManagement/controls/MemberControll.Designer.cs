
namespace ClientManagement
{
    partial class MemberControll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberControll));
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.PictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBoxSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelFindCount = new System.Windows.Forms.Label();
            this.ButtonMinPage = new System.Windows.Forms.Button();
            this.ButtonMinLeft = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonCenter = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonMaxRight = new System.Windows.Forms.Button();
            this.ButtonMaxPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(74, 15);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(281, 22);
            this.TextBoxSearch.TabIndex = 1;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearchTextChanged);
            // 
            // PictureBoxSearch
            // 
            this.PictureBoxSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PictureBoxSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxSearch.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSearch.Image")));
            this.PictureBoxSearch.Location = new System.Drawing.Point(42, 15);
            this.PictureBoxSearch.Name = "PictureBoxSearch";
            this.PictureBoxSearch.Size = new System.Drawing.Size(26, 22);
            this.PictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxSearch.TabIndex = 2;
            this.PictureBoxSearch.TabStop = false;
            this.PictureBoxSearch.Click += new System.EventHandler(this.PictureBoxSearchClick);
            this.PictureBoxSearch.MouseEnter += new System.EventHandler(this.PIctureBoxSearchEnter);
            this.PictureBoxSearch.MouseLeave += new System.EventHandler(this.PictureBoxSearchLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxSelect});
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 396);
            this.dataGridView1.TabIndex = 3;
            // 
            // CheckBoxSelect
            // 
            this.CheckBoxSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CheckBoxSelect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxSelect.HeaderText = "複数選択";
            this.CheckBoxSelect.MinimumWidth = 6;
            this.CheckBoxSelect.Name = "CheckBoxSelect";
            this.CheckBoxSelect.Width = 73;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(385, 15);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 4;
            this.ButtonAdd.Text = "登録";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(466, 15);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(75, 23);
            this.ButtonChange.TabIndex = 5;
            this.ButtonChange.Text = "変更";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChangeClick);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(549, 15);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "削除";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonNext.Location = new System.Drawing.Point(235, 58);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(25, 25);
            this.ButtonNext.TabIndex = 7;
            this.ButtonNext.Text = ">";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNextClick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonBack.Location = new System.Drawing.Point(17, 58);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(25, 25);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "<";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // LabelFindCount
            // 
            this.LabelFindCount.AutoSize = true;
            this.LabelFindCount.Location = new System.Drawing.Point(500, 66);
            this.LabelFindCount.Name = "LabelFindCount";
            this.LabelFindCount.Size = new System.Drawing.Size(124, 15);
            this.LabelFindCount.TabIndex = 9;
            this.LabelFindCount.Text = "1件中1件目を表示";
            // 
            // ButtonMinPage
            // 
            this.ButtonMinPage.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMinPage.Location = new System.Drawing.Point(48, 58);
            this.ButtonMinPage.Name = "ButtonMinPage";
            this.ButtonMinPage.Size = new System.Drawing.Size(25, 25);
            this.ButtonMinPage.TabIndex = 10;
            this.ButtonMinPage.Text = "1";
            this.ButtonMinPage.UseVisualStyleBackColor = true;
            this.ButtonMinPage.UseWaitCursor = true;
            this.ButtonMinPage.Click += new System.EventHandler(this.ButtonMinPageClick);
            // 
            // ButtonMinLeft
            // 
            this.ButtonMinLeft.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMinLeft.Location = new System.Drawing.Point(74, 58);
            this.ButtonMinLeft.Name = "ButtonMinLeft";
            this.ButtonMinLeft.Size = new System.Drawing.Size(25, 25);
            this.ButtonMinLeft.TabIndex = 11;
            this.ButtonMinLeft.Text = "2";
            this.ButtonMinLeft.UseVisualStyleBackColor = true;
            this.ButtonMinLeft.Click += new System.EventHandler(this.ButtonMinLeftClick);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonLeft.Location = new System.Drawing.Point(100, 58);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(25, 25);
            this.ButtonLeft.TabIndex = 12;
            this.ButtonLeft.Text = "3";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            // 
            // ButtonCenter
            // 
            this.ButtonCenter.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonCenter.Location = new System.Drawing.Point(126, 58);
            this.ButtonCenter.Name = "ButtonCenter";
            this.ButtonCenter.Size = new System.Drawing.Size(25, 25);
            this.ButtonCenter.TabIndex = 13;
            this.ButtonCenter.Text = "4";
            this.ButtonCenter.UseVisualStyleBackColor = true;
            this.ButtonCenter.Click += new System.EventHandler(this.ButtonCenterClick);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonRight.Location = new System.Drawing.Point(152, 58);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(25, 25);
            this.ButtonRight.TabIndex = 14;
            this.ButtonRight.Text = "5";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRightClick);
            // 
            // ButtonMaxRight
            // 
            this.ButtonMaxRight.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMaxRight.Location = new System.Drawing.Point(178, 58);
            this.ButtonMaxRight.Name = "ButtonMaxRight";
            this.ButtonMaxRight.Size = new System.Drawing.Size(25, 25);
            this.ButtonMaxRight.TabIndex = 15;
            this.ButtonMaxRight.Text = "6";
            this.ButtonMaxRight.UseVisualStyleBackColor = true;
            this.ButtonMaxRight.Click += new System.EventHandler(this.ButtonMaxRightClick);
            // 
            // ButtonMaxPage
            // 
            this.ButtonMaxPage.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ButtonMaxPage.Location = new System.Drawing.Point(204, 58);
            this.ButtonMaxPage.Name = "ButtonMaxPage";
            this.ButtonMaxPage.Size = new System.Drawing.Size(25, 25);
            this.ButtonMaxPage.TabIndex = 16;
            this.ButtonMaxPage.Text = "7";
            this.ButtonMaxPage.UseVisualStyleBackColor = true;
            this.ButtonMaxPage.Click += new System.EventHandler(this.ButtonMaxPageClick);
            // 
            // MemberControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonMaxPage);
            this.Controls.Add(this.ButtonMaxRight);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonCenter);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.ButtonMinLeft);
            this.Controls.Add(this.ButtonMinPage);
            this.Controls.Add(this.LabelFindCount);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PictureBoxSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Name = "MemberControll";
            this.Size = new System.Drawing.Size(682, 485);
            this.Load += new System.EventHandler(this.MemberControllLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.PictureBox PictureBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxSelect;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelFindCount;
        private System.Windows.Forms.Button ButtonMinPage;
        private System.Windows.Forms.Button ButtonMinLeft;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonCenter;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonMaxRight;
        private System.Windows.Forms.Button ButtonMaxPage;
    }
}

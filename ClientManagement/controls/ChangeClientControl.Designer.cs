﻿
namespace ClientManagement.controls
{
    partial class ChangeClientControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.RadioButtonOther = new System.Windows.Forms.RadioButton();
            this.RadioButtonWoman = new System.Windows.Forms.RadioButton();
            this.RadioButtonMan = new System.Windows.Forms.RadioButton();
            this.LabelGender = new System.Windows.Forms.Label();
            this.LabelBirthday = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.TextBoxMail = new System.Windows.Forms.TextBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "パスワード";
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Location = new System.Drawing.Point(245, 172);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(339, 31);
            this.TextBoxPass.TabIndex = 18;
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(67, 458);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(148, 86);
            this.ButtonChange.TabIndex = 17;
            this.ButtonChange.Text = "変更";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChangeClick);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(245, 254);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(339, 31);
            this.DateTimePicker.TabIndex = 16;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.RadioButtonOther);
            this.GroupBox.Controls.Add(this.RadioButtonWoman);
            this.GroupBox.Controls.Add(this.RadioButtonMan);
            this.GroupBox.Location = new System.Drawing.Point(245, 363);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(257, 33);
            this.GroupBox.TabIndex = 15;
            this.GroupBox.TabStop = false;
            // 
            // RadioButtonOther
            // 
            this.RadioButtonOther.AutoSize = true;
            this.RadioButtonOther.Checked = true;
            this.RadioButtonOther.Location = new System.Drawing.Point(142, 0);
            this.RadioButtonOther.Name = "RadioButtonOther";
            this.RadioButtonOther.Size = new System.Drawing.Size(103, 28);
            this.RadioButtonOther.TabIndex = 2;
            this.RadioButtonOther.TabStop = true;
            this.RadioButtonOther.Text = "その他";
            this.RadioButtonOther.UseVisualStyleBackColor = true;
            // 
            // RadioButtonWoman
            // 
            this.RadioButtonWoman.AutoSize = true;
            this.RadioButtonWoman.Location = new System.Drawing.Point(71, 0);
            this.RadioButtonWoman.Name = "RadioButtonWoman";
            this.RadioButtonWoman.Size = new System.Drawing.Size(65, 28);
            this.RadioButtonWoman.TabIndex = 1;
            this.RadioButtonWoman.Text = "女";
            this.RadioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMan
            // 
            this.RadioButtonMan.AutoSize = true;
            this.RadioButtonMan.Location = new System.Drawing.Point(0, 0);
            this.RadioButtonMan.Name = "RadioButtonMan";
            this.RadioButtonMan.Size = new System.Drawing.Size(65, 28);
            this.RadioButtonMan.TabIndex = 0;
            this.RadioButtonMan.Text = "男";
            this.RadioButtonMan.UseVisualStyleBackColor = true;
            // 
            // LabelGender
            // 
            this.LabelGender.AutoSize = true;
            this.LabelGender.Location = new System.Drawing.Point(63, 363);
            this.LabelGender.Name = "LabelGender";
            this.LabelGender.Size = new System.Drawing.Size(58, 24);
            this.LabelGender.TabIndex = 14;
            this.LabelGender.Text = "性別";
            // 
            // LabelBirthday
            // 
            this.LabelBirthday.AutoSize = true;
            this.LabelBirthday.Location = new System.Drawing.Point(63, 254);
            this.LabelBirthday.Name = "LabelBirthday";
            this.LabelBirthday.Size = new System.Drawing.Size(82, 24);
            this.LabelBirthday.TabIndex = 13;
            this.LabelBirthday.Text = "誕生日";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(63, 104);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(138, 24);
            this.LabelID.TabIndex = 12;
            this.LabelID.Text = "メールアドレス";
            // 
            // TextBoxMail
            // 
            this.TextBoxMail.Location = new System.Drawing.Point(245, 97);
            this.TextBoxMail.Name = "TextBoxMail";
            this.TextBoxMail.Size = new System.Drawing.Size(339, 31);
            this.TextBoxMail.TabIndex = 11;
            // 
            // ChangeClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.LabelGender);
            this.Controls.Add(this.LabelBirthday);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TextBoxMail);
            this.Name = "ChangeClientControl";
            this.Size = new System.Drawing.Size(1000, 800);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.RadioButton RadioButtonOther;
        private System.Windows.Forms.RadioButton RadioButtonWoman;
        private System.Windows.Forms.RadioButton RadioButtonMan;
        private System.Windows.Forms.Label LabelGender;
        private System.Windows.Forms.Label LabelBirthday;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.TextBox TextBoxMail;
    }
}

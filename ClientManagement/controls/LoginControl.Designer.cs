
namespace ClientManagement.controls
{
    partial class LoginControl
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
            this.components = new System.ComponentModel.Container();
            this.TextboxID = new System.Windows.Forms.TextBox();
            this.ClientManagement = new System.Windows.Forms.Label();
            this.TextboxPassword = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.BottonGoLogin = new System.Windows.Forms.Button();
            this.ButtonDBInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextboxID
            // 
            this.TextboxID.ForeColor = System.Drawing.Color.Black;
            this.TextboxID.Location = new System.Drawing.Point(199, 236);
            this.TextboxID.Multiline = true;
            this.TextboxID.Name = "TextboxID";
            this.TextboxID.Size = new System.Drawing.Size(656, 38);
            this.TextboxID.TabIndex = 0;
            // 
            // ClientManagement
            // 
            this.ClientManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientManagement.AutoSize = true;
            this.ClientManagement.Font = new System.Drawing.Font("MS UI Gothic", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ClientManagement.Location = new System.Drawing.Point(186, 58);
            this.ClientManagement.Margin = new System.Windows.Forms.Padding(0);
            this.ClientManagement.Name = "ClientManagement";
            this.ClientManagement.Size = new System.Drawing.Size(612, 75);
            this.ClientManagement.TabIndex = 1;
            this.ClientManagement.Text = "なんか管理するやつ";
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Location = new System.Drawing.Point(199, 334);
            this.TextboxPassword.Multiline = true;
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(656, 38);
            this.TextboxPassword.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(59, 239);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(102, 24);
            this.LabelID.TabIndex = 4;
            this.LabelID.Text = "ログインID";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(59, 337);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(103, 24);
            this.LabelPassword.TabIndex = 5;
            this.LabelPassword.Text = "パスワード";
            // 
            // BottonGoLogin
            // 
            this.BottonGoLogin.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BottonGoLogin.Location = new System.Drawing.Point(408, 500);
            this.BottonGoLogin.Name = "BottonGoLogin";
            this.BottonGoLogin.Size = new System.Drawing.Size(144, 69);
            this.BottonGoLogin.TabIndex = 6;
            this.BottonGoLogin.Text = "GO";
            this.BottonGoLogin.UseVisualStyleBackColor = true;
            this.BottonGoLogin.Click += new System.EventHandler(this.GoLoginButtonClick);
            // 
            // ButtonDBInit
            // 
            this.ButtonDBInit.Location = new System.Drawing.Point(722, 596);
            this.ButtonDBInit.Name = "ButtonDBInit";
            this.ButtonDBInit.Size = new System.Drawing.Size(133, 40);
            this.ButtonDBInit.TabIndex = 7;
            this.ButtonDBInit.Text = "DB初期化";
            this.ButtonDBInit.UseVisualStyleBackColor = true;
            this.ButtonDBInit.Click += new System.EventHandler(this.InitializeButtonClick);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonDBInit);
            this.Controls.Add(this.BottonGoLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.TextboxPassword);
            this.Controls.Add(this.ClientManagement);
            this.Controls.Add(this.TextboxID);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1000, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxID;
        private System.Windows.Forms.Label ClientManagement;
        private System.Windows.Forms.TextBox TextboxPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button BottonGoLogin;
        private System.Windows.Forms.Button ButtonDBInit;
    }
}

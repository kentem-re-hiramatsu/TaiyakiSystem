namespace TaiyakiSystem
{
    partial class OrderForm
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
            this.MenuGroupBox = new System.Windows.Forms.GroupBox();
            this.DeluxeRadioButton = new System.Windows.Forms.RadioButton();
            this.CustardRadioButton = new System.Windows.Forms.RadioButton();
            this.DefaultRadioButton = new System.Windows.Forms.RadioButton();
            this.SizeGroupBox = new System.Windows.Forms.GroupBox();
            this.SmallRadioButton = new System.Windows.Forms.RadioButton();
            this.BigRadioButton = new System.Windows.Forms.RadioButton();
            this.MiddleRadioButton = new System.Windows.Forms.RadioButton();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MenuGroupBox.SuspendLayout();
            this.SizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuGroupBox
            // 
            this.MenuGroupBox.Controls.Add(this.DeluxeRadioButton);
            this.MenuGroupBox.Controls.Add(this.CustardRadioButton);
            this.MenuGroupBox.Controls.Add(this.DefaultRadioButton);
            this.MenuGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MenuGroupBox.Name = "MenuGroupBox";
            this.MenuGroupBox.Size = new System.Drawing.Size(330, 85);
            this.MenuGroupBox.TabIndex = 0;
            this.MenuGroupBox.TabStop = false;
            this.MenuGroupBox.Text = "メニュー";
            // 
            // DeluxeRadioButton
            // 
            this.DeluxeRadioButton.AutoSize = true;
            this.DeluxeRadioButton.Location = new System.Drawing.Point(213, 37);
            this.DeluxeRadioButton.Name = "DeluxeRadioButton";
            this.DeluxeRadioButton.Size = new System.Drawing.Size(105, 16);
            this.DeluxeRadioButton.TabIndex = 2;
            this.DeluxeRadioButton.TabStop = true;
            this.DeluxeRadioButton.Text = "デラックスたい焼き";
            this.DeluxeRadioButton.UseVisualStyleBackColor = true;
            // 
            // CustardRadioButton
            // 
            this.CustardRadioButton.AutoSize = true;
            this.CustardRadioButton.Location = new System.Drawing.Point(99, 37);
            this.CustardRadioButton.Name = "CustardRadioButton";
            this.CustardRadioButton.Size = new System.Drawing.Size(108, 16);
            this.CustardRadioButton.TabIndex = 1;
            this.CustardRadioButton.TabStop = true;
            this.CustardRadioButton.Text = "カスタードたい焼き";
            this.CustardRadioButton.UseVisualStyleBackColor = true;
            // 
            // DefaultRadioButton
            // 
            this.DefaultRadioButton.AutoSize = true;
            this.DefaultRadioButton.Checked = true;
            this.DefaultRadioButton.Location = new System.Drawing.Point(6, 37);
            this.DefaultRadioButton.Name = "DefaultRadioButton";
            this.DefaultRadioButton.Size = new System.Drawing.Size(87, 16);
            this.DefaultRadioButton.TabIndex = 0;
            this.DefaultRadioButton.TabStop = true;
            this.DefaultRadioButton.Text = "通常たい焼き";
            this.DefaultRadioButton.UseVisualStyleBackColor = true;
            // 
            // SizeGroupBox
            // 
            this.SizeGroupBox.Controls.Add(this.SmallRadioButton);
            this.SizeGroupBox.Controls.Add(this.BigRadioButton);
            this.SizeGroupBox.Controls.Add(this.MiddleRadioButton);
            this.SizeGroupBox.Location = new System.Drawing.Point(12, 132);
            this.SizeGroupBox.Name = "SizeGroupBox";
            this.SizeGroupBox.Size = new System.Drawing.Size(330, 78);
            this.SizeGroupBox.TabIndex = 1;
            this.SizeGroupBox.TabStop = false;
            this.SizeGroupBox.Text = "サイズ";
            // 
            // SmallRadioButton
            // 
            this.SmallRadioButton.AutoSize = true;
            this.SmallRadioButton.Location = new System.Drawing.Point(229, 38);
            this.SmallRadioButton.Name = "SmallRadioButton";
            this.SmallRadioButton.Size = new System.Drawing.Size(35, 16);
            this.SmallRadioButton.TabIndex = 4;
            this.SmallRadioButton.TabStop = true;
            this.SmallRadioButton.Text = "小";
            this.SmallRadioButton.UseVisualStyleBackColor = true;
            // 
            // BigRadioButton
            // 
            this.BigRadioButton.AutoSize = true;
            this.BigRadioButton.Checked = true;
            this.BigRadioButton.Location = new System.Drawing.Point(58, 38);
            this.BigRadioButton.Name = "BigRadioButton";
            this.BigRadioButton.Size = new System.Drawing.Size(35, 16);
            this.BigRadioButton.TabIndex = 3;
            this.BigRadioButton.TabStop = true;
            this.BigRadioButton.Text = "大";
            this.BigRadioButton.UseVisualStyleBackColor = true;
            // 
            // MiddleRadioButton
            // 
            this.MiddleRadioButton.AutoSize = true;
            this.MiddleRadioButton.Location = new System.Drawing.Point(140, 38);
            this.MiddleRadioButton.Name = "MiddleRadioButton";
            this.MiddleRadioButton.Size = new System.Drawing.Size(35, 16);
            this.MiddleRadioButton.TabIndex = 3;
            this.MiddleRadioButton.TabStop = true;
            this.MiddleRadioButton.Text = "中";
            this.MiddleRadioButton.UseVisualStyleBackColor = true;
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(158, 267);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(89, 38);
            this.BuyButton.TabIndex = 2;
            this.BuyButton.Text = "購入";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(253, 267);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 38);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 317);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.SizeGroupBox);
            this.Controls.Add(this.MenuGroupBox);
            this.Name = "OrderForm";
            this.Text = "たい焼き種類選択";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.MenuGroupBox.ResumeLayout(false);
            this.MenuGroupBox.PerformLayout();
            this.SizeGroupBox.ResumeLayout(false);
            this.SizeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MenuGroupBox;
        private System.Windows.Forms.RadioButton DeluxeRadioButton;
        private System.Windows.Forms.RadioButton CustardRadioButton;
        private System.Windows.Forms.RadioButton DefaultRadioButton;
        private System.Windows.Forms.GroupBox SizeGroupBox;
        private System.Windows.Forms.RadioButton SmallRadioButton;
        private System.Windows.Forms.RadioButton BigRadioButton;
        private System.Windows.Forms.RadioButton MiddleRadioButton;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button CancelButton;
    }
}


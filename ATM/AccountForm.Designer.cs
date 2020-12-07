using System.ComponentModel;

namespace ATM
{
    partial class AccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabelKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.cardNumberLable = new System.Windows.Forms.Label();
            this.balanceLable = new System.Windows.Forms.Label();
            this.getBtn = new System.Windows.Forms.Button();
            this.amountField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabelKey
            // 
            this.nameLabelKey.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabelKey.Location = new System.Drawing.Point(9, 71);
            this.nameLabelKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabelKey.Name = "nameLabelKey";
            this.nameLabelKey.Size = new System.Drawing.Size(200, 29);
            this.nameLabelKey.TabIndex = 0;
            this.nameLabelKey.Text = "Имя:";
            this.nameLabelKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер карты:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Баланс:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameLable
            // 
            this.nameLable.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLable.Location = new System.Drawing.Point(213, 71);
            this.nameLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(378, 29);
            this.nameLable.TabIndex = 3;
            this.nameLable.Text = "Test name";
            this.nameLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardNumberLable
            // 
            this.cardNumberLable.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cardNumberLable.Location = new System.Drawing.Point(213, 101);
            this.cardNumberLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cardNumberLable.Name = "cardNumberLable";
            this.cardNumberLable.Size = new System.Drawing.Size(378, 29);
            this.cardNumberLable.TabIndex = 4;
            this.cardNumberLable.Text = "5135723886843840";
            this.cardNumberLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // balanceLable
            // 
            this.balanceLable.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceLable.Location = new System.Drawing.Point(213, 130);
            this.balanceLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.balanceLable.Name = "balanceLable";
            this.balanceLable.Size = new System.Drawing.Size(378, 29);
            this.balanceLable.TabIndex = 5;
            this.balanceLable.Text = "00";
            this.balanceLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(218, 208);
            this.getBtn.Margin = new System.Windows.Forms.Padding(2);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(118, 29);
            this.getBtn.TabIndex = 6;
            this.getBtn.Text = "Снять со счета";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // amountField
            // 
            this.amountField.Location = new System.Drawing.Point(198, 184);
            this.amountField.Margin = new System.Windows.Forms.Padding(2);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(155, 20);
            this.amountField.TabIndex = 7;
            this.amountField.TextChanged += new System.EventHandler(this.AmountField_TextChanged);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.balanceLable);
            this.Controls.Add(this.cardNumberLable);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabelKey);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.Button getBtn;

        private System.Windows.Forms.Label balanceLable;
        private System.Windows.Forms.Label cardNumberLable;
        private System.Windows.Forms.Label nameLable;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label nameLabelKey;

        #endregion
    }
}
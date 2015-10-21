namespace Calc
{
    partial class Calc
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.plusResult = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 1;
            // 
            // plusResult
            // 
            this.plusResult.AutoSize = true;
            this.plusResult.Location = new System.Drawing.Point(201, 156);
            this.plusResult.Name = "plusResult";
            this.plusResult.Size = new System.Drawing.Size(52, 18);
            this.plusResult.TabIndex = 2;
            this.plusResult.Text = "label1";
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(57, 150);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(100, 30);
            this.plus.TabIndex = 2;
            this.plus.Text = "足し算";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Button_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 403);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.plusResult);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Calc";
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label plusResult;
        private System.Windows.Forms.Button plus;
    }
}


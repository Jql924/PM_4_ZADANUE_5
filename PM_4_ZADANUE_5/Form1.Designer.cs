namespace NumeralSystemConverterVariant5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.comboFrom = new System.Windows.Forms.ComboBox();
            this.comboTo = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInput.Location = new System.Drawing.Point(30, 30);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(260, 29);
            this.txtInput.TabIndex = 0;
            // 
            // comboFrom
            // 
            this.comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboFrom.FormattingEnabled = true;
            this.comboFrom.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboFrom.Location = new System.Drawing.Point(30, 80);
            this.comboFrom.Name = "comboFrom";
            this.comboFrom.Size = new System.Drawing.Size(100, 29);
            this.comboFrom.TabIndex = 1;
            // 
            // comboTo
            // 
            this.comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboTo.FormattingEnabled = true;
            this.comboTo.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.comboTo.Location = new System.Drawing.Point(190, 80);
            this.comboTo.Name = "comboTo";
            this.comboTo.Size = new System.Drawing.Size(100, 29);
            this.comboTo.TabIndex = 2;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConvert.Location = new System.Drawing.Point(30, 130);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(260, 35);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Преобразовать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblResult.Location = new System.Drawing.Point(30, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(260, 35);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Результат:";
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnTest.Location = new System.Drawing.Point(30, 230);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(260, 35);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Запустить тесты";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 301);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.comboTo);
            this.Controls.Add(this.comboFrom);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Конвертер систем счисления (Вариант 5)";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ComboBox comboFrom;
        private System.Windows.Forms.ComboBox comboTo;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnTest;
    }
}

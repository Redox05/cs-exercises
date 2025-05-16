namespace BankAccountsApp
{
    partial class BankAccountForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            CreateAccountBtn = new Button();
            BankAccountGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            AmountNum = new NumericUpDown();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(41, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 39);
            label1.TabIndex = 0;
            label1.Text = "Owner: ";
            // 
            // label2
            // 
            label2.Location = new Point(32, 364);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 39);
            label2.TabIndex = 1;
            label2.Text = "Amount: ";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(152, 14);
            OwnerTxt.Margin = new Padding(5);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(230, 38);
            OwnerTxt.TabIndex = 2;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(153, 160);
            CreateAccountBtn.Margin = new Padding(5);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(231, 49);
            CreateAccountBtn.TabIndex = 4;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(392, 14);
            BankAccountGrid.Margin = new Padding(5);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.RowHeadersWidth = 51;
            BankAccountGrid.Size = new Size(465, 284);
            BankAccountGrid.TabIndex = 5;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(392, 354);
            DepositBtn.Margin = new Padding(5);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(194, 49);
            DepositBtn.TabIndex = 6;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(596, 354);
            WithdrawBtn.Margin = new Padding(5);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(194, 49);
            WithdrawBtn.TabIndex = 7;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(151, 361);
            AmountNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 99999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(233, 38);
            AmountNum.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 95);
            label3.Name = "label3";
            label3.Size = new Size(181, 31);
            label3.TabIndex = 9;
            label3.Text = "Interest rate (%):";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(232, 93);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(150, 38);
            InterestRateNum.TabIndex = 10;
            // 
            // BankAccountForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(871, 417);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(AmountNum);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountGrid);
            Controls.Add(CreateAccountBtn);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "BankAccountForm";
            Text = "Bank Accounts Form";
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private Button CreateAccountBtn;
        private DataGridView BankAccountGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private NumericUpDown AmountNum;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}

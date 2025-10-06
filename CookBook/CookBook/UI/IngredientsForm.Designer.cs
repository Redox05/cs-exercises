namespace CookBook.UI
{
    partial class IngredientsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            AddToFridgeBtn = new Button();
            NameTxt = new TextBox();
            TypeTxt = new TextBox();
            WeightNum = new NumericUpDown();
            KcalPer100gNum = new NumericUpDown();
            PricePer100gNum = new NumericUpDown();
            IngredientsGrid = new DataGridView();
            SearchTxt = new TextBox();
            SearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)WeightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(950, 106);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(950, 178);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 38);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(950, 254);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 38);
            label3.TabIndex = 2;
            label3.Text = "Weight (g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(950, 326);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 38);
            label4.TabIndex = 3;
            label4.Text = "Kcal (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(950, 403);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 38);
            label5.TabIndex = 4;
            label5.Text = "Price (100g)";
            // 
            // AddToFridgeBtn
            // 
            AddToFridgeBtn.Location = new Point(1184, 509);
            AddToFridgeBtn.Name = "AddToFridgeBtn";
            AddToFridgeBtn.Size = new Size(251, 51);
            AddToFridgeBtn.TabIndex = 5;
            AddToFridgeBtn.Text = "Add to my fridge";
            AddToFridgeBtn.UseVisualStyleBackColor = true;
            AddToFridgeBtn.Click += AddToFridgeBtn_Click;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(1184, 106);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(251, 43);
            NameTxt.TabIndex = 6;
            // 
            // TypeTxt
            // 
            TypeTxt.Location = new Point(1184, 178);
            TypeTxt.Name = "TypeTxt";
            TypeTxt.Size = new Size(251, 43);
            TypeTxt.TabIndex = 7;
            // 
            // WeightNum
            // 
            WeightNum.DecimalPlaces = 2;
            WeightNum.Location = new Point(1184, 254);
            WeightNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            WeightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WeightNum.Name = "WeightNum";
            WeightNum.Size = new Size(251, 43);
            WeightNum.TabIndex = 8;
            WeightNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.DecimalPlaces = 2;
            KcalPer100gNum.Location = new Point(1184, 326);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(251, 43);
            KcalPer100gNum.TabIndex = 9;
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(1184, 403);
            PricePer100gNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(251, 43);
            PricePer100gNum.TabIndex = 10;
            // 
            // IngredientsGrid
            // 
            IngredientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsGrid.Location = new Point(12, 106);
            IngredientsGrid.Name = "IngredientsGrid";
            IngredientsGrid.RowHeadersWidth = 51;
            IngredientsGrid.Size = new Size(929, 454);
            IngredientsGrid.TabIndex = 11;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(12, 28);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "Type ingredient name...";
            SearchTxt.Size = new Size(718, 43);
            SearchTxt.TabIndex = 12;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(761, 28);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(180, 43);
            SearchBtn.TabIndex = 13;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 605);
            Controls.Add(SearchBtn);
            Controls.Add(SearchTxt);
            Controls.Add(IngredientsGrid);
            Controls.Add(PricePer100gNum);
            Controls.Add(KcalPer100gNum);
            Controls.Add(WeightNum);
            Controls.Add(TypeTxt);
            Controls.Add(NameTxt);
            Controls.Add(AddToFridgeBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "IngredientsForm";
            Text = "My Fridge";
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)WeightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button AddToFridgeBtn;
        private TextBox NameTxt;
        private TextBox TypeTxt;
        private NumericUpDown WeightNum;
        private NumericUpDown KcalPer100gNum;
        private NumericUpDown PricePer100gNum;
        private DataGridView IngredientsGrid;
        private TextBox SearchTxt;
        private Button SearchBtn;
    }
}
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
            ClearAllFieldsBtn = new Button();
            EditIngredientBtn = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SortByNameAscBtn = new Button();
            SortByNameDescBtn = new Button();
            SortByKcalAscBtn = new Button();
            SortByKcalDescBtn = new Button();
            SortByPriceDescBtn = new Button();
            SortByPriceAscBtn = new Button();
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
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(950, 179);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 38);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(950, 254);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 38);
            label3.TabIndex = 2;
            label3.Text = "Weight (g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(950, 327);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 38);
            label4.TabIndex = 3;
            label4.Text = "Kcal (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(950, 404);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 38);
            label5.TabIndex = 4;
            label5.Text = "Price (100g)";
            // 
            // AddToFridgeBtn
            // 
            AddToFridgeBtn.Location = new Point(950, 479);
            AddToFridgeBtn.Name = "AddToFridgeBtn";
            AddToFridgeBtn.Size = new Size(485, 51);
            AddToFridgeBtn.TabIndex = 5;
            AddToFridgeBtn.Text = "Add to my fridge";
            AddToFridgeBtn.UseVisualStyleBackColor = true;
            AddToFridgeBtn.Click += AddToFridgeBtn_Click;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(1183, 106);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(251, 43);
            NameTxt.TabIndex = 6;
            // 
            // TypeTxt
            // 
            TypeTxt.Location = new Point(1183, 179);
            TypeTxt.Name = "TypeTxt";
            TypeTxt.Size = new Size(251, 43);
            TypeTxt.TabIndex = 7;
            // 
            // WeightNum
            // 
            WeightNum.DecimalPlaces = 2;
            WeightNum.Location = new Point(1183, 254);
            WeightNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            WeightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WeightNum.Name = "WeightNum";
            WeightNum.Size = new Size(252, 43);
            WeightNum.TabIndex = 8;
            WeightNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.DecimalPlaces = 2;
            KcalPer100gNum.Location = new Point(1183, 327);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(252, 43);
            KcalPer100gNum.TabIndex = 9;
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(1183, 404);
            PricePer100gNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(252, 43);
            PricePer100gNum.TabIndex = 10;
            // 
            // IngredientsGrid
            // 
            IngredientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsGrid.Location = new Point(12, 138);
            IngredientsGrid.Name = "IngredientsGrid";
            IngredientsGrid.RowHeadersWidth = 51;
            IngredientsGrid.Size = new Size(928, 454);
            IngredientsGrid.TabIndex = 11;
            IngredientsGrid.CellClick += IngredientsGrid_CellClick;
            // 
            // SearchTxt
            // 
            SearchTxt.Location = new Point(12, 27);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "Type ingredient name...";
            SearchTxt.Size = new Size(929, 43);
            SearchTxt.TabIndex = 12;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(950, 547);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(485, 47);
            ClearAllFieldsBtn.TabIndex = 14;
            ClearAllFieldsBtn.Text = "Clear Fields / Cancel Edit";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // EditIngredientBtn
            // 
            EditIngredientBtn.Location = new Point(950, 479);
            EditIngredientBtn.Name = "EditIngredientBtn";
            EditIngredientBtn.Size = new Size(485, 51);
            EditIngredientBtn.TabIndex = 15;
            EditIngredientBtn.Text = "Edit Ingredient";
            EditIngredientBtn.UseVisualStyleBackColor = true;
            EditIngredientBtn.Click += EditIngredientBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(64, 86);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 16;
            label6.Text = "Sort by name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(435, 86);
            label7.Margin = new Padding(7, 0, 7, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 17;
            label7.Text = "Sort by Kcal";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(561, 86);
            label8.Margin = new Padding(7, 0, 7, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 23);
            label8.TabIndex = 18;
            label8.Text = "Sort by price";
            // 
            // SortByNameAscBtn
            // 
            SortByNameAscBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortByNameAscBtn.Location = new Point(64, 106);
            SortByNameAscBtn.Name = "SortByNameAscBtn";
            SortByNameAscBtn.Size = new Size(47, 29);
            SortByNameAscBtn.TabIndex = 19;
            SortByNameAscBtn.Text = "Asc";
            SortByNameAscBtn.UseVisualStyleBackColor = true;
            // 
            // SortByNameDescBtn
            // 
            SortByNameDescBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortByNameDescBtn.Location = new Point(128, 106);
            SortByNameDescBtn.Name = "SortByNameDescBtn";
            SortByNameDescBtn.Size = new Size(48, 29);
            SortByNameDescBtn.TabIndex = 20;
            SortByNameDescBtn.Text = "Desc";
            SortByNameDescBtn.UseVisualStyleBackColor = true;
            // 
            // SortByKcalAscBtn
            // 
            SortByKcalAscBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortByKcalAscBtn.Location = new Point(435, 106);
            SortByKcalAscBtn.Name = "SortByKcalAscBtn";
            SortByKcalAscBtn.Size = new Size(47, 29);
            SortByKcalAscBtn.TabIndex = 21;
            SortByKcalAscBtn.Text = "Asc";
            SortByKcalAscBtn.UseVisualStyleBackColor = true;
            // 
            // SortByKcalDescBtn
            // 
            SortByKcalDescBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortByKcalDescBtn.Location = new Point(487, 106);
            SortByKcalDescBtn.Name = "SortByKcalDescBtn";
            SortByKcalDescBtn.Size = new Size(48, 29);
            SortByKcalDescBtn.TabIndex = 22;
            SortByKcalDescBtn.Text = "Desc";
            SortByKcalDescBtn.UseVisualStyleBackColor = true;
            // 
            // SortByPriceDescBtn
            // 
            SortByPriceDescBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortByPriceDescBtn.Location = new Point(613, 106);
            SortByPriceDescBtn.Name = "SortByPriceDescBtn";
            SortByPriceDescBtn.Size = new Size(48, 29);
            SortByPriceDescBtn.TabIndex = 24;
            SortByPriceDescBtn.Text = "Desc";
            SortByPriceDescBtn.UseVisualStyleBackColor = true;
            // 
            // SortByPriceAscBtn
            // 
            SortByPriceAscBtn.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortByPriceAscBtn.Location = new Point(561, 106);
            SortByPriceAscBtn.Name = "SortByPriceAscBtn";
            SortByPriceAscBtn.Size = new Size(47, 29);
            SortByPriceAscBtn.TabIndex = 23;
            SortByPriceAscBtn.Text = "Asc";
            SortByPriceAscBtn.UseVisualStyleBackColor = true;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 605);
            Controls.Add(SortByPriceDescBtn);
            Controls.Add(SortByPriceAscBtn);
            Controls.Add(SortByKcalDescBtn);
            Controls.Add(SortByKcalAscBtn);
            Controls.Add(SortByNameDescBtn);
            Controls.Add(SortByNameAscBtn);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(EditIngredientBtn);
            Controls.Add(ClearAllFieldsBtn);
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
            Margin = new Padding(7, 6, 7, 6);
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
        private Button ClearAllFieldsBtn;
        private Button EditIngredientBtn;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button SortByNameAscBtn;
        private Button SortByNameDescBtn;
        private Button SortByKcalAscBtn;
        private Button SortByKcalDescBtn;
        private Button SortByPriceDescBtn;
        private Button SortByPriceAscBtn;
    }
}
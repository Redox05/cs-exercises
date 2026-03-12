namespace CookBook.UI
{
    partial class RecipesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTxt = new TextBox();
            RecipeTypesCbx = new ComboBox();
            AddRecipeTypeBtn = new Button();
            DescriptionTxt = new RichTextBox();
            RecipePictureBox = new PictureBox();
            AddRecipeBtn = new Button();
            RecipeIngredientsBtn = new Button();
            ClearAllFieldsBtn = new Button();
            RecipeFilterCbx = new ComboBox();
            RecipesGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1341, 89);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 38);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(629, 25);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(629, 56);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 2;
            label3.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(629, 99);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(629, 225);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Image:";
            // 
            // NameTxt
            // 
            NameTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameTxt.Location = new Point(765, 19);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(254, 31);
            NameTxt.TabIndex = 5;
            // 
            // RecipeTypesCbx
            // 
            RecipeTypesCbx.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecipeTypesCbx.FormattingEnabled = true;
            RecipeTypesCbx.Location = new Point(765, 56);
            RecipeTypesCbx.Name = "RecipeTypesCbx";
            RecipeTypesCbx.Size = new Size(151, 33);
            RecipeTypesCbx.TabIndex = 6;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddRecipeTypeBtn.Location = new Point(922, 56);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(97, 33);
            AddRecipeTypeBtn.TabIndex = 7;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionTxt.Location = new Point(765, 99);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(254, 120);
            DescriptionTxt.TabIndex = 8;
            DescriptionTxt.Text = "";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(765, 225);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(254, 141);
            RecipePictureBox.TabIndex = 9;
            RecipePictureBox.TabStop = false;
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddRecipeBtn.Location = new Point(765, 372);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(254, 37);
            AddRecipeBtn.TabIndex = 10;
            AddRecipeBtn.Text = "Add recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            // 
            // RecipeIngredientsBtn
            // 
            RecipeIngredientsBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecipeIngredientsBtn.Location = new Point(765, 415);
            RecipeIngredientsBtn.Name = "RecipeIngredientsBtn";
            RecipeIngredientsBtn.Size = new Size(254, 37);
            RecipeIngredientsBtn.TabIndex = 11;
            RecipeIngredientsBtn.Text = "Recipe Ingredients";
            RecipeIngredientsBtn.UseVisualStyleBackColor = true;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearAllFieldsBtn.Location = new Point(765, 458);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(254, 37);
            ClearAllFieldsBtn.TabIndex = 12;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            // 
            // RecipeFilterCbx
            // 
            RecipeFilterCbx.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecipeFilterCbx.FormattingEnabled = true;
            RecipeFilterCbx.Location = new Point(12, 25);
            RecipeFilterCbx.Name = "RecipeFilterCbx";
            RecipeFilterCbx.Size = new Size(611, 33);
            RecipeFilterCbx.TabIndex = 13;
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(12, 80);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.RowHeadersWidth = 51;
            RecipesGrid.Size = new Size(611, 415);
            RecipesGrid.TabIndex = 14;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 510);
            Controls.Add(RecipesGrid);
            Controls.Add(RecipeFilterCbx);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(RecipeIngredientsBtn);
            Controls.Add(AddRecipeBtn);
            Controls.Add(RecipePictureBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipeTypesCbx);
            Controls.Add(NameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTxt;
        private ComboBox RecipeTypesCbx;
        private Button AddRecipeTypeBtn;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePictureBox;
        private Button AddRecipeBtn;
        private Button RecipeIngredientsBtn;
        private Button ClearAllFieldsBtn;
        private ComboBox RecipeFilterCbx;
        private DataGridView RecipesGrid;
    }
}
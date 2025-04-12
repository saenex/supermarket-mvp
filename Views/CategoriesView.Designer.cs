namespace Supermarket_mvp.Views
{
    partial class CategoriesView
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
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabCategoriesList = new TabPage();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCategories = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategoriesDetail = new TabPage();
            Label3 = new Label();
            Label4 = new Label();
            TxtCategoriesId = new TextBox();
            TxtCategoriesName = new TextBox();
            TxtCategoriesObservation = new TextBox();
            label5 = new Label();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCategoriesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).BeginInit();
            tabPageCategoriesDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(581, 51);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 62);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(391, 51);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(213, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carne;
            pictureBox1.Location = new Point(25, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(391, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 50);
            label1.TabIndex = 0;
            label1.Text = "Categories";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCategoriesList);
            tabControl1.Controls.Add(tabPageCategoriesDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(941, 444);
            tabControl1.TabIndex = 1;
            // 
            // tabCategoriesList
            // 
            tabCategoriesList.Controls.Add(BtnDelete);
            tabCategoriesList.Controls.Add(BtnClose);
            tabCategoriesList.Controls.Add(BtnEdit);
            tabCategoriesList.Controls.Add(BtnNew);
            tabCategoriesList.Controls.Add(DgCategories);
            tabCategoriesList.Controls.Add(BtnSearch);
            tabCategoriesList.Controls.Add(TxtSearch);
            tabCategoriesList.Controls.Add(label2);
            tabCategoriesList.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabCategoriesList.Location = new Point(4, 29);
            tabCategoriesList.Name = "tabCategoriesList";
            tabCategoriesList.Padding = new Padding(3);
            tabCategoriesList.Size = new Size(933, 411);
            tabCategoriesList.TabIndex = 0;
            tabCategoriesList.Text = "Categories List";
            tabCategoriesList.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.BackgroundImage = Properties.Resources.borrar;
            BtnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            BtnDelete.Location = new Point(745, 102);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(117, 70);
            BtnDelete.TabIndex = 7;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.BackgroundImage = Properties.Resources.tienda;
            BtnClose.BackgroundImageLayout = ImageLayout.Zoom;
            BtnClose.Location = new Point(745, 260);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(117, 70);
            BtnClose.TabIndex = 6;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.BackgroundImage = Properties.Resources.firmar;
            BtnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            BtnEdit.Location = new Point(29, 260);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(117, 70);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.BackgroundImage = Properties.Resources.agregar;
            BtnNew.BackgroundImageLayout = ImageLayout.Zoom;
            BtnNew.Location = new Point(29, 102);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(117, 70);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCategories
            // 
            DgCategories.AllowUserToAddRows = false;
            DgCategories.AllowUserToDeleteRows = false;
            DgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategories.Location = new Point(209, 66);
            DgCategories.Name = "DgCategories";
            DgCategories.ReadOnly = true;
            DgCategories.RowHeadersWidth = 51;
            DgCategories.Size = new Size(493, 342);
            DgCategories.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.BackgroundImage = Properties.Resources.lupa;
            BtnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSearch.Location = new Point(721, 9);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(82, 69);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(209, 29);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(493, 31);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 3);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 0;
            label2.Text = "Search Categories";
            label2.Click += label2_Click;
            // 
            // tabPageCategoriesDetail
            // 
            tabPageCategoriesDetail.Controls.Add(BtnCancel);
            tabPageCategoriesDetail.Controls.Add(BtnSave);
            tabPageCategoriesDetail.Controls.Add(label5);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesObservation);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesName);
            tabPageCategoriesDetail.Controls.Add(TxtCategoriesId);
            tabPageCategoriesDetail.Controls.Add(Label4);
            tabPageCategoriesDetail.Controls.Add(Label3);
            tabPageCategoriesDetail.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPageCategoriesDetail.Location = new Point(4, 29);
            tabPageCategoriesDetail.Name = "tabPageCategoriesDetail";
            tabPageCategoriesDetail.Padding = new Padding(3);
            tabPageCategoriesDetail.Size = new Size(933, 411);
            tabPageCategoriesDetail.TabIndex = 1;
            tabPageCategoriesDetail.Text = "Categories Detail";
            tabPageCategoriesDetail.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            Label3.Location = new Point(131, 25);
            Label3.Name = "Label3";
            Label3.Size = new Size(114, 25);
            Label3.TabIndex = 0;
            Label3.Text = "Categories Id";
            Label3.Click += label3_Click;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            Label4.Location = new Point(651, 27);
            Label4.Name = "Label4";
            Label4.Size = new Size(143, 25);
            Label4.TabIndex = 1;
            Label4.Text = "Categories Name";
            // 
            // TxtCategoriesId
            // 
            TxtCategoriesId.Location = new Point(47, 53);
            TxtCategoriesId.Multiline = true;
            TxtCategoriesId.Name = "TxtCategoriesId";
            TxtCategoriesId.Size = new Size(287, 34);
            TxtCategoriesId.TabIndex = 2;
            // 
            // TxtCategoriesName
            // 
            TxtCategoriesName.Location = new Point(554, 53);
            TxtCategoriesName.Multiline = true;
            TxtCategoriesName.Name = "TxtCategoriesName";
            TxtCategoriesName.Size = new Size(344, 34);
            TxtCategoriesName.TabIndex = 3;
            // 
            // TxtCategoriesObservation
            // 
            TxtCategoriesObservation.Location = new Point(47, 157);
            TxtCategoriesObservation.Multiline = true;
            TxtCategoriesObservation.Name = "TxtCategoriesObservation";
            TxtCategoriesObservation.PlaceholderText = "Categories Observation";
            TxtCategoriesObservation.Size = new Size(465, 246);
            TxtCategoriesObservation.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            label5.Location = new Point(47, 118);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 5;
            label5.Text = "Categories Observtion";
            // 
            // BtnSave
            // 
            BtnSave.BackgroundImage = Properties.Resources.verificar;
            BtnSave.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSave.Location = new Point(683, 157);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(133, 88);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackgroundImage = Properties.Resources.cancelacion;
            BtnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCancel.Location = new Point(683, 274);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(133, 94);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // CategoriesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 569);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategoriesView";
            Text = "CategoriesView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCategoriesList.ResumeLayout(false);
            tabCategoriesList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategories).EndInit();
            tabPageCategoriesDetail.ResumeLayout(false);
            tabPageCategoriesDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private TabControl tabControl1;
        private TabPage tabCategoriesList;
        private TabPage tabPageCategoriesDetail;
        private Label label2;
        private TextBox TxtSearch;
        private DataGridView DgCategories;
        private Button BtnSearch;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnNew;
        private Label Label3;
        private Label Label4;
        private TextBox TxtCategoriesName;
        private TextBox TxtCategoriesId;
        private Label label5;
        private TextBox TxtCategoriesObservation;
        private Button BtnCancel;
        private Button BtnSave;
    }
}
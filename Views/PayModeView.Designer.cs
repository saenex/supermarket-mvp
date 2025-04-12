namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            TxtPayModeName = new TextBox();
            label4 = new Label();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(842, 125);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 43);
            label1.Name = "label1";
            label1.Size = new Size(177, 40);
            label1.TabIndex = 0;
            label1.Text = "PAY MODE";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(842, 394);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 29);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(834, 361);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.BackColor = Color.FromArgb(224, 224, 224);
            BtnClose.ForeColor = SystemColors.ButtonShadow;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(597, 286);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(208, 62);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.BackColor = Color.FromArgb(224, 224, 224);
            BtnDelete.ForeColor = SystemColors.ButtonShadow;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(597, 218);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(208, 62);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.BackColor = Color.FromArgb(224, 224, 224);
            BtnEdit.ForeColor = SystemColors.ButtonShadow;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(597, 149);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(208, 62);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackColor = Color.FromArgb(224, 224, 224);
            BtnNew.ForeColor = SystemColors.ButtonShadow;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(597, 81);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(208, 62);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(13, 81);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowHeadersWidth = 51;
            DgPayMode.Size = new Size(578, 263);
            DgPayMode.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.BackColor = Color.FromArgb(224, 224, 224);
            BtnSearch.Font = new Font("Segoe UI", 11F);
            BtnSearch.ForeColor = SystemColors.ActiveBorder;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(541, 9);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 57);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(5, 38);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(530, 27);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 8);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 29);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.RightToLeft = RightToLeft.Yes;
            tabPagePayModeDetail.Size = new Size(834, 361);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(224, 224, 224);
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(169, 301);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(114, 43);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.FromArgb(224, 224, 224);
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(26, 301);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(114, 43);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 194);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 5;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtPayModeObservation.Location = new Point(30, 217);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation.";
            TxtPayModeObservation.RightToLeft = RightToLeft.No;
            TxtPayModeObservation.Size = new Size(306, 78);
            TxtPayModeObservation.TabIndex = 4;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.BorderStyle = BorderStyle.FixedSingle;
            TxtPayModeName.Location = new Point(28, 134);
            TxtPayModeName.Multiline = true;
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.RightToLeft = RightToLeft.No;
            TxtPayModeName.Size = new Size(295, 27);
            TxtPayModeName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 111);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            label4.Click += label4_Click;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.BorderStyle = BorderStyle.FixedSingle;
            TxtPayModeId.Location = new Point(28, 62);
            TxtPayModeId.Multiline = true;
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.ReadOnly = true;
            TxtPayModeId.RightToLeft = RightToLeft.No;
            TxtPayModeId.Size = new Size(219, 27);
            TxtPayModeId.TabIndex = 1;
            TxtPayModeId.Text = "0";
            TxtPayModeId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 31);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 0;
            label3.Text = "Play Mode Id";
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 519);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgPayMode;
        private Label label3;
        private Label label4;
        private TextBox TxtPayModeId;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
    }
}
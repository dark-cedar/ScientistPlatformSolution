namespace ScientistPlatform
{
    partial class MainForm
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
            labelSearchCriterion = new Label();
            comboSearchCriterion = new ComboBox();
            labelSearchValue = new Label();
            textSearchValue = new TextBox();
            buttonFindArticles = new Button();
            dataGridArticles = new DataGridView();
            labelPublishers = new Label();
            listPublishers = new ListBox();
            labelIssn = new Label();
            textIssnForPublisher = new TextBox();
            buttonSendToPublisher = new Button();
            labelDataFormat = new Label();
            comboDataFormat = new ComboBox();
            buttonOpenCitationWindow = new Button();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridArticles).BeginInit();
            SuspendLayout();
            // 
            // labelSearchCriterion
            // 
            labelSearchCriterion.AutoSize = true;
            labelSearchCriterion.Location = new Point(12, 16);
            labelSearchCriterion.Name = "labelSearchCriterion";
            labelSearchCriterion.Size = new Size(115, 20);
            labelSearchCriterion.TabIndex = 0;
            labelSearchCriterion.Text = "Search criterion:";
            // 
            // comboSearchCriterion
            // 
            comboSearchCriterion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSearchCriterion.FormattingEnabled = true;
            comboSearchCriterion.Location = new Point(133, 11);
            comboSearchCriterion.Name = "comboSearchCriterion";
            comboSearchCriterion.Size = new Size(168, 28);
            comboSearchCriterion.TabIndex = 1;
            comboSearchCriterion.SelectedIndexChanged += comboSearchCriterion_SelectedIndexChanged;
            // 
            // labelSearchValue
            // 
            labelSearchValue.AutoSize = true;
            labelSearchValue.Location = new Point(340, 16);
            labelSearchValue.Name = "labelSearchValue";
            labelSearchValue.Size = new Size(95, 20);
            labelSearchValue.TabIndex = 2;
            labelSearchValue.Text = "Search value:";
            // 
            // textSearchValue
            // 
            textSearchValue.Location = new Point(441, 13);
            textSearchValue.Name = "textSearchValue";
            textSearchValue.Size = new Size(376, 27);
            textSearchValue.TabIndex = 3;
            textSearchValue.TextChanged += textSearchValue_TextChanged;
            // 
            // buttonFindArticles
            // 
            buttonFindArticles.Enabled = false;
            buttonFindArticles.Location = new Point(832, 13);
            buttonFindArticles.Name = "buttonFindArticles";
            buttonFindArticles.Size = new Size(138, 29);
            buttonFindArticles.TabIndex = 4;
            buttonFindArticles.Text = "Find articles";
            buttonFindArticles.UseVisualStyleBackColor = true;
            buttonFindArticles.Click += buttonFindArticles_Click;
            // 
            // dataGridArticles
            // 
            dataGridArticles.AllowUserToAddRows = false;
            dataGridArticles.AllowUserToDeleteRows = false;
            dataGridArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridArticles.Location = new Point(12, 72);
            dataGridArticles.Name = "dataGridArticles";
            dataGridArticles.ReadOnly = true;
            dataGridArticles.RowHeadersWidth = 51;
            dataGridArticles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridArticles.Size = new Size(805, 492);
            dataGridArticles.TabIndex = 5;
            // 
            // labelPublishers
            // 
            labelPublishers.AutoSize = true;
            labelPublishers.Location = new Point(832, 71);
            labelPublishers.Name = "labelPublishers";
            labelPublishers.Size = new Size(78, 20);
            labelPublishers.TabIndex = 6;
            labelPublishers.Text = "Publishers:";
            // 
            // listPublishers
            // 
            listPublishers.FormattingEnabled = true;
            listPublishers.Location = new Point(832, 94);
            listPublishers.Name = "listPublishers";
            listPublishers.Size = new Size(138, 184);
            listPublishers.TabIndex = 7;
            // 
            // labelIssn
            // 
            labelIssn.AutoSize = true;
            labelIssn.Location = new Point(832, 306);
            labelIssn.Name = "labelIssn";
            labelIssn.Size = new Size(90, 20);
            labelIssn.TabIndex = 8;
            labelIssn.Text = "Article ISSN:";
            // 
            // textIssnForPublisher
            // 
            textIssnForPublisher.Location = new Point(832, 329);
            textIssnForPublisher.Name = "textIssnForPublisher";
            textIssnForPublisher.Size = new Size(138, 27);
            textIssnForPublisher.TabIndex = 9;
            // 
            // buttonSendToPublisher
            // 
            buttonSendToPublisher.Location = new Point(832, 362);
            buttonSendToPublisher.Name = "buttonSendToPublisher";
            buttonSendToPublisher.Size = new Size(138, 29);
            buttonSendToPublisher.TabIndex = 10;
            buttonSendToPublisher.Text = "Send to publisher";
            buttonSendToPublisher.UseVisualStyleBackColor = true;
            buttonSendToPublisher.Click += buttonSendToPublisher_Click;
            // 
            // labelDataFormat
            // 
            labelDataFormat.AutoSize = true;
            labelDataFormat.Location = new Point(832, 420);
            labelDataFormat.Name = "labelDataFormat";
            labelDataFormat.Size = new Size(93, 20);
            labelDataFormat.TabIndex = 11;
            labelDataFormat.Text = "Data format:";
            // 
            // comboDataFormat
            // 
            comboDataFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDataFormat.FormattingEnabled = true;
            comboDataFormat.Location = new Point(832, 443);
            comboDataFormat.Name = "comboDataFormat";
            comboDataFormat.Size = new Size(138, 28);
            comboDataFormat.TabIndex = 12;
            comboDataFormat.SelectedIndexChanged += comboDataFormat_SelectedIndexChanged;
            // 
            // buttonOpenCitationWindow
            // 
            buttonOpenCitationWindow.Location = new Point(832, 535);
            buttonOpenCitationWindow.Name = "buttonOpenCitationWindow";
            buttonOpenCitationWindow.Size = new Size(138, 29);
            buttonOpenCitationWindow.TabIndex = 13;
            buttonOpenCitationWindow.Text = "Create citation";
            buttonOpenCitationWindow.UseVisualStyleBackColor = true;
            buttonOpenCitationWindow.Click += buttonOpenCitationWindow_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 574);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(50, 20);
            labelStatus.TabIndex = 14;
            labelStatus.Text = "Ready";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(labelStatus);
            Controls.Add(buttonOpenCitationWindow);
            Controls.Add(comboDataFormat);
            Controls.Add(labelDataFormat);
            Controls.Add(buttonSendToPublisher);
            Controls.Add(textIssnForPublisher);
            Controls.Add(labelIssn);
            Controls.Add(listPublishers);
            Controls.Add(labelPublishers);
            Controls.Add(dataGridArticles);
            Controls.Add(buttonFindArticles);
            Controls.Add(textSearchValue);
            Controls.Add(labelSearchValue);
            Controls.Add(comboSearchCriterion);
            Controls.Add(labelSearchCriterion);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScientistPlatform";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridArticles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearchCriterion;
        private ComboBox comboSearchCriterion;
        private Label labelSearchValue;
        private TextBox textSearchValue;
        private Button buttonFindArticles;
        private DataGridView dataGridArticles;
        private Label labelPublishers;
        private ListBox listPublishers;
        private Label labelIssn;
        private TextBox textIssnForPublisher;
        private Button buttonSendToPublisher;
        private Label labelDataFormat;
        private ComboBox comboDataFormat;
        private Button buttonOpenCitationWindow;
        private Label labelStatus;
    }
}

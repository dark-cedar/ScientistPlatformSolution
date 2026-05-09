namespace ScientistPlatform
{
    partial class CitationForm
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
            labelArticle = new Label();
            comboArticles = new ComboBox();
            labelPublisher = new Label();
            comboPublishers = new ComboBox();
            buttonCreateCitation = new Button();
            textCitation = new TextBox();
            buttonSaveCitation = new Button();
            SuspendLayout();
            // 
            // labelArticle
            // 
            labelArticle.AutoSize = true;
            labelArticle.Location = new Point(12, 12);
            labelArticle.Name = "labelArticle";
            labelArticle.Size = new Size(55, 20);
            labelArticle.TabIndex = 0;
            labelArticle.Text = "Article:";
            // 
            // comboArticles
            // 
            comboArticles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboArticles.FormattingEnabled = true;
            comboArticles.Location = new Point(104, 9);
            comboArticles.Name = "comboArticles";
            comboArticles.Size = new Size(566, 28);
            comboArticles.TabIndex = 1;
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(12, 51);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(72, 20);
            labelPublisher.TabIndex = 2;
            labelPublisher.Text = "Publisher:";
            // 
            // comboPublishers
            // 
            comboPublishers.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPublishers.FormattingEnabled = true;
            comboPublishers.Location = new Point(104, 48);
            comboPublishers.Name = "comboPublishers";
            comboPublishers.Size = new Size(566, 28);
            comboPublishers.TabIndex = 3;
            // 
            // buttonCreateCitation
            // 
            buttonCreateCitation.Location = new Point(12, 147);
            buttonCreateCitation.Name = "buttonCreateCitation";
            buttonCreateCitation.Size = new Size(658, 29);
            buttonCreateCitation.TabIndex = 4;
            buttonCreateCitation.Text = "Create citation";
            buttonCreateCitation.UseVisualStyleBackColor = true;
            buttonCreateCitation.Click += buttonCreateCitation_Click;
            // 
            // textCitation
            // 
            textCitation.Location = new Point(12, 182);
            textCitation.Multiline = true;
            textCitation.Name = "textCitation";
            textCitation.ReadOnly = true;
            textCitation.ScrollBars = ScrollBars.Vertical;
            textCitation.Size = new Size(658, 124);
            textCitation.TabIndex = 5;
            // 
            // buttonSaveCitation
            // 
            buttonSaveCitation.Location = new Point(12, 312);
            buttonSaveCitation.Name = "buttonSaveCitation";
            buttonSaveCitation.Size = new Size(658, 29);
            buttonSaveCitation.TabIndex = 6;
            buttonSaveCitation.Text = "Save citation";
            buttonSaveCitation.UseVisualStyleBackColor = true;
            buttonSaveCitation.Click += buttonSaveCitation_Click;
            // 
            // CitationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 353);
            Controls.Add(buttonSaveCitation);
            Controls.Add(textCitation);
            Controls.Add(buttonCreateCitation);
            Controls.Add(comboPublishers);
            Controls.Add(labelPublisher);
            Controls.Add(comboArticles);
            Controls.Add(labelArticle);
            Name = "CitationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Create citation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelArticle;
        private ComboBox comboArticles;
        private Label labelPublisher;
        private ComboBox comboPublishers;
        private Button buttonCreateCitation;
        private TextBox textCitation;
        private Button buttonSaveCitation;
    }
}
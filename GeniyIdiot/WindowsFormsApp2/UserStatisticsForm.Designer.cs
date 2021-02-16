namespace GeniyIdiotWinFormApp
{
    partial class UserStatisticsForm
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
            this.statisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeWindowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsDataGridView
            // 
            this.statisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.countRightAnswersColumn,
            this.diagnoseColumn});
            this.statisticsDataGridView.Location = new System.Drawing.Point(25, 12);
            this.statisticsDataGridView.Name = "statisticsDataGridView";
            this.statisticsDataGridView.Size = new System.Drawing.Size(351, 207);
            this.statisticsDataGridView.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Имя пользователя";
            this.nameColumn.Name = "nameColumn";
            // 
            // countRightAnswersColumn
            // 
            this.countRightAnswersColumn.HeaderText = "Кол-во правильных ответов";
            this.countRightAnswersColumn.Name = "countRightAnswersColumn";
            // 
            // diagnoseColumn
            // 
            this.diagnoseColumn.HeaderText = "Диагноз";
            this.diagnoseColumn.Name = "diagnoseColumn";
            // 
            // closeWindowButton
            // 
            this.closeWindowButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeWindowButton.Location = new System.Drawing.Point(398, 154);
            this.closeWindowButton.Name = "closeWindowButton";
            this.closeWindowButton.Size = new System.Drawing.Size(75, 65);
            this.closeWindowButton.TabIndex = 1;
            this.closeWindowButton.Text = "Закрыть окно";
            this.closeWindowButton.UseVisualStyleBackColor = true;
            this.closeWindowButton.Click += new System.EventHandler(this.closeWindowButton_Click);
            // 
            // UserStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeWindowButton;
            this.ClientSize = new System.Drawing.Size(485, 253);
            this.Controls.Add(this.closeWindowButton);
            this.Controls.Add(this.statisticsDataGridView);
            this.Name = "UserStatisticsForm";
            this.Text = "UserStatisticsForm";
            this.Load += new System.EventHandler(this.UserStatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnoseColumn;
        private System.Windows.Forms.Button closeWindowButton;
    }
}
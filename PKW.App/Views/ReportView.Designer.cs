namespace PKW.App.Views
{
    partial class ReportView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.chtResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dgvResults = new System.Windows.Forms.DataGridView();
			this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cbConstituencyFilter = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblIssuedBallouts = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblInvalidVotes = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lblNoResults = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chtResults)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// chtResults
			// 
			chartArea1.Name = "ChartArea1";
			this.chtResults.ChartAreas.Add(chartArea1);
			this.chtResults.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chtResults.Legends.Add(legend1);
			this.chtResults.Location = new System.Drawing.Point(3, 331);
			this.chtResults.Name = "chtResults";
			series1.ChartArea = "ChartArea1";
			series1.IsVisibleInLegend = false;
			series1.Legend = "Legend1";
			series1.Name = "FullResults";
			series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chtResults.Series.Add(series1);
			this.chtResults.Size = new System.Drawing.Size(267, 126);
			this.chtResults.TabIndex = 0;
			this.chtResults.Text = "chart1";
			// 
			// dgvResults
			// 
			this.dgvResults.AllowUserToAddRows = false;
			this.dgvResults.AllowUserToDeleteRows = false;
			this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateName,
            this.Amount,
            this.Percentage});
			this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvResults.Location = new System.Drawing.Point(3, 52);
			this.dgvResults.Name = "dgvResults";
			this.dgvResults.ReadOnly = true;
			this.dgvResults.Size = new System.Drawing.Size(267, 214);
			this.dgvResults.TabIndex = 1;
			// 
			// CandidateName
			// 
			this.CandidateName.DataPropertyName = "CandidateName";
			this.CandidateName.HeaderText = "Candidate name";
			this.CandidateName.Name = "CandidateName";
			this.CandidateName.ReadOnly = true;
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "Amount";
			this.Amount.HeaderText = "Number of votes";
			this.Amount.Name = "Amount";
			this.Amount.ReadOnly = true;
			// 
			// Percentage
			// 
			this.Percentage.DataPropertyName = "Percentage";
			dataGridViewCellStyle1.Format = "P2";
			this.Percentage.DefaultCellStyle = dataGridViewCellStyle1;
			this.Percentage.HeaderText = "Percentage of votes";
			this.Percentage.Name = "Percentage";
			this.Percentage.ReadOnly = true;
			// 
			// cbConstituencyFilter
			// 
			this.cbConstituencyFilter.DisplayMember = "Name";
			this.cbConstituencyFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbConstituencyFilter.FormattingEnabled = true;
			this.cbConstituencyFilter.Location = new System.Drawing.Point(103, 3);
			this.cbConstituencyFilter.MinimumSize = new System.Drawing.Size(4, 0);
			this.cbConstituencyFilter.Name = "cbConstituencyFilter";
			this.cbConstituencyFilter.Size = new System.Drawing.Size(161, 21);
			this.cbConstituencyFilter.TabIndex = 2;
			this.cbConstituencyFilter.ValueMember = "Id";
			this.cbConstituencyFilter.SelectedIndexChanged += new System.EventHandler(this.cbConstituencyFilter_SelectedIndexChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.lblIssuedBallouts, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblInvalidVotes, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 272);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 53);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// lblIssuedBallouts
			// 
			this.lblIssuedBallouts.AutoSize = true;
			this.lblIssuedBallouts.Location = new System.Drawing.Point(95, 26);
			this.lblIssuedBallouts.Name = "lblIssuedBallouts";
			this.lblIssuedBallouts.Size = new System.Drawing.Size(16, 13);
			this.lblIssuedBallouts.TabIndex = 3;
			this.lblIssuedBallouts.Text = "---";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Głosy nieważne:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Wydane karty:";
			// 
			// lblInvalidVotes
			// 
			this.lblInvalidVotes.AutoSize = true;
			this.lblInvalidVotes.Location = new System.Drawing.Point(95, 0);
			this.lblInvalidVotes.Name = "lblInvalidVotes";
			this.lblInvalidVotes.Size = new System.Drawing.Size(16, 13);
			this.lblInvalidVotes.TabIndex = 2;
			this.lblInvalidVotes.Text = "---";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.cbConstituencyFilter, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(1, 1);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 30);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 5);
			this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Okręg wyborczy:";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.chtResults, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.dgvResults, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.lblNoResults, 0, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.MinimumSize = new System.Drawing.Size(1, 1);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 5;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(273, 460);
			this.tableLayoutPanel3.TabIndex = 6;
			// 
			// lblNoResults
			// 
			this.lblNoResults.AutoSize = true;
			this.lblNoResults.Location = new System.Drawing.Point(3, 36);
			this.lblNoResults.Name = "lblNoResults";
			this.lblNoResults.Size = new System.Drawing.Size(76, 13);
			this.lblNoResults.TabIndex = 6;
			this.lblNoResults.Text = "Brak wyników.";
			this.lblNoResults.Visible = false;
			// 
			// ReportView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel3);
			this.Name = "ReportView";
			this.Size = new System.Drawing.Size(273, 460);
			((System.ComponentModel.ISupportInitialize)(this.chtResults)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chtResults;
		private System.Windows.Forms.ComboBox cbConstituencyFilter;
		private System.Windows.Forms.DataGridView dgvResults;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblIssuedBallouts;
		private System.Windows.Forms.Label lblInvalidVotes;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Percentage;
		private System.Windows.Forms.Label lblNoResults;
    }
}

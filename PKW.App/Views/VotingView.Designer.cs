namespace PKW.App.Views
{
    partial class VotingView
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
            this.dgvCandidates = new System.Windows.Forms.DataGridView();
            this.CandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfVotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbInvalidVotes = new System.Windows.Forms.TextBox();
            this.tbIssuedBallots = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendVotes = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCandidates
            // 
            this.dgvCandidates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidateName,
            this.NumberOfVotes});
            this.dgvCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCandidates.Location = new System.Drawing.Point(0, 0);
            this.dgvCandidates.Name = "dgvCandidates";
            this.dgvCandidates.Size = new System.Drawing.Size(720, 469);
            this.dgvCandidates.TabIndex = 0;
            // 
            // CandidateName
            // 
            this.CandidateName.DataPropertyName = "Name";
            this.CandidateName.HeaderText = "Kandydat";
            this.CandidateName.Name = "CandidateName";
            this.CandidateName.ReadOnly = true;
            this.CandidateName.Width = 150;
            // 
            // NumberOfVotes
            // 
            this.NumberOfVotes.DataPropertyName = "NumberOfVotes";
            this.NumberOfVotes.HeaderText = "Liczba głosów";
            this.NumberOfVotes.Name = "NumberOfVotes";
            // 
            // tbInvalidVotes
            // 
            this.tbInvalidVotes.BackColor = System.Drawing.SystemColors.Window;
            this.tbInvalidVotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInvalidVotes.Location = new System.Drawing.Point(103, 3);
            this.tbInvalidVotes.Name = "tbInvalidVotes";
            this.tbInvalidVotes.Size = new System.Drawing.Size(111, 20);
            this.tbInvalidVotes.TabIndex = 1;
            this.tbInvalidVotes.Text = "0";
            this.tbInvalidVotes.TextChanged += new System.EventHandler(this.tbInvalidVotes_TextChanged);
            this.tbInvalidVotes.Validating += new System.ComponentModel.CancelEventHandler(this.tbInvalidVotes_Validating);
            // 
            // tbIssuedBallots
            // 
            this.tbIssuedBallots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIssuedBallots.Location = new System.Drawing.Point(103, 30);
            this.tbIssuedBallots.Name = "tbIssuedBallots";
            this.tbIssuedBallots.Size = new System.Drawing.Size(111, 20);
            this.tbIssuedBallots.TabIndex = 2;
            this.tbIssuedBallots.Text = "0";
            this.tbIssuedBallots.TextChanged += new System.EventHandler(this.tbIssuedBallots_TextChanged);
            this.tbIssuedBallots.Validating += new System.ComponentModel.CancelEventHandler(this.tbIssuedBallots_Validating);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Glosy nieważne";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wydane karty";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSendVotes
            // 
            this.btnSendVotes.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendVotes.Location = new System.Drawing.Point(642, 57);
            this.btnSendVotes.Name = "btnSendVotes";
            this.btnSendVotes.Size = new System.Drawing.Size(75, 30);
            this.btnSendVotes.TabIndex = 5;
            this.btnSendVotes.Text = "Wyslij glosy";
            this.btnSendVotes.UseVisualStyleBackColor = true;
            this.btnSendVotes.Click += new System.EventHandler(this.btnSendVotes_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbIssuedBallots, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbInvalidVotes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSendVotes, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 379);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 90);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // VotingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvCandidates);
            this.Name = "VotingView";
            this.Size = new System.Drawing.Size(720, 469);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidates)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbInvalidVotes;
        private System.Windows.Forms.TextBox tbIssuedBallots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendVotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.DataGridView dgvCandidates;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfVotes;
    }
}

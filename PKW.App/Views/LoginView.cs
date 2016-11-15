using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PKW.Contracts;

namespace PKW.App.Views
{
    public partial class LoginForm : Form, ILoginView
    {
        public event EventHandler CancelClicked;

        public event EventHandler<int> LoginClicked;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (LoginClicked != null) LoginClicked(this, (int) cbConstituencies.SelectedValue);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelClicked != null) CancelClicked(this, EventArgs.Empty);
        }

        public void LoadConstituencies(IEnumerable<Constituency> constituencies)
        {
            cbConstituencies.ValueMember = "Id";
            cbConstituencies.DisplayMember = "Name";
            cbConstituencies.DataSource = constituencies;
        }

        public void Exit()
        {
            Close();
        }

        public void ShowForm()
        {
            ShowDialog();
        }
    }
}
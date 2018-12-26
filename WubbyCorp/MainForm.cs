using System;
using System.Windows.Forms;

namespace WubbyCorp {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            Icon = Properties.Resources.WubbyCorp;
        }

        private void MainForm_Load(object sender, EventArgs e) {
            IntroForm introForm = new IntroForm();
            introForm.Show();
        }

    }

}

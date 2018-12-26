using System;
using System.Windows.Forms;

namespace WubbyCorp {

    public partial class IntroForm : Form {

        public IntroForm() {
            InitializeComponent();
            Icon = System.Drawing.Icon.FromHandle(Properties.Resources.wubbyLEFT.GetHicon());
        }

        private void IntroForm_Load(object sender, EventArgs e) {

        }

    }

}

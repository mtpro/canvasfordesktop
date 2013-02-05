using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace Canvas
{
    public partial class AccessTokenEntryWindow : Form
    {
        public string SecretKey;

        public AccessTokenEntryWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AccessToken_OK_Click(object sender, EventArgs e)
        {
            SecretKey = AccessTokenTextBox.Text;
            this.Close();
        }
    }
}

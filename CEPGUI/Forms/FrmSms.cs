using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEPGUI.Forms
{
    public partial class FrmSms : Form
    {
        public FrmSms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                Stream s = client.OpenRead("");
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
                MessageBox.Show(result, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

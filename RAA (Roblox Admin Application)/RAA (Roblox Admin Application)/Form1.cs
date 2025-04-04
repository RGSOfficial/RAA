using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RAA__Roblox_Admin_Application_
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // In Form1.cs constructor or Load event
            this.MaximizeBox = false;         // Disables the maximize button
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // Prevents resizing

            Bitmap bmp = new Bitmap(Logo.Image);
            bmp.MakeTransparent(Color.White);
            Logo.Image = bmp;
        }

        private void USRPrompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PSWPrompt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            string username = USRPrompt.Text;  // Get username from input
            string password = PSWPrompt.Text;  // Get password from input

            // username → password mapping
            Dictionary<string, string> validLogins = new Dictionary<string, string>()
    {
        { "admin", "password123" },
        { "rgs", "sub2rgs" },
        { "bob", "bob123" }
    };

            // username → role mapping
            Dictionary<string, string> roles = new Dictionary<string, string>()
    {
        { "admin", "Administrator" },
        { "rgs", "Owner" },
        { "bob", "Support Agent" }
    };

            // Login validation
            if (validLogins.ContainsKey(username) && validLogins[username] == password)
            {
                // Fetch the user's role (if they exist in the dictionary)
                string role = roles.ContainsKey(username) ? roles[username] : "Unknown";

                // Create and show Form2, passing the username and role
                Form2 form2 = new Form2(username, role);
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}

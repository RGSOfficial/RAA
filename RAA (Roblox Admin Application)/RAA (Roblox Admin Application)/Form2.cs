using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;



namespace RAA__Roblox_Admin_Application_
{
    public partial class Form2: Form
    {
        private string savedLogContent = "";
        private string logFilePath = "saved_log.txt";
        public Form2(string username, string role)
        {
            InitializeComponent();
            Reason.CheckOnClick = true;
            Reason.ItemCheck += new ItemCheckEventHandler(Reason_ItemCheck);
            userinfo.Location = new Point(10, 10);  // This gives the label space to grow
            userinfo.Text = $"Logged in as: {username} ({role})";
            savedLogContent = richTextLogs.Text;
        }


        private void UsernameInputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Action_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reason_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void CustomReason_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reason_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the index of the item being checked or unchecked
            int index = e.Index;

            // If the item is being checked, enable editing; if unchecked, disable editing
            if (e.NewValue == CheckState.Checked)
            {
                if (index == 6)  // Example: Enable editing for item at index 0 (first item)
                    CustomReason.ReadOnly = false;  // Allow typing/editing in the GunaTextBox
                                                    // You can add more conditions for other items if needed
            }
            else
            {
                if (index == 6)  // Example: Disable editing for item at index 0 (first item)
                    CustomReason.ReadOnly = true;   // Prevent typing/editing in the GunaTextBox
                                                    // You can add more conditions for other items if needed
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // In Form1.cs constructor or Load event
            this.MaximizeBox = false;         // Disables the maximize button
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  // Prevents resizing
            if (File.Exists(logFilePath))
            {
                richTextLogs.Text = File.ReadAllText(logFilePath);
                savedLogContent = richTextLogs.Text;
            }
            else
            {
                // If no saved log exists, use default fake logs
                savedLogContent = "==== RAA Moderation Logs ====\n"
                                + "User: SussyIsSus14238\n"
                                + "Action: Warning issued\n"
                                + "Reason: Inappropriate asset upload\n"
                                + "Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\n"
                                + "User: NoobMaster69\n"
                                + "Action: Temporary ban (3 days)\n"
                                + "Reason: Exploiting\n"
                                + "Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                richTextLogs.Text = savedLogContent;
            }


        }

        private void btnDownloadLogs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Download Logs";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FileName = "moderation_logs.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, savedLogContent);
                MessageBox.Show("Logs successfully downloaded.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            savedLogContent = richTextLogs.Text;
            File.WriteAllText(logFilePath, savedLogContent);
            MessageBox.Show("Log saved to file!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

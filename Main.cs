using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWineditor
{

    public partial class Main : Form
    {
        // !!
        // FORMS
        // !!
        Settings settings = new Settings(); // Not ready yet...
        Help helpForm = new Help();

        string current_path;

        public Main()
        {
            InitializeComponent();
        }

        // !!
        // OPEN EXISTING FILE AND INSERT CONTENTS
        // !!
        private void open_file_butt_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
                OpenFile(path);
            }
        }

        // !!
        // CREATE NEW FILE
        // !!
        private void createnewfile_Click(object sender, EventArgs e)
        {
            content_box.Text = "";
            filename_label.Text = "[New file]";
            current_path = "";
        }

        // !!
        // SAVE FILE
        // !!
        private void save_file_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(current_path))
            {
                using (StreamWriter sw = new StreamWriter(current_path))
                {
                    sw.Write(content_box.Text);
                    save_file.Enabled = false;
                }
            }
            else
            {
                // Если путь пустой, вызываем "Сохранить как".
                save_as_file_Click(sender, e);
            }
        }

        // !!
        // SAVE AS
        // !!
        private void save_as_file_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                current_path = path;

                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(content_box.Text);
                }

                filename_label.Text = Path.GetFileName(path);
                save_file.Enabled = false;
            }
        }
        public void OpenFile(string path)
        {
            // Clearing previous text.
            content_box.Text = "";
            current_path = path;

            using (StreamReader sr = new StreamReader(path))
            {
                // Reading to end and copying all text from this file to content box.
                content_box.Text = sr.ReadToEnd();
            }
            filename_label.Text = Path.GetFileName(path);
        }

        private void content_box_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(current_path))
            {
                using (StreamReader sr = new StreamReader(current_path))
                {
                    if (sr.ReadToEnd() != content_box.Text)
                    {
                        save_file.Enabled = true;
                    }
                }
            }
        }

        /// !~~~~~~~!
        /// 
        /// Settings form.
        /// It's not avaiable in early version, it's coming in next update.
        /// 
        /// !~~~~~~~!
        private void settings_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming in next update :)", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ~~
        // ... Information form opening if clicks
        // ~~
        private void info_butt_Click(object sender, EventArgs e)
        {
            if (helpForm == null || helpForm.IsDisposed)
            {
                helpForm = new Help();
            }
            helpForm.Show();
            helpForm.BringToFront();
        }
    }
}

namespace TextWineditor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.content_box = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.info_butt = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.save_as_file = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.Button();
            this.createnewfile = new System.Windows.Forms.Button();
            this.open_file_butt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.filename_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // content_box
            // 
            this.content_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.content_box.Location = new System.Drawing.Point(14, 100);
            this.content_box.Multiline = true;
            this.content_box.Name = "content_box";
            this.content_box.Size = new System.Drawing.Size(775, 375);
            this.content_box.TabIndex = 0;
            this.content_box.TextChanged += new System.EventHandler(this.content_box_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.info_butt, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.settings_button, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.save_as_file, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.save_file, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.createnewfile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.open_file_butt, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 82);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // info_butt
            // 
            this.info_butt.AutoSize = true;
            this.info_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_butt.Image = ((System.Drawing.Image)(resources.GetObject("info_butt.Image")));
            this.info_butt.Location = new System.Drawing.Point(643, 3);
            this.info_butt.Name = "info_butt";
            this.info_butt.Size = new System.Drawing.Size(123, 76);
            this.info_butt.TabIndex = 5;
            this.info_butt.UseVisualStyleBackColor = true;
            this.info_butt.Click += new System.EventHandler(this.info_butt_Click);
            // 
            // settings_button
            // 
            this.settings_button.AutoSize = true;
            this.settings_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_button.Image = ((System.Drawing.Image)(resources.GetObject("settings_button.Image")));
            this.settings_button.Location = new System.Drawing.Point(515, 3);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(122, 76);
            this.settings_button.TabIndex = 4;
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // save_as_file
            // 
            this.save_as_file.AutoSize = true;
            this.save_as_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_as_file.Image = ((System.Drawing.Image)(resources.GetObject("save_as_file.Image")));
            this.save_as_file.Location = new System.Drawing.Point(387, 3);
            this.save_as_file.Name = "save_as_file";
            this.save_as_file.Size = new System.Drawing.Size(122, 76);
            this.save_as_file.TabIndex = 3;
            this.save_as_file.UseVisualStyleBackColor = true;
            this.save_as_file.Click += new System.EventHandler(this.save_as_file_Click);
            // 
            // save_file
            // 
            this.save_file.AutoSize = true;
            this.save_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_file.Enabled = false;
            this.save_file.Image = ((System.Drawing.Image)(resources.GetObject("save_file.Image")));
            this.save_file.Location = new System.Drawing.Point(259, 3);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(122, 76);
            this.save_file.TabIndex = 2;
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.save_file_Click);
            // 
            // createnewfile
            // 
            this.createnewfile.AutoSize = true;
            this.createnewfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createnewfile.Image = ((System.Drawing.Image)(resources.GetObject("createnewfile.Image")));
            this.createnewfile.Location = new System.Drawing.Point(131, 3);
            this.createnewfile.Name = "createnewfile";
            this.createnewfile.Size = new System.Drawing.Size(122, 76);
            this.createnewfile.TabIndex = 1;
            this.createnewfile.UseVisualStyleBackColor = true;
            this.createnewfile.Click += new System.EventHandler(this.createnewfile_Click);
            // 
            // open_file_butt
            // 
            this.open_file_butt.AutoSize = true;
            this.open_file_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.open_file_butt.Image = ((System.Drawing.Image)(resources.GetObject("open_file_butt.Image")));
            this.open_file_butt.Location = new System.Drawing.Point(3, 3);
            this.open_file_butt.Name = "open_file_butt";
            this.open_file_butt.Size = new System.Drawing.Size(122, 76);
            this.open_file_butt.TabIndex = 0;
            this.open_file_butt.UseVisualStyleBackColor = true;
            this.open_file_butt.Click += new System.EventHandler(this.open_file_butt_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Location = new System.Drawing.Point(15, 484);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(11, 13);
            this.filename_label.TabIndex = 2;
            this.filename_label.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.filename_label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.content_box);
            this.Name = "Form1";
            this.Text = "TextWineditor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox content_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button open_file_butt;
        private System.Windows.Forms.Button info_butt;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button save_as_file;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.Button createnewfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label filename_label;
    }
}


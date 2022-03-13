
namespace ImageProperties
{
    partial class PropertiesForm
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
            this.dialogBrowseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.dgImages = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColorDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btOpenFolder = new System.Windows.Forms.Button();
            this.lbSelectedPath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgImages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgImages
            // 
            this.dgImages.AllowUserToAddRows = false;
            this.dgImages.AllowUserToDeleteRows = false;
            this.dgImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Size,
            this.Resolution,
            this.ColorDepth,
            this.Compression});
            this.dgImages.Location = new System.Drawing.Point(9, 10);
            this.dgImages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgImages.Name = "dgImages";
            this.dgImages.ReadOnly = true;
            this.dgImages.RowHeadersWidth = 9;
            this.dgImages.RowTemplate.Height = 24;
            this.dgImages.Size = new System.Drawing.Size(734, 533);
            this.dgImages.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.Frozen = true;
            this.FileName.HeaderText = "File name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 125;
            // 
            // Size
            // 
            this.Size.Frozen = true;
            this.Size.HeaderText = "Size (px)";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 125;
            // 
            // Resolution
            // 
            this.Resolution.Frozen = true;
            this.Resolution.HeaderText = "Resolution (dpi)";
            this.Resolution.MinimumWidth = 6;
            this.Resolution.Name = "Resolution";
            this.Resolution.ReadOnly = true;
            this.Resolution.Width = 125;
            // 
            // ColorDepth
            // 
            this.ColorDepth.Frozen = true;
            this.ColorDepth.HeaderText = "Color Depth";
            this.ColorDepth.MinimumWidth = 6;
            this.ColorDepth.Name = "ColorDepth";
            this.ColorDepth.ReadOnly = true;
            this.ColorDepth.Width = 125;
            // 
            // Compression
            // 
            this.Compression.Frozen = true;
            this.Compression.HeaderText = "Compression";
            this.Compression.MinimumWidth = 6;
            this.Compression.Name = "Compression";
            this.Compression.ReadOnly = true;
            this.Compression.Width = 125;
            // 
            // btOpenFolder
            // 
            this.btOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btOpenFolder.Location = new System.Drawing.Point(438, 548);
            this.btOpenFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btOpenFolder.Name = "btOpenFolder";
            this.btOpenFolder.Size = new System.Drawing.Size(128, 28);
            this.btOpenFolder.TabIndex = 1;
            this.btOpenFolder.Text = "Choose Folder...";
            this.btOpenFolder.UseVisualStyleBackColor = true;
            this.btOpenFolder.Click += new System.EventHandler(this.btOpenFolder_Click);
            // 
            // lbSelectedPath
            // 
            this.lbSelectedPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSelectedPath.AutoSize = true;
            this.lbSelectedPath.Location = new System.Drawing.Point(646, 556);
            this.lbSelectedPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSelectedPath.Name = "lbSelectedPath";
            this.lbSelectedPath.Size = new System.Drawing.Size(97, 13);
            this.lbSelectedPath.TabIndex = 2;
            this.lbSelectedPath.Text = "Nothing is selected";
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.lbSelectedPath);
            this.Controls.Add(this.btOpenFolder);
            this.Controls.Add(this.dgImages);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(304, 251);
            this.Name = "PropertiesForm";
            this.Text = "Properties";
            ((System.ComponentModel.ISupportInitialize)(this.dgImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dialogBrowseFolder;
        private System.Windows.Forms.DataGridView dgImages;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColorDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compression;
        private System.Windows.Forms.Button btOpenFolder;
        private System.Windows.Forms.Label lbSelectedPath;
    }
}


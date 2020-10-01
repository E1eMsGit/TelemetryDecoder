namespace TelemetryDecoder.MessageBoxes
{
    partial class FormInformationMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInfo = new MaterialSkin.Controls.MaterialLabel();
            this.btnOk = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblInfo2 = new MaterialSkin.Controls.MaterialLabel();
            this.llPath = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lblInfo.Depth = 0;
            this.lblInfo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo.Location = new System.Drawing.Point(115, 93);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.lblInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(49, 19);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Текст";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Depth = 0;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(233, 161);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.Primary = true;
            this.btnOk.Size = new System.Drawing.Size(79, 34);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.Window;
            this.pbImage.Location = new System.Drawing.Point(9, 79);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 98);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 8;
            this.pbImage.TabStop = false;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.BackColor = System.Drawing.SystemColors.Window;
            this.lblInfo2.Depth = 0;
            this.lblInfo2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInfo2.Location = new System.Drawing.Point(0, 0);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(0);
            this.lblInfo2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(49, 19);
            this.lblInfo2.TabIndex = 9;
            this.lblInfo2.Text = "Текст";
            // 
            // llPath
            // 
            this.llPath.AutoSize = true;
            this.llPath.BackColor = System.Drawing.SystemColors.Window;
            this.llPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llPath.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llPath.Location = new System.Drawing.Point(49, 0);
            this.llPath.Margin = new System.Windows.Forms.Padding(0);
            this.llPath.Name = "llPath";
            this.llPath.Size = new System.Drawing.Size(48, 18);
            this.llPath.TabIndex = 10;
            this.llPath.TabStop = true;
            this.llPath.Text = "Текст";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.lblInfo2);
            this.flowLayoutPanel1.Controls.Add(this.llPath);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(115, 121);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(113, 20);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // FormInformationMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(324, 207);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnOk);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInformationMessageBox";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заголовок";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private MaterialSkin.Controls.MaterialLabel lblInfo;
        private MaterialSkin.Controls.MaterialRaisedButton btnOk;
        private MaterialSkin.Controls.MaterialLabel lblInfo2;
        private System.Windows.Forms.LinkLabel llPath;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
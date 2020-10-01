namespace TelemetryDecoder.MessageBoxes
{
    partial class FormDialogMessageBox
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
            this.btnYes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.Depth = 0;
            this.btnYes.Location = new System.Drawing.Point(160, 164);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(79, 34);
            this.btnYes.TabIndex = 0;
            this.btnYes.Text = "Да";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNo.Depth = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(245, 164);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.Primary = true;
            this.btnNo.Size = new System.Drawing.Size(79, 34);
            this.btnNo.TabIndex = 1;
            this.btnNo.Text = "Нет";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.SystemColors.Window;
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(115, 91);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(49, 19);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Текст";
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.Window;
            this.pbPicture.Location = new System.Drawing.Point(9, 79);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(100, 98);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 4;
            this.pbPicture.TabStop = false;
            // 
            // FormDialogMessageBox
            // 
            this.AcceptButton = this.btnYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnNo;
            this.ClientSize = new System.Drawing.Size(337, 210);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialogMessageBox";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заголовок";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnYes;
        private MaterialSkin.Controls.MaterialRaisedButton btnNo;
        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private System.Windows.Forms.PictureBox pbPicture;
    }
}
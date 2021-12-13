
namespace Inlämningsupggift_final_version
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.lbxShow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(440, 12);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(135, 23);
            this.btnAddAddress.TabIndex = 0;
            this.btnAddAddress.Text = "Lägg till adress";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            // 
            // lbxShow
            // 
            this.lbxShow.FormattingEnabled = true;
            this.lbxShow.ItemHeight = 15;
            this.lbxShow.Location = new System.Drawing.Point(12, 12);
            this.lbxShow.Name = "lbxShow";
            this.lbxShow.Size = new System.Drawing.Size(97, 349);
            this.lbxShow.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxShow);
            this.Controls.Add(this.btnAddAddress);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.ListBox lbxShow;
    }
}


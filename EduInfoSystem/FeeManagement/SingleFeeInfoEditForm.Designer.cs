namespace EduInfoSystem.FeeManagement
{
    partial class SingleFeeInfoEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleFeeInfoEditForm));
            this.singleEditPanel1 = new EduInfoSystem.FeeManagement.SingleEditPanel();
            this.SuspendLayout();
            // 
            // singleEditPanel1
            // 
            this.singleEditPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleEditPanel1.Location = new System.Drawing.Point(0, 0);
            this.singleEditPanel1.Name = "singleEditPanel1";
            this.singleEditPanel1.Size = new System.Drawing.Size(535, 359);
            this.singleEditPanel1.TabIndex = 0;
            // 
            // SingleFeeInfoEditForm
            // 
            this.ClientSize = new System.Drawing.Size(535, 359);
            this.Controls.Add(this.singleEditPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SingleFeeInfoEditForm";
            this.Text = "±‡º≠Ω…∑—–≈œ¢";
            this.ResumeLayout(false);

        }

        #endregion

        private SingleEditPanel singleEditPanel1;

    }
}
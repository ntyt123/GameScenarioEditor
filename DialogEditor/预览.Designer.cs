namespace DialogEditor
{
    partial class 预览
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
            this.tbView = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbView
            // 
            this.tbView.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbView.Location = new System.Drawing.Point(66, 34);
            this.tbView.Multiline = true;
            this.tbView.Name = "tbView";
            this.tbView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbView.Size = new System.Drawing.Size(520, 480);
            this.tbView.TabIndex = 0;
            // 
            // 预览
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(660, 560);
            this.Controls.Add(this.tbView);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "预览";
            this.Text = "预览";
            this.Load += new System.EventHandler(this.预览_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbView;


    }
}
namespace TestForm
{
    partial class FormMain
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
            if(disposing && (components != null)) {
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
            this.btnFormDGVShow = new System.Windows.Forms.Button();
            this.btnFormDGVShowDialog = new System.Windows.Forms.Button();
            this.btnGCCollect = new System.Windows.Forms.Button();
            this.lbMemoryUsage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFormDGVShow
            // 
            this.btnFormDGVShow.Location = new System.Drawing.Point(49, 47);
            this.btnFormDGVShow.Name = "btnFormDGVShow";
            this.btnFormDGVShow.Size = new System.Drawing.Size(136, 23);
            this.btnFormDGVShow.TabIndex = 0;
            this.btnFormDGVShow.Text = "FormDGV.Show()";
            this.btnFormDGVShow.UseVisualStyleBackColor = true;
            // 
            // btnFormDGVShowDialog
            // 
            this.btnFormDGVShowDialog.Location = new System.Drawing.Point(49, 107);
            this.btnFormDGVShowDialog.Name = "btnFormDGVShowDialog";
            this.btnFormDGVShowDialog.Size = new System.Drawing.Size(136, 23);
            this.btnFormDGVShowDialog.TabIndex = 1;
            this.btnFormDGVShowDialog.Text = "FormDGV.ShowDialog()";
            this.btnFormDGVShowDialog.UseVisualStyleBackColor = true;
            // 
            // btnGCCollect
            // 
            this.btnGCCollect.Location = new System.Drawing.Point(49, 169);
            this.btnGCCollect.Name = "btnGCCollect";
            this.btnGCCollect.Size = new System.Drawing.Size(136, 23);
            this.btnGCCollect.TabIndex = 2;
            this.btnGCCollect.Text = "GC.Collect()";
            this.btnGCCollect.UseVisualStyleBackColor = true;
            // 
            // lbMemoryUsage
            // 
            this.lbMemoryUsage.AutoSize = true;
            this.lbMemoryUsage.Location = new System.Drawing.Point(37, 234);
            this.lbMemoryUsage.Name = "lbMemoryUsage";
            this.lbMemoryUsage.Size = new System.Drawing.Size(82, 12);
            this.lbMemoryUsage.TabIndex = 3;
            this.lbMemoryUsage.Text = "Memory Usage :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 285);
            this.Controls.Add(this.lbMemoryUsage);
            this.Controls.Add(this.btnGCCollect);
            this.Controls.Add(this.btnFormDGVShowDialog);
            this.Controls.Add(this.btnFormDGVShow);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormDGVShow;
        private System.Windows.Forms.Button btnFormDGVShowDialog;
        private System.Windows.Forms.Button btnGCCollect;
        private System.Windows.Forms.Label lbMemoryUsage;
    }
}
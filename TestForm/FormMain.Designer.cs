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
            this.btnFormGVShowDialog = new System.Windows.Forms.Button();
            this.btnFormGVShow = new System.Windows.Forms.Button();
            this.btnFormDGVShowMenuStripShow = new System.Windows.Forms.Button();
            this.btnDGVShowOnce = new System.Windows.Forms.Button();
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
            this.btnFormDGVShow.Click += new System.EventHandler(this.btnFormDGVShow_Click);
            // 
            // btnFormDGVShowDialog
            // 
            this.btnFormDGVShowDialog.Location = new System.Drawing.Point(49, 148);
            this.btnFormDGVShowDialog.Name = "btnFormDGVShowDialog";
            this.btnFormDGVShowDialog.Size = new System.Drawing.Size(136, 23);
            this.btnFormDGVShowDialog.TabIndex = 1;
            this.btnFormDGVShowDialog.Text = "FormDGV.ShowDialog()";
            this.btnFormDGVShowDialog.UseVisualStyleBackColor = true;
            this.btnFormDGVShowDialog.Click += new System.EventHandler(this.btnFormDGVShowDialog_Click);
            // 
            // btnGCCollect
            // 
            this.btnGCCollect.Location = new System.Drawing.Point(49, 247);
            this.btnGCCollect.Name = "btnGCCollect";
            this.btnGCCollect.Size = new System.Drawing.Size(278, 23);
            this.btnGCCollect.TabIndex = 2;
            this.btnGCCollect.Text = "GC.Collect()";
            this.btnGCCollect.UseVisualStyleBackColor = true;
            this.btnGCCollect.Click += new System.EventHandler(this.btnGCCollect_Click);
            // 
            // lbMemoryUsage
            // 
            this.lbMemoryUsage.AutoSize = true;
            this.lbMemoryUsage.Location = new System.Drawing.Point(37, 312);
            this.lbMemoryUsage.Name = "lbMemoryUsage";
            this.lbMemoryUsage.Size = new System.Drawing.Size(82, 12);
            this.lbMemoryUsage.TabIndex = 3;
            this.lbMemoryUsage.Text = "Memory Usage :";
            // 
            // btnFormGVShowDialog
            // 
            this.btnFormGVShowDialog.Location = new System.Drawing.Point(191, 148);
            this.btnFormGVShowDialog.Name = "btnFormGVShowDialog";
            this.btnFormGVShowDialog.Size = new System.Drawing.Size(136, 23);
            this.btnFormGVShowDialog.TabIndex = 5;
            this.btnFormGVShowDialog.Text = "FormGV.ShowDialog()";
            this.btnFormGVShowDialog.UseVisualStyleBackColor = true;
            this.btnFormGVShowDialog.Click += new System.EventHandler(this.btnFormGVShowDialog_Click);
            // 
            // btnFormGVShow
            // 
            this.btnFormGVShow.Location = new System.Drawing.Point(191, 47);
            this.btnFormGVShow.Name = "btnFormGVShow";
            this.btnFormGVShow.Size = new System.Drawing.Size(136, 23);
            this.btnFormGVShow.TabIndex = 4;
            this.btnFormGVShow.Text = "FormGV.Show()";
            this.btnFormGVShow.UseVisualStyleBackColor = true;
            this.btnFormGVShow.Click += new System.EventHandler(this.btnFormGVShow_Click);
            // 
            // btnFormDGVShowMenuStripShow
            // 
            this.btnFormDGVShowMenuStripShow.Location = new System.Drawing.Point(49, 98);
            this.btnFormDGVShowMenuStripShow.Name = "btnFormDGVShowMenuStripShow";
            this.btnFormDGVShowMenuStripShow.Size = new System.Drawing.Size(278, 23);
            this.btnFormDGVShowMenuStripShow.TabIndex = 6;
            this.btnFormDGVShowMenuStripShow.Text = "FormDGV.Show() + MenuStrip.Show()";
            this.btnFormDGVShowMenuStripShow.UseVisualStyleBackColor = true;
            this.btnFormDGVShowMenuStripShow.Click += new System.EventHandler(this.btnFormDGVShowMenuStripShow_Click);
            // 
            // btnDGVShowOnce
            // 
            this.btnDGVShowOnce.Location = new System.Drawing.Point(49, 198);
            this.btnDGVShowOnce.Name = "btnDGVShowOnce";
            this.btnDGVShowOnce.Size = new System.Drawing.Size(136, 23);
            this.btnDGVShowOnce.TabIndex = 7;
            this.btnDGVShowOnce.Text = "FormDGV.Show() Once";
            this.btnDGVShowOnce.UseVisualStyleBackColor = true;
            this.btnDGVShowOnce.Click += new System.EventHandler(this.btnDGVShowOnce_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 420);
            this.Controls.Add(this.btnDGVShowOnce);
            this.Controls.Add(this.btnFormDGVShowMenuStripShow);
            this.Controls.Add(this.btnFormGVShowDialog);
            this.Controls.Add(this.btnFormGVShow);
            this.Controls.Add(this.lbMemoryUsage);
            this.Controls.Add(this.btnGCCollect);
            this.Controls.Add(this.btnFormDGVShowDialog);
            this.Controls.Add(this.btnFormDGVShow);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormDGVShow;
        private System.Windows.Forms.Button btnFormDGVShowDialog;
        private System.Windows.Forms.Button btnGCCollect;
        private System.Windows.Forms.Label lbMemoryUsage;
        private System.Windows.Forms.Button btnFormGVShowDialog;
        private System.Windows.Forms.Button btnFormGVShow;
        private System.Windows.Forms.Button btnFormDGVShowMenuStripShow;
        private System.Windows.Forms.Button btnDGVShowOnce;
    }
}
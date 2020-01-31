namespace Consumer
{
    partial class BusyForm
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
            this.pg_progress = new System.Windows.Forms.ProgressBar();
            this.l_calculate = new System.Windows.Forms.Label();
            this.bg_worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pg_progress
            // 
            this.pg_progress.Location = new System.Drawing.Point(82, 16);
            this.pg_progress.MarqueeAnimationSpeed = 30;
            this.pg_progress.Name = "pg_progress";
            this.pg_progress.Size = new System.Drawing.Size(229, 17);
            this.pg_progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pg_progress.TabIndex = 0;
            this.pg_progress.UseWaitCursor = true;
            // 
            // l_calculate
            // 
            this.l_calculate.AutoSize = true;
            this.l_calculate.Location = new System.Drawing.Point(13, 18);
            this.l_calculate.Name = "l_calculate";
            this.l_calculate.Size = new System.Drawing.Size(63, 13);
            this.l_calculate.TabIndex = 1;
            this.l_calculate.Text = "Calculate ...";
            // 
            // bg_worker
            // 
            this.bg_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_worker_DoWork);
            this.bg_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_worker_RunWorkerCompleted);
            // 
            // BusyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 51);
            this.Controls.Add(this.l_calculate);
            this.Controls.Add(this.pg_progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BusyForm";
            this.Text = "BusyForm";
            this.Load += new System.EventHandler(this.BusyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pg_progress;
        private System.Windows.Forms.Label l_calculate;
        private System.ComponentModel.BackgroundWorker bg_worker;
    }
}
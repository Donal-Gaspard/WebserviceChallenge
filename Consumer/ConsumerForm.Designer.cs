namespace Consumer
{
    partial class ConsumerForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_fibonacci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_xml = new System.Windows.Forms.RichTextBox();
            this.rtb_json = new System.Windows.Forms.RichTextBox();
            this.btn_convertToJson = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_event = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsb_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.bg_worker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fibonacci
            // 
            this.btn_fibonacci.BackColor = System.Drawing.Color.White;
            this.btn_fibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fibonacci.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_fibonacci.Location = new System.Drawing.Point(166, 43);
            this.btn_fibonacci.Name = "btn_fibonacci";
            this.btn_fibonacci.Size = new System.Drawing.Size(159, 34);
            this.btn_fibonacci.TabIndex = 0;
            this.btn_fibonacci.Text = "Compute Fibonancci(10)";
            this.btn_fibonacci.UseVisualStyleBackColor = false;
            this.btn_fibonacci.Click += new System.EventHandler(this.btn_fibonacci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fibonnacycci Service :";
            // 
            // rtb_xml
            // 
            this.rtb_xml.Location = new System.Drawing.Point(12, 134);
            this.rtb_xml.Name = "rtb_xml";
            this.rtb_xml.Size = new System.Drawing.Size(300, 170);
            this.rtb_xml.TabIndex = 3;
            this.rtb_xml.Text = "";
            // 
            // rtb_json
            // 
            this.rtb_json.Location = new System.Drawing.Point(376, 134);
            this.rtb_json.Name = "rtb_json";
            this.rtb_json.Size = new System.Drawing.Size(300, 170);
            this.rtb_json.TabIndex = 4;
            this.rtb_json.Text = "";
            // 
            // btn_convertToJson
            // 
            this.btn_convertToJson.BackColor = System.Drawing.Color.White;
            this.btn_convertToJson.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convertToJson.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_convertToJson.Location = new System.Drawing.Point(331, 208);
            this.btn_convertToJson.Name = "btn_convertToJson";
            this.btn_convertToJson.Size = new System.Drawing.Size(39, 23);
            this.btn_convertToJson.TabIndex = 5;
            this.btn_convertToJson.Text = "=>";
            this.btn_convertToJson.UseVisualStyleBackColor = false;
            this.btn_convertToJson.Click += new System.EventHandler(this.btn_convertToJson_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_event,
            this.tsb_progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 358);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(691, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_event
            // 
            this.tssl_event.Name = "tssl_event";
            this.tssl_event.Size = new System.Drawing.Size(42, 17);
            this.tssl_event.Text = "Event :";
            // 
            // tsb_progress
            // 
            this.tsb_progress.MarqueeAnimationSpeed = 30;
            this.tsb_progress.Name = "tsb_progress";
            this.tsb_progress.Size = new System.Drawing.Size(100, 16);
            this.tsb_progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.tsb_progress.Visible = false;
            // 
            // bg_worker
            // 
            this.bg_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_worker_DoWork);
            this.bg_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_worker_RunWorkerCompleted);
            // 
            // ConsumerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 380);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_convertToJson);
            this.Controls.Add(this.rtb_json);
            this.Controls.Add(this.rtb_xml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fibonacci);
            this.Name = "ConsumerForm";
            this.Text = "Consumer Form";
            this.Load += new System.EventHandler(this.ConsumerForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fibonacci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_xml;
        private System.Windows.Forms.RichTextBox rtb_json;
        private System.Windows.Forms.Button btn_convertToJson;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_event;
        private System.Windows.Forms.ToolStripProgressBar tsb_progress;
        private System.ComponentModel.BackgroundWorker bg_worker;
    }
}


namespace StudyTimeManagment
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ModelNameLabel = new System.Windows.Forms.Label();
            this.StartStopBtn = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseTimesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseTimesToolStripMenuItem
            // 
            this.chooseTimesToolStripMenuItem.Name = "chooseTimesToolStripMenuItem";
            this.chooseTimesToolStripMenuItem.Size = new System.Drawing.Size(112, 34);
            this.chooseTimesToolStripMenuItem.Text = "Choose times";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel1.Controls.Add(this.ModelNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartStopBtn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TimerLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModelLabel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 206);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ModelNameLabel
            // 
            this.ModelNameLabel.AutoSize = true;
            this.ModelNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModelNameLabel.Location = new System.Drawing.Point(225, 3);
            this.ModelNameLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ModelNameLabel.Name = "ModelNameLabel";
            this.ModelNameLabel.Size = new System.Drawing.Size(349, 25);
            this.ModelNameLabel.TabIndex = 0;
            this.ModelNameLabel.Text = "Model:";
            this.ModelNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartStopBtn
            // 
            this.StartStopBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartStopBtn.Location = new System.Drawing.Point(225, 159);
            this.StartStopBtn.Name = "StartStopBtn";
            this.StartStopBtn.Size = new System.Drawing.Size(349, 44);
            this.StartStopBtn.TabIndex = 1;
            this.StartStopBtn.Text = "Start";
            this.StartStopBtn.UseVisualStyleBackColor = true;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TimerLabel.Location = new System.Drawing.Point(225, 58);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(3);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(349, 95);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.Text = "00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ModelLabel.Location = new System.Drawing.Point(225, 34);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(349, 18);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "label2";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseTimesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ModelNameLabel;
        private System.Windows.Forms.Button StartStopBtn;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label ModelLabel;
    }
}


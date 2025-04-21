namespace RizzCasino.Views
{
    partial class DoubleOrNothingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoubleOrNothingForm));
            lblBalans = new Label();
            BackHomeBtn = new Button();
            lblResultaat = new Label();
            nudInzet = new NumericUpDown();
            btnStart = new Button();
            btnVerdubbel = new Button();
            btnUitcashen = new Button();
            Nouse = new Label();
            ((System.ComponentModel.ISupportInitialize)nudInzet).BeginInit();
            SuspendLayout();
            // 
            // lblBalans
            // 
            lblBalans.AutoSize = true;
            lblBalans.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalans.Location = new Point(12, 9);
            lblBalans.Name = "lblBalans";
            lblBalans.Size = new Size(76, 17);
            lblBalans.TabIndex = 7;
            lblBalans.Text = "BalansLabel";
            // 
            // BackHomeBtn
            // 
            BackHomeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackHomeBtn.AutoSize = true;
            BackHomeBtn.Location = new Point(12, 413);
            BackHomeBtn.Name = "BackHomeBtn";
            BackHomeBtn.Size = new Size(139, 25);
            BackHomeBtn.TabIndex = 9;
            BackHomeBtn.Text = "Terug naar homepage";
            BackHomeBtn.UseVisualStyleBackColor = true;
            BackHomeBtn.Click += btnTerug_Click;
            // 
            // lblResultaat
            // 
            lblResultaat.Anchor = AnchorStyles.Top;
            lblResultaat.Location = new Point(188, 202);
            lblResultaat.Name = "lblResultaat";
            lblResultaat.Size = new Size(432, 15);
            lblResultaat.TabIndex = 10;
            lblResultaat.Text = "lblResultaat";
            lblResultaat.TextAlign = ContentAlignment.MiddleCenter;
            lblResultaat.Visible = false;
            // 
            // nudInzet
            // 
            nudInzet.Anchor = AnchorStyles.Left;
            nudInzet.Location = new Point(12, 202);
            nudInzet.Name = "nudInzet";
            nudInzet.Size = new Size(120, 23);
            nudInzet.TabIndex = 11;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Left;
            btnStart.Location = new Point(13, 231);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 12;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnVerdubbel
            // 
            btnVerdubbel.Anchor = AnchorStyles.Top;
            btnVerdubbel.AutoSize = true;
            btnVerdubbel.Enabled = false;
            btnVerdubbel.Location = new Point(307, 255);
            btnVerdubbel.Name = "btnVerdubbel";
            btnVerdubbel.Size = new Size(89, 25);
            btnVerdubbel.TabIndex = 13;
            btnVerdubbel.Text = "Verdubbelen";
            btnVerdubbel.UseVisualStyleBackColor = true;
            btnVerdubbel.Click += btnVerdubbel_Click;
            // 
            // btnUitcashen
            // 
            btnUitcashen.Anchor = AnchorStyles.Top;
            btnUitcashen.AutoSize = true;
            btnUitcashen.Enabled = false;
            btnUitcashen.Location = new Point(413, 255);
            btnUitcashen.Name = "btnUitcashen";
            btnUitcashen.Size = new Size(89, 25);
            btnUitcashen.TabIndex = 14;
            btnUitcashen.Text = "Uitcashen";
            btnUitcashen.UseVisualStyleBackColor = true;
            btnUitcashen.Click += btnUitcashen_Click;
            // 
            // Nouse
            // 
            Nouse.Anchor = AnchorStyles.Left;
            Nouse.AutoSize = true;
            Nouse.Location = new Point(12, 184);
            Nouse.Name = "Nouse";
            Nouse.Size = new Size(35, 15);
            Nouse.TabIndex = 15;
            Nouse.Text = "Inzet:";
            // 
            // DoubleOrNothingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Nouse);
            Controls.Add(btnUitcashen);
            Controls.Add(btnVerdubbel);
            Controls.Add(btnStart);
            Controls.Add(nudInzet);
            Controls.Add(lblResultaat);
            Controls.Add(BackHomeBtn);
            Controls.Add(lblBalans);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoubleOrNothingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Double or nothing";
            FormClosed += DoubleOrNothingForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)nudInzet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalans;
        private Button BackHomeBtn;
        private Label lblResultaat;
        private NumericUpDown nudInzet;
        private Button btnStart;
        private Button btnVerdubbel;
        private Button btnUitcashen;
        private Label Nouse;
    }
}
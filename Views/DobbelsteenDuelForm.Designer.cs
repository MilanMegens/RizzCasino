namespace RizzCasino.Views
{
    partial class DobbelsteenDuelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DobbelsteenDuelForm));
            lblBalans = new Label();
            btnTerug = new Button();
            lblResultaat = new Label();
            picBot = new PictureBox();
            picSpeler = new PictureBox();
            nudInzet = new NumericUpDown();
            btnGooien = new Button();
            Geenuse = new Label();
            nouse = new Label();
            ((System.ComponentModel.ISupportInitialize)picBot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSpeler).BeginInit();
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
            lblBalans.TabIndex = 3;
            lblBalans.Text = "BalansLabel";
            // 
            // btnTerug
            // 
            btnTerug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTerug.AutoSize = true;
            btnTerug.Location = new Point(12, 413);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(139, 25);
            btnTerug.TabIndex = 10;
            btnTerug.Text = "Terug naar homepage";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // lblResultaat
            // 
            lblResultaat.Anchor = AnchorStyles.Top;
            lblResultaat.Location = new Point(187, 204);
            lblResultaat.Name = "lblResultaat";
            lblResultaat.Size = new Size(434, 15);
            lblResultaat.TabIndex = 11;
            lblResultaat.Text = "lblResultaat";
            lblResultaat.TextAlign = ContentAlignment.MiddleCenter;
            lblResultaat.Visible = false;
            // 
            // picBot
            // 
            picBot.Anchor = AnchorStyles.Top;
            picBot.Location = new Point(340, 30);
            picBot.MaximumSize = new Size(130, 130);
            picBot.MinimumSize = new Size(130, 130);
            picBot.Name = "picBot";
            picBot.Size = new Size(130, 130);
            picBot.SizeMode = PictureBoxSizeMode.Zoom;
            picBot.TabIndex = 12;
            picBot.TabStop = false;
            // 
            // picSpeler
            // 
            picSpeler.Anchor = AnchorStyles.Bottom;
            picSpeler.Location = new Point(340, 265);
            picSpeler.MaximumSize = new Size(130, 130);
            picSpeler.MinimumSize = new Size(130, 130);
            picSpeler.Name = "picSpeler";
            picSpeler.Size = new Size(130, 130);
            picSpeler.SizeMode = PictureBoxSizeMode.Zoom;
            picSpeler.TabIndex = 13;
            picSpeler.TabStop = false;
            // 
            // nudInzet
            // 
            nudInzet.Anchor = AnchorStyles.Left;
            nudInzet.Location = new Point(12, 202);
            nudInzet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudInzet.Name = "nudInzet";
            nudInzet.Size = new Size(120, 23);
            nudInzet.TabIndex = 14;
            // 
            // btnGooien
            // 
            btnGooien.Anchor = AnchorStyles.Bottom;
            btnGooien.AutoSize = true;
            btnGooien.Location = new Point(340, 399);
            btnGooien.Name = "btnGooien";
            btnGooien.Size = new Size(130, 25);
            btnGooien.TabIndex = 15;
            btnGooien.Text = "Gooi dobbelsteen";
            btnGooien.UseVisualStyleBackColor = true;
            btnGooien.Click += btnGooi_Click;
            // 
            // Geenuse
            // 
            Geenuse.Anchor = AnchorStyles.Top;
            Geenuse.AutoSize = true;
            Geenuse.Location = new Point(357, 9);
            Geenuse.Name = "Geenuse";
            Geenuse.Size = new Size(94, 15);
            Geenuse.TabIndex = 16;
            Geenuse.Text = "Computer worp:";
            // 
            // nouse
            // 
            nouse.Anchor = AnchorStyles.Left;
            nouse.AutoSize = true;
            nouse.Location = new Point(12, 184);
            nouse.Name = "nouse";
            nouse.Size = new Size(35, 15);
            nouse.TabIndex = 17;
            nouse.Text = "Inzet:";
            // 
            // DobbelsteenDuelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nouse);
            Controls.Add(Geenuse);
            Controls.Add(btnGooien);
            Controls.Add(nudInzet);
            Controls.Add(picSpeler);
            Controls.Add(picBot);
            Controls.Add(lblResultaat);
            Controls.Add(btnTerug);
            Controls.Add(lblBalans);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DobbelsteenDuelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dobbelsteen duel";
            FormClosed += DobbelsteenDuelForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)picBot).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSpeler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInzet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBalans;
        private Button btnTerug;
        private Label lblResultaat;
        private PictureBox picBot;
        private PictureBox picSpeler;
        private NumericUpDown nudInzet;
        private Button btnGooien;
        private Label Geenuse;
        private Label nouse;
    }
}
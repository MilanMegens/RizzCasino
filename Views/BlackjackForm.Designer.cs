namespace RizzCasino.Views
{
    partial class BlackjackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackjackForm));
            btnHit = new Button();
            btnStand = new Button();
            btnNieuwSpel = new Button();
            lblSpelerScore = new Label();
            lblDealerScore = new Label();
            nudInzet = new NumericUpDown();
            lblBalans = new Label();
            btnTerug = new Button();
            Nouse = new Label();
            geenuse = new Label();
            geeneenuse = new Label();
            flpDealerKaarten = new FlowLayoutPanel();
            flpSpelerKaarten = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)nudInzet).BeginInit();
            SuspendLayout();
            // 
            // btnHit
            // 
            btnHit.Anchor = AnchorStyles.Bottom;
            btnHit.AutoSize = true;
            btnHit.Enabled = false;
            btnHit.Location = new Point(408, 390);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(75, 25);
            btnHit.TabIndex = 0;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Anchor = AnchorStyles.Bottom;
            btnStand.AutoSize = true;
            btnStand.Enabled = false;
            btnStand.Location = new Point(315, 390);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(75, 25);
            btnStand.TabIndex = 1;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // btnNieuwSpel
            // 
            btnNieuwSpel.Anchor = AnchorStyles.Left;
            btnNieuwSpel.AutoSize = true;
            btnNieuwSpel.Location = new Point(12, 224);
            btnNieuwSpel.Name = "btnNieuwSpel";
            btnNieuwSpel.Size = new Size(75, 25);
            btnNieuwSpel.TabIndex = 2;
            btnNieuwSpel.Text = "Nieuw spel";
            btnNieuwSpel.UseVisualStyleBackColor = true;
            btnNieuwSpel.Click += btnNieuwSpel_Click;
            // 
            // lblSpelerScore
            // 
            lblSpelerScore.Anchor = AnchorStyles.Bottom;
            lblSpelerScore.Location = new Point(1, 375);
            lblSpelerScore.Name = "lblSpelerScore";
            lblSpelerScore.Size = new Size(799, 15);
            lblSpelerScore.TabIndex = 3;
            lblSpelerScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDealerScore
            // 
            lblDealerScore.Anchor = AnchorStyles.Top;
            lblDealerScore.Location = new Point(1, 143);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new Size(799, 15);
            lblDealerScore.TabIndex = 4;
            lblDealerScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudInzet
            // 
            nudInzet.Anchor = AnchorStyles.Left;
            nudInzet.Location = new Point(12, 194);
            nudInzet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudInzet.Name = "nudInzet";
            nudInzet.Size = new Size(120, 23);
            nudInzet.TabIndex = 5;
            // 
            // lblBalans
            // 
            lblBalans.AutoSize = true;
            lblBalans.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalans.Location = new Point(12, 9);
            lblBalans.Name = "lblBalans";
            lblBalans.Size = new Size(76, 17);
            lblBalans.TabIndex = 6;
            lblBalans.Text = "BalansLabel";
            // 
            // btnTerug
            // 
            btnTerug.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTerug.AutoSize = true;
            btnTerug.Location = new Point(12, 413);
            btnTerug.Name = "btnTerug";
            btnTerug.Size = new Size(139, 25);
            btnTerug.TabIndex = 9;
            btnTerug.Text = "Terug naar homepage";
            btnTerug.UseVisualStyleBackColor = true;
            btnTerug.Click += btnTerug_Click;
            // 
            // Nouse
            // 
            Nouse.Anchor = AnchorStyles.Bottom;
            Nouse.AutoSize = true;
            Nouse.Location = new Point(368, 254);
            Nouse.Name = "Nouse";
            Nouse.Size = new Size(67, 15);
            Nouse.TabIndex = 10;
            Nouse.Text = "Jouw hand:";
            // 
            // geenuse
            // 
            geenuse.Anchor = AnchorStyles.Top;
            geenuse.AutoSize = true;
            geenuse.Location = new Point(364, 22);
            geenuse.Name = "geenuse";
            geenuse.Size = new Size(78, 15);
            geenuse.TabIndex = 11;
            geenuse.Text = "Dealers hand:";
            // 
            // geeneenuse
            // 
            geeneenuse.Anchor = AnchorStyles.Left;
            geeneenuse.AutoSize = true;
            geeneenuse.Location = new Point(12, 176);
            geeneenuse.Name = "geeneenuse";
            geeneenuse.Size = new Size(35, 15);
            geeneenuse.TabIndex = 12;
            geeneenuse.Text = "Inzet:";
            // 
            // flpDealerKaarten
            // 
            flpDealerKaarten.Anchor = AnchorStyles.Top;
            flpDealerKaarten.Location = new Point(12, 40);
            flpDealerKaarten.Name = "flpDealerKaarten";
            flpDealerKaarten.Size = new Size(776, 100);
            flpDealerKaarten.TabIndex = 13;
            // 
            // flpSpelerKaarten
            // 
            flpSpelerKaarten.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpSpelerKaarten.Location = new Point(12, 272);
            flpSpelerKaarten.Name = "flpSpelerKaarten";
            flpSpelerKaarten.Size = new Size(776, 100);
            flpSpelerKaarten.TabIndex = 14;
            flpSpelerKaarten.WrapContents = false;
            // 
            // BlackjackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpSpelerKaarten);
            Controls.Add(flpDealerKaarten);
            Controls.Add(geeneenuse);
            Controls.Add(geenuse);
            Controls.Add(Nouse);
            Controls.Add(btnTerug);
            Controls.Add(lblBalans);
            Controls.Add(nudInzet);
            Controls.Add(lblDealerScore);
            Controls.Add(lblSpelerScore);
            Controls.Add(btnNieuwSpel);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BlackjackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Blackjack";
            FormClosed += BlackjackForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)nudInzet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHit;
        private Button btnStand;
        private Button btnNieuwSpel;
        private Label lblSpelerScore;
        private Label lblDealerScore;
        private NumericUpDown nudInzet;
        private Label lblBalans;
        private Button btnTerug;
        private Label Nouse;
        private Label geenuse;
        private Label geeneenuse;
        private FlowLayoutPanel flpDealerKaarten;
        private FlowLayoutPanel flpSpelerKaarten;
    }
}
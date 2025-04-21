namespace RizzCasino.Views
{
    partial class SlotmachineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlotmachineForm));
            NoUse = new Label();
            lblSymbool1 = new Label();
            GeenUse = new Panel();
            lblSymbool3 = new Label();
            lblSymbool2 = new Label();
            nudInzet = new NumericUpDown();
            btnDraai = new Button();
            lblBalans = new Label();
            geenusen = new Label();
            BackHomeBtn = new Button();
            GeenUse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInzet).BeginInit();
            SuspendLayout();
            // 
            // NoUse
            // 
            NoUse.Anchor = AnchorStyles.Top;
            NoUse.AutoSize = true;
            NoUse.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoUse.Location = new Point(317, 9);
            NoUse.Name = "NoUse";
            NoUse.Size = new Size(176, 37);
            NoUse.TabIndex = 0;
            NoUse.Text = "Slotmachine";
            // 
            // lblSymbool1
            // 
            lblSymbool1.Anchor = AnchorStyles.Top;
            lblSymbool1.AutoSize = true;
            lblSymbool1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblSymbool1.Location = new Point(3, 0);
            lblSymbool1.Name = "lblSymbool1";
            lblSymbool1.Size = new Size(95, 65);
            lblSymbool1.TabIndex = 1;
            lblSymbool1.Text = "🍒";
            lblSymbool1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GeenUse
            // 
            GeenUse.Anchor = AnchorStyles.Top;
            GeenUse.Controls.Add(lblSymbool3);
            GeenUse.Controls.Add(lblSymbool2);
            GeenUse.Controls.Add(lblSymbool1);
            GeenUse.Location = new Point(259, 159);
            GeenUse.Name = "GeenUse";
            GeenUse.Size = new Size(296, 79);
            GeenUse.TabIndex = 2;
            // 
            // lblSymbool3
            // 
            lblSymbool3.Anchor = AnchorStyles.Top;
            lblSymbool3.AutoSize = true;
            lblSymbool3.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblSymbool3.Location = new Point(201, 0);
            lblSymbool3.Name = "lblSymbool3";
            lblSymbool3.Size = new Size(95, 65);
            lblSymbool3.TabIndex = 3;
            lblSymbool3.Text = "🔔";
            lblSymbool3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSymbool2
            // 
            lblSymbool2.Anchor = AnchorStyles.Top;
            lblSymbool2.AutoSize = true;
            lblSymbool2.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblSymbool2.Location = new Point(101, 0);
            lblSymbool2.Name = "lblSymbool2";
            lblSymbool2.Size = new Size(95, 65);
            lblSymbool2.TabIndex = 2;
            lblSymbool2.Text = "🍋";
            lblSymbool2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudInzet
            // 
            nudInzet.Anchor = AnchorStyles.Top;
            nudInzet.Location = new Point(372, 57);
            nudInzet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudInzet.Name = "nudInzet";
            nudInzet.Size = new Size(120, 23);
            nudInzet.TabIndex = 3;
            // 
            // btnDraai
            // 
            btnDraai.Anchor = AnchorStyles.Top;
            btnDraai.AutoSize = true;
            btnDraai.Location = new Point(368, 265);
            btnDraai.Name = "btnDraai";
            btnDraai.Size = new Size(75, 25);
            btnDraai.TabIndex = 4;
            btnDraai.Text = "Draai";
            btnDraai.UseVisualStyleBackColor = true;
            btnDraai.Click += btnDraai_Click;
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
            // geenusen
            // 
            geenusen.Anchor = AnchorStyles.Top;
            geenusen.AutoSize = true;
            geenusen.Location = new Point(331, 59);
            geenusen.Name = "geenusen";
            geenusen.Size = new Size(35, 15);
            geenusen.TabIndex = 7;
            geenusen.Text = "Inzet:";
            // 
            // BackHomeBtn
            // 
            BackHomeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BackHomeBtn.AutoSize = true;
            BackHomeBtn.Location = new Point(12, 413);
            BackHomeBtn.Name = "BackHomeBtn";
            BackHomeBtn.Size = new Size(139, 25);
            BackHomeBtn.TabIndex = 8;
            BackHomeBtn.Text = "Terug naar homepage";
            BackHomeBtn.UseVisualStyleBackColor = true;
            BackHomeBtn.Click += BackHomeBtn_Click;
            // 
            // SlotmachineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackHomeBtn);
            Controls.Add(geenusen);
            Controls.Add(lblBalans);
            Controls.Add(btnDraai);
            Controls.Add(nudInzet);
            Controls.Add(GeenUse);
            Controls.Add(NoUse);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SlotmachineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Slotmachine";
            FormClosed += SlotmachineForm_FormClosed;
            GeenUse.ResumeLayout(false);
            GeenUse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudInzet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NoUse;
        private Label lblSymbool1;
        private Panel GeenUse;
        private Label lblSymbool3;
        private Label lblSymbool2;
        private NumericUpDown nudInzet;
        private Button btnDraai;
        private Label lblBalans;
        private Label geenusen;
        private Button BackHomeBtn;
    }
}
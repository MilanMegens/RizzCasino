namespace RizzCasino.Views
{
    partial class StartScherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScherm));
            lblTitel = new Label();
            lblSlogan = new Label();
            lblBalans = new Label();
            NoUse = new Panel();
            btnDoubleOrNothing = new Button();
            btnDobbelsteen = new Button();
            btnBlackjack = new Button();
            btnSlotmachine = new Button();
            NoUse.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.Anchor = AnchorStyles.Top;
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitel.Location = new Point(322, 31);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(161, 37);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Rizz Casino";
            // 
            // lblSlogan
            // 
            lblSlogan.Anchor = AnchorStyles.Top;
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlogan.Location = new Point(350, 68);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(101, 25);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "Rizzk it all!";
            // 
            // lblBalans
            // 
            lblBalans.AutoSize = true;
            lblBalans.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBalans.Location = new Point(12, 9);
            lblBalans.Name = "lblBalans";
            lblBalans.Size = new Size(76, 17);
            lblBalans.TabIndex = 2;
            lblBalans.Text = "BalansLabel";
            // 
            // NoUse
            // 
            NoUse.Anchor = AnchorStyles.Top;
            NoUse.Controls.Add(btnDoubleOrNothing);
            NoUse.Controls.Add(btnDobbelsteen);
            NoUse.Controls.Add(btnBlackjack);
            NoUse.Controls.Add(btnSlotmachine);
            NoUse.Location = new Point(184, 214);
            NoUse.Name = "NoUse";
            NoUse.Size = new Size(438, 31);
            NoUse.TabIndex = 3;
            // 
            // btnDoubleOrNothing
            // 
            btnDoubleOrNothing.AutoSize = true;
            btnDoubleOrNothing.Location = new Point(312, 3);
            btnDoubleOrNothing.Name = "btnDoubleOrNothing";
            btnDoubleOrNothing.Size = new Size(123, 25);
            btnDoubleOrNothing.TabIndex = 3;
            btnDoubleOrNothing.Text = "Double or Nothing";
            btnDoubleOrNothing.UseVisualStyleBackColor = true;
            btnDoubleOrNothing.Click += btnDoubleOrNothing_Click;
            // 
            // btnDobbelsteen
            // 
            btnDobbelsteen.AutoSize = true;
            btnDobbelsteen.Location = new Point(187, 3);
            btnDobbelsteen.Name = "btnDobbelsteen";
            btnDobbelsteen.Size = new Size(119, 25);
            btnDobbelsteen.TabIndex = 2;
            btnDobbelsteen.Text = "Dobbelsteen Duel";
            btnDobbelsteen.UseVisualStyleBackColor = true;
            btnDobbelsteen.Click += btnDobbelsteen_Click;
            // 
            // btnBlackjack
            // 
            btnBlackjack.AutoSize = true;
            btnBlackjack.Location = new Point(95, 3);
            btnBlackjack.Name = "btnBlackjack";
            btnBlackjack.Size = new Size(86, 25);
            btnBlackjack.TabIndex = 1;
            btnBlackjack.Text = "Blackjack";
            btnBlackjack.UseVisualStyleBackColor = true;
            btnBlackjack.Click += btnBlackjack_Click;
            // 
            // btnSlotmachine
            // 
            btnSlotmachine.AutoSize = true;
            btnSlotmachine.Location = new Point(3, 3);
            btnSlotmachine.Name = "btnSlotmachine";
            btnSlotmachine.Size = new Size(86, 25);
            btnSlotmachine.TabIndex = 0;
            btnSlotmachine.Text = "Slotmachine";
            btnSlotmachine.UseVisualStyleBackColor = true;
            btnSlotmachine.Click += btnSlotmachine_Click;
            // 
            // StartScherm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NoUse);
            Controls.Add(lblBalans);
            Controls.Add(lblSlogan);
            Controls.Add(lblTitel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StartScherm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rizz Casino";
            NoUse.ResumeLayout(false);
            NoUse.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblSlogan;
        private Label lblBalans;
        private Panel NoUse;
        private Button btnBlackjack;
        private Button btnSlotmachine;
        private Button btnDoubleOrNothing;
        private Button btnDobbelsteen;
    }
}
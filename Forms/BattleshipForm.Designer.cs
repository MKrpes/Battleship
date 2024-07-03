namespace Battleship.Forms
{
    partial class BattleshipForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            StartGameButton = new Button();
            ResetFleetButton = new Button();
            textBox1 = new TextBox();
            EnemyFleetGrid = new TableLayoutPanel();
            PlayerFleetGrid = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(EnemyFleetGrid);
            panel1.Controls.Add(PlayerFleetGrid);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(PlayerFleetGrid);
            panel2.Controls.Add(StartGameButton);
            panel2.Controls.Add(ResetFleetButton);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1100, 450);
            panel2.TabIndex = 4;
            // 
            // StartGameButton
            // 
            StartGameButton.Location = new Point(840, 228);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(94, 29);
            StartGameButton.TabIndex = 1;
            StartGameButton.Text = "Sail Away!";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += StartGameButton_Click;
            // 
            // ResetFleetButton
            // 
            ResetFleetButton.Location = new Point(840, 85);
            ResetFleetButton.Name = "ResetFleetButton";
            ResetFleetButton.Size = new Size(94, 29);
            ResetFleetButton.TabIndex = 0;
            ResetFleetButton.Text = "Reset Fleet";
            ResetFleetButton.UseVisualStyleBackColor = true;
            ResetFleetButton.Click += ResetFleetButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(853, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(216, 94);
            textBox1.TabIndex = 1;
            // 
            // EnemyFleetGrid
            // 
            EnemyFleetGrid.ColumnCount = 10;
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            EnemyFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            EnemyFleetGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            EnemyFleetGrid.Location = new Point(450, 45);
            EnemyFleetGrid.Name = "EnemyFleetGrid";
            EnemyFleetGrid.RowCount = 10;
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            EnemyFleetGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            EnemyFleetGrid.Size = new Size(360, 360);
            EnemyFleetGrid.TabIndex = 3;
            // 
            // PlayerFleetGrid
            // 
            PlayerFleetGrid.ColumnCount = 10;
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            PlayerFleetGrid.Location = new Point(45, 45);
            PlayerFleetGrid.Name = "PlayerFleetGrid";
            PlayerFleetGrid.RowCount = 10;
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            PlayerFleetGrid.Size = new Size(360, 360);
            PlayerFleetGrid.TabIndex = 2;
            // 
            // BattleshipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 450);
            Controls.Add(panel1);
            Name = "BattleshipForm";
            Text = "Battleship";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel EnemyFleetGrid;
        private TableLayoutPanel PlayerFleetGrid;
        private Panel panel2;
        private Button StartGameButton;
        private Button ResetFleetButton;
        public static TextBox textBox1;
    }
}
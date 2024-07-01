namespace Battleship2.Forms
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
            ConfirmFleetButton = new Button();
            FleetGrid = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(ConfirmFleetButton);
            panel1.Controls.Add(FleetGrid);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 452);
            panel1.TabIndex = 0;
            // 
            // ConfirmFleetButton
            // 
            ConfirmFleetButton.Location = new Point(617, 198);
            ConfirmFleetButton.Name = "ConfirmFleetButton";
            ConfirmFleetButton.Size = new Size(131, 29);
            ConfirmFleetButton.TabIndex = 4;
            ConfirmFleetButton.Text = "Sail away!";
            ConfirmFleetButton.UseVisualStyleBackColor = true;
            ConfirmFleetButton.Click += ConfirmFleetButton_Click;
            // 
            // FleetGrid
            // 
            FleetGrid.ColumnCount = 10;
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            FleetGrid.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            FleetGrid.Location = new Point(45, 45);
            FleetGrid.Name = "FleetGrid";
            FleetGrid.RowCount = 10;
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            FleetGrid.Size = new Size(360, 360);
            FleetGrid.TabIndex = 1;
            // 
            // BattleshipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "BattleshipForm";
            Text = "BattleshipForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel FleetGrid;
        private Button ConfirmFleetButton;
    }
}
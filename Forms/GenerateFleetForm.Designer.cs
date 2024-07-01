namespace Battleship2
{
    partial class GenerateFleetForm
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
            FleetGrid = new TableLayoutPanel();
            GenerateFleetButton = new Button();
            textBox1 = new TextBox();
            ConfirmFleetButton = new Button();
            SuspendLayout();
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
            FleetGrid.Location = new Point(25, 25);
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
            FleetGrid.TabIndex = 0;
            // 
            // GenerateFleetButton
            // 
            GenerateFleetButton.Location = new Point(629, 53);
            GenerateFleetButton.Name = "GenerateFleetButton";
            GenerateFleetButton.Size = new Size(131, 29);
            GenerateFleetButton.TabIndex = 1;
            GenerateFleetButton.Text = "Generate Fleet";
            GenerateFleetButton.UseVisualStyleBackColor = true;
            GenerateFleetButton.Click += GenerateFleetButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(493, 179);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 206);
            textBox1.TabIndex = 2;
            // 
            // ConfirmFleetButton
            // 
            ConfirmFleetButton.Location = new Point(629, 115);
            ConfirmFleetButton.Name = "ConfirmFleetButton";
            ConfirmFleetButton.Size = new Size(131, 29);
            ConfirmFleetButton.TabIndex = 3;
            ConfirmFleetButton.Text = "Sail away!";
            ConfirmFleetButton.UseVisualStyleBackColor = true;
            ConfirmFleetButton.Click += ConfirmFleetButton_Click;
            // 
            // GenerateFleetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConfirmFleetButton);
            Controls.Add(textBox1);
            Controls.Add(GenerateFleetButton);
            Controls.Add(FleetGrid);
            Name = "GenerateFleetForm";
            Text = "GenerateFleetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel FleetGrid;
        private Button GenerateFleetButton;
        private TextBox textBox1;
        private Button ConfirmFleetButton;
    }
}
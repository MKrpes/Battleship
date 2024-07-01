namespace Battleship2.Forms
{
    partial class TestForm
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
            textBox1 = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            FleetGrid = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(FleetGrid);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 449);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(853, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(216, 360);
            textBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(450, 45);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(360, 360);
            tableLayoutPanel1.TabIndex = 3;
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
            FleetGrid.TabIndex = 2;
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 450);
            Controls.Add(panel1);
            Name = "TestForm";
            Text = "TestForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel FleetGrid;
        public static TextBox textBox1;
    }
}
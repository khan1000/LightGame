
namespace LightGame
{
    partial class MainGame
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
            this.boardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.ColumnCount = 2;
            this.boardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.boardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.boardPanel.Location = new System.Drawing.Point(12, 49);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.RowCount = 2;
            this.boardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.boardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.boardPanel.Size = new System.Drawing.Size(776, 401);
            this.boardPanel.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(111, 30);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click_1);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start);
            this.Controls.Add(this.boardPanel);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel boardPanel;
        private System.Windows.Forms.Button start;
    }
}
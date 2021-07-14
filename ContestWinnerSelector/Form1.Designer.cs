
namespace ContestWinnerSelector
{
    partial class Form1
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.fileLocationBox = new System.Windows.Forms.TextBox();
            this.fileLocationLable = new System.Windows.Forms.Label();
            this.fileLocationButton = new System.Windows.Forms.Button();
            this.numOfWinnersBox = new System.Windows.Forms.TextBox();
            this.numOfWinnersLabel = new System.Windows.Forms.Label();
            this.winnersBox = new System.Windows.Forms.ListBox();
            this.winnersLabel = new System.Windows.Forms.Label();
            this.clearBoxesButton = new System.Windows.Forms.Button();
            this.generateWinnersButton = new System.Windows.Forms.Button();
            this.clearWinnersButton = new System.Windows.Forms.Button();
            this.clearWinnersBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mainLabel.Location = new System.Drawing.Point(204, 39);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(356, 41);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Contest Winner Selector";
            // 
            // fileLocationBox
            // 
            this.fileLocationBox.Location = new System.Drawing.Point(75, 144);
            this.fileLocationBox.Name = "fileLocationBox";
            this.fileLocationBox.Size = new System.Drawing.Size(223, 20);
            this.fileLocationBox.TabIndex = 1;
            // 
            // fileLocationLable
            // 
            this.fileLocationLable.AutoSize = true;
            this.fileLocationLable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileLocationLable.ForeColor = System.Drawing.SystemColors.Highlight;
            this.fileLocationLable.Location = new System.Drawing.Point(71, 122);
            this.fileLocationLable.Name = "fileLocationLable";
            this.fileLocationLable.Size = new System.Drawing.Size(78, 19);
            this.fileLocationLable.TabIndex = 2;
            this.fileLocationLable.Text = "File Name:";
            // 
            // fileLocationButton
            // 
            this.fileLocationButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.fileLocationButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fileLocationButton.Location = new System.Drawing.Point(323, 141);
            this.fileLocationButton.Name = "fileLocationButton";
            this.fileLocationButton.Size = new System.Drawing.Size(113, 23);
            this.fileLocationButton.TabIndex = 3;
            this.fileLocationButton.Text = "Browse";
            this.fileLocationButton.UseVisualStyleBackColor = false;
            this.fileLocationButton.Click += new System.EventHandler(this.fileLocationButton_Click);
            // 
            // numOfWinnersBox
            // 
            this.numOfWinnersBox.Location = new System.Drawing.Point(75, 222);
            this.numOfWinnersBox.Name = "numOfWinnersBox";
            this.numOfWinnersBox.Size = new System.Drawing.Size(100, 20);
            this.numOfWinnersBox.TabIndex = 4;
            // 
            // numOfWinnersLabel
            // 
            this.numOfWinnersLabel.AutoSize = true;
            this.numOfWinnersLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfWinnersLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.numOfWinnersLabel.Location = new System.Drawing.Point(71, 200);
            this.numOfWinnersLabel.Name = "numOfWinnersLabel";
            this.numOfWinnersLabel.Size = new System.Drawing.Size(139, 19);
            this.numOfWinnersLabel.TabIndex = 5;
            this.numOfWinnersLabel.Text = "Number of Winners:";
            // 
            // winnersBox
            // 
            this.winnersBox.FormattingEnabled = true;
            this.winnersBox.Location = new System.Drawing.Point(440, 213);
            this.winnersBox.Name = "winnersBox";
            this.winnersBox.Size = new System.Drawing.Size(314, 225);
            this.winnersBox.TabIndex = 6;
            // 
            // winnersLabel
            // 
            this.winnersLabel.AutoSize = true;
            this.winnersLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnersLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.winnersLabel.Location = new System.Drawing.Point(436, 191);
            this.winnersLabel.Name = "winnersLabel";
            this.winnersLabel.Size = new System.Drawing.Size(67, 19);
            this.winnersLabel.TabIndex = 7;
            this.winnersLabel.Text = "Winners:";
            // 
            // clearBoxesButton
            // 
            this.clearBoxesButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clearBoxesButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearBoxesButton.Location = new System.Drawing.Point(75, 391);
            this.clearBoxesButton.Name = "clearBoxesButton";
            this.clearBoxesButton.Size = new System.Drawing.Size(113, 23);
            this.clearBoxesButton.TabIndex = 8;
            this.clearBoxesButton.Text = "Clear All";
            this.clearBoxesButton.UseVisualStyleBackColor = false;
            this.clearBoxesButton.Click += new System.EventHandler(this.clearBoxesButton_Click);
            // 
            // generateWinnersButton
            // 
            this.generateWinnersButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.generateWinnersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.generateWinnersButton.Location = new System.Drawing.Point(265, 334);
            this.generateWinnersButton.Name = "generateWinnersButton";
            this.generateWinnersButton.Size = new System.Drawing.Size(137, 61);
            this.generateWinnersButton.TabIndex = 9;
            this.generateWinnersButton.Text = "Generate Winners";
            this.generateWinnersButton.UseVisualStyleBackColor = false;
            this.generateWinnersButton.Click += new System.EventHandler(this.generateWinnersButton_Click);
            // 
            // clearWinnersButton
            // 
            this.clearWinnersButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clearWinnersButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearWinnersButton.Location = new System.Drawing.Point(75, 353);
            this.clearWinnersButton.Name = "clearWinnersButton";
            this.clearWinnersButton.Size = new System.Drawing.Size(113, 23);
            this.clearWinnersButton.TabIndex = 10;
            this.clearWinnersButton.Text = "Clear Winners";
            this.clearWinnersButton.UseVisualStyleBackColor = false;
            this.clearWinnersButton.Click += new System.EventHandler(this.clearWinnersButton_Click);
            // 
            // clearWinnersBoxButton
            // 
            this.clearWinnersBoxButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.clearWinnersBoxButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearWinnersBoxButton.Location = new System.Drawing.Point(75, 313);
            this.clearWinnersBoxButton.Name = "clearWinnersBoxButton";
            this.clearWinnersBoxButton.Size = new System.Drawing.Size(113, 23);
            this.clearWinnersBoxButton.TabIndex = 11;
            this.clearWinnersBoxButton.Text = "Clear Winners Box";
            this.clearWinnersBoxButton.UseVisualStyleBackColor = false;
            this.clearWinnersBoxButton.Click += new System.EventHandler(this.clearWinnersBoxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearWinnersBoxButton);
            this.Controls.Add(this.clearWinnersButton);
            this.Controls.Add(this.generateWinnersButton);
            this.Controls.Add(this.clearBoxesButton);
            this.Controls.Add(this.winnersLabel);
            this.Controls.Add(this.winnersBox);
            this.Controls.Add(this.numOfWinnersLabel);
            this.Controls.Add(this.numOfWinnersBox);
            this.Controls.Add(this.fileLocationButton);
            this.Controls.Add(this.fileLocationLable);
            this.Controls.Add(this.fileLocationBox);
            this.Controls.Add(this.mainLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.TextBox fileLocationBox;
        private System.Windows.Forms.Label fileLocationLable;
        private System.Windows.Forms.Button fileLocationButton;
        private System.Windows.Forms.TextBox numOfWinnersBox;
        private System.Windows.Forms.Label numOfWinnersLabel;
        private System.Windows.Forms.ListBox winnersBox;
        private System.Windows.Forms.Label winnersLabel;
        private System.Windows.Forms.Button clearBoxesButton;
        private System.Windows.Forms.Button generateWinnersButton;
        private System.Windows.Forms.Button clearWinnersButton;
        private System.Windows.Forms.Button clearWinnersBoxButton;
    }
}


using System.ComponentModel;

namespace Chess
{
    partial class PawnPromotionPicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblText = new System.Windows.Forms.Label();
            this.picQueen = new System.Windows.Forms.PictureBox();
            this.picKnight = new System.Windows.Forms.PictureBox();
            this.picBishop = new System.Windows.Forms.PictureBox();
            this.picRook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBishop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRook)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(120, 30);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(277, 23);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Pick a figure to replace pawn.";
            // 
            // picQueen
            // 
            this.picQueen.Image = global::Chess.Properties.Resources.blackQueen;
            this.picQueen.Location = new System.Drawing.Point(33, 134);
            this.picQueen.Name = "picQueen";
            this.picQueen.Size = new System.Drawing.Size(80, 80);
            this.picQueen.TabIndex = 1;
            this.picQueen.TabStop = false;
            this.picQueen.Click += new System.EventHandler(this.picQueen_Click);
            // 
            // picKnight
            // 
            this.picKnight.Image = global::Chess.Properties.Resources.blackQueen;
            this.picKnight.Location = new System.Drawing.Point(146, 134);
            this.picKnight.Name = "picKnight";
            this.picKnight.Size = new System.Drawing.Size(80, 80);
            this.picKnight.TabIndex = 2;
            this.picKnight.TabStop = false;
            this.picKnight.Click += new System.EventHandler(this.picKnight_Click);
            // 
            // picBishop
            // 
            this.picBishop.Image = global::Chess.Properties.Resources.blackQueen;
            this.picBishop.Location = new System.Drawing.Point(258, 134);
            this.picBishop.Name = "picBishop";
            this.picBishop.Size = new System.Drawing.Size(80, 80);
            this.picBishop.TabIndex = 3;
            this.picBishop.TabStop = false;
            this.picBishop.Click += new System.EventHandler(this.picBishop_Click);
            // 
            // picRook
            // 
            this.picRook.Image = global::Chess.Properties.Resources.blackQueen;
            this.picRook.Location = new System.Drawing.Point(376, 134);
            this.picRook.Name = "picRook";
            this.picRook.Size = new System.Drawing.Size(80, 80);
            this.picRook.TabIndex = 4;
            this.picRook.TabStop = false;
            this.picRook.Click += new System.EventHandler(this.picRook_Click);
            // 
            // PawnPromotionPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.picRook);
            this.Controls.Add(this.picBishop);
            this.Controls.Add(this.picKnight);
            this.Controls.Add(this.picQueen);
            this.Controls.Add(this.lblText);
            this.Name = "PawnPromotionPicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PawnPromotionPicker";
            ((System.ComponentModel.ISupportInitialize)(this.picQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBishop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRook)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblText;

        #endregion

        private System.Windows.Forms.PictureBox picQueen;
        private System.Windows.Forms.PictureBox picKnight;
        private System.Windows.Forms.PictureBox picBishop;
        private System.Windows.Forms.PictureBox picRook;
    }
}
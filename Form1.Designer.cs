namespace LBAHUBx
{
    partial class HUD
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
            this.hud1 = new LBAHUD.HUD();
            this.SuspendLayout();
            // 
            // hud1
            // 
            this.hud1.BackColor = System.Drawing.Color.MistyRose;
            this.hud1.Location = new System.Drawing.Point(1, 0);
            this.hud1.Name = "hud1";
            this.hud1.Size = new System.Drawing.Size(638, 20);
            this.hud1.TabIndex = 0;
            this.hud1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.hud1_MouseDown);
            // 
            // HUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 20);
            this.Controls.Add(this.hud1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HUD";
            this.ShowIcon = false;
            this.Text = "LBAHUD";
            this.ResumeLayout(false);

        }

        #endregion

        private LBAHUD.HUD hud1;
    }
}


namespace FinCodeUnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            movementTimer = new System.Windows.Forms.Timer(components);
            lblMovement = new Label();
            SuspendLayout();
            // 
            // movementTimer
            // 
            movementTimer.Enabled = true;
            movementTimer.Interval = 50;
            movementTimer.Tick += TimerEvent;
            // 
            // lblMovement
            // 
            lblMovement.AllowDrop = true;
            lblMovement.AutoSize = true;
            lblMovement.Location = new Point(54, 444);
            lblMovement.Name = "lblMovement";
            lblMovement.Size = new Size(0, 25);
            lblMovement.TabIndex = 0;
            lblMovement.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 1024);
            Controls.Add(lblMovement);
            Name = "Form1";
            Text = "Form1";
            Paint += FormPaintEvent;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer movementTimer;
        private Label lblMovement;
    }
}

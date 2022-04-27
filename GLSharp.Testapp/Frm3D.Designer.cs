namespace GLSharp.Testapp
{
    partial class Frm3D
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
            this.components = new System.ComponentModel.Container();
            this.tmFPS = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmFPS
            // 
            this.tmFPS.Enabled = true;
            this.tmFPS.Interval = 250;
            this.tmFPS.Tick += new System.EventHandler(this.tmFPS_Tick);
            // 
            // Frm3D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Frm3D";
            this.Text = "Frm3D";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmFPS;
    }
}
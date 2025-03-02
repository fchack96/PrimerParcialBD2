namespace CapaPresentacion
{
    partial class Formulario1
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
            this.iconBtn1 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // iconBtn1
            // 
            this.iconBtn1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtn1.IconColor = System.Drawing.Color.Black;
            this.iconBtn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtn1.Location = new System.Drawing.Point(458, 326);
            this.iconBtn1.Name = "iconBtn1";
            this.iconBtn1.Size = new System.Drawing.Size(75, 23);
            this.iconBtn1.TabIndex = 0;
            this.iconBtn1.Text = "Prueba";
            this.iconBtn1.UseVisualStyleBackColor = true;
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 540);
            this.ControlBox = false;
            this.Controls.Add(this.iconBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Formulario1";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconBtn1;
    }
}
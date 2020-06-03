namespace TrafficLights
{
    partial class TrafficLights
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
            this.redLight = new System.Windows.Forms.PictureBox();
            this.yellowLight = new System.Windows.Forms.PictureBox();
            this.greenLight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // redLight
            // 
            this.redLight.Location = new System.Drawing.Point(73, 54);
            this.redLight.Name = "redLight";
            this.redLight.Size = new System.Drawing.Size(115, 115);
            this.redLight.TabIndex = 0;
            this.redLight.TabStop = false;
            // 
            // yellowLight
            // 
            this.yellowLight.Location = new System.Drawing.Point(73, 175);
            this.yellowLight.Name = "yellowLight";
            this.yellowLight.Size = new System.Drawing.Size(115, 115);
            this.yellowLight.TabIndex = 1;
            this.yellowLight.TabStop = false;
            // 
            // greenLight
            // 
            this.greenLight.Location = new System.Drawing.Point(73, 296);
            this.greenLight.Name = "greenLight";
            this.greenLight.Size = new System.Drawing.Size(115, 115);
            this.greenLight.TabIndex = 2;
            this.greenLight.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 533);
            this.Controls.Add(this.greenLight);
            this.Controls.Add(this.yellowLight);
            this.Controls.Add(this.redLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redLight;
        private System.Windows.Forms.PictureBox yellowLight;
        private System.Windows.Forms.PictureBox greenLight;
    }
}


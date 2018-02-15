namespace Aquila_Constellation_
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
            this.AquilaT = new System.Windows.Forms.Label();
            this.MyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AquilaT
            // 
            this.AquilaT.AutoSize = true;
            this.AquilaT.Font = new System.Drawing.Font("Papyrus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AquilaT.Location = new System.Drawing.Point(200, 50);
            this.AquilaT.Name = "AquilaT";
            this.AquilaT.Size = new System.Drawing.Size(105, 42);
            this.AquilaT.TabIndex = 0;
            this.AquilaT.Text = "Aquila";
            // 
            // MyName
            // 
            this.MyName.AutoSize = true;
            this.MyName.Location = new System.Drawing.Point(106, 266);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(61, 13);
            this.MyName.TabIndex = 1;
            this.MyName.Text = "Kristi Huber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(493, 342);
            this.Controls.Add(this.MyName);
            this.Controls.Add(this.AquilaT);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AquilaT;
        private System.Windows.Forms.Label MyName;
    }
}


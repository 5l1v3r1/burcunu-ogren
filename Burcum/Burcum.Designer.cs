namespace Burcum
{
    partial class Burcum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Burcum));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnBurcOgren = new System.Windows.Forms.Button();
            this.lblburc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(75, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 26);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnBurcOgren
            // 
            this.btnBurcOgren.BackColor = System.Drawing.Color.Black;
            this.btnBurcOgren.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBurcOgren.ForeColor = System.Drawing.Color.White;
            this.btnBurcOgren.Location = new System.Drawing.Point(75, 90);
            this.btnBurcOgren.Name = "btnBurcOgren";
            this.btnBurcOgren.Size = new System.Drawing.Size(350, 36);
            this.btnBurcOgren.TabIndex = 1;
            this.btnBurcOgren.Text = "Burcumu Söyle";
            this.btnBurcOgren.UseVisualStyleBackColor = false;
            this.btnBurcOgren.Click += new System.EventHandler(this.btnBurcOgren_Click);
            // 
            // lblburc
            // 
            this.lblburc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblburc.ForeColor = System.Drawing.Color.White;
            this.lblburc.Location = new System.Drawing.Point(75, 167);
            this.lblburc.Name = "lblburc";
            this.lblburc.Size = new System.Drawing.Size(350, 31);
            this.lblburc.TabIndex = 2;
            this.lblburc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doğum Gününüz";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Burcum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(484, 237);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblburc);
            this.Controls.Add(this.btnBurcOgren);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Burcum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Burcum Ne ?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnBurcOgren;
        private System.Windows.Forms.Label lblburc;
        private System.Windows.Forms.Label label2;
    }
}


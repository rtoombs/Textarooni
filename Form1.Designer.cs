namespace TextProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.browse = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // browse
            // 
            this.browse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browse.Location = new System.Drawing.Point(14, 13);
            this.browse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(76, 32);
            this.browse.TabIndex = 0;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = false;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.SystemColors.ControlDark;
            this.go.Enabled = false;
            this.go.Location = new System.Drawing.Point(182, 12);
            this.go.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(76, 32);
            this.go.TabIndex = 1;
            this.go.Text = "Go!";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.AliceBlue;
            this.statusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.ForeColor = System.Drawing.Color.Green;
            this.statusBox.Location = new System.Drawing.Point(14, 52);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(244, 20);
            this.statusBox.TabIndex = 2;
            this.statusBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(270, 82);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.go);
            this.Controls.Add(this.browse);
            this.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Textarooni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.TextBox statusBox;
    }
}


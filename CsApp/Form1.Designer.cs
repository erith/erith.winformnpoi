namespace CsApp
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
            this.ct01 = new System.Windows.Forms.ComboBox();
            this.ct02 = new System.Windows.Forms.ComboBox();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ct01
            // 
            this.ct01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct01.FormattingEnabled = true;
            this.ct01.Location = new System.Drawing.Point(22, 24);
            this.ct01.Name = "ct01";
            this.ct01.Size = new System.Drawing.Size(193, 20);
            this.ct01.TabIndex = 0;
            this.ct01.SelectedIndexChanged += new System.EventHandler(this.ct01_SelectedIndexChanged);
            // 
            // ct02
            // 
            this.ct02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ct02.FormattingEnabled = true;
            this.ct02.Location = new System.Drawing.Point(240, 24);
            this.ct02.Name = "ct02";
            this.ct02.Size = new System.Drawing.Size(166, 20);
            this.ct02.TabIndex = 1;
            // 
            // tb01
            // 
            this.tb01.Location = new System.Drawing.Point(22, 62);
            this.tb01.Multiline = true;
            this.tb01.Name = "tb01";
            this.tb01.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb01.Size = new System.Drawing.Size(263, 338);
            this.tb01.TabIndex = 2;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(460, 433);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 3;
            this.btn_click.Text = "입력";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 468);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.tb01);
            this.Controls.Add(this.ct02);
            this.Controls.Add(this.ct01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ct01;
        private System.Windows.Forms.ComboBox ct02;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.Button btn_click;

    }
}


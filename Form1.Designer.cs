namespace Rabin_Encryption
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
            this.OpenfileBTN = new System.Windows.Forms.Button();
            this.InputTXTBX = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.EncBTN = new System.Windows.Forms.Button();
            this.ResultTXTBX = new System.Windows.Forms.RichTextBox();
            this.SavefileBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenfileBTN
            // 
            this.OpenfileBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OpenfileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenfileBTN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenfileBTN.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.OpenfileBTN.Location = new System.Drawing.Point(30, 33);
            this.OpenfileBTN.Name = "OpenfileBTN";
            this.OpenfileBTN.Size = new System.Drawing.Size(96, 77);
            this.OpenfileBTN.TabIndex = 0;
            this.OpenfileBTN.Text = "Open File";
            this.OpenfileBTN.UseVisualStyleBackColor = true;
            this.OpenfileBTN.Click += new System.EventHandler(this.OpenfileBTN_Click);
            // 
            // InputTXTBX
            // 
            this.InputTXTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.InputTXTBX.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTXTBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(20)))));
            this.InputTXTBX.Location = new System.Drawing.Point(142, 12);
            this.InputTXTBX.Name = "InputTXTBX";
            this.InputTXTBX.Size = new System.Drawing.Size(937, 142);
            this.InputTXTBX.TabIndex = 1;
            this.InputTXTBX.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EncBTN
            // 
            this.EncBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EncBTN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncBTN.ForeColor = System.Drawing.Color.Lime;
            this.EncBTN.Location = new System.Drawing.Point(487, 200);
            this.EncBTN.Name = "EncBTN";
            this.EncBTN.Size = new System.Drawing.Size(121, 42);
            this.EncBTN.TabIndex = 2;
            this.EncBTN.Text = "Encrypt";
            this.EncBTN.UseVisualStyleBackColor = true;
            this.EncBTN.Click += new System.EventHandler(this.EncBTN_Click);
            // 
            // ResultTXTBX
            // 
            this.ResultTXTBX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ResultTXTBX.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTXTBX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(190)))), ((int)(((byte)(20)))));
            this.ResultTXTBX.Location = new System.Drawing.Point(142, 286);
            this.ResultTXTBX.Name = "ResultTXTBX";
            this.ResultTXTBX.Size = new System.Drawing.Size(937, 142);
            this.ResultTXTBX.TabIndex = 3;
            this.ResultTXTBX.Text = "";
            // 
            // SavefileBTN
            // 
            this.SavefileBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.SavefileBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavefileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SavefileBTN.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavefileBTN.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.SavefileBTN.Location = new System.Drawing.Point(30, 326);
            this.SavefileBTN.Name = "SavefileBTN";
            this.SavefileBTN.Size = new System.Drawing.Size(96, 77);
            this.SavefileBTN.TabIndex = 4;
            this.SavefileBTN.Text = "Save File";
            this.SavefileBTN.UseVisualStyleBackColor = false;
            this.SavefileBTN.Click += new System.EventHandler(this.SavefileBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1091, 450);
            this.Controls.Add(this.SavefileBTN);
            this.Controls.Add(this.ResultTXTBX);
            this.Controls.Add(this.EncBTN);
            this.Controls.Add(this.InputTXTBX);
            this.Controls.Add(this.OpenfileBTN);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rabin Encryption";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenfileBTN;
        private System.Windows.Forms.RichTextBox InputTXTBX;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button EncBTN;
        private System.Windows.Forms.RichTextBox ResultTXTBX;
        private System.Windows.Forms.Button SavefileBTN;
    }
}


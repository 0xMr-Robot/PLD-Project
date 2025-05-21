namespace Gold_parser3
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
            textBox1 = new TextBox();
            Syntac = new ListBox();
            lexical = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 413);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Syntac
            // 
            Syntac.FormattingEnabled = true;
            Syntac.ItemHeight = 15;
            Syntac.Location = new Point(338, 23);
            Syntac.Name = "Syntac";
            Syntac.Size = new Size(450, 124);
            Syntac.TabIndex = 1;
            // 
            // lexical
            // 
            lexical.FormattingEnabled = true;
            lexical.ItemHeight = 15;
            lexical.Location = new Point(338, 172);
            lexical.Name = "lexical";
            lexical.Size = new Size(450, 259);
            lexical.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lexical);
            Controls.Add(Syntac);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox Syntac;
        private ListBox lexical;
    }
}

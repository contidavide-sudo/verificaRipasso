namespace verificaRipasso
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
            listDec = new ListBox();
            buttonDecifra = new Button();
            buttonInsert = new Button();
            SuspendLayout();
            // 
            // listDec
            // 
            listDec.FormattingEnabled = true;
            listDec.ItemHeight = 15;
            listDec.Location = new Point(77, 86);
            listDec.Name = "listDec";
            listDec.Size = new Size(242, 229);
            listDec.TabIndex = 0;
            // 
            // buttonDecifra
            // 
            buttonDecifra.Location = new Point(518, 86);
            buttonDecifra.Name = "buttonDecifra";
            buttonDecifra.Size = new Size(108, 78);
            buttonDecifra.TabIndex = 1;
            buttonDecifra.Text = "Decifra";
            buttonDecifra.UseVisualStyleBackColor = true;
            buttonDecifra.Click += buttonDecifra_Click;
            // 
            // buttonInsert
            // 
            buttonInsert.Location = new Point(518, 244);
            buttonInsert.Name = "buttonInsert";
            buttonInsert.Size = new Size(108, 71);
            buttonInsert.TabIndex = 2;
            buttonInsert.Text = "Inserisci nel file";
            buttonInsert.UseVisualStyleBackColor = true;
            buttonInsert.Click += buttonInsert_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonInsert);
            Controls.Add(buttonDecifra);
            Controls.Add(listDec);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listDec;
        private Button buttonDecifra;
        private Button buttonInsert;
    }
}

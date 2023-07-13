namespace OPCteste {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtEscrever = new TextBox();
            txtLer = new TextBox();
            btnEscrever = new Button();
            btnLer = new Button();
            SuspendLayout();
            // 
            // txtEscrever
            // 
            txtEscrever.Location = new Point(52, 53);
            txtEscrever.Name = "txtEscrever";
            txtEscrever.Size = new Size(276, 23);
            txtEscrever.TabIndex = 0;
            // 
            // txtLer
            // 
            txtLer.Location = new Point(52, 107);
            txtLer.Name = "txtLer";
            txtLer.Size = new Size(276, 23);
            txtLer.TabIndex = 1;
            // 
            // btnEscrever
            // 
            btnEscrever.Location = new Point(353, 53);
            btnEscrever.Name = "btnEscrever";
            btnEscrever.Size = new Size(75, 23);
            btnEscrever.TabIndex = 2;
            btnEscrever.Text = "Escrever";
            btnEscrever.UseVisualStyleBackColor = true;
            btnEscrever.Click += btnEscrever_Click;
            // 
            // btnLer
            // 
            btnLer.Location = new Point(353, 107);
            btnLer.Name = "btnLer";
            btnLer.Size = new Size(75, 23);
            btnLer.TabIndex = 3;
            btnLer.Text = "Ler";
            btnLer.UseVisualStyleBackColor = true;
            btnLer.Click += btnLer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 211);
            Controls.Add(btnLer);
            Controls.Add(btnEscrever);
            Controls.Add(txtLer);
            Controls.Add(txtEscrever);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEscrever;
        private TextBox txtLer;
        private Button btnEscrever;
        private Button btnLer;
    }
}
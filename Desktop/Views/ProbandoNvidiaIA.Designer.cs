namespace Desktop.Views
{
    partial class ProbandoNvidiaIA
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
            BotonENVIAR = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label2 = new Label();
            txtPrompt = new TextBox();
            txtRtaIa = new TextBox();
            SuspendLayout();
            // 
            // BotonENVIAR
            // 
            BotonENVIAR.BackgroundImage = Properties.Resources.NVIDIAimages;
            BotonENVIAR.Font = new Font("Segoe UI", 20F);
            BotonENVIAR.IconChar = FontAwesome.Sharp.IconChar.None;
            BotonENVIAR.IconColor = Color.Black;
            BotonENVIAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BotonENVIAR.ImageAlign = ContentAlignment.MiddleLeft;
            BotonENVIAR.Location = new Point(481, 79);
            BotonENVIAR.Name = "BotonENVIAR";
            BotonENVIAR.Size = new Size(147, 117);
            BotonENVIAR.TabIndex = 0;
            BotonENVIAR.UseVisualStyleBackColor = true;
            BotonENVIAR.Click += BotonENVIAR_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(119, 27);
            label1.Name = "label1";
            label1.Size = new Size(247, 35);
            label1.TabIndex = 1;
            label1.Text = "INTRODUZCA TEXTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(137, 145);
            label2.Name = "label2";
            label2.Size = new Size(244, 35);
            label2.TabIndex = 2;
            label2.Text = "RESPUESTA DE LA IA";
            // 
            // txtPrompt
            // 
            txtPrompt.Location = new Point(12, 79);
            txtPrompt.Name = "txtPrompt";
            txtPrompt.Size = new Size(354, 27);
            txtPrompt.TabIndex = 3;
            // 
            // txtRtaIa
            // 
            txtRtaIa.Location = new Point(27, 220);
            txtRtaIa.Multiline = true;
            txtRtaIa.Name = "txtRtaIa";
            txtRtaIa.Size = new Size(350, 200);
            txtRtaIa.TabIndex = 4;
            txtRtaIa.TextChanged += textBox2_TextChanged;
            // 
            // ProbandoNvidiaIA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRtaIa);
            Controls.Add(txtPrompt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BotonENVIAR);
            MaximizeBox = false;
            Name = "ProbandoNvidiaIA";
            Text = "Nvidia";
            Load += ProbandoNvidiaIA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BotonENVIAR;
        private Label label1;
        private Label label2;
        private TextBox txtPrompt;
        private TextBox txtRtaIa;
    }
}
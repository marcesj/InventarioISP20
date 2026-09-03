namespace Desktop.Views
{
    partial class ProbandoAI_Gemini
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
            textBox1Prompt = new TextBox();
            label1 = new Label();
            button1Send = new Button();
            textBox2RESPONSE = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1Prompt
            // 
            textBox1Prompt.Location = new Point(57, 41);
            textBox1Prompt.Name = "textBox1Prompt";
            textBox1Prompt.Size = new Size(292, 27);
            textBox1Prompt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 1;
            label1.Text = "PROMPT";
            // 
            // button1Send
            // 
            button1Send.Location = new Point(593, 41);
            button1Send.Name = "button1Send";
            button1Send.Size = new Size(94, 29);
            button1Send.TabIndex = 2;
            button1Send.Text = "SEND";
            button1Send.UseVisualStyleBackColor = true;
            button1Send.Click += button1Send_Click;
            // 
            // textBox2RESPONSE
            // 
            textBox2RESPONSE.Location = new Point(57, 130);
            textBox2RESPONSE.Multiline = true;
            textBox2RESPONSE.Name = "textBox2RESPONSE";
            textBox2RESPONSE.Size = new Size(630, 211);
            textBox2RESPONSE.TabIndex = 3;
            textBox2RESPONSE.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 107);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "RESPONSE";
            // 
            // ProbandoAI_Gemini
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2RESPONSE);
            Controls.Add(button1Send);
            Controls.Add(label1);
            Controls.Add(textBox1Prompt);
            Name = "ProbandoAI_Gemini";
            Text = "ProbandoAI_Gemini";
            Load += ProbandoAI_Gemini_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1Prompt;
        private Label label1;
        private Button button1Send;
        private TextBox textBox2RESPONSE;
        private Label label2;
    }
}
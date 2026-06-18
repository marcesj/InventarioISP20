namespace Desktop.Views
{
    partial class ArticulosView
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
            ListAlumnos = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // ListAlumnos
            // 
            ListAlumnos.FormattingEnabled = true;
            ListAlumnos.Location = new Point(152, 88);
            ListAlumnos.Name = "ListAlumnos";
            ListAlumnos.Size = new Size(200, 44);
            ListAlumnos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(190, 257);
            button1.Name = "button1";
            button1.Size = new Size(175, 64);
            button1.TabIndex = 1;
            button1.Text = "Agregar Alumno";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ArticulosView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ListAlumnos);
            Name = "ArticulosView";
            Text = "ArticulosView";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListAlumnos;
        private Button button1;
    }
}
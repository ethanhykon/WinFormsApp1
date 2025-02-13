namespace WinFormsApp1
{
    partial class Form2
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
            txt_modifnom = new TextBox();
            txt_modifmail = new TextBox();
            lbl_modifnom = new Label();
            lbl_modifmail = new Label();
            btn_modif = new Button();
            SuspendLayout();
            // 
            // txt_modifnom
            // 
            txt_modifnom.Location = new Point(90, 86);
            txt_modifnom.Name = "txt_modifnom";
            txt_modifnom.Size = new Size(208, 27);
            txt_modifnom.TabIndex = 0;
            // 
            // txt_modifmail
            // 
            txt_modifmail.Location = new Point(90, 173);
            txt_modifmail.Name = "txt_modifmail";
            txt_modifmail.Size = new Size(208, 27);
            txt_modifmail.TabIndex = 1;
            // 
            // lbl_modifnom
            // 
            lbl_modifnom.AutoSize = true;
            lbl_modifnom.Location = new Point(148, 63);
            lbl_modifnom.Name = "lbl_modifnom";
            lbl_modifnom.Size = new Size(99, 20);
            lbl_modifnom.TabIndex = 2;
            lbl_modifnom.Text = "nouveau nom";
            // 
            // lbl_modifmail
            // 
            lbl_modifmail.AutoSize = true;
            lbl_modifmail.Location = new Point(148, 150);
            lbl_modifmail.Name = "lbl_modifmail";
            lbl_modifmail.Size = new Size(98, 20);
            lbl_modifmail.TabIndex = 3;
            lbl_modifmail.Text = "nouveau mail";
            // 
            // btn_modif
            // 
            btn_modif.Location = new Point(90, 228);
            btn_modif.Name = "btn_modif";
            btn_modif.Size = new Size(208, 29);
            btn_modif.TabIndex = 4;
            btn_modif.Text = "modifier";
            btn_modif.UseVisualStyleBackColor = true;
            btn_modif.Click += btn_modif_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 269);
            Controls.Add(btn_modif);
            Controls.Add(lbl_modifmail);
            Controls.Add(lbl_modifnom);
            Controls.Add(txt_modifmail);
            Controls.Add(txt_modifnom);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_modifnom;
        private TextBox txt_modifmail;
        private Label lbl_modifnom;
        private Label lbl_modifmail;
        private Button btn_modif;
    }
}
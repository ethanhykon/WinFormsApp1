namespace WinFormsApp1
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
            btn_add_contact = new Button();
            txt_nom_prenom = new TextBox();
            lbl_nom_prenom = new Label();
            txt_email = new TextBox();
            lbl_email = new Label();
            grb_contact = new GroupBox();
            lbl_error = new Label();
            lbl_erormail = new Label();
            dataGridView1 = new DataGridView();
            nom = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            supprimer = new DataGridViewButtonColumn();
            grb_contact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_add_contact
            // 
            btn_add_contact.Location = new Point(30, 213);
            btn_add_contact.Name = "btn_add_contact";
            btn_add_contact.Size = new Size(162, 29);
            btn_add_contact.TabIndex = 0;
            btn_add_contact.Text = "A jouter un contact";
            btn_add_contact.UseVisualStyleBackColor = true;
            btn_add_contact.Click += btn_add_contact_Click;
            btn_add_contact.MouseHover += button1_MouseHover;
            // 
            // txt_nom_prenom
            // 
            txt_nom_prenom.Location = new Point(30, 76);
            txt_nom_prenom.Name = "txt_nom_prenom";
            txt_nom_prenom.Size = new Size(257, 27);
            txt_nom_prenom.TabIndex = 1;
            // 
            // lbl_nom_prenom
            // 
            lbl_nom_prenom.AutoSize = true;
            lbl_nom_prenom.Location = new Point(30, 53);
            lbl_nom_prenom.Name = "lbl_nom_prenom";
            lbl_nom_prenom.Size = new Size(97, 20);
            lbl_nom_prenom.TabIndex = 2;
            lbl_nom_prenom.Text = "nom-prénom";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(30, 153);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(257, 27);
            txt_email.TabIndex = 3;
            txt_email.TextChanged += txt_email_TextChanged_1;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(30, 130);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(46, 20);
            lbl_email.TabIndex = 4;
            lbl_email.Text = "Email";
            // 
            // grb_contact
            // 
            grb_contact.Controls.Add(lbl_error);
            grb_contact.Controls.Add(lbl_erormail);
            grb_contact.Controls.Add(txt_email);
            grb_contact.Controls.Add(btn_add_contact);
            grb_contact.Controls.Add(txt_nom_prenom);
            grb_contact.Controls.Add(lbl_nom_prenom);
            grb_contact.Controls.Add(lbl_email);
            grb_contact.Location = new Point(176, 32);
            grb_contact.Name = "grb_contact";
            grb_contact.Size = new Size(323, 305);
            grb_contact.TabIndex = 5;
            grb_contact.TabStop = false;
            grb_contact.Text = "ajout de contact";
            // 
            // lbl_error
            // 
            lbl_error.AutoSize = true;
            lbl_error.Location = new Point(30, 183);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(0, 20);
            lbl_error.TabIndex = 6;
            // 
            // lbl_erormail
            // 
            lbl_erormail.AutoSize = true;
            lbl_erormail.Location = new Point(29, 183);
            lbl_erormail.Name = "lbl_erormail";
            lbl_erormail.Size = new Size(0, 20);
            lbl_erormail.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nom, email, supprimer });
            dataGridView1.Location = new Point(555, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(576, 305);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nom
            // 
            nom.HeaderText = "nom/prénom";
            nom.MinimumWidth = 200;
            nom.Name = "nom";
            nom.Width = 200;
            // 
            // email
            // 
            email.HeaderText = "adresse email";
            email.MinimumWidth = 200;
            email.Name = "email";
            email.Width = 200;
            // 
            // supprimer
            // 
            supprimer.HeaderText = "supprimer";
            supprimer.MinimumWidth = 6;
            supprimer.Name = "supprimer";
            supprimer.Text = "supprimer";
            supprimer.ToolTipText = "supprimer";
            supprimer.UseColumnTextForButtonValue = true;
            supprimer.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 450);
            Controls.Add(dataGridView1);
            Controls.Add(grb_contact);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grb_contact.ResumeLayout(false);
            grb_contact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_add_contact;
        private TextBox txt_nom_prenom;
        private Label lbl_nom_prenom;
        private TextBox txt_email;
        private Label lbl_email;
        private GroupBox grb_contact;
        private Label lbl_erormail;
        private Label lbl_error;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nom;
        private DataGridViewTextBoxColumn email;
        private DataGridViewButtonColumn supprimer;
    }
}

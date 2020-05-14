namespace ExamenC.Interfaces
{
    partial class FRM_commande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlArticleSearch = new System.Windows.Forms.Panel();
            this.btnAddList = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtLibelleSearch = new System.Windows.Forms.TextBox();
            this.btnSearchProduit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtRefSearch = new System.Windows.Forms.TextBox();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtPrix = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlClientSearch = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtPrenomSearch = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtNomSearch = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTelSearch = new System.Windows.Forms.TextBox();
            this.dvgCategorie = new System.Windows.Forms.DataGridView();
            this.pnlCommande = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlArticleSearch.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.pnlClientSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategorie)).BeginInit();
            this.pnlCommande.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(588, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 57;
            this.label7.Text = "Total :";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 100.6656F;
            this.Column1.HeaderText = "Select";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 99.99321F;
            this.Column2.HeaderText = "Libelle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "QteCommande";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Prix";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Montant";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // pnlArticleSearch
            // 
            this.pnlArticleSearch.Controls.Add(this.btnAddList);
            this.pnlArticleSearch.Controls.Add(this.panel12);
            this.pnlArticleSearch.Controls.Add(this.textBox2);
            this.pnlArticleSearch.Controls.Add(this.panel13);
            this.pnlArticleSearch.Controls.Add(this.textBox5);
            this.pnlArticleSearch.Controls.Add(this.panel14);
            this.pnlArticleSearch.Controls.Add(this.txtLibelleSearch);
            this.pnlArticleSearch.Controls.Add(this.btnSearchProduit);
            this.pnlArticleSearch.Controls.Add(this.label13);
            this.pnlArticleSearch.Controls.Add(this.panel15);
            this.pnlArticleSearch.Controls.Add(this.txtRefSearch);
            this.pnlArticleSearch.Location = new System.Drawing.Point(33, 257);
            this.pnlArticleSearch.Name = "pnlArticleSearch";
            this.pnlArticleSearch.Size = new System.Drawing.Size(739, 147);
            this.pnlArticleSearch.TabIndex = 55;
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAddList.FlatAppearance.BorderSize = 0;
            this.btnAddList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddList.Location = new System.Drawing.Point(633, 104);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(88, 36);
            this.btnAddList.TabIndex = 77;
            this.btnAddList.Text = "Add";
            this.btnAddList.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkGray;
            this.panel12.Location = new System.Drawing.Point(405, 129);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(150, 1);
            this.panel12.TabIndex = 76;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.textBox2.Location = new System.Drawing.Point(405, 100);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 28);
            this.textBox2.TabIndex = 75;
            this.textBox2.Text = "QteCommande";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkGray;
            this.panel13.Location = new System.Drawing.Point(206, 127);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(162, 1);
            this.panel13.TabIndex = 73;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.textBox5.Location = new System.Drawing.Point(206, 100);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(162, 28);
            this.textBox5.TabIndex = 72;
            this.textBox5.Text = "QteStock";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkGray;
            this.panel14.Location = new System.Drawing.Point(15, 127);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(124, 1);
            this.panel14.TabIndex = 70;
            // 
            // txtLibelleSearch
            // 
            this.txtLibelleSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtLibelleSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLibelleSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelleSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.txtLibelleSearch.Location = new System.Drawing.Point(15, 100);
            this.txtLibelleSearch.Multiline = true;
            this.txtLibelleSearch.Name = "txtLibelleSearch";
            this.txtLibelleSearch.Size = new System.Drawing.Size(124, 28);
            this.txtLibelleSearch.TabIndex = 69;
            this.txtLibelleSearch.Text = "Libelle";
            // 
            // btnSearchProduit
            // 
            this.btnSearchProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearchProduit.FlatAppearance.BorderSize = 0;
            this.btnSearchProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchProduit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchProduit.Location = new System.Drawing.Point(360, 19);
            this.btnSearchProduit.Name = "btnSearchProduit";
            this.btnSearchProduit.Size = new System.Drawing.Size(90, 35);
            this.btnSearchProduit.TabIndex = 67;
            this.btnSearchProduit.Text = "Search";
            this.btnSearchProduit.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 24);
            this.label13.TabIndex = 66;
            this.label13.Text = "Référence";
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkGray;
            this.panel15.Location = new System.Drawing.Point(123, 50);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(127, 1);
            this.panel15.TabIndex = 65;
            // 
            // txtRefSearch
            // 
            this.txtRefSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtRefSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRefSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefSearch.Location = new System.Drawing.Point(123, 23);
            this.txtRefSearch.Multiline = true;
            this.txtRefSearch.Name = "txtRefSearch";
            this.txtRefSearch.Size = new System.Drawing.Size(127, 28);
            this.txtRefSearch.TabIndex = 64;
            // 
            // pnlClient
            // 
            this.pnlClient.Controls.Add(this.btnEnregistrer);
            this.pnlClient.Controls.Add(this.txtPrix);
            this.pnlClient.Controls.Add(this.panel6);
            this.pnlClient.Controls.Add(this.textPrix);
            this.pnlClient.Controls.Add(this.label5);
            this.pnlClient.Controls.Add(this.panel5);
            this.pnlClient.Controls.Add(this.txtStock);
            this.pnlClient.Controls.Add(this.label4);
            this.pnlClient.Controls.Add(this.panel4);
            this.pnlClient.Controls.Add(this.txtPrenom);
            this.pnlClient.Controls.Add(this.panel3);
            this.pnlClient.Controls.Add(this.txtNom);
            this.pnlClient.Controls.Add(this.label3);
            this.pnlClient.Controls.Add(this.label1);
            this.pnlClient.Location = new System.Drawing.Point(-214, -49);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(447, 549);
            this.pnlClient.TabIndex = 42;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEnregistrer.Location = new System.Drawing.Point(280, 428);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(125, 36);
            this.btnEnregistrer.TabIndex = 52;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            // 
            // txtPrix
            // 
            this.txtPrix.AutoSize = true;
            this.txtPrix.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(27, 365);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(80, 24);
            this.txtPrix.TabIndex = 50;
            this.txtPrix.Text = "Adresse";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkGray;
            this.panel6.Location = new System.Drawing.Point(147, 388);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 1);
            this.panel6.TabIndex = 49;
            // 
            // textPrix
            // 
            this.textPrix.BackColor = System.Drawing.SystemColors.Control;
            this.textPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrix.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrix.Location = new System.Drawing.Point(147, 361);
            this.textPrix.Multiline = true;
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(258, 28);
            this.textPrix.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Téléphone";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Location = new System.Drawing.Point(145, 308);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 1);
            this.panel5.TabIndex = 46;
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStock.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(145, 281);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(258, 28);
            this.txtStock.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 44;
            this.label4.Text = "Prenom";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGray;
            this.panel4.Location = new System.Drawing.Point(145, 221);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 1);
            this.panel4.TabIndex = 43;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(145, 194);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(258, 28);
            this.txtPrenom.TabIndex = 42;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(145, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 1);
            this.panel3.TabIndex = 41;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.SystemColors.Control;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(145, 116);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(258, 28);
            this.txtNom.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(123, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Enregistrement Client";
            // 
            // pnlClientSearch
            // 
            this.pnlClientSearch.Controls.Add(this.panel11);
            this.pnlClientSearch.Controls.Add(this.textBox4);
            this.pnlClientSearch.Controls.Add(this.panel10);
            this.pnlClientSearch.Controls.Add(this.txtPrenomSearch);
            this.pnlClientSearch.Controls.Add(this.panel9);
            this.pnlClientSearch.Controls.Add(this.txtNomSearch);
            this.pnlClientSearch.Controls.Add(this.btnSearchClient);
            this.pnlClientSearch.Controls.Add(this.label8);
            this.pnlClientSearch.Controls.Add(this.panel8);
            this.pnlClientSearch.Controls.Add(this.txtTelSearch);
            this.pnlClientSearch.Location = new System.Drawing.Point(33, 128);
            this.pnlClientSearch.Name = "pnlClientSearch";
            this.pnlClientSearch.Size = new System.Drawing.Size(739, 117);
            this.pnlClientSearch.TabIndex = 54;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkGray;
            this.panel11.Location = new System.Drawing.Point(559, 103);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(165, 1);
            this.panel11.TabIndex = 63;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.textBox4.Location = new System.Drawing.Point(559, 74);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 28);
            this.textBox4.TabIndex = 62;
            this.textBox4.Text = "Adresse";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkGray;
            this.panel10.Location = new System.Drawing.Point(304, 101);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(164, 1);
            this.panel10.TabIndex = 60;
            // 
            // txtPrenomSearch
            // 
            this.txtPrenomSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrenomSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenomSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenomSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.txtPrenomSearch.Location = new System.Drawing.Point(304, 74);
            this.txtPrenomSearch.Multiline = true;
            this.txtPrenomSearch.Name = "txtPrenomSearch";
            this.txtPrenomSearch.Size = new System.Drawing.Size(164, 28);
            this.txtPrenomSearch.TabIndex = 59;
            this.txtPrenomSearch.Text = "Prenom";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGray;
            this.panel9.Location = new System.Drawing.Point(15, 101);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(180, 1);
            this.panel9.TabIndex = 57;
            // 
            // txtNomSearch
            // 
            this.txtNomSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtNomSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(162)))), ((int)(((byte)(171)))));
            this.txtNomSearch.Location = new System.Drawing.Point(15, 74);
            this.txtNomSearch.Multiline = true;
            this.txtNomSearch.Name = "txtNomSearch";
            this.txtNomSearch.Size = new System.Drawing.Size(180, 28);
            this.txtNomSearch.TabIndex = 56;
            this.txtNomSearch.Text = "Nom";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnSearchClient.FlatAppearance.BorderSize = 0;
            this.btnSearchClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchClient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchClient.Location = new System.Drawing.Point(360, 15);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(90, 35);
            this.btnSearchClient.TabIndex = 54;
            this.btnSearchClient.Text = "Search";
            this.btnSearchClient.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "Téléphone";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkGray;
            this.panel8.Location = new System.Drawing.Point(129, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(127, 1);
            this.panel8.TabIndex = 49;
            // 
            // txtTelSearch
            // 
            this.txtTelSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelSearch.Location = new System.Drawing.Point(129, 6);
            this.txtTelSearch.Multiline = true;
            this.txtTelSearch.Name = "txtTelSearch";
            this.txtTelSearch.Size = new System.Drawing.Size(127, 28);
            this.txtTelSearch.TabIndex = 48;
            // 
            // dvgCategorie
            // 
            this.dvgCategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCategorie.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dvgCategorie.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCategorie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategorie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dvgCategorie.EnableHeadersVisualStyles = false;
            this.dvgCategorie.GridColor = System.Drawing.SystemColors.ControlText;
            this.dvgCategorie.Location = new System.Drawing.Point(33, 410);
            this.dvgCategorie.Name = "dvgCategorie";
            this.dvgCategorie.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgCategorie.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCategorie.Size = new System.Drawing.Size(739, 93);
            this.dvgCategorie.TabIndex = 56;
            // 
            // pnlCommande
            // 
            this.pnlCommande.Controls.Add(this.label7);
            this.pnlCommande.Controls.Add(this.dvgCategorie);
            this.pnlCommande.Controls.Add(this.pnlArticleSearch);
            this.pnlCommande.Controls.Add(this.pnlClientSearch);
            this.pnlCommande.Controls.Add(this.btnAdd);
            this.pnlCommande.Controls.Add(this.date);
            this.pnlCommande.Controls.Add(this.label2);
            this.pnlCommande.Controls.Add(this.panel2);
            this.pnlCommande.Controls.Add(this.txtNumero);
            this.pnlCommande.Controls.Add(this.label6);
            this.pnlCommande.Location = new System.Drawing.Point(239, -49);
            this.pnlCommande.Name = "pnlCommande";
            this.pnlCommande.Size = new System.Drawing.Size(775, 549);
            this.pnlCommande.TabIndex = 43;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(666, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 36);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // date
            // 
            this.date.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.date.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(119, 68);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(178, 20);
            this.date.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Date";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(117, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 1);
            this.panel2.TabIndex = 47;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(117, 15);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(180, 28);
            this.txtNumero.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Numéro";
            // 
            // FRM_commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.pnlCommande);
            this.Name = "FRM_commande";
            this.Text = "Form2";
            this.pnlArticleSearch.ResumeLayout(false);
            this.pnlArticleSearch.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.pnlClientSearch.ResumeLayout(false);
            this.pnlClientSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategorie)).EndInit();
            this.pnlCommande.ResumeLayout(false);
            this.pnlCommande.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel pnlArticleSearch;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtLibelleSearch;
        private System.Windows.Forms.Button btnSearchProduit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtRefSearch;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label txtPrix;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textPrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlClientSearch;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtPrenomSearch;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtNomSearch;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTelSearch;
        private System.Windows.Forms.DataGridView dvgCategorie;
        private System.Windows.Forms.Panel pnlCommande;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
    }
}
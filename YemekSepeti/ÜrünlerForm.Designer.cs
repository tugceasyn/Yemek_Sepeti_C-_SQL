
namespace YemekSepeti
{
    partial class ÜrünlerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1_kategori = new System.Windows.Forms.ComboBox();
            this.dataGridView_yemekler = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button4_refresh = new System.Windows.Forms.Button();
            this.button3_delete = new System.Windows.Forms.Button();
            this.button2_update = new System.Windows.Forms.Button();
            this.button1_add = new System.Windows.Forms.Button();
            this.comboBox_kategori = new System.Windows.Forms.ComboBox();
            this.label4_category = new System.Windows.Forms.Label();
            this.TextBox4_quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3_quantity = new System.Windows.Forms.Label();
            this.TextBox3_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2_price = new System.Windows.Forms.Label();
            this.TextBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1_name = new System.Windows.Forms.Label();
            this.TextBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label6_EXIT = new System.Windows.Forms.Label();
            this.button5_seller = new System.Windows.Forms.Button();
            this.button6_category = new System.Windows.Forms.Button();
            this.button7_selling = new System.Windows.Forms.Button();
            this.label_logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_yemekler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.comboBox1_kategori);
            this.panel1.Controls.Add(this.dataGridView_yemekler);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button4_refresh);
            this.panel1.Controls.Add(this.button3_delete);
            this.panel1.Controls.Add(this.button2_update);
            this.panel1.Controls.Add(this.button1_add);
            this.panel1.Controls.Add(this.comboBox_kategori);
            this.panel1.Controls.Add(this.label4_category);
            this.panel1.Controls.Add(this.TextBox4_quantity);
            this.panel1.Controls.Add(this.label3_quantity);
            this.panel1.Controls.Add(this.TextBox3_price);
            this.panel1.Controls.Add(this.label2_price);
            this.panel1.Controls.Add(this.TextBox_name);
            this.panel1.Controls.Add(this.label1_name);
            this.panel1.Controls.Add(this.TextBox_id);
            this.panel1.Controls.Add(this.label_ID);
            this.panel1.Location = new System.Drawing.Point(136, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 614);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1_kategori
            // 
            this.comboBox1_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1_kategori.FormattingEnabled = true;
            this.comboBox1_kategori.Location = new System.Drawing.Point(597, 53);
            this.comboBox1_kategori.Name = "comboBox1_kategori";
            this.comboBox1_kategori.Size = new System.Drawing.Size(178, 30);
            this.comboBox1_kategori.TabIndex = 29;
            this.comboBox1_kategori.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_kategori_SelectionChangeCommitted);
            // 
            // dataGridView_yemekler
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_yemekler.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_yemekler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_yemekler.ColumnHeadersHeight = 24;
            this.dataGridView_yemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_yemekler.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_yemekler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_yemekler.Location = new System.Drawing.Point(403, 120);
            this.dataGridView_yemekler.Name = "dataGridView_yemekler";
            this.dataGridView_yemekler.RowHeadersVisible = false;
            this.dataGridView_yemekler.RowHeadersWidth = 51;
            this.dataGridView_yemekler.RowTemplate.Height = 24;
            this.dataGridView_yemekler.Size = new System.Drawing.Size(559, 491);
            this.dataGridView_yemekler.TabIndex = 28;
            this.dataGridView_yemekler.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_yemekler.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_yemekler.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_yemekler.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_yemekler.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_yemekler.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_yemekler.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_yemekler.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_yemekler.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_yemekler.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView_yemekler.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_yemekler.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_yemekler.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_yemekler.ThemeStyle.ReadOnly = false;
            this.dataGridView_yemekler.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_yemekler.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_yemekler.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView_yemekler.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_yemekler.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_yemekler.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_yemekler.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_yemekler.Click += new System.EventHandler(this.dataGridView_yemekler_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(352, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "ÜRÜNLER BÖLÜMÜ";
            // 
            // button4_refresh
            // 
            this.button4_refresh.BackColor = System.Drawing.Color.Goldenrod;
            this.button4_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4_refresh.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4_refresh.Location = new System.Drawing.Point(817, 39);
            this.button4_refresh.Name = "button4_refresh";
            this.button4_refresh.Size = new System.Drawing.Size(98, 51);
            this.button4_refresh.TabIndex = 26;
            this.button4_refresh.Text = "Yenile";
            this.button4_refresh.UseVisualStyleBackColor = false;
            this.button4_refresh.Click += new System.EventHandler(this.button4_refresh_Click);
            // 
            // button3_delete
            // 
            this.button3_delete.BackColor = System.Drawing.Color.Goldenrod;
            this.button3_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3_delete.Location = new System.Drawing.Point(234, 381);
            this.button3_delete.Name = "button3_delete";
            this.button3_delete.Size = new System.Drawing.Size(107, 51);
            this.button3_delete.TabIndex = 22;
            this.button3_delete.Text = "Sil";
            this.button3_delete.UseVisualStyleBackColor = false;
            this.button3_delete.Click += new System.EventHandler(this.button3_delete_Click);
            // 
            // button2_update
            // 
            this.button2_update.BackColor = System.Drawing.Color.Goldenrod;
            this.button2_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2_update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2_update.Location = new System.Drawing.Point(118, 381);
            this.button2_update.Name = "button2_update";
            this.button2_update.Size = new System.Drawing.Size(110, 51);
            this.button2_update.TabIndex = 21;
            this.button2_update.Text = "Güncelle";
            this.button2_update.UseVisualStyleBackColor = false;
            this.button2_update.Click += new System.EventHandler(this.button2_update_Click);
            // 
            // button1_add
            // 
            this.button1_add.BackColor = System.Drawing.Color.Goldenrod;
            this.button1_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1_add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1_add.Location = new System.Drawing.Point(14, 381);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(98, 51);
            this.button1_add.TabIndex = 20;
            this.button1_add.Text = "Ekle";
            this.button1_add.UseVisualStyleBackColor = false;
            this.button1_add.Click += new System.EventHandler(this.button1_add_Click);
            // 
            // comboBox_kategori
            // 
            this.comboBox_kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_kategori.FormattingEnabled = true;
            this.comboBox_kategori.Location = new System.Drawing.Point(146, 300);
            this.comboBox_kategori.Name = "comboBox_kategori";
            this.comboBox_kategori.Size = new System.Drawing.Size(178, 30);
            this.comboBox_kategori.TabIndex = 19;
            // 
            // label4_category
            // 
            this.label4_category.AutoSize = true;
            this.label4_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4_category.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4_category.Location = new System.Drawing.Point(22, 305);
            this.label4_category.Name = "label4_category";
            this.label4_category.Size = new System.Drawing.Size(85, 20);
            this.label4_category.TabIndex = 18;
            this.label4_category.Text = "Kategori:";
            // 
            // TextBox4_quantity
            // 
            this.TextBox4_quantity.BorderRadius = 16;
            this.TextBox4_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox4_quantity.DefaultText = "";
            this.TextBox4_quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox4_quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox4_quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox4_quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox4_quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox4_quantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox4_quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox4_quantity.Location = new System.Drawing.Point(144, 241);
            this.TextBox4_quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox4_quantity.Name = "TextBox4_quantity";
            this.TextBox4_quantity.PasswordChar = '\0';
            this.TextBox4_quantity.PlaceholderText = "";
            this.TextBox4_quantity.SelectedText = "";
            this.TextBox4_quantity.Size = new System.Drawing.Size(180, 32);
            this.TextBox4_quantity.TabIndex = 17;
            // 
            // label3_quantity
            // 
            this.label3_quantity.AutoSize = true;
            this.label3_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3_quantity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3_quantity.Location = new System.Drawing.Point(22, 241);
            this.label3_quantity.Name = "label3_quantity";
            this.label3_quantity.Size = new System.Drawing.Size(53, 20);
            this.label3_quantity.TabIndex = 16;
            this.label3_quantity.Text = "Adet:";
            // 
            // TextBox3_price
            // 
            this.TextBox3_price.BorderRadius = 16;
            this.TextBox3_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox3_price.DefaultText = "";
            this.TextBox3_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox3_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox3_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox3_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox3_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox3_price.Location = new System.Drawing.Point(144, 177);
            this.TextBox3_price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox3_price.Name = "TextBox3_price";
            this.TextBox3_price.PasswordChar = '\0';
            this.TextBox3_price.PlaceholderText = "";
            this.TextBox3_price.SelectedText = "";
            this.TextBox3_price.Size = new System.Drawing.Size(180, 32);
            this.TextBox3_price.TabIndex = 15;
            // 
            // label2_price
            // 
            this.label2_price.AutoSize = true;
            this.label2_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2_price.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2_price.Location = new System.Drawing.Point(22, 177);
            this.label2_price.Name = "label2_price";
            this.label2_price.Size = new System.Drawing.Size(56, 20);
            this.label2_price.TabIndex = 14;
            this.label2_price.Text = "Fiyat:";
            // 
            // TextBox_name
            // 
            this.TextBox_name.BorderRadius = 16;
            this.TextBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_name.DefaultText = "";
            this.TextBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_name.Location = new System.Drawing.Point(144, 120);
            this.TextBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.PasswordChar = '\0';
            this.TextBox_name.PlaceholderText = "";
            this.TextBox_name.SelectedText = "";
            this.TextBox_name.Size = new System.Drawing.Size(180, 32);
            this.TextBox_name.TabIndex = 13;
            // 
            // label1_name
            // 
            this.label1_name.AutoSize = true;
            this.label1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1_name.Location = new System.Drawing.Point(25, 120);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(50, 20);
            this.label1_name.TabIndex = 12;
            this.label1_name.Text = "İsim:";
            // 
            // TextBox_id
            // 
            this.TextBox_id.BorderRadius = 16;
            this.TextBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_id.DefaultText = "";
            this.TextBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox_id.Location = new System.Drawing.Point(144, 58);
            this.TextBox_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_id.Name = "TextBox_id";
            this.TextBox_id.PasswordChar = '\0';
            this.TextBox_id.PlaceholderText = "";
            this.TextBox_id.SelectedText = "";
            this.TextBox_id.Size = new System.Drawing.Size(180, 32);
            this.TextBox_id.TabIndex = 11;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_ID.Location = new System.Drawing.Point(25, 63);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(28, 20);
            this.label_ID.TabIndex = 10;
            this.label_ID.Text = "ID";
            // 
            // label6_EXIT
            // 
            this.label6_EXIT.AutoSize = true;
            this.label6_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6_EXIT.Location = new System.Drawing.Point(1061, 9);
            this.label6_EXIT.Name = "label6_EXIT";
            this.label6_EXIT.Size = new System.Drawing.Size(27, 25);
            this.label6_EXIT.TabIndex = 9;
            this.label6_EXIT.Text = "X";
            this.label6_EXIT.Click += new System.EventHandler(this.label6_EXIT_Click);
            this.label6_EXIT.MouseEnter += new System.EventHandler(this.label6_EXIT_MouseEnter);
            this.label6_EXIT.MouseLeave += new System.EventHandler(this.label6_EXIT_MouseLeave);
            // 
            // button5_seller
            // 
            this.button5_seller.BackColor = System.Drawing.Color.Goldenrod;
            this.button5_seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5_seller.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5_seller.Location = new System.Drawing.Point(12, 100);
            this.button5_seller.Name = "button5_seller";
            this.button5_seller.Size = new System.Drawing.Size(118, 51);
            this.button5_seller.TabIndex = 27;
            this.button5_seller.Text = "Satıcı";
            this.button5_seller.UseVisualStyleBackColor = false;
            this.button5_seller.Click += new System.EventHandler(this.button5_seller_Click);
            // 
            // button6_category
            // 
            this.button6_category.BackColor = System.Drawing.Color.Goldenrod;
            this.button6_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6_category.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6_category.Location = new System.Drawing.Point(12, 171);
            this.button6_category.Name = "button6_category";
            this.button6_category.Size = new System.Drawing.Size(118, 51);
            this.button6_category.TabIndex = 28;
            this.button6_category.Text = "Kategori";
            this.button6_category.UseVisualStyleBackColor = false;
            this.button6_category.Click += new System.EventHandler(this.button6_category_Click);
            // 
            // button7_selling
            // 
            this.button7_selling.BackColor = System.Drawing.Color.Goldenrod;
            this.button7_selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7_selling.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7_selling.Location = new System.Drawing.Point(12, 247);
            this.button7_selling.Name = "button7_selling";
            this.button7_selling.Size = new System.Drawing.Size(118, 51);
            this.button7_selling.TabIndex = 29;
            this.button7_selling.Text = "Satışlar";
            this.button7_selling.UseVisualStyleBackColor = false;
            this.button7_selling.Click += new System.EventHandler(this.button7_selling_Click);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_logout.Location = new System.Drawing.Point(8, 610);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(86, 20);
            this.label_logout.TabIndex = 39;
            this.label_logout.Text = "LOGOUT";
            this.label_logout.Click += new System.EventHandler(this.label_logout_Click);
            this.label_logout.MouseEnter += new System.EventHandler(this.label_logout_MouseEnter);
            this.label_logout.MouseLeave += new System.EventHandler(this.label_logout_MouseLeave);
            // 
            // ÜrünlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.label_logout);
            this.Controls.Add(this.button7_selling);
            this.Controls.Add(this.button6_category);
            this.Controls.Add(this.button5_seller);
            this.Controls.Add(this.label6_EXIT);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ÜrünlerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_yemekler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6_EXIT;
        private System.Windows.Forms.Label label_ID;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4_refresh;
        private System.Windows.Forms.Button button3_delete;
        private System.Windows.Forms.Button button2_update;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.ComboBox comboBox_kategori;
        private System.Windows.Forms.Label label4_category;
        private Guna.UI2.WinForms.Guna2TextBox TextBox4_quantity;
        private System.Windows.Forms.Label label3_quantity;
        private Guna.UI2.WinForms.Guna2TextBox TextBox3_price;
        private System.Windows.Forms.Label label2_price;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_name;
        private System.Windows.Forms.Label label1_name;
        private System.Windows.Forms.Button button5_seller;
        private System.Windows.Forms.Button button6_category;
        private System.Windows.Forms.Button button7_selling;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_yemekler;
        private System.Windows.Forms.ComboBox comboBox1_kategori;
        private System.Windows.Forms.Label label_logout;
    }
}
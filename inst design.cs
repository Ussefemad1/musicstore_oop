using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;



namespace projectoop
{
    public partial class Instruments : Form
    {
        public Instruments()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=Instruments;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Instruments));
            panel1 = new Panel();
            instpic = new Guna.UI2.WinForms.Guna2DataGridView();
            instbrandtbl = new ComboBox();
            instcategtbl = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            instpricetbl = new TextBox();
            instqtytbl = new TextBox();
            button5 = new Button();
            button4 = new Button();
            brandsearch = new ComboBox();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            instnametbl = new TextBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((ISupportInitialize)instpic).BeginInit();
            guna2GradientPanel1.SuspendLayout();
            ((ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(instpic);
            panel1.Controls.Add(instbrandtbl);
            panel1.Controls.Add(instcategtbl);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(instpricetbl);
            panel1.Controls.Add(instqtytbl);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(brandsearch);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(instnametbl);
            panel1.Controls.Add(guna2GradientPanel1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1303, 880);
            panel1.TabIndex = 1;
            // 
            // instpic
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            instpic.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            instpic.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            instpic.ColumnHeadersHeight = 4;
            instpic.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            instpic.DefaultCellStyle = dataGridViewCellStyle3;
            instpic.GridColor = Color.FromArgb(231, 229, 255);
            instpic.Location = new Point(622, 279);
            instpic.Name = "instpic";
            instpic.RowHeadersVisible = false;
            instpic.RowHeadersWidth = 51;
            instpic.Size = new Size(667, 588);
            instpic.TabIndex = 32;
            instpic.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            instpic.ThemeStyle.AlternatingRowsStyle.Font = null;
            instpic.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            instpic.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            instpic.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            instpic.ThemeStyle.BackColor = Color.White;
            instpic.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            instpic.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            instpic.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            instpic.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            instpic.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            instpic.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            instpic.ThemeStyle.HeaderStyle.Height = 4;
            instpic.ThemeStyle.ReadOnly = false;
            instpic.ThemeStyle.RowsStyle.BackColor = Color.White;
            instpic.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            instpic.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            instpic.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            instpic.ThemeStyle.RowsStyle.Height = 29;
            instpic.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            instpic.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // instbrandtbl
            // 
            instbrandtbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instbrandtbl.FormattingEnabled = true;
            instbrandtbl.Location = new Point(0, 541);
            instbrandtbl.Name = "instbrandtbl";
            instbrandtbl.Size = new Size(197, 35);
            instbrandtbl.TabIndex = 31;
            // 
            // instcategtbl
            // 
            instcategtbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            instcategtbl.FormattingEnabled = true;
            instcategtbl.Location = new Point(-17, 415);
            instcategtbl.Name = "instcategtbl";
            instcategtbl.Size = new Size(197, 35);
            instcategtbl.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Plum;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(3, 478);
            label6.Name = "label6";
            label6.Size = new Size(78, 27);
            label6.TabIndex = 28;
            label6.Text = "brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Plum;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 345);
            label3.Name = "label3";
            label3.Size = new Size(114, 27);
            label3.TabIndex = 27;
            label3.Text = "category";
            // 
            // instpricetbl
            // 
            instpricetbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instpricetbl.Location = new Point(270, 416);
            instpricetbl.Multiline = true;
            instpricetbl.Name = "instpricetbl";
            instpricetbl.Size = new Size(197, 34);
            instpricetbl.TabIndex = 26;
            // 
            // instqtytbl
            // 
            instqtytbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instqtytbl.Location = new Point(270, 279);
            instqtytbl.Multiline = true;
            instqtytbl.Name = "instqtytbl";
            instqtytbl.Size = new Size(197, 34);
            instqtytbl.TabIndex = 25;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumVioletRed;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(1066, 205);
            button5.Name = "button5";
            button5.Size = new Size(173, 35);
            button5.TabIndex = 24;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumVioletRed;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(201, 689);
            button4.Name = "button4";
            button4.Size = new Size(160, 48);
            button4.TabIndex = 23;
            button4.Text = "back";
            button4.UseVisualStyleBackColor = false;
            // 
            // brandsearch
            // 
            brandsearch.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brandsearch.FormattingEnabled = true;
            brandsearch.Location = new Point(779, 205);
            brandsearch.Name = "brandsearch";
            brandsearch.Size = new Size(281, 35);
            brandsearch.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(622, 208);
            label8.Name = "label8";
            label8.Size = new Size(161, 27);
            label8.TabIndex = 21;
            label8.Text = "filter By Brand";
            // 
            // button3
            // 
            button3.BackColor = Color.MediumVioletRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(201, 620);
            button3.Name = "button3";
            button3.Size = new Size(160, 48);
            button3.TabIndex = 20;
            button3.Text = "edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumVioletRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(394, 620);
            button2.Name = "button2";
            button2.Size = new Size(160, 48);
            button2.TabIndex = 19;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumVioletRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 620);
            button1.Name = "button1";
            button1.Size = new Size(161, 46);
            button1.TabIndex = 18;
            button1.Text = "add";
            button1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Salmon;
            label7.Location = new Point(158, 128);
            label7.Name = "label7";
            label7.Size = new Size(340, 44);
            label7.TabIndex = 17;
            label7.Text = "instruments details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Plum;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(291, 217);
            label5.Name = "label5";
            label5.Size = new Size(103, 27);
            label5.TabIndex = 10;
            label5.Text = "quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Plum;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(291, 345);
            label4.Name = "label4";
            label4.Size = new Size(70, 27);
            label4.TabIndex = 9;
            label4.Text = "price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Plum;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 217);
            label2.Name = "label2";
            label2.Size = new Size(200, 27);
            label2.TabIndex = 7;
            label2.Text = "instrument name";
            // 
            // instnametbl
            // 
            instnametbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instnametbl.Location = new Point(3, 279);
            instnametbl.Multiline = true;
            instnametbl.Name = "instnametbl";
            instnametbl.Size = new Size(197, 34);
            instnametbl.TabIndex = 2;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(label1);
            guna2GradientPanel1.Controls.Add(pictureBox1);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.Dock = DockStyle.Top;
            guna2GradientPanel1.FillColor = Color.Plum;
            guna2GradientPanel1.Location = new Point(0, 0);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(1303, 125);
            guna2GradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Plum;
            label1.Font = new Font("Showcard Gothic", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Salmon;
            label1.Location = new Point(519, 39);
            label1.Name = "label1";
            label1.Size = new Size(264, 46);
            label1.TabIndex = 6;
            label1.Text = "music store";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Instruments
            // 
            ClientSize = new Size(1285, 833);
            Controls.Add(panel1);
            Name = "Instruments";
            Load += Instruments_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)instpic).EndInit();
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void instqtytbl_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Instruments_Load(object sender, EventArgs e)
        {

        }

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView instpic;
        private ComboBox instbrandtbl;
        private ComboBox instcategtbl;
        private Label label6;
        private Label label3;
        private TextBox instpricetbl;
        private TextBox instqtytbl;
        private Button button5;
        private Button button4;
        private ComboBox brandsearch;
        private Label label8;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox instnametbl;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Label label1;
        private PictureBox pictureBox1;

      
    }
}

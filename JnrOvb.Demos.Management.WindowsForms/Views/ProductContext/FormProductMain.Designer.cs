namespace JnrOvb.Demos.Management.WindowsForms.Views.ProductContext
{
    partial class FormProductMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.codeProduct = new System.Windows.Forms.ColumnHeader();
            this.nameProduct = new System.Windows.Forms.ColumnHeader();
            this.descriptionProduct = new System.Windows.Forms.ColumnHeader();
            this.quantityProduct = new System.Windows.Forms.ColumnHeader();
            this.productCreation = new System.Windows.Forms.ColumnHeader();
            this.productLastModified = new System.Windows.Forms.ColumnHeader();
            this.identifierProduct = new System.Windows.Forms.ColumnHeader();
            this.identifierCreatedBy = new System.Windows.Forms.ColumnHeader();
            this.identifierLastModifiedBy = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 25);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(206)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.listViewProducts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 618);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.buttonAddProduct);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBoxProductDescription);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxProductName);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(12, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 94);
            this.panel3.TabIndex = 8;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            this.buttonAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddProduct.FlatAppearance.BorderSize = 0;
            this.buttonAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddProduct.ForeColor = System.Drawing.Color.White;
            this.buttonAddProduct.Location = new System.Drawing.Point(600, 59);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(146, 23);
            this.buttonAddProduct.TabIndex = 7;
            this.buttonAddProduct.Text = "ADICIONAR PRODUTO";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.PostCreateProductAsync);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(219, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descrição";
            // 
            // textBoxProductDescription
            // 
            this.textBoxProductDescription.Location = new System.Drawing.Point(219, 30);
            this.textBoxProductDescription.MaxLength = 256;
            this.textBoxProductDescription.Name = "textBoxProductDescription";
            this.textBoxProductDescription.Size = new System.Drawing.Size(527, 23);
            this.textBoxProductDescription.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(13, 30);
            this.textBoxProductName.MaxLength = 64;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(200, 23);
            this.textBoxProductName.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(688, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Página Inicial";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.InitialTable);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 238);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.BackTable);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NextTable);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeProduct,
            this.nameProduct,
            this.descriptionProduct,
            this.quantityProduct,
            this.productCreation,
            this.productLastModified,
            this.identifierProduct,
            this.identifierCreatedBy,
            this.identifierLastModifiedBy});
            this.listViewProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewProducts.FullRowSelect = true;
            this.listViewProducts.GridLines = true;
            this.listViewProducts.Location = new System.Drawing.Point(12, 12);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(760, 220);
            this.listViewProducts.TabIndex = 0;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            this.listViewProducts.DoubleClick += new System.EventHandler(this.DoubleClickToViewInformationAboutProduct);
            // 
            // codeProduct
            // 
            this.codeProduct.Text = "Código";
            this.codeProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codeProduct.Width = 53;
            // 
            // nameProduct
            // 
            this.nameProduct.Text = "Nome do Produto";
            this.nameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameProduct.Width = 135;
            // 
            // descriptionProduct
            // 
            this.descriptionProduct.Text = "Descrição";
            this.descriptionProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.descriptionProduct.Width = 280;
            // 
            // quantityProduct
            // 
            this.quantityProduct.Text = "Estoque";
            this.quantityProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityProduct.Width = 100;
            // 
            // productCreation
            // 
            this.productCreation.Text = "Criado em";
            this.productCreation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productCreation.Width = 72;
            // 
            // productLastModified
            // 
            this.productLastModified.Text = "Última Modificação";
            this.productLastModified.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productLastModified.Width = 120;
            // 
            // identifierProduct
            // 
            this.identifierProduct.Text = "ProductIdentifier";
            this.identifierProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.identifierProduct.Width = 0;
            // 
            // identifierCreatedBy
            // 
            this.identifierCreatedBy.Text = "IdentifierCreatedBy";
            this.identifierCreatedBy.Width = 0;
            // 
            // identifierLastModifiedBy
            // 
            this.identifierLastModifiedBy.Text = "identifierLastModifiedBy";
            this.identifierLastModifiedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.identifierLastModifiedBy.Width = 0;
            // 
            // FormProductMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 643);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductMain";
            this.Text = "FormProductMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private ListView listViewProducts;
        private ColumnHeader nameProduct;
        private ColumnHeader codeProduct;
        private ColumnHeader descriptionProduct;
        private ColumnHeader quantityProduct;
        private ColumnHeader productCreation;
        private ColumnHeader productLastModified;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button button1;
        private ColumnHeader identifierProduct;
        private ColumnHeader identifierCreatedBy;
        private ColumnHeader identifierLastModifiedBy;
        private Panel panel3;
        private Button buttonAddProduct;
        private Label label4;
        private TextBox textBoxProductDescription;
        private Label label3;
        private TextBox textBoxProductName;
    }
}
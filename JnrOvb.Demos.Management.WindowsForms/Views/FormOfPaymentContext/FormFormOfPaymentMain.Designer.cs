namespace JnrOvb.Demos.Management.WindowsForms.Views.FormOfPaymentContext
{
    partial class FormFormOfPaymentMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFormOfPaymentMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.TabIndex = 1;
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
            this.label1.Text = "Gerenciamento de Formas de Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(21)))), ((int)(((byte)(18)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(48, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(688, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Página Inicial";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 257);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(742, 257);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.listViewProducts.Location = new System.Drawing.Point(12, 31);
            this.listViewProducts.MultiSelect = false;
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(760, 220);
            this.listViewProducts.TabIndex = 8;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
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
            // FormFormOfPaymentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFormOfPaymentMain";
            this.Text = "FormFormOfPaymentMain";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private ListView listViewProducts;
        private ColumnHeader codeProduct;
        private ColumnHeader nameProduct;
        private ColumnHeader descriptionProduct;
        private ColumnHeader quantityProduct;
        private ColumnHeader productCreation;
        private ColumnHeader productLastModified;
        private ColumnHeader identifierProduct;
        private ColumnHeader identifierCreatedBy;
        private ColumnHeader identifierLastModifiedBy;
    }
}
using System.Drawing;
namespace burakAydemirFinalProject
{
    partial class frmHandySupply
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandySupply));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lblBrowse = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblDetail = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.lblModelDisplay = new System.Windows.Forms.Label();
            this.lblSKUDisplay = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grpDescription = new System.Windows.Forms.GroupBox();
            this.lblEach = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnCloseCart = new System.Windows.Forms.Button();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalDisplay = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCart = new System.Windows.Forms.Button();
            this.pbItem = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.grpDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblCartCount
            // 
            this.lblCartCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCartCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCartCount.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCartCount.Location = new System.Drawing.Point(756, 34);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(23, 20);
            this.lblCartCount.TabIndex = 14;
            this.lblCartCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstCategory
            // 
            this.lstCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.lstCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCategory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategory.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 16;
            this.lstCategory.Location = new System.Drawing.Point(11, 60);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(139, 322);
            this.lstCategory.TabIndex = 2;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lblBrowse
            // 
            this.lblBrowse.BackColor = System.Drawing.Color.DarkGray;
            this.lblBrowse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowse.ForeColor = System.Drawing.Color.White;
            this.lblBrowse.Location = new System.Drawing.Point(11, 38);
            this.lblBrowse.Name = "lblBrowse";
            this.lblBrowse.Size = new System.Drawing.Size(139, 22);
            this.lblBrowse.TabIndex = 1;
            this.lblBrowse.Text = "Browse";
            this.lblBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMake
            // 
            this.lblMake.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(160, 59);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(222, 21);
            this.lblMake.TabIndex = 3;
            this.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(382, 62);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(59, 14);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "|  Model #";
            this.lblModel.Visible = false;
            // 
            // lblDetail
            // 
            this.lblDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail.Location = new System.Drawing.Point(160, 81);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(573, 21);
            this.lblDetail.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(404, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 40);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKU.Location = new System.Drawing.Point(539, 62);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(49, 14);
            this.lblSKU.TabIndex = 6;
            this.lblSKU.Text = "|  SKU #";
            this.lblSKU.Visible = false;
            // 
            // lblModelDisplay
            // 
            this.lblModelDisplay.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelDisplay.Location = new System.Drawing.Point(437, 59);
            this.lblModelDisplay.Name = "lblModelDisplay";
            this.lblModelDisplay.Size = new System.Drawing.Size(106, 20);
            this.lblModelDisplay.TabIndex = 5;
            this.lblModelDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSKUDisplay
            // 
            this.lblSKUDisplay.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSKUDisplay.Location = new System.Drawing.Point(584, 59);
            this.lblSKUDisplay.Name = "lblSKUDisplay";
            this.lblSKUDisplay.Size = new System.Drawing.Size(100, 20);
            this.lblSKUDisplay.TabIndex = 7;
            this.lblSKUDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(396, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 32);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD TO CART";
            this.toolTip1.SetToolTip(this.btnAdd, "Add selected item to cart");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(6, 19);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(374, 77);
            this.lblDescription.TabIndex = 0;
            // 
            // grpDescription
            // 
            this.grpDescription.Controls.Add(this.lblDescription);
            this.grpDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.grpDescription.Location = new System.Drawing.Point(163, 283);
            this.grpDescription.Name = "grpDescription";
            this.grpDescription.Size = new System.Drawing.Size(386, 99);
            this.grpDescription.TabIndex = 11;
            this.grpDescription.TabStop = false;
            this.grpDescription.Text = "Product Description";
            this.grpDescription.Visible = false;
            // 
            // lblEach
            // 
            this.lblEach.BackColor = System.Drawing.SystemColors.Window;
            this.lblEach.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEach.Location = new System.Drawing.Point(487, 149);
            this.lblEach.Name = "lblEach";
            this.lblEach.Size = new System.Drawing.Size(59, 23);
            this.lblEach.TabIndex = 10;
            this.lblEach.Text = " / each";
            this.lblEach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEach.Visible = false;
            // 
            // lstCart
            // 
            this.lstCart.BackColor = System.Drawing.Color.Gainsboro;
            this.lstCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(598, 86);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(187, 212);
            this.lstCart.TabIndex = 16;
            this.lstCart.Visible = false;
            // 
            // btnCloseCart
            // 
            this.btnCloseCart.BackColor = System.Drawing.Color.Firebrick;
            this.btnCloseCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseCart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCart.ForeColor = System.Drawing.Color.White;
            this.btnCloseCart.Location = new System.Drawing.Point(598, 320);
            this.btnCloseCart.Name = "btnCloseCart";
            this.btnCloseCart.Size = new System.Drawing.Size(187, 24);
            this.btnCloseCart.TabIndex = 19;
            this.btnCloseCart.Text = "CLOSE CART";
            this.toolTip1.SetToolTip(this.btnCloseCart, "Click to minimize cart");
            this.btnCloseCart.UseVisualStyleBackColor = false;
            this.btnCloseCart.Visible = false;
            this.btnCloseCart.Click += new System.EventHandler(this.btnCloseCart_Click);
            // 
            // lblCart
            // 
            this.lblCart.BackColor = System.Drawing.Color.DarkGray;
            this.lblCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCart.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.Color.White;
            this.lblCart.Location = new System.Drawing.Point(598, 64);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(187, 22);
            this.lblCart.TabIndex = 15;
            this.lblCart.Text = "Items In Cart";
            this.lblCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCart.Visible = false;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.DarkGray;
            this.lblSubtotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblSubtotal.Location = new System.Drawing.Point(598, 298);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(113, 22);
            this.lblSubtotal.TabIndex = 17;
            this.lblSubtotal.Text = "Subtotal . . . . . . ";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSubtotal.Visible = false;
            // 
            // lblSubtotalDisplay
            // 
            this.lblSubtotalDisplay.BackColor = System.Drawing.Color.DarkGray;
            this.lblSubtotalDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSubtotalDisplay.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalDisplay.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblSubtotalDisplay.Location = new System.Drawing.Point(711, 298);
            this.lblSubtotalDisplay.Name = "lblSubtotalDisplay";
            this.lblSubtotalDisplay.Size = new System.Drawing.Size(74, 22);
            this.lblSubtotalDisplay.TabIndex = 18;
            this.lblSubtotalDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSubtotalDisplay.Visible = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Firebrick;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckout.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(598, 344);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(187, 24);
            this.btnCheckout.TabIndex = 20;
            this.btnCheckout.Text = "CHECKOUT";
            this.toolTip1.SetToolTip(this.btnCheckout, "Proceed to checkout");
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Visible = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCart.Location = new System.Drawing.Point(691, 26);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(94, 36);
            this.btnCart.TabIndex = 13;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCart, "Click to expand cart");
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // pbItem
            // 
            this.pbItem.Location = new System.Drawing.Point(187, 102);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(173, 181);
            this.pbItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbItem.TabIndex = 5;
            this.pbItem.TabStop = false;
            this.toolTip1.SetToolTip(this.pbItem, "Click to enlarge image");
            this.pbItem.Click += new System.EventHandler(this.pbItem_Click);
            // 
            // frmHandySupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(795, 416);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblSubtotalDisplay);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.btnCloseCart);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.lblEach);
            this.Controls.Add(this.grpDescription);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSKUDisplay);
            this.Controls.Add(this.lblModelDisplay);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.pbItem);
            this.Controls.Add(this.lblBrowse);
            this.Controls.Add(this.lstCategory);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHandySupply";
            this.Text = "Handy Supply Co. - \"We come in handy\"";
            this.Load += new System.EventHandler(this.frmHandySupply_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.Label lblBrowse;
        private System.Windows.Forms.PictureBox pbItem;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.Label lblModelDisplay;
        private System.Windows.Forms.Label lblSKUDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox grpDescription;
        private System.Windows.Forms.Label lblEach;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnCloseCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalDisplay;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


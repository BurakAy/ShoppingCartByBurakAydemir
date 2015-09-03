using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burakAydemirFinalProject
{
    public partial class frmHandySupply : Form
    {
        Product[] inventory = new Product[17];
        decimal[] decBuy = new decimal[20];
        Image[] cartItem = new Image[20];
        int cartCount = 0;
        

        public frmHandySupply()
        {
            InitializeComponent();
        }

        private void frmHandySupply_Load(object sender, EventArgs e)
        {
            //Move lblCartCount to the front of btnCart so count is visible and not hidden behind the button
            lblCartCount.BringToFront();

            //Display the count of items in cart when form loads, should display 0
            lblCartCount.Text = cartCount.ToString();

            //Add categories to category list
            lstCategory.Items.Add("Cordless Drill");
            lstCategory.Items.Add("Studs");
            lstCategory.Items.Add("Screws");
            lstCategory.Items.Add("Cement Board");
            lstCategory.Items.Add("Thinset");
            lstCategory.Items.Add("Mesh Tape");
            lstCategory.Items.Add("Sump Pump");
            lstCategory.Items.Add("Pathway Light");
            lstCategory.Items.Add("Charcoal Grill");
            lstCategory.Items.Add("Push Mower");
            lstCategory.Items.Add("Garden Hose");
            lstCategory.Items.Add("Roller Covers");
            lstCategory.Items.Add("Paint Brushes");
            lstCategory.Items.Add("Garage Opener");
            lstCategory.Items.Add("Tool Chest");
            lstCategory.Items.Add("Wreath");
            lstCategory.Items.Add("Christmas Ornament");
            

            inventory[0] = new Product("Dewalt", "DCD771C2", "1000014677", "20-Volt Max Lithium-Ion Cordless Drill/Driver Kit", 99.00M, Image.FromFile("dewalt.jpg"), "Compact design fits into tight areas.\nTransmission offers 2-speed options.\nHighly rated high-powered motor");
            inventory[1] = new Product("Lumber Supply", "161640", "161640", "2 in. x 4 in. x 96 in. Premium Kiln-Dried Whitewood Stud", 2.72M, Image.FromFile("stud.jpg"), "Use for framing, houses, barns, sheds, and other structures.\nUse for any other small projects.\nInterior or Exterior Use");
            inventory[2] = new Product("Rock-On", "23320", "353046", "#9 x 2-1/4 in. Phillips High Low Threaded Wafer-Head Cement Board Screws", 8.33M, Image.FromFile("screws.jpg"), "(100-Pack)\nUse Rock-On screws for a variety of projects including bathtubs, showers, countertops and flooring applications.\nIdeal for attaching durock and wonderboard to wood and light gauge steel.");
            inventory[3] = new Product("Durock", "172965", "917647", "Next Gen 1/2 in. x 3 ft. x 5 ft. Cement Board", 9.78M, Image.FromFile("durock.jpg"), "Backerboard for ceramic tile and exterior finish systems.\nLightweight cement board.\nWater-durable, mold-resistant substrate for high-moisture areas.");
            inventory[4] = new Product("Custom Building Products", "FBG25", "731136", "FlexBond Gray 25 lb. Crack Prevention Mortar", 17.97M, Image.FromFile("thinset.jpg"), "For use with ceramic, metal and porcelain tile.\nFlexes up to 1/16 in. to prevent cracks.\nGreat bond strength.\nDries in as little as 24 hours.\nQualifies for a lifetime system warranty.");
            inventory[5] = new Product("FibaTape", "FDW8248-U", "483689", "300 ft. White Self-Adhesive Mesh Drywall Joint Tape", 6.45M, Image.FromFile("tape.jpg"), "Made of fiberglass mesh for strong drywall joints. It can also be used for repairing small holes. It resists cracking and accommodates a range of temperature- and humidity levels. It is easy to apply and will not blister or bubble.");
            inventory[6] = new Product("Basement Watchdog", "BW4000", "618637", "1/2 HP Big Combination Sump Pump System", 397.00M, Image.FromFile("sump.jpg"), "The primary system pumps 4,400 GPH at 0 ft. of lift and 3,200 GPH at 10 ft. of lift.\nThe backup system pumps 2,500 GPH at 0 ft. of lift and 1,730 GPH at 10 ft. of lift.");
            inventory[7] = new Product("Malibu", "8422-4110-01", "1000022987", "1-Light Dark Brown LED Jelly Jar Pathway Light", 29.97M, Image.FromFile("pathlight.jpg"), "The light is constructed of durable metal with a bronze finish. It features a modern maritime design, making it an attractive way to increase security. It can be used on a flat surface, strung throughout your garden, or hung from the included shepherd's hook.");
            inventory[8] = new Product("Weber", "14402001", "14402001", "Original Kettle Premium 22 in. Charcoal Grill in Copper", 149.00M, Image.FromFile("weber.jpg"), "Featuring 363 sq. in. of cooking space, the Weber One-Touch Gold 22-1/2 in. Charcoal Kettle Grill consists of heavy-gauge porcelain-enameled lid and bowl for durability and long grill life.");
            inventory[9] = new Product("Yard Machines", "11A-B9BG729", "204686138", "21 in. 190 cc Walk-Behind Gas Lawn Mower", 239.00M, Image.FromFile("mower.jpg"), "The powerful Briggs && Stratton engine delivers solid, efficient power to tackle the yard. This 21 in. Push Mower offers 6 cutting positions to cut grass down to size, with high rear wheels makes it ideal for use on uneven terrain.");
            inventory[10] = new Product("Goodyear Products", "20258074", "457712", "Premium 5/8 in. x 50 ft. Commercial Grade Black Rubber Water Hose", 29.97M, Image.FromFile("hose.jpg"), "The Goodyear 5/8 in. x 50 ft. Premium Commercial-Grade Rubber Water Hose is heavy-duty, kink-resistant and durable. It resists abrasion and won't degrade in sun or frost, making it ideal for any small to medium-sized landscape job. Reinforced for high burst strength.");
            inventory[11] = new Product("Linzer", "RS 1013", "716937", "9 in. x 3/8 in. White Woven Roller Covers (3-Pack)", 10.54M, Image.FromFile("rollers.jpg"), "Great value 3-pack of 9 in. professional quality woven rollers leave an ultra smooth finish. Recommended for use with all premium paints on drywall or plaster. 9 in. woven roller covers are ideal for larger projects such as painting your dining room, kitchen or porch.");
            inventory[12] = new Product("Linzer", "A1170-4", "703728", "All Paints Brush Set (4-Piece)", 16.76M, Image.FromFile("brushes.jpg"), "All Paints 4-Piece Brush Set feature wooden handles and plugs with polyester filaments. They feature rust and solvent-resistant ferrules. These brushes are great for most flat and satin paints and stains.");
            inventory[13] = new Product("Chamberlain", "HD520EV", "1000053031", "1/2 HP Belt Drive Garage Door Opener with MyQ Technology", 188.00M, Image.FromFile("opener.jpg"), "Chamberlain's Premium MyQ 1/2 HP Belt Drive Garage Door Opener is an all-purpose garage door opener. It has a steel reinforced belt for quiet, long-lasting performance. It includes two visor remotes and a keypad - perfect for the family on the go.");
            inventory[14] = new Product("Husky", "HOTC4609B1QBD", "763089", "46 in. 9-Drawer Mobile Workbench with Solid Wood Top", 239.00M, Image.FromFile("workbench.jpg"), "Steel construction with an industrial powder coated finish.\nSolid par wood top with protective coating.\nFull extension 75 lbs. rated ball bearing drawer slides on the top drawer, 50 lbs. rated ball bearing drawer slides on the other drawers.");
            inventory[15] = new Product("Holiday Decor", "10015", "1001189057", "28 in. Fraser Fir Decorated Wreath", 29.98M, Image.FromFile("wreath.jpg"), "Fraser Fir wreaths are a classic traditional wreath. Fresh and fragrant with Bluish green needles and natural cones. The needles have a silver white underside.");
            inventory[16] = new Product("Hallmark", "HPSRTH-2014", "HPSRTH-2014", "The Sorting Hat - Harry Potter - 2014 Hallmark Keepsake Ornament", 47.95M, Image.FromFile("harry.jpg"), "Hallmark 2014 The Sorting Hat Harry Potter Ornament will play dialogue from this scene when button is pushed.");
        }


        private void pbItem_Click(object sender, EventArgs e)
        {
            //Display larger image of item when clicked
            Image i = ((PictureBox)sender).Image;
            frmItemImage frm = new frmItemImage(i);
            frm.ShowDialog();
        }


        private void lstCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Populate fields with properties of item selected from category list
                pbItem.Image = inventory[lstCategory.SelectedIndex].Item;
                lblMake.Text = inventory[lstCategory.SelectedIndex].Make;
                lblModelDisplay.Text = inventory[lstCategory.SelectedIndex].Model;
                lblSKUDisplay.Text = inventory[lstCategory.SelectedIndex].SKU;
                lblDetail.Text = inventory[lstCategory.SelectedIndex].Type;
                lblPrice.Text = inventory[lstCategory.SelectedIndex].Price.ToString("C");
                lblDescription.Text = inventory[lstCategory.SelectedIndex].Description;

                //Display product and information when selected from category list
                lblModel.Visible = true;
                lblSKU.Visible = true;
                lblEach.Visible = true;
                grpDescription.Visible = true;
                btnAdd.Visible = true;

                //Hide cart when category list is clicked
                lblCart.Visible = false;
                lstCart.Visible = false;
                lblSubtotal.Visible = false;
                lblSubtotalDisplay.Visible = false;
                btnCloseCart.Visible = false;
                btnCheckout.Visible = false;
            }
            catch (IndexOutOfRangeException)
            {
                //Show error message if index is out of range
                MessageBox.Show("An error occurred", "ERROR");
            }         
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Concat item selected from list and price of item, add to cart list
            lstCart.Items.Add(lstCategory.SelectedItem + " " + inventory[lstCategory.SelectedIndex].Price.ToString("C"));

            decimal sum = 0.0M;
            int y = 20;

            //Keep count of images and prices in cart
            cartItem[cartCount] = inventory[lstCategory.SelectedIndex].Item;
            decBuy[cartCount++] = inventory[lstCategory.SelectedIndex].Price;
            
            //Display count of items in cart
            lblCartCount.Text = cartCount.ToString();

            //Calculate total of items in cart
            for (int i = 0; i < decBuy.Length; i++)
            {
               sum += decBuy[i];
            }

            //Display running total of items in cart
            lblSubtotalDisplay.Text = sum.ToString("C");
            
            //Disable Add button when cart is full (20) items, display message when full
            if (lstCart.Items.Count == y)
            {
               btnAdd.Enabled = false;
               MessageBox.Show("Your cart is full", "Full Cart");
            }      
        }


        private void btnCart_Click(object sender, EventArgs e)
        {
            //Display cart when cart is clicked
            lblCart.Visible = true;
            lstCart.Visible = true;
            lblSubtotal.Visible = true;
            lblSubtotalDisplay.Visible = true;
            btnCloseCart.Visible = true;
            btnCheckout.Visible = true;
        }


        private void btnCloseCart_Click(object sender, EventArgs e)
        {
            //Hide cart when close cart is clicked
            lblCart.Visible = false;
            lstCart.Visible = false;
            lblSubtotal.Visible = false;
            lblSubtotalDisplay.Visible = false;
            btnCloseCart.Visible = false;
            btnCheckout.Visible = false;
        }


        private void Checkout()
        {
            //Check to see if there are items in cart.  If so, allow checkout, show print preview
            if (lstCart.Items.Count == 0)
            {
                MessageBox.Show("You have no items in your cart", "Empty Cart");
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Call checkout
            Checkout();
        }


        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Call checkout when print preview selected from tool strip
            Checkout();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the form when exit selected from tool strip
            this.Close();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Variables for total calculations
            const decimal taxRate = .08M;
            decimal sum = 0.0M;
            decimal taxTotal = 0.0M;
            decimal grandTotal = 0.0M;
            
            //Loop through cart and sum up prices
            for (int i = 0; i < decBuy.Length; i++)
            {
                sum += decBuy[i];
            }

            //Calculate total tax charged and add to sum for grand total
            taxTotal = sum * taxRate;
            grandTotal = sum + taxTotal;

            //Set fonts, logo, and instance of item images
            Font headingFont = new Font("Calibri", 20);
            Font generalFont = new Font("Calibri", 15);
            Font listFont = new Font("Arial", 12);
            Bitmap bmp = new Bitmap("logo.png");
            Bitmap thumb;

            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            //Logo
            e.Graphics.DrawImage(bmp, 275, 10);

            x += 200;

            //Slogan below Logo
            e.Graphics.DrawString("''We Come in Handy''", headingFont, Brushes.Black, x, 160);

            y += headingFont.Height + 100;

            //Draw red line on invoice
            Pen redPen = new Pen(Color.Firebrick, 3);
            Point point1 = new Point(40, 200);
            Point point2 = new Point(800, 200);
            e.Graphics.DrawLine(redPen, point1, point2);

            //Concat "Invoice Date: " and today's date
            e.Graphics.DrawString("Invoice Date: " + DateTime.Today.ToShortDateString(), generalFont, Brushes.Black, 40, 205);

            //Loop through cart, add image, item, price
            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                x = e.MarginBounds.Left;
                y += 30;
                
                thumb = new Bitmap(cartItem[i], 70, 70);
                e.Graphics.DrawImage(thumb, x, y);

                x += thumb.Width + 10;
                y += 30;

                e.Graphics.DrawString(lstCart.Items[i].ToString(), listFont, Brushes.Black, x, y);
                y += listFont.Height + 20;               
            }

            //Variables for different calculation values
            string subTotal = "Subtotal: " + sum.ToString("C");
            string tax = "Tax rate: " + taxRate.ToString("P");
            string totalTax = "Tax: " + taxTotal.ToString("C");
            string total = "Your total: " + grandTotal.ToString("C");
            string message = "Thank you for shopping at Handy Supply Co.";
            
            x = 550;
            y += generalFont.Height;

            //Concat all calculation values and break into new lines for each
            e.Graphics.DrawString(subTotal + "\n" + tax + "\n" + totalTax + "\n" + total, generalFont, Brushes.Black, x, y);
            
            y += generalFont.Height + 53;

            //Thank you message
            e.Graphics.DrawString(message, generalFont, Brushes.Firebrick, e.MarginBounds.Left, y);
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display About form
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }


    }//end class
}

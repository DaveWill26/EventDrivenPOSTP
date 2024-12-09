    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;
using System.Data;




namespace POSSystem
{
    public partial class POS : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (int nLeft, int nTop, int nRight, int nBottom, int nWidthEllipse, int nHeightEllipse);

        public class OrderEntry
        {
            public string ItemName { get; set; }
            public string Size { get; set; }
            public List<string> AddOns { get; set; }
            public int Quantity { get; set; }
            public decimal Subtotal { get; set; }
            public decimal Discount { get; set; }
            public decimal VAT { get; set; }
            public decimal Total { get; set; }
        }
        public string selectedSize = "";
        public List<string> selectedAddOns = new List<string>();
        public string selectedSugarLevel = "";
        public int quantity = 1;
        public string itemName = "";
        public List<OrderEntry> orderEntries = new List<OrderEntry>();
        public POS()
        {
            InitializeComponent();
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            btn100Pesos.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn100Pesos.Width, btn100Pesos.Height, 30, 30));
            btn200Pesos.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn100Pesos.Width, btn100Pesos.Height, 30, 30));
            btn500Pesos.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn100Pesos.Width, btn100Pesos.Height, 30, 30));
            btn1000Pesos.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn100Pesos.Width, btn100Pesos.Height, 30, 30));

            this.MaximumSize = this.Size;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            AdminPanel.Visible = false;

            lblQty.Text = "1";
        }
        private void button19_Click(object sender, EventArgs e)
        { this.Close(); }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }
        private void button18_Click(object sender, EventArgs e)
        {
            Logout logoutForm = new Logout();
            logoutForm.Show();
        }
        private void btnMilkTea_Click(object sender, EventArgs e)
        { ShowPanel(panel1); panel6.Visible = true; }
        private void btnIcedCoffee_Click(object sender, EventArgs e)
        { ShowPanel(panel2); panel6.Visible = true; }
        private void btnFruitTea_Click(object sender, EventArgs e)
        { ShowPanel(panel3); panel6.Visible = true; }
        private void btnPraf_Click(object sender, EventArgs e)
        { ShowPanel(panel4); panel6.Visible = true; }
        private void btnHotBrew_Click(object sender, EventArgs e)
        { ShowPanel(panel5); panel6.Visible = true; }
        private void ShowPanel(Panel panelToShow)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            AdminPanel.Visible = false;

            panelToShow.Visible = true;
        }
        private void btnOkinawa_Click(object sender, EventArgs e)
        { itemName = "Okinawa"; }
        private void btnWintermelon_Click(object sender, EventArgs e)
        { itemName = "Winter Melon"; }
        private void btnRedVelvet_Click(object sender, EventArgs e)
        { itemName = "Red Velvet"; }
        private void btnMatcha_Click(object sender, EventArgs e)
        { itemName = "Matcha"; }
        private void btnDoubleDutch_Click(object sender, EventArgs e)
        { itemName = "Double Dutch"; }
        private void btnDarkChoco_Click(object sender, EventArgs e)
        { itemName = "Dark Choco"; }
        private void btnChocoKisses_Click(object sender, EventArgs e)
        { itemName = "Choco Kisses"; }
        private void btnCheeseCake_Click(object sender, EventArgs e)
        { itemName = "Cheese Cake"; }
        private void btnTaro_Click(object sender, EventArgs e)
        { itemName = "Taro"; }
        private void btnHoneyDue_Click(object sender, EventArgs e)
        { itemName = "Honey Due"; }
        private void btnBrownSugar_Click(object sender, EventArgs e)
        { itemName = "Brown Sugar"; }
        private void btnStrawberry_Click(object sender, EventArgs e)
        { itemName = "Strawberry Bubble"; }
        private void btnIcedEarlGray_Click(object sender, EventArgs e)
        { itemName = "Iced Earl Grey"; }
        private void btnLychee_Click(object sender, EventArgs e)
        { itemName = "Lychee Bubble"; }
        private void btnAlmond_Click(object sender, EventArgs e)
        { itemName = "Almond"; }
        private void btnJasmine_Click(object sender, EventArgs e)
        { itemName = "Jasmine"; }
        private void btnKapeBrusko_Click(object sender, EventArgs e)
        { itemName = "Ice Kape Brusko"; }
        private void btnMacch_Click(object sender, EventArgs e)
        { itemName = "Ice Maach"; }
        private void btnMoca_Click(object sender, EventArgs e)
        { itemName = "Ice Moca"; }
        private void btnVanilla_Click(object sender, EventArgs e)
        { itemName = "Ice Vanilla Latte"; }
        private void btnCaramel_Click(object sender, EventArgs e)
        { itemName = "Ice Caramel"; }
        private void btnHazelnut_Click(object sender, EventArgs e)
        { itemName = "Ice Hazelnut"; }
        private void btnCoconut_Click(object sender, EventArgs e)
        { itemName = "Ice Coconut"; }
        private void btnMaple_Click(object sender, EventArgs e)
        { itemName = "Ice Maple Syrup"; }
        private void btnLavender_Click(object sender, EventArgs e)
        { itemName = "Ice Lavender"; }
        private void btnPeanut_Click(object sender, EventArgs e)
        { itemName = "Ice Peanut Butter"; }
        private void btnChocoMint_Click(object sender, EventArgs e)
        { itemName = "Ice Chocolate Mint"; }
        private void btnMatchaLatte_Click(object sender, EventArgs e)
        { itemName = "Ice Matcha Latte"; }
        private void btnChaiLatte_Click(object sender, EventArgs e)
        { itemName = "Ice Chai Latte"; }
        private void btnAlmondMilk_Click(object sender, EventArgs e)
        { itemName = "Ice Almond Milk"; }
        private void btnPumpkin_Click(object sender, EventArgs e)
        { itemName = "Ice Pumpkin Spice"; }
        private void btnIrish_Click(object sender, EventArgs e)
        { itemName = "Ice Irish Cream"; }
        private void btnPeach_Click(object sender, EventArgs e)
        { itemName = "Peach Tea"; }
        private void btnMango_Click(object sender, EventArgs e)
        { itemName = "Mango Tea"; }
        private void btnStrawberryTea_Click(object sender, EventArgs e)
        { itemName = "Strawberry Tea"; }
        private void btnLemonTea_Click(object sender, EventArgs e)
        { itemName = "Lemon Tea"; }
        private void btnWatermelonTea_Click(object sender, EventArgs e)
        { itemName = "Watermelon Tea"; }
        private void btnBlueberry_Click(object sender, EventArgs e)
        { itemName = "Blueberry Tea"; }
        private void btnPineappleTea_Click(object sender, EventArgs e)
        { itemName = "Pineapple Tea"; }
        private void btnCherry_Click(object sender, EventArgs e)
        { itemName = "Cherry Tea"; }
        private void btnGrapefruit_Click(object sender, EventArgs e)
        { itemName = "Grapefruit Tea"; }
        private void btnApple_Click(object sender, EventArgs e)
        { itemName = "Apple Tea"; }
        private void btnLycheeTea_Click(object sender, EventArgs e)
        { itemName = "Lychee Tea"; }
        private void btnDragonFruit_Click(object sender, EventArgs e)
        { itemName = "Dragonfruit Tea"; }
        private void btnCranberry_Click(object sender, EventArgs e)
        { itemName = "Cranberry Tea"; }
        private void btnPomegranate_Click(object sender, EventArgs e)
        { itemName = "Pomegranate Tea"; }
        private void btnHoneyDew_Click(object sender, EventArgs e)
        { itemName = "Honey Dew Tea"; }
        private void btnCoconutTea_Click(object sender, EventArgs e)
        { itemName = "Coconut Tea"; }
        private void btnClassicCofee_Click(object sender, EventArgs e)
        { itemName = "Classic Coffee Frappe"; }
        private void btnMochaFrappe_Click(object sender, EventArgs e)
        { itemName = "Mocha Frappe"; }
        private void btnCaramelFrappe_Click(object sender, EventArgs e)
        { itemName = "Caramel Frappe"; }
        private void btnVanillaFrappe_Click(object sender, EventArgs e)
        { itemName = "Vanilla Frappe"; }
        private void btnHazelnutFrappe_Click(object sender, EventArgs e)
        { itemName = "Hazelnut Frappe"; }
        private void btnChocoloateFrappe_Click(object sender, EventArgs e)
        { itemName = "Chocolate Frappe"; }
        private void btnCookiesAndCream_Click(object sender, EventArgs e)
        { itemName = "Cookies and Cream Frappe"; }
        private void btnPeanutButterFrappe_Click(object sender, EventArgs e)
        { itemName = "Peanut Butter Frappe"; }
        private void btnCoconutFrappe_Click(object sender, EventArgs e)
        { itemName = "Coconut Frappe"; }
        private void btnPumpkinSpice_Click(object sender, EventArgs e)
        { itemName = "Pumpkin Spice Frappe"; }
        private void btnChaiLatteFrappe_Click(object sender, EventArgs e)
        { itemName = "Chai Latte Frappe"; }
        private void btnMachaGreenTea_Click(object sender, EventArgs e)
        { itemName = "Macha Green Tea Frappe"; }
        private void btnToffeeNut_Click(object sender, EventArgs e)
        { itemName = "Toffee Nut Frappe"; }
        private void btnStrawberryFrappe_Click(object sender, EventArgs e)
        { itemName = "Strawberry Frappe"; }
        private void btnBananaMochaFrappe_Click(object sender, EventArgs e)
        { itemName = "Banana Mocha Frappe"; }
        private void btnRedVelvetFrappe_Click(object sender, EventArgs e)
        { itemName = "Red Velvet Frappe"; }
        private void btnCaramelMacchiato_Click(object sender, EventArgs e)
        { itemName = "Caramel Macchiato Hot Brew"; }
        private void btnHazelnutHotBrew_Click(object sender, EventArgs e)
        { itemName = "Hazelnut Hot Brew"; }
        private void btnCinnamonDolceLatte_Click(object sender, EventArgs e)
        { itemName = "Cinnamon Dolce Latte"; }
        private void btnToastedMarshmallow_Click(object sender, EventArgs e)
        { itemName = "Toasted Marshmalllow"; }
        private void btnMaplePecanLatte_Click(object sender, EventArgs e)
        { itemName = "Maple Pecan Latte"; }
        private void btnHoneyAlmondLatte_Click(object sender, EventArgs e)
        { itemName = "Honey Almond Latte"; }
        private void btnSaltedCaramelLatte_Click(object sender, EventArgs e)
        { itemName = "Salted Caramel Latte"; }
        private void btnGingerbreadLatte_Click(object sender, EventArgs e)
        { itemName = "Ginger Bread Latte"; }
        private void btnBrownSugarOathMilk_Click(object sender, EventArgs e)
        { itemName = "Brown Sugar Oath Milk"; }
        private void btnMexicanMocha_Click(object sender, EventArgs e)
        { itemName = "Mexican Mocha"; }
        private void btnAlmondJoy_Click(object sender, EventArgs e)
        { itemName = "Almond Joy"; }
        private void btnCoconutMochaLatte_Click(object sender, EventArgs e)
        { itemName = "Coconut Mocha Latte"; }
        private void btnLavenderLatteHot_Click(object sender, EventArgs e)
        { itemName = "Lavender Latte Hot Brew"; }
        private void btnIrishCreamLatte_Click(object sender, EventArgs e)
        { itemName = "Irish Cream Latte Hot Brew"; }
        private void btnChaiLatteHot_Click(object sender, EventArgs e)
        { itemName = "Chai Latte Hot Brew"; }
        private void btnClassicMocha_Click(object sender, EventArgs e)
        { itemName = "Classic Mocha Hot Brew"; }
        public void btnQtyLess_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity--;
                lblQty.Text = quantity.ToString();
            }
        }
        public void btnHigh_Click(object sender, EventArgs e)
        { quantity++;
            lblQty.Text = quantity.ToString(); }
        private void btnSmall_Click(object sender, EventArgs e)
        { selectedSize = "Small"; }
        private void btnMedium_Click(object sender, EventArgs e)
        { selectedSize = "Medium"; }
        private void btnLarge_Click(object sender, EventArgs e)
        { selectedSize = "Large"; }
        private void btnPearl_Click(object sender, EventArgs e)
        { ToggleAddOn("Pearl"); }
        private void btnCrystal_Click(object sender, EventArgs e)
        { ToggleAddOn("Crystal"); }
        private void btnCreamCheese_Click(object sender, EventArgs e)
        { ToggleAddOn("Cream Cheese"); }
        private void btnCoffeeJelly_Click(object sender, EventArgs e)
        { ToggleAddOn("Coffee Jelly"); }
        private void btnCrushedOreo_Click(object sender, EventArgs e)
        { ToggleAddOn("Crushed Oreo"); }
        private void btnCreamPuff_Click(object sender, EventArgs e)
        { ToggleAddOn("Cream Puff"); }
        private void btnCakeCheese_Click(object sender, EventArgs e)
        { ToggleAddOn("Cheese Cake"); }
        private void btn25_Click(object sender, EventArgs e)
        { selectedSugarLevel = "25%"; }
        private void btn50_Click(object sender, EventArgs e)
        { selectedSugarLevel = "50%"; }
        private void btn75_Click(object sender, EventArgs e)
        { selectedSugarLevel = "75%"; }
        private void btn100_Click(object sender, EventArgs e)
        { selectedSugarLevel = "100%"; }
        private void ToggleAddOn(string addOn)
        {
            if (selectedAddOns.Contains(addOn))
            { selectedAddOns.Remove(addOn); }
            else
            { selectedAddOns.Add(addOn); }
        }
        private decimal runningSubtotal = 0.00M;
        private decimal runningDiscount = 0.00M;
        private decimal runningSubtotalAfterDiscount = 0.00M;
        private decimal runningVAT = 0.00M;
        public decimal runningTotal = 0.00M;

        public void btnConfirm1_Click(object sender, EventArgs e)
        {
            decimal basePrice = 0.00M;
            if (itemPrices.ContainsKey(itemName) && itemPrices[itemName].ContainsKey(selectedSize))
            { basePrice = itemPrices[itemName][selectedSize]; }
            decimal addOnsPrice = selectedAddOns.Sum(addOn => addOnPrices.ContainsKey(addOn) ? addOnPrices[addOn] : 0.00M);

            decimal subtotal = (basePrice + addOnsPrice) * quantity;

            decimal discount = 0.00M;
            decimal subtotalAfterDiscount = subtotal - discount;

            decimal vat = subtotalAfterDiscount * 0.12M;

            decimal total = subtotalAfterDiscount;

            var newEntry = new OrderEntry
            { ItemName = itemName,
                Size = selectedSize,
                AddOns = new List<string>(selectedAddOns),
                Quantity = quantity,
                Subtotal = subtotal,
                Discount = discount,
                VAT = vat,
                Total = total };

            orderEntries.Add(newEntry);
            runningSubtotal += subtotal;
            runningDiscount += discount;
            runningSubtotalAfterDiscount += subtotalAfterDiscount;
            runningVAT += vat;
            runningTotal += total;

            string addOns = selectedAddOns.Any() ? string.Join(", ", selectedAddOns) : "None";
            string itemDetails = $"Item:  {itemName}\n" +
                                 $"Quantity: {quantity}\n" +
                                 $"Size: {selectedSize}\n" +
                                 $"Add-ons: {addOns}\n" +
                                 $"Sugar Level: {selectedSugarLevel}\n";

            lblItem1.Text += itemDetails + "\n";

            UpdateSummary();
            ResetSelections();
        }

        public void UpdateSummary()
        {
            lblSummary.Text = $"Subtotal: {runningSubtotal:C}\n" +
                              $"VAT: {runningVAT:C}\n" +
                              $"Total: {runningTotal:C}\n\n";
        }
        public void btnCancel1_Click(object sender, EventArgs e)
        { ResetSelections();
            lblItem1.Text = string.Empty; }
        public void ResetSelections()
        {
            selectedSize = "";
            selectedAddOns.Clear();
            selectedSugarLevel = "";
            quantity = 1;
            lblQty.Text = "1";
        }
        public void btnDelete1_Click(object sender, EventArgs e)
        {
            if (orderEntries.Count > 0)
            {
                var lastEntry = orderEntries.Last();

                runningSubtotal -= lastEntry.Subtotal;
                runningDiscount -= lastEntry.Discount;
                runningSubtotalAfterDiscount -= lastEntry.Subtotal - lastEntry.Discount;
                runningVAT -= lastEntry.VAT;
                runningTotal -= lastEntry.Total;

                orderEntries.Remove(lastEntry);

                string currentText = lblItem1.Text;
                string[] entries = currentText.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
                lblItem1.Text = string.Join("\n\n", entries.Take(entries.Length - 1));

                UpdateSummary();
            }
            else
            {
                MessageBox.Show("No items to delete.");
            }
        }
        private Dictionary<string, Dictionary<string, decimal>> itemPrices = new Dictionary<string, Dictionary<string, decimal>>()
            {
                { "Okinawa", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M }, { "Large", 130.00M } } },
                { "Winter Melon", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M }, { "Large", 140.00M } } },
                { "Red Velvet", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Matcha", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Double Dutch", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Dark Choco", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Choco Kisses", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Cheese Cake", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Taro", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Honey Due", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Brown Sugar", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Strawberry Bubble", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Iced Earl Grey", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Lychee Bubble", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Almond", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Jasmine", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Ice Kape Brusko", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Maach", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Moca", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Vanilla Latte", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Caramel", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Ice Hazelnut", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 150.00M} } },
                { "Ice Coconut", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 150.00M} } },
                { "Ice Maple Syrup", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 150.00M} } },
                { "Ice Lavender", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M }, { "Large", 130.00M } } },
                { "Ice Peanut Butter", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M }, { "Large", 140.00M } } },
                { "Ice Chocolate Mint", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Matcha Latte", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Chai Latte", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Almond Milk", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Pumpkin Spice", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Ice Irish Cream", new Dictionary<string, decimal> { { "Small", 100.00M }, { "Medium", 120.00M}, { "Large", 140.00M} } },
                { "Peach Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Mango Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Strawberry Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Lemon Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Watermelon Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Blueberry Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Pineapple Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Cherry Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Grapefruit Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Apple Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Lychee Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Dragonfruit Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Cranberry Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Pomegranate Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Honey Dew Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Coconut Tea", new Dictionary<string, decimal> { { "Small", 80.00M }, { "Medium", 100.00M}, { "Large", 120.00M} } },
                { "Classic Coffee Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Mocha Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Caramel Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Vanilla Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Hazelnut Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Chocolate Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Cookies and Cream Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Peanut Butter Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Coconut Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Pumpkin Spice Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Chai Latte Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Macha Green Tea Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Toffee Nut Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Strawberry Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Banana Mocha Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Red Velvet Frappe", new Dictionary<string, decimal> { { "Small", 90.00M }, { "Medium", 110.00M}, { "Large", 130.00M} } },
                { "Caramel Macchiato Hot Brew", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Hazelnut Hot Brew", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Cinnamon Dolce Latte", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Toasted Marshmalllow", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Maple Pecan Latte", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Honey Almond Latte", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Salted Caramel Latte", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Ginger Bread Latte", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Brown Sugar Oath Milk", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Mexican Mocha", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Almond Joy", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Coconut Mocha Latte", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Lavender Latte Hot Brew", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Irish Cream Latte Hot Brew", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Chai Latte Hot Brew", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } },
                { "Classic Mocha Hot Brew", new Dictionary<string, decimal> { { "Small", 110.00M }, { "Medium", 130.00M}, { "Large", 150.00M} } }

            };
        private Dictionary<string, decimal> addOnPrices = new Dictionary<string, decimal>()
            {
                { "Pearl", 20.00M },
                { "Crystal", 25.00M },
                { "Cream Cheese", 30.00M },
                { "Coffee Jelly", 25.00M },
                { "Crushed Oreo", 30.00M },
                { "Cream Puff", 30.00M },
                { "Cheese Cake", 35.00M }
            };
        private void ShowAllPanels()
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
        }
        private void btnPOS_Click(object sender, EventArgs e)
        { ShowAllPanels(); }
        private void btnProceedPayment1_Click(object sender, EventArgs e)
        {

            panel7.Visible = true;
            panel6.Visible = false;
            panel1.Visible = panel1.Visible;
            panel2.Visible = panel2.Visible;
            panel3.Visible = panel3.Visible;
            panel4.Visible = panel4.Visible;
            panel5.Visible = panel5.Visible;

        }
        private void btnCash_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = panel1.Visible;
            panel2.Visible = panel2.Visible;
            panel3.Visible = panel3.Visible;
            panel4.Visible = panel4.Visible;
            panel5.Visible = panel5.Visible;

        }
        private void btnCancelPayment_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel6.Visible = true;
            panel1.Visible = panel1.Visible;
            panel2.Visible = panel2.Visible;
            panel3.Visible = panel3.Visible;
            panel4.Visible = panel4.Visible;
            panel5.Visible = panel5.Visible;
        }
        decimal totalAmount1 = 0.0m;
        private void UpdateAmount(decimal amount)
        {
            totalAmount1 += amount;
            txtExactAmount.Text = totalAmount1.ToString("F2");
        }
        private void btn100Pesos_Click(object sender, EventArgs e)
        { UpdateAmount(100.00m); }
        private void btn200Pesos_Click(object sender, EventArgs e)
        { UpdateAmount(200.00m); }
        private void btn500Pesos_Click(object sender, EventArgs e)
        { UpdateAmount(500.00m); }
        private void btn1000Pesos_Click(object sender, EventArgs e)
        { UpdateAmount(1000.00m); }
        private void btnCancel2_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = true;
            panel1.Visible = panel1.Visible;
            panel2.Visible = panel2.Visible;
            panel3.Visible = panel3.Visible;
            panel4.Visible = panel4.Visible;
            panel5.Visible = panel5.Visible;
        }
        private void btnConfirm2_Click(object sender, EventArgs e)
        {
            decimal change;

            change = runningTotal - Convert.ToDecimal(txtExactAmount.Text);

            MessageBox.Show($"Change: {change:C2}");
        }

        private void btnCashless_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
            panel8.Visible = false;
            panel7.Visible = false;
            panel6.Visible = false;
            panel1.Visible = panel1.Visible;
            panel2.Visible = panel2.Visible;
            panel3.Visible = panel3.Visible;
            panel4.Visible = panel4.Visible;
            panel5.Visible = panel5.Visible;
        }



        private void btnGcash_Click(object sender, EventArgs e)
        { GCashQRCode qrCode = new GCashQRCode();
            this.Hide();
            qrCode.Show(); }

        private void btnPaymaya_Click(object sender, EventArgs e)
        { PayMaya payMaya = new PayMaya();
            this.Hide();
            payMaya.Show(); }

        private void btnPaypal_Click(object sender, EventArgs e)
        { PayPal payPal = new PayPal();
            this.Hide();
            payPal.Show(); }

        private void btnMasterCard_Click(object sender, EventArgs e)
        {
            MasterCard masterCard = new MasterCard();
            this.Hide();
            masterCard.Show();
        }
        public void ClearPanel6()
        {
            panel6.Controls.Clear(); // Clear the controls in Panel6
        }

        private void btnCancelPayment3_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
            panel6.Visible = true;
            panel1.Visible = panel1.Visible;
            panel2.Visible = panel2.Visible;
            panel3.Visible = panel3.Visible;
            panel4.Visible = panel4.Visible;
            panel5.Visible = panel5.Visible;
        }

        private void btnConfirmPayment4_Click(object sender, EventArgs e)
        {
            ConfirmationWindow confirmation = new ConfirmationWindow();
            confirmation.Show();
            this.Hide();
        }

        private void btnADM_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAuthentication authForm = new AdminAuthentication(this);
            if (authForm.ShowDialog() == DialogResult.OK)
            {
                AdminPanel.Visible = true;

                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
                panel5.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                panel8.Visible = false;
                panel9.Visible = false;
                this.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void btnPOS_Click_1(object sender, EventArgs e)
        {
            POS pos1 = new POS();
            pos1.Show();
            this.Hide();
        }

       
        private void btnIMS_Click(object sender, EventArgs e)
        {            
                                  
        }
    }    
}
    

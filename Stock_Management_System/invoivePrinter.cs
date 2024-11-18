using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;


namespace Stock_Management_System
{
    internal class invoivePrinter : InvoiceCreate
    {
        private PrintDocument printDocument;

        public void AskAndPrintInvoice()
        {
            DialogResult result = MessageBox.Show("Do you want to print the invoice?", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Printed Invoice Successfully");
                printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(PrintInvoices);
                printDocument.Print(); // Initiates the printing process
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Successfully Saved Invoice");
            }
          
        }

        private void PrintInvoice(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Sample invoice content
            string invoiceTitle = "Invoice";
            string invoiceDetails = "Product: Example Product\nQuantity: 2\nUnit Price: $50\nTotal: $100";
            Font font = new Font("Arial", 12);
            float yPosition = 20;

            // Print title
            graphics.DrawString(invoiceTitle, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, 20, yPosition);
            yPosition += 40;

            // Print details
            graphics.DrawString(invoiceDetails, font, Brushes.Black, 20, yPosition);
        }


        private void PrintInvoices(object sender, PrintPageEventArgs e)
        {
            InvoiceCreate invoiceCreate = new InvoiceCreate();

            Graphics graphics = e.Graphics;
            Font font = new Font("Arial", 10);
            float yPosition = 20;
            float xMargin = 20;

            // Print Header
            graphics.DrawString("INVOICE", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, xMargin, yPosition);
            yPosition += 40;

            // Print Customer Details
            graphics.DrawString($"Customer Name: {invoiceCreate.comboxBillTo.TextTransform}", font, Brushes.Black, xMargin, yPosition);
            yPosition += 20;
            graphics.DrawString($"Invoice Number: {invoiceCreate.txtInvoNo.Text}", font, Brushes.Black, xMargin, yPosition);
            yPosition += 20;
            graphics.DrawString($"Date: {invoiceCreate.invoDate.Value}", font, Brushes.Black, xMargin, yPosition);
            yPosition += 40;

            // Print Table Header
            graphics.DrawString("Product", font, Brushes.Black, xMargin, yPosition);
            graphics.DrawString("Quantity", font, Brushes.Black, xMargin + 150, yPosition);
            graphics.DrawString("Unit Price", font, Brushes.Black, xMargin + 250, yPosition);
            graphics.DrawString("Total", font, Brushes.Black, xMargin + 350, yPosition);
            yPosition += 20;

            // Print Product Details from DataGridView
            foreach (DataGridViewRow row in invoiceCreate.dgvSaleInvoice.Rows)
            {
                if (row.Cells["Item_Name"].Value != null)
                {
                    graphics.DrawString(row.Cells["Item_Name"].Value.ToString(), font, Brushes.Black, xMargin, yPosition);
                    graphics.DrawString(row.Cells["Item_Discription"].Value.ToString(), font, Brushes.Black, xMargin + 150, yPosition);
                    graphics.DrawString(row.Cells["Item_Cost"].Value.ToString(), font, Brushes.Black, xMargin + 250, yPosition);
                    graphics.DrawString(row.Cells["total_price"].Value.ToString(), font, Brushes.Black, xMargin + 350, yPosition);
                    yPosition += 20;
                }
            }
        }
    }
}

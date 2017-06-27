//Libraries
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PDF_Automation
{
    public partial class FrmPDFAutomation : Form
    {
        public FrmPDFAutomation() { InitializeComponent(); }

        //Code for "Generate PDF" button
        private void BtnGeneratePDF_Click(object sender, EventArgs e)
        {
            //Check limit to retrive records
            if (txtFrom.Text.Trim().Length == 0 && txtTo.Text.Trim().Length == 0)
            { MessageBox.Show("Please Enter Range of Records!!"); }
            else
            {
                //Variables 
                MySqlConnection connection; //connection object to connect with MySQL database

                //Database credentials
                string server = "localhost";
                string database = "sakila";
                string usename = "root";
                string password = "root";

                //Connection string
                string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + usename + ";" + "PASSWORD=" + password + ";";

                try
                {
                    //Input from user - Record limits
                    int from = Convert.ToInt32(txtFrom.Text);
                    int to = Convert.ToInt32(txtTo.Text);

                    //SQL Query to retrive data from SAKILA database (CUSTOMER table)
                    string query = "SELECT customer_id, first_name, last_name, email FROM customer where customer_id between " + from + " and " + to + "";

                    //Create a list to store the result
                    List<string>[] list = new List<string>[4];
                    list[0] = new List<string>();
                    list[1] = new List<string>();
                    list[2] = new List<string>();
                    list[3] = new List<string>();
                    
                    //Variables to create PDF document
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, new FileStream(@"MySQL_to_PDF_table.pdf", FileMode.Create)); //Output PDF file
                    PdfPTable table = new PdfPTable(4); //To create table inside the PDF

                    //Width of each column on table
                    float[] widths = { 70f, 110f, 110f, 300f };
                    table.SetWidthPercentage(widths, PageSize.A4);

                    //Font settings
                    Font titleFont = FontFactory.GetFont("Verdana");
                    titleFont.SetStyle("bold");

                    //Connect with MySQL database
                    using (connection = new MySqlConnection(connectionString))
                    {
                        connection.Open(); //Access SAKILA database

                        //Prepare SQL query to retrive data
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        doc.Open(); //Access the PDF Document to write data

                        //Add table column headers
                        table.AddCell(new Paragraph("Record ID", titleFont));
                        table.AddCell(new Paragraph("First Name", titleFont));
                        table.AddCell(new Paragraph("Last Name", titleFont));
                        table.AddCell(new Paragraph("Email ID", titleFont));

                        //Read the data and store them in the list
                        while (dataReader.Read())
                        {
                            //read data using DataReader
                            string value1 = dataReader["customer_id"].ToString();
                            string value2 = dataReader["first_name"].ToString();
                            string value3 = dataReader["last_name"].ToString();
                            string value4 = dataReader["email"].ToString();

                            //Add data to table
                            table.AddCell(value1);
                            table.AddCell(value2);
                            table.AddCell(value3);
                            table.AddCell(value4);
                        }

                        //Close the DataReader
                        dataReader.Close();

                        //Close database connection
                        connection.Close();
                    }

                    //Add data to PDF file
                    doc.Add(new Paragraph("MySQL Database to PDF Table using iText Library\n\n", titleFont));
                    doc.Add(table);
                    doc.Add(new Paragraph("\nCopyright 2017 @ http://howtocodefor.website", titleFont));

                    //Close PDF document
                    doc.Close();

                    //Open the Output file
                    Process.Start(@"MySQL_to_PDF_table.pdf");

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }
    }
}



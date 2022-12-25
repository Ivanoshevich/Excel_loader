using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace excel_loader_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'excel_ds.Financial_Data' table. You can move, or remove it, as needed.
            // this.financial_DataTableAdapter.Fill(this.excel_ds.Financial_Data);
            this.progress_panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fname;
                string fn;
                //------------------------------
                this.openFileDialog1.ShowDialog();
                fname = this.openFileDialog1.FileName;
                if (fname == "openFileDialog1")
                {
                    MessageBox.Show("Please select your file if you want to convert it!");
                    return;
                }
                else
                {
                    fn = fname;
                }
               
                this.loading_label2.Text = "Loading Excel Data...";
                this.progress_panel2.Visible = true;
                this.progressBar1.Minimum = 0;
                this.progressBar1.Value = 0;
                //---------------------
                this.prog_label3.Text = "---";
                //---------------------
                Application.DoEvents();
                //------------------------
                
                //fn = Application.StartupPath + "\\Data\\Financial_Sample.xlsx";
                SpreadsheetLight.SLDocument ss;
                ss = new SpreadsheetLight.SLDocument(fn);
                //---------- load data----------------------
                ss.SelectWorksheet("Sheet1");

                string r;
                int rt;
                rt = 0;
                //---------clear existing data inside datatable-------
                this.excel_ds.Financial_Data.Clear();

                Int32 row_count;

                row_count = ss.GetWorksheetStatistics().EndRowIndex;
                //-------------------
                this.progressBar1.Maximum = row_count + 1;
                this.prog_label3.Text = "0 of " + row_count.ToString();
                //-------------------
                for (int ri = 2; ri <= row_count; ri++)
                {
                    //===================add new record and assign the value to them =======================
                    this.financial_DataBindingSource.AddNew();
                    //----------- add new data----------------
                    r = ss.GetCellValueAsString(ri, 1);
                    this.segmentTextBox.Text = r;
                    //----------------
                    r = ss.GetCellValueAsString(ri, 2);
                    this.countryTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 3);
                    this.productTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 4);
                    this.discount_BandTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 5);
                    this.units_SoldTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 6);
                    this.manufacturing_PriceTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 7);
                    this.sale_PriceTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 8);
                    this.gross_SalesTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 9);
                    this.discountsTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 10);
                    this.salesTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 11);
                    this.cOGSTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 12);
                    this.profitTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsDateTime(ri, 13).ToString("dd/MM/yyyy");
                    this.dateeTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 14);
                    this.month_NumberTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 15);
                    this.month_NameTextBox.Text = r;
                    //---------------
                    r = ss.GetCellValueAsString(ri, 16);
                    this.yearrTextBox.Text = r;
                    //----------------------------------------
                    //===============add data to my datable ====================================================== 
                    if (this.segmentTextBox.Text == "" && this.countryTextBox.Text == "" && this.productTextBox.Text == "")
                    {
                        this.financial_DataBindingSource.CancelEdit();
                    }
                    else
                    {
                        this.financial_DataBindingSource.EndEdit();
                        this.excel_ds.Financial_Data.AcceptChanges();
                    }

                    //============================================================================================
                    rt = rt + 1;
                    if (rt > 10)
                    {
                        Application.DoEvents();
                        rt = 0;
                    }
                    //--------------------------------------------------
                    this.progressBar1.Value = this.progressBar1.Value + 1;
                    this.prog_label3.Text = this.progressBar1.Value.ToString() + " of " + row_count.ToString();
                    //--------------------------------------------------
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

               //---------------------------------
                this.progress_panel2.Visible = false;
                Application.DoEvents();
                //------------------------
          
        }

        private void financial_DataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           this.Validate();
           this.financial_DataBindingSource.EndEdit();
           this.tableAdapterManager.UpdateAll(this.excel_ds);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.financial_DataTableAdapter.Fill(this.excel_ds.Financial_Data);
        }

        private void new_recored_button3_Click(object sender, EventArgs e)
        {
            this.financial_DataBindingSource.AddNew();
            //----------- add new data----------------
            this.segmentTextBox.Text = "Government";
            this.countryTextBox.Text = "USA";
            this.productTextBox.Text = "VTT";
            this.discount_BandTextBox.Text = "Low";
            this.units_SoldTextBox.Text = "2966.05";
            this.manufacturing_PriceTextBox.Text = "3802.5";
            this.sale_PriceTextBox.Text = "350.200";
            this.gross_SalesTextBox.Text = "1207500";
            this.discountsTextBox.Text = "1207500";
            this.salesTextBox.Text = "1159200";
            this.cOGSTextBox.Text = "897000";
            this.profitTextBox.Text = "262200";
            this.dateeTextBox.Text = "7/1/2014";
            this.month_NumberTextBox.Text = "12";
            this.month_NameTextBox.Text = "May";
            this.yearrTextBox.Text = "2019";
            //----------------------------------------
        }

        private void button3_Click(object sender, EventArgs e)
        {   
           this.financial_DataBindingSource.EndEdit();
           this.excel_ds.Financial_Data.AcceptChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             this.financial_DataBindingSource.CancelEdit();
            //////this.financial_DataBindingSource.EndEdit();
            //////this.excel_ds.Financial_Data.RejectChanges();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.excel_ds.Financial_Data.Rows[0].SetAdded();
            this.financial_DataTableAdapter.Update(this.excel_ds.Financial_Data);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                //this.excel_ds.Financial_Data.Rows[0].SetAdded();
                //this.financial_DataTableAdapter.Update(this.excel_ds.Financial_Data);
                //-------------------------------------
                this.loading_label2.Text = "Saving in SQL Server...";
                this.progress_panel2.Visible = true;
                this.progressBar1.Minimum = 0;
                this.progressBar1.Value = 0;
                //---------------------
                this.prog_label3.Text = "---";
                //---------------------
                Application.DoEvents();
                //------------------------
                Int32 ri;
                ri = 0;
                Int32 row_count;
                row_count = this.excel_ds.Financial_Data.Rows.Count;
                ////row_count = 5;

                int rt;
                rt = 0;
                //-------------------
                this.progressBar1.Maximum = row_count + 1;
                this.prog_label3.Text = "0 of " + row_count.ToString();
                //-------------------
                for (ri = 0; ri < row_count; ri++)
                {
                    this.excel_ds.Financial_Data.Rows[ri].SetAdded();
                    this.financial_DataTableAdapter.Update(this.excel_ds.Financial_Data);
                    //---------------------------
                    rt = rt + 1;
                    if (rt > 10)
                    {
                        Application.DoEvents();
                        rt = 0;
                    }
                    //--------------------------------------------------
                    this.progressBar1.Value = this.progressBar1.Value + 1;
                    this.prog_label3.Text = this.progressBar1.Value.ToString() + " of " + row_count.ToString();
                    //--------------------------------------------------
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString())  ;
            }
             //---------------------------------
                this.progress_panel2.Visible = false;
                Application.DoEvents();
             //------------------------
        }
    }
}

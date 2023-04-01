using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeWeek5
{
    public partial class BlinkStore : Form
    {
        DataTable dtProdukSimpan = new DataTable("Produk Simpan");
        DataTable dtProdukTampil = new DataTable("Produk Tampil");
        DataTable dtCategory = new DataTable("Category");
        DataSet dsProdukSimpan = new DataSet();
        DataSet dsProdukTampil = new DataSet();
        DataSet dsCategory = new DataSet();
        int count_ctg = 5;
        int selected_row = -1;

        public void InitialData()
        {
            DataColumn dtColumn;
            DataRow myDataRow;
            // dtProdukSimpan
            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ID Product",
                ReadOnly = false
            };
            dtProdukSimpan.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Nama Product",
                ReadOnly = false
            };
            dtProdukSimpan.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(Int32),
                ColumnName = "Harga",
                ReadOnly = false
            };
            dtProdukSimpan.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(Int32),
                ColumnName = "Stock",
                ReadOnly = false
            };
            dtProdukSimpan.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ID Category",
                ReadOnly = false
            };
            dtProdukSimpan.Columns.Add(dtColumn);

            // dtProdukTampil
            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ID Product",
                ReadOnly = false
            };
            dtProdukTampil.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Nama Product",
                ReadOnly = false
            };
            dtProdukTampil.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(Int32),
                ColumnName = "Harga",
                ReadOnly = false
            };
            dtProdukTampil.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(Int32),
                ColumnName = "Stock",
                ReadOnly = false
            };
            dtProdukTampil.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ID Category",
                ReadOnly = false
            };
            dtProdukTampil.Columns.Add(dtColumn);

            // dtCategory
            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "ID Category",
                ReadOnly = false
            };
            dtCategory.Columns.Add(dtColumn);

            dtColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Nama Category",
                ReadOnly = false
            };
            dtCategory.Columns.Add(dtColumn);

            dsProdukSimpan.Tables.Add(dtProdukSimpan);
            dsProdukTampil.Tables.Add(dtProdukTampil);
            dsCategory.Tables.Add(dtCategory);

            // add data
            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "J001";
            myDataRow["Nama Product"] = "Jas Hitam";
            myDataRow["Harga"] = 100000;
            myDataRow["Stock"] = 10;
            myDataRow["ID Category"] = "C1";
            dtProdukSimpan.Rows.Add(myDataRow);

            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "T001";
            myDataRow["Nama Product"] = "T-Shirt Black Pink";
            myDataRow["Harga"] = 70000;
            myDataRow["Stock"] = 20;
            myDataRow["ID Category"] = "C2";
            dtProdukSimpan.Rows.Add(myDataRow);

            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "T002";
            myDataRow["Nama Product"] = "T-Shirt Obsessive";
            myDataRow["Harga"] = 75000;
            myDataRow["Stock"] = 16;
            myDataRow["ID Category"] = "C2";
            dtProdukSimpan.Rows.Add(myDataRow);

            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "R001";
            myDataRow["Nama Product"] = "Rok mini";
            myDataRow["Harga"] = 82000;
            myDataRow["Stock"] = 26;
            myDataRow["ID Category"] = "C3";
            dtProdukSimpan.Rows.Add(myDataRow);

            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "J002";
            myDataRow["Nama Product"] = "Jeans Biru";
            myDataRow["Harga"] = 90000;
            myDataRow["Stock"] = 5;
            myDataRow["ID Category"] = "C4";
            dtProdukSimpan.Rows.Add(myDataRow);

            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "C001";
            myDataRow["Nama Product"] = "Celana Pendek Coklat";
            myDataRow["Harga"] = 60000;
            myDataRow["Stock"] = 11;
            myDataRow["ID Category"] = "C4";
            dtProdukSimpan.Rows.Add(myDataRow);

            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "C002";
            myDataRow["Nama Product"] = "Cawat Blink-blink";
            myDataRow["Harga"] = 1000000;
            myDataRow["Stock"] = 1;
            myDataRow["ID Category"] = "C5";
            dtProdukSimpan.Rows.Add(myDataRow);

            myDataRow = dtProdukSimpan.NewRow();
            myDataRow["ID Product"] = "R002";
            myDataRow["Nama Product"] = "Rocca Shirt";
            myDataRow["Harga"] = 50000;
            myDataRow["Stock"] = 8;
            myDataRow["ID Category"] = "C2";
            dtProdukSimpan.Rows.Add(myDataRow);

            // insert category
            myDataRow = dtCategory.NewRow();
            myDataRow["ID Category"] = "C1";
            myDataRow["Nama Category"] = "Jas";
            dtCategory.Rows.Add(myDataRow);

            myDataRow = dtCategory.NewRow();
            myDataRow["ID Category"] = "C2";
            myDataRow["Nama Category"] = "T-Shirt";
            dtCategory.Rows.Add(myDataRow);

            myDataRow = dtCategory.NewRow();
            myDataRow["ID Category"] = "C3";
            myDataRow["Nama Category"] = "Rok";
            dtCategory.Rows.Add(myDataRow);

            myDataRow = dtCategory.NewRow();
            myDataRow["ID Category"] = "C4";
            myDataRow["Nama Category"] = "Celana";
            dtCategory.Rows.Add(myDataRow);

            myDataRow = dtCategory.NewRow();
            myDataRow["ID Category"] = "C5";
            myDataRow["Nama Category"] = "Cawat";
            dtCategory.Rows.Add(myDataRow);
        }

        public BlinkStore()
        {
            InitializeComponent();
            InitialData();
            show_all();
            dataGridView2.DataSource = dtCategory;
            updateCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_all();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        public void show_all()
        {
            dtProdukTampil.Rows.Clear();
            foreach (DataRow dr in dtProdukSimpan.Rows)
            {
                dtProdukTampil.Rows.Add(dr.ItemArray);
            }
            dataGridView1.DataSource = dtProdukTampil;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboBox1.SelectedItem.ToString();
            string idcategory = "";
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i]["Nama Category"].ToString() == category)
                {
                    idcategory = dtCategory.Rows[i]["ID Category"].ToString();
                }
            }
            DataRow myDataRow;
            dtProdukTampil.Rows.Clear();
            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (dtProdukSimpan.Rows[i]["ID Category"].ToString() == idcategory)
                {
                    myDataRow = dtProdukTampil.NewRow();
                    myDataRow["ID Product"] = dtProdukSimpan.Rows[i]["ID Product"].ToString();
                    myDataRow["Nama Product"] = dtProdukSimpan.Rows[i]["Nama Product"].ToString();
                    myDataRow["Harga"] = dtProdukSimpan.Rows[i]["Harga"].ToString();
                    myDataRow["Stock"] = dtProdukSimpan.Rows[i]["Stock"].ToString();
                    myDataRow["ID Category"] = dtProdukSimpan.Rows[i]["ID Category"].ToString();
                    dtProdukTampil.Rows.Add(myDataRow);
                }
            }
            dataGridView1.DataSource = dtProdukTampil;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // add category
            string ctg_new = textBox1.Text;
            bool exst = false;
            DataRow myDataRow;
            if (ctg_new == "")
            {
                string message = "Please fill all field!";
                MessageBox.Show(message);
            }
            else
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i]["Nama Category"].ToString() == ctg_new)
                    {
                        exst = true;
                    }
                }
                if (!exst)
                {
                    count_ctg++;
                    myDataRow = dtCategory.NewRow();
                    myDataRow["ID Category"] = "C" + count_ctg.ToString();
                    myDataRow["Nama Category"] = ctg_new;
                    dtCategory.Rows.Add(myDataRow);
                    updateCombobox();
                }
                else
                {
                    string message = "Category Already Exist!";
                    MessageBox.Show(message);
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if(rowIndex < dtCategory.Rows.Count)
                textBox1.Text = (dtCategory.Rows[rowIndex]["Nama Category"].ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selected = textBox1.Text;
            string id_ctg = "";
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i]["Nama Category"].ToString() == selected)
                {
                    id_ctg = dtCategory.Rows[i]["ID Category"].ToString();
                    dtCategory.Rows[i].Delete();
                    break;
                }
            }
            count_ctg--;
            
            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (dtProdukSimpan.Rows[i]["ID Category"].ToString() == id_ctg)
                {
                    dtProdukSimpan.Rows[i].Delete();
                    i--;
                }
            }
            show_all();
            updateCombobox();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accept number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only accept number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        void updateCombobox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                comboBox1.Items.Add(dtCategory.Rows[i]["Nama Category"].ToString());
                comboBox2.Items.Add(dtCategory.Rows[i]["Nama Category"].ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // add data product
            DataRow myDataRow, myDataRow1;
            string nama = textBox2.Text;
            string category = comboBox2.SelectedItem.ToString();
            string harga = textBox3.Text;
            string stok = textBox4.Text;
            // auto generate id
            int countnama = 1;
            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (dtProdukSimpan.Rows[i]["Nama Product"].ToString() == nama)
                {
                    int nomor = dtProdukSimpan.Rows[i]["ID Product"].ToString()[3]-48;
                    if (countnama <= nomor)
                        countnama = nomor + 1;
                }
            }
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i]["Nama Category"].ToString() == category)
                {
                    category = dtCategory.Rows[i]["ID Category"].ToString();
                    break;
                }
            }

            if ((nama == "")|| (category == "") || (harga == "") || (stok == ""))
            {
                string message = "Please fill all field!";
                MessageBox.Show(message);
            }
            else
            {
                myDataRow = dtProdukSimpan.NewRow();
                myDataRow["ID Product"] = nama[0]+"00"+countnama.ToString();
                myDataRow["Nama Product"] = nama;
                myDataRow["Harga"] = harga.ToString();
                myDataRow["Stock"] = stok.ToString();
                myDataRow["ID Category"] = category.ToString();
                dtProdukSimpan.Rows.Add(myDataRow);

                myDataRow1 = dtProdukTampil.NewRow();
                myDataRow1["ID Product"] = nama[0] + "00" + countnama.ToString();
                myDataRow1["Nama Product"] = nama;
                myDataRow1["Harga"] = harga.ToString();
                myDataRow1["Stock"] = stok.ToString();
                myDataRow1["ID Category"] = category;
                dtProdukTampil.Rows.Add(myDataRow1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // when clicked datagrid
            int rowIndex = e.RowIndex;
            selected_row = rowIndex;
            if(rowIndex < dtProdukTampil.Rows.Count)
            {
                string category = dtProdukTampil.Rows[rowIndex]["ID Category"].ToString();
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i]["ID Category"].ToString() == category)
                    {
                        category = dtCategory.Rows[i]["Nama Category"].ToString();
                        break;
                    }
                }
                textBox2.Text = (dtProdukTampil.Rows[rowIndex]["Nama Product"].ToString());
                textBox3.Text = (dtProdukTampil.Rows[rowIndex]["Harga"].ToString());
                comboBox2.SelectedItem = category;
                textBox4.Text = (dtProdukTampil.Rows[rowIndex]["Stock"].ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nama = textBox2.Text;
            string category = comboBox2.SelectedItem.ToString();
            string harga = textBox3.Text;
            string stok = textBox4.Text;
            if ((nama == "") || (category == "") || (harga == "") || (stok == ""))
            {
                string message = "Please fill all field!";
                MessageBox.Show(message);
            }
            else
            {
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i]["Nama Category"].ToString() == category)
                    {
                        category = dtCategory.Rows[i]["ID Category"].ToString();
                        break;
                    }
                }
                dtProdukTampil.Rows[selected_row]["Nama Product"] = nama;
                dtProdukTampil.Rows[selected_row]["Harga"] = harga;
                dtProdukTampil.Rows[selected_row]["Stock"] = stok;
                dtProdukTampil.Rows[selected_row]["ID Category"] = category;
                if(Int32.Parse(stok) == 0)
                {
                    dtProdukTampil.Rows[selected_row].Delete();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((selected_row == -1))
            {
                string message = "Please select items!";
                MessageBox.Show(message);
            }
            else
            {
                if(selected_row < dtProdukTampil.Rows.Count)
                    dtProdukTampil.Rows[selected_row].Delete();
                else
                {
                    string message = "Please select items!";
                    MessageBox.Show(message);
                }
            }
        }
    }
}
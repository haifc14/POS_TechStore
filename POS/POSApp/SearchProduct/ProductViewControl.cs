﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;

namespace POSApp
{
    public partial class ProductViewControl : UserControl
    {
        private string[] _categories;
        private string[] _brands;
        private string _selectedBrand = "";
        private string _selectedCategory = "";

        public ProductViewControl()
        {
            InitializeComponent();
            _categories = Helper.GetCategories().ToArray();
            _brands = Helper.GetBrands().ToArray();
            CategoryComboBox.Items.Add("Select Category");
            CategoryComboBox.Items.AddRange(_categories);
            BrandComboBox.Items.Add("Select Brand");
            BrandComboBox.Items.AddRange(_brands);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == 0)
            {
                _selectedCategory = "";
            }
            else
            {
                _selectedCategory = CategoryComboBox.Items[CategoryComboBox.SelectedIndex].ToString();
            }
        }

        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BrandComboBox.SelectedIndex == 0)
            {
                _selectedBrand = "";
            }
            else
            {
                _selectedBrand = BrandComboBox.Items[BrandComboBox.SelectedIndex].ToString();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                var keywords = SearchTextbox.Text;
                var filteredProducts = new ProductCollection(keywords, _selectedBrand, _selectedCategory);
                var bindingSource = new BindingSource();
                bindingSource.DataSource = filteredProducts.Products;
                ProductDataGradeView.DataSource = bindingSource;
            }
            catch (Exception)
            {
                MessageBox.Show("Error while collecting information to search. Please try agin!");
            }
            finally {
                BrandComboBox.SelectedIndex = 0;
                _selectedBrand = "";
                CategoryComboBox.SelectedIndex = 0;
                _selectedCategory = "";
                SearchTextbox.Text = "";
            }
        }

        private void ProductDataGradeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductFilterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductViewControl_Load(object sender, EventArgs e)
        {

        }

        private void RecommendedButtton_Click(object sender, EventArgs e)
        {
            // get the Customer code when their card was scanned
            string customerCode = "C500"; // for testing 

            var bindingSource = new BindingSource();

            // no customer code
            ProductCollection collectionFromSystem = new ProductCollection();
          
            bindingSource.DataSource = collectionFromSystem.Products;
            //ProductDataGradeView.DataSource = bindingSource;

            // if customer has card, recommend the latest purchased product + random products

            ProductCollection collectionFromCustomerPurchases = new ProductCollection(customerCode);
            
            bindingSource.DataSource = collectionFromCustomerPurchases.Products;
            ProductDataGradeView.DataSource = bindingSource;
        }
    }
}
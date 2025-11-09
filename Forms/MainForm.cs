using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using tcc_barcode.Services;

namespace tcc_barcode.Forms
{
    public partial class MainForm : Form
    {
        private readonly ProductService _productService;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _productService = serviceProvider.GetRequiredService<ProductService>();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadProducts();
            }
            catch (Exception ex)
            {
                OnException(ex);
            }
        }

        private async Task LoadProducts()
        {
            var products = await _productService.GetAllAsync();
            if (products == null) return;

            dgvProductDetail.AutoGenerateColumns = false;
            dgvProductDetail.DataSource = products;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = txtProductCode.Text.Trim();

                await _productService.AddProductAsync(productCode);
                txtProductCode.Clear();

                await LoadProducts();
                txtProductCode.Focus();
            }
            catch (Exception ex)
            {
                OnException(ex);
            }
        }

        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = txtProductCode.Text.Trim();

            if (e.KeyChar != (char)Keys.Back)
            {
                if (string.IsNullOrWhiteSpace(text)) return;

                if (text.Length < 19 && text.Replace("-", "").Length % 4 == 0 && text[^1] != '-')
                {
                    var formatted = new StringBuilder();
                    formatted.Append(text);
                    formatted.Append("-");
                    txtProductCode.Text = formatted.ToString();
                    txtProductCode.SelectionStart = txtProductCode.Text.Length;
                }
            }
        }

        private async void dgvProductDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmDelete.Index)
                {
                    int productId = Convert.ToInt32(dgvProductDetail[clmId.Index, e.RowIndex].Value?.ToString());
                    string productCode = dgvProductDetail[clmProductCode.Index, e.RowIndex].Value?.ToString() ?? string.Empty;

                    string message = $"ต้องการลบข้อมูล รหัสสินค้า '{productCode}' หรือไม่";
                    var result = MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        await _productService.DeleteProductAsync(productId);
                        await LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                OnException(ex);
            }
        }

        private void OnException(Exception ex)
        {
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}

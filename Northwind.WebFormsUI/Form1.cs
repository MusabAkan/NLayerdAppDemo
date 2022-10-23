using Northwind.Business.Abstract;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.Business.Model;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Model;
using Northwind.DataAccess.Model.EntitiyFramework;
using Northwind.Entities.Model;
//using Northwind.DataAccess.Model.NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum ChangeAction
        {
            None, Delete, Insert, Update
        }

        IProductService _productService = InstanceFactory.GetInstance<IProductService>();
        ICategoryService _categoryService = InstanceFactory.GetInstance<ICategoryService>();


        //Dependency Injection  işlemi daha sonra anlatılacaktır.
        private void Form1_Load(object sender, EventArgs e)
        {
            #region not
            //code smel olan demek kötü anlamında gelmektedir.
            //Buradan dataacces erişim yasaktır. İş katmanında çağırılacaktır. Business
            //Arayüz katmanında sadece arayüzle alakalı nesneler olmak zorunda  çokl katmanlar kuralına göre 
            //Yanlzı buradda garibime giden nokta şu konfigrasyonlar ayarında neden DataAccess katmanında değilde buraya yazılıyor onu anlayamadım =P
            //Sonuçtan tüm veritabanı işlemlei oradan yapılıypr.

            //ProductManager productManager = new ProductManager(new NhPrdouctDal());
            //Burada abstract uygulandı çünkü ilerleyen zamanlardan enitiy yerine yada bağımsız  sql , oracle , orem ihtiyaç duyulabiliriz oyüzden istediğin database buradan tek hamle ile bağlayabilirsin.
            //bir katman diğerine new'leyemez bu yüzden  bağımlılığı minimize etmek için 
            #endregion
            LoadProduct();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cmbCategory.DataSource = _categoryService.GetAll();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";

            cmbCategoryAction.DataSource = _categoryService.GetAll();
            cmbCategoryAction.DisplayMember = "CategoryName";
            cmbCategoryAction.ValueMember = "CategoryId";

        }

        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductByCategory(int.Parse(cmbCategory.SelectedValue.ToString()));
            }
            catch { }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()))
                dgwProduct.DataSource = _productService.GetProductByProductName(txtSearch.Text.Trim());
            else
                LoadProduct();
        }

        string OnValidate(ChangeAction action)
        {
            if (action == ChangeAction.Insert)
            {
                try
                {
                    _productService.Add(new Product
                    {

                        CategoryId = Convert.ToInt32(cmbCategoryAction.SelectedValue),
                        ProductName = txtProductNameAction.Text,
                        QuantityPerUnit = txtQuantityPerUnitAction.Text,
                        UnitPrice = Convert.ToDecimal(txtUnitPriceAction.Text),
                        UnitsInStock = Convert.ToInt16(txtUnitsInStockAction.Text)
                    });
                }
                catch (Exception ex)
                {

                    return string.Format("[{1}] Error : {0} ", ex.Message, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }
              
                return "Ürün Kaydedildi...";
            }
            else if (action == ChangeAction.Update)
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    ProductName = txtProductNameAction.Text,
                    CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                    UnitsInStock = Convert.ToInt16(txtUnitsInStockAction.Text),
                    UnitPrice = Convert.ToDecimal(txtUnitPriceAction.Text),
                    QuantityPerUnit = txtQuantityPerUnitAction.Text
                });

                return "Ürün Güncellendi...";
            }

            else if (action == ChangeAction.Delete)
            {
                try
                {
                    if (dgwProduct.CurrentRow != null)
                        _productService.Delete(new Product
                        {
                            ProductId = int.Parse(dgwProduct.CurrentRow.Cells[0].Value.ToString())
                        });
                    return "Ürün Silindi";
                }
                catch (Exception ex)
                {
                    return string.Format("[{1}] Error : {0} ", ex.Message, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                }
            }
            else
            {
                return "Hiç Bir şey olmadı";
            }

        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
             
            string returns = string.Empty;

            DialogResult dr = MessageBox.Show($"{rbActions.Text} için devam etmek istiyor musun?", "BİLDİRİM", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                switch (rbActions.Text)
                {
                    case "EKLE":
                        returns = OnValidate(ChangeAction.Insert);
                        break;
                    case "SİL":
                        returns = OnValidate(ChangeAction.Delete);
                        break;
                    case "GÜNCELLE":
                        returns = OnValidate(ChangeAction.Update);
                        break;
                    default:
                        returns = OnValidate(ChangeAction.None);
                        break;
                }

                MessageBox.Show(returns);
                LoadProduct();
                TextClear();
            }
        }


        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rbUpdate.Checked)
            {
                var row = dgwProduct.CurrentRow;
                txtProductNameAction.Text = row.Cells["ProductName"].Value.ToString();
                cmbCategoryAction.SelectedValue = row.Cells["CategoryId"].Value;
                txtUnitPriceAction.Text = row.Cells["UnitPrice"].Value.ToString();
                txtQuantityPerUnitAction.Text = row.Cells["QuantityPerUnit"].Value.ToString();
                txtUnitsInStockAction.Text = row.Cells["UnitsInStock"].Value.ToString();
            }

        }
        private void TextClear()
        {
            txtQuantityPerUnitAction.Text = string.Empty;
            txtProductNameAction.Text = string.Empty;
            txtUnitPriceAction.Text = string.Empty;
            txtUnitsInStockAction.Text = string.Empty;
            cmbCategoryAction.SelectedValue = -1;
        }


        public RadioButton rbActions;
        private void rbAction(object sender, EventArgs e)
        {
            btnProcess.Enabled = true;
            rbActions = (RadioButton)sender;
            if (rbActions.Text == "EKLE")
                TextClear();
            grpEvents.Text = "ÜRÜN " + rbActions.Text;
        }
    }
}

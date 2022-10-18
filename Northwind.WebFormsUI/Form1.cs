using Northwind.Business.Abstract;
using Northwind.DataAccess.Model;
using Northwind.DataAccess.Model.EntitiyFramework;
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
        IProductService _productManager = new ProductManager(new EfProductDal());

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

            dgwProduct.DataSource = _productManager.GetAll();
        }
    }
}

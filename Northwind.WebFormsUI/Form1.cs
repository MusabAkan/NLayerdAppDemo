using Northwind.DataAccess.Model;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Buradan dataacces erişim yasaktır. İş katmanında çağırılacaktır. Business
            //Arayüz katmanında sadece arayüzle alakalı nesneler olmak zorunda  çokl katmanlar kuralına göre 
            //Yanlzı buradda garibime giden nokta şu konfigrasyonlar ayarında neden DataAccess katmanında değilde buraya yazılıyor onu anlayamadım =P
            //Sonuçtan tüm veritabanı işlemlei oradan yapılıypr.
            ProductManager productManager = new ProductManager();

            dgwProduct.DataSource = productManager.GetAll();
        }
    }
}

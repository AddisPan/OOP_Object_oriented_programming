using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellphoneWindowsFormsApp
{
    //定義結構
    struct CellPhone
    {
        public string brand;
        public string model;
        public int price;
        public double size;
    }
    public partial class mainPhone : Form
    {
        //建立一個全域串列
        private List<CellPhone> phoneList = new List<CellPhone> ();
        public mainPhone()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            //建立一個新的手機物件
            CellPhone myPhone = new CellPhone();

            //取得手機的資料
            getData(ref myPhone);

            //將新的手機資料加在串列中
            phoneList.Add(myPhone);

            //清除資料
            BrandTextBox.Clear();
            ModelTextBox.Clear();
            PriceTextBox.Clear();
            SizeTextBox.Clear();

            //將游標移到輸入資料處
            BrandTextBox.Focus();
        }

        private void getData(ref CellPhone Phone)
        {
            try
            {
                //使用者輸入的資料
                Phone.brand = BrandTextBox.Text;
                Phone.model = ModelTextBox.Text;
                Phone.price = int.Parse(PriceTextBox.Text);
                Phone.size = int.Parse(SizeTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DispalyButton_Click(object sender, EventArgs e)
        {
            //宣告一個字串放入將一台手機的所有資訊
            string output;
            PhoneListBox.Items.Clear();

            //顯示串列的資料
            foreach (CellPhone phone in phoneList)
            {
                output = phone.brand + "  " + phone.model + "  " + phone.price + "  " + phone.size;
                PhoneListBox.Items.Add(output);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CelebrationCard
{
    public partial class MainPage : ContentPage
    {
        private List<string> anh = new List<string>();
        private int item = 0;
        public MainPage()
        {
            InitializeComponent();
            anh.Add("https://vnuf.edu.vn/wp-content/uploads/2020/11/SU-KIEN-ngay-Nha-Giao-VN.jpg");
            anh.Add("https://www.liena.com.vn/media/amasty/blog/cache/c/a/840/840/cau-chuc-y-nghia-ngay-nha-giao-20-11.jpg");
            anh.Add("https://dongphucvina.vn/wp-content/uploads/2022/09/ngay-20-11-la-gi.jpg");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            item++;
            if(item >= anh.Count)   item = 0;
            imageView.Source = anh[item];
        }
    }
}

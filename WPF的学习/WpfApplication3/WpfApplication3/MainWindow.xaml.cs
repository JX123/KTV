using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Visibility的值是枚举类型：Visibility可见，coppapsed不可见
            //所有的控件都有Visibility属性
          // txtName.Visibility = System.Windows.Visibility.Collapsed;
            if (txtName.Visibility == System.Windows.Visibility.Visible)
                txtName.Visibility = System.Windows.Visibility.Collapsed;
            else if (txtName.Visibility == System.Windows.Visibility.Collapsed)
                txtName.Visibility = System.Windows.Visibility.Visible;


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //DateTime? value = datapk1.SelectedDate;
            //   if(value==null)
            //   {
            //       MessageBox.Show("请选择日期");
            //   }
            //else
            //   {
            //       MessageBox.Show(value.ToString());
            //   }
               //datapk1.SelectedDate = DateTime.Today;
            MessageBox.Show(DateTime.Today.ToString());//时间00:00:00，只包含年月日
            MessageBox.Show(DateTime.Now.ToString());//有明确时间，还包含时分秒
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            progress.Value += 10;
        }
    }
}

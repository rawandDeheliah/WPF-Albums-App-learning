using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp2.ModelViews
{
    public class MainViewModel
    {
        public Frame? MainFrame { get; set; }
        public void NavigateTo(Page page)
        {
            MainFrame?.Navigate(page);
        }
    }
}

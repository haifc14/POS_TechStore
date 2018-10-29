using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSLibrary;

namespace POSApp
{
    public class ProductViewControl
    {
        public TextBox SearchBar { get; set; }
        public ComboBox CategoryCombobox { get; set; }
        public ComboBox BrandCombobox { get; set; }
        

        public void SearchBarOnChange()
        {
            //event
            //execute on change of search bar text
        }

        public void CategoryComboboxOnChange()
        {
            //event 
            // execute on change of category combobox selectindex
        }

        public void BrandComboboxOnChange()
        {
            //event
            //execute on change of brand combobox selectedindex
        }
    }
}

using MVP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Views
{
    public interface IMainView
    {
        EventHandler<EventArgs> AddButtonClicked { get; set; }
        EventHandler<EventArgs> LoadButtonClicked { get; set; }
        EventHandler<EventArgs> ListBoxIndexChanged { get; set; }
        EventHandler<EventArgs> DeleteButtonClicked { get; set; }
        EventHandler<DrawItemEventArgs> CbColorDrawItem { get; set; }
        EventHandler<EventArgs> VendorIndexChanged { get; set; }
        ComboBox CbColor { get; }

        bool DeleteButtonEnable { set; }
        string VendorText { get; set; }
        string ModelText { get; set; }
        string YearText { get; set; }
        string TransmissionText { get; set; }
        List<Car> Cars { set; }
        List<string> Vendors { set; }
        List<string> Transmissions { set; }
        List<string> Models { set; }
        List<string> Years { set; }
    }
}

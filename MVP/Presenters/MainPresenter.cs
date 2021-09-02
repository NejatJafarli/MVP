using MVP.Data;
using MVP.Models;
using MVP.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP.Presenters
{
	public class MainPresenter
	{
		private readonly CarContext _carContext;
		private readonly IMainView _view;

		public MainPresenter(IMainView view)
		{
			_view = view;
			_carContext = new CarContext();

			_view.AddButtonClicked += ViewAddButtonClicked;
			_view.LoadButtonClicked += ViewLoadButtonClicked;
			_view.CbColorDrawItem += cbColor_DrawItem;
			_view.VendorIndexChanged += VendorSelectedIndexChanged;
			_view.ListBoxIndexChanged += ListBoxIndexChanged;
			_view.DeleteButtonClicked += deleteButtonClicked;
			_view.DeleteButtonEnable = false;

			string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
			_view.CbColor.Items.AddRange(colores);
			_view.CbColor.SelectedIndex = 34;
			List<string> Vendors = new List<string>();
			Vendors.Add("VAZ");
			Vendors.Add("BMW");
			Vendors.Add("MERCEDES");
			_view.Vendors = Vendors;

			_view.Transmissions = new List<string> { "Manual", "Automatic" };
			List<string> Years = new List<string>();

			for (int i = 2000; i < DateTime.Now.Year; i++)
				Years.Add(i.ToString());

			_view.Years=Years;
		}
		private void deleteButtonClicked(object sender, EventArgs e)
		{
			if (SelectionItems is ListBox.SelectedObjectCollection temp)
			{
				for (int i = 0; i < temp.Count; i++)
				{
					_carContext.Cars.Remove(temp[i] as Car);
				}
				_carContext.SaveChanges();
				_view.Cars = _carContext.Cars.ToList();
			}
		}
		public object SelectionItems { get; set; }
		private void ListBoxIndexChanged(object sender, EventArgs e)
		{
			var temp = sender as ListBox;
			if (temp.SelectionMode != SelectionMode.MultiSimple)
				temp.SelectionMode = SelectionMode.MultiSimple;
			if (temp.SelectedItems.Count == 0)
			{
				_view.DeleteButtonEnable = false;
				return;
			}
			else
			{
				_view.DeleteButtonEnable = true;
			}
			SelectionItems = temp.SelectedItems;
		}
		private void VendorSelectedIndexChanged(object sender, EventArgs e)
		{
			if (_view.VendorText == "BMW")
			{
				List<String> Models = new List<string>();
				Models.Add("E60");
				Models.Add("F10");
				Models.Add("X5");
				_view.Models = Models;
			}
			else if (_view.VendorText == "VAZ")
			{
				List<string> Models = new List<string>();
				Models.Add("2107");
				Models.Add("2106");
				Models.Add("Priora");
				_view.Models = Models;
			}
			else if (_view.VendorText == "MERCEDES")
			{
				List<string> Models = new List<string>();
				Models.Add("G63 SUV");
				Models.Add("C63 Sedan");
				Models.Add("GT Roadster");
				_view.Models = Models;
			}
		}

		private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
		{
			try
			{
				e.DrawBackground();
				string texto = _view.CbColor.Items[e.Index].ToString();
				Brush border = new SolidBrush(e.ForeColor);
				Color color = Color.FromName(texto);
				Brush pincel = new SolidBrush(color);
				Pen boli = new Pen(e.ForeColor);
				e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 24, e.Bounds.Height - 4));
				e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 22, e.Bounds.Height - 6));
				e.Graphics.DrawString(texto, e.Font, border, e.Bounds.Left + 30, e.Bounds.Top + 2);

				e.DrawFocusRectangle();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private void ViewAddButtonClicked(object sender, EventArgs e)
		{
			Car car = new Car
			{
				Vendor = _view.VendorText,
				Model = _view.ModelText,
				Year = int.Parse(_view.YearText),
				Color = _view.CbColor.SelectedItem.ToString(),
				Transmission = _view.TransmissionText
			};

			_carContext.Cars.Add(car);
			_carContext.SaveChanges();

			_view.Cars = _carContext.Cars.ToList();
		}

		private void ViewLoadButtonClicked(object sender, EventArgs e)
		{
			_view.Cars = _carContext.Cars.ToList();
		}
	}
}

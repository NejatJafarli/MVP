using MVP.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace MVP.Views
{
	public partial class MainView : Form, IMainView
	{
		public MainView()
		{
			InitializeComponent();
		}

		public EventHandler<EventArgs> AddButtonClicked { get; set; }
		public EventHandler<EventArgs> LoadButtonClicked { get; set; }


		public string VendorText
		{
			get => CbVendor.Text;
			set => CbVendor.Text = value;
		}

		public string ModelText
		{
			get => cbModel.Text;
			set => cbModel.Text = value;
		}

		public string ColorText
		{
			get => comboBoxColor.Text;
			set => comboBoxColor.Text = value;
		}

		public string YearText
		{
			get => cbYear.Text;
			set => cbYear.Text = value;
		}

		public string TransmissionText
		{
			get => cbTransmission.Text;
			set => cbTransmission.Text = value;
		}


		public List<Car> Cars
		{
			set
			{
				listBoxCar.DataSource = value;
			}
		}


		public List<string> Colors
		{
			set
			{
				comboBoxColor.DataSource = value;
			}
		}

		public EventHandler<DrawItemEventArgs> CbColorDrawItem { get; set; }

		public ComboBox CbColor { get => comboBoxColor; }
		public List<string> Vendors { set => CbVendor.DataSource = value; }
		public List<string> Models { set => cbModel.DataSource = value; }
		public EventHandler<EventArgs> VendorIndexChanged { get; set; }
		public EventHandler<EventArgs> DeleteButtonClicked { get; set; }
		public EventHandler<EventArgs> ListBoxIndexChanged { get; set; }
		public List<string> Transmissions { set => cbTransmission.DataSource = value; }
		public bool DeleteButtonEnable { set=> btnDelete.Enabled=value; }
		public List<string> Years { set => cbYear.DataSource=value; }

		private void btnAddCar_Click(object sender, EventArgs e)
		{
			AddButtonClicked.Invoke(sender, e);
		}
		private void btnLoadCars_Click(object sender, EventArgs e)
		{
			LoadButtonClicked.Invoke(sender, e);
		}
		private void comboBoxColor_DrawItem(object sender, DrawItemEventArgs e)
		{
			CbColorDrawItem.Invoke(sender, e);
		}

		private void CbVendor_SelectedIndexChanged(object sender, EventArgs e)
		{
			VendorIndexChanged.Invoke(sender, e);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DeleteButtonClicked.Invoke(sender, e);
		}

		private void listBoxCar_SelectedIndexChanged(object sender, EventArgs e)
		{
			ListBoxIndexChanged.Invoke(sender, e);
		}

		private void btnDelete_Click_1(object sender, EventArgs e)
		{
			DeleteButtonClicked.Invoke(sender, e);
		}

	}
}

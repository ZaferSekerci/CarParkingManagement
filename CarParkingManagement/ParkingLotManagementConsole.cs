using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkingManagement
{
    public partial class ParkingLotManagementConsole : Form
    {

        // DEPENDENCY INJECTION

        private ParkingLot leventParking;
        private Car car;
        private Customer customer;

        //List<CarViewModel> carViewModel = new List<CarViewModel>();

        public ParkingLotManagementConsole()
        {
            leventParking = new ParkingLot();
            car = new Car();
            customer = new Customer();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(VehicleClass)))
            {
                cmbCarType.Items.Add(item);
            }

            leventParking.ParkingLotName = "Levent Parking";
            leventParking.MaximumCarCapacity = 5;

            

            label7.Text = leventParking.ParkingLotName;
            textBox1.Text = leventParking.MaximumCarCapacity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            car.Plate = maskedTextBox1.Text;
            car.VehicleClass = (VehicleClass)cmbCarType.SelectedItem;



            customer.EntryTime = dateTimePicker1.Value;
            customer.Car = car;

            leventParking.MaximumCarCapacity -= 1;
            textBox1.Text = leventParking.MaximumCarCapacity.ToString(); 
            cmbCarPlate.Items.Add(customer.Car.Plate);           

            dataGridView1.Rows.Add(customer.Car.Plate,customer.EntryTime,customer.Car.VehicleClass);
            //carViewModel.Add(cvm);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer.Car.Plate = cmbCarPlate.SelectedText;

            customer.ExitTime = dateTimePicker2.Value;
            
            
            PriceList priceList = new PriceList(customer.Car.VehicleClass);

            Billing billing = new Billing(customer,priceList);

            MessageBox.Show(billing.TotalPrice.ToString());
        }
    }
}

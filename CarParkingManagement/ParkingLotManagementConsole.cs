using System;
using System.Windows.Forms;
using System.Drawing;

namespace CarParkingManagement
{
    public partial class ParkingLotManagementConsole : Form
    {

        // DEPENDENCY INJECTION

        private ParkingLot leventParking;
        private Car car;
        private Customer customer;
        private DataGridViewRow selectedCarRow = new DataGridViewRow();

        //List<CarViewModel> carViewModel = new List<CarViewModel>();

        public ParkingLotManagementConsole()
        {
            leventParking = new ParkingLot();
            car = new Car();
            customer = new Customer();
            InitializeComponent();
        }

        private void UpdateSlot()
        {
            txtEmptyParkSlot.Text = leventParking.MaximumCarCapacity.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(VehicleClass)))
            {
                cmbCarType.Items.Add(item);
            }

            leventParking.ParkingLotName = "Levent Parking";
            leventParking.MaximumCarCapacity = 50;

            UpdateSlot();   

            label7.Text = leventParking.ParkingLotName;
        }


        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            car.Plate = mtxtCarPlate.Text;
            car.VehicleClass = (VehicleClass)cmbCarType.SelectedItem;



            customer.EntryTime = dtpCheckInTime.Value;
            customer.Car = car;

            leventParking.TotalIncome = dgvListOfInsideCars.Rows.Count;

            UpdateSlot();

            dgvListOfInsideCars.Rows.Add(customer.Car.Plate, customer.EntryTime, customer.Car.VehicleClass);

            gbEntrySection.Enabled = leventParking.CheckAvailability();
            gbEntrySection.BackColor = Color.FromName(leventParking.CapacityCustomerRatio());


        }

        private void btnCalculateParkingPrice_Click(object sender, EventArgs e)
        {
            if (dgvListOfInsideCars.SelectedRows.Count != 0)
            {

                customer.ExitTime = dtpCheckOutTime.Value;

                PriceList priceList = new PriceList(customer.Car);

                Billing billing = new Billing(customer, priceList);

                //MessageBox.Show(billing.TotalPrice.ToString());
                
                DialogResult result = MessageBox.Show("Total payment of the vehicle below informations " +
                                    billing.TotalPrice.ToString() + " TL\n" +
                                    customer.Car.VehicleClass.ToString() +
                                    " " + customer.Car.Plate,"Bill Calculation",MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    dgvListOfInsideCars.Rows.RemoveAt(selectedCarRow.Index);
                    leventParking.TotalIncome++;
                    UpdateSlot();

                }

                

            }
            else
            {
                MessageBox.Show("Please select a customer from list");
            }

        }

        private void dgvListOfInsideCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedCarRow = dgvListOfInsideCars.SelectedRows[0];
            customer.Car.Plate = selectedCarRow.Cells["CarPlate"].Value.ToString();
            customer.Car.VehicleClass = (VehicleClass)Enum.Parse(typeof(VehicleClass), selectedCarRow.Cells["CarType"].Value.ToString());
        }
    }
}

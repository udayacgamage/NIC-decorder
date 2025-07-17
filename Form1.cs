namespace IdentityDataRetrievalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGenerate.Click += btnGenerate_Click;

        }
        private (string Gender, int Year, int Month, int Day) ParseNIC(string nic)
        {
            int year, dayOfYear;

            if (nic.Length == 10 && char.IsLetter(nic[9]))
            {
                year = 1900 + int.Parse(nic.Substring(0, 2));
                dayOfYear = int.Parse(nic.Substring(2, 3));
            }
            else if (nic.Length == 12)
            {
                year = int.Parse(nic.Substring(0, 4));
                dayOfYear = int.Parse(nic.Substring(4, 3));
            }
            else
            {
                throw new Exception("Invalid NIC format. Use 10 or 12 characters.");
            }

            string gender = dayOfYear > 500 ? "Female" : "Male";
            if (dayOfYear > 500) dayOfYear -= 500;

            DateTime birthDate = new DateTime(year, 1, 1).AddDays(dayOfYear - 1);
            return (gender, year, birthDate.Month, birthDate.Day);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ParseNIC((txtNIC.Text ?? string.Empty).Trim());
                lblGender.Text = result.Gender;
                lblYear.Text = result.Year.ToString();
                lblMonth.Text = new DateTime(1, result.Month, 1).ToString("MMMM");
                lblDate.Text = result.Day.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "NIC Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

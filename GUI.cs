// Import the required namespaces.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Define the form.
public partial class Form1 : Form
{
    // Define the database connection string.
    private string connectionString = "Data Source=localhost;Initial Catalog=TireManagementSystem;Integrated Security=True";

    // Define the database table names.
    private string tableNameTire = "Tire";
    private string tableNameCustomer = "Customer";

    // Define the database table columns.
    private string columnTireId = "TireId";
    private string columnTireSize = "TireSize";
    private string columnTireBrand = "TireBrand";
    private string columnTirePrice = "TirePrice";
    private string columnCustomerId = "CustomerId";
    private string columnCustomerName = "CustomerName";
    private string columnCustomerAddress = "CustomerAddress";
    private string columnCustomerPhone = "CustomerPhone";

    // Define the database objects.
    private SqlConnection connection = new SqlConnection(connectionString);
    private SqlCommand command = new SqlCommand();
    private SqlDataReader reader = null;

    // Define the form controls.
    private TextBox textBoxTireSize = new TextBox();
    private TextBox textBoxTireBrand = new TextBox();
    private TextBox textBoxTirePrice = new TextBox();
    private TextBox textBoxCustomerName = new TextBox();
    private TextBox textBoxCustomerAddress = new TextBox();
    private TextBox textBoxCustomerPhone = new TextBox();
    private Button buttonAdd = new Button();
    private Button buttonUpdate = new Button();
    private Button buttonDelete = new Button();
    private Button buttonSearch = new Button();
    private DataGridView dataGridViewTire = new DataGridView();

    // Initialize the form.
    public Form1()
    {
        // Initialize the form controls.
        textBoxTireSize.Location = new Point(12, 24);
        textBoxTireSize.Size = new Size(100, 20);
        textBoxTireBrand.Location = new Point(12, 56);
        textBoxTireBrand.Size = new Size(100, 20);
        textBoxTirePrice.Location = new Point(12, 88);
        textBoxTirePrice.Size = new Size(100, 20);
        textBoxCustomerName.Location = new Point(12, 120);
        textBoxCustomerName.Size = new Size(100, 20);
        textBoxCustomerAddress.Location = new Point(12, 152);
        textBoxCustomerAddress.Size = new Size(100, 20);
        textBoxCustomerPhone.Location = new Point(12, 184);
        textBoxCustomerPhone.Size = new Size(100, 20);
        buttonAdd.Location = new Point(12, 216);
        buttonAdd.Size = new Size(75, 23);
        buttonAdd.Text = "Add";
        buttonUpdate.Location = new Point(93, 216);
        buttonUpdate.Size = new Size(75, 23);
        buttonUpdate.Text = "Update";
        buttonDelete.Location = new Point(174, 216);
        buttonDelete.Size = new Size(75, 23);
        buttonDelete.Text = "Delete";
        buttonSearch.Location = new Point(255, 216);
        buttonSearch.Size = new Size(75, 23);
        buttonSearch.Text = "Search";
        dataGridViewTire.Location = new Point(12, 2
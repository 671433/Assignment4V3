using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Staffapp.Data;
using Staffapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staffapp
{
    public partial class StaffApp : Form
    {
        private readonly Assignment4V3Context context = new();
        private readonly LocalView<Service> Services;

        public StaffApp()
        {
            InitializeComponent();

            context = new Assignment4V3Context();
            Services = new LocalView<Service>(context.Services);

            Services = context.Services.Local;
            context.Services.Load();


        }

        private void Btn_Maintainer_Click(object sender, EventArgs e)
        {
            var maintainerServices = context.Services.Where(s => s.RequestType == "Maintainer").ToList();
            dataGridView1.DataSource = maintainerServices;
        }

        private void Btn_Cleaner_Click(object sender, EventArgs e)
        {
            var CleanerServices = context.Services.Where(s => s.RequestType == "Cleaner").ToList();

            dataGridView1.DataSource = CleanerServices;
        }

        private void Btn_service_person_Click(object sender, EventArgs e)
        {
            var ServicePerson = context.Services.Where(s => s.RequestType == "Service person").ToList();

            dataGridView1.DataSource = ServicePerson;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == dataGridView1.Columns[6].Index && e.RowIndex >= 0)
            {

                var selectedValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (selectedValue != null)
                {
                    MessageBox.Show("selectedValue" + selectedValue);
                    var currentDescription = dataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

                    currentDescription += " " + selectedValue;

                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = currentDescription;

                    context.SaveChanges();
                }
            }


        }

        private void Btn_SaveChanges_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

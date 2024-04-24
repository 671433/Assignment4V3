using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualBasic.ApplicationServices;
using Staffapp.Data;
using Staffapp.Models;
using System;

namespace Staffapp
{ 
    
    public partial class Form1 : Form
    {

        //  private readonly Assignment4V3Context context = new Assignment4V3Context();

        private readonly Assignment4V3Context context = new();
        private readonly LocalView<Room> Rooms;
        private readonly LocalView<Reservation> Reservations;
        private readonly LocalView<AspNetUser> Users;
        //  private readonly LocalView<AppUser> Users;
        private readonly LocalView<Service> Services;


        public Form1()
        {
            InitializeComponent();


            context = new Assignment4V3Context();
            Rooms = new LocalView<Room>(context.Rooms);
            Reservations = new LocalView<Reservation>(context.Reservations);
            Users = new LocalView<AspNetUser>(context.AspNetUsers);
            Services = new LocalView<Service>(context.Services);

            Services = context.Services.Local;

            context.Rooms.Load();
            context.Services.Load();
            context.Reservations.Load();
            context.AspNetUsers.Load();
        }


        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(context.AspNetUsers.FirstOrDefault().FirstName.ToString());
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {



        }

        private void LoadServices()
        {

            try
            {
                var allServices = context.Services.ToList();

                var maintainerServices = context.Services.Where(s => s.RequestType == "Maintainer").ToList();

                MdataGridView1.DataSource = maintainerServices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading services: " + ex.Message);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            try
            {
                LoadServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void m_saveChanges_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex == MdataGridView1.Columns[6].Index && e.RowIndex >= 0)
            {
                var selectedValue = MdataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (selectedValue != null)
                {
                    MessageBox.Show("selectedValue" + selectedValue);
                    var currentDescription = MdataGridView1.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

                    currentDescription += " " + selectedValue;

                    MdataGridView1.Rows[e.RowIndex].Cells[3].Value = currentDescription;

                    context.SaveChanges();
                }
            }



        }


        // clean tab
        private void C_btn_ShowAll_Click(object sender, EventArgs e)
        {
            var inProgress = context.Services.Where(s => s.RequestType == "Cleaner").ToList();

            CdataGridView2.DataSource = inProgress;
        }



        private void C_btn_SaveChanges_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void dataGridView2_Clean_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CdataGridView2.Columns[6].Index && e.RowIndex >= 0)
            {
                var selectedValue = CdataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (selectedValue != null)
                {
                    MessageBox.Show("selectedValue : " + selectedValue);

                    var currentDescription = CdataGridView2.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

                    currentDescription += " " + selectedValue;

                    CdataGridView2.Rows[e.RowIndex].Cells[3].Value = currentDescription;

                    context.SaveChanges();
                }
            }
        }

        private void S_btn_ShowAll_Click(object sender, EventArgs e)
        {
            var ServicePerson = context.Services.Where(s => s.RequestType == "Service person").ToList();

            SdataGridView3.DataSource = ServicePerson;
        }

        private void S_btn_SaveChanges_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void dataGridView3_ChangeValue(object sender, DataGridViewCellEventArgs e)
        {

            if (SdataGridView3.Columns[e.ColumnIndex].Name == "SelectProcessingServiceP")
            {
                MessageBox.Show("Hei");
                if (e.ColumnIndex == SdataGridView3.Columns[6].Index && e.RowIndex > 0)
                {
                    var selectedValue = SdataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                    if (selectedValue != null)
                    {

                        var currentDescription = SdataGridView3.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

                        currentDescription += " " + selectedValue;

                        SdataGridView3.Rows[e.RowIndex].Cells[3].Value = currentDescription;


                    }
                }
                context.SaveChanges();
            }

            //    if (e.ColumnIndex == dataGridView3.Columns[6].Index && e.RowIndex > 0)
            //{
            //    var selectedValue = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            //    if (selectedValue != null)
            //    {

            //        var currentDescription = dataGridView3.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

            //        currentDescription += " " + selectedValue;

            //        dataGridView3.Rows[e.RowIndex].Cells[3].Value = currentDescription;


            //    }
            //}
            //context.SaveChanges();
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          

            if (e.ColumnIndex == CdataGridView2.Columns[6].Index && e.RowIndex > 0)
            {


                var selectedValue = CdataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                if (selectedValue != null)
                {
                    MessageBox.Show("selectedValue : " + selectedValue);

                    var currentDescription = CdataGridView2.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

                    currentDescription += " " + selectedValue;

                    CdataGridView2.Rows[e.RowIndex].Cells[3].Value = currentDescription;

                    context.SaveChanges();
                }
            }

            context.SaveChanges();
        }

     
    }
    
}

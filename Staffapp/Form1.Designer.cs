using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.VisualBasic.ApplicationServices;
using Staffapp.Data;
using Staffapp.Models;

namespace Staffapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;








       // public Form1(Assignment4V3Context context, LocalView<Room> rooms, LocalView<Reservation> reservations, LocalView<AspNetUser> users, LocalView<Service> services)
       //{
       //     this.context = context;
       //     Rooms = rooms;
       //     Reservations = reservations;
       //     Users = users;
       //     Services = services;
       // }
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            m_saveChanges = new Button();
            M_showAll = new Button();
            MdataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateRequestedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCompletedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            SelectProcessing = new DataGridViewComboBoxColumn();
            serviceBindingSource1 = new BindingSource(components);
            tabPage2 = new TabPage();
            C_btn_SaveChanges = new Button();
            CdataGridView2 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            requestTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateRequestedDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateCompletedDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            roomIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            SelectProcessingM = new DataGridViewComboBoxColumn();
            C_btn_ShowAll = new Button();
            tabPage3 = new TabPage();
            SdataGridView3 = new DataGridView();
            idDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            requestTypeDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dateRequestedDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dateCompletedDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            roomIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            SelectProcessingServiceP = new DataGridViewComboBoxColumn();
            S_btn_SaveChanges = new Button();
            S_btn_ShowAll = new Button();
            serviceBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MdataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CdataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SdataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1088, 525);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(m_saveChanges);
            tabPage1.Controls.Add(M_showAll);
            tabPage1.Controls.Add(MdataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1080, 492);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Maintainer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_saveChanges
            // 
            m_saveChanges.Location = new Point(116, 15);
            m_saveChanges.Name = "m_saveChanges";
            m_saveChanges.Size = new Size(132, 29);
            m_saveChanges.TabIndex = 2;
            m_saveChanges.Text = "Save Chenges";
            m_saveChanges.UseVisualStyleBackColor = true;
            m_saveChanges.Click += m_saveChanges_Click;
            // 
            // M_showAll
            // 
            M_showAll.Location = new Point(6, 15);
            M_showAll.Name = "M_showAll";
            M_showAll.Size = new Size(94, 29);
            M_showAll.TabIndex = 1;
            M_showAll.Text = "Show All ";
            M_showAll.UseVisualStyleBackColor = true;
            M_showAll.Click += dataGridView1_DoubleClick;
            // 
            // MdataGridView1
            // 
            MdataGridView1.AutoGenerateColumns = false;
            MdataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MdataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, requestTypeDataGridViewTextBoxColumn, dateRequestedDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dateCompletedDataGridViewTextBoxColumn, roomIdDataGridViewTextBoxColumn, SelectProcessing });
            MdataGridView1.DataSource = serviceBindingSource1;
            MdataGridView1.Location = new Point(3, 70);
            MdataGridView1.Name = "MdataGridView1";
            MdataGridView1.RowHeadersWidth = 51;
            MdataGridView1.Size = new Size(1071, 419);
            MdataGridView1.TabIndex = 0;
            MdataGridView1.DefaultCellStyleChanged += dataGridView1_DoubleClick;
            MdataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            MdataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // requestTypeDataGridViewTextBoxColumn
            // 
            requestTypeDataGridViewTextBoxColumn.DataPropertyName = "RequestType";
            requestTypeDataGridViewTextBoxColumn.HeaderText = "RequestType";
            requestTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            requestTypeDataGridViewTextBoxColumn.Name = "requestTypeDataGridViewTextBoxColumn";
            requestTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateRequestedDataGridViewTextBoxColumn
            // 
            dateRequestedDataGridViewTextBoxColumn.DataPropertyName = "DateRequested";
            dateRequestedDataGridViewTextBoxColumn.HeaderText = "DateRequested";
            dateRequestedDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateRequestedDataGridViewTextBoxColumn.Name = "dateRequestedDataGridViewTextBoxColumn";
            dateRequestedDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateCompletedDataGridViewTextBoxColumn
            // 
            dateCompletedDataGridViewTextBoxColumn.DataPropertyName = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn.HeaderText = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCompletedDataGridViewTextBoxColumn.Name = "dateCompletedDataGridViewTextBoxColumn";
            dateCompletedDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            roomIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // SelectProcessing
            // 
            SelectProcessing.HeaderText = "Select processing";
            SelectProcessing.Items.AddRange(new object[] { "New", "In Progress", "Finished" });
            SelectProcessing.MinimumWidth = 6;
            SelectProcessing.Name = "SelectProcessing";
            SelectProcessing.Width = 125;
            // 
            // serviceBindingSource1
            // 
            serviceBindingSource1.DataSource = typeof(Service);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(C_btn_SaveChanges);
            tabPage2.Controls.Add(CdataGridView2);
            tabPage2.Controls.Add(C_btn_ShowAll);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1080, 492);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cleaner";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // C_btn_SaveChanges
            // 
            C_btn_SaveChanges.Location = new Point(134, 14);
            C_btn_SaveChanges.Name = "C_btn_SaveChanges";
            C_btn_SaveChanges.Size = new Size(130, 29);
            C_btn_SaveChanges.TabIndex = 2;
            C_btn_SaveChanges.Text = "Save Changes";
            C_btn_SaveChanges.UseVisualStyleBackColor = true;
            C_btn_SaveChanges.Click += C_btn_SaveChanges_Click;
            // 
            // CdataGridView2
            // 
            CdataGridView2.AutoGenerateColumns = false;
            CdataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CdataGridView2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, requestTypeDataGridViewTextBoxColumn1, dateRequestedDataGridViewTextBoxColumn1, descriptionDataGridViewTextBoxColumn1, dateCompletedDataGridViewTextBoxColumn1, roomIdDataGridViewTextBoxColumn1, SelectProcessingM });
            CdataGridView2.DataSource = serviceBindingSource1;
            CdataGridView2.Location = new Point(13, 67);
            CdataGridView2.Name = "CdataGridView2";
            CdataGridView2.RowHeadersWidth = 51;
            CdataGridView2.Size = new Size(1022, 386);
            CdataGridView2.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // requestTypeDataGridViewTextBoxColumn1
            // 
            requestTypeDataGridViewTextBoxColumn1.DataPropertyName = "RequestType";
            requestTypeDataGridViewTextBoxColumn1.HeaderText = "RequestType";
            requestTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            requestTypeDataGridViewTextBoxColumn1.Name = "requestTypeDataGridViewTextBoxColumn1";
            requestTypeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateRequestedDataGridViewTextBoxColumn1
            // 
            dateRequestedDataGridViewTextBoxColumn1.DataPropertyName = "DateRequested";
            dateRequestedDataGridViewTextBoxColumn1.HeaderText = "DateRequested";
            dateRequestedDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dateRequestedDataGridViewTextBoxColumn1.Name = "dateRequestedDataGridViewTextBoxColumn1";
            dateRequestedDataGridViewTextBoxColumn1.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn1.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            descriptionDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateCompletedDataGridViewTextBoxColumn1
            // 
            dateCompletedDataGridViewTextBoxColumn1.DataPropertyName = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn1.HeaderText = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dateCompletedDataGridViewTextBoxColumn1.Name = "dateCompletedDataGridViewTextBoxColumn1";
            dateCompletedDataGridViewTextBoxColumn1.Width = 125;
            // 
            // roomIdDataGridViewTextBoxColumn1
            // 
            roomIdDataGridViewTextBoxColumn1.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn1.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            roomIdDataGridViewTextBoxColumn1.Name = "roomIdDataGridViewTextBoxColumn1";
            roomIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // SelectProcessingM
            // 
            SelectProcessingM.HeaderText = "Select Processing";
            SelectProcessingM.Items.AddRange(new object[] { "New ", "In Progress", "Finished" });
            SelectProcessingM.MinimumWidth = 6;
            SelectProcessingM.Name = "SelectProcessingM";
            SelectProcessingM.Width = 125;
            // 
            // C_btn_ShowAll
            // 
            C_btn_ShowAll.Location = new Point(23, 14);
            C_btn_ShowAll.Name = "C_btn_ShowAll";
            C_btn_ShowAll.Size = new Size(94, 29);
            C_btn_ShowAll.TabIndex = 0;
            C_btn_ShowAll.Text = "Show All";
            C_btn_ShowAll.UseVisualStyleBackColor = true;
            C_btn_ShowAll.Click += C_btn_ShowAll_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(SdataGridView3);
            tabPage3.Controls.Add(S_btn_SaveChanges);
            tabPage3.Controls.Add(S_btn_ShowAll);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1080, 492);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Service Person";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // SdataGridView3
            // 
            SdataGridView3.AutoGenerateColumns = false;
            SdataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SdataGridView3.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn2, requestTypeDataGridViewTextBoxColumn2, dateRequestedDataGridViewTextBoxColumn2, descriptionDataGridViewTextBoxColumn2, dateCompletedDataGridViewTextBoxColumn2, roomIdDataGridViewTextBoxColumn2, SelectProcessingServiceP });
            SdataGridView3.DataSource = serviceBindingSource1;
            SdataGridView3.Location = new Point(12, 79);
            SdataGridView3.Name = "SdataGridView3";
            SdataGridView3.RowHeadersWidth = 51;
            SdataGridView3.Size = new Size(928, 288);
            SdataGridView3.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn2.HeaderText = "Id";
            idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // requestTypeDataGridViewTextBoxColumn2
            // 
            requestTypeDataGridViewTextBoxColumn2.DataPropertyName = "RequestType";
            requestTypeDataGridViewTextBoxColumn2.HeaderText = "RequestType";
            requestTypeDataGridViewTextBoxColumn2.MinimumWidth = 6;
            requestTypeDataGridViewTextBoxColumn2.Name = "requestTypeDataGridViewTextBoxColumn2";
            requestTypeDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dateRequestedDataGridViewTextBoxColumn2
            // 
            dateRequestedDataGridViewTextBoxColumn2.DataPropertyName = "DateRequested";
            dateRequestedDataGridViewTextBoxColumn2.HeaderText = "DateRequested";
            dateRequestedDataGridViewTextBoxColumn2.MinimumWidth = 6;
            dateRequestedDataGridViewTextBoxColumn2.Name = "dateRequestedDataGridViewTextBoxColumn2";
            dateRequestedDataGridViewTextBoxColumn2.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            descriptionDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dateCompletedDataGridViewTextBoxColumn2
            // 
            dateCompletedDataGridViewTextBoxColumn2.DataPropertyName = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn2.HeaderText = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn2.MinimumWidth = 6;
            dateCompletedDataGridViewTextBoxColumn2.Name = "dateCompletedDataGridViewTextBoxColumn2";
            dateCompletedDataGridViewTextBoxColumn2.Width = 125;
            // 
            // roomIdDataGridViewTextBoxColumn2
            // 
            roomIdDataGridViewTextBoxColumn2.DataPropertyName = "RoomId";
            roomIdDataGridViewTextBoxColumn2.HeaderText = "RoomId";
            roomIdDataGridViewTextBoxColumn2.MinimumWidth = 6;
            roomIdDataGridViewTextBoxColumn2.Name = "roomIdDataGridViewTextBoxColumn2";
            roomIdDataGridViewTextBoxColumn2.Width = 125;
            // 
            // SelectProcessingServiceP
            // 
            SelectProcessingServiceP.HeaderText = "Select Processing";
            SelectProcessingServiceP.Items.AddRange(new object[] { "New ", "In Progress", "Finished" });
            SelectProcessingServiceP.MinimumWidth = 6;
            SelectProcessingServiceP.Name = "SelectProcessingServiceP";
            SelectProcessingServiceP.Resizable = DataGridViewTriState.True;
            SelectProcessingServiceP.SortMode = DataGridViewColumnSortMode.Automatic;
            SelectProcessingServiceP.Width = 125;
            // 
            // S_btn_SaveChanges
            // 
            S_btn_SaveChanges.Location = new Point(145, 17);
            S_btn_SaveChanges.Name = "S_btn_SaveChanges";
            S_btn_SaveChanges.Size = new Size(124, 29);
            S_btn_SaveChanges.TabIndex = 1;
            S_btn_SaveChanges.Text = "Save Changes";
            S_btn_SaveChanges.UseVisualStyleBackColor = true;
            S_btn_SaveChanges.Click += S_btn_SaveChanges_Click;
            // 
            // S_btn_ShowAll
            // 
            S_btn_ShowAll.Location = new Point(27, 17);
            S_btn_ShowAll.Name = "S_btn_ShowAll";
            S_btn_ShowAll.Size = new Size(94, 29);
            S_btn_ShowAll.TabIndex = 0;
            S_btn_ShowAll.Text = "Show All";
            S_btn_ShowAll.UseVisualStyleBackColor = true;
            S_btn_ShowAll.Click += S_btn_ShowAll_Click;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Service);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 549);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Staff App";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MdataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CdataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SdataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private BindingSource serviceBindingSource;
        private DataGridView MdataGridView1;
        private BindingSource serviceBindingSource1;
        private Button M_showAll;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requestTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateRequestedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCompletedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn SelectProcessing;
        private Button m_saveChanges;
        private Button C_btn_ShowAll;
        private DataGridView CdataGridView2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn requestTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateRequestedDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateCompletedDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn SelectProcessingM;
        private Button C_btn_SaveChanges;
        private Button S_btn_ShowAll;
        private Button S_btn_SaveChanges;
        private DataGridView SdataGridView3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn requestTypeDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dateRequestedDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dateCompletedDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn SelectProcessingServiceP;
        
    }
}

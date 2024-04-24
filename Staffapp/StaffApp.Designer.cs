namespace Staffapp
{
    partial class StaffApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Btn_Maintainer = new Button();
            Btn_Cleaner = new Button();
            Btn_service_person = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateRequestedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateCompletedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            RoomId = new DataGridViewTextBoxColumn();
            SelectProcessing = new DataGridViewComboBoxColumn();
            serviceBindingSource = new BindingSource(components);
            Btn_SaveChanges = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Btn_Maintainer
            // 
            Btn_Maintainer.Location = new Point(24, 28);
            Btn_Maintainer.Name = "Btn_Maintainer";
            Btn_Maintainer.Size = new Size(94, 29);
            Btn_Maintainer.TabIndex = 1;
            Btn_Maintainer.Text = "Maintainer";
            Btn_Maintainer.UseVisualStyleBackColor = true;
            Btn_Maintainer.Click += Btn_Maintainer_Click;
            // 
            // Btn_Cleaner
            // 
            Btn_Cleaner.Location = new Point(124, 28);
            Btn_Cleaner.Name = "Btn_Cleaner";
            Btn_Cleaner.Size = new Size(94, 29);
            Btn_Cleaner.TabIndex = 2;
            Btn_Cleaner.Text = "Cleaner";
            Btn_Cleaner.UseVisualStyleBackColor = true;
            Btn_Cleaner.Click += Btn_Cleaner_Click;
            // 
            // Btn_service_person
            // 
            Btn_service_person.Location = new Point(234, 28);
            Btn_service_person.Name = "Btn_service_person";
            Btn_service_person.Size = new Size(131, 29);
            Btn_service_person.TabIndex = 3;
            Btn_service_person.Text = "Service Person";
            Btn_service_person.UseVisualStyleBackColor = true;
            Btn_service_person.Click += Btn_service_person_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, requestTypeDataGridViewTextBoxColumn, dateRequestedDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dateCompletedDataGridViewTextBoxColumn, RoomId, SelectProcessing });
            dataGridView1.DataSource = serviceBindingSource;
            dataGridView1.Location = new Point(-1, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1128, 483);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellValueChanged;
            dataGridView1.CellContentClick += dataGridView1_CellValueChanged;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 50;
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
            descriptionDataGridViewTextBoxColumn.Width = 400;
            // 
            // dateCompletedDataGridViewTextBoxColumn
            // 
            dateCompletedDataGridViewTextBoxColumn.DataPropertyName = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn.HeaderText = "DateCompleted";
            dateCompletedDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateCompletedDataGridViewTextBoxColumn.Name = "dateCompletedDataGridViewTextBoxColumn";
            dateCompletedDataGridViewTextBoxColumn.Width = 175;
            // 
            // RoomId
            // 
            RoomId.DataPropertyName = "RoomId";
            RoomId.HeaderText = "RoomId";
            RoomId.MinimumWidth = 6;
            RoomId.Name = "RoomId";
            RoomId.Width = 75;
            // 
            // SelectProcessing
            // 
            SelectProcessing.HeaderText = "Select Processing";
            SelectProcessing.Items.AddRange(new object[] { "New", "In Progress", "Finished " });
            SelectProcessing.MinimumWidth = 6;
            SelectProcessing.Name = "SelectProcessing";
            SelectProcessing.Width = 125;
            // 
            // serviceBindingSource
            // 
            serviceBindingSource.DataSource = typeof(Models.Service);
            // 
            // Btn_SaveChanges
            // 
            Btn_SaveChanges.Location = new Point(947, 28);
            Btn_SaveChanges.Name = "Btn_SaveChanges";
            Btn_SaveChanges.Size = new Size(130, 29);
            Btn_SaveChanges.TabIndex = 5;
            Btn_SaveChanges.Text = "Save Changes";
            Btn_SaveChanges.UseVisualStyleBackColor = true;
            Btn_SaveChanges.Click += Btn_SaveChanges_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(739, 32);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 6;
            label1.Text = "Select the task, edit and save:";
            label1.Click += label1_Click;
            // 
            // StaffApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 591);
            Controls.Add(label1);
            Controls.Add(Btn_SaveChanges);
            Controls.Add(dataGridView1);
            Controls.Add(Btn_service_person);
            Controls.Add(Btn_Cleaner);
            Controls.Add(Btn_Maintainer);
            Name = "StaffApp";
            Text = "StaffApp";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button Btn_Maintainer;
        private Button Btn_Cleaner;
        private Button Btn_service_person;
        private DataGridView dataGridView1;
        private BindingSource serviceBindingSource;
        private Button Btn_SaveChanges;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requestTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateRequestedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateCompletedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewComboBoxColumn SelectProcessing;
        private Label label1;
    }
}
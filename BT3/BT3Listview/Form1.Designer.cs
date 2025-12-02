namespace BT3Listview
{
    partial class ListviewDemo
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ly",
            "Thi Bong",
            "23456"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nguyen",
            "Van Chinh",
            "4555"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Tran",
            "Chanh Truc",
            "123456"}, -1);
            this.b_addname = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lv_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // b_addname
            // 
            this.b_addname.Location = new System.Drawing.Point(656, 380);
            this.b_addname.Name = "b_addname";
            this.b_addname.Size = new System.Drawing.Size(119, 35);
            this.b_addname.TabIndex = 0;
            this.b_addname.Text = "Add Name";
            this.b_addname.UseVisualStyleBackColor = true;
            this.b_addname.Click += new System.EventHandler(this.b_addname_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_LastName,
            this.lv_FirstName,
            this.lv_Phone});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(30, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 371);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(514, 60);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(261, 22);
            this.LastNameText.TabIndex = 2;
            this.LastNameText.TextChanged += new System.EventHandler(this.LastNameText_TextChanged);
            // 
            // FirstNameText
            // 
            this.FirstNameText.Location = new System.Drawing.Point(514, 121);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(261, 22);
            this.FirstNameText.TabIndex = 3;
            this.FirstNameText.TextChanged += new System.EventHandler(this.FirstNameText_TextChanged);
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(514, 182);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(261, 22);
            this.PhoneText.TabIndex = 4;
            this.PhoneText.TextChanged += new System.EventHandler(this.PhoneText_TextChanged);
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Location = new System.Drawing.Point(511, 41);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(69, 16);
            this.lb_LastName.TabIndex = 5;
            this.lb_LastName.Text = "LastName";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Location = new System.Drawing.Point(511, 102);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(69, 16);
            this.lb_FirstName.TabIndex = 6;
            this.lb_FirstName.Text = "FirstName";
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(511, 163);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(46, 16);
            this.lb_Phone.TabIndex = 7;
            this.lb_Phone.Text = "Phone";
            // 
            // lv_LastName
            // 
            this.lv_LastName.Text = "LastName";
            this.lv_LastName.Width = 100;
            // 
            // lv_FirstName
            // 
            this.lv_FirstName.Text = "FirstName";
            this.lv_FirstName.Width = 100;
            // 
            // lv_Phone
            // 
            this.lv_Phone.Text = "Phone";
            this.lv_Phone.Width = 100;
            // 
            // ListviewDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Phone);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.lb_LastName);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.FirstNameText);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.b_addname);
            this.Name = "ListviewDemo";
            this.Text = "ListviewDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_addname;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox FirstNameText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.ColumnHeader lv_LastName;
        private System.Windows.Forms.ColumnHeader lv_FirstName;
        private System.Windows.Forms.ColumnHeader lv_Phone;
    }
}


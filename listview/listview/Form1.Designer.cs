namespace listview
{
    partial class LSView
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnum = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Updateclick = new System.Windows.Forms.Button();
            this.UpdateItems = new System.Windows.Forms.Button();
            this.Deleteclick = new System.Windows.Forms.Button();
            this.DeleteItems = new System.Windows.Forms.Button();
            this.Addclick = new System.Windows.Forms.Button();
            this.AddItems = new System.Windows.Forms.Button();
            this.Phone = new System.Windows.Forms.TextBox();
            this.LastN = new System.Windows.Forms.TextBox();
            this.FirstN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.PhoneNumber});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(519, 260);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 78;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 84;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.Width = 306;
            // 
            // pnum
            // 
            this.pnum.Location = new System.Drawing.Point(593, 153);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(203, 22);
            this.pnum.TabIndex = 8;
            //this.pnum.TextChanged += new System.EventHandler(this.pnum_TextChanged);
            // 
            // ln
            // 
            this.ln.Location = new System.Drawing.Point(30, 91);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(203, 22);
            this.ln.TabIndex = 9;
            //this.ln.TextChanged += new System.EventHandler(this.ln_TextChanged);
            // 
            // fn
            // 
            this.fn.Location = new System.Drawing.Point(30, 39);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(203, 22);
            this.fn.TabIndex = 10;
            //this.fn.TextChanged += new System.EventHandler(this.fn_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Updateclick);
            this.panel1.Controls.Add(this.ln);
            this.panel1.Controls.Add(this.UpdateItems);
            this.panel1.Controls.Add(this.fn);
            this.panel1.Controls.Add(this.Deleteclick);
            this.panel1.Controls.Add(this.DeleteItems);
            this.panel1.Controls.Add(this.Addclick);
            this.panel1.Controls.Add(this.AddItems);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.LastN);
            this.panel1.Controls.Add(this.FirstN);
            this.panel1.Location = new System.Drawing.Point(563, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 260);
            this.panel1.TabIndex = 7;
            // 
            // Updateclick
            // 
            this.Updateclick.Location = new System.Drawing.Point(165, 199);
            this.Updateclick.Name = "Updateclick";
            this.Updateclick.Size = new System.Drawing.Size(75, 30);
            this.Updateclick.TabIndex = 7;
            this.Updateclick.Text = "Update";
            this.Updateclick.UseVisualStyleBackColor = true;
            this.Updateclick.Click += new System.EventHandler(this.Updateclick_Click);
            // 
            // UpdateItems
            // 
            this.UpdateItems.Location = new System.Drawing.Point(433, 199);
            this.UpdateItems.Name = "UpdateItems";
            this.UpdateItems.Size = new System.Drawing.Size(75, 23);
            this.UpdateItems.TabIndex = 7;
            this.UpdateItems.Text = "Update";
            this.UpdateItems.UseVisualStyleBackColor = true;
            // 
            // Deleteclick
            // 
            this.Deleteclick.Location = new System.Drawing.Point(84, 199);
            this.Deleteclick.Name = "Deleteclick";
            this.Deleteclick.Size = new System.Drawing.Size(75, 30);
            this.Deleteclick.TabIndex = 8;
            this.Deleteclick.Text = "Delete";
            this.Deleteclick.UseVisualStyleBackColor = true;
            this.Deleteclick.Click += new System.EventHandler(this.Deleteclick_Click);
            // 
            // DeleteItems
            // 
            this.DeleteItems.Location = new System.Drawing.Point(352, 199);
            this.DeleteItems.Name = "DeleteItems";
            this.DeleteItems.Size = new System.Drawing.Size(75, 23);
            this.DeleteItems.TabIndex = 8;
            this.DeleteItems.Text = "Delete";
            this.DeleteItems.UseVisualStyleBackColor = true;
            // 
            // Addclick
            // 
            this.Addclick.Location = new System.Drawing.Point(3, 199);
            this.Addclick.Name = "Addclick";
            this.Addclick.Size = new System.Drawing.Size(75, 30);
            this.Addclick.TabIndex = 9;
            this.Addclick.Text = "Add";
            this.Addclick.UseVisualStyleBackColor = true;
            this.Addclick.Click += new System.EventHandler(this.Addclick_Click);
            // 
            // AddItems
            // 
            this.AddItems.Location = new System.Drawing.Point(271, 199);
            this.AddItems.Name = "AddItems";
            this.AddItems.Size = new System.Drawing.Size(75, 23);
            this.AddItems.TabIndex = 9;
            this.AddItems.Text = "Add";
            this.AddItems.UseVisualStyleBackColor = true;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(293, 142);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(203, 22);
            this.Phone.TabIndex = 4;
            // 
            // LastN
            // 
            this.LastN.Location = new System.Drawing.Point(293, 91);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(203, 22);
            this.LastN.TabIndex = 5;
            // 
            // FirstN
            // 
            this.FirstN.Location = new System.Drawing.Point(293, 39);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(203, 22);
            this.FirstN.TabIndex = 6;
            // 
            // LSView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 284);
            this.Controls.Add(this.pnum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "LSView";
            this.Text = "List View Sinh Vien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox pnum;
        private System.Windows.Forms.TextBox ln;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Updateclick;
        private System.Windows.Forms.Button UpdateItems;
        private System.Windows.Forms.Button Deleteclick;
        private System.Windows.Forms.Button DeleteItems;
        private System.Windows.Forms.Button Addclick;
        private System.Windows.Forms.Button AddItems;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox LastN;
        private System.Windows.Forms.TextBox FirstN;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
    }
}


namespace Railway_management_system
{
    partial class Dashboard
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
            this.Option = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.reservation = new System.Windows.Forms.Button();
            this.train = new System.Windows.Forms.Button();
            this.trainpanel = new System.Windows.Forms.Panel();
            this.traindatagrid = new System.Windows.Forms.DataGridView();
            this.route = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Arrival = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.searchtrain = new System.Windows.Forms.Button();
            this.deletetrain = new System.Windows.Forms.Button();
            this.updatetrain = new System.Windows.Forms.Button();
            this.createtrain = new System.Windows.Forms.Button();
            this.departure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reservationpanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Option.SuspendLayout();
            this.trainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traindatagrid)).BeginInit();
            this.reservationpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.welcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.BackColor = System.Drawing.Color.White;
            this.Option.Controls.Add(this.button5);
            this.Option.Controls.Add(this.reservation);
            this.Option.Controls.Add(this.train);
            this.Option.Location = new System.Drawing.Point(11, 10);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(206, 560);
            this.Option.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 60);
            this.button5.TabIndex = 4;
            this.button5.Text = "logout";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // reservation
            // 
            this.reservation.Location = new System.Drawing.Point(22, 242);
            this.reservation.Name = "reservation";
            this.reservation.Size = new System.Drawing.Size(150, 60);
            this.reservation.TabIndex = 3;
            this.reservation.Text = "reservation";
            this.reservation.UseVisualStyleBackColor = true;
            this.reservation.Click += new System.EventHandler(this.reservation_Click);
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(22, 57);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(150, 60);
            this.train.TabIndex = 0;
            this.train.Text = "train";
            this.train.UseVisualStyleBackColor = true;
            this.train.Click += new System.EventHandler(this.train_Click);
            // 
            // trainpanel
            // 
            this.trainpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.trainpanel.Controls.Add(this.traindatagrid);
            this.trainpanel.Controls.Add(this.route);
            this.trainpanel.Controls.Add(this.label6);
            this.trainpanel.Controls.Add(this.Arrival);
            this.trainpanel.Controls.Add(this.label7);
            this.trainpanel.Controls.Add(this.searchtrain);
            this.trainpanel.Controls.Add(this.deletetrain);
            this.trainpanel.Controls.Add(this.updatetrain);
            this.trainpanel.Controls.Add(this.createtrain);
            this.trainpanel.Controls.Add(this.departure);
            this.trainpanel.Controls.Add(this.label4);
            this.trainpanel.Controls.Add(this.speed);
            this.trainpanel.Controls.Add(this.label3);
            this.trainpanel.Controls.Add(this.tname);
            this.trainpanel.Controls.Add(this.label5);
            this.trainpanel.Location = new System.Drawing.Point(230, 12);
            this.trainpanel.Name = "trainpanel";
            this.trainpanel.Size = new System.Drawing.Size(696, 554);
            this.trainpanel.TabIndex = 2;
            this.trainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.trainpanel_Paint);
            // 
            // traindatagrid
            // 
            this.traindatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traindatagrid.Location = new System.Drawing.Point(108, 379);
            this.traindatagrid.Name = "traindatagrid";
            this.traindatagrid.RowHeadersWidth = 51;
            this.traindatagrid.RowTemplate.Height = 29;
            this.traindatagrid.Size = new System.Drawing.Size(484, 168);
            this.traindatagrid.TabIndex = 25;
            // 
            // route
            // 
            this.route.Location = new System.Drawing.Point(296, 226);
            this.route.Name = "route";
            this.route.Size = new System.Drawing.Size(214, 27);
            this.route.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "route";
            // 
            // Arrival
            // 
            this.Arrival.Location = new System.Drawing.Point(296, 179);
            this.Arrival.Name = "Arrival";
            this.Arrival.Size = new System.Drawing.Size(214, 27);
            this.Arrival.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "arrival time";
            // 
            // searchtrain
            // 
            this.searchtrain.Location = new System.Drawing.Point(443, 330);
            this.searchtrain.Name = "searchtrain";
            this.searchtrain.Size = new System.Drawing.Size(94, 29);
            this.searchtrain.TabIndex = 20;
            this.searchtrain.Text = "search";
            this.searchtrain.UseVisualStyleBackColor = true;
            this.searchtrain.Click += new System.EventHandler(this.button3_Click);
            // 
            // deletetrain
            // 
            this.deletetrain.Location = new System.Drawing.Point(331, 330);
            this.deletetrain.Name = "deletetrain";
            this.deletetrain.Size = new System.Drawing.Size(94, 29);
            this.deletetrain.TabIndex = 19;
            this.deletetrain.Text = "delete";
            this.deletetrain.UseVisualStyleBackColor = true;
            this.deletetrain.Click += new System.EventHandler(this.deletetrain_Click);
            // 
            // updatetrain
            // 
            this.updatetrain.Location = new System.Drawing.Point(220, 330);
            this.updatetrain.Name = "updatetrain";
            this.updatetrain.Size = new System.Drawing.Size(94, 29);
            this.updatetrain.TabIndex = 18;
            this.updatetrain.Text = "update";
            this.updatetrain.UseVisualStyleBackColor = true;
            this.updatetrain.Click += new System.EventHandler(this.updatetrain_Click);
            // 
            // createtrain
            // 
            this.createtrain.Location = new System.Drawing.Point(108, 330);
            this.createtrain.Name = "createtrain";
            this.createtrain.Size = new System.Drawing.Size(94, 29);
            this.createtrain.TabIndex = 17;
            this.createtrain.Text = "create";
            this.createtrain.UseVisualStyleBackColor = true;
            this.createtrain.Click += new System.EventHandler(this.createtrain_Click);
            // 
            // departure
            // 
            this.departure.Location = new System.Drawing.Point(296, 139);
            this.departure.Name = "departure";
            this.departure.Size = new System.Drawing.Size(214, 27);
            this.departure.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "departure time";
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(296, 92);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(214, 27);
            this.speed.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "speed";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(296, 51);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(214, 27);
            this.tname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Train name";
            // 
            // reservationpanel
            // 
            this.reservationpanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.reservationpanel.Controls.Add(this.comboBox1);
            this.reservationpanel.Controls.Add(this.dataGridView4);
            this.reservationpanel.Controls.Add(this.label20);
            this.reservationpanel.Controls.Add(this.button10);
            this.reservationpanel.Controls.Add(this.button11);
            this.reservationpanel.Controls.Add(this.button12);
            this.reservationpanel.Controls.Add(this.button13);
            this.reservationpanel.Controls.Add(this.textBox13);
            this.reservationpanel.Controls.Add(this.label21);
            this.reservationpanel.Controls.Add(this.textBox14);
            this.reservationpanel.Controls.Add(this.label22);
            this.reservationpanel.Controls.Add(this.textBox15);
            this.reservationpanel.Controls.Add(this.label23);
            this.reservationpanel.Controls.Add(this.textBox16);
            this.reservationpanel.Controls.Add(this.label24);
            this.reservationpanel.Location = new System.Drawing.Point(230, 12);
            this.reservationpanel.Name = "reservationpanel";
            this.reservationpanel.Size = new System.Drawing.Size(696, 559);
            this.reservationpanel.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(296, 232);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 28);
            this.comboBox1.TabIndex = 26;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(108, 379);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(484, 168);
            this.dataGridView4.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(120, 233);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 20);
            this.label20.TabIndex = 21;
            this.label20.Text = "train id";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(443, 330);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(94, 29);
            this.button10.TabIndex = 20;
            this.button10.Text = "search";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(331, 330);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 29);
            this.button11.TabIndex = 19;
            this.button11.Text = "delete";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(220, 330);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(94, 29);
            this.button12.TabIndex = 18;
            this.button12.Text = "update";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(108, 330);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 29);
            this.button13.TabIndex = 17;
            this.button13.Text = "create";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(296, 190);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(214, 27);
            this.textBox13.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(120, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(127, 20);
            this.label21.TabIndex = 15;
            this.label21.Text = "passenger gender";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(296, 143);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(214, 27);
            this.textBox14.TabIndex = 14;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(120, 146);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(122, 20);
            this.label22.TabIndex = 13;
            this.label22.Text = "passenger phone";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(296, 97);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(214, 27);
            this.textBox15.TabIndex = 12;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(120, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 20);
            this.label23.TabIndex = 11;
            this.label23.Text = "passenger email";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(296, 51);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(214, 27);
            this.textBox16.TabIndex = 10;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(120, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 20);
            this.label24.TabIndex = 9;
            this.label24.Text = "passenger name";
            // 
            // welcome
            // 
            this.welcome.BackColor = System.Drawing.Color.White;
            this.welcome.Controls.Add(this.label1);
            this.welcome.Location = new System.Drawing.Point(230, 12);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(696, 559);
            this.welcome.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Railway Management System";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.reservationpanel);
            this.Controls.Add(this.trainpanel);
            this.Controls.Add(this.Option);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Option.ResumeLayout(false);
            this.trainpanel.ResumeLayout(false);
            this.trainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traindatagrid)).EndInit();
            this.reservationpanel.ResumeLayout(false);
            this.reservationpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.welcome.ResumeLayout(false);
            this.welcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Option;
        private Button button5;
        private Button reservation;
        private Button train;
        private Panel trainpanel;
        private Button searchtrain;
        private Button deletetrain;
        private Button updatetrain;
        private Button createtrain;
        private TextBox departure;
        private Label label4;
        private TextBox speed;
        private Label label3;
        private TextBox tname;
        private Label label5;
        private TextBox route;
        private Label label6;
        private TextBox Arrival;
        private Label label7;
        private DataGridView traindatagrid;
        private Panel reservationpanel;
        private DataGridView dataGridView4;
        private Label label20;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private TextBox textBox13;
        private Label label21;
        private TextBox textBox14;
        private Label label22;
        private TextBox textBox15;
        private Label label23;
        private TextBox textBox16;
        private Label label24;
        private Panel welcome;
        private Label label1;
        private ComboBox comboBox1;
    }
}
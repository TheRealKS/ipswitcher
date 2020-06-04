namespace WindowsFormsApp1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.applyone = new System.Windows.Forms.Button();
            this.GATEWAY_ONE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SUBNET_ONE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IP_ONE = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.applytwo = new System.Windows.Forms.Button();
            this.GATEWAY_TWO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SUBNET_TWO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IP_TWO = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.applythree = new System.Windows.Forms.Button();
            this.GATEWAY_THREE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SUBNET_THREE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IP_THREE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DHCP = new System.Windows.Forms.Button();
            this.AdapterList = new System.Windows.Forms.ListBox();
            this.status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.applyone);
            this.groupBox1.Controls.Add(this.GATEWAY_ONE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SUBNET_ONE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IP_ONE);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(117, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP 1";
            // 
            // applyone
            // 
            this.applyone.Location = new System.Drawing.Point(4, 137);
            this.applyone.Margin = new System.Windows.Forms.Padding(2);
            this.applyone.Name = "applyone";
            this.applyone.Size = new System.Drawing.Size(56, 19);
            this.applyone.TabIndex = 14;
            this.applyone.Text = "Apply";
            this.applyone.UseVisualStyleBackColor = true;
            this.applyone.Click += new System.EventHandler(this.Applyone_Click);
            // 
            // GATEWAY_ONE
            // 
            this.GATEWAY_ONE.Location = new System.Drawing.Point(4, 113);
            this.GATEWAY_ONE.Margin = new System.Windows.Forms.Padding(2);
            this.GATEWAY_ONE.Name = "GATEWAY_ONE";
            this.GATEWAY_ONE.Size = new System.Drawing.Size(109, 20);
            this.GATEWAY_ONE.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gateway";
            // 
            // SUBNET_ONE
            // 
            this.SUBNET_ONE.Location = new System.Drawing.Point(4, 73);
            this.SUBNET_ONE.Margin = new System.Windows.Forms.Padding(2);
            this.SUBNET_ONE.Name = "SUBNET_ONE";
            this.SUBNET_ONE.Size = new System.Drawing.Size(109, 20);
            this.SUBNET_ONE.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subnet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // IP_ONE
            // 
            this.IP_ONE.Location = new System.Drawing.Point(4, 31);
            this.IP_ONE.Margin = new System.Windows.Forms.Padding(2);
            this.IP_ONE.Name = "IP_ONE";
            this.IP_ONE.Size = new System.Drawing.Size(109, 20);
            this.IP_ONE.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.applytwo);
            this.groupBox2.Controls.Add(this.GATEWAY_TWO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SUBNET_TWO);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.IP_TWO);
            this.groupBox2.Location = new System.Drawing.Point(131, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(117, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP 2";
            // 
            // applytwo
            // 
            this.applytwo.Location = new System.Drawing.Point(4, 137);
            this.applytwo.Margin = new System.Windows.Forms.Padding(2);
            this.applytwo.Name = "applytwo";
            this.applytwo.Size = new System.Drawing.Size(56, 19);
            this.applytwo.TabIndex = 10;
            this.applytwo.Text = "Apply";
            this.applytwo.UseVisualStyleBackColor = true;
            this.applytwo.Click += new System.EventHandler(this.Applytwo_Click);
            // 
            // GATEWAY_TWO
            // 
            this.GATEWAY_TWO.Location = new System.Drawing.Point(4, 113);
            this.GATEWAY_TWO.Margin = new System.Windows.Forms.Padding(2);
            this.GATEWAY_TWO.Name = "GATEWAY_TWO";
            this.GATEWAY_TWO.Size = new System.Drawing.Size(109, 20);
            this.GATEWAY_TWO.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gateway";
            // 
            // SUBNET_TWO
            // 
            this.SUBNET_TWO.Location = new System.Drawing.Point(4, 73);
            this.SUBNET_TWO.Margin = new System.Windows.Forms.Padding(2);
            this.SUBNET_TWO.Name = "SUBNET_TWO";
            this.SUBNET_TWO.Size = new System.Drawing.Size(109, 20);
            this.SUBNET_TWO.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Subnet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "IP";
            // 
            // IP_TWO
            // 
            this.IP_TWO.Location = new System.Drawing.Point(4, 31);
            this.IP_TWO.Margin = new System.Windows.Forms.Padding(2);
            this.IP_TWO.Name = "IP_TWO";
            this.IP_TWO.Size = new System.Drawing.Size(109, 20);
            this.IP_TWO.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.applythree);
            this.groupBox3.Controls.Add(this.GATEWAY_THREE);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.SUBNET_THREE);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.IP_THREE);
            this.groupBox3.Location = new System.Drawing.Point(253, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(117, 164);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP 3";
            // 
            // applythree
            // 
            this.applythree.Location = new System.Drawing.Point(4, 137);
            this.applythree.Margin = new System.Windows.Forms.Padding(2);
            this.applythree.Name = "applythree";
            this.applythree.Size = new System.Drawing.Size(56, 19);
            this.applythree.TabIndex = 11;
            this.applythree.Text = "Apply";
            this.applythree.UseVisualStyleBackColor = true;
            this.applythree.Click += new System.EventHandler(this.Applythree_Click);
            // 
            // GATEWAY_THREE
            // 
            this.GATEWAY_THREE.Location = new System.Drawing.Point(4, 113);
            this.GATEWAY_THREE.Margin = new System.Windows.Forms.Padding(2);
            this.GATEWAY_THREE.Name = "GATEWAY_THREE";
            this.GATEWAY_THREE.Size = new System.Drawing.Size(109, 20);
            this.GATEWAY_THREE.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Gateway";
            // 
            // SUBNET_THREE
            // 
            this.SUBNET_THREE.Location = new System.Drawing.Point(4, 73);
            this.SUBNET_THREE.Margin = new System.Windows.Forms.Padding(2);
            this.SUBNET_THREE.Name = "SUBNET_THREE";
            this.SUBNET_THREE.Size = new System.Drawing.Size(109, 20);
            this.SUBNET_THREE.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 56);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Subnet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 15);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "IP";
            // 
            // IP_THREE
            // 
            this.IP_THREE.Location = new System.Drawing.Point(4, 31);
            this.IP_THREE.Margin = new System.Windows.Forms.Padding(2);
            this.IP_THREE.Name = "IP_THREE";
            this.IP_THREE.Size = new System.Drawing.Size(109, 20);
            this.IP_THREE.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DHCP
            // 
            this.DHCP.Location = new System.Drawing.Point(79, 179);
            this.DHCP.Margin = new System.Windows.Forms.Padding(2);
            this.DHCP.Name = "DHCP";
            this.DHCP.Size = new System.Drawing.Size(56, 19);
            this.DHCP.TabIndex = 10;
            this.DHCP.Text = "DHCP";
            this.DHCP.UseVisualStyleBackColor = true;
            this.DHCP.Click += new System.EventHandler(this.DHCP_Click);
            // 
            // AdapterList
            // 
            this.AdapterList.FormattingEnabled = true;
            this.AdapterList.Location = new System.Drawing.Point(376, 11);
            this.AdapterList.Name = "AdapterList";
            this.AdapterList.Size = new System.Drawing.Size(162, 186);
            this.AdapterList.TabIndex = 13;
            this.AdapterList.SelectedIndexChanged += new System.EventHandler(this.AdapterList_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(141, 181);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 13);
            this.status.TabIndex = 14;
            this.status.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 207);
            this.Controls.Add(this.status);
            this.Controls.Add(this.AdapterList);
            this.Controls.Add(this.DHCP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "IPSwitcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IP_ONE;
        private System.Windows.Forms.TextBox GATEWAY_ONE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SUBNET_ONE;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox GATEWAY_TWO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SUBNET_TWO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IP_TWO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox GATEWAY_THREE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SUBNET_THREE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IP_THREE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DHCP;
        private System.Windows.Forms.ListBox AdapterList;
        private System.Windows.Forms.Button applyone;
        private System.Windows.Forms.Button applytwo;
        private System.Windows.Forms.Button applythree;
        private System.Windows.Forms.Label status;
    }
}


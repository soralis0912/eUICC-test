
namespace eUICC_test
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txb_send_cla = new System.Windows.Forms.TextBox();
            this.txb_send_ins = new System.Windows.Forms.TextBox();
            this.txb_send_p1 = new System.Windows.Forms.TextBox();
            this.txb_send_p2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_send_data = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_geticcid = new System.Windows.Forms.Button();
            this.txb_iccid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.txb_read_cla = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_read_ins = new System.Windows.Forms.TextBox();
            this.txb_read_le = new System.Windows.Forms.TextBox();
            this.txb_read_p1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txb_read_p2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 100;
            this.label1.Text = "カードリーダー機器名";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 228);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 21;
            this.dataGridView.Size = new System.Drawing.Size(586, 321);
            this.dataGridView.TabIndex = 8;
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(123, 12);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(1047, 20);
            this.comboBoxDevice.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(269, 141);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_send_cla
            // 
            this.txb_send_cla.Location = new System.Drawing.Point(62, 18);
            this.txb_send_cla.Name = "txb_send_cla";
            this.txb_send_cla.Size = new System.Drawing.Size(282, 19);
            this.txb_send_cla.TabIndex = 2;
            // 
            // txb_send_ins
            // 
            this.txb_send_ins.Location = new System.Drawing.Point(62, 43);
            this.txb_send_ins.Name = "txb_send_ins";
            this.txb_send_ins.Size = new System.Drawing.Size(282, 19);
            this.txb_send_ins.TabIndex = 3;
            // 
            // txb_send_p1
            // 
            this.txb_send_p1.Location = new System.Drawing.Point(62, 68);
            this.txb_send_p1.Name = "txb_send_p1";
            this.txb_send_p1.Size = new System.Drawing.Size(282, 19);
            this.txb_send_p1.TabIndex = 4;
            // 
            // txb_send_p2
            // 
            this.txb_send_p2.Location = new System.Drawing.Point(62, 93);
            this.txb_send_p2.Name = "txb_send_p2";
            this.txb_send_p2.Size = new System.Drawing.Size(282, 19);
            this.txb_send_p2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 101;
            this.label2.Text = "CLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 102;
            this.label3.Text = "INS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 12);
            this.label4.TabIndex = 103;
            this.label4.Text = "P1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 12);
            this.label5.TabIndex = 104;
            this.label5.Text = "P2";
            // 
            // txb_send_data
            // 
            this.txb_send_data.Location = new System.Drawing.Point(62, 118);
            this.txb_send_data.Name = "txb_send_data";
            this.txb_send_data.Size = new System.Drawing.Size(282, 19);
            this.txb_send_data.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 105;
            this.label6.Text = "DATA";
            // 
            // btn_geticcid
            // 
            this.btn_geticcid.Location = new System.Drawing.Point(6, 292);
            this.btn_geticcid.Name = "btn_geticcid";
            this.btn_geticcid.Size = new System.Drawing.Size(75, 23);
            this.btn_geticcid.TabIndex = 10;
            this.btn_geticcid.Text = "get iccid";
            this.btn_geticcid.UseVisualStyleBackColor = true;
            this.btn_geticcid.Click += new System.EventHandler(this.btn_getccid_Click);
            // 
            // txb_iccid
            // 
            this.txb_iccid.Location = new System.Drawing.Point(77, 18);
            this.txb_iccid.Name = "txb_iccid";
            this.txb_iccid.ReadOnly = true;
            this.txb_iccid.Size = new System.Drawing.Size(168, 19);
            this.txb_iccid.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_geticcid);
            this.groupBox1.Controls.Add(this.txb_iccid);
            this.groupBox1.Location = new System.Drawing.Point(604, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 321);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sim Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "ICCID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Controls.Add(this.txb_send_cla);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txb_send_ins);
            this.groupBox2.Controls.Add(this.txb_send_data);
            this.groupBox2.Controls.Add(this.txb_send_p1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txb_send_p2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(14, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 170);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Send Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_read);
            this.groupBox3.Controls.Add(this.txb_read_cla);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txb_read_ins);
            this.groupBox3.Controls.Add(this.txb_read_le);
            this.groupBox3.Controls.Add(this.txb_read_p1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txb_read_p2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(390, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 170);
            this.groupBox3.TabIndex = 107;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Read Data";
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(269, 141);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 7;
            this.btn_read.Text = "read";
            this.btn_read.UseVisualStyleBackColor = true;
            // 
            // txb_read_cla
            // 
            this.txb_read_cla.Location = new System.Drawing.Point(62, 18);
            this.txb_read_cla.Name = "txb_read_cla";
            this.txb_read_cla.Size = new System.Drawing.Size(282, 19);
            this.txb_read_cla.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 12);
            this.label8.TabIndex = 105;
            this.label8.Text = "LE";
            // 
            // txb_read_ins
            // 
            this.txb_read_ins.Location = new System.Drawing.Point(62, 43);
            this.txb_read_ins.Name = "txb_read_ins";
            this.txb_read_ins.Size = new System.Drawing.Size(282, 19);
            this.txb_read_ins.TabIndex = 3;
            // 
            // txb_read_le
            // 
            this.txb_read_le.Location = new System.Drawing.Point(62, 118);
            this.txb_read_le.Name = "txb_read_le";
            this.txb_read_le.Size = new System.Drawing.Size(282, 19);
            this.txb_read_le.TabIndex = 6;
            // 
            // txb_read_p1
            // 
            this.txb_read_p1.Location = new System.Drawing.Point(62, 68);
            this.txb_read_p1.Name = "txb_read_p1";
            this.txb_read_p1.Size = new System.Drawing.Size(282, 19);
            this.txb_read_p1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 12);
            this.label9.TabIndex = 104;
            this.label9.Text = "P2";
            // 
            // txb_read_p2
            // 
            this.txb_read_p2.Location = new System.Drawing.Point(62, 93);
            this.txb_read_p2.Name = "txb_read_p2";
            this.txb_read_p2.Size = new System.Drawing.Size(282, 19);
            this.txb_read_p2.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 12);
            this.label10.TabIndex = 103;
            this.label10.Text = "P1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 12);
            this.label11.TabIndex = 101;
            this.label11.Text = "CLA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 102;
            this.label12.Text = "INS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txb_send_cla;
        private System.Windows.Forms.TextBox txb_send_ins;
        private System.Windows.Forms.TextBox txb_send_p1;
        private System.Windows.Forms.TextBox txb_send_p2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_send_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_iccid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button btn_geticcid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.TextBox txb_read_cla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_read_ins;
        private System.Windows.Forms.TextBox txb_read_le;
        private System.Windows.Forms.TextBox txb_read_p1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txb_read_p2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}


namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rtb_content = new System.Windows.Forms.RichTextBox();
            this.btn_connectserail = new System.Windows.Forms.Button();
            this.cb_serialportlist = new System.Windows.Forms.ComboBox();
            this.t_updateRcBox = new System.Windows.Forms.Timer(this.components);
            this.btn_stop = new System.Windows.Forms.Button();
            this.lb_nor = new System.Windows.Forms.Label();
            this.lb_est = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_content
            // 
            this.rtb_content.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_content.Location = new System.Drawing.Point(710, 78);
            this.rtb_content.Margin = new System.Windows.Forms.Padding(4);
            this.rtb_content.Name = "rtb_content";
            this.rtb_content.Size = new System.Drawing.Size(434, 217);
            this.rtb_content.TabIndex = 0;
            this.rtb_content.Text = "";
            // 
            // btn_connectserail
            // 
            this.btn_connectserail.Location = new System.Drawing.Point(187, 27);
            this.btn_connectserail.Margin = new System.Windows.Forms.Padding(4);
            this.btn_connectserail.Name = "btn_connectserail";
            this.btn_connectserail.Size = new System.Drawing.Size(107, 28);
            this.btn_connectserail.TabIndex = 1;
            this.btn_connectserail.Text = "連線";
            this.btn_connectserail.UseVisualStyleBackColor = true;
            this.btn_connectserail.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cb_serialportlist
            // 
            this.cb_serialportlist.FormattingEnabled = true;
            this.cb_serialportlist.Location = new System.Drawing.Point(44, 27);
            this.cb_serialportlist.Name = "cb_serialportlist";
            this.cb_serialportlist.Size = new System.Drawing.Size(112, 28);
            this.cb_serialportlist.TabIndex = 2;
            this.cb_serialportlist.SelectedIndexChanged += new System.EventHandler(this.Cb_serialportlist_SelectedIndexChanged);
            // 
            // t_updateRcBox
            // 
            this.t_updateRcBox.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(317, 27);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(102, 28);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // lb_nor
            // 
            this.lb_nor.AutoSize = true;
            this.lb_nor.Location = new System.Drawing.Point(185, 193);
            this.lb_nor.Name = "lb_nor";
            this.lb_nor.Size = new System.Drawing.Size(56, 20);
            this.lb_nor.TabIndex = 4;
            this.lb_nor.Text = "lb_nor";
            this.lb_nor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_est
            // 
            this.lb_est.AutoSize = true;
            this.lb_est.Location = new System.Drawing.Point(185, 241);
            this.lb_est.Name = "lb_est";
            this.lb_est.Size = new System.Drawing.Size(52, 20);
            this.lb_est.TabIndex = 4;
            this.lb_est.Text = "lb_est";
            this.lb_est.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(185, 144);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(65, 20);
            this.lb_time.TabIndex = 5;
            this.lb_time.Text = "lb_time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(185, 292);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(62, 20);
            this.lb_date.TabIndex = 9;
            this.lb_date.Text = "lb_date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 357);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_est);
            this.Controls.Add(this.lb_nor);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.cb_serialportlist);
            this.Controls.Add(this.btn_connectserail);
            this.Controls.Add(this.rtb_content);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_content;
        private System.Windows.Forms.Button btn_connectserail;
        private System.Windows.Forms.ComboBox cb_serialportlist;
        private System.Windows.Forms.Timer t_updateRcBox;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lb_nor;
        private System.Windows.Forms.Label lb_est;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


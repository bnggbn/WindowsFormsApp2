namespace WindowsFormsApp2
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.enter = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.jonio = new System.Windows.Forms.ComboBox();
            this.jtyp = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.Label();
            this.thing = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.jondiscount = new System.Windows.Forms.ComboBox();
            this.money = new System.Windows.Forms.Label();
            this.jmon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp2.Properties.Settings.Default, "comfirm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enter.Location = new System.Drawing.Point(197, 176);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(75, 23);
            this.enter.TabIndex = 0;
            this.enter.Text = global::WindowsFormsApp2.Properties.Settings.Default.comfirm;
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // clear
            // 
            this.clear.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp2.Properties.Settings.Default, "clear", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.clear.Location = new System.Drawing.Point(197, 214);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = global::WindowsFormsApp2.Properties.Settings.Default.clear;
            this.clear.UseVisualStyleBackColor = true;
            // 
            // jonio
            //
            this.jonio.FormattingEnabled = true;
            this.jonio.Items.AddRange(new object[] {
            });

            this.jonio.Location = new System.Drawing.Point(101, 61);
            this.jonio.Name = "jonio";
            this.jonio.Size = new System.Drawing.Size(69, 20);
            this.jonio.TabIndex = 2;
            this.jonio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // jtyp
            // 
            this.jtyp.Location = new System.Drawing.Point(101, 25);
            this.jtyp.MaxLength = 5;
            this.jtyp.Name = "jtyp";
            this.jtyp.Size = new System.Drawing.Size(100, 22);
            this.jtyp.TabIndex = 3;
            this.jtyp.TextChanged += new System.EventHandler(this.jtyp_TextChanged);
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp2.Properties.Settings.Default, "inout", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.type.Location = new System.Drawing.Point(31, 69);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(29, 12);
            this.type.TabIndex = 4;
            this.type.Text = global::WindowsFormsApp2.Properties.Settings.Default.inout;
            // 
            // thing
            // 
            this.thing.AutoSize = true;
            this.thing.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp2.Properties.Settings.Default, "type", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.thing.Location = new System.Drawing.Point(31, 35);
            this.thing.Name = "thing";
            this.thing.Size = new System.Drawing.Size(29, 12);
            this.thing.TabIndex = 5;
            this.thing.Text = global::WindowsFormsApp2.Properties.Settings.Default.type;
            // 
            // discount
            // 

            this.discount.AutoSize = true;
            this.discount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp2.Properties.Settings.Default, "off", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.discount.Location = new System.Drawing.Point(31, 102);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(29, 12);
            this.discount.TabIndex = 6;
            this.discount.Text = global::WindowsFormsApp2.Properties.Settings.Default.off;
            // 
            // jondiscount
            // 
            this.jondiscount.DisplayMember = "Key";
            this.jondiscount.FormattingEnabled = true;
            this.jondiscount.Items.AddRange(new object[] {
            "無",
            "9折"});
            this.jondiscount.Location = new System.Drawing.Point(101, 94);
            this.jondiscount.Name = "jondiscount";
            this.jondiscount.Size = new System.Drawing.Size(69, 20);
            this.jondiscount.TabIndex = 0;
            this.jondiscount.ValueMember = "Value";
            this.jondiscount.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp2.Properties.Settings.Default, "jonmoney", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.money.Location = new System.Drawing.Point(31, 130);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(29, 12);
            this.money.TabIndex = 7;
            this.money.Text = global::WindowsFormsApp2.Properties.Settings.Default.jonmoney;
            // 
            // jmon
            // 
            this.jmon.Location = new System.Drawing.Point(101, 120);
            this.jmon.MaxLength = 7;
            this.jmon.Name = "jmon";
            this.jmon.Size = new System.Drawing.Size(100, 22);
            this.jmon.TabIndex = 8;
            this.jmon.TextChanged += new System.EventHandler(this.jmon_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);

            this.Controls.Add(this.jmon);
            this.Controls.Add(this.money);
            this.Controls.Add(this.jondiscount);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.thing);
            this.Controls.Add(this.type);
            this.Controls.Add(this.jtyp);
            this.Controls.Add(this.jonio);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.enter);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WindowsFormsApp2.Properties.Settings.Default, "jkac", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "Form1";
            this.Text = global::WindowsFormsApp2.Properties.Settings.Default.jkac;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ComboBox jonio;
        private System.Windows.Forms.TextBox jtyp;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label thing;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.ComboBox jondiscount;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox jmon;
    }
   /* public class discount
    {
        public discount(string jdis, double jvalue)
        {
            jdis = disname;
            jvalue = disvalue;
        }
        
        public override string ToString()
        {
            return disname;
        }

        
    }*/
}


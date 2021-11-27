namespace vallet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_reload = new System.Windows.Forms.Button();
            this.lavel_usd = new System.Windows.Forms.Label();
            this.label_eur = new System.Windows.Forms.Label();
            this.label_usd_sell = new System.Windows.Forms.Label();
            this.label_eur_sell = new System.Windows.Forms.Label();
            this.label_usd_buy = new System.Windows.Forms.Label();
            this.label_eur_buy = new System.Windows.Forms.Label();
            this.label_cny = new System.Windows.Forms.Label();
            this.label_kgs = new System.Windows.Forms.Label();
            this.label_rub = new System.Windows.Forms.Label();
            this.label_gbp = new System.Windows.Forms.Label();
            this.label_jpy = new System.Windows.Forms.Label();
            this.label_cny_sell = new System.Windows.Forms.Label();
            this.label_kgs_sell = new System.Windows.Forms.Label();
            this.label_rub_sell = new System.Windows.Forms.Label();
            this.label_gbp_sell = new System.Windows.Forms.Label();
            this.label_jpy_sell = new System.Windows.Forms.Label();
            this.label_cny_buy = new System.Windows.Forms.Label();
            this.label_kgs_buy = new System.Windows.Forms.Label();
            this.label_rub_buy = new System.Windows.Forms.Label();
            this.label_gbp_buy = new System.Windows.Forms.Label();
            this.label_jpy_buy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_reload
            // 
            this.button_reload.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reload.Location = new System.Drawing.Point(17, 201);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(291, 69);
            this.button_reload.TabIndex = 0;
            this.button_reload.Text = "Обновить";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button1_Click);
            // 
            // lavel_usd
            // 
            this.lavel_usd.AutoSize = true;
            this.lavel_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lavel_usd.Location = new System.Drawing.Point(12, 9);
            this.lavel_usd.Name = "lavel_usd";
            this.lavel_usd.Size = new System.Drawing.Size(100, 25);
            this.lavel_usd.TabIndex = 1;
            this.lavel_usd.Text = "Доллар: ";
            // 
            // label_eur
            // 
            this.label_eur.AutoSize = true;
            this.label_eur.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_eur.Location = new System.Drawing.Point(39, 34);
            this.label_eur.Name = "label_eur";
            this.label_eur.Size = new System.Drawing.Size(73, 25);
            this.label_eur.TabIndex = 2;
            this.label_eur.Text = "Евро: ";
            // 
            // label_usd_sell
            // 
            this.label_usd_sell.AutoSize = true;
            this.label_usd_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_usd_sell.Location = new System.Drawing.Point(118, 9);
            this.label_usd_sell.Name = "label_usd_sell";
            this.label_usd_sell.Size = new System.Drawing.Size(18, 25);
            this.label_usd_sell.TabIndex = 3;
            this.label_usd_sell.Text = " ";
            // 
            // label_eur_sell
            // 
            this.label_eur_sell.AutoSize = true;
            this.label_eur_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_eur_sell.Location = new System.Drawing.Point(118, 34);
            this.label_eur_sell.Name = "label_eur_sell";
            this.label_eur_sell.Size = new System.Drawing.Size(0, 25);
            this.label_eur_sell.TabIndex = 4;
            // 
            // label_usd_buy
            // 
            this.label_usd_buy.AutoSize = true;
            this.label_usd_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_usd_buy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_usd_buy.Location = new System.Drawing.Point(221, 9);
            this.label_usd_buy.Name = "label_usd_buy";
            this.label_usd_buy.Size = new System.Drawing.Size(18, 25);
            this.label_usd_buy.TabIndex = 5;
            this.label_usd_buy.Text = " ";
            // 
            // label_eur_buy
            // 
            this.label_eur_buy.AutoSize = true;
            this.label_eur_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_eur_buy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_eur_buy.Location = new System.Drawing.Point(221, 34);
            this.label_eur_buy.Name = "label_eur_buy";
            this.label_eur_buy.Size = new System.Drawing.Size(18, 25);
            this.label_eur_buy.TabIndex = 6;
            this.label_eur_buy.Text = " ";
            // 
            // label_cny
            // 
            this.label_cny.AutoSize = true;
            this.label_cny.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cny.Location = new System.Drawing.Point(32, 59);
            this.label_cny.Name = "label_cny";
            this.label_cny.Size = new System.Drawing.Size(80, 25);
            this.label_cny.TabIndex = 7;
            this.label_cny.Text = "Юань: ";
            // 
            // label_kgs
            // 
            this.label_kgs.AutoSize = true;
            this.label_kgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kgs.Location = new System.Drawing.Point(46, 84);
            this.label_kgs.Name = "label_kgs";
            this.label_kgs.Size = new System.Drawing.Size(66, 25);
            this.label_kgs.TabIndex = 8;
            this.label_kgs.Text = "Сом: ";
            // 
            // label_rub
            // 
            this.label_rub.AutoSize = true;
            this.label_rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rub.Location = new System.Drawing.Point(28, 109);
            this.label_rub.Name = "label_rub";
            this.label_rub.Size = new System.Drawing.Size(84, 25);
            this.label_rub.TabIndex = 9;
            this.label_rub.Text = "Рубль: ";
            // 
            // label_gbp
            // 
            this.label_gbp.AutoSize = true;
            this.label_gbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gbp.Location = new System.Drawing.Point(37, 134);
            this.label_gbp.Name = "label_gbp";
            this.label_gbp.Size = new System.Drawing.Size(75, 25);
            this.label_gbp.TabIndex = 10;
            this.label_gbp.Text = "Фунт: ";
            // 
            // label_jpy
            // 
            this.label_jpy.AutoSize = true;
            this.label_jpy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_jpy.Location = new System.Drawing.Point(37, 159);
            this.label_jpy.Name = "label_jpy";
            this.label_jpy.Size = new System.Drawing.Size(75, 25);
            this.label_jpy.TabIndex = 11;
            this.label_jpy.Text = "Йена: ";
            // 
            // label_cny_sell
            // 
            this.label_cny_sell.AutoSize = true;
            this.label_cny_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cny_sell.Location = new System.Drawing.Point(118, 59);
            this.label_cny_sell.Name = "label_cny_sell";
            this.label_cny_sell.Size = new System.Drawing.Size(18, 25);
            this.label_cny_sell.TabIndex = 12;
            this.label_cny_sell.Text = " ";
            // 
            // label_kgs_sell
            // 
            this.label_kgs_sell.AutoSize = true;
            this.label_kgs_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kgs_sell.Location = new System.Drawing.Point(118, 84);
            this.label_kgs_sell.Name = "label_kgs_sell";
            this.label_kgs_sell.Size = new System.Drawing.Size(18, 25);
            this.label_kgs_sell.TabIndex = 13;
            this.label_kgs_sell.Text = " ";
            // 
            // label_rub_sell
            // 
            this.label_rub_sell.AutoSize = true;
            this.label_rub_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rub_sell.Location = new System.Drawing.Point(118, 109);
            this.label_rub_sell.Name = "label_rub_sell";
            this.label_rub_sell.Size = new System.Drawing.Size(18, 25);
            this.label_rub_sell.TabIndex = 14;
            this.label_rub_sell.Text = " ";
            // 
            // label_gbp_sell
            // 
            this.label_gbp_sell.AutoSize = true;
            this.label_gbp_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gbp_sell.Location = new System.Drawing.Point(118, 134);
            this.label_gbp_sell.Name = "label_gbp_sell";
            this.label_gbp_sell.Size = new System.Drawing.Size(18, 25);
            this.label_gbp_sell.TabIndex = 15;
            this.label_gbp_sell.Text = " ";
            // 
            // label_jpy_sell
            // 
            this.label_jpy_sell.AutoSize = true;
            this.label_jpy_sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_jpy_sell.Location = new System.Drawing.Point(118, 159);
            this.label_jpy_sell.Name = "label_jpy_sell";
            this.label_jpy_sell.Size = new System.Drawing.Size(18, 25);
            this.label_jpy_sell.TabIndex = 16;
            this.label_jpy_sell.Text = " ";
            // 
            // label_cny_buy
            // 
            this.label_cny_buy.AutoSize = true;
            this.label_cny_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cny_buy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_cny_buy.Location = new System.Drawing.Point(221, 59);
            this.label_cny_buy.Name = "label_cny_buy";
            this.label_cny_buy.Size = new System.Drawing.Size(18, 25);
            this.label_cny_buy.TabIndex = 17;
            this.label_cny_buy.Text = " ";
            // 
            // label_kgs_buy
            // 
            this.label_kgs_buy.AutoSize = true;
            this.label_kgs_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kgs_buy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_kgs_buy.Location = new System.Drawing.Point(221, 84);
            this.label_kgs_buy.Name = "label_kgs_buy";
            this.label_kgs_buy.Size = new System.Drawing.Size(18, 25);
            this.label_kgs_buy.TabIndex = 18;
            this.label_kgs_buy.Text = " ";
            // 
            // label_rub_buy
            // 
            this.label_rub_buy.AutoSize = true;
            this.label_rub_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rub_buy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_rub_buy.Location = new System.Drawing.Point(221, 109);
            this.label_rub_buy.Name = "label_rub_buy";
            this.label_rub_buy.Size = new System.Drawing.Size(18, 25);
            this.label_rub_buy.TabIndex = 19;
            this.label_rub_buy.Text = " ";
            // 
            // label_gbp_buy
            // 
            this.label_gbp_buy.AutoSize = true;
            this.label_gbp_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_gbp_buy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_gbp_buy.Location = new System.Drawing.Point(221, 134);
            this.label_gbp_buy.Name = "label_gbp_buy";
            this.label_gbp_buy.Size = new System.Drawing.Size(18, 25);
            this.label_gbp_buy.TabIndex = 20;
            this.label_gbp_buy.Text = " ";
            // 
            // label_jpy_buy
            // 
            this.label_jpy_buy.AutoSize = true;
            this.label_jpy_buy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_jpy_buy.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_jpy_buy.Location = new System.Drawing.Point(221, 159);
            this.label_jpy_buy.Name = "label_jpy_buy";
            this.label_jpy_buy.Size = new System.Drawing.Size(18, 25);
            this.label_jpy_buy.TabIndex = 21;
            this.label_jpy_buy.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 288);
            this.Controls.Add(this.label_jpy_buy);
            this.Controls.Add(this.label_gbp_buy);
            this.Controls.Add(this.label_rub_buy);
            this.Controls.Add(this.label_kgs_buy);
            this.Controls.Add(this.label_cny_buy);
            this.Controls.Add(this.label_jpy_sell);
            this.Controls.Add(this.label_gbp_sell);
            this.Controls.Add(this.label_rub_sell);
            this.Controls.Add(this.label_kgs_sell);
            this.Controls.Add(this.label_cny_sell);
            this.Controls.Add(this.label_jpy);
            this.Controls.Add(this.label_gbp);
            this.Controls.Add(this.label_rub);
            this.Controls.Add(this.label_kgs);
            this.Controls.Add(this.label_cny);
            this.Controls.Add(this.label_eur_buy);
            this.Controls.Add(this.label_usd_buy);
            this.Controls.Add(this.label_eur_sell);
            this.Controls.Add(this.label_usd_sell);
            this.Controls.Add(this.label_eur);
            this.Controls.Add(this.lavel_usd);
            this.Controls.Add(this.button_reload);
            this.Name = "Form1";
            this.Text = "Курс валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Label lavel_usd;
        private System.Windows.Forms.Label label_eur;
        private System.Windows.Forms.Label label_usd_sell;
        private System.Windows.Forms.Label label_eur_sell;
        private System.Windows.Forms.Label label_usd_buy;
        private System.Windows.Forms.Label label_eur_buy;
        private System.Windows.Forms.Label label_cny;
        private System.Windows.Forms.Label label_kgs;
        private System.Windows.Forms.Label label_rub;
        private System.Windows.Forms.Label label_gbp;
        private System.Windows.Forms.Label label_jpy;
        private System.Windows.Forms.Label label_cny_sell;
        private System.Windows.Forms.Label label_kgs_sell;
        private System.Windows.Forms.Label label_rub_sell;
        private System.Windows.Forms.Label label_gbp_sell;
        private System.Windows.Forms.Label label_jpy_sell;
        private System.Windows.Forms.Label label_cny_buy;
        private System.Windows.Forms.Label label_kgs_buy;
        private System.Windows.Forms.Label label_rub_buy;
        private System.Windows.Forms.Label label_gbp_buy;
        private System.Windows.Forms.Label label_jpy_buy;
    }
}


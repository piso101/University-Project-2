﻿namespace ProjektProgramowanie2Dentysta
{
    partial class Form2
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.name_box = new System.Windows.Forms.TextBox();
			this.date_box = new System.Windows.Forms.DateTimePicker();
			this.hour_box = new System.Windows.Forms.ComboBox();
			this.main_btn = new System.Windows.Forms.Button();
			this.book_btn = new System.Windows.Forms.Button();
			this.message_box = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// name_box
			// 
			this.name_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.name_box.Location = new System.Drawing.Point(236, 163);
			this.name_box.Name = "name_box";
			this.name_box.Size = new System.Drawing.Size(188, 20);
			this.name_box.TabIndex = 0;
			this.name_box.Text = "Imię i nazwisko";
			this.name_box.TextChanged += new System.EventHandler(this.name_box_TextChanged);
			// 
			// date_box
			// 
			this.date_box.AllowDrop = true;
			this.date_box.CalendarMonthBackground = System.Drawing.Color.Transparent;
			this.date_box.CalendarTitleBackColor = System.Drawing.Color.Transparent;
			this.date_box.CalendarTitleForeColor = System.Drawing.Color.Transparent;
			this.date_box.CustomFormat = "yyyy\'-\'MM\'-\'dd";
			this.date_box.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.date_box.Location = new System.Drawing.Point(236, 208);
			this.date_box.Name = "date_box";
			this.date_box.Size = new System.Drawing.Size(188, 20);
			this.date_box.TabIndex = 1;
			this.date_box.ValueChanged += new System.EventHandler(this.date_box_ValueChanged);
			// 
			// hour_box
			// 
			this.hour_box.Items.AddRange(new object[] {
            "Proszę wybrać datę."});
			this.hour_box.Location = new System.Drawing.Point(236, 252);
			this.hour_box.Name = "hour_box";
			this.hour_box.Size = new System.Drawing.Size(188, 21);
			this.hour_box.TabIndex = 3;
			this.hour_box.SelectedIndexChanged += new System.EventHandler(this.hour_box_SelectedIndexChanged);
			// 
			// main_btn
			// 
			this.main_btn.BackColor = System.Drawing.Color.Transparent;
			this.main_btn.FlatAppearance.BorderSize = 0;
			this.main_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.main_btn.Location = new System.Drawing.Point(11, 10);
			this.main_btn.Name = "main_btn";
			this.main_btn.Size = new System.Drawing.Size(46, 44);
			this.main_btn.TabIndex = 4;
			this.main_btn.UseVisualStyleBackColor = false;
			this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
			// 
			// book_btn
			// 
			this.book_btn.BackColor = System.Drawing.Color.Transparent;
			this.book_btn.FlatAppearance.BorderSize = 0;
			this.book_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.book_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.book_btn.Location = new System.Drawing.Point(203, 356);
			this.book_btn.Name = "book_btn";
			this.book_btn.Size = new System.Drawing.Size(232, 34);
			this.book_btn.TabIndex = 5;
			this.book_btn.UseVisualStyleBackColor = false;
			this.book_btn.Click += new System.EventHandler(this.book_btn_Click);
			// 
			// message_box
			// 
			this.message_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.message_box.Location = new System.Drawing.Point(236, 296);
			this.message_box.Name = "message_box";
			this.message_box.Size = new System.Drawing.Size(188, 20);
			this.message_box.TabIndex = 6;
			this.message_box.Text = "Uwagi (max 250 znaków)";
			this.message_box.TextChanged += new System.EventHandler(this.message_box_TextChanged);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(640, 450);
			this.Controls.Add(this.message_box);
			this.Controls.Add(this.book_btn);
			this.Controls.Add(this.main_btn);
			this.Controls.Add(this.hour_box);
			this.Controls.Add(this.date_box);
			this.Controls.Add(this.name_box);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form2";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.TextBox name_box;
		private System.Windows.Forms.DateTimePicker date_box;
		private System.Windows.Forms.ComboBox hour_box;
		private System.Windows.Forms.Button main_btn;
		private System.Windows.Forms.Button book_btn;
		private System.Windows.Forms.TextBox message_box;
	}
}


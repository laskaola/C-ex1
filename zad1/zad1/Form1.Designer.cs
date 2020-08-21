namespace zad1
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.decrease_acc = new System.Windows.Forms.Button();
            this.value_acc = new System.Windows.Forms.TextBox();
            this.increase_acc = new System.Windows.Forms.Button();
            this.increase_div = new System.Windows.Forms.Button();
            this.value_div = new System.Windows.Forms.TextBox();
            this.decrease_div = new System.Windows.Forms.Button();
            this.increase_ris = new System.Windows.Forms.Button();
            this.value_ris = new System.Windows.Forms.TextBox();
            this.decrease_ris = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label_acc = new System.Windows.Forms.Label();
            this.label_div = new System.Windows.Forms.Label();
            this.label_ris = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(361, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(228, 80);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(86, 30);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // decrease_acc
            // 
            this.decrease_acc.Location = new System.Drawing.Point(191, 211);
            this.decrease_acc.Name = "decrease_acc";
            this.decrease_acc.Size = new System.Drawing.Size(31, 29);
            this.decrease_acc.TabIndex = 3;
            this.decrease_acc.Text = "-";
            this.decrease_acc.UseVisualStyleBackColor = true;
            this.decrease_acc.Click += new System.EventHandler(this.decrease_acc_Click);
            // 
            // value_acc
            // 
            this.value_acc.Location = new System.Drawing.Point(237, 216);
            this.value_acc.Name = "value_acc";
            this.value_acc.Size = new System.Drawing.Size(38, 20);
            this.value_acc.TabIndex = 4;
            // 
            // increase_acc
            // 
            this.increase_acc.Location = new System.Drawing.Point(291, 211);
            this.increase_acc.Name = "increase_acc";
            this.increase_acc.Size = new System.Drawing.Size(33, 29);
            this.increase_acc.TabIndex = 5;
            this.increase_acc.Text = "+";
            this.increase_acc.UseVisualStyleBackColor = true;
            this.increase_acc.Click += new System.EventHandler(this.increase_acc_Click);
            // 
            // increase_div
            // 
            this.increase_div.Location = new System.Drawing.Point(291, 249);
            this.increase_div.Name = "increase_div";
            this.increase_div.Size = new System.Drawing.Size(33, 29);
            this.increase_div.TabIndex = 8;
            this.increase_div.Text = "+";
            this.increase_div.UseVisualStyleBackColor = true;
            this.increase_div.Click += new System.EventHandler(this.increase_div_Click);
            // 
            // value_div
            // 
            this.value_div.Location = new System.Drawing.Point(237, 254);
            this.value_div.Name = "value_div";
            this.value_div.Size = new System.Drawing.Size(38, 20);
            this.value_div.TabIndex = 7;
            // 
            // decrease_div
            // 
            this.decrease_div.Location = new System.Drawing.Point(191, 249);
            this.decrease_div.Name = "decrease_div";
            this.decrease_div.Size = new System.Drawing.Size(31, 29);
            this.decrease_div.TabIndex = 6;
            this.decrease_div.Text = "-";
            this.decrease_div.UseVisualStyleBackColor = true;
            this.decrease_div.Click += new System.EventHandler(this.decrease_div_Click);
            // 
            // increase_ris
            // 
            this.increase_ris.Location = new System.Drawing.Point(291, 286);
            this.increase_ris.Name = "increase_ris";
            this.increase_ris.Size = new System.Drawing.Size(33, 29);
            this.increase_ris.TabIndex = 11;
            this.increase_ris.Text = "+";
            this.increase_ris.UseVisualStyleBackColor = true;
            this.increase_ris.Click += new System.EventHandler(this.increase_ris_Click);
            // 
            // value_ris
            // 
            this.value_ris.Location = new System.Drawing.Point(237, 291);
            this.value_ris.Name = "value_ris";
            this.value_ris.Size = new System.Drawing.Size(38, 20);
            this.value_ris.TabIndex = 10;
            // 
            // decrease_ris
            // 
            this.decrease_ris.Location = new System.Drawing.Point(191, 286);
            this.decrease_ris.Name = "decrease_ris";
            this.decrease_ris.Size = new System.Drawing.Size(31, 29);
            this.decrease_ris.TabIndex = 9;
            this.decrease_ris.Text = "-";
            this.decrease_ris.UseVisualStyleBackColor = true;
            this.decrease_ris.Click += new System.EventHandler(this.decrease_ris_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(228, 116);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 29);
            this.delete.TabIndex = 12;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label_acc
            // 
            this.label_acc.AutoSize = true;
            this.label_acc.Location = new System.Drawing.Point(119, 219);
            this.label_acc.Name = "label_acc";
            this.label_acc.Size = new System.Drawing.Size(66, 13);
            this.label_acc.TabIndex = 13;
            this.label_acc.Text = "Acceleration";
            // 
            // label_div
            // 
            this.label_div.AutoSize = true;
            this.label_div.Location = new System.Drawing.Point(145, 257);
            this.label_div.Name = "label_div";
            this.label_div.Size = new System.Drawing.Size(29, 13);
            this.label_div.TabIndex = 14;
            this.label_div.Text = "Dive";
            // 
            // label_ris
            // 
            this.label_ris.AutoSize = true;
            this.label_ris.Location = new System.Drawing.Point(145, 294);
            this.label_ris.Name = "label_ris";
            this.label_ris.Size = new System.Drawing.Size(28, 13);
            this.label_ris.TabIndex = 15;
            this.label_ris.Text = "Rise";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 383);
            this.Controls.Add(this.label_ris);
            this.Controls.Add(this.label_div);
            this.Controls.Add(this.label_acc);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.increase_ris);
            this.Controls.Add(this.value_ris);
            this.Controls.Add(this.decrease_ris);
            this.Controls.Add(this.increase_div);
            this.Controls.Add(this.value_div);
            this.Controls.Add(this.decrease_div);
            this.Controls.Add(this.increase_acc);
            this.Controls.Add(this.value_acc);
            this.Controls.Add(this.decrease_acc);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button decrease_acc;
        private System.Windows.Forms.TextBox value_acc;
        private System.Windows.Forms.Button increase_acc;
        private System.Windows.Forms.Button increase_div;
        private System.Windows.Forms.TextBox value_div;
        private System.Windows.Forms.Button decrease_div;
        private System.Windows.Forms.Button increase_ris;
        private System.Windows.Forms.TextBox value_ris;
        private System.Windows.Forms.Button decrease_ris;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label_acc;
        private System.Windows.Forms.Label label_div;
        private System.Windows.Forms.Label label_ris;
    }
}


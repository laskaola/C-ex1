using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1 {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();
            comboBox1.Items.Add("Computer");
            comboBox1.Items.Add("Plane");
            comboBox1.Items.Add("Submarine");
            comboBox1.Items.Add("Car");

        }

        private void hideThings() {
            label_acc.Visible = false;
            label_div.Visible = false;
            label_ris.Visible = false;
            value_acc.Visible = false;
            value_div.Visible = false;
            value_ris.Visible = false;
            decrease_acc.Visible = false;
            decrease_div.Visible = false;
            decrease_ris.Visible = false;
            increase_acc.Visible = false;
            increase_div.Visible = false;
            increase_ris.Visible = false;
        }

        // poprawione: oddzielne funkcje do pokazywania/ukrywania elementów w zależności od interfejsu zamiast od obiektu

        private void showAccelerateElements() {

            hideThings();

            label_acc.Visible = true;
            decrease_acc.Visible = true;
            increase_acc.Visible = true;
            value_acc.Visible = true;
        }
        private void showRiseElements() {

            hideThings();

            label_ris.Visible = true;
            decrease_ris.Visible = true;
            increase_ris.Visible = true;
            value_ris.Visible = true;
        }

        private void showDiveElements() {

            hideThings();

            label_div.Visible = true;
            decrease_div.Visible = true;
            increase_div.Visible = true;
            value_div.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e) {

            if(comboBox1.SelectedItem != null) {
                if(comboBox1.SelectedItem.ToString().Equals("Computer"))
                    listBox1.Items.Add(new Computer());

                if(comboBox1.SelectedItem.ToString().Equals("Plane"))
                    listBox1.Items.Add(new Plane());

                if(comboBox1.SelectedItem.ToString().Equals("Submarine"))
                    listBox1.Items.Add(new Submarine());

                if(comboBox1.SelectedItem.ToString().Equals("Car"))
                    listBox1.Items.Add(new Car());
            } else
                MessageBox.Show("No item selected");

        }



        private void delete_Click(object sender, EventArgs e) {

            if(listBox1.SelectedItem != null)
                listBox1.Items.Remove(listBox1.SelectedItem);
            else
                MessageBox.Show("Choose an item to remove");
        }


        private void decrease_acc_Click(object sender, EventArgs e) {

            if(listBox1.SelectedItem is IAccelerate && (listBox1.SelectedItem != null)) {
                ((IAccelerate) listBox1.SelectedItem).Accelerate -= 1;
                value_acc.Text = ((IAccelerate) listBox1.SelectedItem).Accelerate.ToString();
            }
        }

        private void decrease_div_Click(object sender, EventArgs e) {

            if(listBox1.SelectedItem is iDive && (listBox1.SelectedItem != null)) {
                ((iDive) listBox1.SelectedItem).Dive -= 1;
                value_div.Text = ((iDive) listBox1.SelectedItem).Dive.ToString();
            }

        }

        private void decrease_ris_Click(object sender, EventArgs e) {

            if(listBox1.SelectedItem is IRise && (listBox1.SelectedItem != null)) {
                ((IRise) listBox1.SelectedItem).Rise -= 1;
                value_ris.Text = ((IRise) listBox1.SelectedItem).Rise.ToString();
            }
        }

        private void increase_acc_Click(object sender, EventArgs e) {

            if(listBox1.SelectedItem is IAccelerate && (listBox1.SelectedItem != null)) {
                ((IAccelerate) listBox1.SelectedItem).Accelerate += 1;
                value_acc.Text = ((IAccelerate) listBox1.SelectedItem).Accelerate.ToString();
            }
        }

        private void increase_div_Click(object sender, EventArgs e) {

            if(listBox1.SelectedItem is iDive && (listBox1.SelectedItem != null)) {
                ((iDive) listBox1.SelectedItem).Dive += 1;
                value_div.Text = ((iDive) listBox1.SelectedItem).Dive.ToString();
            }
        }

        private void increase_ris_Click(object sender, EventArgs e) {

            if(listBox1.SelectedItem is IRise && (listBox1.SelectedItem != null)) {
                ((IRise) listBox1.SelectedItem).Rise += 1;
                value_ris.Text = ((IRise) listBox1.SelectedItem).Rise.ToString();
            }
        }

        // poprawione: oddzielnie warunki dla każdego interfejsu
        private void updateValues() {

            if(listBox1.SelectedItem is IAccelerate && (listBox1.SelectedItem != null)) {
                value_acc.Text = (((IAccelerate) listBox1.SelectedItem).Accelerate).ToString();
            } else
            if(listBox1.SelectedItem is IRise && listBox1.SelectedItem is iDive && !(listBox1.SelectedItem is IRise) && (listBox1.SelectedItem != null)) {
                value_ris.Text = (((IRise) listBox1.SelectedItem).Rise).ToString();
            } else
            if(listBox1.SelectedItem is iDive && (listBox1.SelectedItem != null)) {
                value_div.Text = (((iDive) listBox1.SelectedItem).Dive).ToString();
            }
        }

        // poprawione: usunięte warunki zależne od obiektów
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

            value_acc.Clear();
            value_div.Clear();
            value_ris.Clear();

            updateValues();
        }
    }
}

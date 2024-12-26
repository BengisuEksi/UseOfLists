using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseOfLists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void list1_bttn_Click(object sender, EventArgs e)
        {
            List<string> names = new List<string>();
            names.Add("Asli");
            names.Add("Taha");
            names.Add("Bengisu");
            names.Add("Mirac");
            names.Add("Mahmut");

            foreach (string name in names)
            {
                listBox1.Items.Add(name);
            }
        }

        private void list2_bttn_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<int> numbers = new List<int>();
            numbers.Add(14);
            numbers.Add(26);
            numbers.Add(13);
            numbers.Add(11);
            numbers.Add(18);
            numbers.Add(25);
            numbers.Add(4);
            //numbers.Remove(14);

            foreach (int i in numbers)
            {
                listBox2.Items.Add(i);
            }

            if (check_txtbox.Text == "")
            {
                check_txtbox.Text = 0.ToString();
            }
            else
            {
                if (numbers.Contains(int.Parse(check_txtbox.Text)))
                {
                    MessageBox.Show("Number exists.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Number doesn't exist.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
        }

        private void list3_bttn_Click(object sender, EventArgs e)
        {
            List<People> people = new List<People>();
            people.Add(new People()
            {
                Name = "Bengisu",
                Surname = "Eksi",
                Job = "Software Developer"
            });
            people.Add(new People()
            {
                Name = "Asli",
                Surname = "Eksi",
                Job = "Teacher"
            });
            people.Add(new People()
            {
                Name = "Taha",
                Surname = "Eksi",
                Job = "Engineer"
            });

            foreach (People p in people)
            {
                listBox3.Items.Add(p.Name + " " + p.Surname + " - " + p.Job);
            }
        }
        List<Car> cars = new List<Car>();
        private void add_bttn_Click(object sender, EventArgs e)
        {
            cars.Add(new Car()
            {
                Model = model_txtbox.Text,
                Colour = color_txtbox.Text,
                Year = int.Parse(year_txtbox.Text)
            });
        }

        private void list4_bttn_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            foreach (Car c in cars)
            {
                listBox4.Items.Add(c.Model + " - " + c.Colour + " - " + c.Year);
            }
        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            model_txtbox.Text = "";
            color_txtbox.Text = "";
            year_txtbox.Text = "";
        }
    }
}

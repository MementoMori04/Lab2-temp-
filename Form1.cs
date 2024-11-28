using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_temp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Цельсий в Фаренгейт");
            comboBox1.Items.Add("Фаренгейт в Цельсий");
            comboBox1.SelectedIndex = 0;
        }

        // Конвертация Цельсий в Фаренгейт
        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        // Конвертация Фаренгейт в Цельсий
        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperature;
            // Проверяем, хорошо ли введено значение
            if (double.TryParse(textBox1.Text, out temperature))
            {
                if (comboBox1.SelectedIndex == 0) // Цельсий в Фаренгейт
                {
                    double fahrenheit = CelsiusToFahrenheit(temperature);
                    label1.Text = $"{fahrenheit:F2} °F";
                }
                else // Фаренгейт в Цельсий
                {
                    double celsius = FahrenheitToCelsius(temperature);
                    label1.Text = $"{celsius:F2} °C";
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное значение температуры.");
            }
        }
    }
}

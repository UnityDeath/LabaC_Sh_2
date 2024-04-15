using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComboBox = System.Windows.Forms.ComboBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.str1.ToString();
            textBox2.Text = Properties.Settings.Default.str2.ToString();

            var measureItems = new string[]
       {
            "10",
            "2",
            "8",
            "16",
       };

            // привязываем списки значений к каждому комбобоксу
            comboBox1.DataSource = new List<string>(measureItems);
            comboBox2.DataSource = new List<string>(measureItems);
            comboBox3.DataSource = new List<string>(measureItems);

            comboBox5.DataSource = new List<string>(measureItems);
            comboBox6.DataSource = new List<string>(measureItems);
        }
        private MeasureOfType GetMeasureOfType(ComboBox comboBox)
        {
            MeasureOfType measureOfType;
            switch (comboBox.Text)
            {
                case "2":
                    measureOfType = MeasureOfType.sec;
                    break;
                case "8":
                    measureOfType = MeasureOfType.ei;
                    break;
                case "10":
                    measureOfType = MeasureOfType.t;
                    break;
                case "16":
                    measureOfType = MeasureOfType.six;
                    break;
                default:
                    measureOfType = MeasureOfType.t;
                    break;
            }
            return measureOfType;
        }

        private void Calculate()
        {
            try
            {
                var firstValue = textBox1.Text;
                var secondValue = textBox2.Text;

                MeasureOfType firstType = GetMeasureOfType(comboBox1);
                MeasureOfType secondType = GetMeasureOfType(comboBox2);
                MeasureOfType resultType = GetMeasureOfType(comboBox3);

                Summa sumLength;

                if (firstValue != "" && secondValue != "")
                {
                    var firstNum = Convert.ToInt32(firstValue, NumSys(firstType));
                    var secondNum = Convert.ToInt32(secondValue, NumSys(secondType));

                    var firstLength = new Summa(firstNum, resultType);
                    var secondLength = new Summa(secondNum, resultType);

                    // смотрим что выбрали в cmbOperation
                    switch (comboBox4.Text)
                    {
                        case "+":
                            // если плюсик выбрали, то складываем
                            sumLength = firstLength + secondLength;
                            break;
                        case "-":
                            // если минус, то вычитаем
                            sumLength = firstLength - secondLength;
                            break;
                        case "*":
                            sumLength = firstLength * secondLength;
                            break;
                        default:
                            sumLength = new Summa(0, MeasureOfType.t);
                            break;
                    }

                    textBox3.Text = sumLength.To(resultType).OutputOfTheValue();

                    Properties.Settings.Default.str1 = textBox1.Text;
                    Properties.Settings.Default.str2 = textBox2.Text;
                    Properties.Settings.Default.Save();
                }


            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);   //Если так делать, то в свойствах текстбоксов надо поставить текст, который будет начальным
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void onValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        //Сравнение
        private void CompareValues()
        {
            try
            {
                var value1 = Int32.Parse(textBox4.Text);
                var value2 = Int32.Parse(textBox5.Text);

                MeasureOfType measure1 = GetMeasureOfType(comboBox5);
                MeasureOfType measure2 = GetMeasureOfType(comboBox6);

                Summa Summa1 = new Summa(value1, measure1);
                Summa Summa2 = new Summa(value2, measure2);

                Summa1.To(MeasureOfType.t);
                Summa2.To(MeasureOfType.t);

                // Сравниваем значения
                if (Summa1 == Summa2)
                {
                    textBox6.Text = "=";
                }
                else if (Summa1 < Summa2)
                {
                    textBox6.Text = "<";
                }
                else
                {
                    textBox6.Text = ">";
                }
            }
            catch (FormatException)
            {
                // В случае некорректного ввода выводим сообщение об ошибке или предпринимаем другие действия
                //MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onCompareValues(object sender, EventArgs e)
        {
            CompareValues();
        }

        private int NumSys(MeasureOfType Type)
        {
            int num = 0;
            switch (Type)
            {
                case MeasureOfType.t:
                    num = 10;
                    break;
                case MeasureOfType.sec:
                    num = 2;
                    break;
                case MeasureOfType.ei:
                    num = 8;
                    break;
                case MeasureOfType.six:
                    num = 16;
                    break;
            }
            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    
    public enum MeasureOfType { sec, ei, t, six };
    public class Summa
    {
        private int value;
        private MeasureOfType type;

        public Summa(int value, MeasureOfType type)
        {
            this.value = value;
            this.type = type;
        }

        // выводит значение в виде (1 km, 2 m, 3 au и т.д.)
        public string OutputOfTheValue()
        {
            string typeOutput = "";
            switch (this.type)
            {
                case MeasureOfType.sec:
                    typeOutput = "2";
                    break;
                case MeasureOfType.ei:
                    typeOutput = "8";
                    break;
                case MeasureOfType.t:
                    typeOutput = "10";
                    break;
                case MeasureOfType.six:
                    typeOutput = "16";
                    break;
            }
            return String.Format("{0} {1}", this.value, typeOutput);
        }

        // сложение
        public static Summa operator +(Summa instance, int number)
        {
            // расчитываем новую значение
            var newValue = instance.value + number;
            // создаем новый экземпляр класса, с новый значением и типом как у меры, к которой число добавляем
            var Summa = new Summa(newValue, instance.type);
            // возвращаем результат
            return Summa;
        }

        public static Summa operator +(int number, Summa instance)
        {
            // вызываем с правильным порядком аргументов, то есть сначала длина потом число
            // для такого порядка мы определили оператор выше
            return instance + number;
        }

        // умножение
        public static Summa operator *(Summa instance, int number)
        {
            return new Summa(instance.value * number, instance.type); ;
        }

        public static Summa operator *(int number, Summa instance)
        {
            return instance * number;
        }

        // вычитание
        public static Summa operator -(Summa instance, int number)
        {
            return new Summa(instance.value - number, instance.type); ;
        }

        public static Summa operator -(int number, Summa instance)
        {
            return instance - number;
        }

        // сложение двух величин
        public static Summa operator +(Summa instance1, Summa instance2)
        {
            // к текущей длине добавляем число полученное преобразованием значения второй длины в тип первой длины
            return instance1 + instance2.value;
        }

        // вычитание двух величин
        public static Summa operator -(Summa instance1, Summa instance2)
        {
            return instance1 - instance2.value;
        }

        // Умножение двух величин
        public static Summa operator *(Summa instance1, Summa instance2)
        {
            return instance1 * instance2.value;
        }

        public Summa To(MeasureOfType newType)
        {
            // по умолчанию новое значение совпадает со старым
            var newValue = this.value;

            if (this.type == MeasureOfType.t)
            {
                switch (newType)
                {
                    case MeasureOfType.t:
                        newValue = this.value;
                        break;
                    default:
                        newValue = Int32.Parse(Convert.ToString(this.value, 10));
                        break;
                }
            }
            else if (newType == MeasureOfType.t)
            {
                switch (this.type)
                {
                    case MeasureOfType.t:
                        newValue = this.value;
                        break;

                    case MeasureOfType.sec:
                        newValue = Int32.Parse(Convert.ToString(this.value, 2));
                        break;

                    case MeasureOfType.ei:
                        newValue = Int32.Parse(Convert.ToString(this.value, 8));
                        break;

                    case MeasureOfType.six:
                        newValue = Int32.Parse(Convert.ToString(this.value, 16));
                        break;
                }
            }
            else
            {
                newValue = this.To(MeasureOfType.t).To(newType).value;
            }
            return new Summa(newValue, newType);
        }

        //Сравнение
        public static bool operator == (Summa instance1, Summa instance2)
        {
            return instance1.To(instance2.type).value == instance2.value;
        }

        public static bool operator !=(Summa instance1, Summa instance2)
        {
            return !(instance1 == instance2);
        }

        public static bool operator <(Summa instance1, Summa instance2)
        {
            return instance1.To(instance2.type).value < instance2.value;
        }

        public static bool operator >(Summa instance1, Summa instance2)
        {
            return instance2 < instance1;
        }
    }
}

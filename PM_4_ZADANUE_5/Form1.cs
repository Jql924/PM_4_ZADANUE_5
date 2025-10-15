using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NumeralSystemConverterVariant5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка "Преобразовать"
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text.Trim();
                if (comboFrom.SelectedItem == null || comboTo.SelectedItem == null)
                {
                    MessageBox.Show("Выберите обе системы счисления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int fromBase = int.Parse(comboFrom.SelectedItem.ToString());
                int toBase = int.Parse(comboTo.SelectedItem.ToString());

                string result = ConvertBase(input, fromBase, toBase);
                lblResult.Text = $"Результат: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод перевода между системами счисления
        private string ConvertBase(string input, int fromBase, int toBase)
        {
            input = input.ToUpper();

            // Проверка корректности ввода
            foreach (char c in input)
            {
                if (!IsValidChar(c, fromBase))
                    throw new ArgumentException($"Недопустимый символ '{c}' для системы {fromBase}");
            }

            // Перевод в десятичное
            long number = Convert.ToInt64(input, fromBase);

            // Перевод из десятичного в целевую систему
            return Convert.ToString(number, toBase).ToUpper();
        }

        // Проверка допустимых символов
        private bool IsValidChar(char c, int baseNum)
        {
            if (char.IsDigit(c))
                return (c - '0') < baseNum;
            if (char.IsLetter(c))
                return (c - 'A' + 10) < baseNum;
            return false;
        }

        // Тесты для проверки корректности работы
        private void btnTest_Click(object sender, EventArgs e)
        {
            string report = "";
            try
            {
                // Нулевое значение
                report += "Тест 1 (0 из 10 в 2): " + ConvertBase("0", 10, 2) + "\n";
                // Граничные значения
                report += "Тест 2 (255 из 10 в 16): " + ConvertBase("255", 10, 16) + "\n";
                report += "Тест 3 (11111111 из 2 в 10): " + ConvertBase("11111111", 2, 10) + "\n";
                // Некорректный ввод
                try { ConvertBase("2", 2, 10); }
                catch (Exception ex) { report += "Тест 4 (ошибка '2' в 2): ОК (" + ex.Message + ")\n"; }

                MessageBox.Show(report, "Результаты тестов", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при тестах: " + ex.Message);
            }
        }
    }
}

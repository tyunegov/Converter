using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurrencyConverterLibrary;
using NLog;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Украинская гривна");
            list.Add("Доллар США");
            list.Add("Евро");
            list.Add("Российский рубль");
            foreach (var v in list)
            {
                comboBoxCurrencyIN.Items.Add(v);
                comboBoxCurrencyOut.Items.Add(v);
            }


        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBoxCurrencyIN.Text!="" | comboBoxCurrencyOut.Text!="") &  comboBoxCurrencyIN.Text.Equals(comboBoxCurrencyOut.Text))
                {
                    MessageBox.Show("Нельзя перевести валюту в ту же самую валюту");
                    logger.Error("Поле \"Имеющаяся валюта\" и поле \"Нужная валюта\" совпадают");
                }
                else
                {
                    decimal amount = Convert.ToDecimal(textBoxAmound.Text.Replace(".", ","));
                    string currencyIn = Ccy(comboBoxCurrencyIN.Text);
                    string currencyOut = Ccy(comboBoxCurrencyOut.Text);
                    decimal summ = Math.Round(ConvertCash.GetSumm(amount, currencyIn, currencyOut), 2);
                    labelSumm.Text = summ.ToString();

                    logger.Debug($"Совершение конвертации валюты в количестве {textBoxAmound.Text} из \"{comboBoxCurrencyIN.Text}\" в \"{comboBoxCurrencyOut.Text}\"");
                }
            }
            catch (FormatException)
            {
                logger.Error("Ошибка введения суммы");
                MessageBox.Show("Необходимо ввести сумму");
            }
            catch(Exception exception)
            {
                if (comboBoxCurrencyIN.Text.Equals(""))
                {
                    MessageBox.Show("Необходимо заполнить поле \"Имеющаяся валюта\"");
                    logger.Error("Ошибка проведения конвертации валюты \"Не заполнено поле Имеющаяся валюта\"");
                }
                else if(comboBoxCurrencyOut.Text.Equals(""))
                {
                    MessageBox.Show("Необходимо заполнить поле \"Нужная валюта\"");
                    logger.Error("Ошибка проведения конвертации валюты \"Не заполнено поле Нужная валюта\"");

                }
                else logger.Error(exception);
            }
        }

        static string Ccy(string currency)
        {
            switch (currency)
            {
                case "Российский рубль":
                    return "RUR";
                case "Евро":
                    return "EUR";
                case "Доллар США":
                    return "USD";
                case "Украинская гривна":
                    return "UAH";
                default:
                    throw new Exception("Does not exist currency");
            }

        }
    }
}

using Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CurrencyConverterLibrary
{
    public static class ConvertCash
    {
        public static decimal GetSumm(decimal amount, string currencyIn, string currencyOut)
        {
           
            var v = CourseUAH(currencyIn).Buy.Replace(".",",");
            var i = CourseUAH(currencyOut).Sale.Replace(".", ",");
            return amount * Convert.ToDecimal(i) / Convert.ToDecimal(v);
        } 
        
        static List<CurrencyModel> GetCurrencyModel()
        {
            string url = "https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5";
            var webClient = new WebClient();
            // Выполняем запрос по адресу и получаем ответ в виде строки
            var response = webClient.DownloadString(url).ToString();
           return JsonConvert.DeserializeObject<List<CurrencyModel>>(response);

        }

        static CurrencyModel CourseUAH(string currency) {
            var currencyModel = GetCurrencyModel();
            switch (currency)
            {
                case "RUR":
                    return currencyModel[0];
                case "EUR":
                    return currencyModel[1];
                case "USD":
                    return currencyModel[2];
                case "UAH":
                    return new CurrencyModel() { Ccy = "UAH", Buy = "1", Sale = "1" };
                default:
                    throw new Exception("Does not exist currency");
            }

        }
}
}

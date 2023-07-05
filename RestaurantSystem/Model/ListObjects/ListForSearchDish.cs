using RestaurantSystem.Model.ClassProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Model.ListObjects
{

    public class SearchEventArgs : EventArgs
    {
        public string DishName { get; }

        public SearchEventArgs(string dish)
        {
            DishName = dish;
        }
    }

    public static class ListForSearchDish
    {
        private static string SearchDishModels;
        private static string dishName;
        public static event EventHandler<SearchEventArgs> SearchEventHandler;

        public static void TypeALetterToSearch(char[] arrayOfLetters)
        {
            SearchDishModels = arrayOfLetters.ToString();
            OnSearch(arrayOfLetters);
        }

        public static string GetNames()
        {
            return SearchDishModels;
        }

        public static void OnSearch(char[] arrayOfLetters)
        {
            SearchEventHandler?.Invoke(null, new SearchEventArgs(arrayOfLetters.ToString()));
        }
    }
}

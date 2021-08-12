using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vittighedsmaskinen.DataModels
{
    public class Joke
    {
        private Category _category;
        private string _text;
        private Language _language;

        public Joke(Category category, string text, Language language)
        {
            _category = category;
            _language = language;
            _text = text;
        }

        public string GetCategory()
        {
            return _category.ToString();
        }

        public string GetText()
        {
            return _text;
        }
    }
}

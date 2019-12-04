using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agarkov.TheoryOfAuthomats
{
    /// <summary>
    /// Конечный автомат
    /// </summary>
    class AuotoMath
    {
        /// <summary>
        /// Алфавит автомата
        /// </summary>
        private List<string> _alphabet;

        /// <summary>
        /// Закодированный алфавит
        /// </summary>
        private Dictionary<string, int> _encodedAlphabet;

        /// <summary>
        /// Входной текст
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// Состояние ошибки
        /// </summary>
        public int ErrorState { get; private set; }

        /// <summary>
        /// Перегруженный конструктор
        /// </summary>
        /// <param name="alphabet">Входной алфавит</param>
        /// <param name="inputText">Входной текст</param>
        public AuotoMath(List<string> alphabet, string inputText)
        {
            if (alphabet == null)
            {
                throw new Exception("Алфавит задан некорректно");
            }

            if (String.IsNullOrEmpty(inputText))
            {
                throw new Exception("Текст задан некорректно");
            }

            _alphabet = alphabet;
            Text = inputText;
            _encodedAlphabet = new Dictionary<string, int>();
        }

        /// <summary>
        /// Закодировать входной алфавит
        /// </summary>
        public void EncodeAlphabet()
        {
            for(var i = 0; i < _alphabet.Count; i++)
            {
                _encodedAlphabet.Add(_alphabet.ElementAt(i), i); 
            }

            ErrorState = _alphabet.Count;
        }

        public List<int> EncodeText()
        {
            var encodedInts = new List<int>();

            foreach(var symbol in Text)
            {
                var temp = _encodedAlphabet.FirstOrDefault(s => s.Key == symbol.ToString());
                if (temp.Key == null)
                {
                    throw new Exception("Ошибочное состояние");
                }
                encodedInts.Add(temp.Value);
            }

            return encodedInts;

        }
    }
}

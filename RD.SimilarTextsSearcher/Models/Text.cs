using System.Security.Cryptography;
using System.Text;

namespace RD.SimilarTextsSearcher.Models
{
    class Text
    {
        private string _value;
        private string _valueMD5;

        public string Id { get; set; }
        public string Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                GenerateMD5Hash();
            }
        }

        public string ValueMD5 { get => _valueMD5; }

        private void GenerateMD5Hash()
        {
            var dataMD5 = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(_value));

            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < dataMD5.Length; i++)
                sBuilder.Append(dataMD5[i].ToString("x2"));
            _valueMD5 = sBuilder.ToString();
        }
    }
}

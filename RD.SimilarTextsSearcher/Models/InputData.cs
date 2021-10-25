
namespace RD.SimilarTextsSearcher.Models
{
    public class InputData
    {
        private Text _text1;
        private Text _text2;

        public InputData()
        {
            _text1 = new Text();
            _text2 = new Text();
        }
        public string Text1
        { 
                get
                {
                    return _text1.Value;
                } 
                set
                {
                    _text1.Value = value;
                }
        }
        public string Text2
        {
            get
            {
                return _text2.Value;
            }
            set
            {
                _text2.Value = value;
            }
        }
        public string Text1Id
        {
            get
            {
                return _text1.Id;
            }
            set
            {
                _text1.Id = value;
            }
        }
        public string Text2Id
        {
            get
            {
                return _text2.Id;
            }
            set
            {
                _text2.Id = value;
            }
        }
        public string Text1valueMD5
        {
            get
            {
                return _text1.ValueMD5;
            }
        }
        public string Text2valueMD5
        {
            get
            {
                return _text2.ValueMD5;
            }
        }
    }
}

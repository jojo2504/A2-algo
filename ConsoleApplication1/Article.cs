namespace ConsoleApplication1
{
    public class Article {
        private string _title;
        private int _quantity;
        private float _priceHt;
        private long _reference;
    
        public Article(string title, int quantity, float priceHt, long reference)
        {
            this._title = title;
            this._quantity = quantity;
            this._priceHt = priceHt;
            this._reference = reference;
        }

        public string GetTitle()
        {
            return this._title;
        }

        public int GetQuantity()
        {
            return this._quantity;
        }

        public float GetPriceHt()
        {
            return this._priceHt;
        }

        public long GetReference()
        {
            return _reference;
        }

        public bool SellArticle(int quantity)
        {
            if (quantity <= this._quantity)
            {
                _quantity -= quantity;
                return true;
            }
            return false;
        }

        public void Restock(int quantity)
        {
            _quantity += quantity;
        }

        public float GetPriceTTc()
        {
            return (float)(_priceHt * 1.2);
        }

        public string ToString()
        {
            return string.Format("reference: {0}, title: {1}, quantity: {2}, priceHt: {3}", _reference, _title, _quantity, _priceHt);
        }

        public bool Equals(Article article)
        {
            return _reference == article.GetReference();
        }
    }
}
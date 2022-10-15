namespace sanpham{
    public partial class product
    {
        public string name {set;get;}
        public decimal price {set;get;}

        public string getInfo(){
            return $"{name}/{price} : {description}";
        }

    }
}
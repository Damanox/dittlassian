namespace dittlassian.Utilities.ConditionParser
{
    public enum ResultType
    {
        Decimal,
        String,
        Bool,
        Object
    }

    public class Result
    {
        private object _object;
        private bool? _bool;
        private decimal? _decimal;
        private string _string;

        public ResultType Type { get; set; }

        public object Object
        {
            get => _object;
            set
            {
                Type = ResultType.Object;
                _object = value;
            }
        }

        public bool? Bool
        {
            get => _bool;
            set
            {
                Type = ResultType.Bool;
                _bool = value;
            }
        }

        public decimal? Decimal
        {
            get => _decimal;
            set
            {
                Type = ResultType.Decimal;
                _decimal = value;
            }
        }

        public string String
        {
            get => _string;
            set
            {
                Type = ResultType.String;
                _string = value;
            }
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Result res))
                return false;

            if(Type != res.Type)
                return false;

            switch(Type)
            {
                case ResultType.Object:
                    return Object.Equals(res.Object);
                case ResultType.Bool:
                    return Bool.Equals(res.Bool);
                case ResultType.Decimal:
                    return Decimal.Equals(res.Decimal);
                case ResultType.String:
                    return String.Equals(res.String);
                default:
                    return false;
            }
        }
    }
}
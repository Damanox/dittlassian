using System;

namespace dittlassian.Utilities.ConditionParser
{
    public enum ResultType
    {
        Decimal,
        String,
        Bool,
        Object,
        Date
    }

    public class Result
    {
        private object _object;
        private bool? _bool;
        private decimal? _decimal;
        private string _string;
        private DateTime? _date;

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
        
        public DateTime? Date
        {
            get => _date;
            set
            {
                Type = ResultType.Date;
                _date = value;
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
                case ResultType.Date:
                    return Date.Equals(res.Date);
                default:
                    return false;
            }
        }
    }
}
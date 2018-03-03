using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace dittlassian.Utilities.ConditionParser
{
    public class ResultVisitor : ConditionBaseVisitor<Result>
    {
        private readonly object _param;

        public ResultVisitor(object param)
        {
            _param = param;
        }

        public override Result VisitIdentifierExpression(ConditionParser.IdentifierExpressionContext context)
        {
            var identifier = context.IDENTIFIER().GetText();

            var obj = _param;
            foreach(var propName in identifier.Split('.'))
            {
                var prop = obj.GetType().GetRuntimeProperty(propName);

                if(prop == null)
                {
                    var customField = obj.GetType().GetProperty("CustomFields");

                    if(customField == null)
                        throw new Exception($"Property {identifier} not found");

                    var custom = (IDictionary<string, object>)customField.GetValue(obj);

                    if(!custom.ContainsKey(propName))
                        throw new Exception($"Property {identifier} not found");

                    obj = custom[propName];
                }
                else
                    obj = prop.GetValue(obj);
            }

            var result = new Result();

            switch(obj)
            {
                case int i:
                    result.Decimal = i;
                    break;
                case uint ui:
                    result.Decimal = ui;
                    break;
                case short s:
                    result.Decimal = s;
                    break;
                case ushort us:
                    result.Decimal = us;
                    break;
                case byte b:
                    result.Decimal = b;
                    break;
                case sbyte sb:
                    result.Decimal = sb;
                    break;
                case long l:
                    result.Decimal = l;
                    break;
                case ulong ul:
                    result.Decimal = ul;
                    break;
                case float fl:
                    result.Decimal = (decimal?)fl;
                    break;
                case double db:
                    result.Decimal = (decimal?)db;
                    break;
                case bool bo:
                    result.Bool = bo;
                    break;
                case string str:
                    result.String = str;
                    break;
                default:
                    result.Object = obj;
                    break;
            }

            return result;
        }

        public override Result VisitParenExpression(ConditionParser.ParenExpressionContext context)
        {
            return Visit(context.expression());
        }

        public override Result VisitNotExpression(ConditionParser.NotExpressionContext context)
        {
            return new Result { Bool = !Visit(context.expression()).Bool.GetValueOrDefault() };
        }

        public override Result VisitBinaryExpression(ConditionParser.BinaryExpressionContext context)
        {
            var left = Visit(context.left);
            var right = Visit(context.right);
            
            if(left.Type != right.Type && left.Type != ResultType.Bool)
                throw new Exception("Invalid type comparison");
            
            if(context.op.AND() != null)
                return new Result { Bool = left.Bool.GetValueOrDefault() && right.Bool.GetValueOrDefault() };

            if(context.op.OR() != null)
                return new Result { Bool = left.Bool.GetValueOrDefault() || right.Bool.GetValueOrDefault() };

            return new Result();
        }

        public override Result VisitComparatorExpression(ConditionParser.ComparatorExpressionContext context)
        {
            var left = Visit(context.left);
            var right = Visit(context.right);

            if(left.Type != right.Type)
                throw new Exception("Invalid type comparison");

            if(context.op.EQ() != null)
                return new Result { Bool = left.Equals(right) };

            if(context.op.NEQ() != null)
                return new Result { Bool = !left.Equals(right) };

            if(context.op.GT() != null)
            {
                if(left.Type != right.Type || left.Type == ResultType.Object || left.Type == ResultType.Bool)
                    throw new Exception("Invalid type comparison");

                if(left.Type == ResultType.Decimal)
                    return new Result { Bool = left.Decimal > right.Decimal };
                if(left.Type == ResultType.String)
                    return new Result { Bool = string.Compare(left.String, right.String, StringComparison.Ordinal) > 0 };
            }

            if(context.op.GE() != null)
            {
                if(left.Type != right.Type || left.Type == ResultType.Object || left.Type == ResultType.Bool)
                    throw new Exception("Invalid type comparison");

                if(left.Type == ResultType.Decimal)
                    return new Result { Bool = left.Decimal > right.Decimal };
                if(left.Type == ResultType.String)
                    return new Result { Bool = string.Compare(left.String, right.String, StringComparison.Ordinal) >= 0 };
            }

            if(context.op.LT() != null)
            {
                if(left.Type != right.Type || left.Type == ResultType.Object || left.Type == ResultType.Bool)
                    throw new Exception("Invalid type comparison");

                if(left.Type == ResultType.Decimal)
                    return new Result { Bool = left.Decimal > right.Decimal };
                if(left.Type == ResultType.String)
                    return new Result { Bool = string.Compare(left.String, right.String, StringComparison.Ordinal) < 0 };
            }

            if(context.op.LE() != null)
            {
                if(left.Type != right.Type || left.Type == ResultType.Object || left.Type == ResultType.Bool)
                    throw new Exception("Invalid type comparison");

                if(left.Type == ResultType.Decimal)
                    return new Result { Bool = left.Decimal > right.Decimal };
                if(left.Type == ResultType.String)
                    return new Result { Bool = string.Compare(left.String, right.String, StringComparison.Ordinal) <= 0 };
            }

            return new Result();
        }

        public override Result VisitBool(ConditionParser.BoolContext context)
        {
            return new Result { Bool = bool.Parse(context.GetText()) };
        }

        public override Result VisitDecimalExpression(ConditionParser.DecimalExpressionContext context)
        {
            return new Result { Decimal = decimal.Parse(context.GetText()) };
        }

        public override Result VisitStringExpression(ConditionParser.StringExpressionContext context)
        {
            var text = context.GetText();
            text = text.Substring(1, text.Length - 2);

            if(DateTime.TryParse(text, out var date))
                return new Result { Date = date };    
            
            return new Result { String = text };
        }
    }
}
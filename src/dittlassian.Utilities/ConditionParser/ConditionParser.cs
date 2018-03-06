using System;
using System.Collections.Generic;
using Antlr4.Runtime;

namespace dittlassian.Utilities.ConditionParser
{
    public class ConditionParser
    {
        private readonly Dictionary<int, AntlrConditionParser.ExpressionContext> _cache;

        public ConditionParser()
        {
            _cache = new Dictionary<int, AntlrConditionParser.ExpressionContext>();
        }

        public bool Parse<T>(string condition, T param)
        {
            var hashCode = condition.ToLowerInvariant().GetHashCode();

            AntlrConditionParser.ExpressionContext expression;
            
            if(!_cache.ContainsKey(hashCode))
            {
                var inputStream = new AntlrInputStream(condition);
                var conditionLexer = new ConditionLexer(inputStream);
                var commonTokenStream = new CommonTokenStream(conditionLexer);
                var conditionParser = new AntlrConditionParser(commonTokenStream);
                
                expression = conditionParser.expression();
                
                _cache.Add(hashCode, expression);
            }
            else
            {
                expression = _cache[hashCode];
            }

            try
            {
                var res = new ResultVisitor(param).Visit(expression);
                
                return res.Bool.GetValueOrDefault();
            }
            catch(Exception e)
            {
                // TODO logging
            }

            return false;
        }
    }
}
using Antlr4.Runtime;

namespace dittlassian.Utilities.ConditionParser
{
    public static class ConditionParserUtil
    {
        public static bool Parse<T>(string condition, T param)
        {
            var inputStream = new AntlrInputStream(condition);
            var conditionLexer = new ConditionLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(conditionLexer);
            var conditionParser = new ConditionParser(commonTokenStream);

            var res = new ResultVisitor(param).Visit(conditionParser.expression());

            return res.Bool.GetValueOrDefault();
        }
    }
}
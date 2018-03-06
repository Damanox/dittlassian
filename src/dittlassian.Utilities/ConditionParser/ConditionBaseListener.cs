//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Condition.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace dittlassian.Utilities.ConditionParser {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IConditionListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public partial class ConditionBaseListener : IConditionListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrConditionParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParse([NotNull] AntlrConditionParser.ParseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrConditionParser.parse"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParse([NotNull] AntlrConditionParser.ParseContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>binaryExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinaryExpression([NotNull] AntlrConditionParser.BinaryExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>binaryExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinaryExpression([NotNull] AntlrConditionParser.BinaryExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>decimalExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDecimalExpression([NotNull] AntlrConditionParser.DecimalExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>decimalExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDecimalExpression([NotNull] AntlrConditionParser.DecimalExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>stringExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStringExpression([NotNull] AntlrConditionParser.StringExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>stringExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStringExpression([NotNull] AntlrConditionParser.StringExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolExpression([NotNull] AntlrConditionParser.BoolExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolExpression([NotNull] AntlrConditionParser.BoolExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdentifierExpression([NotNull] AntlrConditionParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdentifierExpression([NotNull] AntlrConditionParser.IdentifierExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNotExpression([NotNull] AntlrConditionParser.NotExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNotExpression([NotNull] AntlrConditionParser.NotExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>parenExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParenExpression([NotNull] AntlrConditionParser.ParenExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>parenExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParenExpression([NotNull] AntlrConditionParser.ParenExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by the <c>comparatorExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparatorExpression([NotNull] AntlrConditionParser.ComparatorExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>comparatorExpression</c>
	/// labeled alternative in <see cref="AntlrConditionParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparatorExpression([NotNull] AntlrConditionParser.ComparatorExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrConditionParser.comparator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterComparator([NotNull] AntlrConditionParser.ComparatorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrConditionParser.comparator"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitComparator([NotNull] AntlrConditionParser.ComparatorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrConditionParser.binary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBinary([NotNull] AntlrConditionParser.BinaryContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrConditionParser.binary"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBinary([NotNull] AntlrConditionParser.BinaryContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="AntlrConditionParser.bool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBool([NotNull] AntlrConditionParser.BoolContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="AntlrConditionParser.bool"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBool([NotNull] AntlrConditionParser.BoolContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace dittlassian.Utilities.ConditionParser

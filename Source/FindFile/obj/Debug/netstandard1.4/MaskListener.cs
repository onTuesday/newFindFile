//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\XBO4\Desktop\FindFileByMask\newFindFile\Source\FindFile\Mask.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace FindFile {

	using System;
	using System.Text;
	using System.Text.RegularExpressions;
	using FindFile;
	using System.IO;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MaskParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMaskListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MaskParser.mask"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMask([NotNull] MaskParser.MaskContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MaskParser.mask"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMask([NotNull] MaskParser.MaskContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MaskParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] MaskParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MaskParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] MaskParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MaskParser.boolexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolexpr([NotNull] MaskParser.BoolexprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MaskParser.boolexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolexpr([NotNull] MaskParser.BoolexprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MaskParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] MaskParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MaskParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] MaskParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MaskParser.exprName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprName([NotNull] MaskParser.ExprNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MaskParser.exprName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprName([NotNull] MaskParser.ExprNameContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MaskParser.exprLength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprLength([NotNull] MaskParser.ExprLengthContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MaskParser.exprLength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprLength([NotNull] MaskParser.ExprLengthContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MaskParser.exprContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExprContent([NotNull] MaskParser.ExprContentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MaskParser.exprContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExprContent([NotNull] MaskParser.ExprContentContext context);
}
} // namespace FindFile

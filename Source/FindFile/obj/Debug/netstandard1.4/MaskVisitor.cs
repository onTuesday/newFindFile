//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

<<<<<<< HEAD
// Generated from D:\newFindFile\Source\FindFile\Mask.g4 by ANTLR 4.6.6
=======
// Generated from C:\Users\User\Desktop\Repos\newFindFile\Source\FindFile\Mask.g4 by ANTLR 4.6.6
>>>>>>> 98f5092b6652f5978e8341155bf52f41df94e72e

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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MaskParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMaskVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MaskParser.mask"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMask([NotNull] MaskParser.MaskContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MaskParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] MaskParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MaskParser.boolexpr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBoolexpr([NotNull] MaskParser.BoolexprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MaskParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] MaskParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MaskParser.exprName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprName([NotNull] MaskParser.ExprNameContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MaskParser.exprLength"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprLength([NotNull] MaskParser.ExprLengthContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MaskParser.exprContent"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExprContent([NotNull] MaskParser.ExprContentContext context);
}
} // namespace FindFile

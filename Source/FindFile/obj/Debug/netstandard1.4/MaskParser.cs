//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\User\Desktop\Repos\newFindFile\Source\FindFile\Mask.g4 by ANTLR 4.6.6

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

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Collections.Generic;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class MaskParser : Parser {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, EQUAL_SIGN=12, EQUAL_SIGN_1=13, EQUAL_SIGN_2=14, NAME_SYMBOLS=15, 
		LENGTH_SYMBOLS=16, LENGTH_SYMBOLS_1=17, LENGTH_SYMBOLS_2=18, CONTENT_SYMBOLS=19, 
		NEWLINE=20;
	public const int
		RULE_mask = 0, RULE_statement = 1, RULE_boolexpr = 2, RULE_expr = 3, RULE_exprName = 4, 
		RULE_exprLength = 5, RULE_exprContent = 6;
	public static readonly string[] ruleNames = {
		"mask", "statement", "boolexpr", "expr", "exprName", "exprLength", "exprContent"
	};

	private static readonly string[] _LiteralNames = {
		null, "'&'", "'|'", "'^'", "'('", "')'", "'Name'", "'='", "'''", "'~'", 
		"'Length'", "'Content'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		"EQUAL_SIGN", "EQUAL_SIGN_1", "EQUAL_SIGN_2", "NAME_SYMBOLS", "LENGTH_SYMBOLS", 
		"LENGTH_SYMBOLS_1", "LENGTH_SYMBOLS_2", "CONTENT_SYMBOLS", "NEWLINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Mask.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }


		String NAME	= Path.GetFileName(MaskHandler.currentFile.GetName());
	    UInt64 LENGTH = MaskHandler.currentFile.GetLength();
	    String CONTENT = MaskHandler.currentFile.GetContent();

		bool IfFitsToNamemask(String Name, String Mask)
		{
			Regex mask = new Regex(Mask.Replace(".", "[.]").Replace("*", ".*").Replace("?", "."));
			return mask.IsMatch(Name);
		}

	public MaskParser(ITokenStream input)
		: base(input)
	{
		_interp = new ParserATNSimulator(this,_ATN);
	}
	public partial class MaskContext : ParserRuleContext {
		public StatementContext statement() {
			return GetRuleContext<StatementContext>(0);
		}
		public MaskContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_mask; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.EnterMask(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.ExitMask(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaskVisitor<TResult> typedVisitor = visitor as IMaskVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMask(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MaskContext mask() {
		MaskContext _localctx = new MaskContext(_ctx, State);
		EnterRule(_localctx, 0, RULE_mask);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14; statement();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StatementContext : ParserRuleContext {
		public BoolexprContext _boolexpr;
		public BoolexprContext boolexpr() {
			return GetRuleContext<BoolexprContext>(0);
		}
		public StatementContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_statement; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.EnterStatement(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.ExitStatement(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaskVisitor<TResult> typedVisitor = visitor as IMaskVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStatement(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StatementContext statement() {
		StatementContext _localctx = new StatementContext(_ctx, State);
		EnterRule(_localctx, 2, RULE_statement);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16; _localctx._boolexpr = boolexpr();
			 MaskHandler.final = _localctx._boolexpr.value; 
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class BoolexprContext : ParserRuleContext {
		public bool value;
		public ExprContext e1;
		public ExprContext e2;
		public ExprContext e3;
		public ExprContext e4;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public BoolexprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_boolexpr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.EnterBoolexpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.ExitBoolexpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaskVisitor<TResult> typedVisitor = visitor as IMaskVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoolexpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public BoolexprContext boolexpr() {
		BoolexprContext _localctx = new BoolexprContext(_ctx, State);
		EnterRule(_localctx, 4, RULE_boolexpr);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19; _localctx.e1 = expr();
			 _localctx.value =  _localctx.e1.value; 
			State = 35;
			_errHandler.Sync(this);
			_la = _input.La(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2))) != 0)) {
				{
				State = 33;
				_errHandler.Sync(this);
				switch (_input.La(1)) {
				case T__0:
					{
					State = 21; Match(T__0);
					State = 22; _localctx.e2 = expr();
					 _localctx.value &= _localctx.e2.value; 
					}
					break;
				case T__1:
					{
					State = 25; Match(T__1);
					State = 26; _localctx.e3 = expr();
					 _localctx.value |= _localctx.e3.value; 
					}
					break;
				case T__2:
					{
					State = 29; Match(T__2);
					State = 30; _localctx.e4 = expr();
					 _localctx.value =  !_localctx.e4.value; 
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 37;
				_errHandler.Sync(this);
				_la = _input.La(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public bool value;
		public ExprNameContext eName;
		public ExprLengthContext eLength;
		public ExprContentContext eContent;
		public BoolexprContext _boolexpr;
		public ExprNameContext[] exprName() {
			return GetRuleContexts<ExprNameContext>();
		}
		public ExprNameContext exprName(int i) {
			return GetRuleContext<ExprNameContext>(i);
		}
		public ExprLengthContext[] exprLength() {
			return GetRuleContexts<ExprLengthContext>();
		}
		public ExprLengthContext exprLength(int i) {
			return GetRuleContext<ExprLengthContext>(i);
		}
		public ExprContentContext[] exprContent() {
			return GetRuleContexts<ExprContentContext>();
		}
		public ExprContentContext exprContent(int i) {
			return GetRuleContext<ExprContentContext>(i);
		}
		public BoolexprContext boolexpr() {
			return GetRuleContext<BoolexprContext>(0);
		}
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.EnterExpr(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.ExitExpr(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaskVisitor<TResult> typedVisitor = visitor as IMaskVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExpr(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		ExprContext _localctx = new ExprContext(_ctx, State);
		EnterRule(_localctx, 6, RULE_expr);
		int _la;
		try {
			State = 82;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,11,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 48;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==T__3 || _la==T__5) {
					{
					{
					State = 39;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==T__3) {
						{
						State = 38; Match(T__3);
						}
					}

					State = 41; _localctx.eName = exprName();
					_localctx.value =  _localctx.eName.value;
					State = 44;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,3,_ctx) ) {
					case 1:
						{
						State = 43; Match(T__4);
						}
						break;
					}
					}
					}
					State = 50;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 61;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__3) | (1L << T__9) | (1L << LENGTH_SYMBOLS) | (1L << LENGTH_SYMBOLS_1))) != 0)) {
					{
					{
					State = 52;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==T__3) {
						{
						State = 51; Match(T__3);
						}
					}

					State = 54; _localctx.eLength = exprLength();
					_localctx.value =  _localctx.eLength.value;
					State = 57;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,6,_ctx) ) {
					case 1:
						{
						State = 56; Match(T__4);
						}
						break;
					}
					}
					}
					State = 63;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				break;

			case 3:
				EnterOuterAlt(_localctx, 3);
				{
				State = 74;
				_errHandler.Sync(this);
				_la = _input.La(1);
				while (_la==T__3 || _la==T__10) {
					{
					{
					State = 65;
					_errHandler.Sync(this);
					_la = _input.La(1);
					if (_la==T__3) {
						{
						State = 64; Match(T__3);
						}
					}

					State = 67; _localctx.eContent = exprContent();
					_localctx.value =  _localctx.eContent.value;
					State = 70;
					_errHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(_input,9,_ctx) ) {
					case 1:
						{
						State = 69; Match(T__4);
						}
						break;
					}
					}
					}
					State = 76;
					_errHandler.Sync(this);
					_la = _input.La(1);
				}
				}
				break;

			case 4:
				EnterOuterAlt(_localctx, 4);
				{
				State = 77; Match(T__3);
				State = 78; _localctx._boolexpr = boolexpr();
				State = 79; Match(T__4);
				_localctx.value =  _localctx._boolexpr.value;
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprNameContext : ParserRuleContext {
		public bool value;
		public IToken _NAME_SYMBOLS;
		public ITerminalNode NAME_SYMBOLS() { return GetToken(MaskParser.NAME_SYMBOLS, 0); }
		public ExprNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.EnterExprName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.ExitExprName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaskVisitor<TResult> typedVisitor = visitor as IMaskVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprNameContext exprName() {
		ExprNameContext _localctx = new ExprNameContext(_ctx, State);
		EnterRule(_localctx, 8, RULE_exprName);
		try {
			State = 96;
			_errHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(_input,12,_ctx) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 84; Match(T__5);
				State = 85; Match(T__6);
				State = 86; Match(T__7);
				State = 87; _localctx._NAME_SYMBOLS = Match(NAME_SYMBOLS);
				State = 88; Match(T__7);
				 _localctx.value =  (NAME == (_localctx._NAME_SYMBOLS!=null?_localctx._NAME_SYMBOLS.Text:null)); 
				}
				break;

			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 90; Match(T__5);
				State = 91; Match(T__8);
				State = 92; Match(T__7);
				State = 93; _localctx._NAME_SYMBOLS = Match(NAME_SYMBOLS);
				State = 94; Match(T__7);
				 _localctx.value =  IfFitsToNamemask(NAME, (_localctx._NAME_SYMBOLS!=null?_localctx._NAME_SYMBOLS.Text:null)); 
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprLengthContext : ParserRuleContext {
		public bool value;
		public IToken _LENGTH_SYMBOLS;
		public IToken _EQUAL_SIGN;
		public IToken _LENGTH_SYMBOLS_1;
		public IToken _EQUAL_SIGN_1;
		public IToken _EQUAL_SIGN_2;
		public IToken _LENGTH_SYMBOLS_2;
		public ITerminalNode LENGTH_SYMBOLS() { return GetToken(MaskParser.LENGTH_SYMBOLS, 0); }
		public ITerminalNode EQUAL_SIGN() { return GetToken(MaskParser.EQUAL_SIGN, 0); }
		public ITerminalNode LENGTH_SYMBOLS_1() { return GetToken(MaskParser.LENGTH_SYMBOLS_1, 0); }
		public ITerminalNode EQUAL_SIGN_1() { return GetToken(MaskParser.EQUAL_SIGN_1, 0); }
		public ITerminalNode EQUAL_SIGN_2() { return GetToken(MaskParser.EQUAL_SIGN_2, 0); }
		public ITerminalNode LENGTH_SYMBOLS_2() { return GetToken(MaskParser.LENGTH_SYMBOLS_2, 0); }
		public ExprLengthContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprLength; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.EnterExprLength(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.ExitExprLength(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaskVisitor<TResult> typedVisitor = visitor as IMaskVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprLength(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprLengthContext exprLength() {
		ExprLengthContext _localctx = new ExprLengthContext(_ctx, State);
		EnterRule(_localctx, 10, RULE_exprLength);
		try {
			State = 112;
			_errHandler.Sync(this);
			switch (_input.La(1)) {
			case LENGTH_SYMBOLS:
				EnterOuterAlt(_localctx, 1);
				{
				State = 98; _localctx._LENGTH_SYMBOLS = Match(LENGTH_SYMBOLS);
				State = 99; _localctx._EQUAL_SIGN = Match(EQUAL_SIGN);
				State = 100; Match(T__9);

						String Size = (_localctx._LENGTH_SYMBOLS!=null?_localctx._LENGTH_SYMBOLS.Text:null);
						UInt64 Length;
						
						switch(Size.Substring(Size.Length - 1))
						{
							case "k": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024; break;
							case "K": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024; break;
							case "m": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024; break;
							case "M": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024; break;
							case "g": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024 * 1024; break;
							case "G": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024 * 1024; break;
							default: Length = UInt64.Parse(Size); break;
						}
						
						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null) == "=")
						{
							_localctx.value =  (Length == LENGTH);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == "<")
						{
							_localctx.value =  (Length < LENGTH);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == ">")
						{
							_localctx.value =  (Length > LENGTH);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == ">=")
						{
							_localctx.value =  (Length >= LENGTH);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == "<=")
						{
							_localctx.value =  (Length <= LENGTH);
						}
					
				}
				break;
			case T__9:
				EnterOuterAlt(_localctx, 2);
				{
				State = 102; Match(T__9);
				State = 103; _localctx._EQUAL_SIGN = Match(EQUAL_SIGN);
				State = 104; _localctx._LENGTH_SYMBOLS = Match(LENGTH_SYMBOLS);

						String Size = (_localctx._LENGTH_SYMBOLS!=null?_localctx._LENGTH_SYMBOLS.Text:null);
						UInt64 Length;
						
						switch(Size.Substring(Size.Length - 1))
						{
							case "k": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024; break;
							case "K": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024; break;
							case "m": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024; break;
							case "M": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024; break;
							case "g": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024 * 1024; break;
							case "G": Length = UInt64.Parse(Size.TrimEnd(Size[Size.Length - 1])) * 1024 * 1024 * 1024; break;
							default: Length = UInt64.Parse(Size); break;
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null) == "=")
						{
							_localctx.value =  (LENGTH == Length);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == "<")
						{
							_localctx.value =  (LENGTH < Length);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == ">")
						{
							_localctx.value =  (LENGTH > Length);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == ">=")
						{
							_localctx.value =  (LENGTH >= Length);
						}

						if ((_localctx._EQUAL_SIGN!=null?_localctx._EQUAL_SIGN.Text:null)  == "<=")
						{
							_localctx.value =  (LENGTH <= Length);
						}
					
				}
				break;
			case LENGTH_SYMBOLS_1:
				EnterOuterAlt(_localctx, 3);
				{
				State = 106; _localctx._LENGTH_SYMBOLS_1 = Match(LENGTH_SYMBOLS_1);
				State = 107; _localctx._EQUAL_SIGN_1 = Match(EQUAL_SIGN_1);
				State = 108; Match(T__9);
				State = 109; _localctx._EQUAL_SIGN_2 = Match(EQUAL_SIGN_2);
				State = 110; _localctx._LENGTH_SYMBOLS_2 = Match(LENGTH_SYMBOLS_2);

						String Size1 = (_localctx._LENGTH_SYMBOLS_1!=null?_localctx._LENGTH_SYMBOLS_1.Text:null);
						UInt64 Length1;
						
						switch(Size1.Substring(Size1.Length - 1))
						{
							case "k": Length1 = UInt64.Parse(Size1.TrimEnd(Size1[Size1.Length - 1])) * 1024; break;
							case "K": Length1 = UInt64.Parse(Size1.TrimEnd(Size1[Size1.Length - 1])) * 1024; break;
							case "m": Length1 = UInt64.Parse(Size1.TrimEnd(Size1[Size1.Length - 1])) * 1024 * 1024; break;
							case "M": Length1 = UInt64.Parse(Size1.TrimEnd(Size1[Size1.Length - 1])) * 1024 * 1024; break;
							case "g": Length1 = UInt64.Parse(Size1.TrimEnd(Size1[Size1.Length - 1])) * 1024 * 1024 * 1024; break;
							case "G": Length1 = UInt64.Parse(Size1.TrimEnd(Size1[Size1.Length - 1])) * 1024 * 1024 * 1024; break;
							default: Length1 = UInt64.Parse(Size1); break;
						}

						String Size2 = (_localctx._LENGTH_SYMBOLS_2!=null?_localctx._LENGTH_SYMBOLS_2.Text:null);
						UInt64 Length2;
						
						switch(Size2.Substring(Size2.Length - 1))
						{
							case "k": Length2 = UInt64.Parse(Size2.TrimEnd(Size2[Size2.Length - 1])) * 1024; break;
							case "K": Length2 = UInt64.Parse(Size2.TrimEnd(Size2[Size2.Length - 1])) * 1024; break;
							case "m": Length2 = UInt64.Parse(Size2.TrimEnd(Size2[Size2.Length - 1])) * 1024 * 1024; break;
							case "M": Length2 = UInt64.Parse(Size2.TrimEnd(Size2[Size2.Length - 1])) * 1024 * 1024; break;
							case "g": Length2 = UInt64.Parse(Size2.TrimEnd(Size2[Size2.Length - 1])) * 1024 * 1024 * 1024; break;
							case "G": Length2 = UInt64.Parse(Size2.TrimEnd(Size2[Size2.Length - 1])) * 1024 * 1024 * 1024; break;
							default: Length2 = UInt64.Parse(Size2); break;
						}
						
						if ((_localctx._EQUAL_SIGN_1!=null?_localctx._EQUAL_SIGN_1.Text:null) == ">")
						{
							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<")
							{
								_localctx.value =  ((LENGTH < Length1) && (LENGTH < Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">")
							{
								_localctx.value =  ((LENGTH < Length1) && (LENGTH > Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">=")
							{
								_localctx.value =  ((LENGTH < Length1) && (LENGTH >= Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<=")
							{
								_localctx.value =  ((LENGTH < Length1) && (LENGTH <= Length2));
							}
						}

						if ((_localctx._EQUAL_SIGN_1!=null?_localctx._EQUAL_SIGN_1.Text:null) == "<")
						{
							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<")
							{
								_localctx.value =  ((LENGTH > Length1) && (LENGTH < Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">")
							{
								_localctx.value =  ((LENGTH > Length1) && (LENGTH > Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">=")
							{
								_localctx.value =  ((LENGTH > Length1) && (LENGTH >= Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<=")
							{
								_localctx.value =  ((LENGTH > Length1) && (LENGTH <= Length2));
							}
						}

						if ((_localctx._EQUAL_SIGN_1!=null?_localctx._EQUAL_SIGN_1.Text:null) == ">=")
						{
							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<")
							{
								_localctx.value =  ((LENGTH <= Length1) && (LENGTH < Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">")
							{
								_localctx.value =  ((LENGTH <= Length1) && (LENGTH > Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">=")
							{
								_localctx.value =  ((LENGTH <= Length1) && (LENGTH >= Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<=")
							{
								_localctx.value =  ((LENGTH <= Length1) && (LENGTH <= Length2));
							}
						}

						if ((_localctx._EQUAL_SIGN_1!=null?_localctx._EQUAL_SIGN_1.Text:null) == "<=")
						{
							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<")
							{
								_localctx.value =  ((LENGTH >= Length1) && (LENGTH < Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">")
							{
								_localctx.value =  ((LENGTH >= Length1) && (LENGTH > Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == ">=")
							{
								_localctx.value =  ((LENGTH >= Length1) && (LENGTH >= Length2));
							}

							if ((_localctx._EQUAL_SIGN_2!=null?_localctx._EQUAL_SIGN_2.Text:null)  == "<=")
							{
								_localctx.value =  ((LENGTH >= Length1) && (LENGTH <= Length2));
							}
						}
					
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContentContext : ParserRuleContext {
		public bool value;
		public IToken _CONTENT_SYMBOLS;
		public ITerminalNode CONTENT_SYMBOLS() { return GetToken(MaskParser.CONTENT_SYMBOLS, 0); }
		public ExprContentContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exprContent; } }
		public override void EnterRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.EnterExprContent(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IMaskListener typedListener = listener as IMaskListener;
			if (typedListener != null) typedListener.ExitExprContent(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IMaskVisitor<TResult> typedVisitor = visitor as IMaskVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExprContent(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContentContext exprContent() {
		ExprContentContext _localctx = new ExprContentContext(_ctx, State);
		EnterRule(_localctx, 12, RULE_exprContent);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 114; Match(T__10);
			State = 115; Match(T__8);
			State = 116; Match(T__7);
			State = 117; _localctx._CONTENT_SYMBOLS = Match(CONTENT_SYMBOLS);
			State = 118; Match(T__7);
			 _localctx.value =  CONTENT.Contains((_localctx._CONTENT_SYMBOLS!=null?_localctx._CONTENT_SYMBOLS.Text:null)); 
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.ReportError(this, re);
			_errHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x3\x16|\x4\x2\t\x2"+
		"\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x3\x2\x3"+
		"\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\a\x4$\n\x4\f\x4\xE\x4\'\v\x4\x3\x5"+
		"\x5\x5*\n\x5\x3\x5\x3\x5\x3\x5\x5\x5/\n\x5\a\x5\x31\n\x5\f\x5\xE\x5\x34"+
		"\v\x5\x3\x5\x5\x5\x37\n\x5\x3\x5\x3\x5\x3\x5\x5\x5<\n\x5\a\x5>\n\x5\f"+
		"\x5\xE\x5\x41\v\x5\x3\x5\x5\x5\x44\n\x5\x3\x5\x3\x5\x3\x5\x5\x5I\n\x5"+
		"\a\x5K\n\x5\f\x5\xE\x5N\v\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x5\x5U\n\x5"+
		"\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3\x6\x3"+
		"\x6\x5\x6\x63\n\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3"+
		"\a\x3\a\x3\a\x3\a\x5\as\n\a\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x2"+
		"\x2\x2\t\x2\x2\x4\x2\x6\x2\b\x2\n\x2\f\x2\xE\x2\x2\x2\x86\x2\x10\x3\x2"+
		"\x2\x2\x4\x12\x3\x2\x2\x2\x6\x15\x3\x2\x2\x2\bT\x3\x2\x2\x2\n\x62\x3\x2"+
		"\x2\x2\fr\x3\x2\x2\x2\xEt\x3\x2\x2\x2\x10\x11\x5\x4\x3\x2\x11\x3\x3\x2"+
		"\x2\x2\x12\x13\x5\x6\x4\x2\x13\x14\b\x3\x1\x2\x14\x5\x3\x2\x2\x2\x15\x16"+
		"\x5\b\x5\x2\x16%\b\x4\x1\x2\x17\x18\a\x3\x2\x2\x18\x19\x5\b\x5\x2\x19"+
		"\x1A\b\x4\x1\x2\x1A$\x3\x2\x2\x2\x1B\x1C\a\x4\x2\x2\x1C\x1D\x5\b\x5\x2"+
		"\x1D\x1E\b\x4\x1\x2\x1E$\x3\x2\x2\x2\x1F \a\x5\x2\x2 !\x5\b\x5\x2!\"\b"+
		"\x4\x1\x2\"$\x3\x2\x2\x2#\x17\x3\x2\x2\x2#\x1B\x3\x2\x2\x2#\x1F\x3\x2"+
		"\x2\x2$\'\x3\x2\x2\x2%#\x3\x2\x2\x2%&\x3\x2\x2\x2&\a\x3\x2\x2\x2\'%\x3"+
		"\x2\x2\x2(*\a\x6\x2\x2)(\x3\x2\x2\x2)*\x3\x2\x2\x2*+\x3\x2\x2\x2+,\x5"+
		"\n\x6\x2,.\b\x5\x1\x2-/\a\a\x2\x2.-\x3\x2\x2\x2./\x3\x2\x2\x2/\x31\x3"+
		"\x2\x2\x2\x30)\x3\x2\x2\x2\x31\x34\x3\x2\x2\x2\x32\x30\x3\x2\x2\x2\x32"+
		"\x33\x3\x2\x2\x2\x33U\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2\x35\x37\a\x6\x2"+
		"\x2\x36\x35\x3\x2\x2\x2\x36\x37\x3\x2\x2\x2\x37\x38\x3\x2\x2\x2\x38\x39"+
		"\x5\f\a\x2\x39;\b\x5\x1\x2:<\a\a\x2\x2;:\x3\x2\x2\x2;<\x3\x2\x2\x2<>\x3"+
		"\x2\x2\x2=\x36\x3\x2\x2\x2>\x41\x3\x2\x2\x2?=\x3\x2\x2\x2?@\x3\x2\x2\x2"+
		"@U\x3\x2\x2\x2\x41?\x3\x2\x2\x2\x42\x44\a\x6\x2\x2\x43\x42\x3\x2\x2\x2"+
		"\x43\x44\x3\x2\x2\x2\x44\x45\x3\x2\x2\x2\x45\x46\x5\xE\b\x2\x46H\b\x5"+
		"\x1\x2GI\a\a\x2\x2HG\x3\x2\x2\x2HI\x3\x2\x2\x2IK\x3\x2\x2\x2J\x43\x3\x2"+
		"\x2\x2KN\x3\x2\x2\x2LJ\x3\x2\x2\x2LM\x3\x2\x2\x2MU\x3\x2\x2\x2NL\x3\x2"+
		"\x2\x2OP\a\x6\x2\x2PQ\x5\x6\x4\x2QR\a\a\x2\x2RS\b\x5\x1\x2SU\x3\x2\x2"+
		"\x2T\x32\x3\x2\x2\x2T?\x3\x2\x2\x2TL\x3\x2\x2\x2TO\x3\x2\x2\x2U\t\x3\x2"+
		"\x2\x2VW\a\b\x2\x2WX\a\t\x2\x2XY\a\n\x2\x2YZ\a\x11\x2\x2Z[\a\n\x2\x2["+
		"\x63\b\x6\x1\x2\\]\a\b\x2\x2]^\a\v\x2\x2^_\a\n\x2\x2_`\a\x11\x2\x2`\x61"+
		"\a\n\x2\x2\x61\x63\b\x6\x1\x2\x62V\x3\x2\x2\x2\x62\\\x3\x2\x2\x2\x63\v"+
		"\x3\x2\x2\x2\x64\x65\a\x12\x2\x2\x65\x66\a\xE\x2\x2\x66g\a\f\x2\x2gs\b"+
		"\a\x1\x2hi\a\f\x2\x2ij\a\xE\x2\x2jk\a\x12\x2\x2ks\b\a\x1\x2lm\a\x13\x2"+
		"\x2mn\a\xF\x2\x2no\a\f\x2\x2op\a\x10\x2\x2pq\a\x14\x2\x2qs\b\a\x1\x2r"+
		"\x64\x3\x2\x2\x2rh\x3\x2\x2\x2rl\x3\x2\x2\x2s\r\x3\x2\x2\x2tu\a\r\x2\x2"+
		"uv\a\v\x2\x2vw\a\n\x2\x2wx\a\x15\x2\x2xy\a\n\x2\x2yz\b\b\x1\x2z\xF\x3"+
		"\x2\x2\x2\x10#%).\x32\x36;?\x43HLT\x62r";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace FindFile

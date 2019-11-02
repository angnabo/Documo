//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /home/angelica/RiderProjects/Documo/Documo/Documo.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class DocumoParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WORD=1, TEXT=2, WHITESPACE=3, STARTPLACEHOLDER=4, ENDPLACEHOLDER=5, STARTREPEATINGSECTION=6, 
		ENDREPEATINGSECTION=7, ACCESSOPERATOR=8;
	public const int
		RULE_stmt = 0, RULE_placeholder = 1, RULE_object = 2, RULE_objectFieldAccess = 3, 
		RULE_objectName = 4, RULE_objectField = 5, RULE_startRepeatingSection = 6, 
		RULE_endRepeatingSection = 7, RULE_repeatingSection = 8;
	public static readonly string[] ruleNames = {
		"stmt", "placeholder", "object", "objectFieldAccess", "objectName", "objectField", 
		"startRepeatingSection", "endRepeatingSection", "repeatingSection"
	};

	private static readonly string[] _LiteralNames = {
	};
	private static readonly string[] _SymbolicNames = {
		null, "WORD", "TEXT", "WHITESPACE", "STARTPLACEHOLDER", "ENDPLACEHOLDER", 
		"STARTREPEATINGSECTION", "ENDREPEATINGSECTION", "ACCESSOPERATOR"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Documo.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DocumoParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public DocumoParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public DocumoParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class StmtContext : ParserRuleContext {
		public ITerminalNode Eof() { return GetToken(DocumoParser.Eof, 0); }
		public PlaceholderContext[] placeholder() {
			return GetRuleContexts<PlaceholderContext>();
		}
		public PlaceholderContext placeholder(int i) {
			return GetRuleContext<PlaceholderContext>(i);
		}
		public StmtContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_stmt; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterStmt(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitStmt(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStmt(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StmtContext stmt() {
		StmtContext _localctx = new StmtContext(Context, State);
		EnterRule(_localctx, 0, RULE_stmt);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 19;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 18; placeholder();
				}
				}
				State = 21;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==STARTPLACEHOLDER );
			State = 23; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PlaceholderContext : ParserRuleContext {
		public ITerminalNode STARTPLACEHOLDER() { return GetToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public ObjectContext @object() {
			return GetRuleContext<ObjectContext>(0);
		}
		public ITerminalNode ENDPLACEHOLDER() { return GetToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public RepeatingSectionContext repeatingSection() {
			return GetRuleContext<RepeatingSectionContext>(0);
		}
		public PlaceholderContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_placeholder; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterPlaceholder(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitPlaceholder(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPlaceholder(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PlaceholderContext placeholder() {
		PlaceholderContext _localctx = new PlaceholderContext(Context, State);
		EnterRule(_localctx, 2, RULE_placeholder);
		try {
			State = 30;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,1,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 25; Match(STARTPLACEHOLDER);
				State = 26; @object();
				State = 27; Match(ENDPLACEHOLDER);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 29; repeatingSection();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ObjectContext : ParserRuleContext {
		public ObjectFieldAccessContext objectFieldAccess() {
			return GetRuleContext<ObjectFieldAccessContext>(0);
		}
		public ObjectNameContext objectName() {
			return GetRuleContext<ObjectNameContext>(0);
		}
		public ObjectContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_object; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterObject(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitObject(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObject(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectContext @object() {
		ObjectContext _localctx = new ObjectContext(Context, State);
		EnterRule(_localctx, 4, RULE_object);
		try {
			State = 34;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 32; objectFieldAccess();
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 33; objectName();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ObjectFieldAccessContext : ParserRuleContext {
		public ObjectNameContext objectName() {
			return GetRuleContext<ObjectNameContext>(0);
		}
		public ITerminalNode ACCESSOPERATOR() { return GetToken(DocumoParser.ACCESSOPERATOR, 0); }
		public ObjectFieldContext objectField() {
			return GetRuleContext<ObjectFieldContext>(0);
		}
		public ObjectFieldAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_objectFieldAccess; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterObjectFieldAccess(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitObjectFieldAccess(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObjectFieldAccess(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectFieldAccessContext objectFieldAccess() {
		ObjectFieldAccessContext _localctx = new ObjectFieldAccessContext(Context, State);
		EnterRule(_localctx, 6, RULE_objectFieldAccess);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 36; objectName();
			State = 37; Match(ACCESSOPERATOR);
			State = 38; objectField();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ObjectNameContext : ParserRuleContext {
		public ITerminalNode WORD() { return GetToken(DocumoParser.WORD, 0); }
		public ObjectNameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_objectName; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterObjectName(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitObjectName(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObjectName(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectNameContext objectName() {
		ObjectNameContext _localctx = new ObjectNameContext(Context, State);
		EnterRule(_localctx, 8, RULE_objectName);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 40; Match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ObjectFieldContext : ParserRuleContext {
		public ITerminalNode WORD() { return GetToken(DocumoParser.WORD, 0); }
		public ObjectFieldContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_objectField; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterObjectField(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitObjectField(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObjectField(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectFieldContext objectField() {
		ObjectFieldContext _localctx = new ObjectFieldContext(Context, State);
		EnterRule(_localctx, 10, RULE_objectField);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42; Match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StartRepeatingSectionContext : ParserRuleContext {
		public ITerminalNode STARTPLACEHOLDER() { return GetToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public ITerminalNode STARTREPEATINGSECTION() { return GetToken(DocumoParser.STARTREPEATINGSECTION, 0); }
		public ObjectContext @object() {
			return GetRuleContext<ObjectContext>(0);
		}
		public ITerminalNode ENDPLACEHOLDER() { return GetToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public StartRepeatingSectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_startRepeatingSection; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterStartRepeatingSection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitStartRepeatingSection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitStartRepeatingSection(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StartRepeatingSectionContext startRepeatingSection() {
		StartRepeatingSectionContext _localctx = new StartRepeatingSectionContext(Context, State);
		EnterRule(_localctx, 12, RULE_startRepeatingSection);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 44; Match(STARTPLACEHOLDER);
			State = 45; Match(STARTREPEATINGSECTION);
			State = 46; @object();
			State = 47; Match(ENDPLACEHOLDER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class EndRepeatingSectionContext : ParserRuleContext {
		public ITerminalNode STARTPLACEHOLDER() { return GetToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public ITerminalNode ENDREPEATINGSECTION() { return GetToken(DocumoParser.ENDREPEATINGSECTION, 0); }
		public ObjectContext @object() {
			return GetRuleContext<ObjectContext>(0);
		}
		public ITerminalNode ENDPLACEHOLDER() { return GetToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public EndRepeatingSectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_endRepeatingSection; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterEndRepeatingSection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitEndRepeatingSection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEndRepeatingSection(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public EndRepeatingSectionContext endRepeatingSection() {
		EndRepeatingSectionContext _localctx = new EndRepeatingSectionContext(Context, State);
		EnterRule(_localctx, 14, RULE_endRepeatingSection);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 49; Match(STARTPLACEHOLDER);
			State = 50; Match(ENDREPEATINGSECTION);
			State = 51; @object();
			State = 52; Match(ENDPLACEHOLDER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class RepeatingSectionContext : ParserRuleContext {
		public StartRepeatingSectionContext startRepeatingSection() {
			return GetRuleContext<StartRepeatingSectionContext>(0);
		}
		public EndRepeatingSectionContext endRepeatingSection() {
			return GetRuleContext<EndRepeatingSectionContext>(0);
		}
		public PlaceholderContext[] placeholder() {
			return GetRuleContexts<PlaceholderContext>();
		}
		public PlaceholderContext placeholder(int i) {
			return GetRuleContext<PlaceholderContext>(i);
		}
		public RepeatingSectionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_repeatingSection; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.EnterRepeatingSection(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDocumoListener typedListener = listener as IDocumoListener;
			if (typedListener != null) typedListener.ExitRepeatingSection(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDocumoVisitor<TResult> typedVisitor = visitor as IDocumoVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRepeatingSection(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public RepeatingSectionContext repeatingSection() {
		RepeatingSectionContext _localctx = new RepeatingSectionContext(Context, State);
		EnterRule(_localctx, 16, RULE_repeatingSection);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 54; startRepeatingSection();
			State = 56;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 55; placeholder();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 58;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,3,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 60; endRepeatingSection();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\n', '\x41', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', '\b', 
		'\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x3', '\x2', '\x6', 
		'\x2', '\x16', '\n', '\x2', '\r', '\x2', '\xE', '\x2', '\x17', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '!', '\n', '\x3', '\x3', '\x4', '\x3', 
		'\x4', '\x5', '\x4', '%', '\n', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', 
		'\x3', '\n', '\x6', '\n', ';', '\n', '\n', '\r', '\n', '\xE', '\n', '<', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x2', '\x2', '\v', '\x2', '\x4', 
		'\x6', '\b', '\n', '\f', '\xE', '\x10', '\x12', '\x2', '\x2', '\x2', ';', 
		'\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x4', ' ', '\x3', '\x2', '\x2', 
		'\x2', '\x6', '$', '\x3', '\x2', '\x2', '\x2', '\b', '&', '\x3', '\x2', 
		'\x2', '\x2', '\n', '*', '\x3', '\x2', '\x2', '\x2', '\f', ',', '\x3', 
		'\x2', '\x2', '\x2', '\xE', '.', '\x3', '\x2', '\x2', '\x2', '\x10', '\x33', 
		'\x3', '\x2', '\x2', '\x2', '\x12', '\x38', '\x3', '\x2', '\x2', '\x2', 
		'\x14', '\x16', '\x5', '\x4', '\x3', '\x2', '\x15', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x16', '\x17', '\x3', '\x2', '\x2', '\x2', '\x17', '\x15', 
		'\x3', '\x2', '\x2', '\x2', '\x17', '\x18', '\x3', '\x2', '\x2', '\x2', 
		'\x18', '\x19', '\x3', '\x2', '\x2', '\x2', '\x19', '\x1A', '\a', '\x2', 
		'\x2', '\x3', '\x1A', '\x3', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', 
		'\a', '\x6', '\x2', '\x2', '\x1C', '\x1D', '\x5', '\x6', '\x4', '\x2', 
		'\x1D', '\x1E', '\a', '\a', '\x2', '\x2', '\x1E', '!', '\x3', '\x2', '\x2', 
		'\x2', '\x1F', '!', '\x5', '\x12', '\n', '\x2', ' ', '\x1B', '\x3', '\x2', 
		'\x2', '\x2', ' ', '\x1F', '\x3', '\x2', '\x2', '\x2', '!', '\x5', '\x3', 
		'\x2', '\x2', '\x2', '\"', '%', '\x5', '\b', '\x5', '\x2', '#', '%', '\x5', 
		'\n', '\x6', '\x2', '$', '\"', '\x3', '\x2', '\x2', '\x2', '$', '#', '\x3', 
		'\x2', '\x2', '\x2', '%', '\a', '\x3', '\x2', '\x2', '\x2', '&', '\'', 
		'\x5', '\n', '\x6', '\x2', '\'', '(', '\a', '\n', '\x2', '\x2', '(', ')', 
		'\x5', '\f', '\a', '\x2', ')', '\t', '\x3', '\x2', '\x2', '\x2', '*', 
		'+', '\a', '\x3', '\x2', '\x2', '+', '\v', '\x3', '\x2', '\x2', '\x2', 
		',', '-', '\a', '\x3', '\x2', '\x2', '-', '\r', '\x3', '\x2', '\x2', '\x2', 
		'.', '/', '\a', '\x6', '\x2', '\x2', '/', '\x30', '\a', '\b', '\x2', '\x2', 
		'\x30', '\x31', '\x5', '\x6', '\x4', '\x2', '\x31', '\x32', '\a', '\a', 
		'\x2', '\x2', '\x32', '\xF', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', 
		'\a', '\x6', '\x2', '\x2', '\x34', '\x35', '\a', '\t', '\x2', '\x2', '\x35', 
		'\x36', '\x5', '\x6', '\x4', '\x2', '\x36', '\x37', '\a', '\a', '\x2', 
		'\x2', '\x37', '\x11', '\x3', '\x2', '\x2', '\x2', '\x38', ':', '\x5', 
		'\xE', '\b', '\x2', '\x39', ';', '\x5', '\x4', '\x3', '\x2', ':', '\x39', 
		'\x3', '\x2', '\x2', '\x2', ';', '<', '\x3', '\x2', '\x2', '\x2', '<', 
		':', '\x3', '\x2', '\x2', '\x2', '<', '=', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\x3', '\x2', '\x2', '\x2', '>', '?', '\x5', '\x10', '\t', '\x2', 
		'?', '\x13', '\x3', '\x2', '\x2', '\x2', '\x6', '\x17', ' ', '$', '<',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
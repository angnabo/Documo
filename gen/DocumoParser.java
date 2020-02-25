// Generated from /home/angelica/RiderProjects/Documo/Documo/Grammar/Documo.g4 by ANTLR 4.8
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class DocumoParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		WORD=1, WHITESPACE=2, STARTPLACEHOLDER=3, ENDPLACEHOLDER=4, IMAGEPLACEHOLDER=5, 
		STARTREPEATINGSECTION=6, ENDREPEATINGSECTION=7, ACCESSOPERATOR=8, IF=9, 
		OPERATOR=10, EQUALSOPERATOR=11, NOTEQUALSOPERATOR=12;
	public static final int
		RULE_stmt = 0, RULE_placeholder = 1, RULE_repeatingSection = 2, RULE_imagePlaceholder = 3, 
		RULE_conditionalPlaceholder = 4, RULE_startRepeatingSection = 5, RULE_endRepeatingSection = 6, 
		RULE_object = 7, RULE_objectFieldAccess = 8, RULE_objectName = 9, RULE_objectField = 10;
	private static String[] makeRuleNames() {
		return new String[] {
			"stmt", "placeholder", "repeatingSection", "imagePlaceholder", "conditionalPlaceholder", 
			"startRepeatingSection", "endRepeatingSection", "object", "objectFieldAccess", 
			"objectName", "objectField"
		};
	}
	public static final String[] ruleNames = makeRuleNames();

	private static String[] makeLiteralNames() {
		return new String[] {
		};
	}
	private static final String[] _LITERAL_NAMES = makeLiteralNames();
	private static String[] makeSymbolicNames() {
		return new String[] {
			null, "WORD", "WHITESPACE", "STARTPLACEHOLDER", "ENDPLACEHOLDER", "IMAGEPLACEHOLDER", 
			"STARTREPEATINGSECTION", "ENDREPEATINGSECTION", "ACCESSOPERATOR", "IF", 
			"OPERATOR", "EQUALSOPERATOR", "NOTEQUALSOPERATOR"
		};
	}
	private static final String[] _SYMBOLIC_NAMES = makeSymbolicNames();
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "Documo.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public DocumoParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	public static class StmtContext extends ParserRuleContext {
		public TerminalNode EOF() { return getToken(DocumoParser.EOF, 0); }
		public List<PlaceholderContext> placeholder() {
			return getRuleContexts(PlaceholderContext.class);
		}
		public PlaceholderContext placeholder(int i) {
			return getRuleContext(PlaceholderContext.class,i);
		}
		public StmtContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_stmt; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterStmt(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitStmt(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitStmt(this);
			else return visitor.visitChildren(this);
		}
	}

	public final StmtContext stmt() throws RecognitionException {
		StmtContext _localctx = new StmtContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_stmt);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(23); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(22);
				placeholder();
				}
				}
				setState(25); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==STARTPLACEHOLDER );
			setState(27);
			match(EOF);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class PlaceholderContext extends ParserRuleContext {
		public TerminalNode STARTPLACEHOLDER() { return getToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public ObjectContext object() {
			return getRuleContext(ObjectContext.class,0);
		}
		public TerminalNode ENDPLACEHOLDER() { return getToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public RepeatingSectionContext repeatingSection() {
			return getRuleContext(RepeatingSectionContext.class,0);
		}
		public ImagePlaceholderContext imagePlaceholder() {
			return getRuleContext(ImagePlaceholderContext.class,0);
		}
		public ConditionalPlaceholderContext conditionalPlaceholder() {
			return getRuleContext(ConditionalPlaceholderContext.class,0);
		}
		public PlaceholderContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_placeholder; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterPlaceholder(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitPlaceholder(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitPlaceholder(this);
			else return visitor.visitChildren(this);
		}
	}

	public final PlaceholderContext placeholder() throws RecognitionException {
		PlaceholderContext _localctx = new PlaceholderContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_placeholder);
		try {
			setState(36);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(29);
				match(STARTPLACEHOLDER);
				setState(30);
				object();
				setState(31);
				match(ENDPLACEHOLDER);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(33);
				repeatingSection();
				}
				break;
			case 3:
				enterOuterAlt(_localctx, 3);
				{
				setState(34);
				imagePlaceholder();
				}
				break;
			case 4:
				enterOuterAlt(_localctx, 4);
				{
				setState(35);
				conditionalPlaceholder();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class RepeatingSectionContext extends ParserRuleContext {
		public StartRepeatingSectionContext startRepeatingSection() {
			return getRuleContext(StartRepeatingSectionContext.class,0);
		}
		public EndRepeatingSectionContext endRepeatingSection() {
			return getRuleContext(EndRepeatingSectionContext.class,0);
		}
		public List<PlaceholderContext> placeholder() {
			return getRuleContexts(PlaceholderContext.class);
		}
		public PlaceholderContext placeholder(int i) {
			return getRuleContext(PlaceholderContext.class,i);
		}
		public RepeatingSectionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_repeatingSection; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterRepeatingSection(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitRepeatingSection(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitRepeatingSection(this);
			else return visitor.visitChildren(this);
		}
	}

	public final RepeatingSectionContext repeatingSection() throws RecognitionException {
		RepeatingSectionContext _localctx = new RepeatingSectionContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_repeatingSection);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(38);
			startRepeatingSection();
			setState(40); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(39);
					placeholder();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(42); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
			} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			setState(44);
			endRepeatingSection();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ImagePlaceholderContext extends ParserRuleContext {
		public TerminalNode STARTPLACEHOLDER() { return getToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public TerminalNode IMAGEPLACEHOLDER() { return getToken(DocumoParser.IMAGEPLACEHOLDER, 0); }
		public ObjectContext object() {
			return getRuleContext(ObjectContext.class,0);
		}
		public TerminalNode ENDPLACEHOLDER() { return getToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public ImagePlaceholderContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_imagePlaceholder; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterImagePlaceholder(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitImagePlaceholder(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitImagePlaceholder(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ImagePlaceholderContext imagePlaceholder() throws RecognitionException {
		ImagePlaceholderContext _localctx = new ImagePlaceholderContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_imagePlaceholder);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(46);
			match(STARTPLACEHOLDER);
			setState(47);
			match(IMAGEPLACEHOLDER);
			setState(48);
			object();
			setState(49);
			match(ENDPLACEHOLDER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ConditionalPlaceholderContext extends ParserRuleContext {
		public TerminalNode STARTPLACEHOLDER() { return getToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public TerminalNode IF() { return getToken(DocumoParser.IF, 0); }
		public ObjectContext object() {
			return getRuleContext(ObjectContext.class,0);
		}
		public TerminalNode ENDPLACEHOLDER() { return getToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public ConditionalPlaceholderContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_conditionalPlaceholder; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterConditionalPlaceholder(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitConditionalPlaceholder(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitConditionalPlaceholder(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ConditionalPlaceholderContext conditionalPlaceholder() throws RecognitionException {
		ConditionalPlaceholderContext _localctx = new ConditionalPlaceholderContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_conditionalPlaceholder);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(51);
			match(STARTPLACEHOLDER);
			setState(52);
			match(IF);
			setState(53);
			object();
			setState(54);
			match(ENDPLACEHOLDER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class StartRepeatingSectionContext extends ParserRuleContext {
		public TerminalNode STARTPLACEHOLDER() { return getToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public TerminalNode STARTREPEATINGSECTION() { return getToken(DocumoParser.STARTREPEATINGSECTION, 0); }
		public ObjectContext object() {
			return getRuleContext(ObjectContext.class,0);
		}
		public TerminalNode ENDPLACEHOLDER() { return getToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public StartRepeatingSectionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_startRepeatingSection; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterStartRepeatingSection(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitStartRepeatingSection(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitStartRepeatingSection(this);
			else return visitor.visitChildren(this);
		}
	}

	public final StartRepeatingSectionContext startRepeatingSection() throws RecognitionException {
		StartRepeatingSectionContext _localctx = new StartRepeatingSectionContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_startRepeatingSection);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(56);
			match(STARTPLACEHOLDER);
			setState(57);
			match(STARTREPEATINGSECTION);
			setState(58);
			object();
			setState(59);
			match(ENDPLACEHOLDER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class EndRepeatingSectionContext extends ParserRuleContext {
		public TerminalNode STARTPLACEHOLDER() { return getToken(DocumoParser.STARTPLACEHOLDER, 0); }
		public TerminalNode ENDREPEATINGSECTION() { return getToken(DocumoParser.ENDREPEATINGSECTION, 0); }
		public ObjectContext object() {
			return getRuleContext(ObjectContext.class,0);
		}
		public TerminalNode ENDPLACEHOLDER() { return getToken(DocumoParser.ENDPLACEHOLDER, 0); }
		public EndRepeatingSectionContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_endRepeatingSection; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterEndRepeatingSection(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitEndRepeatingSection(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitEndRepeatingSection(this);
			else return visitor.visitChildren(this);
		}
	}

	public final EndRepeatingSectionContext endRepeatingSection() throws RecognitionException {
		EndRepeatingSectionContext _localctx = new EndRepeatingSectionContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_endRepeatingSection);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(61);
			match(STARTPLACEHOLDER);
			setState(62);
			match(ENDREPEATINGSECTION);
			setState(63);
			object();
			setState(64);
			match(ENDPLACEHOLDER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ObjectContext extends ParserRuleContext {
		public ObjectFieldAccessContext objectFieldAccess() {
			return getRuleContext(ObjectFieldAccessContext.class,0);
		}
		public ObjectNameContext objectName() {
			return getRuleContext(ObjectNameContext.class,0);
		}
		public ObjectContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_object; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterObject(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitObject(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitObject(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ObjectContext object() throws RecognitionException {
		ObjectContext _localctx = new ObjectContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_object);
		try {
			setState(68);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(66);
				objectFieldAccess();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(67);
				objectName();
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ObjectFieldAccessContext extends ParserRuleContext {
		public ObjectNameContext objectName() {
			return getRuleContext(ObjectNameContext.class,0);
		}
		public TerminalNode ACCESSOPERATOR() { return getToken(DocumoParser.ACCESSOPERATOR, 0); }
		public ObjectFieldContext objectField() {
			return getRuleContext(ObjectFieldContext.class,0);
		}
		public ObjectFieldAccessContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_objectFieldAccess; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterObjectFieldAccess(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitObjectFieldAccess(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitObjectFieldAccess(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ObjectFieldAccessContext objectFieldAccess() throws RecognitionException {
		ObjectFieldAccessContext _localctx = new ObjectFieldAccessContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_objectFieldAccess);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(70);
			objectName();
			setState(71);
			match(ACCESSOPERATOR);
			setState(72);
			objectField();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ObjectNameContext extends ParserRuleContext {
		public TerminalNode WORD() { return getToken(DocumoParser.WORD, 0); }
		public ObjectNameContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_objectName; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterObjectName(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitObjectName(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitObjectName(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ObjectNameContext objectName() throws RecognitionException {
		ObjectNameContext _localctx = new ObjectNameContext(_ctx, getState());
		enterRule(_localctx, 18, RULE_objectName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(74);
			match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ObjectFieldContext extends ParserRuleContext {
		public TerminalNode WORD() { return getToken(DocumoParser.WORD, 0); }
		public ObjectFieldContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_objectField; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).enterObjectField(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof DocumoListener ) ((DocumoListener)listener).exitObjectField(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof DocumoVisitor ) return ((DocumoVisitor<? extends T>)visitor).visitObjectField(this);
			else return visitor.visitChildren(this);
		}
	}

	public final ObjectFieldContext objectField() throws RecognitionException {
		ObjectFieldContext _localctx = new ObjectFieldContext(_ctx, getState());
		enterRule(_localctx, 20, RULE_objectField);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(76);
			match(WORD);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\16Q\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t\13\4"+
		"\f\t\f\3\2\6\2\32\n\2\r\2\16\2\33\3\2\3\2\3\3\3\3\3\3\3\3\3\3\3\3\3\3"+
		"\5\3\'\n\3\3\4\3\4\6\4+\n\4\r\4\16\4,\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\6"+
		"\3\6\3\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\b\3\b\3\b\3\b\3\b\3\t\3\t\5\tG"+
		"\n\t\3\n\3\n\3\n\3\n\3\13\3\13\3\f\3\f\3\f\2\2\r\2\4\6\b\n\f\16\20\22"+
		"\24\26\2\2\2K\2\31\3\2\2\2\4&\3\2\2\2\6(\3\2\2\2\b\60\3\2\2\2\n\65\3\2"+
		"\2\2\f:\3\2\2\2\16?\3\2\2\2\20F\3\2\2\2\22H\3\2\2\2\24L\3\2\2\2\26N\3"+
		"\2\2\2\30\32\5\4\3\2\31\30\3\2\2\2\32\33\3\2\2\2\33\31\3\2\2\2\33\34\3"+
		"\2\2\2\34\35\3\2\2\2\35\36\7\2\2\3\36\3\3\2\2\2\37 \7\5\2\2 !\5\20\t\2"+
		"!\"\7\6\2\2\"\'\3\2\2\2#\'\5\6\4\2$\'\5\b\5\2%\'\5\n\6\2&\37\3\2\2\2&"+
		"#\3\2\2\2&$\3\2\2\2&%\3\2\2\2\'\5\3\2\2\2(*\5\f\7\2)+\5\4\3\2*)\3\2\2"+
		"\2+,\3\2\2\2,*\3\2\2\2,-\3\2\2\2-.\3\2\2\2./\5\16\b\2/\7\3\2\2\2\60\61"+
		"\7\5\2\2\61\62\7\7\2\2\62\63\5\20\t\2\63\64\7\6\2\2\64\t\3\2\2\2\65\66"+
		"\7\5\2\2\66\67\7\13\2\2\678\5\20\t\289\7\6\2\29\13\3\2\2\2:;\7\5\2\2;"+
		"<\7\b\2\2<=\5\20\t\2=>\7\6\2\2>\r\3\2\2\2?@\7\5\2\2@A\7\t\2\2AB\5\20\t"+
		"\2BC\7\6\2\2C\17\3\2\2\2DG\5\22\n\2EG\5\24\13\2FD\3\2\2\2FE\3\2\2\2G\21"+
		"\3\2\2\2HI\5\24\13\2IJ\7\n\2\2JK\5\26\f\2K\23\3\2\2\2LM\7\3\2\2M\25\3"+
		"\2\2\2NO\7\3\2\2O\27\3\2\2\2\6\33&,F";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
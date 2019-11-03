// Generated from /home/angelica/Development/Documo/Documo/Documo.g4 by ANTLR 4.7.1
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
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		WORD=1, TEXT=2, WHITESPACE=3, STARTPLACEHOLDER=4, ENDPLACEHOLDER=5, STARTREPEATINGSECTION=6, 
		ENDREPEATINGSECTION=7, ACCESSOPERATOR=8;
	public static final int
		RULE_stmt = 0, RULE_placeholder = 1, RULE_repeatingSection = 2, RULE_startRepeatingSection = 3, 
		RULE_endRepeatingSection = 4, RULE_object = 5, RULE_objectFieldAccess = 6, 
		RULE_objectName = 7, RULE_objectField = 8;
	public static final String[] ruleNames = {
		"stmt", "placeholder", "repeatingSection", "startRepeatingSection", "endRepeatingSection", 
		"object", "objectFieldAccess", "objectName", "objectField"
	};

	private static final String[] _LITERAL_NAMES = {
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, "WORD", "TEXT", "WHITESPACE", "STARTPLACEHOLDER", "ENDPLACEHOLDER", 
		"STARTREPEATINGSECTION", "ENDREPEATINGSECTION", "ACCESSOPERATOR"
	};
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
	}

	public final StmtContext stmt() throws RecognitionException {
		StmtContext _localctx = new StmtContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_stmt);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(19); 
			_errHandler.sync(this);
			_la = _input.LA(1);
			do {
				{
				{
				setState(18);
				placeholder();
				}
				}
				setState(21); 
				_errHandler.sync(this);
				_la = _input.LA(1);
			} while ( _la==STARTPLACEHOLDER );
			setState(23);
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
		public PlaceholderContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_placeholder; }
	}

	public final PlaceholderContext placeholder() throws RecognitionException {
		PlaceholderContext _localctx = new PlaceholderContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_placeholder);
		try {
			setState(30);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,1,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(25);
				match(STARTPLACEHOLDER);
				setState(26);
				object();
				setState(27);
				match(ENDPLACEHOLDER);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(29);
				repeatingSection();
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
	}

	public final RepeatingSectionContext repeatingSection() throws RecognitionException {
		RepeatingSectionContext _localctx = new RepeatingSectionContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_repeatingSection);
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(32);
			startRepeatingSection();
			setState(34); 
			_errHandler.sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					setState(33);
					placeholder();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(36); 
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,2,_ctx);
			} while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER );
			setState(38);
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
	}

	public final StartRepeatingSectionContext startRepeatingSection() throws RecognitionException {
		StartRepeatingSectionContext _localctx = new StartRepeatingSectionContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_startRepeatingSection);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(40);
			match(STARTPLACEHOLDER);
			setState(41);
			match(STARTREPEATINGSECTION);
			setState(42);
			object();
			setState(43);
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
	}

	public final EndRepeatingSectionContext endRepeatingSection() throws RecognitionException {
		EndRepeatingSectionContext _localctx = new EndRepeatingSectionContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_endRepeatingSection);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(45);
			match(STARTPLACEHOLDER);
			setState(46);
			match(ENDREPEATINGSECTION);
			setState(47);
			object();
			setState(48);
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
	}

	public final ObjectContext object() throws RecognitionException {
		ObjectContext _localctx = new ObjectContext(_ctx, getState());
		enterRule(_localctx, 10, RULE_object);
		try {
			setState(52);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(50);
				objectFieldAccess();
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(51);
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
	}

	public final ObjectFieldAccessContext objectFieldAccess() throws RecognitionException {
		ObjectFieldAccessContext _localctx = new ObjectFieldAccessContext(_ctx, getState());
		enterRule(_localctx, 12, RULE_objectFieldAccess);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(54);
			objectName();
			setState(55);
			match(ACCESSOPERATOR);
			setState(56);
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
	}

	public final ObjectNameContext objectName() throws RecognitionException {
		ObjectNameContext _localctx = new ObjectNameContext(_ctx, getState());
		enterRule(_localctx, 14, RULE_objectName);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(58);
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
	}

	public final ObjectFieldContext objectField() throws RecognitionException {
		ObjectFieldContext _localctx = new ObjectFieldContext(_ctx, getState());
		enterRule(_localctx, 16, RULE_objectField);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(60);
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\nA\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\3\2\6\2\26"+
		"\n\2\r\2\16\2\27\3\2\3\2\3\3\3\3\3\3\3\3\3\3\5\3!\n\3\3\4\3\4\6\4%\n\4"+
		"\r\4\16\4&\3\4\3\4\3\5\3\5\3\5\3\5\3\5\3\6\3\6\3\6\3\6\3\6\3\7\3\7\5\7"+
		"\67\n\7\3\b\3\b\3\b\3\b\3\t\3\t\3\n\3\n\3\n\2\2\13\2\4\6\b\n\f\16\20\22"+
		"\2\2\2;\2\25\3\2\2\2\4 \3\2\2\2\6\"\3\2\2\2\b*\3\2\2\2\n/\3\2\2\2\f\66"+
		"\3\2\2\2\168\3\2\2\2\20<\3\2\2\2\22>\3\2\2\2\24\26\5\4\3\2\25\24\3\2\2"+
		"\2\26\27\3\2\2\2\27\25\3\2\2\2\27\30\3\2\2\2\30\31\3\2\2\2\31\32\7\2\2"+
		"\3\32\3\3\2\2\2\33\34\7\6\2\2\34\35\5\f\7\2\35\36\7\7\2\2\36!\3\2\2\2"+
		"\37!\5\6\4\2 \33\3\2\2\2 \37\3\2\2\2!\5\3\2\2\2\"$\5\b\5\2#%\5\4\3\2$"+
		"#\3\2\2\2%&\3\2\2\2&$\3\2\2\2&\'\3\2\2\2\'(\3\2\2\2()\5\n\6\2)\7\3\2\2"+
		"\2*+\7\6\2\2+,\7\b\2\2,-\5\f\7\2-.\7\7\2\2.\t\3\2\2\2/\60\7\6\2\2\60\61"+
		"\7\t\2\2\61\62\5\f\7\2\62\63\7\7\2\2\63\13\3\2\2\2\64\67\5\16\b\2\65\67"+
		"\5\20\t\2\66\64\3\2\2\2\66\65\3\2\2\2\67\r\3\2\2\289\5\20\t\29:\7\n\2"+
		"\2:;\5\22\n\2;\17\3\2\2\2<=\7\3\2\2=\21\3\2\2\2>?\7\3\2\2?\23\3\2\2\2"+
		"\6\27 &\66";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
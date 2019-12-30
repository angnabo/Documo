// Generated from /home/angelica/RiderProjects/Documo/Documo/DocumoLexer.g4 by ANTLR 4.7.2
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class DocumoLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.7.2", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		WORD=1, WHITESPACE=2, STARTPLACEHOLDER=3, ENDPLACEHOLDER=4, STARTREPEATINGSECTION=5, 
		ENDREPEATINGSECTION=6, ACCESSOPERATOR=7, RBRAKET=8, LBRAKET=9, QUOTATION=10, 
		MAYBEWORD=11;
	public static final int
		text=1;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE", "text"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"A", "S", "Y", "LOWERCASE", "UPPERCASE", "DIGIT", "ANY", "WORD", "WHITESPACE", 
			"STARTPLACEHOLDER", "ENDPLACEHOLDER", "STARTREPEATINGSECTION", "ENDREPEATINGSECTION", 
			"ACCESSOPERATOR", "RBRAKET", "LBRAKET", "QUOTATION", "MAYBEWORD"
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
			null, "WORD", "WHITESPACE", "STARTPLACEHOLDER", "ENDPLACEHOLDER", "STARTREPEATINGSECTION", 
			"ENDREPEATINGSECTION", "ACCESSOPERATOR", "RBRAKET", "LBRAKET", "QUOTATION", 
			"MAYBEWORD"
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


	public DocumoLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "DocumoLexer.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\r\u009e\b\1\b\1\4"+
		"\2\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n"+
		"\4\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\3\2\3\2\3\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\7\3\7\3\b\3"+
		"\b\3\t\3\t\3\t\6\t:\n\t\r\t\16\t;\3\n\6\n?\n\n\r\n\16\n@\3\n\3\n\3\13"+
		"\6\13F\n\13\r\13\16\13G\3\13\6\13K\n\13\r\13\16\13L\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\f\3\f\6\fz\n\f\r\f\16"+
		"\f{\3\f\6\f\177\n\f\r\f\16\f\u0080\3\f\3\f\3\r\3\r\3\r\3\r\3\16\3\16\3"+
		"\16\3\16\3\17\3\17\3\20\3\20\3\21\3\21\3\21\3\21\3\22\3\22\3\23\3\23\6"+
		"\23\u0099\n\23\r\23\16\23\u009a\3\23\3\23\2\2\24\4\2\6\2\b\2\n\2\f\2\16"+
		"\2\20\2\22\3\24\4\26\5\30\6\32\7\34\b\36\t \n\"\13$\f&\r\4\2\3\n\4\2C"+
		"Ccc\4\2UUuu\4\2[[{{\3\2c|\3\2C\\\3\2\62;\5\2\62;C\\c|\4\2\13\13\"\"\2"+
		"\u009f\2\22\3\2\2\2\2\24\3\2\2\2\2\26\3\2\2\2\2\30\3\2\2\2\2\32\3\2\2"+
		"\2\2\34\3\2\2\2\2\36\3\2\2\2\2 \3\2\2\2\2\"\3\2\2\2\2$\3\2\2\2\3&\3\2"+
		"\2\2\4(\3\2\2\2\6*\3\2\2\2\b,\3\2\2\2\n.\3\2\2\2\f\60\3\2\2\2\16\62\3"+
		"\2\2\2\20\64\3\2\2\2\229\3\2\2\2\24>\3\2\2\2\26E\3\2\2\2\30y\3\2\2\2\32"+
		"\u0084\3\2\2\2\34\u0088\3\2\2\2\36\u008c\3\2\2\2 \u008e\3\2\2\2\"\u0090"+
		"\3\2\2\2$\u0094\3\2\2\2&\u0098\3\2\2\2()\t\2\2\2)\5\3\2\2\2*+\t\3\2\2"+
		"+\7\3\2\2\2,-\t\4\2\2-\t\3\2\2\2./\t\5\2\2/\13\3\2\2\2\60\61\t\6\2\2\61"+
		"\r\3\2\2\2\62\63\t\7\2\2\63\17\3\2\2\2\64\65\t\b\2\2\65\21\3\2\2\2\66"+
		":\5\n\5\2\67:\5\f\6\28:\5\16\7\29\66\3\2\2\29\67\3\2\2\298\3\2\2\2:;\3"+
		"\2\2\2;9\3\2\2\2;<\3\2\2\2<\23\3\2\2\2=?\t\t\2\2>=\3\2\2\2?@\3\2\2\2@"+
		">\3\2\2\2@A\3\2\2\2AB\3\2\2\2BC\b\n\2\2C\25\3\2\2\2DF\7>\2\2ED\3\2\2\2"+
		"FG\3\2\2\2GE\3\2\2\2GH\3\2\2\2HJ\3\2\2\2IK\5\22\t\2JI\3\2\2\2KL\3\2\2"+
		"\2LJ\3\2\2\2LM\3\2\2\2MN\3\2\2\2NO\7\"\2\2OP\7e\2\2PQ\7n\2\2QR\7c\2\2"+
		"RS\7u\2\2ST\7u\2\2TU\7?\2\2UV\7$\2\2VW\7r\2\2WX\7n\2\2XY\7c\2\2YZ\7e\2"+
		"\2Z[\7g\2\2[\\\7j\2\2\\]\7q\2\2]^\7n\2\2^_\7f\2\2_`\7g\2\2`a\7t\2\2ab"+
		"\7$\2\2bc\7\"\2\2cd\7f\2\2de\7c\2\2ef\7v\2\2fg\7c\2\2gh\7/\2\2hi\7r\2"+
		"\2ij\7n\2\2jk\7c\2\2kl\7e\2\2lm\7g\2\2mn\7j\2\2no\7q\2\2op\7n\2\2pq\7"+
		"f\2\2qr\7g\2\2rs\7t\2\2st\7?\2\2tu\3\2\2\2uv\b\13\3\2v\27\3\2\2\2wx\7"+
		">\2\2xz\7\61\2\2yw\3\2\2\2z{\3\2\2\2{y\3\2\2\2{|\3\2\2\2|~\3\2\2\2}\177"+
		"\5\22\t\2~}\3\2\2\2\177\u0080\3\2\2\2\u0080~\3\2\2\2\u0080\u0081\3\2\2"+
		"\2\u0081\u0082\3\2\2\2\u0082\u0083\7@\2\2\u0083\31\3\2\2\2\u0084\u0085"+
		"\7t\2\2\u0085\u0086\7u\2\2\u0086\u0087\7a\2\2\u0087\33\3\2\2\2\u0088\u0089"+
		"\7g\2\2\u0089\u008a\7u\2\2\u008a\u008b\7a\2\2\u008b\35\3\2\2\2\u008c\u008d"+
		"\7\60\2\2\u008d\37\3\2\2\2\u008e\u008f\7>\2\2\u008f!\3\2\2\2\u0090\u0091"+
		"\7@\2\2\u0091\u0092\3\2\2\2\u0092\u0093\b\21\4\2\u0093#\3\2\2\2\u0094"+
		"\u0095\7$\2\2\u0095%\3\2\2\2\u0096\u0099\5\20\b\2\u0097\u0099\7\60\2\2"+
		"\u0098\u0096\3\2\2\2\u0098\u0097\3\2\2\2\u0099\u009a\3\2\2\2\u009a\u0098"+
		"\3\2\2\2\u009a\u009b\3\2\2\2\u009b\u009c\3\2\2\2\u009c\u009d\b\23\2\2"+
		"\u009d\'\3\2\2\2\r\2\39;@GL{\u0080\u0098\u009a\5\b\2\2\6\2\2\7\3\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
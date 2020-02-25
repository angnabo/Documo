// Generated from /home/angelica/RiderProjects/Documo/Documo/Grammar/Documo.g4 by ANTLR 4.8
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
	static { RuntimeMetaData.checkVersion("4.8", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		WORD=1, WHITESPACE=2, STARTPLACEHOLDER=3, ENDPLACEHOLDER=4, IMAGEPLACEHOLDER=5, 
		STARTREPEATINGSECTION=6, ENDREPEATINGSECTION=7, ACCESSOPERATOR=8, IF=9, 
		OPERATOR=10, EQUALSOPERATOR=11, NOTEQUALSOPERATOR=12;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	private static String[] makeRuleNames() {
		return new String[] {
			"LOWERCASE", "UPPERCASE", "DIGIT", "ANY", "WORD", "WHITESPACE", "STARTPLACEHOLDER", 
			"ENDPLACEHOLDER", "IMAGEPLACEHOLDER", "STARTREPEATINGSECTION", "ENDREPEATINGSECTION", 
			"ACCESSOPERATOR", "IF", "OPERATOR", "EQUALSOPERATOR", "NOTEQUALSOPERATOR"
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


	public DocumoLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Documo.g4"; }

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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\16[\b\1\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\3\2\3\2\3"+
		"\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\6\6\6/\n\6\r\6\16\6\60\3\7\6\7\64\n\7"+
		"\r\7\16\7\65\3\7\3\7\3\b\3\b\3\b\3\t\3\t\3\t\3\n\3\n\3\n\3\n\3\n\3\13"+
		"\3\13\3\13\3\13\3\f\3\f\3\f\3\f\3\r\3\r\3\16\3\16\3\16\3\17\3\17\5\17"+
		"T\n\17\3\20\3\20\3\20\3\21\3\21\3\21\2\2\22\3\2\5\2\7\2\t\2\13\3\r\4\17"+
		"\5\21\6\23\7\25\b\27\t\31\n\33\13\35\f\37\r!\16\3\2\7\3\2c|\3\2C\\\3\2"+
		"\62;\5\2\62;C\\c|\4\2\13\13\"\"\2[\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2"+
		"\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2"+
		"\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2\2\2\2!\3\2\2\2\3#\3\2\2\2\5%\3\2\2\2"+
		"\7\'\3\2\2\2\t)\3\2\2\2\13.\3\2\2\2\r\63\3\2\2\2\179\3\2\2\2\21<\3\2\2"+
		"\2\23?\3\2\2\2\25D\3\2\2\2\27H\3\2\2\2\31L\3\2\2\2\33N\3\2\2\2\35S\3\2"+
		"\2\2\37U\3\2\2\2!X\3\2\2\2#$\t\2\2\2$\4\3\2\2\2%&\t\3\2\2&\6\3\2\2\2\'"+
		"(\t\4\2\2(\b\3\2\2\2)*\t\5\2\2*\n\3\2\2\2+/\5\3\2\2,/\5\5\3\2-/\5\7\4"+
		"\2.+\3\2\2\2.,\3\2\2\2.-\3\2\2\2/\60\3\2\2\2\60.\3\2\2\2\60\61\3\2\2\2"+
		"\61\f\3\2\2\2\62\64\t\6\2\2\63\62\3\2\2\2\64\65\3\2\2\2\65\63\3\2\2\2"+
		"\65\66\3\2\2\2\66\67\3\2\2\2\678\b\7\2\28\16\3\2\2\29:\7}\2\2:;\7}\2\2"+
		";\20\3\2\2\2<=\7\177\2\2=>\7\177\2\2>\22\3\2\2\2?@\7k\2\2@A\7o\2\2AB\7"+
		"i\2\2BC\7a\2\2C\24\3\2\2\2DE\7t\2\2EF\7u\2\2FG\7a\2\2G\26\3\2\2\2HI\7"+
		"g\2\2IJ\7u\2\2JK\7a\2\2K\30\3\2\2\2LM\7\60\2\2M\32\3\2\2\2NO\7k\2\2OP"+
		"\7h\2\2P\34\3\2\2\2QT\5\37\20\2RT\5!\21\2SQ\3\2\2\2SR\3\2\2\2T\36\3\2"+
		"\2\2UV\7?\2\2VW\7?\2\2W \3\2\2\2XY\7#\2\2YZ\7?\2\2Z\"\3\2\2\2\7\2.\60"+
		"\65S\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
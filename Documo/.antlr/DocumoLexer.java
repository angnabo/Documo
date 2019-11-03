// Generated from /home/angelica/Development/Documo/Documo/Documo.g4 by ANTLR 4.7.1
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
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		WORD=1, TEXT=2, WHITESPACE=3, STARTPLACEHOLDER=4, ENDPLACEHOLDER=5, STARTREPEATINGSECTION=6, 
		ENDREPEATINGSECTION=7, ACCESSOPERATOR=8;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] ruleNames = {
		"A", "S", "Y", "LOWERCASE", "UPPERCASE", "DIGIT", "WORD", "TEXT", "WHITESPACE", 
		"STARTPLACEHOLDER", "ENDPLACEHOLDER", "STARTREPEATINGSECTION", "ENDREPEATINGSECTION", 
		"ACCESSOPERATOR"
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
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\ni\b\1\4\2\t\2\4"+
		"\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4\13\t"+
		"\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\3\2\3\2\3\3\3\3\3\4\3\4\3\5\3"+
		"\5\3\6\3\6\3\7\3\7\3\b\3\b\3\b\6\b/\n\b\r\b\16\b\60\3\t\3\t\7\t\65\n\t"+
		"\f\t\16\t8\13\t\3\t\3\t\3\n\6\n=\n\n\r\n\16\n>\3\n\3\n\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\13"+
		"\3\13\3\13\3\13\3\13\3\13\3\13\3\13\3\f\3\f\3\f\3\f\3\f\3\r\3\r\3\r\3"+
		"\r\3\16\3\16\3\16\3\16\3\17\3\17\3\66\2\20\3\2\5\2\7\2\t\2\13\2\r\2\17"+
		"\3\21\4\23\5\25\6\27\7\31\b\33\t\35\n\3\2\t\4\2CCcc\4\2UUuu\4\2[[{{\3"+
		"\2c|\3\2C\\\3\2\62;\4\2\13\13\"\"\2g\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3"+
		"\2\2\2\2\25\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2"+
		"\2\3\37\3\2\2\2\5!\3\2\2\2\7#\3\2\2\2\t%\3\2\2\2\13\'\3\2\2\2\r)\3\2\2"+
		"\2\17.\3\2\2\2\21\62\3\2\2\2\23<\3\2\2\2\25B\3\2\2\2\27Z\3\2\2\2\31_\3"+
		"\2\2\2\33c\3\2\2\2\35g\3\2\2\2\37 \t\2\2\2 \4\3\2\2\2!\"\t\3\2\2\"\6\3"+
		"\2\2\2#$\t\4\2\2$\b\3\2\2\2%&\t\5\2\2&\n\3\2\2\2\'(\t\6\2\2(\f\3\2\2\2"+
		")*\t\7\2\2*\16\3\2\2\2+/\5\t\5\2,/\5\13\6\2-/\5\r\7\2.+\3\2\2\2.,\3\2"+
		"\2\2.-\3\2\2\2/\60\3\2\2\2\60.\3\2\2\2\60\61\3\2\2\2\61\20\3\2\2\2\62"+
		"\66\7$\2\2\63\65\13\2\2\2\64\63\3\2\2\2\658\3\2\2\2\66\67\3\2\2\2\66\64"+
		"\3\2\2\2\679\3\2\2\28\66\3\2\2\29:\7$\2\2:\22\3\2\2\2;=\t\b\2\2<;\3\2"+
		"\2\2=>\3\2\2\2><\3\2\2\2>?\3\2\2\2?@\3\2\2\2@A\b\n\2\2A\24\3\2\2\2BC\7"+
		">\2\2CD\7r\2\2DE\7\"\2\2EF\7e\2\2FG\7n\2\2GH\7c\2\2HI\7u\2\2IJ\7u\2\2"+
		"JK\7?\2\2KL\7$\2\2LM\7r\2\2MN\7n\2\2NO\7c\2\2OP\7e\2\2PQ\7g\2\2QR\7j\2"+
		"\2RS\7q\2\2ST\7n\2\2TU\7f\2\2UV\7g\2\2VW\7t\2\2WX\7$\2\2XY\7@\2\2Y\26"+
		"\3\2\2\2Z[\7>\2\2[\\\7\61\2\2\\]\7r\2\2]^\7@\2\2^\30\3\2\2\2_`\7t\2\2"+
		"`a\7u\2\2ab\7a\2\2b\32\3\2\2\2cd\7g\2\2de\7u\2\2ef\7a\2\2f\34\3\2\2\2"+
		"gh\7\60\2\2h\36\3\2\2\2\7\2.\60\66>\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}
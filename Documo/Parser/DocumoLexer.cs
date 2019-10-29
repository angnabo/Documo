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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class DocumoLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		WORD=1, TEXT=2, WHITESPACE=3, STARTPLACEHOLDER=4, ENDPLACEHOLDER=5, STARTREPEATINGSECTION=6, 
		ENDREPEATINGSECTION=7, ACCESSOPERATOR=8;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"A", "S", "Y", "LOWERCASE", "UPPERCASE", "DIGIT", "WORD", "TEXT", "WHITESPACE", 
		"STARTPLACEHOLDER", "ENDPLACEHOLDER", "STARTREPEATINGSECTION", "ENDREPEATINGSECTION", 
		"ACCESSOPERATOR"
	};


	public DocumoLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public DocumoLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static DocumoLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\n', 'i', '\b', '\x1', '\x4', '\x2', '\t', '\x2', '\x4', 
		'\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', 
		'\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', '\t', 
		'\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', '\t', 
		'\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x6', '\b', '/', '\n', '\b', '\r', '\b', '\xE', 
		'\b', '\x30', '\x3', '\t', '\x3', '\t', '\a', '\t', '\x35', '\n', '\t', 
		'\f', '\t', '\xE', '\t', '\x38', '\v', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\n', '\x6', '\n', '=', '\n', '\n', '\r', '\n', '\xE', '\n', '>', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', 
		'\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\x36', '\x2', '\x10', '\x3', 
		'\x2', '\x5', '\x2', '\a', '\x2', '\t', '\x2', '\v', '\x2', '\r', '\x2', 
		'\xF', '\x3', '\x11', '\x4', '\x13', '\x5', '\x15', '\x6', '\x17', '\a', 
		'\x19', '\b', '\x1B', '\t', '\x1D', '\n', '\x3', '\x2', '\t', '\x4', '\x2', 
		'\x43', '\x43', '\x63', '\x63', '\x4', '\x2', 'U', 'U', 'u', 'u', '\x4', 
		'\x2', '[', '[', '{', '{', '\x3', '\x2', '\x63', '|', '\x3', '\x2', '\x43', 
		'\\', '\x3', '\x2', '\x32', ';', '\x4', '\x2', '\v', '\v', '\"', '\"', 
		'\x2', 'g', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x3', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x5', '!', '\x3', '\x2', '\x2', '\x2', 
		'\a', '#', '\x3', '\x2', '\x2', '\x2', '\t', '%', '\x3', '\x2', '\x2', 
		'\x2', '\v', '\'', '\x3', '\x2', '\x2', '\x2', '\r', ')', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '.', '\x3', '\x2', '\x2', '\x2', '\x11', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '<', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x42', '\x3', '\x2', '\x2', '\x2', '\x17', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '\x19', '_', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x63', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', 'g', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		' ', '\t', '\x2', '\x2', '\x2', ' ', '\x4', '\x3', '\x2', '\x2', '\x2', 
		'!', '\"', '\t', '\x3', '\x2', '\x2', '\"', '\x6', '\x3', '\x2', '\x2', 
		'\x2', '#', '$', '\t', '\x4', '\x2', '\x2', '$', '\b', '\x3', '\x2', '\x2', 
		'\x2', '%', '&', '\t', '\x5', '\x2', '\x2', '&', '\n', '\x3', '\x2', '\x2', 
		'\x2', '\'', '(', '\t', '\x6', '\x2', '\x2', '(', '\f', '\x3', '\x2', 
		'\x2', '\x2', ')', '*', '\t', '\a', '\x2', '\x2', '*', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '+', '/', '\x5', '\t', '\x5', '\x2', ',', '/', '\x5', '\v', 
		'\x6', '\x2', '-', '/', '\x5', '\r', '\a', '\x2', '.', '+', '\x3', '\x2', 
		'\x2', '\x2', '.', ',', '\x3', '\x2', '\x2', '\x2', '.', '-', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x30', '\x3', '\x2', '\x2', '\x2', '\x30', '.', '\x3', 
		'\x2', '\x2', '\x2', '\x30', '\x31', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x10', '\x3', '\x2', '\x2', '\x2', '\x32', '\x36', '\a', '$', '\x2', 
		'\x2', '\x33', '\x35', '\v', '\x2', '\x2', '\x2', '\x34', '\x33', '\x3', 
		'\x2', '\x2', '\x2', '\x35', '\x38', '\x3', '\x2', '\x2', '\x2', '\x36', 
		'\x37', '\x3', '\x2', '\x2', '\x2', '\x36', '\x34', '\x3', '\x2', '\x2', 
		'\x2', '\x37', '\x39', '\x3', '\x2', '\x2', '\x2', '\x38', '\x36', '\x3', 
		'\x2', '\x2', '\x2', '\x39', ':', '\a', '$', '\x2', '\x2', ':', '\x12', 
		'\x3', '\x2', '\x2', '\x2', ';', '=', '\t', '\b', '\x2', '\x2', '<', ';', 
		'\x3', '\x2', '\x2', '\x2', '=', '>', '\x3', '\x2', '\x2', '\x2', '>', 
		'<', '\x3', '\x2', '\x2', '\x2', '>', '?', '\x3', '\x2', '\x2', '\x2', 
		'?', '@', '\x3', '\x2', '\x2', '\x2', '@', '\x41', '\b', '\n', '\x2', 
		'\x2', '\x41', '\x14', '\x3', '\x2', '\x2', '\x2', '\x42', '\x43', '\a', 
		'>', '\x2', '\x2', '\x43', '\x44', '\a', 'r', '\x2', '\x2', '\x44', '\x45', 
		'\a', '\"', '\x2', '\x2', '\x45', '\x46', '\a', '\x65', '\x2', '\x2', 
		'\x46', 'G', '\a', 'n', '\x2', '\x2', 'G', 'H', '\a', '\x63', '\x2', '\x2', 
		'H', 'I', '\a', 'u', '\x2', '\x2', 'I', 'J', '\a', 'u', '\x2', '\x2', 
		'J', 'K', '\a', '?', '\x2', '\x2', 'K', 'L', '\a', '$', '\x2', '\x2', 
		'L', 'M', '\a', 'r', '\x2', '\x2', 'M', 'N', '\a', 'n', '\x2', '\x2', 
		'N', 'O', '\a', '\x63', '\x2', '\x2', 'O', 'P', '\a', '\x65', '\x2', '\x2', 
		'P', 'Q', '\a', 'g', '\x2', '\x2', 'Q', 'R', '\a', 'j', '\x2', '\x2', 
		'R', 'S', '\a', 'q', '\x2', '\x2', 'S', 'T', '\a', 'n', '\x2', '\x2', 
		'T', 'U', '\a', '\x66', '\x2', '\x2', 'U', 'V', '\a', 'g', '\x2', '\x2', 
		'V', 'W', '\a', 't', '\x2', '\x2', 'W', 'X', '\a', '$', '\x2', '\x2', 
		'X', 'Y', '\a', '@', '\x2', '\x2', 'Y', '\x16', '\x3', '\x2', '\x2', '\x2', 
		'Z', '[', '\a', '>', '\x2', '\x2', '[', '\\', '\a', '\x31', '\x2', '\x2', 
		'\\', ']', '\a', 'r', '\x2', '\x2', ']', '^', '\a', '@', '\x2', '\x2', 
		'^', '\x18', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', 't', '\x2', '\x2', 
		'`', '\x61', '\a', 'u', '\x2', '\x2', '\x61', '\x62', '\a', '\x61', '\x2', 
		'\x2', '\x62', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\a', 
		'g', '\x2', '\x2', '\x64', '\x65', '\a', 'u', '\x2', '\x2', '\x65', '\x66', 
		'\a', '\x61', '\x2', '\x2', '\x66', '\x1C', '\x3', '\x2', '\x2', '\x2', 
		'g', 'h', '\a', '\x30', '\x2', '\x2', 'h', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\a', '\x2', '.', '\x30', '\x36', '>', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}

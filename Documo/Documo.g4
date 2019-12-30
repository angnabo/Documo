grammar Documo;

/*
 * Parser Rules
 */
stmt                : placeholder + EOF;
placeholder         : STARTPLACEHOLDER QUOTATION object QUOTATION LBRAKET ENDPLACEHOLDER | repeatingSection;
repeatingSection    : startRepeatingSection placeholder+ endRepeatingSection ;
startRepeatingSection : STARTPLACEHOLDER QUOTATION STARTREPEATINGSECTION object QUOTATION LBRAKET ENDPLACEHOLDER;
endRepeatingSection : STARTPLACEHOLDER QUOTATION ENDREPEATINGSECTION object QUOTATION LBRAKET ENDPLACEHOLDER;
object              : objectFieldAccess | objectName;
objectFieldAccess   : objectName ACCESSOPERATOR objectField;
objectName          : WORD ;
objectField         : WORD ;

/*
 * Lexer Rules
 */
fragment LOWERCASE  : [a-z] ;
fragment UPPERCASE  : [A-Z] ;
fragment DIGIT      : [0-9] ;
fragment ANY        : [0-9a-zA-Z] ;
WORD                : (LOWERCASE | UPPERCASE | DIGIT)+ ;
WHITESPACE          : (' '|'\t')+ -> skip ;
STARTPLACEHOLDER    : ('<'+WORD+' class="placeholder" data-placeholder=');
ENDPLACEHOLDER      : ('</'+WORD+'>'); 
STARTREPEATINGSECTION    : ('rs_');
ENDREPEATINGSECTION      : ('es_'); 
ACCESSOPERATOR      : ('.'); 
RBRAKET             : ('<'); 
LBRAKET             : ('>'); 
QUOTATION           : ('"');
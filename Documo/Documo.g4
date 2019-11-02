grammar Documo;
/*
 * Parser Rules
 */
stmt                : placeholder+ EOF;
placeholder         : STARTPLACEHOLDER object ENDPLACEHOLDER | repeatingSection ;
repeatingSection    : startRepeatingSection placeholder+ endRepeatingSection;
startRepeatingSection : STARTPLACEHOLDER STARTREPEATINGSECTION object ENDPLACEHOLDER;
endRepeatingSection : STARTPLACEHOLDER ENDREPEATINGSECTION object ENDPLACEHOLDER;
object              : objectFieldAccess | objectName;
objectFieldAccess   : objectName ACCESSOPERATOR objectField;
objectName          : WORD ;
objectField         : WORD ;


/*
 * Lexer Rules
 */
fragment A          : ('A'|'a') ;
fragment S          : ('S'|'s') ;
fragment Y          : ('Y'|'y') ;
fragment LOWERCASE  : [a-z] ;
fragment UPPERCASE  : [A-Z] ;
fragment DIGIT      : [0-9] ;
WORD                : (LOWERCASE | UPPERCASE | DIGIT)+ ;
TEXT                : '"' .*? '"' ;
WHITESPACE          : (' '|'\t')+ -> skip ;
STARTPLACEHOLDER    : ('<p class="placeholder">');
ENDPLACEHOLDER      : ('</p>'); 
STARTREPEATINGSECTION    : ('rs_');
ENDREPEATINGSECTION      : ('es_'); 
ACCESSOPERATOR      : ('.'); 
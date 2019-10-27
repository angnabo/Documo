grammar DocRend;
/*
 * Parser Rules
 */
stmt                : placeholder EOF ;
placeholder         : STARTPLACEHOLDER expr ENDPLACEHOLDER ;
expr                : object ACCESSOPERATOR object ;
object              : WORD ;
/*
 * Lexer Rules
 */
fragment A          : ('A'|'a') ;
fragment S          : ('S'|'s') ;
fragment Y          : ('Y'|'y') ;
fragment LOWERCASE  : [a-z] ;
fragment UPPERCASE  : [A-Z] ;
WORD                : (LOWERCASE | UPPERCASE)+ ;
TEXT                : '"' .*? '"' ;
WHITESPACE          : (' '|'\t')+ -> skip ;
STARTPLACEHOLDER    : ('<<');
ENDPLACEHOLDER      : ('>>'); 
ACCESSOPERATOR      : ('.'); 
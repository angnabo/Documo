grammar Documo;

/*
 * Parser Rules
 */
stmt                : placeholder + EOF;
placeholder         : STARTPLACEHOLDER object  ENDPLACEHOLDER | repeatingSection | imagePlaceholder;
repeatingSection    : startRepeatingSection placeholder+ endRepeatingSection;
imagePlaceholder    : STARTPLACEHOLDER IMAGEPLACEHOLDER object ENDPLACEHOLDER;
startRepeatingSection : STARTPLACEHOLDER STARTREPEATINGSECTION object ENDPLACEHOLDER;
endRepeatingSection : STARTPLACEHOLDER ENDREPEATINGSECTION object ENDPLACEHOLDER;
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
STARTPLACEHOLDER    : ('{{');
ENDPLACEHOLDER      : ('}}');
IMAGEPLACEHOLDER    : ('img_');
STARTREPEATINGSECTION    : ('rs_');
ENDREPEATINGSECTION      : ('es_'); 
ACCESSOPERATOR      : ('.'); 
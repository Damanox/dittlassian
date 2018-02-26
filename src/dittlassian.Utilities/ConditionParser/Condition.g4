grammar Condition;

parse
 : expression EOF
 ;

expression
 : LPAREN expression RPAREN                       #parenExpression
 | NOT expression                                 #notExpression
 | left=expression op=comparator right=expression #comparatorExpression
 | left=expression op=binary right=expression     #binaryExpression
 | bool                                           #boolExpression
 | IDENTIFIER                                     #identifierExpression
 | DECIMAL                                        #decimalExpression
 | STRING                                         #stringExpression
 ;

comparator
 : GT | GE | LT | LE | EQ | NEQ
 ;

binary
 : AND | OR
 ;

bool
 : TRUE | FALSE
 ;
 
STRING
 : '\'' (~[\r\n"])* '\''
 ;
 
AND        : '&&' ;
OR         : '||' ;
NOT        : '!';
TRUE       : 'true' ;
FALSE      : 'false' ;
GT         : '>' ;
GE         : '>=' ;
LT         : '<' ;
LE         : '<=' ;
EQ         : '==' ;
NEQ        : '!=' ;
LPAREN     : '(' ;
RPAREN     : ')' ;
DECIMAL    : '-'? [0-9]+ ( '.' [0-9]+ )? ;
IDENTIFIER : [a-zA-Z_.] [a-zA-Z_0-9.]* ;
WS         : [ \r\t\u000C\n]+ -> skip;
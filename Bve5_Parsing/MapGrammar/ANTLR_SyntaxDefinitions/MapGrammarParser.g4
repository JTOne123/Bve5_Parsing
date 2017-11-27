parser grammar MapGrammarParser;
options{
	tokenVocab=MapGrammarLexer;
}

root :
	statement* EOF
	;

statement :
	  distance								#distState
	| CURVE curve							#curveState
	| varAssign								#varAssignState
	;

//������
distance :
	expr END
	;

//�Ȑ�
curve :
	DOT func1=BEGIN OPN_PAR radius=nullableExpr (COMMA cant=nullableExpr)? CLS_PAR END
	;

//�ϐ�/����
varAssign :
	v=var EQUAL expr END;

nullableExpr :
	expr
	| /* epsilon */
	;

expr :
	  OPN_PAR expr CLS_PAR							#parensExpr
	| op=(PLUS | MINUS) expr						#unaryExpr
	| left=expr op=(MULT | DIV) right=expr			#infixExpr
	| left=expr op=(PLUS | MINUS | MOD) right=expr	#infixExpr
	| v=var											#varExpr
	| num=NUM										#numberExpr
	| str=string									#stringExpr
	;

var returns [string varName]:
	VAR_START v=VAR { $varName = $v.text ;}
	;

string returns [string text]:
	QUOTE v=string_text RQUOTE { $text = $v.text ;}
	;

string_text :
	CHAR*
	;
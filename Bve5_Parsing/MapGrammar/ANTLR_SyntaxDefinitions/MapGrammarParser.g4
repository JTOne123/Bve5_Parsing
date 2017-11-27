parser grammar MapGrammarParser;
options{
	tokenVocab=MapGrammarLexer;
}

root :
	(statement STATE_END)* EOF
	;

statement :
	  distance								#distState
	| CURVE curve							#curveState
	| GRADIENT gradient						#gradientState
	| varAssign								#varAssignState
	;

//距離程
distance :
	expr
	;

//平面曲線
curve :
	  DOT func=SET_GAUGE OPN_PAR value=nullableExpr CLS_PAR
	| DOT func=SET_CENTER OPN_PAR x=nullableExpr CLS_PAR
	| DOT func=SET_FUNCTION OPN_PAR id=nullableExpr CLS_PAR
	| DOT func=BEGIN_TRANSITION OPN_PAR CLS_PAR
	| DOT func=BEGIN OPN_PAR radius=nullableExpr (COMMA cant=nullableExpr)? CLS_PAR
	| DOT func=END OPN_PAR CLS_PAR
	| DOT func=INTERPOLATE OPN_PAR CLS_PAR
	| DOT func=INTERPOLATE OPN_PAR radiusE=expr CLS_PAR
	| DOT func=INTERPOLATE OPN_PAR radius=nullableExpr COMMA cant=nullableExpr CLS_PAR
	| DOT func=CHANGE OPN_PAR radius=nullableExpr CLS_PAR
	;

//縦曲線
gradient :
	  DOT func=BEGIN_TRANSITION OPN_PAR CLS_PAR
	| DOT func=BEGIN OPN_PAR gradientArgs=nullableExpr CLS_PAR	//引数名gradientが被るのでgradientArgsにしている
	| DOT func=END OPN_PAR CLS_PAR
	| DOT func=INTERPOLATE OPN_PAR gradientArgsE=expr CLS_PAR
	;

//変数/数式
varAssign :
	v=var EQUAL expr;

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
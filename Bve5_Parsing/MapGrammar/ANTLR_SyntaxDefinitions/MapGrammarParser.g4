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
	| TRACK track							#trackState
	| STRUCTURE structure					#structureState
	| REPEATER repeater						#repeaterState
	| varAssign								#varAssignState
	;

//������
distance :
	expr
	;

//���ʋȐ�
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

//�c�Ȑ�
gradient :
	  DOT func=BEGIN_TRANSITION OPN_PAR CLS_PAR
	| DOT func=BEGIN OPN_PAR gradientArgs=nullableExpr CLS_PAR	//������gradient�����̂�gradientArgs�ɂ��Ă���
	| DOT func=END OPN_PAR CLS_PAR
	| DOT func=INTERPOLATE OPN_PAR gradientArgsE=expr CLS_PAR
	;

//���O��
track :
	  OPN_BRA key=expr CLS_BRA DOT element=X_ELEMENT DOT func=INTERPOLATE OPN_PAR CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=X_ELEMENT DOT func=INTERPOLATE OPN_PAR xE=expr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=X_ELEMENT DOT func=INTERPOLATE OPN_PAR x=nullableExpr COMMA radius=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=Y_ELEMENT DOT func=INTERPOLATE OPN_PAR CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=Y_ELEMENT DOT func=INTERPOLATE OPN_PAR xE=expr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=Y_ELEMENT DOT func=INTERPOLATE OPN_PAR x=nullableExpr COMMA radius=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=POSITION OPN_PAR x=nullableExpr COMMA y=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=POSITION OPN_PAR x=nullableExpr COMMA y=nullableExpr COMMA radiusH=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=POSITION OPN_PAR x=nullableExpr COMMA y=nullableExpr COMMA radiusH=nullableExpr COMMA radiusV=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=CANT_ELEMENT DOT func=SET_CENTER OPN_PAR x=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=CANT_ELEMENT DOT func=SET_GAUGE OPN_PAR gauge=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=CANT_ELEMENT DOT func=SET_FUNCTION OPN_PAR id=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=CANT_ELEMENT DOT func=BEGIN_TRANSITION OPN_PAR CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=CANT_ELEMENT DOT func=BEGIN OPN_PAR cant=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=CANT_ELEMENT DOT func=END OPN_PAR CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT element=CANT_ELEMENT DOT func=INTERPOLATE OPN_PAR cantE=expr? CLS_PAR
	;

//�X�g���N�`��
structure :
	  DOT func=LOAD OPN_PAR path=string CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PUT OPN_PAR trackkey=nullableExpr COMMA x=nullableExpr COMMA y=nullableExpr COMMA z=nullableExpr COMMA rx=nullableExpr COMMA ry=nullableExpr COMMA rz=nullableExpr COMMA tilt=nullableExpr COMMA span=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PUT0 OPN_PAR trackkey=nullableExpr COMMA tilt=nullableExpr COMMA span=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PUTBETWEEN OPN_PAR trackkey1=nullableExpr COMMA trackkey2=nullableExpr ( COMMA flag=nullableExpr )? CLS_PAR
	;

//�A���X�g���N�`��
repeater :
	OPN_BRA key=expr CLS_BRA DOT func=BEGIN OPN_PAR trackkey=nullableExpr COMMA x=nullableExpr COMMA y=nullableExpr COMMA z=nullableExpr COMMA rx=nullableExpr COMMA ry=nullableExpr COMMA rz=nullableExpr COMMA tilt=nullableExpr COMMA span=nullableExpr COMMA interval=nullableExpr strkey+ CLS_PAR
	;

//�A���X�g���N�`���̃X�g���N�`�����X�g
strkey :
	COMMA key=string;

//�ϐ�/����
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
	| dist=DISTANCE									#distanceExpr
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
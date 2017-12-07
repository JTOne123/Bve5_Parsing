/*
 *	MapGrammar��ANTLR�\����`�t�@�C���ł��B
 */
parser grammar MapGrammarParser;
options{
	tokenVocab=MapGrammarLexer;
}

root :
	BVETS MAP version=NUM statement* EOF
	;

statement :
	  distance STATE_END						#distState
	| CURVE curve STATE_END						#curveState
	| GRADIENT gradient STATE_END				#gradientState
	| TRACK track STATE_END						#trackState
	| STRUCTURE structure STATE_END				#structureState
	| REPEATER repeater STATE_END				#repeaterState
	| BACKGROUND background STATE_END			#backgroundState
	| STATION station STATE_END					#stationState
	| SECTION section STATE_END					#sectionState
	| SIGNAL signal STATE_END					#signalState
	| BEACON beacon STATE_END					#beaconState
	| SPEEDLIMIT speedlimit STATE_END			#speedlimitState
	| PRETRAIN pretrain STATE_END				#pretrainState
	| LIGHT light STATE_END						#lightState
	| FOG fog STATE_END							#fogState
	| DRAWDISTANCE drawdistance STATE_END		#drawdistanceState
	| CABILLUMINANCE cabilluminance STATE_END	#cabilluminanceState
	| IRREGULARITY irregularity STATE_END		#irregularityState
	| ADHESION adhesion STATE_END				#adhesionState
	| SOUND sound STATE_END						#soundState
	| SOUND3D sound3d STATE_END					#sound3dState
	| ROLLINGNOISE rollingnoise STATE_END		#rollingnoiseState
	| FLANGENOISE flangenoise STATE_END			#flangenoiseState
	| JOINTNOISE jointnoise STATE_END			#jointnoiseState
	| TRAIN train STATE_END						#trainState
	| varAssign STATE_END						#varAssignState
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
	| OPN_BRA key=expr CLS_BRA DOT func=BEGIN0 OPN_PAR trackkey=nullableExpr COMMA tilt=nullableExpr COMMA span=nullableExpr COMMA interval=nullableExpr strkey+ CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=END OPN_PAR CLS_PAR
	;

//�w�i
background :
	DOT func=CHANGE OPN_PAR structurekey=nullableExpr CLS_PAR
	;

//��ԏ�
station :
	  DOT func=LOAD OPN_PAR path=string CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PUT OPN_PAR door=nullableExpr COMMA margin1=nullableExpr COMMA margin2=nullableExpr CLS_PAR
	;

//����
section :
	  DOT func=BEGIN OPN_PAR nullableExpr exprArgs* CLS_PAR
	| DOT func=SET_SPEEDLIMIT OPN_PAR nullableExpr exprArgs* CLS_PAR
	;

//�M���@
signal :
	  DOT func=LOAD OPN_PAR path=string CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PUT OPN_PAR sectionArgs=nullableExpr COMMA trackkey=nullableExpr COMMA x=nullableExpr COMMA y=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PUT OPN_PAR sectionArgs=nullableExpr COMMA trackkey=nullableExpr COMMA x=nullableExpr COMMA y=nullableExpr COMMA z=nullableExpr COMMA rx=nullableExpr COMMA ry=nullableExpr COMMA rz=nullableExpr COMMA tilt=nullableExpr COMMA span=nullableExpr CLS_PAR
	;

//�n��q
beacon :
	DOT func=PUT OPN_PAR type=nullableExpr COMMA sectionArgs=nullableExpr COMMA sendData=nullableExpr CLS_PAR
	;

//���x����
speedlimit :
	  DOT func=BEGIN OPN_PAR v=nullableExpr CLS_PAR
	| DOT func=END OPN_PAR CLS_PAR
	;

//��s���
pretrain :
	DOT func=PASS OPN_PAR nullableExpr CLS_PAR
	;

//����
light :
	  DOT func=AMBIENT OPN_PAR red=nullableExpr COMMA green=nullableExpr COMMA blue=nullableExpr CLS_PAR
	| DOT func=DIFFUSE OPN_PAR red=nullableExpr COMMA green=nullableExpr COMMA blue=nullableExpr CLS_PAR
	| DOT func=DIRECTION OPN_PAR pitch=nullableExpr COMMA yaw=nullableExpr CLS_PAR
	;

//������
fog :
	  DOT func=INTERPOLATE OPN_PAR CLS_PAR
	| DOT func=INTERPOLATE OPN_PAR densityE=expr CLS_PAR
	| DOT func=INTERPOLATE OPN_PAR density=nullableExpr COMMA red=nullableExpr COMMA green=nullableExpr COMMA blue=nullableExpr CLS_PAR
	;

//���i�`�拗��
drawdistance :
	DOT func=CHANGE OPN_PAR value=nullableExpr CLS_PAR
	;

//�^�]��̖��邳
cabilluminance :
	DOT func=INTERPOLATE OPN_PAR value=expr? CLS_PAR
	;

//�O���ψ�
irregularity :
	DOT func=CHANGE OPN_PAR x=nullableExpr COMMA y=nullableExpr COMMA r=nullableExpr COMMA lx=nullableExpr COMMA ly=nullableExpr COMMA lr=nullableExpr CLS_PAR
	;

//�S������
adhesion :
	  DOT func=CHANGE OPN_PAR a=nullableExpr CLS_PAR
	| DOT func=CHANGE OPN_PAR a=nullableExpr COMMA b=nullableExpr COMMA c=nullableExpr CLS_PAR
	;

//��
sound :
	  DOT func=LOAD OPN_PAR path=string CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PLAY OPN_PAR CLS_PAR
	;

//�Œ艹��
sound3d :
	  DOT func=LOAD OPN_PAR path=string CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=PUT OPN_PAR x=nullableExpr COMMA y=nullableExpr CLS_PAR
	;

//���s��
rollingnoise :
	DOT func=CHANGE OPN_PAR index=nullableExpr CLS_PAR
	;

//�t�����W�����艹
flangenoise :
	DOT func=CHANGE OPN_PAR index=nullableExpr CLS_PAR
	;

//�����ʉ߉�
jointnoise :
	DOT func=PLAY OPN_PAR index=nullableExpr CLS_PAR
	;

//�����
train :
	  DOT func=ADD OPN_PAR trainkey=nullableExpr COMMA path=expr COMMA trackkey=nullableExpr COMMA direction=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=LOAD OPN_PAR path=expr COMMA trackkey=nullableExpr COMMA direction=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=ENABLE OPN_PAR time=nullableExpr CLS_PAR
	| OPN_BRA key=expr CLS_BRA DOT func=STOP OPN_PAR decelerate=nullableExpr COMMA stoptime=nullableExpr COMMA accelerate=nullableExpr COMMA speed=nullableExpr CLS_PAR
	;

//�A���X�g���N�`�����X�g����
strkey :
	COMMA key=string;

//�A����������
exprArgs :
	COMMA arg=nullableExpr;

//�ϐ�/����
varAssign :
	v=var EQUAL expr;

nullableExpr :
	  expr
	| nullSyntax=NULL
	| /* epsilon */
	;

expr :
	  OPN_PAR expr CLS_PAR							#parensExpr
	| op=(PLUS | MINUS) expr						#unaryExpr
	| left=expr op=(MULT | DIV) right=expr			#infixExpr
	| left=expr op=(PLUS | MINUS | MOD) right=expr	#infixExpr
	| func=ABS OPN_PAR value=expr CLS_PAR			#absExpr
	| func=ATAN2 OPN_PAR y=expr x=expr CLS_PAR		#atan2Expr
	| func=CEIL OPN_PAR value=expr CLS_PAR			#ceilExpr
	| func=COS OPN_PAR value=expr CLS_PAR			#cosExpr
	| func=EXP OPN_PAR value=expr CLS_PAR			#expExpr
	| func=FLOOR OPN_PAR value=expr CLS_PAR			#floorExpr
	| func=LOG OPN_PAR value=expr CLS_PAR			#logExpr
	| func=POW OPN_PAR x=expr y=expr CLS_PAR		#powExpr
	| func=RAND OPN_PAR value=expr? CLS_PAR			#randExpr
	| func=SIN OPN_PAR value=expr CLS_PAR			#sinExpr
	| func=SQRT OPN_PAR value=expr CLS_PAR			#sqrtExpr
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
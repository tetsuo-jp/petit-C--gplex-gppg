%namespace Petit
%partial
%visibility internal

%{
%}

%union {
	public ExpressionNode expression;
	public ProgramNode program;
	public VariableNode variable;
}

%token	ZERO VAR SUC FOR TIMES_DO END ASSIGN
%token	<variable>	VAR
%left	SEMICOLON


%type	<expression>	expression
%type	<program>		program

%%

input
	: program	{ this.root = $1; }
	;

program
	: program SEMICOLON program				{ $$ = new SequenceNode($1, $3); }
	| FOR expression TIMES_DO program END	{ $$ = new ForNode($2, $4); }
	| VAR ASSIGN expression					{ $$ = new AssignNode($1, $3); }
	;

expression
	: ZERO				{ $$ = new ZeroNode(); }
	| VAR				{ $$ = $1; }
	| SUC expression	{ $$ = new SucNode($2); }
	;

%%

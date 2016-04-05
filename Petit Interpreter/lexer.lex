%namespace Petit
%visibility internal

%{

public bool IsInteractive { get; set; }

%}

SP	[ \t]+

%%

0					{ return (int)Tokens.ZERO; }
[A-Z]				{ yylval.variable = new VariableNode(yytext[0]); return (int)Tokens.VAR; }
;					{ return (int)Tokens.SEMICOLON; }
:=					{ return (int)Tokens.ASSIGN; }
suc{SP}				{ return (int)Tokens.SUC; }
for{SP}				{ return (int)Tokens.FOR; }
{SP}times{SP}do{SP}	{ return (int)Tokens.TIMES_DO; }
{SP}end				{ return (int)Tokens.END; }

\n					{ ; }
{SP}				{ ; }
.					{ ; }

%%

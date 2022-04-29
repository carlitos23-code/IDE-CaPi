numero [0-9]
reservadas program|if|else|fi|do|until|while|read|write|not|and|or
dataType int|float|string|boolean
palabra [a-z]|[A-Z]
id {palabra}({palabra}|{numero})* 
operadores "+"|"-"|"*"|"/"|"%"|"^"
opEspeciales "<"|"<="|">"|">="|"=="|"!="|"="|"{"|"}"|"("|")"

%{
#include<stdio.h>
#include <math.h>
int numero_lineas = 1;
int numero_columna = 1;
%}
%%
\n {
   numero_lineas++;
   numero_columna = 1; 
}

" " {

}

{reservadas} {
    printf("%s palabra clave linea = %d columna = %d \n", yytext, numero_lineas, numero_columna);
    numero_columna++;
}
{numero}{numero}* {
    printf("%s entero linea = %d columna = %d \n", yytext, numero_lineas, numero_columna);
    numero_columna++;
}
{numero}{numero}*"."{numero}{numero}* { 
     printf("%s flotante linea = %d columna = %d \n", yytext, numero_lineas, numero_columna);
    numero_columna++;
}
{dataType} {
    printf("%s tipo de dato linea = %d columna = %d \n", yytext, numero_lineas, numero_columna);
    numero_columna++;
}
{id} {
   printf("%s identificador linea = %d columna = %d \n", yytext, numero_lineas, numero_columna); 
   numero_columna++;
} 
{operadores} {
   printf("%s operador linea = %d columna = %d \n", yytext, numero_lineas, numero_columna); 
   numero_columna++;  
}
{opEspeciales} {
   printf("%s simbolo especial linea = %d columna = %d \n", yytext, numero_lineas, numero_columna); 
   numero_columna++;  
}

"//" {
   printf("%s comentario en linea = %d columna = %d \n", yytext, numero_lineas, numero_columna); 
   numero_columna++; 
}


"/*" {
    printf("%s comentario abre = %d columna = %d \n", yytext, numero_lineas, numero_columna); 
   numero_columna++; 
}

"*/" {
   printf("%s comentario cierra = %d columna = %d \n", yytext, numero_lineas, numero_columna); 
   numero_columna++; 
}

%%
int yywrap(){
 return 1;
}
int main(int argc, char *argv[]){
 yyin = fopen(argv[1], "r");
 yylex();

 return 0;
}
//TryParse()

/*Tenta analisar uma cadeia de caracteres sobre o tipo de dados
numérico fornecido.Caso seja bem sucedido, armazenará o valor 
convertido em um parâmetro out e retornará um bool para indicar
se teve êxito ou não.*/

//Parâmetro out

/*Indica que o argumento a ser passado receberá um valor dentro
do método.*/

//Exemplo

string value = "bad";
int result = 0;
if (int.TryParse(value, out result)){
    Console.WriteLine($"Measurement: {result}");
}
else{
    Console.WriteLine("Unable to report the measurement.");
}
/*Na linha 17, o método int.TryParse() retornará [true] caso tenha
convertido com êxito a |string value|, caso contrário, retornará
[false].*/

//---------------------------------------------------------------

Console.WriteLine($"Measurement (w/ offset): {50 + result}");

/*Se a variável "out" for declarada no escopo global, você pode
utilizá-la no seu código depois.*/

~~14mN1ck

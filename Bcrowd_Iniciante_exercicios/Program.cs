/*MÉTODO MAIS SIMPLES PARA TROCAR DUAS VARIÁVEIS É USAR UMA TERCEIRA VARIÁVEL TEMPORÁRIA:

int num1, num2, temp;
Console.WriteLine("Digite o primeiro numero: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
num2 = Convert.ToInt32(Console.ReadLine());

//troca de valores
temp = num1;
num1 = num2;
num2 = temp;


Console.Write("\nApós trocar: ");
Console.Write("\nPrimeiro número: " + num1);
Console.Write("\nSegundo número: " + num2);

Console.Read();*/

// MULTIPLICAR 3 NÚMEROS E EXIBIR MENSAGEM SE FOR MULTIPLO DE 5 OU 7:


/*int num1, num2, num3, resulta;

Console.WriteLine("Digite o primeiro valor a ser multiplicado: ");
num1 =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo valor a ser muliplicado: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o terceiro valor a ser multiplicado: ");
num3 = Convert.ToInt32(Console.ReadLine());
resulta = num1 * num2 * num3;

Console.Write($"{num1} x {num2} x {num3} = ");
if(resulta %5 == 0 ){

    Console.Write($"{resulta} é multiplo de 5");
}
else if (resulta %7 == 0)
{
    Console.WriteLine($"{resulta} é multiplo de 7");
}
else
{
    Console.Write($"{resulta}");
}*/

//MULTIPLICAR NÚMEROS COM ENTRADA DO USUÁRIO E LAÇO DE REPETIÇÃO:

/* int num1, resulta = 1;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Digite o {i}º valor a ser multiplicado: ");
    num1 =  Convert.ToInt32(Console.ReadLine());
    resulta *= num1;
}
Console.WriteLine($"o resultado da multiplicação é: {resulta} ");
*/

//TABUADA

/*int  vezes = 0, numUsuario;
Console.WriteLine("Digite um número para ver a Tabuada de Multiplicação: ");
numUsuario = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= 9; i++)
{
   vezes = numUsuario * i;
   Console.WriteLine($"{numUsuario} x {i} = {vezes}");
}


//calcular média usando laço de repetição "for" e classe "List"

/*List<int> numerosMedia = new List<int>();

  int soma = 0;
  Console.WriteLine("Vamos tirar a média de quatro números!");

  for (int i = 1; i <= 4; i++)
  {
  Console.WriteLine($"Digite o {i}º número: ");
  int num = Convert.ToInt32(Console.ReadLine());
  numerosMedia.Add(num);
  }
  foreach (int num in numerosMedia)
{
   soma += num;
}
double media = (double)soma / numerosMedia.Count;

//opção de saída 1:
Console.Write("A média dos números: ");
Console.Write(string.Join(", ", numerosMedia));
Console.Write($" é {media}");

/*opção de saída 2: 
Console.Write($"A média dos números: {numerosMedia[0]}, {numerosMedia[1]}, {numerosMedia[2]}, {numerosMedia[3]} é {media}");




//IMPRIMIR APENAS NÚMEROS ÍMPARES

/*int impar = 0;
for(impar = 1; impar <= 99; impar++)
{
   if (impar %2 != 0)
   {
       Console.WriteLine($"{impar}");
   }
   else{};
}*/

// Multiplo de 3 ou 7:


/*Console.WriteLine("Digite um número inteiro: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 3 == 0 || num % 7 == 0)
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("falso");
}
*/


/* string codPeca1 = Console.ReadLine() ?? string.Empty;
string codPeca2 = Console.ReadLine() ?? string.Empty;
string[] dados = codPeca1.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries); //método Split captura múltiplos dados na mesma linha
int codigo = int.Parse(dados[0]);
int quantPeca = int.Parse(dados[1]);
double valor = double.Parse(dados[2]);
string[] dados2 = codPeca2.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
int codigo2 = int.Parse(dados2[0]);
int quantPeca2 = int.Parse(dados2[1]);
double valor2 = double.Parse(dados2[2]);

double totalPeca = (quantPeca * valor) + (quantPeca2 * valor2);
Console.WriteLine($"VALOR A PAGAR: R$ {totalPeca:F2}");*/

/* int A = Convert.ToInt32(Console.ReadLine());
 int B = Convert.ToInt32(Console.ReadLine());
 int C = Convert.ToInt32(Console.ReadLine());
 int maior = (A + B + Math.Abs(A - B)) / 2;
 if(C > maior)
 {
     Console.WriteLine($"{C} eh o maior.");

 }
 else
 {
     Console.WriteLine($"{maior} eh o maior");
 }

*/

// IDADE EM DIAS
/*int totalDias = Convert.ToInt32(Console.ReadLine());

int anos = totalDias  / 365;
int restoDias =  totalDias % 365;
int mes = restoDias / 30;
int dia = restoDias % 30;
Console.WriteLine($"{anos} ano(s)");
Console.WriteLine($"{mes} mes(es)");
Console.WriteLine($"{dia} dia(s)"); 
*/

// VOLUME DE ESFERA:

/*double raioEsfera = Convert.ToDouble(Console.ReadLine());
double volume = (4.0/3) * 3.14159 * Math.Pow(raioEsfera, 3);

Console.WriteLine($"VOLUME = {volume:F3}"); */


// CALCULO AREA: 

/*
string ABC = Console.ReadLine() ??string.Empty;
string[] valor = ABC.Split(new char[]{ ' ' },StringSplitOptions.RemoveEmptyEntries);
double A = double.Parse(valor[0]);
double B = double.Parse(valor[1]);
double C = double.Parse(valor[2]);


double trianguloRetnglo = A * C / 2;
double areaCirculo = 3.14159 * Math.Pow(C,2);
double trapezio = (A + B) * C/ 2;
double quadrado = Math.Pow(B,2);
double retangulo =  A * B;

Console.WriteLine($"TRIANGULO: {trianguloRetnglo:F3}");
Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
Console.WriteLine($"QUADRADO: {quadrado:F3}");
Console.WriteLine($"RETANGULO: {retangulo:F3}");*/

// CONSUMO:
/*
int distancia = Convert.ToInt32(Console.ReadLine());
double combustivelGasto = Convert.ToDouble(Console.ReadLine());
double consumoMedio = distancia / combustivelGasto;
Console.WriteLine($"{consumoMedio:F3} km/l");
*/

// DISTÂNCIA ENTRE DOIS PONTOS:

/*string p1 = Console.ReadLine() ?? string.Empty;
string[] eixos = p1.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
double x1 = double.Parse(eixos [0]);
double y1 = double.Parse(eixos [1]);
string p2 = Console.ReadLine() ?? string.Empty;
string[] eixos2 = p2.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
double x2 = double.Parse(eixos2 [0]);
double y2 = double.Parse(eixos2 [1]);
double distancia = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1, 2));
Console.WriteLine($"{distancia:F4}");
*/

//DISTÂNCIA:
/*int distancia = Convert.ToInt32(Console.ReadLine());
int tempo = distancia * 2;
Console.WriteLine($"{tempo} minutos");*/

//GASTO DE COMBUSTÍVEL

/*int tempoGasto = Convert.ToInt32(Console.ReadLine());
int velocidadMedia = Convert.ToInt32(Console.ReadLine());
double distancia = tempoGasto * velocidadMedia; 
double gasolina = distancia / 12;
Console.WriteLine($"{gasolina:F3}");*/

//DECOMPONDO VALORES EM CÉDULAS
/*
 int N = Convert.ToInt32(Console.ReadLine());
 int valor = N;
 int notas100 = valor / 100;
 valor %= 100; //VARIÁVEL VALOR RECEBENDO O RESTO DAS DIVISOES 
 int notas50 = valor / 50;
 valor %= 50;
 int notas20 = valor / 20;
 valor %= 20;
 int notas10 = valor / 10;
 valor %= 10;
 int notas5 = valor / 5;
 valor %= 5;
 int notas2 = valor / 2;
 valor %= 2;
 int notas1 = valor / 1; 

 Console.WriteLine($"{N}");
 Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
 Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
 Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
 Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
 Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
 Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
 Console.WriteLine($"{notas1} nota(s) de R$ 1,00");
 */

//CONVERSÃO DE TEMPO

/*int tempo = Convert.ToInt32(Console.ReadLine());
int hora = tempo / 3600; 
int sobraHora = tempo %= 3600;
int minutos = sobraHora / 60;
int segundos = tempo %= 60;

Console.WriteLine($"{hora}:{minutos}:{segundos}");*/

//NOTAS E MOEDAS
/*
double valor = Convert.ToDouble (Console.ReadLine());
// Multiplica por 100 e arredonda usando Math.Round e MidpointRounding.AwayFromZero para evitar erros de precisão,
// convertendo o total para centavos em um valor inteiro (long)
long centavos = (long)Math.Round(valor * 100, MidpointRounding.AwayFromZero);
long[] notas = {10000, 5000, 2000, 1000, 500, 200};
long[] moedas = {100, 50, 25, 10, 5, 1};
Console.WriteLine("NOTAS:");
// Vetores com os valores das notas e moedas convertidos para centavos
foreach (long nota in notas)
{
    long quantidadeNotas = centavos / nota;
    Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {(nota / 100.0):F2}");
    centavos %= nota;
}
Console.WriteLine("MOEDAS:");
foreach(long moeda in moedas)
{
    long quantidadeMoedas = centavos / moeda;
    Console.WriteLine($"{quantidadeMoedas} moeda(s) de R$ {(moeda / 100.0):F2}");
    centavos %= moeda;
}*/

//PERCORRENDO LISTA COM FOREACH
/*List<string> listaNomes = new(){"Pérola", "Ian", "Isis"};
foreach(string item in listaNomes)
{
    Console.WriteLine($"Olá, {item}, você está convidado para a festa!");
}

//ACUMULAR VALORES EM VARÁVEL EXTERNA AO LOOP
List<double> listaCompras = new(){70,50,82,100};
double soma = 0;
foreach(double compra in listaCompras)
{
    soma += compra;
}
double total = soma;
Console.WriteLine($"Total: R$ {total}");*/

//FILTRAR DADOS DE UMA COLEÇÃO USANDO LÓGICA CONDICIONAL

/*List<int> idadeConvidados = new(){15, 18, 25, 13, 38, 30};
foreach(int idade in idadeConvidados)
{
    if(idade >= 18)
    {
        Console.WriteLine($"{idade}");
    }
}*/

//USAR LOOP PARA CONTAR OCORRÊNCIAS ESPECÍFICAS
/*List<double> notasAlunos = new(){1.0, 4.5, 8.0, 7.5, 10.0, 3.2, 9.3};
int quantidade = 0;
foreach(double nota in notasAlunos)
{
    if (nota >= 7.0)
    {
        quantidade++;
    }
}
Console.WriteLine($"{quantidade} alunos foram aprovados");*/

//UTILIZAR PROPRIEDADES DOS ELEMENTOS DA LISTA DENTRO DO LOOP

/*List<string> nomesCidades = new(){"Montes Claros", "São Paulo", "Uberaba", "Pompeu", "Belo Horizonte", "São João da Ponte", "Juramento", "Chuí"};
Console.WriteLine("CIDADES COM MAIS DE 8 CARACTERES:");
foreach(string cidade in nomesCidades)
{
   if(cidade.Length >= 8)
    {
        Console.WriteLine($"- {cidade} ({cidade.Length} caracteres - contando o espaço).");
    }
}
*/

//CATÁLOGO E PRODUTOS(POO)

public class Produto
{
 public string? Nome { get; set; }
 public double Preco { get; set; }
 public void ExibirInformacoes()
    {
        Console.WriteLine($"Produto: {Nome} | Preço: R$ {Preco:F2}");
    }
}
class Program{
static void Main(){
    Produto produto1 = new Produto
    {
        Nome = "Monitor 32 polegadas",
        Preco = 1500.00,
    };
    Produto produto2 = new Produto
    {
        Nome = "Celular Poco-X7",
        Preco = 2000.00
    };
    Produto produto3 = new Produto
    {
        Nome = "Climatizador Midea",
        Preco = 930.00
    };

    Produto produto4 = new Produto
    {
        Nome = "Fone Blueetooth Basike",
        Preco = 50.00
    };
   
    List<Produto> catalogo = new List<Produto>()

    {
      produto1,
      produto2,
      produto3,
      produto4,

    };
    foreach (Produto p in catalogo)
        {
            p.ExibirInformacoes();
        }
        
        
        
        }
 }   
    



   
    
    

    

# Seção 17: Expressões lambda, delegates, LINQ

Expressões lambda, delegates e LINQ são conceitos da linguagem de programação C#.
Expressões lambda: são funções anônimas que podem ser definidas e passadas como parâmetros para outras funções ou métodos. Elas permitem escrever código mais conciso e legível, especialmente em operações que envolvem listas, arrays e coleções em geral. Exemplo:

    int[] numeros = { 1, 2, 3, 4, 5 };
    var numerosPares = Array.FindAll(numeros, x => x % 2 == 0);

<b>Delegates</b>: são tipos de dados que permitem definir referências a métodos e passá-los como parâmetros para outras funções ou métodos. Eles são úteis quando se deseja implementar callbacks ou eventos, por exemplo. Exemplo:delegate int Operacao(int x, int y);

    public static int Soma(int x, int y)
    {
        return x + y;
    }

    public static void Main()
    {
        Operacao operacao = Soma;
        int resultado = operacao(2, 3); // resultado = 5
    }

<b>LINQ</b>: é uma tecnologia que permite escrever consultas (queries) em objetos que implementam a interface IEnumerable. Essas consultas são expressas em uma linguagem específica chamada LINQ Query Syntax ou usando a sintaxe de métodos de extensão LINQ. Elas são úteis para filtrar, ordenar e projetar dados em coleções. 

Exemplo:

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
    var numerosPares = from n in numeros
                    where n % 2 == 0
                    select n;

Em resumo, expressões lambda, delegates e LINQ são recursos poderosos da linguagem C# que permitem escrever código mais conciso e legível, além de facilitar a manipulação de coleções de dados.

# Programação funcional e calculo de lambda

Programação funcional é um paradigma de programação que se baseia em funções matemáticas e evita o uso de estados mutáveis e efeitos colaterais. Nesse paradigma, as funções são tratadas como cidadãos de primeira classe, ou seja, podem ser passadas como argumentos para outras funções, retornadas como valores de outras funções e armazenadas em variáveis.
O cálculo lambda é um formalismo matemático que descreve as funções em termos de expressões lambda, ou seja, funções anônimas que recebem argumentos e retornam valores. 
Ele foi proposto por Alonzo Church na década de 1930 e é considerado a base teórica da programação funcional.
Em programação funcional, as funções são definidas em termos de expressões lambda e a composição de funções é uma técnica comum para construir programas. Exemplo:
// Função que recebe uma lista de números e retorna a soma dos quadrados dos números pares

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
    int somaDosQuadradosDosPares = numeros.Where(x => x % 2 == 0).Select(x => x * x).Sum();

No cálculo lambda, as funções são definidas em termos de expressões lambda e as operações de aplicação e substituição são usadas para calcular o valor de uma expressão. 

    Exemplo:// Função que calcula o fatorial de um número usando cálculo lambda
    Func<Func<int, int>, Func<int, int>> fatorial = f => n => n == 0 ? 1 : n * f(n - 1);
    int resultado = fatorial(fatorial)(5); // resultado = 120

Em resumo, programação funcional e cálculo lambda são conceitos relacionados que se baseiam em funções matemáticas para construir programas. A programação funcional é um paradigma de programação que utiliza funções como cidadãos de primeira classe e evita estados mutáveis e efeitos colaterais. O cálculo lambda é um formalismo matemático que descreve as funções em termos de expressões lambda e é considerado a base teórica da programação funcional.

# Delegate 

Delegate é um tipo de dado em C# que representa referências a métodos. Delegates são utilizados para permitir a passagem de métodos como argumentos para outros métodos, além de possibilitar a criação de callbacks e eventos.
Para declarar um delegate, utiliza-se a palavra-chave delegate, seguida pela assinatura do método que ele irá referenciar. Por exemplo:

    delegate void ImprimeTextoDelegate(string texto);

Nesse exemplo, o delegate ImprimeTextoDelegate é declarado com a assinatura de um método que recebe uma string como argumento e não retorna valor. Esse delegate pode ser usado para referenciar qualquer método que tenha a mesma assinatura.
Para criar uma instância de um delegate, utiliza-se a sintaxe de inicialização de delegate. Por exemplo:

    ImprimeTextoDelegate imprime = Console.WriteLine;

Nesse exemplo, a variável imprime é do tipo ImprimeTextoDelegate e é inicializada com uma referência ao método Console.WriteLine, que tem a mesma assinatura do delegate.
Para invocar um método referenciado por um delegate, utiliza-se a sintaxe de invocação do delegate, passando os argumentos necessários para o método. Por exemplo:

    imprime("Hello, world!");

Nesse exemplo, o método Console.WriteLine é invocado por meio do delegate imprime, passando a string "Hello, world!" como argumento.
Delegate é uma das principais ferramentas do C# para implementar callbacks e eventos, permitindo a criação de programas mais flexíveis e modulares. Além disso, delegates são uma forma poderosa de criar funções anônimas e expressões lambda em C#.

# LINQ

LINQ (Language Integrated Query) é uma tecnologia introduzida no C# que fornece uma sintaxe unificada para realizar consultas (queries) em diferentes fontes de dados, como coleções, bancos de dados, serviços web, entre outros.
O LINQ permite escrever consultas de forma declarativa, expressando a intenção do que se deseja obter, em vez de especificar os passos detalhados de como obtê-lo. Isso torna o código mais legível e facilita a manipulação de dados.
Há duas formas principais de escrever consultas LINQ: a sintaxe de consulta (query syntax) e a sintaxe de método (method syntax).
Sintaxe de consulta (query syntax):

A sintaxe de consulta LINQ utiliza palavras-chave semelhantes a SQL para expressar as operações desejadas, como from, where, select, group by, orderby, entre outras. Exemplo:

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 }; var numerosPares = from num in numeros where num % 2 == 0 select num;

Nesse exemplo, a consulta LINQ retorna os números pares da lista numeros.
Sintaxe de método (method syntax):

A sintaxe de método LINQ utiliza métodos de extensão que operam em objetos que implementam a interface IEnumerable<T>. Os métodos representam as operações de consulta, como Where, Select, OrderBy, GroupBy, entre outros. Exemplo:

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 }; var numerosPares = numeros.Where(num => num % 2 == 0);

Nesse exemplo, o método Where filtra os números pares da lista numeros.
O LINQ oferece suporte a uma ampla gama de operações de consulta, incluindo filtragem, projeção, ordenação, agrupamento e junção de dados. Além disso, é possível combinar consultas LINQ para realizar operações mais complexas.
As consultas LINQ podem ser realizadas em várias fontes de dados, como listas, arrays, bancos de dados relacionais (usando o LINQ to SQL ou o Entity Framework), serviços web (usando o LINQ to XML) e muitos outros provedores de dados.
Em resumo, o LINQ é uma poderosa tecnologia do C# que simplifica a escrita de consultas em diferentes fontes de dados. Ele fornece uma sintaxe unificada e expressiva para manipular dados, tornando o código mais legível e facilitando a realização de operações de consulta complexas.


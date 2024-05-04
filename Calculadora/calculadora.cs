// calculadora simples
using System;
class HelloWorld {
  static void Main() {
    while(true){
    Console.WriteLine("Bem vindo a calculadora\nEscolha a tarefa que quer fazer:\nAdição|+| Subtracão |-| Multiplicação |*| Divisão |/| Resto |%| Potencição |!| Sair |.|");
    char escolha = char.Parse(Console.ReadLine());
        if(escolha == '.'){
            break;
        }else{
        switch (escolha){
            case '+':
        Soma();
        Console.ReadKey();
        Console.Clear();
        break;
        case '-':
        Subtracao();
        Console.ReadKey();
        Console.Clear();
        break;
        case '*':
        Multiplicacao();
        Console.ReadKey();
        Console.Clear();
        break;
        case '/':
        Divisao();
        Console.ReadKey();
        Console.Clear();
        break;
        case '%':
        Resto();
        Console.ReadKey();
        Console.Clear();
        break;
        case '!':
        Potenciacao();
        Console.ReadKey();
        Console.Clear();
        break;
        
        }
      }
    }
  }    

  static void Soma(){
      Console.WriteLine("Digite o primeiro valor: ");
      int n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      int n2 = int.Parse(Console.ReadLine());
      int soma = n1 + n2;
      Console.WriteLine("A soma dos numeros {0} e {1} é {2}",n1,n2,soma);
  }
  static void Subtracao(){
      Console.WriteLine("Digite o primeiro valor: ");
      int n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      int n2 = int.Parse(Console.ReadLine());
      
      int subtracao = n1 - n2;
      Console.WriteLine("A subtração dos numeros {0} e {1} é {2}",n1,n2,subtracao);
  }
  static void Multiplicacao(){
      Console.WriteLine("Digite o primeiro valor: ");
      int n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      int n2 = int.Parse(Console.ReadLine());
      int multiplicacao = n1 * n2;
      Console.WriteLine("A multiplicação dos numeros {0} e {1} é {2}",n1,n2,multiplicacao);
  }
  static void Divisao(){
      Console.WriteLine("Digite o primeiro valor: ");
      double n1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor: ");
      double n2 = double.Parse(Console.ReadLine());
      
      double divisao = n1 / n2;
      Console.WriteLine("A divisão do numero {0} por {1} é {2}",n1,n2,divisao);
  }
  static void Resto(){
      Console.WriteLine("Digite o primeiro valor da divisão: ");
      int n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o segundo valor da divisão: ");
      int n2 = int.Parse(Console.ReadLine());
      
      int resto = n1 % n2;
      Console.WriteLine("O resto da divisão dos numeros {0} e {1} é {2}",n1,n2,resto);
  }
  static void Potenciacao(){
      Console.WriteLine("Digite o valor da base: ");
      int n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor do expoente: ");
      int n2 = int.Parse(Console.ReadLine());
      
      double potencia = Math.Pow(n1,n2);
      Console.WriteLine("A potencia do numero {0} por {1} é {2}",n1,n2,potencia);
  }
}

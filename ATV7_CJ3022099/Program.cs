int opcao;

do
{
    do
    {

        Console.WriteLine("=========MENU=========");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("1 - EX1");
        Console.WriteLine("2 - EX2");
        Console.WriteLine("3 - EX3");
        Console.WriteLine("4 - EX3");
        Console.WriteLine("5 - EX3");
        Console.WriteLine("6 - EX3");
        Console.WriteLine("7 - EX3");
      

        opcao = int.Parse(Console.ReadLine());

    } while (opcao < 0 || opcao > 7);

    switch (opcao)
    {
        case 0:
            Console.WriteLine("Obrigado por usar o sistema!");
            break;
        
        case 1:
            Console.WriteLine("\n*Executando o EX1*\n");
            int Num, i = 1;
            Console.WriteLine("digite um número para contarmos até ele:");
            Num = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= Num);
            Console.WriteLine();
            break;
            
        case 2:
            Console.WriteLine("\n*Executando o EX2*\n");
            int Nume, cont = 1;
            Console.WriteLine("digite um número para contarmos os números pares até ele:");
            Nume = int.Parse(Console.ReadLine());

            do
            {
                if (cont == 1 || cont % 2 == 0)
                    Console.WriteLine(cont);
                cont++;
            }
            while (cont <= Nume);

            Console.WriteLine();
            break;
        
        case 3:
            Console.WriteLine("\n*Executando o EX3*\n");
            int Numer,con = 1000;
            Console.WriteLine("digite um número(menor que mil) para contarmos os números pares de mil até ele:");
            Numer = int.Parse(Console.ReadLine());

            if (Numer <= 1000)
            {
                do
                {
                    if (con == 1000 || con % 2 == 0)
                        Console.WriteLine(con);
                    con--;
                }
                while (con > Numer);
            }
            else
            {
                Console.WriteLine("O número é maior que mil");
            }
            break;
        
        case 4:
            Console.WriteLine("\n*Executando o EX4*\n");
            int valor = 0, Num1, conta = 0;
            do
            {
                Console.WriteLine("Digite números aleatótios para somarmos:");
                Num1 = int.Parse(Console.ReadLine());
                valor += Num1;
                conta++;
                if (Num1 >= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Último número positivo digitado:{0}", Num1);
                    Console.WriteLine("A soma dos números até agora é de:{0}", valor);
                    Console.WriteLine();
                }
                else if (Num1 < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Último número negativo digitado:{0}", Num1);
                    Console.WriteLine("A soma dos números até agora é de:{0}", valor);
                    Console.WriteLine();
                }
                if (valor >= 200)
                {
                    break;
                }
            }
            while (true);
            break;
        
        case 5:
            Console.WriteLine("\n*Executando o EX5*\n");
            int Num2, contar = 1;
            do
            {
                Console.WriteLine("Digite um número para que possamos descobrir seus divisores exatos:");
                Num2 = int.Parse(Console.ReadLine());
            } while (Num2 <= 0);
            do
            { 
                contar++;
                if (Num2 % contar == 0)
                {
                    Console.WriteLine("Os divisores exatos do número escolhido são:{0}", contar);
                }
            }
            while (contar <= Num2);
        break;
        
        case 6:
            Console.WriteLine("\n*Executando o EX6*\n");
            int[] numeros = new int[10];
            int maior, menor, contado = 0;

            do
            {
                Console.Write($"Digite o {contado + 1}º número: ");
                numeros[contado] = int.Parse(Console.ReadLine());
                contado++;
            }
            while (contado < 10);
            maior = menor = numeros[0];
            contado = 1;
            do
            {
                if (numeros[contado] > maior)
                {
                    maior = numeros[contado];
                }
                if (numeros[contado] < menor)
                {
                    menor = numeros[contado];
                }
                contado++;
            }
            while (contado < 10);
            Console.WriteLine($"O maior número digitado é: {maior}");
            Console.WriteLine($"O menor número digitado é: {menor}");
            break;
            

        case 7:
            Console.WriteLine("\n*Executando o EX7*\n");
            int numero;
            int Pares = 0;
            int Impar = 0;

            Console.WriteLine("Digite uma sequência de números (digite 0 para parar)");
            do
            {
                Console.Write("Número: ");
                numero = int.Parse(Console.ReadLine());
                if (numero != 0)
                {
                    if (numero % 2 == 0)
                    {
                        Pares += numero;
                    }
                    else
                    {
                        Impar += numero;
                    }
                }
            } while (numero != 0);
            Console.WriteLine($"A soma dos números pares é: {Pares}");
            Console.WriteLine($"A soma dos números ímpares é: {Impar}");
            break;
    }

} while (opcao != 0);
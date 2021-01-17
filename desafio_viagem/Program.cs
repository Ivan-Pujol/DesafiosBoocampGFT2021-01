using System;

namespace Desafios
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("insira o tempo e a velocidade média com um espaço simple entre eles ex: 10 80");
      string input = Console.ReadLine();
      string[] timeAndVelocity = input.Split(' ');
      float time;
      float velMedia;

      if (float.TryParse(timeAndVelocity[0], out time))
      {
        time = float.Parse(timeAndVelocity[0]);
      };

      if (float.TryParse(timeAndVelocity[1], out velMedia))
      {
        velMedia = float.Parse(timeAndVelocity[1]);
      };

      float gas = (time * velMedia) / 12f;
      Console.WriteLine(Math.Round(gas, 3));
    }
  }
}
/*
Desafio
Rubens quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem de carro, sendo que seu carro faz 12 KM/L. 
Como ele não sabe fazer um programa que o auxilie nessa missão, ele te pede ajuda. Para efetuar o cálculo, deve-se fornecer o 
tempo gasto em horas na viagem e a velocidade média durante a mesma em km/h. Assim, você conseguirá passar para Rubens qual a 
distância percorrida e, em seguida, calcular quantos litros serão necessários para a viagem que ele quer fazer. 
Mostre o valor com 3 casas decimais após o ponto.

Entrada
O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem em horas e o segundo é a velocidade média durante a mesma em km/h.

Saída
Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos após o ponto decimal

 
Exemplo de Entrada	Exemplo de Saída
10 85               70.833
22 67               122.833
*/
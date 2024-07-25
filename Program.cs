using ExemploAppGetESet.RegrasDeNegocio; //acesso a pasta

//fazendo uso do Get e Set na metodologia JAVA
CalculadoraDiversaVersao1 objeto = new CalculadoraDiversaVersao1();


Console.Write("Digite um Valor: ");

objeto.SetValor1(Convert.ToDecimal(Console.ReadLine()));
Console.WriteLine("Resultado: " + objeto.GetValor1() * 5);

//fazendo uso do SET e GET na metodologia C#

Console.Write("Digite um valor (C#): ");
objeto.Valor1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Resultado (C#): " + objeto.Valor1 * 7);


CalculadoraDiversaVersao2 objeto2 = new CalculadoraDiversaVersao2();
objeto2.Valor1 = 30;
Console.WriteLine("Resultado do José: " +objeto2.Valor1*1000);

objeto2.Valor2 = 15;
Console.WriteLine("Resultado do Luiz: " + objeto2.Valor2 * 1000);

objeto2.Valor3 = 13;
Console.WriteLine("Resultado do João: " + objeto2.Valor3 * 1000);

objeto2.GetSomar();
Console.WriteLine("Total = "+ objeto2.Total);
Console.ReadKey();


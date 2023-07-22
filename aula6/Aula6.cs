using System;

class Aula06 {
    static void Main() {
        // Console.WriteLine("Lorem ipson"); // Quebra linha no final
        // Console.Write("Lorem ipson \n"); // Não quebra linha no final

        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";



        valorVenda=valorCompra+(valorCompra*lucro);


        Console.WriteLine("Produto.........:{0,15}", produto);
        Console.WriteLine("Val.Compra......:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro...........:{0,15:p}", lucro);
        Console.WriteLine("Val.Venda.......:{0,15:c}", valorVenda);

    }
}
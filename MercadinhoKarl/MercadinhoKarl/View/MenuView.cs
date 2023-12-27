namespace MercadinhoKarl.View
{
    public class MenuView
    {
        public void CriarMenuPrincipal()
        {
            int opcao = 0;

            do
            {
                string menu = @"
                    ### Mercadinho do Karl ###
                    1- Cliente
                    2- Produtos
                    3- Vendas
                    9- Sair
                    Insira a opção desejada:
                ";
                Console.Write(menu);

                try
                {
                    opcao = Int32.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Menu Cliente");
                            break;
                        case 2:
                            Console.Clear();
                            ProdutoView pV = new ProdutoView ();
                            pV.CriarMenu();
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Menu Vendas");
                            break;
                        case 9:
                            Environment.Exit(0);//Finalizar o programa
                            break;
                        default:
                            throw new Exception("Opção selecionada não existe");//Exception criada pelo dev.
                    }
                }
                catch (Exception) 
                {
                    Console.Clear() ;
                    Console.WriteLine("Opção Invalida!\nInsira uma das opções a seguir:");
                }

            } while (opcao != 9);
        }
    }
}

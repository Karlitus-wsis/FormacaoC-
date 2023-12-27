namespace MercadinhoKarl.View
{
    public class ProdutoView
    {
        public void CriarMenu()
        {
            int opcao = 0;

            do
            {
                string menu = @"
                    ### PRODUTO ###
                    1- Cadastrar
                    2- Listar
                    3- Excluir
                    9- Voltar ao menu principal
                    Escolha a opção desejada:                
                ";
                Console.Write(menu);

                try
                {
                    opcao = Int32.Parse(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Cadastrar...");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Listar...");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Excluír...");
                            break;
                        case 9:
                            Console.Clear();
                            MenuView mV = new MenuView();
                            mV.CriarMenuPrincipal();
                            break;
                        default:
                            throw new Exception("Opção não existe");
                    }
                }catch (Exception)
                {
                    Console.Clear() ;
                    Console.WriteLine("Opção Inválida!\nInsira uma das opções a seguir:");
                }

            } while (opcao != 9);
        }
    }
}

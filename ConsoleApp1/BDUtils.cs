using ConsoleApp1.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class BDUtils
    {
        public static void Exemplos()
        {
            //Buscar("teste");
            //Listar();
            //Inserir();
            //Deletar("teste");
            //DeletarVarios("teste");


            //Pausar();
        }


        public static void Deletar(string nome)
        {
            //var contextoDados = new BancoProwayEntities();

            //var item = Buscar(nome);
            //contextoDados.categorias.Remove(item);
            //contextoDados.SaveChanges();

            //Listar();

        }

        public static void DeletarVarios(string nome)
        {
            //var contextoDados = new BancoProwayEntities();

            //var deletados = contextoDados.categorias.Where(x => x.nome.ToLower().Contains(nome)).ToList();


            //foreach (var item in deletados)
            //{
            //    contextoDados.categorias.Remove(item);
            //    contextoDados.SaveChanges();
            //    Console.WriteLine($"Deletar:{item.nome}");
            //}


            //Listar();
        }

        public static void Inserir()
        {
            //var contextoDados = new BancoProwayEntities();
            //var insert = new categorias
            //{
            //    nome = "Teste2",
            //};
            //contextoDados.categorias.Add(insert);
            //contextoDados.SaveChanges();


            //Listar();

        }

        public static void Listar()
        {
            //var contextoDados = new BancoProwayEntities();
            //List<categorias> categorias;
            //var all = contextoDados.categorias
            //         .ToList<categorias>();

            //foreach (var item in all)
            //{
            //    Console.WriteLine($"Nome:{item.nome}");
            //}

        }

        //public static categorias Buscar(string nome)
        //{
        //    var contextoDados = new BancoProwayEntities();


        //    var get = contextoDados.categorias
        //              .Where(s => s.nome == nome)
        //              .FirstOrDefault<categorias>();

        //    Console.WriteLine(get.nome);
        //    return get;
        //}

        public static void ImportarBanco()
        {
            Console.WriteLine(@"Como criar as entidades automaticamente com base no banco de dados:
            Botão direito no projeto
            adicionar
            novo item...
            lista de opções > Dados
            ADO.NET Entity Data Model
            Nomear arquivo como 'Banco'
            Adicionar
            Escolher primeira opção: EF Designer from database
            avançar
            New conection
            Abrir SSMS e permanacer na tela de login
            Copiar o nome do servidor
            Voltar ao visual studio
            No nome do servidor informar o mesmo nome do servidor na tela de login do SSMS
            La em baixo no grupo 'Conectar a um banco de dados' escolha o banco 'BancoProway'
            teste a conexão
            OK
            Avançar
            Manter versão do EntityFramework que for sugerida
            Marcar o checkbox 'tables'
            concluir
            esperar alguns minutos a geração automatica das entidades
            ...
            um arquivo será gerado como Banco.edmx
            expandir o arquivo Banco.edmx
            expandir o arquivo Banco.tt
            todas as entidades estarão la");

            Utils.Pausar();
        }



      
    }

}

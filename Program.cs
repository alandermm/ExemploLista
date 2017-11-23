using System;
using System.Collections;
using System.Collections.Generic;

namespace ExemploLista
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> sacola = new List<Produto>();
            sacola.Add(new HigienePessoal(){Id = 13, Nome = "Sabonete", Preco = 8.99, NumeroMS = "123456", Marca = "Dove"});
            sacola.Add(new Bebidas(){Id = 18, Nome = "Skol", Preco = 4.30, TeorAlcolico = 5.5, Tipo = "Cerveja"});

            Console.Clear();

            foreach (var item in sacola){
                string classe = item.GetType().ToString();
                switch(classe){
                    case "ExemploLista.HigienePessoal":
                    {
                        HigienePessoal higiene = (HigienePessoal)item;
                        Console.WriteLine("Higiene Pessoal: " + higiene.Nome + " - " +
                                                                higiene.NumeroMS + " - " +
                                                                higiene.Marca);
                        break;
                    }
                    case "ExemploLista.Bebidas":
                    {
                        Bebidas bebidas = (Bebidas)item;
                        Console.WriteLine("Bebidas: " + bebidas.Nome + " - " +
                                                        bebidas.TeorAlcolico + " - " +
                                                        bebidas.Tipo);
                        break;
                    }
                }
            }

            //Console.WriteLine("Id: " + sacola[1].Id + "\nNome: " + sacola[1].Nome + "\nPreço: " + sacola[1].Preco + "\nTeor Alcoolico: " + sacola[1].TeorAlcolico + "\nTipo: " + sacola[1].Tipo);

            /*List<Usuarios> usuarios = new List<Usuarios>();

            usuarios.Add(new Usuarios(){Id = 1, Login = "Pedro" , Senha = "123"});
            usuarios.Add(new Usuarios(){Id = 2, Login = "Joao", Senha = "321"});

            Console.Clear();
            Console.WriteLine("Id: " + usuarios[1].Id + "\nLogin: " + usuarios[1].Login + "\nSenha: " + usuarios[1].Senha);
            /*List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Campinas");
            cidades.Add("Manaus");
            cidades.Add("Rio de Janeiro");

            Console.WriteLine(cidades[1]);*/
        }
    }
}

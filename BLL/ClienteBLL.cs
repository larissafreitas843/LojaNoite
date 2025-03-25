using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Modelo;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using DAL;

namespace BLL
{
    internal class ClienteBLL
    {
        public void Incluir(ClienteInformation cliente)
        {
            //o nome do cliente é obrigatório
            if (cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente e obrigatorio");
            }
            //E-email sempre em minusculo
            cliente.Email = cliente.Email.ToLower();
            //se tudo ok, chma a rotina de inserção
           ClienteDAL obj = new ClienteDAL();   
            obj.Incluir(cliente);
        }
        public void Alterar(ClienteInformation cliente)
        {
            if(cliente.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é´obrigatório");
            }
            cliente.Email = cliente.Email.ToLower();
            ClienteDAL obj = new ClienteDAL();
            obj.Alterar(cliente);
        }
        public void Excluir(int codigo)
    }
}

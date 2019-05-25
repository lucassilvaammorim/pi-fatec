using CadastroUsuarios.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuarios.DAL
{
    public class CartaoDao
    {
        CartaoContext modelContext;

        //persistencia de dados entity framework
        public CartaoDao()
        {
            modelContext = new CartaoContext();
        }

        //buscar todos os registros
        public List<Cartao> GetAll()
        {
            try
            {
                return modelContext.Cartoes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //buscar registro pelo id do cartao
        public Cartao GetById(String cartaoId)
        {
            try
            {
                return modelContext.Cartoes.FirstOrDefault(x => x.ID.Equals(cartaoId));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //inserir novo registro
        public void Insert(Cartao cartao)
        {
            try
            {
                modelContext.Cartoes.Add(cartao);
                modelContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //deletar registro
        public void Delete(Cartao cartao)
        {
            try
            {
                modelContext.Cartoes.Remove(cartao);
                modelContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        //atualizar registro
        public void Update(Cartao newObject)
        {
            try
            {
                Cartao cartao = modelContext.Cartoes.FirstOrDefault(x => x.ID.Equals(newObject.ID));
                cartao.Cpf = newObject.Cpf;
                cartao.Motivo = newObject.Motivo;
                cartao.Nascimento = newObject.Nascimento;
                cartao.Nome = newObject.Nome;
                cartao.Validade = newObject.Validade;
                modelContext.SaveChanges();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }

    }
}

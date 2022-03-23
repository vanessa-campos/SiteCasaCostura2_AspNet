using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CasaCosturaCadastro.Models
{
    public class ProdutoService{

        public void Cadastrar(Produto at){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                ccc.Produto.Add(at);
                ccc.SaveChanges();
            }
        }
        public Produto ObterProdutoPorId(int id){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                return ccc.Produto.Find(id);
            }
        }        
        public ICollection<Produto> ListarTodos(){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){               
                IQueryable<Produto> query = ccc.Produto;         
                return query.OrderBy(a => a.Nome).ToList();
            }
        }
        public void AtualizarProduto(Produto p){
             using(CasaCosturaContext ccc = new CasaCosturaContext()){
                Produto produto = ccc.Produto.Find(p.Id);
                produto.Quantidade = p.Quantidade;          
                ccc.SaveChanges();
            }
        }
        public void Editar(Produto p){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                Produto produto = ccc.Produto.Find(p.Id);
                produto.Id = p.Id;
                produto.Categoria = p.Categoria;
                produto.Nome = p.Nome;
                produto.Descricao = p.Descricao;
                produto.Tamanho = p.Tamanho;
                produto.Valor = p.Valor;
                produto.Quantidade = p.Quantidade;          
                ccc.SaveChanges();
            }
        }
        public ICollection<Produto> MaxProdutosPg(int page, int size){            
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                int pular = (page-1)*size;                                              
                IQueryable<Produto> query = ccc.Produto;         
                return query.Skip(pular).Take(size).OrderBy(a => a.Nome).ToList();
            }
        }
        public int CountItemsProdutos(){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){                
                IQueryable<Produto> query = ccc.Produto;      
                return query.Count();
            }
        }

        // ---------------------------------------------------------------------------

        public void Costurar(Costura c){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                ccc.Costura.Add(c);
                ccc.SaveChanges();
            }
        }
        public Costura ObterCosturaPorId(int id){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                return ccc.Costura.Find(id);
            }
        }
        public void Atualizar(Costura c){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                Costura costura = ccc.Costura.Find(c.Id);
                costura.Resumo = c.Resumo;
                costura.Cliente = c.Cliente;
                costura.Telefone = c.Telefone;
                costura.Descricao = c.Descricao;          
                costura.Valor = c.Valor;          
                costura.DataEntrega = c.DataEntrega;          
                costura.Pago = c.Pago;          
                costura.Entregue = c.Entregue;          
                ccc.SaveChanges();
            }
        }
        public ICollection<Costura> MaxCosturasPg(int page, int size){            
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                int pular = (page-1)*size;                                              
                IQueryable<Costura> query = ccc.Costura;         
                return query.Skip(pular).Take(size).OrderBy(a => a.DataEntrega).ToList();
            }
        }
        public int CountItemsCosturas(){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){                
                IQueryable<Costura> query = ccc.Costura;      
                return query.Count();
            }
        }
        
        // ---------------------------------------------------------------------------

        public void Vender(Vendidos v){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                ccc.Vendidos.Add(v);
                ccc.SaveChanges();
            }
        }
        public ICollection<Vendidos> MaxVendasPg(int page, int size){            
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                int pular = (page-1)*size;                                              
                IQueryable<Vendidos> query = ccc.Vendidos;         
                return query.Skip(pular).Take(size).OrderBy(a => a.DataVenda).ToList();
            }
        }
        public int CountItemsVendas(){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){                
                IQueryable<Vendidos> query = ccc.Vendidos;      
                return query.Count();
            }
        }
        
        // ---------------------------------------------------------------------------

        public ICollection<MesResumo> ListarResumo(){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){                
                IQueryable<MesResumo> query = ccc.MesResumo;         
                return query.ToList();
            }
        }
        public void AdicionarResumo(MesResumo mr){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){                
                ccc.MesResumo.Add(mr);
                ccc.SaveChanges();
            }
        }
        public void AtualizarResumo(MesResumo mr){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                MesResumo mesResumo = ccc.MesResumo.Find(mr.Id);
                mesResumo.Quantidade = mr.Quantidade;
                mesResumo.Valor = mr.Valor;        
                ccc.SaveChanges();
            }
        }        
        public ICollection<MesResumo> MaxResumoPg(int page, int size){            
            using(CasaCosturaContext ccc = new CasaCosturaContext()){
                int pular = (page-1)*size;                                              
                IQueryable<MesResumo> query = ccc.MesResumo;         
                return query.Skip(pular).Take(size).ToList();
            }
        }
        public int CountItemsResumo(){
            using(CasaCosturaContext ccc = new CasaCosturaContext()){                
                IQueryable<MesResumo> query = ccc.MesResumo;      
                return query.Count();
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CasaCosturaCadastro.Models;

namespace CasaCosturaCadastro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger){
            _logger = logger;
        }

        public IActionResult Index(){
            ProdutoViewModel pvm = new ProdutoViewModel();
            ProdutoService produtoService = new ProdutoService();            
            pvm.Produtos = produtoService.ListarTodos();
            return View(pvm);
        }
        
        // public IActionResult Login(){
        //     return View();
        // }

        // [HttpPost]
        // public IActionResult Login(string login, string senha){            
        //     try{
        //         if(Autenticacao.CheckLoginSenha(login, senha, this)){
        //             return RedirectToAction("Index");
        //         } 
        //         else{
        //             ViewData["Erro"] = "Login ou senha inválidos";
        //             return View();
        //         }
        //     }catch(Exception e){
        //         _logger.LogError("Erro: " + e.Message);
        //         ViewData["Erro"] = "Login ou senha inválidos";
        //         return View();
        //     }
        // }

        // public IActionResult Logout(){
		// 	HttpContext.Session.Clear();            
        //     return RedirectToAction("Index");
	    // }


        [HttpPost]
        public IActionResult Cadastrar(Produto p){                        
            ProdutoService produtoService = new ProdutoService();
            produtoService.Cadastrar(p);                
            return RedirectToAction("Listagem", "Produtos");
        }

        [HttpPost]
        public IActionResult Costurar(Costura c){
            ProdutoService produtoService = new ProdutoService();
            produtoService.Costurar(c);
            return RedirectToAction("Costuras", "Produtos");
        }

        [HttpPost]
        public IActionResult Vender(int id, int qt, string descricao){
            ProdutoService produtoService = new ProdutoService();

            //Acrescentando esta venda a lista de vendidos
            Produto p = produtoService.ObterProdutoPorId(id); 
            Vendidos v = new Vendidos();
            v.Nome = p.Nome;
            v.Descricao = descricao;
            v.Tamanho = p.Tamanho;
            v.Valor = p.Valor;
            v.Quantidade = qt;
            v.DataVenda = DateTime.Now;
            produtoService.Vender(v);

            //Atualizar quantidade do Produto
            p.Quantidade -= qt;
            produtoService.AtualizarProduto(p);

            //Acrescentando esta venda ao resumo por mês
            ICollection<MesResumo> list = produtoService.ListarResumo();
            if(produtoService.CountItemsResumo() > 0){
                foreach (var mr in list){
                    if(v.DataVenda.Month == mr.Mes){
                        mr.Quantidade += v.Quantidade;
                        mr.Valor += (v.Valor * v.Quantidade);
                        produtoService.AtualizarResumo(mr);
                    }
                }   
            }else{
                MesResumo mr = new MesResumo();
                mr.Quantidade = v.Quantidade;
                mr.Valor = (v.Quantidade * v.Valor);
                produtoService.AdicionarResumo(mr);
            }

            return RedirectToAction("Vendidos", "Produtos");
        }
    }
}

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
    public class ProdutosController : Controller
    {
        private readonly ILogger<ProdutosController> _logger;

        public ProdutosController(ILogger<ProdutosController> logger){
            _logger = logger;
        }

        public IActionResult Listagem(int p=1){ 
            ProdutoService produtoService = new ProdutoService();            
            int qtPg = 15;            
            ICollection<Produto> list = produtoService.MaxProdutosPg(p, qtPg);             
            int qtReg = produtoService.CountItemsProdutos();
            ViewData["Pages"] = (int)Math.Ceiling((double)qtReg/qtPg);
            return View(list);
        }
        // [HttpPost]
        // public IActionResult Cadastrar(Produto p){                        
        //     ProdutoService produtoService = new ProdutoService();
        //     produtoService.Cadastrar(p);                
        //     return RedirectToAction("Listagem");
        // }
        public IActionResult Editar(int id){       
            ProdutoService produtoService = new ProdutoService();
            Produto p = produtoService.ObterProdutoPorId(id);      
            return View(p);
        }
        [HttpPost]
        public IActionResult Editar(Produto p){
            ProdutoService produtoService = new ProdutoService();
            produtoService.Editar(p);
            return RedirectToAction("Listagem");
        }

        // ---------------------------------------------------------------------------

        public IActionResult Costuras(int pg=1){ 
            ProdutoService produtoService = new ProdutoService();            
            int qtPg = 10;            
            ICollection<Costura> list = produtoService.MaxCosturasPg(pg, qtPg);             
            int qtReg = produtoService.CountItemsCosturas();
            ViewData["Pages"] = (int)Math.Ceiling((double)qtReg/qtPg);
            return View(list);
        }
        // [HttpPost]
        // public IActionResult Costurar(Costura c){
        //     ProdutoService produtoService = new ProdutoService();
        //     produtoService.Costurar(c);
        //     return RedirectToAction("Costuras");
        // }
        public IActionResult Atualizar(int id){       
            ProdutoService produtoService = new ProdutoService();
            Costura c = produtoService.ObterCosturaPorId(id);      
            return View(c);
        }
        [HttpPost]
        public IActionResult Atualizar(Costura c){
            ProdutoService produtoService = new ProdutoService();
            produtoService.Atualizar(c);
            return RedirectToAction("Costuras");
        }

        // ---------------------------------------------------------------------------
        
        public IActionResult Vendidos(int pg=1){ 
            ProdutoService produtoService = new ProdutoService();            
            int qtPg = 10;            
            ICollection<Vendidos> list = produtoService.MaxVendasPg(pg, qtPg);             
            int qtReg = produtoService.CountItemsVendas();
            ViewData["Pages"] = (int)Math.Ceiling((double)qtReg/qtPg);
            return View(list);
        }
        // [HttpPost]
        // public IActionResult Vender(int id, int qt, string descricao){
        //     ProdutoService produtoService = new ProdutoService();

        //     //Acrescentando esta venda a lista de vendidos
        //     Produto p = produtoService.ObterProdutoPorId(id); 
        //     Vendidos v = new Vendidos();
        //     v.Nome = p.Nome;
        //     v.Descricao = descricao;
        //     v.Tamanho = p.Tamanho;
        //     v.Valor = p.Valor;
        //     v.Quantidade = qt;
        //     v.DataVenda = DateTime.Now;
        //     produtoService.Vender(v);

        //     //Atualizar quantidade do Produto
        //     p.Quantidade -= qt;
        //     produtoService.AtualizarProduto(p);

        //     //Acrescentando esta venda ao resumo por mês
        //     ICollection<MesResumo> list = produtoService.ListarResumo();
        //     if(produtoService.CountItemsResumo() > 0){
        //         foreach (var mr in list){
        //             if(v.DataVenda.Month == mr.Mes){
        //                 mr.Quantidade += v.Quantidade;
        //                 mr.Valor += (v.Valor * v.Quantidade);
        //                 produtoService.AtualizarResumo(mr);
        //             }
        //         }   
        //     }else{
        //         MesResumo mr = new MesResumo();
        //         mr.Quantidade = v.Quantidade;
        //         mr.Valor = (v.Quantidade * v.Valor);
        //         produtoService.AdicionarResumo(mr);
        //     }

        //     return RedirectToAction("Vendidos");
        // }

        // ---------------------------------------------------------------------------
        
        public IActionResult MesResumo(int pg=1){ 
            ProdutoService produtoService = new ProdutoService(); 
            int qtPg = 10;            
            ICollection<MesResumo> list = produtoService.MaxResumoPg(pg, qtPg);             
            int qtReg = produtoService.CountItemsResumo();
            ViewData["Pages"] = (int)Math.Ceiling((double)qtReg/qtPg);
            return View(list);
        }

    }
}

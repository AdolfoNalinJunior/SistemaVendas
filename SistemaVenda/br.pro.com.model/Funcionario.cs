using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.br.pro.com.model
{
    public class Funcionario : Cliente
    {
        #region Campos
        /// <summary>
        /// Atributos da classe do obj
        /// </summary>
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string NivelAcesso { get; set; }
        #endregion
    }
}

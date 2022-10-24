//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Almoxarifado
{
    using System;
    using System.Collections.Generic;
    
    public partial class Atendimento
    {
        public int Id { get; set; }
        public Nullable<int> IdProduto { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> QuantidadeProdUsada { get; set; }
        public string NomePrestador { get; set; }
        public Nullable<System.DateTime> DataHoraFeita { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public Nullable<bool> Ativo { get; set; }
        public Nullable<System.DateTime> DataInclusao { get; set; }
        public Nullable<System.DateTime> DataAlteracao { get; set; }
        public Nullable<System.DateTime> DataExclusao { get; set; }
        public int IdServico { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}

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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Atendimentoes = new HashSet<Atendimento>();
            this.Servicoes = new HashSet<Servico>();
        }
    
        public int Id { get; set; }
        public string RazãoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public Nullable<int> CEP { get; set; }
        public Nullable<bool> Ativo { get; set; }
        public Nullable<System.DateTime> DataAlteracao { get; set; }
        public Nullable<System.DateTime> DataExclusao { get; set; }
        public Nullable<bool> Dependente { get; set; }
        public Nullable<int> IdMatrix { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Atendimento> Atendimentoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servico> Servicoes { get; set; }
    }
}

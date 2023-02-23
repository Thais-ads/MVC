namespace MVCI.Models
{
   // A tabela do banco de dados,
  // entity framework, comunicação com o banco.ele roda um codigo de migração no c# automatico.
    public class ContatoModel
    {   

        //codigo do contato vai receber um codigo sequencial automatico.
        
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Email { get; set; }

        public int Profissao { get; set; }



    }
}

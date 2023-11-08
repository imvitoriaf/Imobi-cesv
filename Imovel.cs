using System.Web.UI.WebControls;

namespace ImobCESV
{
    public class Imovel
    {


        internal string bairro;
        internal string endereco;
        internal string cidade;
        internal string cep;
        internal string numero;
        internal string referencia;
        internal string titulo;
        internal string ativo;
        internal string descricao;
        internal int quartos;
        internal string finalidade;
        internal string tipoimovel;
        internal int banheiro;
        internal int suite;
        internal int garagem;
        internal string areatotal;
        internal string valor;
        internal string tratar;
        internal string telefone;
        internal bool agua;
        internal bool lavanderia;
        internal bool alarme;
        internal bool academia;
        internal bool camera;
        internal bool churrasqueira;
        internal bool cerca;
        internal bool esgoto;
        internal bool playground;
        internal bool gas;
        internal bool piscina;
        internal bool portaria;
        internal bool quintal;
        internal bool quadra;
        internal bool sauna;
        internal bool wifi;

        public Imovel() { }

        public Imovel(string bairro, string endereco, string cidade, string cep, string numero, 
            string referencia, string titulo, string ativo, string descricao, int quartos, string finalidade,
            string tipoimovel, int banheiro, int suite, int garagem, string areatotal, string valor, string tratar, 
            string telefone, bool agua, bool lavanderia, bool alarme, bool academia, bool camera, bool churrasqueira, 
            bool cerca, bool esgoto, bool playground, bool gas, bool piscina, bool portaria, bool quintal, bool quadra, 
            bool sauna, bool wifi)
        {
            this.bairro = bairro;
            this.endereco = endereco;
            this.cidade = cidade;
            this.cep = cep;
            this.numero = numero;
            this.referencia = referencia;
            this.titulo = titulo;
            this.ativo = ativo;
            this.descricao = descricao;
            this.quartos = quartos;
            this.finalidade = finalidade;
            this.tipoimovel = tipoimovel;
            this.banheiro = banheiro;
            this.suite = suite;
            this.garagem = garagem;
            this.areatotal = areatotal;
            this.valor = valor;
            this.tratar = tratar;
            this.telefone = telefone;
            this.agua = agua;
            this.lavanderia = lavanderia;
            this.alarme = alarme;
            this.academia = academia;
            this.camera = camera;
            this.churrasqueira = churrasqueira;
            this.cerca = cerca;
            this.esgoto = esgoto;
            this.playground = playground;
            this.gas = gas;
            this.piscina = piscina;
            this.portaria = portaria;
            this.quintal = quintal;
            this.quadra = quadra;
            this.sauna = sauna;
            this.wifi = wifi;
        }
    }
}
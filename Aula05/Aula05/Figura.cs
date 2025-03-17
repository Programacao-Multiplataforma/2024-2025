namespace Aula05
{
    public class Figura
    {
        public string Nome { get; set; }
        public string Largura { get; set; }
        public string Altura { get; set; }

        // redefinição necessário pelo uso de objects como items na Listbox, mas dependência eliminada pelo uso do Template para os dados da ListBox
        //public override string ToString()
        //{
        //    return Nome + " [ " + Largura + ", " + Altura + "]";
        //}
    }
}

namespace ER3_EC1
{
    public abstract class Conta
    {
        public string ?numero { get; private set; }

        public string ?agencia { get; private set; }

        public double saldo {get; private set;}  

        public Conta(string argNumero, string argAgencia){
            // this.numero = argNumero;
            setNumero(argNumero);
            // this.agencia = argAgencia;
            setAgencia(argAgencia);
            setSaldo(0);
        }

       
        public void setNumero (string argNumero) {
            if (argNumero.Length >4){
                this.numero = argNumero;
            }
            else
            {
                this.numero = "Conta não válida";
            }
        }

        public void setAgencia(string argAgencia){
            if (argAgencia.Length > 2)
            {
                this.agencia = argAgencia;
            }
        }
      


        public void setSaldo(double argSaldo){
            this.saldo = argSaldo;
        }
        
        public abstract bool Sacar(double argValor);

        public bool Depositar(double argValor)
        {
            if (argValor > 0){
            this.saldo = this.saldo + argValor;
            return true;
            }
            else{
                return false;
            }
        }

        public string ToString(){
            string texto = "Agencia: " + this.agencia +
                            "\nNro. Conta: " + this.numero +
                            "\nSaldo: " + this.saldo;
            return texto;
        }

        /*
        Metodos 
        Possuem o modificador de visibilidade (public, private, protected....)
        retorno (bool, string, int, double, float, objeto de uma classe, lsita, void....)
        nome do método (padrão não é regra, mas é bom seguir, iniciais maiusculas e denotação ação....
        exemplo verbos no infinitivo.... Depositar, Sacar, Imprimir, Verificar, Calucular...etc)
        argumentos (são os valores, que podem existir ou não, para que um método funcione - precisa passar para o método funcionar. Chamamos de assinatura do método)
        */
    }   
}
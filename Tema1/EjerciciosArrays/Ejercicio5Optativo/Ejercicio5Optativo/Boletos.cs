using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Optativo
{
    //CHEQUEAR LO DE PRIVATE QUE LLAMO DIRECTAMENTE A NUMEROSBOLETO
    //HACER METODOS GET PARA OBTENER LOS NUMEROS DE ESA POSICION, Y SUSTITUIRLO SINMAS

    /* 
     public int ObtenerPosicion(int indice)
    {
    return numerosBoletos[indice];
    }
    */
    public class Boletos
    {
        int numeros = 6;
        //Atributo seran de 6 numeros array cada boleto sera un objetoque tendra diferente combinacion
        private int[] numerosBoleto;
        private int[] numerosOrdenadosComprobacion=new int[6];

        public Boletos()
        {
            this.numerosBoleto =new int[] { 0, 0, 0, 0, 0, 0 };
        }
        /*AQUI LE IntRODUCIMOS LOS NUMEROS AL OBJETO BOLETO QUE CREAMOS EN APP, no devuelve nada
    es para introducir numeros aleatorios a el array (propiedad) del objeto boleto*/
        public void CreacionNumerosBoleto()
        {
            Random rd = new Random();
            for (int i = 0; i < numerosBoleto.Length; i++)
            {   
                //Guardamos en un int el numero que se genera 
                bool numerosRepetidos;
                int numeroAleatorio;
                
                do
                {   
                    //guardams el numero generado en el entero
                    numerosRepetidos = false;
                    numeroAleatorio = rd.Next(1, 50);
                    //comprobamos desde 0 hasta donde este demomento generado el array(i) si existe ya
                    for (int j = 0; j < i; j++)
                    {
                        if (numerosBoleto[j] == numeroAleatorio)
                        {
                            numerosRepetidos = true;
                            break;
                        }
                    }
                } while (numerosRepetidos);//Se repite si se sigue encontrando repetidos

                numerosBoleto[i] = numeroAleatorio;//Si no se guarda
            }
        }
        //SOLO ME DEJO EL METODO EQUALS ME ESTA COSTANDO
        
             public override bool Equals(Object boleto)
             {
                Boletos boletoRecibido= (Boletos)boleto;
            
                //Y si ordeno metodo burbuja solo para comparar si son exactamente iguales, y luego
                //Uso equals que compara contenido?
                //GUardo en arrays auxiliar para no modifcar el otro
                for (int i = 0; i < numeros; i++)
                {
                    boletoRecibido.numerosOrdenadosComprobacion[i] = boletoRecibido.numerosBoleto[i];
                }
            //Este para el metodo que usa equals
            for (int i = 0; i < numeros; i++)
            {
                this.numerosOrdenadosComprobacion[i] = this.numerosBoleto[i];
            }
            /*Uso dos metodos burbujas para ordenar el array auxiliar del boleto que llama el metodo,
            y el array auxiliar del boleto que le paso, para luego comparar*/
            for (int i = 0; i < 6 - 1; i++)
            {

                for (int j = 0; j < 6 - i - 1; j++)
                {
                    if (boletoRecibido.numerosOrdenadosComprobacion[j] > boletoRecibido.numerosOrdenadosComprobacion[j + 1])
                    {
                        int temp = boletoRecibido.numerosOrdenadosComprobacion[j];
                        boletoRecibido.numerosOrdenadosComprobacion[j] = boletoRecibido.numerosOrdenadosComprobacion[j + 1];
                        boletoRecibido.numerosOrdenadosComprobacion[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < 6 - 1; i++)
            {

                for (int j = 0; j < 6 - i - 1; j++)
                {
                    if (this.numerosOrdenadosComprobacion[j] > this.numerosOrdenadosComprobacion[j + 1])
                    {
                        int temp = this.numerosOrdenadosComprobacion[j];
                        this.numerosOrdenadosComprobacion[j] = this.numerosOrdenadosComprobacion[j + 1];
                        this.numerosOrdenadosComprobacion[j + 1] = temp;
                    }
                }
            }
            if (this.numerosOrdenadosComprobacion.Equals(boletoRecibido.numerosOrdenadosComprobacion)){
                return true;
            }
            else
            {
                return false;
            }
        }
    
             
       
        //NO SE LE PASA NADA AL toString 
        public override string ToString()
        {
            string numerosStr = "";
            for (int i = 0; i < this.numerosBoleto.Length; i++)
            {
                numerosStr += this.numerosBoleto[i] + " ";
            }
            return numerosStr.Trim();
        }
    }
}


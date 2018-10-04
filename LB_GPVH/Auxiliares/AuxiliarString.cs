using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_GPVH.Auxiliares
{
    public static class AuxiliarString
    {
        public static string shit(String cadena)
        {
            string shit = "";

            for (int i = 0; i < cadena.Length; i++)
            {
                shit += (int)cadena[i]+" ";
            }

            return shit;

        }

        //Verifica el codigo ASCII de cada letra de la cadena y verifica que sus caracter sean valido en un contexto general
        public static bool ContieneCaracteresInvalidos(String cadena)
        {

            for (int i = 0; i < cadena.Length; i++)
            {
                int charACCII = (int)cadena[i];
                if (charACCII >= 65 && charACCII <= 90) //caracter del 'A' al 'Z', incluyendo al '@'
                {
                    continue;
                }

                if (charACCII >= 97 && charACCII <= 122) //caracter del 'a' al 'z'
                {
                    continue;
                }

                if (charACCII == 95) //caracter '_'
                {
                    continue;
                }

                if (charACCII == 32) //caracter [BARRA ESPACIADORA]
                {
                    continue;
                }

                if (charACCII == 46) //caracter '.'
                {
                    continue;
                }

                if (charACCII == 209) //caracter 'Ñ'
                {
                    continue;
                }

                if (charACCII == 241) //caracter 'ñ'
                {
                    continue;
                }

                return true;
            }

            return false;

        }



        //Verifica que los caracteres de la cadena pertenescan al alfabeto
        public static bool ContieneCaracteresAlfabeto(String cadena)
        {

            for (int i = 0; i < cadena.Length; i++)
            {
                int charACCII = (int)cadena[i];
                if (charACCII >= 65 && charACCII <= 91) //caracter del 'A' al 'Z'
                {
                    continue;
                }

                if (charACCII >= 97 && charACCII <= 122) //caracter del 'a' al 'z'
                {
                    continue;
                }

                if (charACCII == 209) //caracter 'Ñ'
                {
                    continue;
                }

                if (charACCII == 241) //caracter 'ñ'
                {
                    continue;
                }

                return false;
            }

            return true;

        }



    }
}

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

                if (charACCII >= 48 && charACCII <= 57) //caracter del '1' al '9'
                {
                    continue;
                }

                if (charACCII >= 64 && charACCII <= 90) //caracter del 'A' al 'Z', incluyendo al '@'
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

                if (charACCII == 44) //caracter ','
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
        public static bool ContieneCaracteresAlfabeto(String cadena, bool espacios)
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

                if (charACCII == 32 && espacios) //caracter [BARRA ESPACIADORA]
                {
                    continue;
                }

                return false;
            }

            return true;

        }

        //Verifica que los caracteres de la cadena pertenescan a numeros naturales (incluyendo al 0)
        public static bool EsNumerico(String cadena, bool espacios)
        {

            for (int i = 0; i < cadena.Length; i++)
            {
                int charACCII = (int)cadena[i];
                if (charACCII >= 48 && charACCII <= 57) //caracter del '0' al '9'
                {
                    continue;
                }

                return false;
            }

            return true;

        }

        //Verifica si un caracter es numerico
        public static bool EsNumerico(char caracter)
        {
            if (caracter >= 48 && caracter <= 57) //caracter del '0' al '9'
                return true;
            else
                return false;
        }




    }
}

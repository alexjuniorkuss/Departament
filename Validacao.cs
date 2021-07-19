﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Departamento.Models;

namespace Departamento
{
    class Validacao
    {
        public static string IssNotNull()
        {
            string texto = String.Empty;
            while (true)
            {
                texto = Console.ReadLine().Trim();
                if (texto.Equals(""))
                {
                    ModificaTexto.ColorRed("Digite um caracter válido!");
                }
                else
                {
                    break;
                }
            }
            return texto;
        }
        public static int IntBiggerZero()
        {
            int value = -1;
            while (value < 0)
            {
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    if (value < 0)
                    {
                        ModificaTexto.ColorRed("Invalid Value. Type Again:");

                    }
                }
                catch (FormatException)
                {
                    ModificaTexto.ColorRed("Invalid Characters. Type Again:");
                }
                catch (OverflowException)
                {
                    ModificaTexto.ColorRed("Invalid Number. Type Again:");
                }
            }
            return value;
        }
        public static decimal ValueMoney()
        {
            decimal value = 0;
            while (value == 0)
            {
                try
                {
                    value = Convert.ToDecimal(Console.ReadLine());
                    if (value < 0)
                    {
                        ModificaTexto.ColorRed("Invalid Value. Type Again:");
                    }
                }
                catch (FormatException)
                {
                    ModificaTexto.ColorRed("Invalid Characters. Type Again:");
                }
                catch (OverflowException)
                {
                    ModificaTexto.ColorRed("Invalid Number. Type Again:");
                }
            } 
            return value;
        }
    }
}

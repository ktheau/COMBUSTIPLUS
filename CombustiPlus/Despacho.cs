using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CombustiPlus
{
    public class Despacho
    {
        public int Numero { get; set; }
        public string Placa { get; set; }
        public string Combustible { get; set; }
        public decimal Galones { get; set; }
        public string Pago { get; set; }
        public decimal Total { get; set; }

        public Despacho(int numero, string placa, string combustible, decimal galones, string pago)
        {
            Numero = numero;
            Placa = placa;
            Combustible = combustible;
            Galones = galones;
            Pago = pago;
            Total = CalcularTotal();
        }

        private decimal CalcularTotal()
        {
            decimal precioBase = 0;

            // Definir precio por galon segun el combustible
            switch (Combustible)
            {
                case "Premium":
                    precioBase = 290.00m;
                    break;
                case "Regular":
                    precioBase = 272.00m;
                    break;
                case "Gasoil":
                    precioBase = 225.00m;
                    break;
            }

            decimal subtotal = (decimal)Galones * precioBase;

            // Regla 3 
            if (Galones >= 20)
            {
                subtotal = subtotal - (subtotal * 0.02m);
            }

            // Regla 4 y 5
            if (Pago == "Tarjeta")
            {
                subtotal = subtotal + (subtotal * 0.03m);
            }

            return subtotal;
        }

        public override string ToString()
        {
            // Formato para que se vea ordenado en el ListBox
            return $"{Numero:D2}, Placa: {Placa},  {Combustible}, {Galones} gal. , {Pago} , Total: RD$ {Total:N2}";
        }
    }














}


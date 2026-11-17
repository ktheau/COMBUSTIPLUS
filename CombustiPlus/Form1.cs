using System.Drawing.Imaging;
using System.Globalization;
namespace CombustiPlus
{
    public partial class frmCombustiPlus : Form
    {
        // lista donde se guardan todos los despachos del dia
        private List<Despacho> listaDespachos = new List<Despacho>();

        public frmCombustiPlus()
        {
            // para que los numeros salgan como 2,720.00 y 10.0
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            InitializeComponent();

            // r1: llenar los combobox
            cmbCombustible.Items.Add("Premium");
            cmbCombustible.Items.Add("Regular");
            cmbCombustible.Items.Add("Gasoil");
            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Tarjeta");
            cmbCombustible.SelectedIndex = 0;
            cmbPago.SelectedIndex = 0;
            
        }
        // r3: revisar que la placa tenga 7 caracteres y que los galones sean mas de 0
        private bool DatosValidos()
        {
            if (txtPlaca.Text.Length != 7)
            {
                MessageBox.Show("la placa debe tener 7 caracteres");
                return false;
            }

            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("los galones deben ser mas de 0");
                return false;
            }

            return true;
        }
        // r4: calcular el total y mostrar el detalle paso a paso
        private decimal Calcular()
        {
            string combustible = cmbCombustible.Text;
            decimal galones = nudGalones.Value;

            // buscar el precio segun el combustible
            decimal precio = 0;
            if (combustible == "Premium")
            {
                precio = 290.00m;
            }
            else if (combustible == "Regular")
            {
                precio = 272.00m;
            }
            else if (combustible == "Gasoil")
            {
                precio = 225.00m;
            }

            // limpiar la lista de detalle
            lstDetalle.Items.Clear();

            // multiplicar galones por precio
            decimal total = galones * precio;
            lstDetalle.Items.Add($"{galones:0.0} gal x RD$ {precio:N2} = RD$ {total:N2}");

            // si son 20 galones o mas, aplicar descuento del 2%
            if (galones >= 20)
            {
                total = total * 0.98m;
                lstDetalle.Items.Add($"Descuento 20+ galones -2 %: RD$ {total:N2}");
            }

            // si paga con tarjeta, sumar 3%
            if (cmbPago.Text == "Tarjeta")
            {
                total = total * 1.03m;
                lstDetalle.Items.Add($"Tarjeta +3 %: RD$ {total:N2}");
            }

            lstDetalle.Items.Add($"TOTAL: RD$ {total:N2}");
            return total;
        }

        // r4: boton cotizar
        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;
            Calcular();
        }

        // r5: guardar el despacho y mostrar el resumen
        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;

            decimal total = Calcular();

            Despacho despachou = new Despacho(
                listaDespachos.Count + 1,
                txtPlaca.Text,
                cmbCombustible.Text,
                (decimal)nudGalones.Value,
                cmbPago.Text
            );

            listaDespachos.Add(despachou);
            lstDespachos.Items.Add(despachou);

            ActualizarResumen();
        }

        // r5: recorrer la lista y mostrar el resumen
        private void ActualizarResumen()
        {
            decimal vendido = 0;
            decimal galones = 0;
            Despacho mayor = null;

            foreach (Despacho despachou in listaDespachos)
            {
                vendido = vendido + despachou.Total;
                galones = galones + despachou.Galones;

                if (mayor == null)
                {
                    mayor = despachou;
                }
                else if (despachou.Total > mayor.Total)
                {
                    mayor = despachou;
                }
            }

            if (mayor == null)
            {
                lblResumen.Text = "sin despachos";
            }
            else
            {
                lblResumen.Text = $"{listaDespachos.Count} despachos - Vendido RD$ {vendido:N2} - Galones {galones:0.0} - Mayor: #{mayor.Numero:00} {mayor.Placa} (RD$ {mayor.Total:N2})";
            }
        }

        // r6: sumar galones por combustible usando dictionary
        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> porCombustible = new Dictionary<string, decimal>();

            foreach (Despacho despachou in listaDespachos)
            {
                if (porCombustible.ContainsKey(despachou.Combustible))
                {
                    porCombustible[despachou.Combustible] = porCombustible[despachou.Combustible] + despachou.Galones;
                }
                else
                {
                    porCombustible[despachou.Combustible] = despachou.Galones;
                }
            }

           

            foreach (string combustible in porCombustible.Keys)
            {
                lstDetalle.Items.Add($"{combustible} {porCombustible[combustible]:0.0}");
            }
        }

        private void btnPorCombustible_Click_1(object sender, EventArgs e)
        {

        }
    }
}
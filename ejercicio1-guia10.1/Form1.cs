using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1_guia10._1
{
    public partial class Form1 : Form
    {
        int bicicleta;
        double distanciabici;
        int moto;
        double distanciamoto;
        int auto;
        int transportepublico;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double promediobici()
        {
            double promedio = 0;
            if (bicicleta > 0)
            {
               return distanciabici / bicicleta;
            }
            return 0;
        }
        double promediomoto()
        {
            if (moto > 0)
            {
                return distanciamoto / moto;
            }
            return 0;
        }
        int calcularpersonas()
        {
            return bicicleta + moto + auto + transportepublico;
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            double distancia = Convert.ToDouble(textdistancia.Text);
            if (btnradiobici.Checked)
            {
                bicicleta++;
                distanciabici += distancia;
            }
            else if (btnradiomoto.Checked)
            {
                moto++;
                distanciamoto += distancia;
            }
            else if (btnradioauto.Checked)
            {
                auto++;
            }
            else if (btnradiotp.Checked)
            {
                transportepublico++;
            }
            btnradiobici.Checked = false;
            btnradiomoto.Checked = false;
            btnradioauto.Checked = false;
            btnradiotp.Checked = false;
            textdistancia.Clear();
        }


        private void btnresultados_Click(object sender, EventArgs e)
        {
            listBoxresultado.Items.Clear();
            int poblacion = calcularpersonas();
            double prombici = promediobici();
            double prombmoto = promediomoto();
            listBoxresultado.Items.Add($"La poblacion: {poblacion}");
            listBoxresultado.Items.Add($"El promedio recorrido de bicicletas: {prombici}");
            listBoxresultado.Items.Add($"El promedio recorrido de motocicletas: {prombmoto}");
        }
    }
}




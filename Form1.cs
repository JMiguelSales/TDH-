using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tdh
{
    public partial class Form1 : Form
    {

        public int TempoAlvoPrincipal_Etapa1, TempoAlvoSecundario_Etapa1;
        public int TempoAlvoPrincipal_Etapa2, TempoAlvoSecundario_Etapa2, intervalo;
        public bool Cancelar=false;

        public Form1()
        {
            InitializeComponent();
        }
        public int RandomTempoAlvoPrincipal()
        {
            Random rnd = new Random();
            return rnd.Next(3000, 5000);
        }
        public int Secundario()
        {
    
            Random rnd = new Random();
            return rnd.Next(0, 2);
            
        }
        public async void teste1()// Brain & Development
        {
            CancellationTokenSource source = new CancellationTokenSource();
            
            PictureBox[] Pb = { SecundarioA, SecundarioB };
            int i = 1, Rnd;
            
            TempoAlvoSecundario_Etapa1 = 50;
            TempoAlvoPrincipal_Etapa2 = 3000;
            TempoAlvoSecundario_Etapa2 = 2000;
            intervalo = 1000;

            Pontos.Text = i.ToString();
            while (i < 31 && !Cancelar)
            {
                TempoAlvoPrincipal_Etapa1 = RandomTempoAlvoPrincipal();
                Rnd = Secundario();
                
                Principal.Visible = true;
                await Task.Delay(TempoAlvoPrincipal_Etapa1);
                Pb[Rnd].Visible = true;
                await Task.Delay(TempoAlvoSecundario_Etapa1);
                Pb[Rnd].Visible = false;
                if (Cancelar)
                    break;

                await Task.Delay(TempoAlvoPrincipal_Etapa2);
                Principal.Visible = false;
                await Task.Delay(intervalo);
                if (Cancelar)
                    break;

                Pb[Rnd].Visible = true;
                await Task.Delay(TempoAlvoSecundario_Etapa2);
                Pb[Rnd].Visible = false;
                await Task.Delay(intervalo);
                if (Cancelar)
                    break;

                i++;
                Pontos.Text = i.ToString();
            }
            Cancelar = false;
            Clean();
        }

        public async void teste2()
        {
            PictureBox[] Pb = { SecundarioA, SecundarioB };
            int[] Direcao = new int[2];//0 esquerda 1 Direita

            int intervalo2,i = 1, Rnd=0;
            TempoAlvoPrincipal_Etapa1 = 800;
            intervalo = 200;
            TempoAlvoSecundario_Etapa1 = 1000;
            intervalo2 = 1000;

            Pontos.Text = i.ToString();
            
            while (i < 41 && !Cancelar)
            {
                if(Direcao[0]<20 && Direcao[1] < 20)
                {
                    Rnd = Secundario();
                    Direcao[Rnd]++;
                }
                if (Direcao[0] == 20)
                    Rnd = 1;
                else if(Direcao[1] == 20)
                    Rnd = 0;

                Principal.Visible = true;
                await Task.Delay(TempoAlvoPrincipal_Etapa1);
                Principal.Visible = false;
                await Task.Delay(intervalo);
                if (Cancelar)
                    break;

                Pb[Rnd].Visible = true;
                await Task.Delay(TempoAlvoSecundario_Etapa1);
                Pb[Rnd].Visible = false;
                await Task.Delay(intervalo2);
                if (Cancelar)
                    break;

                i++;
                Pontos.Text=i.ToString();
            }
            Cancelar = false;
            Clean();
        }

        private void Clean()
        {
            Vr1.Enabled = true;
            Vr2.Enabled = true;
            Vr1.Visible = true;
            Vr2.Visible = true;
            tilte.Visible = true;
            Pontos.Text = "0";
            Stop.Visible = false;
            Stop.Enabled = false;
        }
        private void Vr1_Click(object sender, EventArgs e)
        {
            Vr1.Enabled = false;
            Vr2.Enabled=false;
            Vr1.Visible=false;
            Vr2.Visible=false;
            tilte.Visible=false;
            Stop.Visible = true;
            Stop.Enabled = true;
            teste1();
        }

        private void Vr2_Click(object sender, EventArgs e)
        {
            Vr1.Enabled = false;
            Vr2.Enabled = false;
            Vr1.Visible = false;
            Vr2.Visible = false;
            tilte.Visible = false;
            Stop.Visible = true;
            Stop.Enabled = true;
            teste2();
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            Cancelar = true;
        }
    }
}

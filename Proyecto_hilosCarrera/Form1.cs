using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Proyecto_hilosCarrera
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer fondo = new WindowsMediaPlayer();
        WindowsMediaPlayer mario =new WindowsMediaPlayer();
        WindowsMediaPlayer mcqueen =new WindowsMediaPlayer();

        Random random = new Random();
        public Thread engine1;
        public Thread engine2;
        public int recorrido1, recorrido2, meta;
        delegate void delegado(int x);
        delegate void delegado2(int x);
        public Form1()
        {
            InitializeComponent();
            Thread.CurrentThread.Name = "hilo main";
            recorrido1 = box_auto1.Location.X;
            recorrido2 = box_auto2.Location.X;
            meta = box_meta.Location.X-78;
        }



        public void proceso1() {
            while (true)
            {
                if (box_auto1.Location.X < meta)
                {

                    int random1 = random.Next(10, 50);
                    recorrido1 = recorrido1 + random1;
                    delegado MD = new delegado(actualizar1);
                    this.Invoke(MD, new object[] { recorrido1 });

                }
                else if (box_auto1.Location.X >=meta)
                {
                    lock (this)
                    engine2.Abort();
                    fondo.controls.stop();
                    mcqueen.URL = Application.StartupPath + @"\audios\queen_gana.mp3";
                    mario.URL = Application.StartupPath + @"\audios\mario_pierde.wav";
                    mcqueen.controls.play();
                    mario.settings.volume = 5;
                    mario.controls.play();
                    MessageBox.Show("Ganó McQueen");
                    engine1.Abort();
                    
            }

            Thread.Sleep(100);
            }
        }
            

        public void actualizar1(int x) {
            box_auto1.Enabled = false;
            box_auto1.Location = new Point(x, box_auto1.Location.Y);
            box_auto1.Enabled = true;
        }



        public void proceso2() {
            while (true)
            {
                if (box_auto2.Location.X < meta)
                {

                    int random2 = random.Next(10, 50);
                    recorrido2 = recorrido2 + random2;
                    delegado2 MD = new delegado2(actualizar2);
                    this.Invoke(MD, new object[] { recorrido2 });

                }
                else if (box_auto2.Location.X >= meta)
                {
                    lock(this)
                    
                    engine1.Abort();
                    fondo.controls.stop();
                    mario.URL = Application.StartupPath + @"\audios\mario_gana.wav";
                    mcqueen.URL = Application.StartupPath + @"\audios\queen_pierde.mp3";
                    mario.controls.play();
                    mcqueen.settings.volume = 9;
                    mcqueen.controls.play();
                    MessageBox.Show("Ganó Mario");
                    engine2.Abort(); 
                    
                }
                Thread.Sleep(100);
            }

        }

        private void Box_auto2_Click(object sender, EventArgs e)
        {

        }

        public void actualizar2(int x)
        {
            box_auto2.Enabled = false;
            box_auto2.Location = new Point(x, box_auto2.Location.Y);
            box_auto2.Enabled = true;
        }


        











        private void btn_Start_Click(object sender, EventArgs e)
        {
            fondo.URL = Application.StartupPath + @"\audios\1.10.mp3";
            fondo.settings.volume = 5;
            fondo.controls.play();
            engine1 = new Thread(new ThreadStart(proceso1));
            engine2 = new Thread(new ThreadStart(proceso2));
            engine1.Start();
            engine2.Start();
        }
    }
}

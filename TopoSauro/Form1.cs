using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TopoSauro
{
    public partial class TopoSauro : Form
    {
        string[] immagini = new string[] { "RocciaBassa.png", "RocciaAlta.png", "Uccellino.png" };
        bool[] BO = new bool[5];
        bool basso = false;
        bool c = true;
        int sfo = 0;
        int punteggio = 0;
        int p = 0;
        bool Morto = true;
        bool Again = true;
        int Record = 0;
        PictureBox[] Top = new PictureBox[3];
        PictureBox[] PO = new PictureBox[5];  // picturebox ostacolo
        Ostacolo[] O = new Ostacolo[5];  //ostacolo
        int no = 0;
        int d = 1;  //DIFFICOLTA = SPOSTAMENTO AL TICK
        Random rnd = new Random();
        System.Media.SoundPlayer Soundtrack = new System.Media.SoundPlayer("Soundtrack.wav");
        StreamReader sr;
        StreamWriter sw;
        public TopoSauro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Record.txt"))
            {
                sr = new StreamReader("Record.txt");
                Record = int.Parse(sr.ReadLine());
                record.Text = Record.ToString();
                sr.Close();
            }
            else
            {
                FileStream fs = File.Create("Record.txt");
                fs.Close();
                sw = new StreamWriter("Record.txt");
                sw.Write("0");
                sw.Close();
            }
            Top2.Location = new Point(790, 0);
            Top3.Location = new Point(1580, 0);
            Top[0] = Top1;
            Top[1] = Top2;
            Top[2] = Top3;
        }

        private void TickSfondo_Tick(object sender, EventArgs e)
        {
            if (sfo >= 800 && sfo <= 799 + d)
            {
                Top1.Location = new Point(Top3.Location.X + 790, 0);
            }
            if (sfo >= 1600 && sfo <= 1599 + d)
            {
                Top2.Location = new Point(Top1.Location.X + 790, 0);
            }
            if (sfo >= 2400 && sfo <= 2399 + d)
            {
                Top3.Location = new Point(Top2.Location.X + 790, 0);
                sfo = 0;
            }
            for (int i = 0; i < Top.Length; i++)
            {
                Top[i].Location = new Point(Top[i].Location.X - d, 0);
            }
            sfo = sfo + d;
        }

        private void Tick_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < O.Length; i++)
            {
                if(BO[i] == true)
                {
                    O[i].Sposta();
                    PO[i].Location = new Point(O[i].X(), O[i].Y());
                    if (basso == false)
                    {
                        if (HitBoxTopo.Bounds.IntersectsWith(PO[i].Bounds))
                        {
                            this.Morte();
                        }
                    }
                    else
                    {
                        if (HitBoxTopoBasso.Bounds.IntersectsWith(PO[i].Bounds))
                        {
                            basso = false;
                            Topo.Show();
                            TopoBasso.Hide();
                            Topo.Image = Image.FromFile("TopoSalto.png");
                            this.Morte();
                        }
                    }
                }
                p++;
                if (p >= 10)
                {
                    punteggio++;
                    Punteggio.Text = punteggio.ToString();
                    p = 0;
                }
            }
        }
        private void Respawn()
        {
            Morto = false;
            for (int i = 0; i < O.Length; i++)
            {
                if (BO[i] == true)
                {
                    this.Controls.Remove(PO[i]);
                    BO[i] = false;
                }
            }
            p = 0;
            no = 0;
            punteggio = 0;
            Topo.Location=new Point(0, 271);
            Continua.Hide();
            Topo.Image = Image.FromFile("Topo.gif");
            TickSfondo.Start();
            Soundtrack.PlayLooping();
            SpawnTick.Start();
            Tick.Start();
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Morto == true)
            {
                if (Again == true)
                {
                    this.Respawn();
                    Again = false;
                }
            }
            else
            {
                if (c == true)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Up:
                            Topo.Location = new Point(0, Topo.Location.Y - 20);
                            HitBoxTopo.Location = new Point(HitBoxTopo.Location.X, Topo.Location.Y);
                            c = false;
                            Topo.Image = Image.FromFile("TopoSalto.png");
                            Discesa.Stop();
                            Salto.Start();
                            break;
                        case Keys.Down:
                            basso = true;
                            c = false;
                            Topo.Hide();
                            TopoBasso.Show();
                            break;
                    }
                }
            }
        }

        private void Salto_Tick(object sender, EventArgs e)
        {
            if (Topo.Location.Y <= 163)
            {
                Salto.Stop();
                Discesa.Start();
            }
            else
            {
                Topo.Location = new Point(0, Topo.Location.Y - 5);
                HitBoxTopo.Location = new Point(HitBoxTopo.Location.X, Topo.Location.Y);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Morto == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    Salto.Stop();
                    Discesa.Start();
                }
                else
                {
                    Topo.Show();
                    TopoBasso.Hide();
                    c = true;
                    basso = false;
                }
            }
        }

        private void Discesa_Tick(object sender, EventArgs e)
        {
            if (Topo.Location.Y == 271)
            {
                c = true;
                Topo.Image = Image.FromFile("Topo.gif");
                Discesa.Stop();
            }
            else
            {
                Topo.Location = new Point(0, Topo.Location.Y + 5);
                HitBoxTopo.Location = new Point(HitBoxTopo.Location.X, Topo.Location.Y);
            }
        }

        private void SpawnTick_Tick(object sender, EventArgs e)
        {
            int l = 1;
            int r=rnd.Next(1, 4);
            if (no >= 5)
            {
                no = 0;
            }
            if (BO[no] == true)
            {
                this.Controls.Remove(PO[no]);
            }
            O[no] = new Ostacolo(r);
            if (r == 2)
            {
                l=21;
            }
            PO[no] = new PictureBox
            {
                Name = "PictureBox",
                Size = new Size(50, 49 + l),
                Location= new Point(O[no].X()-100, O[no].Y()),
                Image = Image.FromFile(immagini[r-1])
            };
            l = 1;
            this.Controls.Add(PO[no]);
            BO[no] = true;
            no++;
        }
        private void Morte()
        {
            Morto = true;
            Tick.Stop();
            TickSfondo.Stop();
            Salto.Stop();
            Discesa.Stop();
            SpawnTick.Stop();
            Soundtrack.Stop();
            Topo.Image = Image.FromFile("TopoSalto.png");
            p = 0;
            this.CheckRecord();
            AfterDeath.Start();
            Continua.Show();
        }
        private void CheckRecord()
        {
            if (punteggio > Record)
            {
                MessageBox.Show("Hai Superato Il Record");
                sw = new StreamWriter("Record.txt");
                sw.Write(punteggio.ToString());
                sw.Close();
                record.Text = Punteggio.Text;
                Record = punteggio;
            }
        }

        private void AfterDeath_Tick(object sender, EventArgs e)
        {
            Again = true;
            AfterDeath.Stop();
        }
    }
}

using Subsecsum.ROUTINES;
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

namespace Subsecsum
{
    public partial class vista : Form
    {
        private Int64[] arrburbuja;
        private Int64[] arrshaker;
        private Int64[] arrinsertion;
        private Int64[] arrshell;
        private Int64[] arrheap;
        private Int64[] arrmerge;
        private Int64[] arrquick;
        private Int64[] arrintro;     

        private Thread t1;
        private Thread t2;
        private Thread t3;
        private Thread t4;
        private Thread t5;
        private Thread t6; 
        private Thread t7;
        private Thread t8;

        private Stopwatch s1, s2, s3, s4, s5, s6, s7, s8;


        private bool flag = false;


        public vista(Int64 [] arr, bool flag)
        {
            InitializeComponent();

            this.flag = flag;

            this.ShowIcon = false;

            this.arrburbuja = new Int64[arr.Length];

            Array.Copy(arr, this.arrburbuja, arr.Length);

            this.arrshaker = new Int64[arr.Length];

            Array.Copy(arr, this.arrshaker, arr.Length);

            this.arrinsertion = new Int64[arr.Length];

            Array.Copy(arr, this.arrinsertion, arr.Length);

            this.arrshell = new Int64[arr.Length];

            Array.Copy(arr, this.arrshell, arr.Length);

            this.arrheap = new Int64[arr.Length];

            Array.Copy(arr, this.arrheap, arr.Length);

            this.arrquick = new Int64[arr.Length];

            Array.Copy(arr, this.arrquick, arr.Length);

            this.arrmerge = new Int64[arr.Length];

            Array.Copy(arr, this.arrmerge, arr.Length);

            this.arrintro = new Int64[arr.Length];

            Array.Copy(arr, this.arrintro, arr.Length);

            this.MaximizeBox = false;

            this.s1 = new Stopwatch();
            this.s2 = new Stopwatch();
            this.s3 = new Stopwatch();
            this.s4 = new Stopwatch();
            this.s5 = new Stopwatch();
            this.s6 = new Stopwatch();
            this.s7 = new Stopwatch();
            this.s8 = new Stopwatch();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Resultados para "+ arr.Length.ToString()+" Elementos";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
        }

        
        private void ocho(ref Int64 [] arrocho)
        {
            this.s8.Reset();
            this.s8.Start();
            rutinasX.intro(ref arrocho);
            this.s8.Stop();

            var send = arrocho;

            this.Invoke(new MethodInvoker(delegate ()
            {
                this.lblintro.Text = this.s8.Elapsed.ToString();
                this.showvals(this.intro, ref send);

            }));
        }
        private void siete(ref Int64 [] arrsiete)
        {
            this.s7.Reset();
            this.s7.Start();
            rutinasX.quick(ref arrsiete);
            this.s7.Stop();

            var send = arrsiete;

            this.Invoke(new MethodInvoker(delegate () {
                this.lblquick.Text = this.s7.Elapsed.ToString();
                this.showvals(this.quick, ref send);
            }));
        }

        private void seis(ref Int64[] arrseis)
        {
            this.s6.Reset();
            this.s6.Start();
            rutinasX.merge(ref arrseis);
            this.s6.Stop();

            var send = arrseis;

            this.Invoke(new MethodInvoker(delegate () {

                this.showvals(this.merge, ref send);
                this.lblmerge.Text = this.s6.Elapsed.ToString();

            }));
        }

        private void cinco(ref Int64[] arrcinco)
        {
            this.s5.Reset();
            this.s5.Start();
            rutinasX.heap(ref arrcinco);
            this.s5.Stop();

            var send = arrcinco;


            this.Invoke(new MethodInvoker(delegate () {
                this.lblheap.Text = this.s5.Elapsed.ToString();
                this.showvals(this.heap, ref send);
            }));
        }

        private void cuatro(ref Int64[] arrcuatro)
        {
            this.s4.Reset();
            this.s4.Start();
            rutinasX.shell(ref arrcuatro);
            this.s4.Stop();

            var send = arrcuatro;


            this.Invoke(new MethodInvoker(delegate () {
                this.lblshell.Text = this.s4.Elapsed.ToString();
                this.showvals(this.shell, ref send);
            }));


        }

        private void tres(ref Int64[] arrtres)
        {
            this.s3.Reset();
            this.s3.Start();
            rutinasX.insertion(ref arrtres);
            this.s3.Stop();

            var send = arrtres;

            this.Invoke(new MethodInvoker(delegate () {
                this.label3.Text = this.s3.Elapsed.ToString();
                this.showvals(this.insertion, ref send);
            }));


        }

        private void dos(ref Int64[] arrdos)
        {
            this.s2.Reset();
            this.s2.Start();
            rutinasX.shaker(ref arrdos);
            this.s2.Stop();

            var send = arrdos;

            this.Invoke(new MethodInvoker(delegate () {
                this.label2.Text = this.s2.Elapsed.ToString();
                this.showvals(this.shaker, ref send);
            }));
        }

        private void uno(ref Int64[] arruno)
        {
            this.s1.Reset();
            this.s1.Start();
            rutinasX.burbuja(ref arruno);
            this.s1.Stop();

            var send = arruno;

            this.Invoke(new MethodInvoker(delegate () {
                this.label1.Text = this.s1.Elapsed.ToString();
                this.showvals(this.burbuja,ref send);
            }));

        }
    
        private void vista_Load(object sender, EventArgs e)
        {
            if (this.flag)
            {
                this.t1 = new Thread(new ThreadStart(() => {

                this.uno(ref this.arrburbuja);
                    
                })) { IsBackground = true };


                this.t2 = new Thread(new ThreadStart(() => {
                    this.dos(ref this.arrshaker);

                })) { IsBackground = true };


                this.t3 = new Thread(new ThreadStart(() => {

                    this.tres(ref this.arrinsertion);

                } )) { IsBackground = true };

                this.t4 = new Thread(new ThreadStart(() =>
                {

                    this.cuatro(ref this.arrshell);

                })){ IsBackground = true};

                this.t5 = new Thread(new ThreadStart(() =>
                {

                    this.cinco(ref this.arrheap);

                })){IsBackground = true };

                this.t6 = new Thread(new ThreadStart(() =>
                {

                    this.seis(ref this.arrmerge);

                })) { IsBackground = true };


                this.t7 = new Thread(new ThreadStart(() =>
                {

                    this.siete(ref this.arrquick);

                })){IsBackground = true };

                this.t8 = new Thread(new ThreadStart(() =>
                {

                    this.ocho(ref this.arrintro);

                }))
                { IsBackground = true };


                Application.DoEvents();
                this.t1.Start();
                this.t2.Start();
                this.t3.Start();
                this.t4.Start();
                this.t5.Start();
                this.t6.Start();
                this.t7.Start();
                this.t8.Start();
            }
            else
            {
                this.t1 = new Thread(new ThreadStart(() =>
                {
                    this.uno(ref this.arrburbuja);
                    this.dos(ref this.arrburbuja);
                    this.tres(ref this.arrburbuja);
                    this.cuatro(ref this.arrburbuja);
                    this.cinco(ref this.arrburbuja);
                    this.seis(ref this.arrburbuja);
                    this.siete(ref this.arrburbuja);
                    this.ocho(ref this.arrburbuja);
                }));

                Application.DoEvents();
                this.t1.Start();
            }

            /*
            this.showvals(this.burbuja, this.arrburbuja);
            this.showvals(this.shaker, this.arrshaker);
            this.showvals(this.insertion, this.arrinsertion);*/
        }

        private void showvals(RichTextBox rtb, ref Int64[] arr)
        {
            var arrx = arr;

            if (rtb.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate () {
                    rtb.Text = "";
                    for (int x = 0; x < arrx.Length; ++x)
                    {
                        if (x == (arrx.Length - 1))
                        {                            
                            rtb.Text += arrx[x].ToString();
                        }
                        else
                        {
                            rtb.Text += arrx[x].ToString() + " , ";
                        }
                    }
                }));
            }
            else
            {
                rtb.Text = "";
                for (int x = 0; x < arrx.Length; ++x)
                {
                    if (x == (arrx.Length - 1))
                    {                        
                        rtb.Text += arrx[x].ToString();
                    }
                    else
                    {
                        rtb.Text += arrx[x].ToString() + " , ";
                    }
                }
            }

        }
    }
}

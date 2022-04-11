using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpGL.SceneGraph.Assets;
using SharpGlWinForm.Storage;
using System.Threading;

namespace SharpGlWinForm
{
    public partial class Form1 : Form
    {
        ///
        OpenGL openGL;
        
        Car car;
        Queue<Car> cars;


        public Form1()
        {
            InitializeComponent();
            openGL = this.openGLControl1.OpenGL;
            car = new Car(openGL);
            cars = new Queue<Car>();
            
        }

        private void openGLControl1_GDIDraw(object sender, RenderEventArgs args)
        {
            label1.Text = cars.Count.ToString();
            openGL.Clear(OpenGL.GL_COLOR_BUFFER_BIT);
            openGL.Clear(OpenGL.GL_DEPTH_BUFFER_BIT);
            openGL.LoadIdentity();  
            foreach (Car car in cars)
            {
                car.Draw();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cars.Enqueue(new Car(openGL));
            
        }
    }

     
    }


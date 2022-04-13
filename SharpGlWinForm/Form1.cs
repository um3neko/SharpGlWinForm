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
        OpenGL op;
        Map map;
        
        public Form1()
        {
            InitializeComponent();
            op = this.openGLControl1.OpenGL;
            map = new Map(op);
            
        }

        private void openGLControl1_GDIDraw(object sender, RenderEventArgs args)
        {
            map.StartMap();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
        }

        
    }

     
    }


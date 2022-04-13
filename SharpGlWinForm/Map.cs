using SharpGL;
using SharpGL.SceneGraph.Assets;
using SharpGlWinForm.Storage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGlWinForm
{
    internal class Map
    {
        OpenGL openGl;
        Bitmap grass;
        Bitmap water;
        Texture grassTex = new Texture();
        Texture waterTex = new Texture();
        Ship ship;
        Train train;
        Car car;

        public Map(OpenGL gl)
        {
            openGl = gl;
            openGl.Enable(OpenGL.GL_TEXTURE_2D);
            grass = new Bitmap(@"C:\Users\debb6\Desktop\SharpGlWinForm\SharpGlWinForm\Resources\Grass.png");
            water = new Bitmap(@"C:\Users\debb6\Desktop\SharpGlWinForm\SharpGlWinForm\Resources\Water.png");
            grassTex.Create(openGl, grass);
            waterTex.Create(openGl, water);
            ship = new Ship(openGl);
            train = new Train(openGl);
            car = new Car(openGl);
        }

        public void StartMap()
        {
            Cleaner();
            DrawMap();
            ship.Start();
            
            train.Start();

            car.Start();

        }

        private void Cleaner()
        {
            openGl.Clear(OpenGL.GL_COLOR_BUFFER_BIT);
            openGl.Clear(OpenGL.GL_DEPTH_BUFFER_BIT);
            openGl.LoadIdentity();
            openGl.Translate(-0.5f, 0f, -2.25f);
            
        }

        private void DrawMap()
        {
            grassTex.Bind(openGl);
            openGl.Color(1.0f, 1.0f, 1.0f);
            openGl.PushMatrix();
            openGl.Begin(OpenGL.GL_QUADS);
            openGl.TexCoord(1.0f, 0.0f); openGl.Vertex(1.0f, 1.0f, 0.0f);
            openGl.TexCoord(1.0f, 1.0f); openGl.Vertex(1.0f, -1.0f, 0.0f);
            openGl.TexCoord(0.0f, 1.0f); openGl.Vertex(-1.0f, -1.0f, 0.0f);
            openGl.TexCoord(0.0f, 0.0f); openGl.Vertex(-1.0f, 1.0f, 0.0f);
            openGl.End();
            waterTex.Bind(openGl);
            openGl.Translate(1.0f, 0.0f, 0.0f);
            openGl.Begin(OpenGL.GL_QUADS);
            openGl.TexCoord(1.0f, 0.0f); openGl.Vertex(1.0f, 1.0f, 0.0f);
            openGl.TexCoord(1.0f, 1.0f); openGl.Vertex(1.0f, -1.0f, 0.0f);
            openGl.TexCoord(0.0f, 1.0f); openGl.Vertex(0.0f, -1.0f, 0.0f);
            openGl.TexCoord(0.0f, 0.0f); openGl.Vertex(0.0f, 1.0f, 0.0f);
            openGl.End();
            openGl.PopMatrix();

        }
    }
}

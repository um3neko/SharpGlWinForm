using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGlWinForm.Storage
{
    internal class Ship : AbstractTransport
    {
        OpenGL openGl;

        public float CurrentX { get; }
        public float CurrentY { get; }


        public Ship(OpenGL gl)
        {
            this.isFool = false;
            this.Buf = 0;
            openGl = gl;
            CurrentX = currentX;
            CurrentY = currentY;
            this.currentX = 5.0f;
            this.currentY = -5.0f;
        }

        public override void Start()
        {
            this.Move();
            this.Draw();
        }

        protected override void Move()
        {
            
            openGl.PushMatrix();  
            openGl.Translate(5.0f, -10.0f, 0.0f);
            if (this.currentY < 0)
            {
                this.currentY += 0.05f;
            }
            if (this.currentY < 10.0f && isFool)
            {
                this.currentY += 0.05f;
            }
            openGl.PopMatrix();
        }

        protected override void Draw()
        {
            openGl.PushMatrix();
            openGl.Color(1.0f, 0.0f,0.0f);
            openGl.Translate(1.45f, currentY, 0.25f);
            openGl.Scale(0.5f, 0.7f, 0.5f);
            openGl.Begin(OpenGL.GL_QUADS);
            openGl.Vertex(-0.25f, 0.8f);
            openGl.Vertex(-0.25f, -0.8f);
            openGl.Vertex(0.25f, -0.8f);
            openGl.Vertex(0.25f, 0.8f);
            openGl.End();
            openGl.Begin(OpenGL.GL_TRIANGLES);
            openGl.Vertex(-0.25f, 0.8f);
            openGl.Vertex(0.25f, 0.8f);
            openGl.Vertex(0.0f, 1.0f);
            openGl.End();
            openGl.Begin(OpenGL.GL_TRIANGLES);
            openGl.Vertex(-0.25f, -0.8f);
            openGl.Vertex(0.25f, -0.8f);
            openGl.Vertex(0.0f, -1.0f);
            openGl.End();
            openGl.PopMatrix();
        }

        protected override void Load()
        {
            base.Load();
        }

    }
}

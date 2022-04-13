using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGlWinForm.Storage
{
    internal class Train : AbstractTransport
    {
        OpenGL openGl;
        
        public Train(OpenGL gL)
        {
            isFool = true;
            openGl = gL;
            currentY = -0.85f;
            currentX = -1.5f;
        }
        public override void Start()
        {
            this.Move();
            this.CreateTrain();
        }

        protected override void Move()
        {
            openGl.Translate(currentX, currentY, 0.0f);
            openGl.PushMatrix();
            if (currentX < 0.75f)
            {
                currentX += 0.02f;
            }
            if (currentX > 1.5f && !isFool)
            {
                currentX += 0.02f;
            }
            openGl.PopMatrix();
        }

        private void CreateTrain()
        {   
            openGl.PushMatrix();
            this.Draw();
            openGl.Translate(-0.25f, 0.0f, 0.0f);
            this.Draw();
            openGl.Translate(-0.25f, 0.0f, 0.0f);
            this.Draw();
            openGl.Translate(-0.25f, 0.0f, 0.0f);
            this.Draw();
            openGl.PopMatrix();
            
        }
        protected override void Draw()
        {
            openGl.PushMatrix();
            openGl.Scale(0.10f, 0.10f, 0.10f);
            openGl.Begin(OpenGL.GL_QUADS);
            openGl.Color(1.0f, 1.0f, 0.0f);
            openGl.Vertex(1.0f, 0.5f, 0.0f);
            openGl.Vertex(-1.0f, 0.5f, 0.0f);
            openGl.Vertex(-1.0f, 0.0f, 0.0f);
            openGl.Vertex(1.0f, 0.0, 0.0f);
            openGl.End();

            openGl.PopMatrix();

        }

        

    }
}

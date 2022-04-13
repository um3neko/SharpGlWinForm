using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace SharpGlWinForm.Storage
{
    internal class Car : AbstractTransport
    {
        OpenGL openGl;

        public Car(OpenGL gl)
        {
            this.Buf = 25;

            openGl = gl;
            this.currentX = -1.0f;
            this.currentY = 1.6f;


        }


        public override void Start()
        {
            this.Move();
            this.Draw();
        }
        /// <summary>
        /// //openGl.Translate(0.0f, 0.0f, -10.0f);
        //openGl.Translate(-9.0f, 3.0f, 0.0f);
        //openGl.Translate(currentX, currentY, 0);
        //if (currentX > 4.0f)
        //{
        //    openGl.Rotate(-90, 0.0f, 0.0f, 1.0f);
        //}

        //if (currentX < 4.0f && currentY < -4.0f)
        //{
        //    openGl.Rotate(180, 0.0f, 0.0f, 1.0f);
        //}
        //}
        /// </summary>
        /// 

        protected override void Move()
        {
            openGl.Translate(this.currentX, this.currentY, 0.0f);
            openGl.PushMatrix();
            if (this.currentX < -0.2f && this.currentY == 1.6f)
            {
                this.currentX += 0.1f;
            }

            if (this.currentX > 0.2f && this.currentY > 0.0f)
            {
                this.currentY -= 0.1f;
            }

            if (this.currentX > 0 && this.currentY < -4.0f)
            {
                this.currentX -= 0.1f;

            }
            openGl.PopMatrix();
        }

        protected override void Draw()
        {
            openGl.PushMatrix();
            openGl.Scale(0.05f, 0.05f, 0.05f);
            openGl.Begin(OpenGL.GL_TRIANGLE_FAN);
            openGl.Color(1.0f, 0.0f, 0.0f);
            openGl.Vertex(-1.0f, 0.5f, 0.0f);
            openGl.Vertex(1.0f, 0.5f, 0.0f);
            openGl.Vertex(1.0f, -0.5f, 0.0f);
            openGl.Vertex(-1.0f, -0.5f, 0.0f);
            openGl.End();
            openGl.Begin(OpenGL.GL_TRIANGLE_FAN);
            openGl.Color(1.0f, 1.0f, 0.0f);
            openGl.Vertex(1.0f, 0.25f, 0.0f);
            openGl.Vertex(1.5f, 0.25f, 0.0f);
            openGl.Vertex(1.5f, -0.25f, 0.0f);
            openGl.Vertex(1.0f, -0.25f, 0.0f);
            openGl.End();
            openGl.PopMatrix();
        }

        
    }
}

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
    internal class Car : AbstractStorage
    {

        OpenGL openGl;
        public Car(OpenGL gl)
        {
            this.Buf = 25;
            openGl = gl;
            
        }

        private  float moveX = 0;
        private  float moveY = 0;
        public  void Draw()
        {
            openGl.PushMatrix();
            openGl.Translate(0.0f, 0.0f, -10.0f);
            openGl.Translate(-9.0f, 3.0f, 0.0f);
            openGl.Translate(moveX, moveY, 0);
            if (moveX > 4.0f)
            {
                openGl.Rotate(-90, 0.0f, 0.0f, 1.0f);
            }

            if (moveX < 4.0f && moveY < -4.0f)
            {
                openGl.Rotate(180, 0.0f, 0.0f, 1.0f);
            }

            openGl.Begin(OpenGL.GL_TRIANGLE_FAN);
            openGl.Color(1.0f, 0.0f, 0.0f);
            openGl.Vertex(0.0f, 0.0f, 0.0f);
            openGl.Vertex(0.0f, 0.2f, 0.0f);
            openGl.Vertex(0.4f, 0.2f, 0.0f);
            openGl.Vertex(0.4f, 0.0f, 0.0f);
            openGl.End();
            openGl.Begin(OpenGL.GL_TRIANGLE_FAN);
            openGl.Color(1.0f, 1.0f, 0.0f);
            openGl.Vertex(0.4f, 0.15f, 0.0f);
            openGl.Vertex(0.4f, 0.05f, 0.0f);
            openGl.Vertex(0.5f, 0.05f, 0.0f);
            openGl.Vertex(0.5f, 0.15f, 0.0f);

            if (moveX < 4.0f && moveY == 0)
            {
                moveX += 0.1f;
            }

            if (moveX > 4.0f && moveY > -4.0f)
            {
                moveY -= 0.1f;
            }

            if (moveX > 0 && moveY < -4.0f)
            {
                moveX -= 0.1f;
            }

            openGl.End();
            openGl.PopMatrix();
            openGl.Flush();

        }

        
    }
}

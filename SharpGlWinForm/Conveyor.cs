using SharpGL;
using SharpGlWinForm.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGlWinForm
{
    internal class Conveyor : AbstractTransport
    {
        OpenGL openGl;
        public Conveyor(OpenGL gl)
        {
            this.Buf = 25;
            this.CurrentBuf = 0;
            isFool = false;
            openGl = gl;
        }

        protected override void Draw()
        {
            if (isFool)
            {

            }
            if (!isFool)
            {

            }
        }
        
    }
}

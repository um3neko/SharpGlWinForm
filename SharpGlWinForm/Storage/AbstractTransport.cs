using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGlWinForm.Storage
{
    internal abstract class AbstractTransport
    {
        protected int Buf { get; set; }
        protected int CurrentBuf { get; set; }
        protected bool isFool;

        protected float currentX;
        protected float currentY;


        public virtual void Start()
        {
            Move();
            Draw();
        }

        protected virtual void Move()
        {
            
        }

        protected virtual void Draw()
        {

        }

        protected virtual void Upload()
        {

        }
        
        protected virtual void Load()
        {

        }

    }
}

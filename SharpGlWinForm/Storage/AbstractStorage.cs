using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGlWinForm.Storage
{
    internal abstract class AbstractStorage
    {
        protected int Buf { get; set; }

        protected float _CurrentXPlace;
        protected float _CurrentYPlace;


        public virtual void Move()
        {

        }

        public virtual void ThisDraw()
        {

        }
    }
}

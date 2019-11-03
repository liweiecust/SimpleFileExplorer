using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileExplorer.Commands
{
    public interface IHellp
    {
        void Method();
        void Method2();
    }

    public abstract class Class4:IHellp
    {
        void IHellp.Method() { }// public modifier is not suitable here
        public void Method2() { }
       
    }
    public abstract class Class1
    {
        public virtual void Me() { }

        protected abstract void Method();
    }
    public class Class2:Class1
    {
        public override void Me() { }
        protected override void Method()
        {

        }
    }
    public class Class3:Class2
    {
        public override void Me() { }
    }

    public class Class6 : IHellp
    {
        void IHellp.Method()
        {
            Method();
        }

        void IHellp.Method2()
        {
            throw new NotImplementedException();
        }
      public void Method()
        {
            
        }
    }
    

}

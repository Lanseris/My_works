using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class MyException:Exception
    {

        public MyException()
        {
            System.Windows.Forms.MessageBox.Show(base.Message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InheritianceVirtualOverride
{
    public class A
    {
        public int var = 7;
        public virtual string m1()
        {
            return "A m1, ";
        }

        public string m2()
        {
            return "A m2, ";
        }

        public virtual string m3()
        {
            return "A m3, ";
        }
    }

    public class B : A
    {
        public override string m1()
        {
            return "B m1, ";
        }
    }

    public class C : B
    {
        public override string m3()
        {
            return "C m3, " + (var + 6);
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            A a = new A();
            B b = new B();
            C c = new C();
            A a2 = new C();
            string result = "";

            result += b.m1();
            result += c.m2();
            result += a.m3();
            System.Windows.Forms.MessageBox.Show(result);

            result = "";
            result += c.m1();
            result += c.m2();
            result += c.m3();
            System.Windows.Forms.MessageBox.Show(result);

            result = "";
            result += a.m1();
            result += b.m2();
            result += c.m3();
            System.Windows.Forms.MessageBox.Show(result);

            result = "";
            result += a2.m1();
            result += a2.m2();
            result += a2.m3();
            System.Windows.Forms.MessageBox.Show(result);

        }
    }
}

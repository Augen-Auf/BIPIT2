using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Threading;

namespace БИПиТ2
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        static double[] sum;
        [WebMethod]
        public double Calculate(double N, int M)
        {
            double total = 0;
            sum = new double[M];
            Thread[] thread = new Thread[M];

            for (int i = 0; i < M; i++)
            {
                Rectan r = new Rectan(i, N, M);
                thread[i] = new Thread(new ThreadStart(r.Rectangle));
                thread[i].Start();
            }

            for (int i = 0; i < M; i++)
                thread[i].Join();

            for (int i = 0; i < M; i++)
                total += sum[i];
            return total;
        }

        public class Rectan
        {
            double n;
            int m;
            int num;
            double a = 1;
            double b = 2;

            public Rectan(int _num, double _n, int _m)
            {
                num = _num;
                n = _n;
                m = _m;
            }

            public void Rectangle()
            {
                double F, xi, S = 0, h = (b - a) / n;
                for (int i = num; i < n; i += m)
                {
                    xi = a + i * h;
                    F = 1 / Math.Pow((Math.Pow(xi, 2) + 1), 2);
                    S += F * h;
                }
                sum[num] = S;
            }
        }
    }
}

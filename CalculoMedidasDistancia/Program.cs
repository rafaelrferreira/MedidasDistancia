using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoMedidasDistancia {
    class Program {
        static void Main(string[] args) {
            //A = (Xa, Ya) 
            //B = (Xb, Yb)
            //d² = (Xa-Xb)² + (Ya-Yb)² 
            //d = raiz ( (Xa-Xb)² + (Ya-Yb)² )

            Point pA = new Point();
            pA.X = 7;
            pA.Y = 6;

            Point pB = new Point();
            pB.X = 1;
            pB.Y = 3;

            Console.WriteLine(pA.X);
            Console.WriteLine(pA.Y);
            Console.WriteLine(pB.X);
            Console.WriteLine(pB.Y);

            //A Distância Euclidiana é definida como a soma da raiz quadrada da diferença entre x e y em suas respectivas dimensões.
            //Distância Euclideana: √((x1 – x2)² + (y1 – y2)²).
            double distEuclideana = Math.Sqrt((pA.X-pB.X)^2 + (pA.Y - pB.Y)^2);
            Console.WriteLine("Distância Euclideana: " + distEuclideana);

            //Já a Distância Manhattan tem uma definição mais simples na qual é apenas a soma das diferenças entre x e y em cada dimensão.
            //Distância Manhattan: | x1 – x2 | + | y1 – y2 |.
            double distManhattan = Math.Abs(pA.X - pB.X) + Math.Abs(pA.Y - pB.Y);
            Console.WriteLine("Distância Manhattan:" + distManhattan);

            Console.ReadLine();

            //LINKS
            //https://mineracaodedados.wordpress.com/tag/distancia-euclidiana/
            //https://br.answers.yahoo.com/question/index?qid=20110312044205AA2ejxM
        }
    }
}

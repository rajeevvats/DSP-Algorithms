﻿using DSPAlgorithms.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSPAlgorithms.Algorithms
{
    public class DCT: Algorithm
    {
        public Signal InputSignal { get; set; }
        public Signal OutputSignal { get; set; }

        public override void Run()
        {
            List<float> result = new List<float>();
            double summation = 0;
            for (int k = 0; k < InputSignal.Samples.Count; k++)
            {
                for (int n = 0; n < InputSignal.Samples.Count; n++)
                {
                    summation += ( InputSignal.Samples[n] )*(Math.Cos( (Math.PI*( (2*n)-1 )*( (2*k)-1 ))/(float)(4*InputSignal.Samples.Count) ));
                }
                result.Add( (float)(Math.Sqrt(2/(float)InputSignal.Samples.Count)*summation) );
                summation = 0;
                //System.Console.WriteLine(result[k]);
            }
            OutputSignal = new Signal(result, false);
        }
    }
}

using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace KMean.ML.Objects
{
    public class FileTypePrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[] Distances;
    }
}

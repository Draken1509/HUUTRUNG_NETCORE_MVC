using BertMINET.MachineLearning.DataModel;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertMINET.MachineLearning
{
	public class Trainer
	{
		private readonly MLContext _mlContext;
		public ITransformer BuidAndTrain(string bertModelPath, bool useGpu)
		{
			var pipeline = _mlContext.Transforms
							.ApplyOnnxModel(modelFile: bertModelPath,
											outputColumnNames: new[] { "unstack:1",
																	   "unstack:0",
																	   "unique_ids:0" },
											inputColumnNames: new[] {"unique_ids_raw_output___9:0",
																	  "segment_ids:0",
																	  "input_mask:0",
																	  "input_ids:0" },
											gpuDeviceId: useGpu ? 0 : (int?)null);

			return pipeline.Fit(_mlContext.Data.LoadFromEnumerable(new List<BertInput>()));
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertMINET.Heplers
{
	public class FileReader
	{
		public static List<string> ReadFile(string filename)
		{
			var result = new List<string>();

			using (var reader = new StreamReader(filename))
			{
				string line;

				while ((line = reader.ReadLine()) != null)
				{
					if (!string.IsNullOrWhiteSpace(line))
					{
						result.Add(line);
					}
				}
			}

			return result;
		}
	}
}

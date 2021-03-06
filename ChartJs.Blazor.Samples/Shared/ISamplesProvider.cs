using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChartJs.Blazor.Samples.Shared
{
    public interface ISamplesProvider
    {
        /// <summary>
        /// Returns an enumeration of sample categories each containing their respective samples.
        /// </summary>
        Task<IEnumerable<SampleCategory>> GetSamples();
    }
}

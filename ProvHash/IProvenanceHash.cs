using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvHash
{
    public interface IProvenanceHash
    { 
        /// <summary>
        /// Generates the provenance hash, in order of name
        /// </summary>
        /// <param name="fileDirectory">File directory</param>
        /// <returns>Hash</returns>
        ProvHashResult GenerateHash(string fileDirectory);
    }
}

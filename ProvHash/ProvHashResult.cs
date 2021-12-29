using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvHash
{
    public class ProvHashResult
    {
        public string ProvHash
        {
            get
            {
                return HashUtilities.HashString(ConcateHash);
            }
        }

        public string ConcateHash
        {
            get
            {
                return string.Join(null, FileHashes.Values);
            }
        }
        public Dictionary<string, string> FileHashes { get; set; } = new Dictionary<string, string>();
    }
}

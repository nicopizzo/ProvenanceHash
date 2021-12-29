using System.Security.Cryptography;
using System.Text;

namespace ProvHash
{
    public class ProvenanceHash : IProvenanceHash
    {
        public ProvHashResult GenerateHash(string fileDirectory)
        {
            var hashResult = new ProvHashResult();
            var dirInfo = new DirectoryInfo(fileDirectory);
            var files = dirInfo.GetFiles();
            foreach(var file in files.OrderBy(f => f.Name))
            {
                var f = File.ReadAllBytes(file.FullName);
                byte[] SHA256Result = SHA256.HashData(f);
 
                var hash = HashUtilities.HashBytesToString(SHA256Result);

                hashResult.FileHashes.Add(file.Name, hash);
            }
            return hashResult; 
        }
    }
}
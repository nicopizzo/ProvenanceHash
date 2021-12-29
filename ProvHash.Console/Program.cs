
using ProvHash;

Console.WriteLine($"Creating hash of {args[0]}");

IProvenanceHash hasher = new ProvenanceHash();

var hash = hasher.GenerateHash(args[0]);

Console.ReadLine();
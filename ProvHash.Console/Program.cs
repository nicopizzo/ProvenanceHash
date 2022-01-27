
using ProvHash;

Console.WriteLine($"Creating hash of {args[0]}");

IProvenanceHash hasher = new ProvenanceHash();

var hash = hasher.GenerateHash(args[0]);

Console.WriteLine("ProvenanceHash is:");
Console.WriteLine(hash.ProvHash);
Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Concated Hash is:");
Console.WriteLine(hash.ConcateHash);

Directory.CreateDirectory("Output");
File.WriteAllText("Output/ProvHash.txt", hash.ProvHash);
File.WriteAllText("Output/ConcatHash.txt", hash.ConcateHash);
File.WriteAllLines("Output/Hashes.txt", hash.FileHashes.OrderBy(f => int.Parse(f.Key)).Select(f => $"{f.Key}\t{f.Value}"));

Console.ReadLine();
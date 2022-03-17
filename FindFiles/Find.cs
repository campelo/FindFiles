using BenchmarkDotNet.Attributes;

namespace FindFiles
{
    public class Find
    {
        [Benchmark]
        public void RepositoryOnly()
        {
            Directory.GetFiles(@"C:\FindFiles\RepositoryOnly", "*.xml", SearchOption.TopDirectoryOnly);
        }

        [Benchmark]
        public void SubRepository()
        {
            Directory.GetFiles(@"C:\FindFiles\SubRepository", "*.xml", SearchOption.AllDirectories);
        }
    }
}

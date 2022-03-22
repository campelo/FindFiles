using BenchmarkDotNet.Attributes;

namespace FindFiles
{
    public class Find
    {
        private readonly string BASE_PATH = @"C:\FindFiles\";
        private readonly string FILE_FILTER = "*.xml";

        [Benchmark]
        public void RepositoryOnly()
        {
            Directory.GetFiles($@"{BASE_PATH}RepositoryOnly", FILE_FILTER, SearchOption.TopDirectoryOnly);
        }

        [Benchmark]
        public void SubRepository()
        {
            Directory.GetFiles($@"{BASE_PATH}SubRepository", FILE_FILTER, SearchOption.AllDirectories);
        }

        [Benchmark]
        public void SubRepositoryEnumerateDirectories()
        {
            IEnumerable<string>? dirs = Directory.EnumerateDirectories($@"{BASE_PATH}SubRepository");
            foreach (string? d in dirs)
            {
                Directory.GetFiles(d, FILE_FILTER, SearchOption.TopDirectoryOnly);
            }
        }
    }
}

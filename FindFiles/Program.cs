using BenchmarkDotNet.Running;
using FindFiles;

var summary = BenchmarkRunner.Run<Find>();

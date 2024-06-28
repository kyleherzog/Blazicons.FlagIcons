using Blazicons.Generating;
using Microsoft.CodeAnalysis;
using Microsoft.VisualStudio.Threading;

namespace Blazicons.FlagIcons.Generating;

[Generator]
internal class FlagIconsGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        using var taskContext = new JoinableTaskContext();
        var taskFactory = new JoinableTaskFactory(taskContext);
        var downloader = new RepoDownloader(new Uri(Properties.Resources.DownloadAddress));
        taskFactory.Run(
            async () =>
            {
                await downloader.Download(@"^flags\/.*\.svg$").ConfigureAwait(true);
            });

        var svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "flags", "4x3");
        context.WriteIconsClass("FlagIcon4x3", svgFolder);

        svgFolder = Path.Combine(downloader.ExtractedFolder, $"{downloader.RepoName}-{downloader.BranchName}", "flags", "1x1");
        context.WriteIconsClass("FlagIcon1x1", svgFolder);

        downloader.CleanUp();
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // required by ISourceGenerator
    }
}
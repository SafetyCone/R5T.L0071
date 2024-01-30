using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.L0071
{
    /// <summary>
    /// Provides executable-directory relative /Files directory path functionality for providing paths to copied-to-output resources files.
    /// These operations implement the {Executable Directory Path}/{Files}/{Project Name}/{File Name} copied-to-output resource file methodology.
    /// </summary>
    /// <remarks>
    /// Prior work:
    /// <list type="bullet">
    /// <item>R5T.F0026.IExecutableFileRelativePathOperator</item>
    /// <item>R5T.F0042.F001.IFilesDirectoryOperator</item>
    /// <item>R5T.F0091.IFilesDirectoryOperator - Best prior work.</item>
    /// <item>R5T.F0095.IFilesDirectoryOperator</item>
    /// <item>R5T.Z0008.IFilePathOperator.GetFilesDirectoryFilePath()</item>
    /// <item>R5T.Z0052.Z001.IFilesDirectoryOperator.Get_FilesDirectoryPath()</item>
    /// </list>
    /// </remarks>
    [FunctionalityMarker]
    public partial interface IFilesDirectoryOperator : IFunctionalityMarker
    {
        public string Get_FilesDirectoryPath(string executableDirectoryPath)
        {
            var filesDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                executableDirectoryPath,
                Instances.DirectoryNames.Files);

            return filesDirectoryPath;
        }

        public string Get_FilesDirectoryPath()
        {
            var executableDirectoryPath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryPath();

            var output = this.Get_FilesDirectoryPath(executableDirectoryPath);
            return output;
        }

        public string Get_FilesDirectory_DirectoryPath(IEnumerable<string> directoryPathParts)
        {
            var directoryPath = Instances.PathOperator.Get_DirectoryPath(
                DirectoryPaths.Instance.FilesDirectoryPath,
                directoryPathParts);

            return directoryPath;
        }

        public string Get_FilesDirectory_DirectoryPath(params string[] directoryPathParts)
        {
            var directoryPath = this.Get_FilesDirectory_DirectoryPath(
                directoryPathParts.AsEnumerable());

            return directoryPath;
        }

        public string Get_FilesDirectory_FilePath(IEnumerable<string> filePathParts)
        {
            var filePath = Instances.PathOperator.Get_FilePath(
                DirectoryPaths.Instance.FilesDirectoryPath,
                filePathParts);

            return filePath;
        }

        public string Get_FilesDirectory_FilePath(params string[] filePathParts)
        {
            var filePath = this.Get_FilesDirectory_FilePath(
                filePathParts.AsEnumerable());

            return filePath;
        }

        public string Get_FilesDirectory_FilePath_ByProjectName(
            string projectName,
            string fileName)
        {
            var projectDirectoryName = Instances.DirectoryNameOperator.Ensure_IsValidDirectoryName(projectName);

            var output = this.Get_FilesDirectory_FilePath(
                projectDirectoryName,
                fileName);

            return output;
        }
    }
}

using System;


namespace R5T.T0117
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class FileGenerator : IFileGenerator
    {
        #region Static
        
        public static FileGenerator Instance { get; } = new();

        #endregion
    }
}
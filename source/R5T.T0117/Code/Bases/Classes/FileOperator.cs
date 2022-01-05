using System;


namespace R5T.T0117
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class FileOperator : IFileOperator
    {
        #region Static
        
        public static FileOperator Instance { get; } = new();

        #endregion
    }
}
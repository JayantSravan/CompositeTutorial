namespace CompositeTutorial.Components
{
    /// <summary>
    /// File class
    /// </summary>
    public class File : FileSystemItem
    {
        /// <summary>
        /// Size of the file
        /// </summary>
        private int Size { get; }

        /// <summary>
        /// File constructor
        /// </summary>
        /// <param name="name">Name of the file</param>
        /// <param name="size">Size of the file</param>
        public File(string name, int size) : base(name)
        {
            this.Size = size;
        }

        /// <inheritdoc />
        public override int GetSize()
        {
            return this.Size;
        }
    }
}

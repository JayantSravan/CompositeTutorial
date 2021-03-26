namespace CompositeTutorial.Components
{
    /// <summary>
    /// FileSystemItem class ----- Component
    /// </summary>
    public abstract class FileSystemItem
    {
        /// <summary>
        /// Name of the file system item type
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// FileSystemItem class
        /// </summary>
        /// <param name="name">name of the item</param>
        protected FileSystemItem(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Get Size of them Item -------- Common interaction method
        /// </summary>
        /// <returns></returns>
        public abstract int GetSize();
    }
}

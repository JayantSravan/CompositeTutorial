using System.Collections.Generic;

namespace CompositeTutorial.Components
{
    /// <summary>
    /// Directory class
    /// </summary>
    public class Directory : FileSystemItem
    {
        /// <summary>
        /// Sub files in the directory
        /// </summary>
        private List<FileSystemItem> Children { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        public Directory(string name) : base(name)
        {
            this.Children = new List<FileSystemItem>();
        }

        /// <inheritdoc />
        public override int GetSize()
        {
            int size = 0;

            foreach (var child in Children)
            {
                size += child.GetSize();
            }

            return size;
        }

        /// <summary>
        /// Add children to the directory
        /// </summary>
        /// <param name="fileSystemItem"></param>
        public void Add(FileSystemItem fileSystemItem)
        {
            this.Children.Add(fileSystemItem);
        }

        /// <summary>
        /// Remove items from directory
        /// </summary>
        /// <param name="fileSystemItem"></param>
        public void Remove(FileSystemItem fileSystemItem)
        {
            this.Children.Remove(fileSystemItem);
        }
    }
}

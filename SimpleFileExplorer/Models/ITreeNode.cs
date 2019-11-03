using System.Collections.Generic;

namespace SimpleFileExplorer.Models
{
    /// <summary>
    /// Represents a tree structure.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="Content"/> in the tree node.</typeparam>
    public interface ITreeNode<T>
    {
        /// <summary>
        /// Gets the content that stored in the node.j
        /// </summary>
        T Content { get; set; }                               //change to writeable    

        /// <summary>
        /// Gets parent of the current node.
        /// </summary>
        ITreeNode<T> Parent { get; set; }                  //

        /// <summary>
        /// Gets a <see cref="IEnumerable{T}"/> instance that contains all the child node of the node.
        /// </summary>
        IList<ITreeNode<T>> Children { get; }

        /// <summary>
        /// Gets the count of all descendants of the current node.
        /// </summary>
        long Count { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleFileExplorer.Models
{
    internal class TreeNode<T> : ITreeNode<T> where T : new()  //constraints
    {
        private T fileinfo;                                        //
        public TreeNode()
        {

        }

        public TreeNode(string str)
        {
            fileinfo = (T)System.Activator.CreateInstance(typeof(T), str);
            Parent=new TreeNode<T>();
        }   

       
        public T Content { get { return fileinfo; } set { fileinfo = value; } }   //

        /*
         * TIP: In this case, the type of T is FileInformation in Models folder.
         */

        public ITreeNode<T> Parent { get ;   set ; }

        public IList<ITreeNode<T>> Children
        {
            get;
            set;
        }   
        /*
         * TIP: I suggest you design TreeNode<T> class to automatically fetch Children based on it's own information, 
         * but the type of T cannot be determined when you design this class, 
         * so I suggest you use the "callback" trick. 
         * Specifically, you can implement this by delegate, abstract method and so on.
         * 
         * e.g.: 
         * 
         * 1. public Func<T, IEnumerable<T>> ChildrenProvider { ... }
         * 
         * 2. public abstract IEnumerable<T> GetChildren(T self);
         */
         public Func<T, IEnumerable<T>> ChildrenProvider { get; set; }
      

        public long Count { get; set; }
    }
    
}

        /*
         * TIP: You can count the number of descendants by recursion. 
         */
         
using SimpleFileExplorer.Commands;
using SimpleFileExplorer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimpleFileExplorer
{
  
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ITreeNode<FileInformation> _currentFileTreeNode;        //current tree node
        private List<ITreeNode<FileInformation>> _files;                //all nodes under the current node

        private ICommand _enterFolderCommand;
        private ICommand _backCommand;

        public MainWindowViewModel(ITreeNode<FileInformation> fileRoot)    //parent lost here
        {
            CurrentFileTreeNode = fileRoot;

            EnterFolderCommand = new RelayCommand<ITreeNode<FileInformation>>(Execu,
                //file => 
                //{
                //    var str2 = Directory.GetFiles(file.Content.FileName, "*", SearchOption.TopDirectoryOnly);
                //    file.Count = str2.Length;
                //    CurrentFileTreeNode = file;
                //    BuildNewItem(CurrentFileTreeNode);
                //},
                //Input parameter file
                file => file.Content.FileType == FileType.Folder);   // 如果条件成立 就执行上一句

            //BackCommand = new RelayCommand(
            //    () => CurrentFileTreeNode = _currentFileTreeNode.Parent,   // inputparameter is not needed.
            //    () => _currentFileTreeNode.Parent != null);

            //EnterFolderCommand = new RelayCommand(Enter_execute, Enter_Canexecute);
            BackCommand = new RelayCommand(Back_Command, Back_Canexecute);
            BuildNewItem(CurrentFileTreeNode);

        }
        public void Execu(ITreeNode<FileInformation> file)
        {
            var str2 = Directory.GetFiles(file.Content.FileName, "*", SearchOption.TopDirectoryOnly);
            file.Count = str2.Length;
            CurrentFileTreeNode = file;
            BuildNewItem(CurrentFileTreeNode);
        }

        private void BuildNewItem(ITreeNode<FileInformation> fileRoot)
        {
            var node = new List<ITreeNode<FileInformation>>();

            var str = Directory.GetFiles(fileRoot.Content.FileName, "*", SearchOption.TopDirectoryOnly);

            foreach (var children in str)
            {
                TreeNode<FileInformation> ii = new TreeNode<FileInformation>(children);

                ii.Content = new FileInformation(children);

                ii.Parent = CurrentFileTreeNode;  //

                node.Add(ii);
            }

            var str1 = Directory.GetDirectories(fileRoot.Content.FileName, "*", SearchOption.TopDirectoryOnly);

            #region   // Create TreeNode


            // Files.Add(childrenroot);

            foreach (var children in str1)
            {
                TreeNode<FileInformation> ii = new TreeNode<FileInformation>(children);
                ii.Content = new FileInformation(children);
                ii.Parent = CurrentFileTreeNode;
                        
                node.Add(ii);
            }                         
                                                                                                               
            #endregion

            var str2 = Directory.GetFiles(CurrentFileTreeNode.Content.FileName, "*", SearchOption.TopDirectoryOnly);
            fileRoot.Count = str2.Length;                              //why assign value to  fileRoot rather than  CurrentFileTreeNode?
            Files = node;
        }         

        public bool Enter_Canexecute()       
        {
            if (_currentFileTreeNode.Content.FileType ==FileType.Folder)
                return true;
            else
                return false;              
        }

    

        public void Back_Command()
        {
            CurrentFileTreeNode = CurrentFileTreeNode.Parent;
            BuildNewItem(CurrentFileTreeNode);
        }

        public bool Back_Canexecute()
        {
            if (CurrentFileTreeNode.Parent.Content != null)
                return true;
            else
                return false;
        }

        public IList<ITreeNode<FileInformation>> Files
        {
            get { return _files; }
            set
            {
                _files =(List<ITreeNode<FileInformation>>)value;
                OnPropertyChanged(this, new PropertyChangedEventArgs("Files"));
                //    SetProperty < List<ITreeNode<FileInformation>>>( ref _files, (List < ITreeNode < FileInformation >>) value);
            }
        }
        public void OnPropertyChanged(object sender,  PropertyChangedEventArgs e)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged.Invoke(sender, e);
            }
           
        }

        public ITreeNode<FileInformation> CurrentFileTreeNode
        {
            get { return _currentFileTreeNode; }

            //{
            //    //if(SetProperty(ref _currentFileTreeNode, value))
            //    // {
            //    //    Files = value.Children;

            //    //}
            //}
            set
            {
                _currentFileTreeNode = value;
                if(PropertyChanged!=null)
                {
                    OnPropertyChanged(this, new PropertyChangedEventArgs("CurrentFileTreeNode"));
                }
                
            }
        }

        public ICommand EnterFolderCommand
        {
            get { return _enterFolderCommand; }
            //set { SetProperty(ref _enterFolderCommand, value); }
            set
            {

                _enterFolderCommand = value;
                
            }
        }

        public ICommand BackCommand
        {
            get { return _backCommand; }
            //set { SetProperty(ref _backCommand, value); }
            set
            {
                _backCommand = value;

            }
        }
    }
}

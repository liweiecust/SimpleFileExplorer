   M S B A M L   `   `   `  ����  SimpleFileExplorer#    SimpleFileExplorer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��800��6)   .��5      �  � ColumnDefinitions 5	   
   �� 5
      $	��11* �6   �� 5      $	��13* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��20 �6   �� 5      .+�5   
   �� $��0��6   $��<<BACK��6      LinkButtonStyle#��[  6U   $��
10,10,0,10q�5      ��5   5   �� *BackCommand+5      �� 5   
   $��0��6   $
��Bold"�5      $��Center=�5      $��Right=�6/   $��
0,12,10,11q�6K   $��1��6_   ��5   !   �� *CurrentFileTreeNode.Count+ �� StringFormat$' !Current folder contains {0} files��5   _   �� 5   
    �� SelectionMode$ Extended=�6   $��0q�6+   $
��Auto=�6?      FileExplorerListBoxItemStyle#��[ 5      $��2��6U   $��2��5      ��5      �� *Files+��5      �� 5      .R�5       ��  �� Padding$ 20 10q�6   ._�5!      �  5"      �� 5#   "   $
��Auto �63   �� 5$   "   $��16 �63   �� 5%   "   $��* �63   .+�5'      �� $��0��6$     FileImageSelectorStyle#��[ 6U   $��Center=�6�   
 � Tag 64   �� *Content.FileType+6�   �� 5(      $��2��6%   #��[  6Z   $��Center=�6�   ��65   �� *Content.FileName+��5)   %   ��  �� Path$$ DataContext.EnterFolderCommand� �� RelativeSource �� 	 �� Mode$	 FindAncestor=�
 �� AncestorType$
 ListBoxL� �� AncestorLevel$ 1����5*   %   �� 5+      5,      5-      5/      50      51      
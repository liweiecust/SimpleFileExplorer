   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089    FileExplorerListBoxItemStyle  �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType'    !System.Windows.VisualStateManager    VisualStateGroups%   System.Windows.VisualStateGroup   Transitions%   System.Windows.VisualTransition   GeneratedDuration	   To	   From
   
Storyboard   GeneratedEasingFunction/  )System.Windows.Media.Animation.CircleEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode   States    System.Windows.VisualState   
Storyboard g� Duration	 W� To �� TargetProperty �� 
TargetName � RowDefinitions ��Name J� Opacity J� RenderTransformOrigin ��Name  PrimaryHueMidBrush  LightGreyBackgroundBrush J� SnapsToDevicePixels �� Triggers P� Property P� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %@  &	        7��7  7  �� 5      "  ��61   8   .�5   
   ��  � ��$ 0q�6$   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� #��z��6   #��z��6I   #��z��6}   #}�z}�6�   #��z��6�    5	        5
      CommonStates�� 5   "     5   &   $ 0:0:0.6D�6G   $ Normal��6y   	 67   Z� 
 6c   Z�  5   *     5   .   $ EaseOut=�69   5   '   . 5   "     
Normal��6.     5   "   	MouseOver��. 5   &   �� .��5   *   W� $ 0D�6:   $	 0.4X�6G   $ Opacity�6P   $ MouseOverBorder��6t   W� 5   *   $ 0D�6:   $	 0.2X�6G   $ Opacity�6P   $ PART_MouseOverRectangle��6t   5   '   5   #     5   "   Disabled��6.   5        5      SelectionStates�� 5   "     5   &   $ 0:0:0.4D�6G   	 67   Z�  6c   Z� 
 6�   Z�  6�   Z� . 5   "     Selected��. 5    &   �� .��5!   *   W� $ 0D�6:   $	 0.8X�6G   $ Opacity�6P   $ SelectedBorder��6t   W� 5"   *   $ 0D�6:   $ 1X�6G   $ Opacity�6N   $ PART_SeletedRectangle��6r   5#   '   5$   #     5%   "   
Unselected��6.     5&   "   SelectedUnfocused��. 5'   &   �� .��5(   *   W� $ 0D�6:   $	 0.8X�6G   $ Opacity�6P   $ SelectedBorder��6t   W� 5)   *   $ 0D�6:   $ 1X�6G   $ Opacity�6N   $ PART_SeletedRectangle��6r   5*   '   5+   #   5,      ._�5/      �  50      �� 51   "   �� 52   "   $
��Auto �60   .+�54      �� $ MouseOverBorder��6%   $ 0Q�6>   ���#9EA3FE6J   �� 55      $ SelectedBorder��6%   $ 0Q�6=   $ 0.5,0.5&�6I   ���#9EA3FE6i   �� 56      �� 57      $ PART_SeletedRectangle��6M   $��4��6(   $
��Left=�62   8�� $ 0Q�6�   �� 58      $ PART_MouseOverRectangle��6M   $��4��6(   $
��Left=�62   8�� $ 0Q�6�   �� 59      $��1��6%   #���  62   $��2��6j   $��Bottom=�6u   $��Stretch=�6�    . 6�   5:      5;       5<      P� 5=       � {� .  . �5>      ��  �@J�Opacity$
 0.56Q�68   5?      5A      5C      5D      5E      
   M S B A M L   `   `   `  ����J  FReportGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ReportGeneratorReportGenerator  5          ReportGenerator.Accounts   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      )localclr-namespace:ReportGenerator  5        � DataContext  5
        ReportGenerator.FacultyVM  5   
   .��5      � .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost     DialogContent 5      �� 5      $��16q�6   .+�5      �� -   5         ��Name$
 name��5   M   $��0 8 0 0q�6   $��Stretch=�6/   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��6[   �� 5      -   5         ��Name$
 role��5   �    �� DisplayMemberPath$ roleName��6=   $��0 8 0 0q�6Z   $��Stretch=�6k   $
 Role��6�   ��6   �� *roles+6�   G� 5      -   5         G�Name$ password��5   @   $��Stretch=�6"   $��0 8 0 0q�6R   $ Password��6c   �� 5       �� Orientation$ 
Horizontal=�6!   $��Right=�6:   .+�5      �� -   5         ��Name$ Accept��5   !      MaterialDesignFlatButton#��[  61   	 �� 	IsDefault	 . $��0 8 8 0q�5   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5   )   .��5   6   ADD5      �� 5      #��[  6!   
 �� IsCancel
 . $��0 8 8 0q�5   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5   )   .��6`   CANCEL5!      5"      5#      .��5'      #  MaterialDesignThemes.Wpf.Card  $��5,5,5,5q�6"   $
��auto��63   $��Stretch=�6A   $��Stretch=�6_   $
��auto��6{   .��5(      � .+�5)      &   System.Windows.Controls.DataGrid  -   5          Name$ dg��5)         CanUserAddRows .     CanUserReorderColumns .     AutoGenerateColumns .  $��Stretch=�6�   $
��auto��6�   $��Stretch=�6�   $
��auto��6�     6`   �� *	faculty+��6�   ��    Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *id+6H     5,      $
 Name��6J    61   �� *name+6J     5-      $
 Role��6O    61   �� *	Role.role+6O     5.      $ 	Undergrad��6O    61   �� *	undergrad+6O     5/      $
 Year��6S    61   �� *undergradYear+6S     50      $ Postgrad��6N    61   �� *
postgrad+6N     51      $
 Year��6R    61   �� *postgradYear+6R     52      $ Expected Year��6Z    61   �� *postgradExpectedYear+6Z   55      '	  !MaterialDesignThemes.Wpf.PopupBox	  57       - )MaterialDesignMultiFloatingActionPopupBox#��[ 6.    	  PlacementMode$ TopAndAlignCentres=�58   *   $��45��6M   $��44��6X    ^� 	Placement$ Right=�59   *   $��	0,0,10,10q�6K   $��Right=�5:   *   $��Bottom=�6F    	  PopupContent. 5;      �� .+�5<      �� -   5        $ btnAdd��5<   %      OpenDialogCommand#��Z 65    + 'MaterialDesignFloatingActionLightButton#���  6v    � ToolTip$	 Add��6�   $ Right=�6�   $��35��6�   $��34��6�   $��	0,0,10,10q�6�   $��30(�6  $
��Bold"�6  .��5=   "   '
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ LibraryPlus=�6:   $��20��6M   $��20��6X   5>      �� 5?      -   5        $ 	btnDelete��5?   %   #���  6P   $ Delete��6�   $ Right=�6�   $��35��6�   $��34��6�   $��	0,0,10,10q�6�   $��30(�6�   $
��Bold"�6�   .��5@   "   
  $ Delete=�6:   $��20��6H   $��20��6S   5A      5B      5C      5D      5E      5F      5G      5H      
   M S B A M L   `   `   `  ����J  FReportGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ReportGeneratorReportGenerator  5          ReportGenerator.Seminars   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ReportGenerator     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��auto��5
      $
��auto��6   $��Stretch=�5      $��Stretch=�6,     � DataContext  5      "  ReportGenerator.AttendanceVM  5   
   .��5      � .+�5   
   )  #MaterialDesignThemes.Wpf.DialogHost  -   5           DialogContent 5      �� 5      $��16q�6   .+�5      �� -   5         ��Name$ 	seminarCB��5   �    �� DisplayMemberPath$ seminarName��6n    �� 
IsEditable . $��0 8 0 0q�6�   $��Stretch=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Seminar Name��6�   ��6M   �� *
Seminars+6�   �� 5      -   5        $ classCB��5   �   $ classification��6G   $��0 8 0 0q�6j   $��Stretch=�6{   $ Seminar Classification��6�   ��6   �� *classifications+6�   �� 5      -   5        $ typeCB��5   �   $
 type��6=    . $��0 8 0 0q�6h   $��Stretch=�6y   $ Seminar Type��6�   ��6   �� *types+6�   �� 5      -   5         ��Name$ venueTB��5   M   $��0 8 0 0q�6   $��Stretch=�6/   $ Venue��6^   �� 5      -   5        $ dateTB��5   M   $��0 8 0 0q�6   $��Stretch=�6/   $
 Date��6]   �� 5      -   5         ��Name$ delete��5   +   $
��Test��6   6+   �� 5       �� Orientation$ 
Horizontal=�6!   $��Right=�6:   .+�5      �� -   5        	 ��Name$	 Accept��5   !      MaterialDesignFlatButton#��[  61   
 �� 	IsDefault
 . $��0 8 8 0q�5   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5   )   .��5   6   ADD5!      �� 5"      -	   5        #��[  5"   !    �� IsCancel . $��0 8 8 0q�5$   )   $2��,materialDesign:DialogHost.CloseDialogCommand��5%   )   .��5&   6   CANCEL5(      5)      5*      .��5.      #  MaterialDesignThemes.Wpf.Card  $��5,5,5,5q�6"   $
��auto��63   $��Stretch=�6A   $��Stretch=�6_   $
��auto��6{   .��5/      � .+�50      &   System.Windows.Controls.DataGrid  -
   5          Name$ dg��50         CanUserAddRows .     CanUserReorderColumns .     AutoGenerateColumns .  $��Stretch=�6�   $
��auto��6�   $��Stretch=�6�   $
��auto��6    6`   �� *specificAttendances+��6�   ��    Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *
seminar.id+6P     53      $ Seminar��6Y    61   �� *seminar.seminarName+6Y     54      $
 Type��6W    61   �� *seminar.type.type+6W     55      $ Classification��6k    61   �� *'%seminar.classification.classification+6k     56      $ Venue��6S    61   �� *seminar.venue+6S     57      $
 Date��6R    61   �� *seminar.date+6R   5:      '	  !MaterialDesignThemes.Wpf.PopupBox	  5<       - )MaterialDesignMultiFloatingActionPopupBox#��[ 6.    	  PlacementMode$ TopAndAlignCentres=�5=   *   $��45��6M   $��44��6X    ^� 	Placement$ Right=�5>   *   $��	0,0,10,10q�6K   $��Right=�5?   *   $��Bottom=�6F    	  PopupContent. 5@      �� .+�5A      �� -   5        $	 btnAdd��5A   %      OpenDialogCommand#��Z 6J    + 'MaterialDesignFloatingActionLightButton#���  6�    � ToolTip$	 Add��6�   $ Right=�6�   $��35��6�   $��34��6  $��	0,0,10,10q�6  $��30(�6&  $
��Bold"�64  .��5B   "   '
  !MaterialDesignThemes.Wpf.PackIcon
  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ LibraryPlus=�6:   $��20��6M   $��20��6X   5C      �� 5D      -   5        $	 btnEdit��5D   %   #��Z 6L   #���  6�   $
 Edit��6�   $ Right=�6�   $��35��6�   $��34��6
  $��	0,0,10,10q�6  $��30(�6)  $
��Bold"�67  .��5E   "   
  $ Pencil=�6:   $��20��6H   $��20��6S   5F      �� 5G      -   5        $	 	btnDelete��5G   %   #��Z 6P   #���  6�   $ Delete��6�   $ Right=�6�   $��35��6  $��34��6  $��	0,0,10,10q�6  $��30(�6/  $
��Bold"�6=  .��5H   "   
  $ Delete=�6:   $��20��6H   $��20��6S   5I      5J      5K      5L      5M      5N      5O      5P      
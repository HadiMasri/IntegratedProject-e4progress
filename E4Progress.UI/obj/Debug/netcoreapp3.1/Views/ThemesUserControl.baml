   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5      C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5      H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
      +   %E4Progress.UI.Views.ThemesUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:UIUtil;assembly=UIUtil  5      8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	      0resx#clr-namespace:E4Progress.UI.Strings  	 5
      -   5        !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5        E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5      
������� � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.3.��5      � $��Stretch=�6   $	��Top=�62    � ColumnDefinitions 5      �� 5      $	��300��6'   68   �� 5      $	��300��6'   69    � RowDefinitions 5      �� 5      $	��800��6$   5      .+�5       � $��80q�6   ���#4A5464$��0��6>   $��0��6N   .+�5!      )  #MaterialDesignThemes.Wpf.DialogHost  -   5        	  Name$	 
DialogHost��5!   f     MaterialDesignDivider#���  60   
   DialogContent
 5"      �� 5#      $��16q�5$      .+�5%   "   �� $��Center=�6,   Theme5'   #   �� 5(   "   -   5         ��Name$ ThemeTextBox��5+   	   $��0 8 0 0q�5)   	   $��Stretch=�5*   	   5+   	   �� 5,   "    �� Orientation$ 
Horizontal=�5-   	   $��Right=�5.   	   .+�5/   &   �� -   5         ��Name$ addBtn��5/   -     MaterialDesignFlatButton#��[ 50      .��6=   ADD52   '   �� 53   &   -   5        $ editBtn��53   -   #��[ 54      .��6=   Edit56   '   �� 57   &   #��[ 58       �� IsCancel$
 True��59      $��0 8 8 0q�5:      $2��,materialDesign:DialogHost.CloseDialogCommand��5<      ��5=   *   O
 Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem
 5>   =   ��6.   5system&clr-namespace:System;assembly=mscorlib  	 6=   	False��5@   /   .��5A   C   CANCEL5C   '   5D   #   5E      .��5G      #	  MaterialDesignThemes.Wpf.Card	  
���   �.��5I      �� ���#2E333A.+�5J      ��  �� Padding$ 10q�6(   $��35(�5K      $
��Bold"�5L      
����������#2E333A $  MaterialDesignHeadline5TextBlock#��[ 5M      Themas5O      �� 5P   "   -   5         ��Name$ 
lbTodoList��5P   ?   ���#697280$��Stretch=�6S   $��Visible=�6x   $��Stretch=�6�   $��Stretch=�6�   $	��508��6�   ��5Q   "   �� 5R   &   .R�5S   .   �  5T   2   �� 5U   6   $��4* �6G   6T   �� 5V   6   $��1* �6G   6T   �� 5W   6   $��1* �6G   6T   .+�5Y   2   �� 
�������$
��Bold"�6O   $��30(�6b   $��0��6p   ��6�   �� *Name+�� 5[   2   -   5        $��Stretch=�5[   i   $��Right=�6�   $��2��6�   
������� * &MaterialDesignFloatingActionMiniButton#��[ 5\       � ToolTip$( "MaterialDesignFloatingActionButton��5]      
 � Tag 5[   ;   �� *Id+.��5^   6   '
  !MaterialDesignThemes.Wpf.PackIcon
   
  Kind$ TrashCan=�5_      $��24��5`      $��24��5a      5b   3   5c   /   5e   +   5g      �� 5h      $ 
Horizontal=�6*   $��Center=�6C   .+�5i   &   �� -	   5        $��10q�5i   .      OpenDialogCommand#��Z 6:   $��Center=�6�    & "MaterialDesignFloatingActionButton#��[ 5j      $( "MaterialDesignFloatingActionButton��5k      .��5l   &   
  $
 Plus=�5m      $��24��5n      $��24��5o      5p   #   �� 5r   &   -
   5        $��10q�5r   .   $��Right=�6O   $��1��6k   #��[ 5s      $( "MaterialDesignFloatingActionButton��5t      .��5u   *   
  $
 Edit=�5v      $��24��5w      $��24��5x      5y   '   5|   #   5}      5      5�      5�      � 5�      $��80q�6   $	��400��6%   $	��600��65   $��Stretch=�6E   $��Stretch=�6c   ���#4A5464$��1��6�   .+�5�      	  
���   �.��5�      �� ���#2E333A.+�5�      �� $ 10q�6(   $��35(�5�      $
��Bold"�5�      
����������#2E333A#��[ 5�      	Questions5�      �� 5�      -   5        $ vragenlijst��5�   ;   ���#697280$��Stretch=�6P   $��Visible=�6u   $��Stretch=�6�   $��Stretch=�6�   $	��508��6�   ��5�   "   �� 5�   &   .R�5�   *   �  5�   .   �� 5�   2   $��4* �6C   6P   �� 5�   2   $��1* �6C   6P   �� 5�   2   $��1* �6C   6P   .+�5�   .   �� 
�������$
��Bold"�6K   $��30(�6^   $��0��6l   ��6}   �� *Title+5�   +   5�   '   5�      5�      5�      5�      5�      5�      5�      5�      
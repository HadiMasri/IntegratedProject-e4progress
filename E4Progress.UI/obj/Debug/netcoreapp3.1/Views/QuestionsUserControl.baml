   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5      C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5      H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
      .   (E4Progress.UI.Views.QuestionsUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      4	converter$clr-namespace:UIUtil;assembly=UIUtil  5      8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	      0resx#clr-namespace:E4Progress.UI.Strings  	 5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5        E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5       � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � 
�������.+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration 0:0:0.3.��5      �  � RowDefinitions 5      �� 5      $��90 �6$   �� 5      $
��610* �6$   �� 5      $	��60* �6$   .+�5      � $��0��6   $��10q�6$   .+�5      �� .+�5      �  � ColumnDefinitions 5      �� 5   "   �� 5    "   �� 5!   "   �� 5"   "   �� 5#   "   �� 5$   "   �� 5%   "   .+�5(      �� $��0��6%   $
��0 10q�65   ._�5)      �� -   5        $��titleTxt��5)   R     MaterialDesignTextBox#��[ 6�   	 �� TextWrapping$
	 Wrap=�6"  )  #MaterialDesignThemes.Wpf.HintAssist
   Hint
 6�   �� *Title+ �� 	Converter# [   �� Mode$ TwoWay=�6"  5*      �� 5+      $��1��6%   $��10q�65   ._�5,   "   �� -   5        $��questionTypeCombo��5,   a    �� SelectedValuePath$ QuestionTypeId��6�    �� DisplayMemberPath$ Translation��6�     MaterialDesignComboBox#��[ 6�    �� SelectedValue 6z   �� *QuestionTypeId+
 6  �� *QuestionType+# [  $ TwoWay=�5-      �� 5.      $��2��6%   $��10q�65   ._�5/   "   �� -   5        $��officeApplicationCombo��5/   f   #��[ 6�   $
 Name��6^   6�   �� *Office_ApplicationId+
 6�   �� *OfficeApplication+# [  $ TwoWay=�6^  50      �� 51      $��3��6%   $��10q�65   ._�52   "   �� -   5        $��instructionLanguageCombo��52   �   $ 
LanguageId��6�   $ Translation��6�   #��[ 6�    6h   �� *
LanguageId+
 6  �� *InstructionLanguage+# [  $ TwoWay=�53      �� 54      $��4��6%   $��10q�65   ._�55   "   �� -   5        $��userLanguageCombo��55   �   $ 
LanguageId��6�   $ Translation��6�   #��[ 6�    6a   �� *
LanguageId+
 6  �� *UserInterfaceLanguage+# [  $ TwoWay=�56      �� 57      $��5��6%   $��10q�65   ._�58   "   �� -   5        $��noteTxt��58   x   #��[ 6�   $
	 Wrap=�6#  
 6�   �� *Note+# [  $ TwoWay=�6#  59      �� 5:      $��6��6%   $��10q�65   ._�5;   "   �� -   5          MaterialDesignFlatButton#��[ 5;   )   
���������6�   �� *Reset+# [  $ TwoWay=�5<      5=      5>      5?      � 5A      $��1��6   $	��610��6$   .+�5B      &	   System.Windows.Controls.DataGrid	  -	   5         	 Name$ questionDataGrid��5B       	  AutoGenerateColumns$ False��6:    	  
IsReadOnly$
 True��6W    	  SelectionMode$ Single=�6i    	  SelectionUnit$ FullRow=�6�   $��14(�6�   
���   �$
��True��6�    	  Columns 5C      1
  +MaterialDesignThemes.Wpf.DataGridTextColumn
  5D      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 190 6@    �� TextAlignment$ Center=�6L      Header$ Title��6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6}   �� *Title+
  5E      $	 180 6@   $ Center=�6L   $ Question Type��6m    6�   �� *QuestionTypeName+
  5F      $	 190 6@   $ Center=�6L   $ Office Application��6m    6�   �� *OfficeApplicationName+
  5G      $	 190 6@   $ Center=�6L   $ Instruction Language��6m    6�   �� *InstructionLanguageName+
  5H      $	 190 6@   $ Center=�6L   $ User Interface Language��6m    6�   �� *UserInterfaceLanguageName+
  5I      $	 190 6@   $ Center=�6L   $
 Note��6m    6|   �� *Notes+ � ContextMenu 5K      �� 5L      .@�5M   "   m� -
   5         m�Name$ itemNew��5M   +   ��6<   �� *New+# [  $ TwoWay=� m� Icon 5N   &   �� 5O   *   $��../Assets/new.png��60   5Q   #   m� 5R   "   -   5        $ 
itemUpdate��5R   +   ��6?   �� *	Details+# [  $ TwoWay=� 5S   &   �� 5T   *   $��../Assets/details.png��60   5V   #   m� 5W   "   -   5        ��5W   ,   �� *Delete+# [  $ TwoWay=� 5X   &   �� 5Y   *   $��../Assets/delete.png��60   5[   #   5\      5^      5_      � 5a      $��2��6   $��Bottom=�6$   .+�5b      ��  �� Orientation$ 
Horizontal=�6!   $��Right=�6:   $��0 10 0 0q�6V   .+�5c      �� $��13(�6}   $��Center=�6�   ��6    �� *RowsPerPage+# [  $ TwoWay=�6�   �� 5d      -   5         ��Name$ CbNumberOfRows��5d   #   #��[ 6;   $��25 0 0 5q�6k   $��70��6~   $��	0 10 10 0q�6�   6�   �� 5e      -   5         ��Name$ BtnFirst��5e   !    & "MaterialDesignFloatingActionButton#��[ 63   $��0 0 10 0q�6o   $��30��6�   $��30��6�   .��5f      '  !MaterialDesignThemes.Wpf.PackIcon      Kind$  	FirstPage=�66   ! � Cursor$
! Hand��6G   5g      �� 5h      -   5        $ BtnPrev��5h   !   #��[ 62   $��0 0 10 0q�6n   $��30��6�   $��30��6�   .��5i        $  NavigateBefore=�66   $
! Hand��6L   5j      �� 5k      -   5        " ��Name$" TxtPageInfo��5k   $   $�� ��69   $��10q�6A   �� 5l      -   5        $ BtnNext��5l   !   #��[ 62   $��0 0 10 0q�6n   $��30��6�   $��30��6�   .��5m        $  NavigateNext=�66   $
! Hand��6J   5n      �� 5o      -   5        $ BtnLast��5o   !   #��[ 62   $��0 0 10 0q�6n   $��30��6�   $��30��6�   .��5p        $  LastPage=�67   $
! Hand��6G   5q      5r      5s      5u      5v      5w      5x      
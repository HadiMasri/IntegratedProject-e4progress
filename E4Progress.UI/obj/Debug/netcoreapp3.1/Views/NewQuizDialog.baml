   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5   	   H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
   	   '   !E4Progress.UI.Views.NewQuizDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4	converter$clr-namespace:UIUtil;assembly=UIUtil  5   	   8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5   	   S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	   	   0resx#clr-namespace:E4Progress.UI.Strings  	 5
   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5   	     E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5   	    � Title$ NewQuizDialog��5   	   $	��639��6   $
��1127��6,    � AllowsTransparency$
 True��69    � WindowStartupLocation$ CenterScreen=�6S   
������  � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � -   5        	 �Name$	 Window��5      
������ $��	0,26,0,10q�65   
 J� Effect
 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6      	Direction$ 0Q�6.      RenderingBias$ Quality=�6<      ShadowDepth$ 1Q�6T      Color$
 Gray��6d   .+�5   
   �� $��	21,0,21,0q�6   .+�5      ��  �� CornerRadius$ 2��6   $	��594��6&   ._�5      � 
�������$��0,0,0,10q�6*   .+�5      � $��	0,0,480,0q�6   .+�5      �� -   5         ��Name$ Header��5   $    �� TextAlignment$ Center=�6�   $��25(�6�   $��	0,0,0,271q�6�   ��64   �� *CreateNewQuiz+ �� 	Converter# [   �� Mode$ TwoWay=�6�   �� 5      -   5         ��Name$ PickerOffice��5   w   $��33��6#    �� DisplayMemberPath$
 Name��6^   $��15(�6�     MaterialDesignComboBox#��[ 6�   $��10,56,321,0q�6E  $	��Top=�6Z   �� SelectedValue 6/   �� *Office_ApplicationId+)  #MaterialDesignThemes.Wpf.HintAssist   Hint 6�   �� *OfficeApplication+# [  $ TwoWay=�6Z  �� 5      -   5        $��PickerInstructionLanguage��5   �    �� SelectedValuePath$ 
LanguageId��6H   $ Translation��6g   $��33��6�   $��15(�6�   #��[ 6�   $��316,56,29,0q�6n  $	��Top=�6�   6#   �� *
LanguageId+ 6�   �� *InstructionLanguage+# [  $ TwoWay=�6�  �� 5      -   5        $ PickerUILanguage��5   �   $��38��6#   $ 
LanguageId��6T   $ Translation��6s   $��15(�6�   #��[ 6�   $��10,127,321,0q�6i  $	��Top=�6   6/   �� *
LanguageId+ 6�   �� *UserInterfaceLanguage+# [  $ TwoWay=�6  �� 5       -   5         ��Name$ 	TextTitle��5    N   $��15(�6a    % !MaterialDesignFloatingHintTextBox#��[ 6o   $��316,110,29,419q�6   6�   �� *Title+# [  $ TwoWay=�6  �� 5!      -   5        $ TextShortIntro��5!   "   $��15(�6:   #��[ 6H   $��10,272,29,243q�6�    6�   �� *
ShortIntro+# [  $ TwoWay=�6�   �� 5"      -   5        $ 	TextIntro��5"   "   $��15(�65   #��[ 6C    �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn$
 True��6   " �� VerticalScrollBarVisibility$
 Auto=�6  $
��auto��68  $��10,432,29,68q�6F   J� RenderTransformOrigin$ 0.492,0.652&�6\   6~   �� *Intro+# [  $ TwoWay=�6\  �� 5#      -	   5        $ TextMinScore��5#   "   $��15(�68   #��[ 6F   $��10,194,321,328q�6�    6�   �� *
MinScore+# [  $ TwoWay=�6�   �� 5%      $��316,200,29,328q�6!      
HelperText$ Duration��69   ._�5&      �   � ColumnDefinitions  5'   "   �� 5(   &   �� 5)   &   �� 5*   &   .+�5,      �� -
   5        $ 	TextHours��5,   a   $��0��6&   $��15(�6t   #��[ 6�   $ HH��6�   $��0 0 10 0q�6�   �� 5-      -   5        $ TextMinutes��5-   a   $��1��6&   $��15(�6v   #��[ 6�   $ MM��6�   $��0 0 10 0q�6�   �� 5.      -   5        $ TextSeconds��5.   a   $��2��6&   $��15(�6v   #��[ 6�   $ SS��6�   5/      50      �� 52      -   5        $ TextIdentificationCode��52   "   $��15(�6B   #��[ 6P   $��10,346,29,178q�6�    6�   �� *IDCode+# [  $ TwoWay=�6�   �� 53      -   5        ! ��Name$! ButtonReturn��53   !     MaterialDesignFlatButton#��[ 67   
�������$��316,542,175,10q�6�   ��6�   �� *Cancel+# [  $ TwoWay=�6�   �� 54      -   5        $! ButtonConfirm��54   !   #��[ 68   
�������$��446,542,45,10q�6�   ��6�   �� *Save+# [  $ TwoWay=�6�   55      � 57      $��	605,0,0,0q�6   .+�58      �� $ 	20 0 0 20��6!   ��59      �� 5:   "   " �� ImageSource$" ../Assets/e4p.jpg��6-   # j� Stretch$
# Fill=�6M   5<      5=      5>      5?      5@      5B      5C      